using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*102. Binary Tree Level Order Traversal
     
     * Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

        Example 1:
        Input: root = [3,9,20,null,null,15,7]
        Output: [[3],[9,20],[15,7]]

        Example 2:
        Input: root = [1]
        Output: [[1]]

        Example 3:
        Input: root = []
        Output: []

        Constraints:
        The number of nodes in the tree is in the range [0, 2000].
        -1000 <= Node.val <= 1000
    */
    public class clsBinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> lstResult = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null)
                return lstResult;
            queue.Enqueue(root);
            queue.Enqueue(null);
            IList<int> lst = new List<int>();
            while (queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();
                if (curr != null)
                {
                    lst.Add(curr.val);
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
                else
                {
                    if (queue.Count != 0)
                        queue.Enqueue(null);
                    lstResult.Add(lst);
                    lst = new List<int>();
                }
            }
            return lstResult;
        }
    }
}
