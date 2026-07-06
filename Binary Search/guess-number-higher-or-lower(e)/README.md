# **Explanation: Guess Number Higher or Lower**

## **Problem:** [Guess Number Higher or Lower - LeetCode](https://leetcode.com/problems/guess-number-higher-or-lower/)

### **Difficulty Level:** Easy

---

## **Description**

We are playing the Guess Game. The game is as follows:

I pick a number from `1` to `n`. You have to guess which number I picked.

Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

You call a pre-defined API `int guess(int num)`, which returns three possible results:

- `-1`: Your guess is higher than the number I picked (i.e. `num > pick`).
- `1`: Your guess is lower than the number I picked (i.e. `num < pick`).
- `0`: Your guess is equal to the number I picked (i.e. `num == pick`).

Return the number that I picked.

## **Examples**

**Input:** `n = 10, pick = 6`
**Output:** `6`

**Input:** `n = 1, pick = 1`
**Output:** `1`

**Input:** `n = 2, pick = 1`
**Output:** `1`

## **Approach**

Since the picked number lies in the sorted range `1..n` and the `guess` API tells us whether our guess is too high or too low, we can use **binary search**.

Keep a search range `[start, n]`, starting with `start = 1`. On each iteration:

1. Compute the middle of the range: `mid = (start + n) // 2`.
2. Call `guess(mid)`:
   - If it returns `0`, `mid` is the picked number — return it.
   - If it returns `-1`, the guess is too high, so shrink the range from above: `n = mid - 1`.
   - If it returns `1`, the guess is too low, so shrink the range from below: `start = mid + 1`.

Each step halves the search range, so the answer is found in at most log₂(n) guesses.

## **Time Complexity**

- **O(log n)** — the search range is halved on every iteration of the loop.

## **Space Complexity**

- **O(1)** — only a fixed number of variables are used regardless of the input size.

## **Code**

```python
# The guess API is already defined for you.
# @param num, your guess
# @return -1 if num is higher than the picked number
#          1 if num is lower than the picked number
#          otherwise return 0
# def guess(num: int) -> int:

class Solution:
    def guessNumber(self, n: int) -> int:
        start = 1

        while start <= n:
            mid = (start + n) // 2
            res = guess(mid)
            if res == 0:
                return mid
            elif res == -1:
                n = mid -1
            else:
                start = mid+1
```
