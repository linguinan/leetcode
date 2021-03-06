/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {

    /// <code>
    /// 用栈循环遍历右边界
    /// 容量就是左右边界之宽*最矮的边，如果没有左或右边界则跳过 
    /// </code>
    public int Trap (int[] height) {
        Stack<int> stack = new Stack<int> ();
        int ans = 0;
        for (int i = 0; i < height.Length; i++) {
            while (stack.Count > 0 && height[i] >= height[stack.Peek ()]) {
                int top = stack.Pop ();
                if (stack.Count > 0) {
                    // i与前一个柱子构成凹槽，减去凹柱高度
                    int w = i - stack.Peek () - 1;
                    int h = Math.Min (height[stack.Peek ()], height[i]) - height[top];
                    ans += w * h;
                }
            }
            stack.Push (i);
        }
        return ans;
    }
}
// @lc code=end