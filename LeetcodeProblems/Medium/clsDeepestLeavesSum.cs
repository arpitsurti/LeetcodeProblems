using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*1302. Deepest Leaves Sum
     *** REF ***
     *** VERY IMP ***
     https://www.youtube.com/watch?v=hM9tzzlRcnM
     * Given the root of a binary tree, return the sum of values of its deepest leaves.

        Example 1:
        Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
        Output: 15

        Example 2:
        Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
        Output: 19

        Constraints:
        The number of nodes in the tree is in the range [1, 104].
        1 <= Node.val <= 100
    */
    public class clsDeepestLeavesSum
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int levelSum = 0;
            while (queue.Count() != 0)
            {
                levelSum = 0;
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    TreeNode currNode = queue.Dequeue();
                    levelSum += currNode.val;
                    if (currNode.left != null)
                        queue.Enqueue(currNode.left);
                    if (currNode.right != null)
                        queue.Enqueue(currNode.right);
                }
            }
            return levelSum;
        }
    }
}
