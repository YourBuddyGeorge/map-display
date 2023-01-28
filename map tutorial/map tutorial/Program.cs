using System;

namespace map_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mapData = new int[8,8,1];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(i % 2 == 0 && j % 2 == 0) { mapData[i, j, 0] = 1; }
                    else if (i % 2 != 0 && j % 2 == 0) { mapData[i, j, 0] = 1; }
                    else { mapData[i, j, 0] = 2; }
                }
            }    //determines map tile type

            for (int i= 0; i<8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(mapData[i,j,0] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("  ");
                    }
                    if (mapData[i, j, 0] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }    //map display code
            Console.ReadLine();
        }
    }
}
