class Solution(object):
    def removeStars(self, s):
        """
        :type s: str
        :rtype: str
        """
        stack = [] 
        
        for c in s:
            if c != '*':
                stack.append(c)
            elif stack:
                stack.pop()
        
        return ''.join(stack)

