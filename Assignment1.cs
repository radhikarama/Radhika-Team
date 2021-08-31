using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Assissnments
{

    class Assignment1
    {
        static void input(int[] a,int cp)
        {
            for (int i = 0; i < a.Length ; i++)
            {

                if (i == cp)
                {
                    a[i] = 1;

                }
                else
                    a[i] = 0;               
            }

            Console.WriteLine();
        }


        static void ZeroMatrix(int[] input, int height, int width)
        {
            int[,] output = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[i, j] = (int)input[i * width + j];
                    Console.Write(output[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int row, column,n, shiftD,cp=0;
            Console.WriteLine("Enter the Array  Size");
             n = int.Parse(Console.ReadLine());
         
            row = n; column = n;
            int n1 = (int)(row * column);
            int[] a = new int[n1];
            input(a,cp);
            ZeroMatrix(a,row , column);
            double m =(a.Length-1)/column;
            double c = Math.Ceiling(m);
            Console.WriteLine(" : USER SHIFTING DIRECTIONS : ");
            Console.WriteLine(" 1 :- EXIT  2 :- DOWN SHIFT  4 :-  LEFT SHIFT  6 :-  RIGHT SHIFT  8 :- UP SHIFT ");
            while (true)
            {
                Console.WriteLine("Enter the Shifting Direction");
                shiftD = int.Parse(Console.ReadLine());

                switch (shiftD)
                {
                    case 1:
                        Environment.Exit(-1);
                        break;
                    case 6:
                        int r1 = cp + column;
                        
                        if (r1 % column == column - 1)
                        {
                            
                            Console.WriteLine("right shift dosent exits:");
                        }
                        else
                         if (cp >= 0)
                        {
                            cp++;
                            input(a, cp);
                            ZeroMatrix(a, row, column);

                        }

                        break;
                    case 4:

                        int r = cp +column;
                       if(r%column==0)
                            Console.WriteLine("left shift dosent exits:");
                            else
                        if (cp >= 0)
                        {
                            cp--;
                            
                            input(a, cp);

                            ZeroMatrix(a, row, column);
                        }

                        break;
                    case 8:
                        if (cp >= 0 && cp > ((a.Length - 1) / column))
                        {
                            input(a, cp -= column);

                            ZeroMatrix(a, row, column);
                        }
                        else
                        {
                            Console.WriteLine("Up shift dose not take place..");
                        }
                        break;
                    case 2:
                        
                        if (cp >= 0 && cp<((a.Length-1)-column))
                        {
                            input(a, cp+=column);
                                ZeroMatrix(a, row, column);                        
                        }
                       else
                        {
                            Console.WriteLine("Down shift dose not take place..");
                        }

                        break;
                     }
            }
          
            Console.ReadLine();
        }
    }
}
