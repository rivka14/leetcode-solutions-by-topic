# **Explanation: Valid Parentheses**

## **Problem:** [Valid Parentheses - LeetCode](https://leetcode.com/problems/valid-parentheses/)

### **Difficulty Level:** Easy

---

## **Description**  
Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`,
determine if the input string is **valid**.

A string is valid when:
- Every open bracket is closed by the **same type** of bracket.
- Open brackets are closed in the **correct order**.
- Every close bracket has a corresponding open bracket of the same type.

---

## **Examples**  
**Input:** `s = "()[]{}"`  
**Output:** `true`

**Input:** `s = "(]"`  
**Output:** `false`

**Input:** `s = "([)]"`  
**Output:** `false`

---

## **Approach**

We use a **stack** to track the open brackets we still expect to close:

1. Build a `pairs` map from each closing bracket to its matching opening bracket, and a set
   of the opening characters.
2. Iterate over the string:
   - If the character is an **open** bracket, push it onto the stack.
   - If it is a **close** bracket, the stack must be non-empty **and** its top must be the
     matching open bracket. If the stack is empty or the top does not match, the string is
     invalid, so return `false`.
3. After the loop, the string is valid only if the stack is **empty** — any leftover open
   bracket was never closed.

The stack naturally enforces the correct nesting order: the most recent open bracket must be
the first one closed.

---

## **Time Complexity**
- **O(n)** – Each character is processed once, with O(1) stack operations.

## **Space Complexity**
- **O(n)** – In the worst case (all opening brackets) the stack holds every character.

---

## **Code**

```python
class Solution:
    def isValid(self, s: str) -> bool:
        pairs = {')': '(', ']': '[', '}': '{'}
        open_char = set(pairs.values())
        current_open = []

        for char in s:
            if char in open_char:
                current_open.append(char)
            elif char in pairs:
                if not current_open or pairs[char] != current_open.pop():
                    return False

        return not current_open
```
