using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*590. N-ary Tree Postorder Traversal
     * Given the root of an n-ary tree, return the postorder traversal of its nodes' values.

        Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value (See examples)

        Example 1:
        Input: root = [1,null,3,2,4,null,5,6]
        Output: [5,6,3,2,4,1]

        Example 2:
        Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
        Output: [2,6,14,11,7,3,12,8,4,13,9,10,5,1]
 
        Constraints:
        The number of nodes in the tree is in the range [0, 104].
        0 <= Node.val <= 104
        The height of the n-ary tree is less than or equal to 1000.

        Follow up: Recursive solution is trivial, could you do it iteratively?
    */
    class clsN_aryTreePostorderTraversal
    {
        public IList<int> Postorder(Node root)
        {
            /* Recursion
            if(root == null)
                return lstResult;
            foreach(var item in root.children)
            {
                Postorder(item);
            }
            lstResult.Add(root.val);
            return lstResult;
            */
    List<int> lstResult = new List<int>();
            if (root == null)
                return lstResult;
            Stack<Node> st = new Stack<Node>();
            st.Push(root);
            while (st.Count != 0)
            {
                Node curr = st.Pop();
                lstResult.Add(curr.val);
                foreach (var item in curr.children)
                {
                    st.Push(item);
                }
            }
            lstResult.Reverse();
            return lstResult;
        }
    }
}
