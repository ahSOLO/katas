/*
You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/

/**
 * @param {number} n
 * @return {number}
 */

const climbStairs = function(n) {
  if (n === 0) return 0;
  if (n === 1) return 1;
  if (n === 2) return 2;

  // n = (n-1) + (n-2)
  // Start iteration at 3rd stair
  let oneBefore = 2;
  let twoBefore = 1;
  let temp = 0;
  for (i = 2; i < n - 1; i++) {
    temp = oneBefore;
    oneBefore = oneBefore + twoBefore;
    twoBefore = temp;
  }

  return oneBefore + twoBefore;
};