using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*257. Binary Tree Paths
     * Given the root of a binary tree, return all root-to-leaf paths in any order.

        A leaf is a node with no children.

        Example 1:
        Input: root = [1,2,3,null,5]
        Output: ["1->2->5","1->3"]

        Example 2:
        Input: root = [1]
        Output: ["1"]

        Constraints:
        The number of nodes in the tree is in the range [1, 100].
        -100 <= Node.val <= 100
    */
    public class clsBinaryTreePaths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> lstResult = new List<string>();
            StringBuilder sb = new StringBuilder();
            getPaths(root, lstResult, "");
            return lstResult;
        }

        private void getPaths(TreeNode root, IList<string> lstResult, string path)
        {
            if (root.left == null && root.right == null)
                lstResult.Add(path + root.val);
            if (root.left != null)
                getPaths(root.left, lstResult, path + root.val + "->");
            if (root.right != null)
                getPaths(root.right, lstResult, path + root.val + "->");
        }
    }
}
