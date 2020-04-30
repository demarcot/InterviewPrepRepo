using InterviewPrepRepo.DataStructs;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo.Search
{
    public static class BFS
    {
        public static void RunBFS()
        {
            List<Node> tree = new List<Node>();
            tree.Add(new Node(3));
            tree.Add(new Node(2));
            tree.Add(new Node(8));
            tree.Add(new Node(21));
            tree.Add(new Node(99)); // Node will not be attached to the graph

            tree[0].l = tree[1];
            tree[0].r = tree[2];
            tree[1].r = tree[3];
            
            Queue<Node> frontier = new Queue<Node>();

            frontier.Enqueue(tree[0]);
            Console.WriteLine("BFS true: " + Search(frontier, 21));
            frontier.Clear();
            frontier.Enqueue(tree[0]);
            Console.WriteLine("BFS false: " + Search(frontier, 99));
        }

        public static bool Search(Queue<Node> frontier, int val)
        {
            while (frontier.Count > 0)
            {
                Node n = frontier.Dequeue();
                if(n.l != null)
                {
                    frontier.Enqueue(n.l);
                }

                if(n.r != null)
                {
                    frontier.Enqueue(n.r);
                }

                if(n.val == val)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
