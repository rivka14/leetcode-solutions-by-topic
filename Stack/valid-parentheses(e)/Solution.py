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
