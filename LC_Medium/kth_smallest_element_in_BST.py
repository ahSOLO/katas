# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):    
    def kthSmallest(self, root, k):
        """
        :type root: TreeNode
        :type k: int
        :rtype: int
        """

        if not root.left and not root.right:
            return root.val

        output = []
        self.kthSmallestRec(root, k, output)

        return output[len(output) - 1]


    def kthSmallestRec(self, root, k, output):
        """
        :type root: TreeNode
        :type k: int
        """

        if root.left:
            self.kthSmallestRec(root.left, k, output)

        if len(output) is k:
            return

        output.append(root.val)            
        
        if root.right:
            self.kthSmallestRec(root.right, k, output)