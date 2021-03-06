﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    class DrawGame
    {
        private int[][] Tiles;
        private Random rd;
        public DrawGame(int[][] tiles)
        {
            //Inject dependency
            Tiles = tiles;
            rd = new Random();
        }
        public int[][] WriteDefault()
        {
            //Write default selection before game start
            int pxPrev, pyPrev;
            for (int i = 0; i < 2; i++)
            {
                int px = rd.Next(0, 4);
                int py = rd.Next(0, 4);
                pxPrev = px;
                pyPrev = py;
                if (Tiles[px][py] == 0)
                {
                    Tiles[px][py] = rd.Next(0, 20) == 0 ? rd.Next(0, 15) == 0 ? 8 : 4 : 2;

                }
            }

            return Tiles;
        }
        public void writeTiles(int[][] tiles)
        {
            //Clear the console
            Console.Clear();
            //Then write again
            Console.WriteLine("Instructions.");
            Console.WriteLine("=================");
            Console.WriteLine("{0}", "Press the Escape (Esc) key to quit:");
            Console.WriteLine("Press enter button to start");
            Console.WriteLine("Press Up button to move up");
            Console.WriteLine("Press Down button to move down ");
            Console.WriteLine("Use RIght Arrao to navigate right");
            Console.WriteLine("Use Left Arrow to navigate left");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Score : " + GameModel.Score);

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < Tiles.Count(); i++)
            {
                for (int j = 0; j < Tiles[i].Count(); j++)
                {
                    Console.Write(Indent(5) + Tiles[i][j]);
                }
                Console.WriteLine();
            }
            //     Console.ReadLine();
        }

        public static string Indent(int count)
        {
            //Indent , here we space the game and make it look nicer.
            return "".PadLeft(count);
        }
      
    }
}
