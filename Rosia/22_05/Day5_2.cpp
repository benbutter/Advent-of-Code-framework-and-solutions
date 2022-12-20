#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>
#include <stack>

std::vector<std::stack<char>> getInput();
std::vector<std::vector<int>> getInstructions();
int extractIntFromString(std::string string, int index);
bool isEndOfGrid(std::string string);

/*
Rosia you should probably be using pointers for the stacks in the vector coming out of getInput()
*/

int main(int argc, char **argv)
{
    std::vector<std::stack<char>> data = getInput();

    std::vector<std::vector<int>> instructions = getInstructions();

    for (int i = 0; i < instructions.size(); i++)
    {
        std::vector<char> cache;
        for (int j = 0; j < instructions[i][0]; j++)
        {
            cache.push_back(data[instructions[i][1]-1].top());
            data[instructions[i][1]-1].pop();
        }

        for (int j = 0; j < instructions[i][0]; j++)
        {
            data[instructions[i][2]-1].push(cache.back());
            cache.pop_back();
        }
    }


    for (int i = 0; i < data.size(); i++)
    {
        printf("%c", data[i].top());
    }
}

std::vector<std::stack<char>> getInput()
{
    // store input in horizontal lists
    std::vector<std::vector<char>> resultingGrid;
    std::string input = "  ";
    while (true)
    {
        // get line, if its the end of the grid, end this loop
        std::getline(std::cin, input);
        if (isEndOfGrid(input))
            break;

        // put line in 2D vector
        std::vector<char> cache;
        for (int i = 1; i < input.length(); i=i+4)
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
        for (int j = resultingGrid.size()-1; j >= 0; j--)
        {
            if (resultingGrid[j][i] != ' ')
                resultingStacks[i].push(resultingGrid[j][i]);
        }
    }

    return resultingStacks;
}

std::vector<std::vector<int>> getInstructions()
{
    std::vector<std::vector<int>> results;
    std::string input = " ";

    // go past blank lines till we reach actual text
    while (input == " ") std::getline(std::cin, input);


    while (true)
    {
        std::getline(std::cin, input);
        if (input == "")
            break;

        results.push_back(std::vector<int>());
        for (int i = 0; i < 3; i++)
        {
            results.back().push_back(extractIntFromString(input, i));
        }
    }

    return results;
}

// extracts an int from a string, index is which int to extract, 0 will get first integer, 1 will get second so on.
int extractIntFromString(std::string string, int index)
{
    size_t intStartPos = 0;
    size_t intEndPos = 0;

    for (int i = 0; i < index+1; i++)
    {
        intStartPos = string.find_first_of("0123456789", intEndPos);
        intEndPos = string.find_first_not_of("0123456789", intStartPos);
    }

    return std::stoi(string.substr(intStartPos, intEndPos-intStartPos));
}


// this doesnt feel very robust
bool isEndOfGrid(std::string string)
{
    if (string[0] == ' ' && string[1] == '1')
        return true;
    return false;
}


