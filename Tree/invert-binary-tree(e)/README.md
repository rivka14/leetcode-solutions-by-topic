# **Explanation: Invert Binary Tree**

## **Problem:** [Invert Binary Tree - LeetCode](https://leetcode.com/problems/invert-binary-tree/)

### **Difficulty Level:** Easy

---

## **Description**  
Given the `root` of a binary tree, invert the tree — swap the left and right child of **every** node — and return its root.

---

## **Examples**

**Input:** `root = [4,2,7,1,3,6,9]`  
**Output:** `[4,7,2,9,6,3,1]`

**Input:** `root = [2,1,3]`  
**Output:** `[2,3,1]`

**Input:** `root = []`  
**Output:** `[]`

---

## **Approach**

We invert the tree with a simple **recursive DFS**:

1. If the current node is `None`, there is nothing to do — return it (base case).
2. Otherwise, swap the node's left and right children, recursively inverting each subtree as it is assigned.
3. Return the (now inverted) node.

Because Python evaluates the entire right-hand side of the tuple assignment **before** assigning, both `self.invertTree(root.right)` and `self.invertTree(root.left)` are computed first, so the swap is correct in a single line.

---

## **Time Complexity**
- **O(n)** — every node is visited exactly once.

## **Space Complexity**
- **O(h)** — the recursion stack, where `h` is the height of the tree (`O(n)` worst case for a skewed tree, `O(log n)` for a balanced one).

---

## **Code**

```python
# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def invertTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        if root:
            root.left, root.right = self.invertTree(root.right), self.invertTree(root.left)
        return root
```
