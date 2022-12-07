#include <stdio.h>
#include <iostream>

#include <string.h>
#include <stdlib.h>

#include <vector>

// confidence in my solution: 5/10
// it should always work but it feels messy and it has some jank solutions to problems in it


// takes a list of 3 values, list is ordered in size, will add a new number to that list
// if its not the smallest, will add it in the correct place in the order
void alterList(int list[3], int toAdd)
{
    for (int i = 0; i < 3; i++)
    {
      if (toAdd > list[i])
      {
        int cache = list[i];
        list[i] = toAdd;
        alterList(list, cache);
        return;
      }
    }
}



int main(int argc, char **argv)
{
  std::vector<int> numbers;
  
  printf("type a value, press enter, type -1 on an empty line to end input\n");  
  
  char givenValue[100] = ""; // defined outside of while to keep it in scope
  do
  {
    fgets(givenValue, 100, stdin);
    
    if (givenValue[0] == '\n')
      numbers.push_back(-1);
    else
      numbers.push_back(strtol(givenValue, NULL, 10));
  }
  while (givenValue[0] != '-');
  numbers.pop_back();

  
  
  int largestValues[3] = {0, 0, 0};
  int currentValue = 0;
  
  int counter = 0;
  while (counter < numbers.size())
  {
    if (numbers[counter] == -1)
    {
      if (currentValue > largestValues[2]) // if bigger than the smallest number on the biggest numbers list
        alterList(largestValues, currentValue);
      currentValue = 0;
    }
    else
    {
      currentValue += numbers[counter];
    }
    
    counter++;
  }
  
  int total = 0;
  for(int i : largestValues)
  {
    total += i;
  }
  
  printf("the largest values are: %i, %i and %i", largestValues[0], largestValues[1], largestValues[2]);
  printf("the total value of these is %i", total); 
}


