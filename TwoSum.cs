/*
    Name: Roberto Sanchez
    Date: 2/2/19

    Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].  `
*/
public class TwoSums {
	public int[] TwoSum(int[] nums, int target)
  {
		int[] Found = new int[2];
		int sizeOfArray = nums.Length;
		for (int i = 0; i < sizeOfArray; i++)
    {
			for (int j = i + 1; j < sizeOfArray; j++)
      {
				if (nums[i] + nums[j] == target)
        {
					Found[0] = i;
					Found[1] = j;
					return Found;
				}
			}
		}
		return Found;
	}
}
