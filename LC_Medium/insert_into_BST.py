# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def insertIntoBST(self, root, val):
        """
        :type root: TreeNode
        :type val: int
        :rtype: TreeNode
        """

        cur = root
        while (cur != None):
            if (cur.val > val):
                if (cur.left):
                    cur = cur.left
                else:
                    cur.left = TreeNode(val)
                    break
            elif (cur.val < val):
                if (cur.right):
                    cur = cur.right
                else:
                    cur.right = TreeNode(val)
                    break

        if (root == None):
            root = TreeNode(val)
        
        return root