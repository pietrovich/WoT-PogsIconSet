﻿using Phobos.WoT;
using System.Collections.Generic;
using System.IO;
using WotPogsIconSet.Layers;

namespace WotPogsIconSet
{
    public class IconSet
    {
        /// <summary>
        /// Used for adding diferent layers to icon generated by this set.
        /// Example: first set generate only basic image, with background and tank namm. 
        ///     In other versions, you can add different layouts of stats.
        /// </summary>
        protected IList<IconSet> Versions;


        /// <summary>
        /// Callback that draws current icon set
        /// </summary>
        protected IList<Layer> Layers;

        
        /// <summary>
        /// Name of this set for configuration
        /// </summary>
        public string Name { get; protected set; }


        /// <summary>
        /// Full name of set, when is rendered
        /// </summary>
        public string FullName { get; protected set; }

        /// <summary>
        /// Output path for icons
        /// </summary>
        public string OutputPathIcon { get; protected set; }

        /// <summary>
        /// Output path for atlases
        /// </summary>
        public string OutputPathAtlas { get; protected set; }

        public IconSet(string name)
        {
            Name = name;
            Versions = new List<IconSet>();
            Layers = new List<Layer>();
        }

        public void SetOutputPath(string path, string fullName)
        {
            OutputPathIcon = Path.Combine(path, "icons");
            OutputPathAtlas = Path.Combine(path, "atlases");
            Directory.CreateDirectory(OutputPathIcon);
            Directory.CreateDirectory(OutputPathAtlas);
            FullName = fullName;
        }

        /// <summary>
        /// Generate icon file based on given stats and parent icon, if set.
        /// </summary>
        /// <param name="tankStats"></param>
        /// <param name="parentPath"></param>
        /// <returns>Output path to icon file.</returns>
        public string Generate(TankStats tankStats, string parentPath = null)
        {
            string outputFile = Path.Combine(OutputPathIcon, tankStats.FileName);

            // create / load icon file
            using (Icon icon = parentPath == null ? new Icon() : new Icon(parentPath))
            {
                // aply layers
                foreach (Layer layer in Layers)
                {
                    icon.Apply(layer, tankStats);
                }

                // save to file
                icon.Save(outputFile);
            }

            return outputFile;
        }

        /// <summary>
        /// Add new layer
        /// </summary>
        public void addLayer(Layer layer)
        {
            Layers.Add(layer);
        }

        /// <summary>
        /// Return list of layers for this set
        /// </summary>
        public IList<Layer> getLayers()
        {
            return new List<Layer>(Layers);
        }

        /// <summary>
        /// Add new version for this set
        /// </summary>
        public void addVersion(IconSet version)
        {
            Versions.Add(version.Clone());
        }

        /// <summary>
        /// Return list of versions for this set
        /// </summary>
        public IList<IconSet> getVersions()
        {
            return new List<IconSet>(Versions);
        }


        /// <summary>
        /// Clone current IconSet, allow it to be used as child in other parent.
        /// Also clone all it's versions.
        /// </summary>
        protected IconSet Clone()
        {
            IconSet clone = new IconSet(Name);
            clone.OutputPathIcon = null;
            clone.Layers = new List<Layer>(Layers);

            // clone all versions
            foreach (IconSet version in Versions)
            {
                clone.Versions.Add(version.Clone());
            }

            return clone;
        }
    }
}
