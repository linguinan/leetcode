using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start
public class Solution {
    public IList<string> GenerateParenthesis2(int n) {
        IList<string> list = new List<string>();
        if (n <= 0)
            return list;
        gen2(list, 0, 0, n, "");
        return list;
    }

    void gen2(IList<string> list, int left, int right, int n, string res) {
        if (left == n && right == n)
        {
            list.Add(res);
            return;
        }

        if (left < n)
        {
            // 注意：不能用++left 这样会修改left值影响后续的递归
            gen2(list, left + 1, right, n, res + "(");
        }
        if (left > right && right < n)
        {
            gen2(list, left, right + 1, n, res + ")");
        }
    }

    public IList<string> GenerateParenthesis(int n) {
        IList<string> list = new List<string>();
        if (n <= 0)
            return list;
        gen(list, n, n, "");
        return list;
    }

    void gen(IList<string> list, int left, int right, string res) {
        if (left == 0 && right == 0)
        {
            list.Add(res);
            return;
        }

        if (left > 0)
        {
            gen(list, left - 1, right, res + "(");
        }
        if (right > left)
        {
            gen(list, left, right - 1, res + ")");
        }
    }
}
// @lc code=end

