public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new();
        Stack<int> result  = new();

        for(int i = asteroids.Length - 1; i >= 0; i--){
            stack.Push(asteroids[i]);
        }

        while(stack.Count() != 0){
            if(result.Count() == 0) 
                result.Push(stack.Pop());
            else {
                int r = result.Peek(), s = stack.Peek();
                if(Math.Sign(r) <= Math.Sign(s))
                    result.Push(stack.Pop());
                else if(Math.Abs(r) == Math.Abs(s) && Math.Sign(r) != Math.Sign(s)){
                    result.Pop();
                    stack.Pop();
                }
                else if(Math.Abs(r) < Math.Abs(s)){
                    result.Pop();
                }
                else 
                    stack.Pop();
            }
        }
        
        int[] output = new int[result.Count()];
        for(int i = output.Length - 1; i >= 0 ; i--){
            output[i] = result.Pop();
        }

        return output;
    }
}
