public class BrowserHistory {

    private List<string> history;
    private int historyCount;
    private int current;

    public BrowserHistory(string homepage) {
        history = new List<string>() {homepage};
        historyCount = 1;
        current = 0;
    }
    
    public void Visit(string url) {
        current++;
        historyCount = current + 1;
        if (history.Count > current)
        {
            history[current] = url;
        }
        else
        {
            history.Add(url);
        }
    }
    
    public string Back(int steps) {
        var toVisit = Math.Max(current - steps, 0);
        current = toVisit;
        return history[current];
    }
    
    public string Forward(int steps) {
        var toVisit = Math.Min(current + steps, historyCount - 1);
        current = toVisit;
        return history[current];
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */