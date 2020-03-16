﻿using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinked_List myList = new SinglyLinked_List();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(75);
            myList.insertFirst(60);
            myList.insertFirst(30);
            myList.insertFirst(20);
            myList.insertLast(101010101);
            myList.displatList();
            myList.deleteFirst();
            myList.displatList();
        }
    }
    public class SinglyLinked_List
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
        public void displatList()
        {
            Console.WriteLine("List (first -- last) ");
            Node current = first;

            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }
        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

    }
    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
