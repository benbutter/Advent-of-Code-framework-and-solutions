#include <iostream>
#include <string>
#include <vector>

// condfidence in solution: 5/10
// it works well but I feel like nested for loops is bad

struct Rucksack
{
  std::string  firstCompartment;
  std::string  secondCompartment;
};

Rucksack getRucksackFromString(std::string string)
{
  int midPoint = string.length()/2;
  return
  {
  string.substr(0, midPoint),
  string.substr(midPoint, string.length())
  };
}

int getItemValue(char item)
{
  // get items value, a-z = 1-26, A-Z = 27-53
  int itemValue = item - 96;
  if (itemValue < 0)
      itemValue += 58;
  return itemValue;
}


int main(int argc, char **argv)
{
  std::vector<Rucksack> AllRucksacks;  
  // get input
  std::string input = "placeholder data";
  while(input != "")
  {
    getline(std::cin, input);
    AllRucksacks.push_back(getRucksackFromString(input));
  }
  
  
  int totalValue = 0;
  for (Rucksack rucksack : AllRucksacks)
  {
    // not sure about this...
    for(char item : rucksack.secondCompartment)
    {
      if (rucksack.firstCompartment.find_first_of(item) != std::string::npos)
      {
                
        totalValue += getItemValue(item);
        break;    
      }
    }
  }
  
  printf("%i", totalValue);
  return 0;
}