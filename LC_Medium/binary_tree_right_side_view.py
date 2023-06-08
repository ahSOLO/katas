# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def rightSideView(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """

        output = []
        if (not root):
            return output

        q = collections.deque()
        q.append(root)

        while len(q) > 0:
            l = len(q)
            for i in range(l):
                cur = q.popleft()
                if (i == l - 1):
                    output.append(cur.val)
                if (cur.left):
                    q.append(cur.left)
                if (cur.right):
                    q.append(cur.right)
        
        return output