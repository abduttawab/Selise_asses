using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value)
    {
        val = value;
        left = null;
        right = null;
    }
}

public class Lib
{
    public static List<int> GetRightmostNodes(TreeNode root)
    {
        List<int> result = new List<int>();
        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // loop for full list

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int rightmostValue = 0;

            // loop for getting the single right most value
            for (int i = 0; i < levelSize; i++)
            {

                // Reduce the tree and get the right most value
                TreeNode currentNode = queue.Dequeue();
                rightmostValue = currentNode.val;

                // Get the values and put them in que

                if (currentNode.left != null) {
                    queue.Enqueue(currentNode.left)


                };
                if (currentNode.right != null) {
                    queue.Enqueue(currentNode.right)
                };

                
            }

            // get the results
            result.Add(rightmostValue);
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
   
        TreeNode root1 = null;
        List<int> result1 = Lib.GetRightmostNodes(root1);
        Console.WriteLine($" Output: [{string.Join(", ", result1)}]");

        
        TreeNode root2 = new TreeNode(1);
        List<int> result2 = Lib.GetRightmostNodes(root2);
        Console.WriteLine($"Output: [{string.Join(", ", result2)}]");

   
        TreeNode root3 = new TreeNode(1)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(4)
            },
            right = new TreeNode(3)
            {
                left = new TreeNode(5)
                {
                    right = new TreeNode(7)
                },
                right = new TreeNode(6)
            }
        };
        List<int> result3 = Lib.GetRightmostNodes(root3);
        Console.WriteLine($"Output: [{string.Join(", ", result3)}]");

      
        TreeNode root4 = new TreeNode(1)
        {
            right = new TreeNode(2)
            {
                right = new TreeNode(3)
                {
                    right = new TreeNode(4)
                }
            }
        };
        List<int> result4 = Lib.GetRightmostNodes(root4);
        Console.WriteLine($"Output: [{string.Join(", ", result4)}]");

   
        TreeNode root5 = new TreeNode(1)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(4)
                }
            }
        };
        List<int> result5 = Lib.GetRightmostNodes(root5);
        Console.WriteLine($"Output: [{string.Join(", ", result5)}]");

        TreeNode root6 = new TreeNode(1)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(4),
                right = new TreeNode(5)
            },
            right = new TreeNode(3)
            {
                right = new TreeNode(7)
            }
        };

        List<int> result6 = Lib.GetRightmostNodes(root6);
        Console.WriteLine($"Output: [{string.Join(", ", result6)}]");


        TreeNode root7 = new TreeNode(1)
        {
            left = new TreeNode(2)
            {
                right = new TreeNode(4)
            },
            right = new TreeNode(3)
        };

        List<int> result7 = Lib.GetRightmostNodes(root7);
        Console.WriteLine($"Output: [{string.Join(", ", result7)}]");

    }
}
