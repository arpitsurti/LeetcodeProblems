using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*103. Binary Tree Zigzag Level Order Traversal
     * Given the root of a binary tree, return the zigzag level order traversal of its nodes' values. (i.e., from left to right, then right to left for the next level and alternate between).

        Example 1:
        Input: root = [3,9,20,null,null,15,7]
        Output: [[3],[20,9],[15,7]]
        
        Example 2:
        Input: root = [1]
        Output: [[1]]
        
        Example 3:
        Input: root = []
        Output: []

        Constraints:
        The number of nodes in the tree is in the range [0, 2000].
        -100 <= Node.val <= 100
    */
    public class clsBinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> lstResult = new List<IList<int>>();
            if (root == null)
                return lstResult;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool flgReverse = false;
            while (queue.Count != 0)
            {
                int size = queue.Count;
                List<int> lst = new List<int>();
                while (size != 0)
                {
                    TreeNode curr = queue.Dequeue();
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                    size--;
                    lst.Add(curr.val);
                }
                if (flgReverse)
                {
                    lst.Reverse();
                    flgReverse = false;
                }
                else
                    flgReverse = true;
                lstResult.Add(lst);
            }
            return lstResult;
        }
    }
}
