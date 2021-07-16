using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assissnments.DoublyLinkedListAss
{
    class Node
    {
        public int data;
        public Node nxtadd;
        public Node prevadd;
    };
        class DoublyLinkedListProg
         {
        public Node head , tail;
        public int count;
        public DoublyLinkedListProg()
        {
            head = null;
            count = 0;
        }

        public Node createNode(int ele)
        {
           // head = new Node();
            Node tempNode = new Node();
            tempNode.data = ele;
            tempNode.prevadd = null;
            tempNode.nxtadd = null;
           // head =  tempNode;
            count++;
            return tempNode;
        }

        public void insertBegin(int ele)
        {
            Node newNode = createNode(ele);
            if (head == null)
                head =tail= newNode;
            else
            {
                head.prevadd = newNode;
                newNode.nxtadd = head;
                head = newNode;
            }
        }
        public void insertEnd(int ele)
              {
            Node newNode = createNode(ele);
            if (tail == null)
                tail = newNode;
            else
            {
                newNode.prevadd = tail;
                tail.nxtadd = newNode;
                tail = newNode;
            }
              }
        public void insertPos(int ele,int pos)
        {
            if (pos == 1)
                insertBegin(ele);
            else if (pos == count + 1)
                insertEnd(ele);
            else
            {
                Node newNode = createNode(ele);
                Node pn, cn;
                pn = cn = head;
                for(int i = 1; i < pos; i++)
                {
                    pn = cn;
                    cn = cn.nxtadd;
                }
                pn.nxtadd = newNode;
                cn.prevadd = newNode;
                newNode.prevadd = pn;
                newNode.nxtadd = cn;
            }

        }
        public void DeleteBegin()
        {
            if(head==null)
                Console.WriteLine("No Elements in the list -> Deletion not possible");
            else
            {
                Node temp = head;
                head = head.nxtadd;
                Console.WriteLine("Deleted Elements is:" + temp.data);
                temp = null;
                //head.prevadd = null;
                count--;
            }
        }
        public void DeleteEnd()
        {
            if (head == null)
                Console.WriteLine("No Elements in the End of list -> Deletion not possible");
            else
            {
                 Node pn, cn;
                 pn = cn = head;
                 while (cn.nxtadd!= null)
                 {
                     pn = cn;
                     cn = cn.nxtadd;
                 }

                 if (pn == cn)
                 {
                     head = null;
                     //head.nxtadd = null;
                 }
                pn.nxtadd = null;
            
                // cn.prevadd = null;
                Console.WriteLine("Deleted Element at End"+cn.data);
               // cn.prevadd = null;
                cn = null;
              
                count--;
            }
        }
        public void DeletePos(int pos)
        {
             if (pos == 1)
                DeleteBegin();
            else if (pos == count)
                DeleteEnd();
            else
            {
                Node pn, cn;
                pn = cn = head;
                for(int i = 1; i < pos; i++)
                {
                    pn = cn;
                    cn = cn.nxtadd;
                }
                //cn.prevadd = null;
                pn.nxtadd= null;
                pn.nxtadd = cn.nxtadd;
               // cn = pn;
                Console.WriteLine("Deleting Element at position"+cn.data);
                //cn.prevadd = null;
                cn = null;
                count--;
            }
        }
        public void searchNode(int ele)
        {
            Node tempNode = head;
            int  flag=0;
            if (head == null)
                Console.WriteLine("No Elements in the list");
            else
            {
               while (tempNode != null)
                     {
                    
                    if(tempNode.data == ele )
                             {
                         Console.WriteLine("Element found successfully" + " \t " + ele);
                        flag = 1;
                                }
                tempNode = tempNode.nxtadd;
                     }
               if(flag==0)
             Console.WriteLine("Element not found");
            }

        }
        public void searchNodePos(int ele,int pos)
        {
            Node tempNode = head;
            int position = 1, flag=0,count=1;
            if (head == null)
                Console.WriteLine("No Elements in the list");
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.data == ele )
                    {
                        if (count == pos)
                        {
                            Console.WriteLine("Element at the position"+"\t" + ele + " \t " + position);
                            flag = 1;
                        }
                        count++;
                    }
                    tempNode = tempNode.nxtadd;
                    position++;
                }
                if (flag == 0)
                    Console.WriteLine("Element not found");

            }
        }

        public void display()
        {
            Node temp = head;
            if(head==null)
                Console.WriteLine("No Elements in the list");
            else
            {
                Console.WriteLine("\nElements in the list :");
               
                while (temp != null)
                {
                    Console.Write(temp.data+"\t");
                    temp = temp.nxtadd;
                }
                Console.WriteLine();
            }
        }
     
   }
}
