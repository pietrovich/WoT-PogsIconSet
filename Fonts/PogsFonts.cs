﻿using System.Collections.Generic;

namespace WotPogsIconSet.Fonts
{
    public class PogsFont : Dictionary<char, int[][]> { }

    public abstract class PogsFonts
    {
        public static readonly PogsFont font3 = new PogsFont
        {
            {'0', new int[][] {
            new int[] {1, 1, 1},
            new int[] {1, 0, 1},
            new int[] {1, 0, 1},
            new int[] {1, 0, 1},
            new int[] {1, 1, 1},
            }},
            {'1', new int[][] {
            new int[] {1, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            }},
            {'2', new int[][] {
            new int[] {1, 1, 1},
            new int[] {0, 0, 1},
            new int[] {1, 1, 1},
            new int[] {1, 0, 0},
            new int[] {1, 1, 1},
            }},
            {'3', new int[][] {
            new int[] {1, 1, 1},
            new int[] {0, 0, 1},
            new int[] {0, 1, 1},
            new int[] {0, 0, 1},
            new int[] {1, 1, 1},
            }},
            {'4', new int[][] {
            new int[] {1, 0, 1},
            new int[] {1, 0, 1},
            new int[] {1, 1, 1},
            new int[] {0, 0, 1},
            new int[] {0, 0, 1},
            }},
            {'5', new int[][] {
            new int[] {1, 1, 1},
            new int[] {1, 0, 0},
            new int[] {1, 1, 1},
            new int[] {0, 0, 1},
            new int[] {1, 1, 1},
            }},
            {'6', new int[][] {
            new int[] {1, 1, 0},
            new int[] {1, 0, 0},
            new int[] {1, 1, 1},
            new int[] {1, 0, 1},
            new int[] {1, 1, 1},
            }},
            {'7', new int[][] {
            new int[] {1, 1, 1},
            new int[] {0, 0, 1},
            new int[] {0, 0, 1},
            new int[] {0, 0, 1},
            new int[] {0, 0, 1},
            }},
            {'8', new int[][] {
            new int[] {1, 1, 1},
            new int[] {1, 0, 1},
            new int[] {1, 1, 1},
            new int[] {1, 0, 1},
            new int[] {1, 1, 1},
            }},
            {'9', new int[][] {
            new int[] {1, 1, 1},
            new int[] {1, 0, 1},
            new int[] {1, 1, 1},
            new int[] {0, 0, 1},
            new int[] {0, 0, 1},
            }},
            {'_', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {0},
            }},

            {'-', new int[][] {
            new int[] {0,0},
            new int[] {0,0},
            new int[] {1,1},
            new int[] {0,0},
            new int[] {0,0},
            }},

            {'.', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {1},
            }},

            {' ', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {0},
            }},

     /*       {'x', new int[][] {
            new int[] {0,0,0},
            new int[] {1,0,1},
            new int[] {0,1,0},
            new int[] {1,0,1},
            new int[] {0,0,0},
            }},*/

