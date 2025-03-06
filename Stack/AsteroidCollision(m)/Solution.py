class Solution:
    def asteroidCollision(self, asteroids: List[int]) -> List[int]:
        stack = deque()
        result = deque()

        for i in range(len(asteroids) - 1, -1, -1):
            stack.append(asteroids[i])

        while stack:
            if not result:
                result.append(stack.pop())
            else:
                r = result[-1]
                s = stack[-1]
                
                if (r > 0 and s > 0) or (r < 0 and s < 0) or (r < 0 and s > 0):
                    result.append(stack.pop())
                elif abs(r) == abs(s) and (r < 0 < s or s < 0 < r):
                    result.pop()
                    stack.pop()
                elif abs(r) < abs(s):
                    result.pop()
                else:
                    stack.pop()

        return list(result)
