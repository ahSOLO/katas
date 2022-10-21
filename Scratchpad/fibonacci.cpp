#include <iostream>
#include <unordered_map>

int fibonacci(int num, std::unordered_map<int,int> memo) {
    if (num <= 0)
    {
        return 0;
    }
    else if (num == 1)
    {
        return 1;
    }
    else 
    {
        if (memo.find(num) != memo.end())
        {
          return memo[num];
        }
        else
        {
          memo[num] = fibonacci(num - 2, memo) + fibonacci(num - 1, memo);
          return memo[num];
        }
    }
}

int main() {
    std::unordered_map<int,int> memo;
    std::cout << fibonacci(10, memo);
    return 0;
}