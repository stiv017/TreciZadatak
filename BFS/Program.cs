using BFS;

static  Node sample_tree()
{
    Node root =
        new Node("A",
            new Node("B",
                  new Node("C"), new Node("D")),
            new Node("E",
                  new Node("F"), new Node("G", new Node("H"), null)));
            
    return root;
}
static void bfs_travesal(Node node)
{
    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(node);
    while(queue.Count > 0)
    {
        node = queue.Dequeue();
        Console.WriteLine(node.data+"");
        if(node.left != null)
        {
            queue.Enqueue(node.left);
        }
        if(node.right != null)
        {
            queue.Enqueue(node.right);
        }
    }
}
Node tree= sample_tree();
Console.WriteLine("BFS ->"); bfs_travesal(tree);

