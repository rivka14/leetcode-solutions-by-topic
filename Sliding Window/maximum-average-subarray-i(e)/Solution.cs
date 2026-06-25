public double FindMaxAverage(int[] nums, int k)
{
    double sum = nums[..k].Sum();
    double max = sum;

    for (int right = k; right < nums.Length; right++) {
        sum += nums[right] - nums[right - k];
        max = Math.Max(max, sum);
    }

    return max / k;
}