            {'*', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {1},
            new int[] {0},
            new int[] {0},
            }},
            {'\xb7', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {1},
            new int[] {0},
            new int[] {0 },
            }},
        };

        public static readonly PogsFont font4 = new PogsFont
        {
            {'_', new int[][] {
            new int[] {0, 0},
            new int[] {0, 0},
            new int[] {0, 0},
            new int[] {0, 0},
            new int[] {0, 0},
            }},
            {'0', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'1', new int[][] {
            new int[] {1, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            }},
            {'2', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            }},
            {'3', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'4', new int[][] {
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            }},
            {'5', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'6', new int[][] {
            new int[] {1, 1, 1, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'7', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            }},
            {'8', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'9', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            }},
            {'-', new int[][] {
            new int[] {0, 0, 0},
            new int[] {0, 0, 0},
            new int[] {1, 1, 1},
            new int[] {0, 0, 0},
            new int[] {0, 0, 0},
            }},
            {'.', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {0},
            new int[] {1},
            }},
            {' ', new int[][] {
            new int[] {0, 0},
            new int[] {0, 0},
            new int[] {0, 0},
            new int[] {0, 0},
            new int[] {0, 0},
            }},
            {'a', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            }},
            {'b', new int[][] {
            new int[] {1, 1, 1, 1, 0},
            new int[] {1, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 0},
            new int[] {1, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 0},
            }},
            {'c', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            }},
            {'d', new int[][] {
            new int[] {1, 1, 1, 0},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 0},
            }},
            {'e', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            }},
            {'f', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            }},
            {'g', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'h', new int[][] {
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            }},
            {'i', new int[][] {
            new int[] {1},
            new int[] {1},
            new int[] {1},
            new int[] {1},
            new int[] {1},
            }},
            {'j', new int[][] {
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},

            {'k', new int[][] {
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 1, 0},
            new int[] {1, 1, 0, 0},
            new int[] {1, 0, 1, 0},
            new int[] {1, 0, 0, 1},
            }},

            {'l', new int[][] {
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            }},
            {'m', new int[][] {
            new int[] {1, 1, 1, 1, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            }},
            {'n', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            }},
            {'o', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'p', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 0, 0, 0},
            }},
            {'q', new int[][] {
            new int[] {1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 1, 1, 1, 1},
            new int[] {0, 0, 1, 0, 0},
            }},
            {'r', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 1, 0},
            new int[] {1, 0, 0, 1},
            }},
            {'s', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'t', new int[][] {
            new int[] {1, 1, 1, 1, 1},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            }},
            {'u', new int[][] {
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'v', new int[][] {
            new int[] {1, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 1},
            new int[] {0, 1, 0, 1, 0},
            new int[] {0, 0, 1, 0, 0},
            }},
            {'w', new int[][] {
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 1, 1, 1, 1},
            }},
            {'x', new int[][] {
            new int[] {1, 0, 0, 0, 1},
            new int[] {0, 1, 0, 1, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 1, 0, 1, 0},
            new int[] {1, 0, 0, 0, 1},
            }},
            {'y', new int[][] {
            new int[] {1, 0, 0, 0, 1},
            new int[] {0, 1, 0, 1, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            }},
            {'z', new int[][] {
            new int[] {1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 1, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 1, 0, 0, 0},
            new int[] {1, 1, 1, 1, 1},
            }},
            {'(', new int[][] {
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {1, 0},
            new int[] {1, 0},
            new int[] {0, 1},
            }},
            {')', new int[][] {
            new int[] {1, 0},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {1, 0},
            }},
            {'\xf6', new int[][] {
            new int[] {0, 1, 0, 1}, // oumlaut
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'\xe4', new int[][] {
            new int[] {1, 1, 1, 1}, // aumlaut
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
            {'\u0442', new int[][] {
            new int[] {1, 1, 1, 1, 1}, // russian T
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 0, 1, 0, 0},
            }},
            {'/', new int[][] {
            new int[] {0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 1, 0},
            new int[] {0, 0, 1, 0, 0},
            new int[] {0, 1, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0},
            }},
            {'*', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {1},
            new int[] {0},
            new int[] {0},
            }},
            {'\xb7', new int[][] {
            new int[] {0},
            new int[] {0},
            new int[] {1},
            new int[] {0},
            new int[] {0 },
            }},
            {'š', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 1, 1},
            new int[] {0, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            }},
             {'á', new int[][] {
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 1, 1, 1},
            new int[] {1, 0, 0, 1},
            new int[] {1, 0, 0, 1},
            }},
        };

        public static readonly PogsFont fontNumbers = new PogsFont
        {
            {'0', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1}
            }},

            {'1', new int[][] {
            new int[] {1, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            new int[] {0, 1},
            }},

            {'2', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 0},
            new int[] {1, 1, 1, 1, 1, 1},
            }},

            {'3', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            }},

            {'4', new int[][] {
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            }},

            {'5', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 0},
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            }},

            {'6', new int[][] {
            new int[] {1, 1, 1, 1, 1, 0},
            new int[] {1, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 0},
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            }},

            {'7', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1, 0},
            new int[] {0, 0, 0, 0, 0, 1, 0},
            new int[] {0, 0, 0, 0, 0, 1, 0},
            new int[] {0, 0, 0, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1, 0},
            new int[] {0, 0, 0, 0, 0, 1, 0},
            new int[] {0, 0, 0, 0, 0, 1, 0},
            }},

            {'8', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            }},

            {'9', new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 0, 0, 0, 0, 1},
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] {0, 0, 0, 0, 0, 1},
            new int[] { 0, 0, 0, 0, 0, 1},
            }},
        };
    }
}
