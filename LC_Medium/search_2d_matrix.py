class Solution(object):
    def searchMatrix(self, matrix, target):
        """
        :type matrix: List[List[int]]
        :type target: int
        :rtype: bool
        """

        l = 0
        r = len(matrix) - 1

        while l <= r:
            m = (l + r)//2
            if (matrix[m][0] > target):
                r = m - 1
            elif (matrix[m][len(matrix[m]) - 1] < target):
                l = m + 1
            elif (matrix[m][0] <= target <= matrix[m][len(matrix[m]) - 1]):
                # perform binary search
                return self.searchArray(matrix[m], target)
            else:
                break

        return False

    def searchArray(self, array, target):
        """
        :type matrix: List[int]
        :type target: int
        :rtype: bool
        """
        l = 0
        r = len(array) - 1

        while l <= r:
            m = (l + r)//2
            if (array[m] > target):
                r = m - 1
            elif (array[m] < target):
                l = m + 1
            else:
                return True

        return False