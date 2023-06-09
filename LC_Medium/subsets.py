class Solution(object):
    def subsets(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        output = [[]]

        for i in nums:
            l = len(output)
            for x in range(0,l):
                output.append(output[x] + [i])

        return output
