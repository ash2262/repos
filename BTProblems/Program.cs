using System;
using System.Collections.Generic;

namespace BTProblems
{
    class Solution
    {
        TreeNode root;
        public static Solution tree = new Solution();
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] arr = { 1,4,5,2,3,6,7,-1,-1,-1,-1,-1,-1,-1,-1, };

            int[] arr1 = { 11, 41 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    AddBST(arr[i]);
            //}
            tree.root = insertLevelOrder(arr, tree.root, 0);
            var result = solve(tree.root, 7);
        }
        public static List<int> lst = new List<int>();
        public static bool found = false;
        public static List<int> solve(TreeNode A, int B)
        {
           
            if(A==null)
            {
                return lst ;
            }
            if (A.val == B)
            {
                found = true;
                lst.Add(A.val);
                return lst;
            }
            if (!found)
            {
                lst.Add(A.val);
             
            solve(A.left,B);
            
            solve(A.right, B);
            }
            return lst;
            
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

}
