using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*652. Find Duplicate Subtrees
     *** REF ***
     *** VERY IMP ***
     * Given the root of a binary tree, return all duplicate subtrees.

        For each kind of duplicate subtrees, you only need to return the root node of any one of them.

        Two trees are duplicate if they have the same structure with the same node values.

 

        Example 1:


        Input: root = [1,2,3,4,null,2,4,null,null,4]
        Output: [[2,4],[4]]
        Example 2:


        Input: root = [2,1,1]
        Output: [[1]]
        Example 3:


        Input: root = [2,2,2,3,null,3,null]
        Output: [[2,3],[3]]
 

        Constraints:

        The number of the nodes in the tree will be in the range [1, 10^4]
        -200 <= Node.val <= 200
    */
    public class clsFindDuplicateSubtrees
    {
        IList<TreeNode> lstResult = new List<TreeNode>();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            traverseTree(root);
            return lstResult;
        }

        private string traverseTree(TreeNode root)
        {
            if (root == null)
                return "#";
            string ss = root.val.ToString() + " " + traverseTree(root.left) + " " + traverseTree(root.right);
            int count = 0;
            if (dict.TryGetValue(ss, out count))
            {
                count++;
                dict[ss] = count;
                if (count == 2)
                    lstResult.Add(root);
            }
            else
                dict.Add(ss, 1);
            return ss;
        }
    }
}
