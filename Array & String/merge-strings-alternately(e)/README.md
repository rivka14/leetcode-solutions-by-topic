# **Explanation: Merge Strings Alternately**

## **Problem:** [Merge Strings Alternately - LeetCode](https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Easy

---

## **Description**  
You are given two strings `word1` and `word2`.  
Merge the strings by adding letters in alternating order, starting with `word1`.  
If one string is longer than the other, append the additional letters to the end of the merged string.

---

## **Example**

**Input:** `word1 = "abc"`, `word2 = "pqr"`  
**Output:** `"apbqcr"`  
**Explanation:**  
```
word1:   a   b   c  
word2:     p   q   r  
merged: a p b q c r
```

**Input:** `word1 = "ab"`, `word2 = "pqrs"`  
**Output:** `"apbqrs"`  
**Explanation:**  
```
word1:   a   b  
word2:     p   q   r   s  
merged: a p b q     r   s
```

**Input:** `word1 = "abcd"`, `word2 = "pq"`  
**Output:** `"apbqcd"`  
**Explanation:**  
```
word1:   a   b   c   d  
word2:     p   q  
merged: a p b q c   d
```

---

## **Approach**

We use a **StringBuilder** and loop through both strings in parallel:

1. Calculate the lengths of both strings and find the minimum length (`min`).
2. Loop from `0` to `min` and alternate appending characters from `word1` and `word2`.
3. After the loop, check which string is longer:
   - If `word1` is longer, append the remaining characters starting from `min`.
   - If `word2` is longer, append its remaining characters starting from `min`.

This approach ensures the strings are merged alternately, and any extra characters are correctly appended.

---

## **Time Complexity**
- **O(n + m)** where `n` is the length of `word1` and `m` is the length of `word2`.

## **Space Complexity**
- **O(n + m)** for the `StringBuilder` result.

---

## **Code**

```csharp
public string MergeAlternately(string word1, string word2) {
    int len1 = word1.Length, len2 = word2.Length;
    int min = Math.Min(len1, len2);
    var sb = new StringBuilder(len1 + len2);

    for (int i = 0; i < min; i++) {
        sb.Append(word1[i]).Append(word2[i]);
    }

    if (len1 > min) sb.Append(word1, min, len1 - min);
    if (len2 > min) sb.Append(word2, min, len2 - min);

    return sb.ToString();
}
```
