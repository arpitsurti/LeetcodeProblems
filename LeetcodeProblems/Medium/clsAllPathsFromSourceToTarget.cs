using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*797. All Paths From Source to Target
     *** REF ***
     *https://www.youtube.com/watch?v=CYnvDzMprdc
     * Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1 and return them in any order.

        The graph is given as follows: graph[i] is a list of all nodes you can visit from node i (i.e., there is a directed edge from node i to node graph[i][j]).

        Example 1:
        Input: graph = [[1,2],[3],[3],[]]
        Output: [[0,1,3],[0,2,3]]
        Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.

        Example 2:
        Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
        Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]
 
        Constraints:
        n == graph.length
        2 <= n <= 15
        0 <= graph[i][j] < n
        graph[i][j] != i (i.e., there will be no self-loops).
        All the elements of graph[i] are unique.
        The input graph is guaranteed to be a DAG.
    */
    public class clsAllPathsFromSourceToTarget
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> lstResult = new List<IList<int>>();
            Queue<List<int>> queue = new Queue<List<int>>();
            List<int> lst = new List<int>();
            lst.Add(0);
            queue.Enqueue(lst);
            int targetNode = graph.Length - 1;

            while (queue.Count != 0)
            {
                List<int> path = queue.Dequeue();
                int lastNode = path[path.Count - 1];
                if (lastNode == targetNode)
                    lstResult.Add(new List<int>(path));
                else
                {
                    int[] neighbors = graph[lastNode];
                    for (int i = 0; i < neighbors.Length; i++)
                    {
                        List<int> newList = new List<int>(path);
                        newList.Add(neighbors[i]);
                        queue.Enqueue(newList);
                    }
                }
            }
            return lstResult;
        }
    }
}
