using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*637. Average of Levels in Binary Tree
     * Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. Answers within 10-5 of the actual answer will be accepted.
    
    Example 1:
    Input: root = [3,9,20,null,null,15,7]
    Output: [3.00000,14.50000,11.00000]
    Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
    Hence return [3, 14.5, 11].

    Example 2:
    Input: root = [3,9,20,15,7]
    Output: [3.00000,14.50000,11.00000]
 
    Constraints:
    The number of nodes in the tree is in the range [1, 104].
    -231 <= Node.val <= 231 - 1
    */
    public class clsAverageOfLevelsInBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> lstResult = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            double count = 0;
            double sum = 0;
            while (queue.Count() > 0)
            {
                TreeNode curr = queue.Dequeue();
                if (curr == null)
                {
                    lstResult.Add((sum / count));
                    sum = 0;
                    count = 0;
                    if (queue.Count != 0)//This line is important to break the loop
                        queue.Enqueue(null);
                }
                else
                {
                    sum += curr.val;
                    count++;
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
            }
            return lstResult;
        }
    }
}
