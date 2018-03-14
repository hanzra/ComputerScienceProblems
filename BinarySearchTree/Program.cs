using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Value = data;
            Left = null;
            Right = null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 6, 4, 2, 3, 8 };

            HashSet<int> set = new HashSet<int>();

            Node root = CreateMinHeightBSTFromArray(arr);

            Console.WriteLine(FindNumberInBinaryTree(root,3));
            Console.WriteLine(FindNumberInBinaryTree(root, 10));

            Console.ReadLine();
        }

        public static int FindMaximumLengthPathinBinaryTree(Node root)
        {
//needto do that afterwards
                return 0;

           
        }

        public static bool FindNumberInBinaryTree(Node root, int key)
        {
            if (root == null)
                return false;

            if (root.Value == key)
                return true;

            return FindNumberInBinaryTree(root.Left, key) || FindNumberInBinaryTree(root.Right, key);
        }

        public static int ReturnMaxNumber(Node root)
        {
            if (root == null)
                return int.MinValue;

            int value = root.Value;
            int leftValue = ReturnMaxNumber(root.Left);
            int rightValue = ReturnMaxNumber(root.Right);

            return Math.Max(Math.Max(value, leftValue), Math.Max(value, rightValue));
        }

        public static void PrintAllThePathsFromRootToLeaf(Node root)
        {
            //wrong need to do again
            if(root.Left == null && root.Right == null)
            {
                return;
            }

            Console.WriteLine(root.Value);

            PrintAllThePathsFromRootToLeaf(root.Left);
            PrintAllThePathsFromRootToLeaf(root.Right);

        }

        public static int NumberOfLeafNodes(Node root)
        {
            if (root.Left == null && root.Right == null)
                return 1;

            return NumberOfLeafNodes(root.Left) + NumberOfLeafNodes(root.Right);
        }

        public static int counter = 0;

        //nth PreOrder
        public static void NthPreOrder(Node root, int nthPreOrder){

            if (root == null)
                return;

            counter++;

            if (counter == nthPreOrder)
            {
                Console.WriteLine(root.Value);
            }

                NthPreOrder(root.Left, nthPreOrder);
                NthPreOrder(root.Right, nthPreOrder);
        }

        public static int DepthOfBST(Node root) //T:O(n), S:O(n)
        {
            if (root == null)
                return 0;

            return Math.Max(DepthOfBST(root.Left), DepthOfBST(root.Right)) + 1;
        }

        public static void LevelOrderTraversal_BFS(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                Node n = queue.Dequeue();
                Console.Write(n.Value + " ");

                if (n.Left != null)
                {
                    queue.Enqueue(n.Left);
                }

                if (n.Right != null)
                {
                    queue.Enqueue(n.Right);
                }
            }
        }

        public static void DepthFirstSearch_Recursion(Node root)
        {
            if (root == null)
                return;

            Console.Write(root.Value + " ");
            DepthFirstSearch(root.Right);
            DepthFirstSearch(root.Left);
                

        }

        public static void DepthFirstSearch(Node root)
        {
            Stack<Node> stc = new Stack<Node>();
            stc.Push(root);

            while(stc.Count != 0)
            {
                Node n = stc.Pop();

                Console.Write(n.Value + " ");

                if (n.Left != null)
                {
                    stc.Push(n.Left);
                }

                if(n.Right != null)
                {
                    stc.Push(n.Right);
                }
            }
        }

        public static bool FindIfTreeIsBST(Node root)
        {
            return BSTFindHelper(root, int.MinValue, int.MaxValue);
        }

        public static bool BSTFindHelper(Node root, int Min, int Max)
        {
            if (root == null)
                return true;

            if ( (root.Value < Min) || (root.Value > Max))
                return false;

            return BSTFindHelper(root.Left, Min, root.Value) && BSTFindHelper(root.Right, root.Value, Max);
        }

        public static Node CreateMinHeightBSTFromArray(int[] arr)
        {
            return BSTHelper(arr, 0, arr.Length - 1);
        }

        private static Node BSTHelper(int[] arr, int L, int H)
        {
            if (L > H)
                return null;

            int Mid = L + (H - L) / 2;

            Node newNode = new Node(arr[Mid]);

            newNode.Left = BSTHelper(arr, L, Mid - 1);
            newNode.Right = BSTHelper(arr, Mid+1, H);

            return newNode;
        }
    }
}
