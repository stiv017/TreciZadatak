using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Node
    {
        public string data;
        public Node left,right;
        public Node(string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public Node(string data)
        {
            this.data=data;
            this.left = null;
            this.right = null;
        }
    }
}
