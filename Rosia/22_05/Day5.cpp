#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>
#include <stack>

std::vector<std::stack<char>> getInput();
bool isEndOfGrid(std::string string);

/*
Rosia you should probably be using pointers for the stacks in the vector coming out of getInput()
*/

int main(int argc, char **argv)
{
    std::vector<std::stack<char>> data = getInput();

    for (int i = 0; i < data[0].size(); i++)
    {
        printf("%c\n", data[0].top());
        data[0].pop();
    }
}

std::vector<std::stack<char>> getInput()
{
    // store input in horizontal lists
    std::vector<std::vector<char>> resultingGrid;
    std::string input = "  ";
    while (!isEndOfGrid(input))
    {
        std::getline(std::cin, input);

        std::vector<char> cache;
        for (int i = 1; i < input.length(); i=i+3)
        {
            cache.push_back(input[i]);
        }
        resultingGrid.push_back(cache);
    }

    // convert horizontal lists to vertical stacks
    std::vector<std::stack<char>> resultingStacks;
    for (int i = 0; i < resultingGrid[0].size(); i++)
    {
        resultingStacks.push_back(std::stack<char>());
        for (int j = resultingGrid.size(); j > 0; j--)
        {
            resultingStacks[i].push(resultingGrid[j][i]);
        }
    }

    return resultingStacks;
}

// this doesnt feel very robust
bool isEndOfGrid(std::string string)
{
    if (string[0] == ' ' && string[1] == '1')
        return true;
    return false;
}


