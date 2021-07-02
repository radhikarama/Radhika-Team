using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Assissnments
{

    class Assignment1
    {
        static void ZeroMatrix(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length; j++)
                {
                    Console.Write("0" + " ");
                }
                Console.WriteLine();
            }
        }
        static void UserChoice(int[] a)
        {
            int row, column, shiftD;
            Console.WriteLine(" : USER SHIFTING DIRECTIONS : ");
            Console.WriteLine(" 1 :- EXIT  2 :- DOWN SHIFT  4 :-  LEFT SHIFT  6 :-  RIGHT SHIFT  8 :- UP SHIFT ");
            while (true)
            {
                Console.WriteLine("Enter the Row Number of Your Choice");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Column Number of Your Choice");
                column = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Choice of Shifting direction");
                shiftD = int.Parse(Console.ReadLine());
                try
                {
                    a[row] = row;
                    a[column] = column;
                }
                catch (Exception e)
                {
                    // Console.WriteLine("DOWN shift does not work");

                }

                switch (shiftD)
                {
                    case 1:
                        //  Exit();
                        Environment.Exit(-1);
                        break;

                    case 6:
                        // RIGHT SHIFT
                        try
                        {
                            if (a[column] >= a.Length - 1)
                            {
                                Console.WriteLine("RIGHT SHIFT does not exist");
                            }
                            else
                            {
                                for (int i = 1; i < a.Length; i++)
                                {
                                    for (int j = 1; j < a.Length; j++)
                                    {


                                        if (a[i] == a[row] && a[j] == a[column + 1])


                                            Console.Write("1" + "\t");

                                        else
                                            Console.Write("0" + "\t");


                                    }
                                    Console.WriteLine();
                                }
                            }
                        }catch(Exception e)
                        {
                            Console.WriteLine("RIGHT SHIFT does not exist");

                        }
                        break;
                    case 4:
                        // LEFT SHIFT
                        try
                        {
                            if (a[column] == a.Length - (a.Length - 1))
                            {
                                Console.WriteLine("Left shift does not work for the fist column");
                                break;
                            }
                            else
                            {
                                for (int i = 1; i < a.Length; i++)
                                {
                                    for (int j = 1; j < a.Length; j++)
                                    {

                                        if (a[i] == a[row] && a[j] == a[column - 1])


                                            Console.Write("1" + "\t");

                                        else
                                            Console.Write("0" + "\t");

                                    }
                                    Console.WriteLine();
                                }
                            }
                        }catch(Exception e)
                        {
                            Console.WriteLine("Left shift does not for the fist column");

                        }

                        break;
                    case 8:
                        // UP SHIFT
                        try
                        {
                            if (a[row] == a.Length - (a.Length-1))
                            {
                                Console.WriteLine("UPSHIFT does not exist");
                            }
                            else
                            {
                                for (int i = 1; i < a.Length; i++)
                                {
                                    for (int j = 1; j < a.Length; j++)
                                    {

                                        if (a[i] == a[row - 1] && a[j] == a[column])
                                        {

                                            Console.Write("1" + "\t");
                                            continue;

                                        }
                                        else
                                            Console.Write("0" + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("UPSHIFT does not exist");
                        }
                        break;



                    case 2:
                        // 2 --- Down
                        try
                        {

                            if (a[row] >= a.Length)
                            {
                                Console.WriteLine("DOWN shift does not work");
                            }
                            else
                            {

                                for (int i = 0; i < 5; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        if (a[i] == a[row + 1] && a[j] == a[column])
                                        {
                                           // Console.WriteLine( " jvn {0} {1}",a[i] , a[j]);

                                            Console.Write("1" + "\t");
                                            continue;
                                        }
                                        else
                                            Console.Write("0" + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("DOWN shift does not work");

                        }
                        break;
                }
            }
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array size ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            ZeroMatrix(a);
            UserChoice(a);
            Console.ReadLine();
        }
    }
}
