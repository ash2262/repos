// C# program to print top
// view of binary tree
using System;
using System.Collections;
using System.Collections.Generic;

// Class to create a node
class Node
{
	public int data;
	public Node left, right;

	public Node(int data)
	{
		this.data = data;
		left = right = null;
	}
};

class QueueObj
{
	public Node node;
	public int hd;

	public QueueObj(Node node, int hd)
	{
		this.node = node;
		this.hd = hd;
	}
};

// Class of binary tree
class BinaryTree
{

	Node root;

	public BinaryTree() { root = null; }

	// function should print the topView of
	// the binary tree
	void TopView(Node root)
	{
		Queue q = new Queue();
		SortedDictionary<int, Node> topViewMap
			= new SortedDictionary<int, Node>();

		if (root == null)
		{
			return;
		}
		else
		{
			q.Enqueue(new QueueObj(root, 0));
		}

		// count function returns 1 if the container
		// contains an element whose key is equivalent
		// to hd, or returns zero otherwise.
		while (q.Count != 0)
		{
			QueueObj tmpNode = (QueueObj)q.Dequeue();

			if (!topViewMap.ContainsKey(tmpNode.hd))
			{
				topViewMap[tmpNode.hd] = tmpNode.node;
			}

			if (tmpNode.node.left != null)
			{
				q.Enqueue(new QueueObj(tmpNode.node.left,
									tmpNode.hd - 1));
			}
			if (tmpNode.node.right != null)
			{
				q.Enqueue(new QueueObj(tmpNode.node.right,
									tmpNode.hd + 1));
			}
		}

		foreach (var entry in topViewMap.Values)
		{
			Console.Write(entry.data);
		}
	}

	// Driver code
	public static void Main(string[] args)
	{

		/* Create following Binary Tree
			1
		/ \
		2 3
		\
			4
			\
			5
			\
				6*/
		BinaryTree tree = new BinaryTree();
		tree.root = new Node(1);
		tree.root.left = new Node(2);
		tree.root.right = new Node(3);
		tree.root.left.right = new Node(4);
		tree.root.left.right.right = new Node(5);
		tree.root.left.right.right.right = new Node(6);

		Console.WriteLine("Following are nodes "
						+ "in top view of Binary Tree");

		tree.TopView(tree.root);
	}
}

// This code is contributed by rutvik_56
