using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*872. Leaf-Similar Trees
     * Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.

        For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).
        Two binary trees are considered leaf-similar if their leaf value sequence is the same.
        Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

        Example 1:
        Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
        Output: true

        Example 2:
        Input: root1 = [1,2,3], root2 = [1,3,2]
        Output: false

        Constraints:
        The number of nodes in each tree will be in the range [1, 200].
        Both of the given trees will have values in the range [0, 200].
    */
    public class clsLeaf_SimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();
            dfs(root1, lst1);
            dfs(root2, lst2);
            if (lst1.Count != lst2.Count)
                return false;
            for (int i = 0; i < lst1.Count; i++)
            {
                if (lst1[i] != lst2[i])
                    return false;
            }
            return true;
        }

        private void dfs(TreeNode root, List<int> lst)
        {
            if (root != null)
            {
                if (root.left == null && root.right == null)
                    lst.Add(root.val);
                dfs(root.left, lst);
                dfs(root.right, lst);
            }
        }
    }
}
