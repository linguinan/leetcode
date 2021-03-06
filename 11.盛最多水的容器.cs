/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
using System;

public class Solution {
    // public int MaxArea(int[] height) {
    //     int max = 0;
    //     for (int i = 0; i < height.Length; i++)
    //     {
    //         for (int j = i + 1; j < height.Length; j++)
    //         {
    //             int area = (j - i) * Math.Min(height[i], height[j]);
    //             max = Math.Max(max, area);
    //         }
    //     }
    //     return max;
    // }

    /// <summary>
    /// 双指针移动，时间复杂度O(n)
    /// 两边逼近，以小的一方做h计算面积，谁小谁往中间移动
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public int MaxArea(int[] height) {
        int max = 0;
        for (int i = 0, j = height.Length - 1; i < j;)
        {
            // 只移动小的下标，所以下面计算只需要+1
            int h = height[i] < height[j] ? height[i++] : height[j--];
            int area = (j - i + 1) * h;
            max = Math.Max(max, area);
        }
        return max;
    }
}
// @lc code=end

