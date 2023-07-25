public class Solution {
    HashSet<int> visited = new HashSet<int>();
    Dictionary<int, List<int>> courseMap = new Dictionary<int, List<int>>();

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for (int i = 0; i < numCourses; i++)
        {
            courseMap.Add(i, new List<int>());
        }
        foreach (int[] entry in prerequisites)
        {
            courseMap[entry[0]].Add(entry[1]);
        }
        for (int i = 0; i < numCourses; i++)
        {
            visited.Clear();
            if (dfs(i) == false)
            {
                return false;
            }
        }
        return true;
    }

    public bool dfs(int courseNum)
    {
        if (visited.Contains(courseNum))
        {
            return false;
        }
        visited.Add(courseNum);
        for (int i = courseMap[courseNum].Count - 1; i >= 0; i--)
        {
            int prereq = courseMap[courseNum][i];
            if (dfs(prereq) == false)
            {
                return false;
            }
            courseMap[courseNum].RemoveAt(i);
        }
        if (courseMap[courseNum].Count == 0)
        {
            visited.Remove(courseNum);
        }
        return true;
    }
}