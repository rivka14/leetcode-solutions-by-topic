# **Explanation: Roman to Integer**

## **Problem:** [Roman to Integer - LeetCode](https://leetcode.com/problems/roman-to-integer/)

### **Difficulty Level:** Easy

---

## **Description**
Roman numerals are written with seven symbols:

| Symbol | Value |
|--------|-------|
| `I`    | 1     |
| `V`    | 5     |
| `X`    | 10    |
| `L`    | 50    |
| `C`    | 100   |
| `D`    | 500   |
| `M`    | 1000  |

Numerals are usually written from largest to smallest, left to right, and their values are
added (`XII` = 10 + 1 + 1 = 12). There are six exceptions where **subtraction** is used
instead — a smaller symbol placed before a larger one:

- `I` before `V` (5) or `X` (10) → 4 and 9
- `X` before `L` (50) or `C` (100) → 40 and 90
- `C` before `D` (500) or `M` (1000) → 400 and 900

Given a valid Roman numeral `s` (in the range 1–3999), convert it to an integer.

---

## **Examples**

**Input:** `s = "III"`
**Output:** `3`

**Input:** `s = "LVIII"`
**Output:** `58` (L = 50, V = 5, III = 3)

**Input:** `s = "MCMXCIV"`
**Output:** `1994` (M = 1000, CM = 900, XC = 90, IV = 4)

---

## **Approach**

We use a **hash map** (`convert`) to look up each symbol's value in O(1), and make a single
left-to-right pass:

1. For each character `s[i]`, compare its value with the value of the **next** character.
2. If the current value is **smaller** than the next one, it is part of a subtractive pair
   (e.g. the `I` in `IV`) → **subtract** it from the total.
3. Otherwise → **add** it to the total.
4. The last character has no neighbor, so it is always added.

For example, `MCMXCIV`:

| Char | Next | Action | Total |
|------|------|--------|-------|
| M (1000) | C (100)  | add      | 1000 |
| C (100)  | M (1000) | subtract | 900  |
| M (1000) | X (10)   | add      | 1900 |
| X (10)   | C (100)  | subtract | 1890 |
| C (100)  | I (1)    | add      | 1990 |
| I (1)    | V (5)    | subtract | 1989 |
| V (5)    | —        | add      | 1994 |

This works because in a subtractive pair like `IV`, "−1 then +5" equals 4 — so we never
need to treat pairs as special two-character tokens.

---

## **Time Complexity**
- **O(n)** — one pass over the string, with O(1) hash-map lookups.

## **Space Complexity**
- **O(1)** — the map always holds exactly 7 entries, regardless of input size.

---

## **Code**

```python
class Solution:
    def romanToInt(self, s: str) -> int:
        convert = {
           "I": 1,
           "V": 5,
           "X": 10,
           "L": 50,
           "C": 100,
           "D": 500,
           "M": 1000
        }
        n = 0
        for i in range(len(s)):
            if i + 1 < len(s) and convert[s[i]] < convert[s[i+1]]:
                n -= convert[s[i]]
            else:
                n += convert[s[i]]

        return n
```
