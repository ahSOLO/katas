/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:
  Input: nums = [2,7,11,15], target = 9
  Output: [0,1]
  Output: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
  Input: nums = [3,2,4], target = 6
  Output: [1,2]

Example 3:
  Input: nums = [3,3], target = 6
  Output: [0,1]

*/

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
*/

// Bruce Force Attempt:

const twoSum_BF = function(nums, target) {
  let output = null;
  // use .some to break out of iteration early if a match is found
  nums.some( (num, i) => {
    const diff = target - num;
    // begin inner loop at index + 1 to avoid duplicate comparisons
    for (let i_ = i + 1; i_ < nums.length; i_++) {
      if (nums[i_] === diff) {
        return output = [i, i_];
      }
    }
  })
  return output;
};

// Using Maps (solution is not mine):

const twoSum = (nums, target) => {
  const obj = {};

  for (let i = 0; i < nums.length; i++) {
    const another = target - nums[i];

    if (another in obj) {
      return [obj[another], i];
    }

    obj[nums[i]] = i;
  }

  return null;
};