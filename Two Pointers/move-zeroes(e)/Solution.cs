public class Solution {
    public void MoveZeroes(int[] nums) {
        int position = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[position] = nums[i];
                position++;
            }
        }

        for (int i = position; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}
