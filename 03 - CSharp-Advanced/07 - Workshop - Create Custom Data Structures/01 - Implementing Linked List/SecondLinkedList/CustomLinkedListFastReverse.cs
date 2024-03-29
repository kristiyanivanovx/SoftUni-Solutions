﻿using ImplementingLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLinkedList
{
    public class CustomLinkedListFastReverse
    {
        private int count = 0;

        public bool reversed = false;

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void Reverse()
        {
            var temp = Head;
            Head = Tail;
            Tail = temp;
            reversed = !reversed;
        }

        public void AddTail(Node node)
        {
            count += 1;

            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public void ForEachFromHead(Action<Node> action)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode);

                if (reversed)
                {
                    currentNode = currentNode.Previous;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
    }
}
