using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*101. Symmetric Tree
     * Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

        Example 1:
        Input: root = [1,2,2,3,4,4,3]
        Output: true

        Example 2:
        Input: root = [1,2,2,null,3,null,3]
        Output: false
 
        Constraints:
        The number of nodes in the tree is in the range [1, 1000].
        -100 <= Node.val <= 100
 
        Follow up: Could you solve it both recursively and iteratively?
    */
    public class clsSymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return checkSymm(root.left, root.right);
        }

        private bool checkSymm(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null)
                return root1 == root2;
            if (root1.val != root2.val)
                return false;
            return checkSymm(root1.left, root2.right) && checkSymm(root1.right, root2.left);
        }
    }
}
