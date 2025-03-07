# **Explanation: Asteroid Collision**

## **Problem:** [Asteroid Collision](https://leetcode.com/problems/asteroid-collision/)

### **Difficulty Level: Medium**

## **Description:**
You are given an array `asteroids` where each asteroid is represented as an integer:
- **Positive values** (`> 0`) represent asteroids moving to the **right**.
- **Negative values** (`< 0`) represent asteroids moving to the **left**.

Asteroids move in the given order. If two asteroids **collide**:
- The **smaller** asteroid is destroyed.
- If they are **equal in size**, both are destroyed.
- If a moving left asteroid (`< 0`) collides with a moving right asteroid (`> 0`), only the larger one remains.

Return an array of remaining asteroids **after all collisions are resolved**.

---

## **Example 1:**
### **Input:**
```csharp
asteroids = [5, 10, -5]
```
### **Output:**
```csharp
[5, 10]
```
### **Explanation:**
- The asteroid `-5` moves left and collides with `10`.
- Since `10 > 5`, `-5` is destroyed, leaving `[5, 10]`.

---

## **Example 2:**
### **Input:**
```csharp
asteroids = [8, -8]
```
### **Output:**
```csharp
[]
```
### **Explanation:**
- `8` and `-8` collide and destroy each other.

---

## **Solution Explanation:**
This problem can be efficiently solved using a **stack**:

### **Approach:**
1. **Iterate through the asteroids list**:
   - If an asteroid is **positive** (`> 0`), push it onto the stack.
   - If an asteroid is **negative** (`< 0`), check for possible collisions.
2. **Handle collisions**:
   - Compare the negative asteroid with the top of the stack (which is moving right).
   - If the stack’s top is **smaller**, pop it (it gets destroyed).
   - If the stack’s top is **equal**, pop it and **remove both**.
   - If the stack’s top is **larger**, the negative asteroid gets destroyed.
   - If no positive asteroids remain in the stack, push the negative asteroid.
3. **Convert the stack to an array and return the result**.

---

## **Time Complexity:**
- **O(N)**: Each asteroid is processed once, and each element is pushed and popped from the stack at most once.

## **Space Complexity:**
- **O(N)**: In the worst case, all asteroids are stored in the stack.

---

## **Code Implementation:**
```csharp
public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
    
        foreach (int asteroid in asteroids) {
            if (asteroid > 0) {  
                stack.Push(asteroid);
            } else {  
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid)) {
                    stack.Pop();
                }
                
                if (stack.Count == 0 || stack.Peek() < 0) {
                    stack.Push(asteroid);
                } else if (stack.Peek() == Math.Abs(asteroid)) {
                    stack.Pop();
                }
            }
        }
        
        return stack.Reverse().ToArray();
    }
}
```

---

### **Alternative Approach:**
Instead of using a stack explicitly, we could use a **list** as a stack-like structure, but it would have the same time complexity. The stack-based approach is cleaner and more intuitive for this problem.

**Let me know if you need more details or improvements! 🚀**


