class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        prev_nums = {}
        for i, num in enumerate(nums):
            complement_num = target - num
            if complement_num in prev_nums:
                return [prev_nums[complement_num], i]

            prev_nums[num] = i

        return []
