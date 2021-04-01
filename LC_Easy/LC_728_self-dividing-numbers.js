/* https://leetcode.com/problems/self-dividing-numbers/

A self-dividing number is a number that is divisible by every digit it contains.

For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

Also, a self-dividing number is not allowed to contain the digit zero.

Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.

Example 1:
  Input: 
  left = 1, right = 22
  Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
Note:
- The boundaries of each input argument are 1 <= left <= right <= 10000.

*/

/**
 * @param {number} left
 * @param {number} right
 * @return {number[]}
 */

// Helper function to get the nth digit of an integer - faster than toString method
const getDigit = function(digit, number) {
  return Math.floor((number / Math.pow(10, digit - 1)) % 10);
}

// Helper function to get length of an integer - faster than toString method
const getLength = function(number) {
  // Multiplying natural log by LOG10E because Math.log10 is not supported by legacy browsers
  return Math.log(number) * Math.LOG10E + 1 | 0;
}

const selfDividingNumbers = function(left, right) {
  // Generate the range of potential numbers inside an array
  const range = [...Array(right + 1 - left).keys()].map( i => i + left);
  // Filter only the numbers that...
  const output = range.filter( num => {
    // Are less than 10 (automatically self-dividing), or...
    if (num < 10) {
      return true;
    }
    // Is self-dividing for each of the digits
    const digits = getLength(num);
    for (let digitNum = 1; digitNum <= digits; digitNum++) {
      const digit = getDigit(digitNum, num)
      if (digit === 0) {
        return false;
      }
      else if (num % digit !== 0) {
        return false;
      }
    }
    return true;
  })
  return output;
}