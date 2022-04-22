using System;

namespace classqueTrees2
{
    class Program
    {
        TreeNode root;
        public static Program tree = new Program();
        static void Main(string[] args)
        {
            //int[] arr = { 17, 21, 13, 35, 12, 18, 27, 41, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] arr = { 3,8, -1, -1 };
            //int[] arr = { 3, 8, -1, -1 };
            //int[] arr1 = { 11, 41 };
            
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    AddBST(arr[i]);
            //}
            Solution sol = new Solution();
            tree.root = insertLevelOrder(arr, tree.root, 0);
            //tree.root = insertLevelOrder(arr1, tree.root, 0);
            Console.WriteLine(sol.IsSameTree(tree.root, tree.root));
            //Console.WriteLine(search(tree.root,22));
           // Console.WriteLine(BSTRange(tree.root,19,22));
        }



        public static int cnt = 0;
        public static int BSTRange(TreeNode root, int B, int C)
        {
           
            if (root == null)
                return 0;
            if((root.val>=B)&& (root.val <= C))
            {
                cnt++;
            }
            BSTRange(root.left,B,C);
            BSTRange(root.right, B, C);
            return cnt;
        }
        public static bool AddBST(int value)
        {
           // Program tree = new Program();
            TreeNode before = null, after = tree.root;

            while (after != null)
            {
                before = after;
                if (value < after.val) //Is new node in left tree? 
                    after = after.left;
                else if (value > after.val) //Is new node in right tree?
                    after = after.right;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            TreeNode newNode = new TreeNode();
            newNode.val = value;

            if (tree.root == null)//Tree ise empty
                tree.root = newNode;
            else
            {
                if (value < before.val)
                    before.left = newNode;
                else
                    before.right = newNode;
            }

            return true;
        }
            public static bool search(TreeNode root, int k)
        {
            while (root != null) { 
            if (root.val == k)
                return true;
            else if(root.val>k)
            {
                root = root.left;
            }
            else
            {
                root = root.right;
            }
            }
            return false;
        }
        public static TreeNode insertLevelOrder(int[] arr,
                            TreeNode root, int i)
        {
            // Base case for recursion
            if (i < arr.Length)
            {
                TreeNode temp = new TreeNode(arr[i]);
                root = temp;

                // insert left child
                root.left = insertLevelOrder(arr,
                                root.left, 2 * i + 1);

                // insert right child
                root.right = insertLevelOrder(arr,
                                root.right, 2 * i + 2);
            }
            return root;
        }
    }
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
      }
  }
 
public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p == null) && (q == null))
                return true;
            if ((p == null) || (q == null))
                return false;
            if (p.val != q.val)
                return false;
            if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right)) 
            return true;

            return true;
        }
    }
}
