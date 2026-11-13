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
