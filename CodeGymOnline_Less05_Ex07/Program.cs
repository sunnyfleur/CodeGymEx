using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less05_Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {
                             {"*", ".", ".", "."},
                              {".", ".", ".", "."},
                              {".", "*", ".", "."},
                              {".", ".", ".", "."}
            };

            int mapHeight= map.GetLength(0);
            int mapWidth= map.GetLength(1);

            string[,] mapReport= new string[mapHeight, mapWidth];

            for (int yOrdinate = 0; yOrdinate < mapHeight; yOrdinate++)
            {
                for (int xOrdinate = 0; xOrdinate < map.GetLength(1); xOrdinate++)
                {
                    String curentCell = map[yOrdinate, xOrdinate];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[yOrdinate, xOrdinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = { { yOrdinate, xOrdinate - 1 }, { yOrdinate, xOrdinate + 1 } };

                        int minesAround = 0;
                        for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0 || xOrdinateOfNeighbour == mapWidth;
                            if (isOutOfMapNeighbour) continue;

                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour) minesAround++;
                        }

                        mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                    }
                }
            }

            for (int yOrdinate = 0; yOrdinate < mapHeight; yOrdinate++)
            {
                Console.WriteLine("\n");
                for (int xOrdinate = 0; xOrdinate < mapWidth; xOrdinate++)
                {
                    String currentCellReport = mapReport[yOrdinate, xOrdinate];
                    Console.Write(currentCellReport);
                }
            }


        }
    }
}
