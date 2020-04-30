using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo.DataStructs
{
    public class Node
    {
        private Node()
        {
        }

        public Node(int val, Node l = null, Node r = null)
        {
            this.val = val;
            this.l = l;
            this.r = r;
        }

        public int val;
        public Node l, r;
    }
}
