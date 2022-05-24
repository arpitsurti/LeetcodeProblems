using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*155. Min Stack
     * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

        Implement the MinStack class:

        MinStack() initializes the stack object.
        void push(int val) pushes the element val onto the stack.
        void pop() removes the element on the top of the stack.
        int top() gets the top element of the stack.
        int getMin() retrieves the minimum element in the stack.
 

        Example 1:
        Input
        ["MinStack","push","push","push","getMin","pop","top","getMin"]
        [[],[-2],[0],[-3],[],[],[],[]]

        Output
        [null,null,null,null,-3,null,0,-2]

        Explanation
        MinStack minStack = new MinStack();
        minStack.push(-2);
        minStack.push(0);
        minStack.push(-3);
        minStack.getMin(); // return -3
        minStack.pop();
        minStack.top();    // return 0
        minStack.getMin(); // return -2
 

        Constraints:
        -231 <= val <= 231 - 1
        Methods pop, top and getMin operations will always be called on non-empty stacks.
        At most 3 * 104 calls will be made to push, pop, top, and getMin.
    */
    public class MinStack
    {
        Stack<int> st;
        Stack<int> minSt;
        public MinStack()
        {
            st = new Stack<int>();
            minSt = new Stack<int>();
        }

        public void Push(int val)
        {
            st.Push(val);
            if (minSt.Count == 0 || minSt.Peek() >= val)
            {
                minSt.Push(val);
            }
        }

        public void Pop()
        {
            int item = st.Pop();
            if (minSt.Peek() == item)
                minSt.Pop();
        }

        public int Top()
        {
            return st.Peek();
        }

        public int GetMin()
        {
            return minSt.Peek();
        }
    }
}
