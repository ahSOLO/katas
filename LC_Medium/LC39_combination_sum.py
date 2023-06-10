class Solution:
    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        output = []
        self.combinationSumRec(0, candidates, [], 0, target, output)
        return output

    def combinationSumRec(self, i: int, candidates: List[int], cur: List[int], curSum: int, target: int, output: List[List[int]]) -> None:
        if curSum > target or i == len(candidates):
            return
        if curSum == target:
            output.append(copy.copy(cur))
            return

        cur.append(candidates[i])
        self.combinationSumRec(i, candidates, cur, curSum + candidates[i], target, output)
        cur.pop()
        self.combinationSumRec(i+1, candidates, cur, curSum, target, output)