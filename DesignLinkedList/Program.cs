using System;

namespace DesignLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList obj = new MyLinkedList();
            obj.AddAtHead(7);
            obj.AddAtTail(3);
            obj.AddAtHead(9);
            obj.AddAtTail(8);
            obj.AddAtHead(6);
            obj.AddAtHead(0);
            var supposedToBe8 = obj.Get(5);
            obj.AddAtHead(0);
            obj.Get(2);
            obj.Get(5);
            obj.AddAtTail(4);
        }
    }


     public class Node
    {
        public int value;
        public Node next;

        public Node(int val)
        {
            value = val;
        }
    }

    public class MyLinkedList
    {
        public Node head;

        public MyLinkedList() 
        {
            
        }
        
        public int Get(int index) 
        {
            if (head == null)
            {
                return -1;
            }
            Node temp = head;
            int count = 0;
            if (index == count)
            {
                return temp.value;
            }
            while (temp.next != null)
            {
                temp = temp.next;
                count = count + 1;
                if (index == count)
                {
                    return temp.value;
                }
            }
            return -1;              
        }    

        public void AddAtHead(int val) 
        {
            if (head == null)
            {
                Node node = new Node(val);
                head = node;
            }
            else 
            {
                Node node = new Node(val);
                node.next = head;
                head = node;
            }
        }        
        public void AddAtTail(int valToAdd) 
        {
            if (head == null)
            {
                Node node = new Node(valToAdd);
                head = node;
            }
            else if (head.next == null)
            {
                Node node = new Node(valToAdd);
                head.next = node;
            }    
            else if (head.next != null)
            {
                Node temp = head.next;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                Node node = new Node(valToAdd);
                temp.next = node;
            }
        } 
        
        public void AddAtIndex(int index, int valueToInsert) 
        {
            if (index == 0)
            {
                AddAtHead(valueToInsert);
            }
            if (head == null)
            {
                return;
            }    
            if (index == 1)
            {
                if (head.next == null)
                {
                    Node node = new Node(valueToInsert);
                    head.next = node;
                }
                else
                {
                    Node node = new Node(valueToInsert);
                    node.next = head.next;
                    head.next = node;
                }                
            }
            if (index >= 2)
            {
                int count = 0;
                if (head.next != null)
                {
                    Node temp = head.next;
                    count = 1;
                    while (temp.next != null)
                    {                       
                        if (count == index - 1)
                        {
                            Node node = new Node(valueToInsert);
                            node.next = temp.next;
                            temp.next = node;
                        }
                        count = count + 1;
                        temp = temp.next;
                    }
                    if (count == index - 1)
                        {
                            Node node = new Node(valueToInsert);
                            node.next = temp.next;
                            temp.next = node;
                        }

                }
            }
        }
        public void DeleteAtIndex(int index)
        {         
            if (head == null)
            {
                return;
            }
            if (index == 0)
            {
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    head = head.next;
                }
            }
            if (index == 1)
            {
                if (head.next == null)  
                {
                    return;
                }
                else
                {
                    Node temp = head.next;
                    head.next = temp.next;
                }
            }
            if (index >= 2)
            {
                int count = 0;
                if (head.next != null) 
                {
                    Node temp = head.next; 
                    count = 1; 
                    while (temp.next != null) 
                    {
                        count = count + 1;            
                        if (count == index) 
                        {
                            temp.next = temp.next.next;
                            return;
                        }
                        temp = temp.next;
                    }

                }
            }
        }
             
            
    }
       
}

 





