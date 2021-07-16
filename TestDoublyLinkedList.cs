using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assissnments.DoublyLinkedListAss
{
    class TestDoublyLinkedList
    {
        static void Main(string[] args)
        {
            DoublyLinkedListProg d = new DoublyLinkedListProg();
            int ch, ele, pos;
            do
            {
                Console.WriteLine("1 Insert in the beginning");
                Console.WriteLine("2 Insert in the end");
                Console.WriteLine("3 Insert at  a given pos");
                Console.WriteLine("4 Delete at the beginning");
                Console.WriteLine("5 Delete at the end");
                Console.WriteLine("6 Delete at  a given pos");
                Console.WriteLine("7 Display");
                Console.WriteLine("8 Search Element in the list");
                Console.WriteLine("9 Search Element position");
                Console.WriteLine("10 Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        Console.WriteLine("Enter the element ");
                        ele = int.Parse(Console.ReadLine());
                        d.insertBegin(ele);
                        break;
                    case 2:
                        Console.WriteLine("Enter the element ");
                        ele = int.Parse(Console.ReadLine());
                        d.insertEnd(ele);
                        break;
                    case 3:
                        Console.WriteLine("Enter the element ");
                        ele = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Enter position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > d.count + 1);

                        d.insertPos(ele, pos);
                        break;
                    case 4: d.DeleteBegin(); break;
                    case 5: d.DeleteEnd(); break;
                    case 6:
                        do
                        {
                            Console.WriteLine("Enter position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > d.count);
                        d.DeletePos(pos);
                        break;
                    case 7:
                        d.display();
                        break;
                    case 8:
                        Console.WriteLine("Enter the Element to Search");
                        ele = int.Parse(Console.ReadLine());
                        d.searchNode(ele);
                        break;
                    case 9:
                        Console.WriteLine("Enter the Element to Search at Repeated position");
                        ele = int.Parse(Console.ReadLine());
                        pos = int.Parse(Console.ReadLine());
                        d.searchNodePos(ele,pos);
                        break;
                    case 10:Environment.Exit(1);
                        break;
                    default: Console.WriteLine("invalid choice"); break;
                }
            } while (ch != 10);
            Console.ReadLine();
        }
    }
}
