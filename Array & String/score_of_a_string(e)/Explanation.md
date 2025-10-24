# **Explanation: Score of a String**

## **Problem:** [Score of a String - LeetCode](https://leetcode.com/problems/score-of-a-string/description/)

### **Difficulty Level:** Easy

---

## **Description**  
The **score of a string** is defined as the sum of the absolute differences between the ASCII (or Unicode) values of adjacent characters.  
Formally, for a string `s` of length `n`, the score is:

```
|s[1] - s[0]| + |s[2] - s[1]| + ... + |s[n-1] - s[n-2]|
```

Return the total score of the given string `s`.

---

## **Example**

**Input:** `s = "hello"`  
**Output:** `13`  
**Explanation (ASCII differences):**  
```
'h'->'e' : |104 - 101| = 3
'e'->'l' : |101 - 108| = 7
'l'->'l' : |108 - 108| = 0
'l'->'o' : |108 - 111| = 3
Total = 3 + 7 + 0 + 3 = 13
```

**Input:** `s = "az"`  
**Output:** `25`  
**Explanation:** `|97 - 122| = 25`


---

## **Approach**

We iterate through the string once, summing the absolute difference between each character and its previous character:

1. If the string length is less than 2, return `0` (no adjacent pairs).
2. Initialize an accumulator (`score = 0`).
3. Loop `i` from `1` to `len(s)-1`:
   - Add `abs(ord(s[i]) - ord(s[i-1]))` to `score`.
4. Return `score`.

This is a straightforward linear pass.

---

## **Time Complexity**
- **O(n)** where `n` is the length of the string `s`. We visit each character once (except the first for pairs).

## **Space Complexity**
- **O(1)** extra space (only a few variables used).

---

## **Code (Python)**

```python
def scoreOfString(s: str) -> int:
    score = 0
    for i in range(1, len(s)):
        score += abs(ord(s[i]) - ord(s[i - 1]))

    return score
```
