using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*199. Binary Tree Right Side View
     * Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

        Example 1:
        Input: root = [1,2,3,null,5,null,4]
        Output: [1,3,4]

        Example 2:
        Input: root = [1,null,3]
        Output: [1,3]

        Example 3:
        Input: root = []
        Output: []

        Constraints:
        The number of nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100
    */
    public class clsBinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> lstResult = new List<int>();
            if (root == null)
                return lstResult;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int len = queue.Count;
                for (int i = 0; i < len; i++)
                {
                    TreeNode curr = queue.Dequeue();
                    if (i == len - 1)
                        lstResult.Add(curr.val);
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
