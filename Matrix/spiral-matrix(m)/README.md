# **Explanation: Spiral Matrix**

## **Problem:** [Spiral Matrix - LeetCode](https://leetcode.com/problems/spiral-matrix/)

### **Difficulty Level:** Medium

---

## **Description**

Given an `m x n` matrix, return all elements of the matrix in **spiral order**.

Starting from the top-left corner, we move right across the top row, down the right column, left across the bottom row, and up the left column — then repeat the same pattern on the inner layer, until every element has been visited.

## **Examples**

**Input:** `matrix = [[1,2,3],[4,5,6],[7,8,9]]`
**Output:** `[1,2,3,6,9,8,7,4,5]`
**Explanation:**
```
→ → →
    ↓
↑ ← ←
```

**Input:** `matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]`
**Output:** `[1,2,3,4,8,12,11,10,9,5,6,7]`

## **Approach**

Keep four boundaries that mark the part of the matrix not yet visited: `top`, `bottom`, `left`, and `right`. Each pass around the loop peels off one layer of the spiral:

1. **Top row** — traverse from `left` to `right` along row `top`, then move `top` down by one.
2. **Right column** — traverse from `top` to `bottom` along column `right`, then move `right` in by one.
3. **Bottom row** — if there are still rows left (`top <= bottom`), traverse from `right` back to `left` along row `bottom`, then move `bottom` up by one.
4. **Left column** — if there are still columns left (`left <= right`), traverse from `bottom` back up to `top` along column `left`, then move `left` in by one.

The checks before steps 3 and 4 prevent double-counting when a single row or a single column remains. The loop continues while `top <= bottom and left <= right`, i.e. while there is still an unvisited layer.

## **Time Complexity**

- **O(m · n)** — every element of the matrix is visited exactly once.

## **Space Complexity**

- **O(1)** — apart from the output list, only the four boundary variables are used.

## **Code**

```python
class Solution:
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
        res = []

        top, bottom = 0, len(matrix) -1
        left, right = 0, len(matrix[0]) -1

        while top <= bottom and left <= right:
            # top
            for col in range(left, right+1):
                res.append(matrix[top][col])
            top += 1

            #right
            for row in range(top, bottom+1):
                res.append(matrix[row][right])
            right -= 1

            #bottom
            if top <= bottom:
                for col in range(right, left -1, -1):
                    res.append(matrix[bottom][col])
                bottom -= 1

            # left
            if left <= right:
                for row in range(bottom, top -1, -1):
                    res.append(matrix[row][left])
                left += 1

        return res
```
