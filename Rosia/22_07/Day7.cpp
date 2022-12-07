#include <iostream>
#include <stdio.h>
#include <string>

#include <vector>

struct pair
{
    int firstRange[2];
    int secondRange[2];
};

int main(int argc, char **argv)
{
    std::vector<pair> allPairs;

    std::string currentInput = "placeHolder";
    while (currentInput != "")
    {
        std::getline(std::cin, currentInput);
        printf(currentInput.c_str());
    }
}