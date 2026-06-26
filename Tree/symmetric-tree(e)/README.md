# **Explanation: Symmetric Tree**

## **Problem:** [Symmetric Tree - LeetCode](https://leetcode.com/problems/symmetric-tree/)

### **Difficulty Level:** Easy

---

## **Description**  
Given the `root` of a binary tree, return `true` if the tree is **symmetric** — a mirror image of itself around its center — and `false` otherwise.

---

## **Examples**

**Input:** `root = [1,2,2,3,4,4,3]`  
**Output:** `true`

**Input:** `root = [1,2,2,null,3,null,3]`  
**Output:** `false`

---

## **Approach**

Two subtrees are mirror images when their roots hold the same value and each subtree mirrors the **opposite** subtree of the other. We capture this with a helper `mirror(left, right)`:

1. If **both** nodes are `None`, they mirror → return `True` (base case).
2. If **only one** is `None`, the structure differs → return `False`.
3. Otherwise the values must match **and** the outer pair (`left.left`, `right.right`) and the inner pair (`left.right`, `right.left`) must each mirror.

We kick the check off on the root's two children: `mirror(root.left, root.right)`.

---

## **Time Complexity**
- **O(n)** — each node is compared at most once.

## **Space Complexity**
- **O(h)** — recursion stack, where `h` is the height of the tree (`O(n)` worst case for a skewed tree, `O(log n)` if balanced).

---

## **Code**

```python
class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        def mirror(left, right):
            if not left and not right:
                return True
            if not left or not right:
                return False
            return (left.val == right.val and
                    mirror(left.left, right.right) and
                    mirror(left.right, right.left))

        return mirror(root.left, root.right)
```
