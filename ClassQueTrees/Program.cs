using System;
using System.Collections.Generic;
namespace ClassQueTrees
{
    public class Program
    {
        TreeNode root;
        public class TreeNode
        {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { this.val = x; this.left = this.right = null; }
       }
        static void Main(string[] args)
        {
             int[] arr = { 1,2,3};
            //int[] arr = { 11, 1, 20, 3, -1, -1, 14, -1, -1, 5, -1, -1 };
            Program tree = new Program();
            tree.root = insertLevelOrder(arr, tree.root, 0);
            
            //tc1
            //TreeNode A = new TreeNode(4);
            //A.right = new TreeNode(2);
            //A.left = new TreeNode(5);
            //A.right.left = new TreeNode(3);
            //A.right.right = new TreeNode(6);
            ////TreeNode B = new TreeNode(1);
            //B.right = new TreeNode(2);
            //B.right.left = new TreeNode(3);

            List<int> lst = new List<int>();
            Console.WriteLine(height(tree.root)); 
            //foreach (var item in lst) { 
            //Console.WriteLine(item);
            //}

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
        //public static int max=int.MinValue;
        public static int cnt = 0;
        public static int height(TreeNode A)
        {
            if (A == null)
                return 0;
            int hl = height(A.left);
            int hr = height(A.right);

            return Math.Max(hl, hr) + 1;

        }
        public static int CntBiggerNode(TreeNode A)
        {
           
            return  Traverse(A, int.MinValue);
         }

        public static int Traverse(TreeNode Node, int max)
        {
            
            if (Node == null)
            {
                return 0;
            }

            if (Node.val > max)
            {
                max = Node.val;
                cnt++;
            }
            Traverse(Node.left,max);
            Traverse(Node.right,max);
            
            return cnt;
        }

        public static int isSameTree(TreeNode A, TreeNode B)
        {
            List<int> Alst = new List<int>();
            List<int> Blst = new List<int>();
            Alst = inorderTraversal(A);
            Blst = inorderTraversal(B);
            for (int i = 0; i < Alst.Count; i++)
            {
                if (Alst[i] != Blst[i])
                {
                    return 0;
                }
            }

            return 1;
        }
        public static List<int> lst = new List<int>();
        public static List<int> postorderTraversal(TreeNode A)
        {
            lst = new List<int>();
            postorderTraverse(A);
            return lst;
        }
        public static List<int> preorderTraversal(TreeNode A)
        {
            lst = new List<int>();
            preorderTraverse(A);
            return lst;
        }
        public static List<int> inorderTraversal(TreeNode A)
        {
            lst = new List<int>();
            inorderTraverse(A);
            return lst;
        }

        public static void postorderTraverse(TreeNode Node)
        {
            if (Node == null)
            {
                return;
            }
            
            postorderTraverse(Node.left);
            postorderTraverse(Node.right);
            lst.Add(Node.val);
        }   

        public static void inorderTraverse(TreeNode Node)
        {
            if (Node == null)
            {
                return;
            }

            inorderTraverse(Node.left);
            lst.Add(Node.val);
            inorderTraverse(Node.right);
        }
       public static void preorderTraverse(TreeNode Node)
        {
            if (Node == null)
            {
                return;
            }
            lst.Add(Node.val);
            preorderTraverse(Node.left);

            preorderTraverse(Node.right);
        }
        
    }
}
