#include <iostream>
#include <string>
#include <vector>

// condfidence in solution: 3/10
// it works well but I feel like nested for loops is bad
// I shouldnt have used a struct for Group either, because I cant loop through it

struct Group
{
  std::string  firstMember;
  std::string  secondMember;
  std::string  thirdMember;
};

int getItemValue(char item)
{
  
  int itemValue = item - 96;
  if (itemValue < 0)
      itemValue += 58;
  return itemValue;
}

int main(int argc, char **argv)
{
  std::vector<Group> AllGroups;  
  // get input
  std::string input = "placeholder data";

  while(input != "")
  {
    Group tempGroup;

    // eww
    getline(std::cin, input);
    tempGroup.firstMember = input;
    getline(std::cin, input);
    tempGroup.secondMember = input;
    getline(std::cin, input);
    tempGroup.thirdMember = input;


    AllGroups.push_back(tempGroup);
  }
  
  int totalValue = 0;
  for (Group group : AllGroups)
  {
    // not sure about this...
    for(char item : group.firstMember)
    {
      if (group.secondMember.find_first_of(item) != std::string::npos)
      {
        if (group.thirdMember.find_first_of(item) != std::string::npos)
        {
          totalValue += getItemValue(item);
          break;
        }
      }
    }
  }
  
  printf("%i", totalValue);
  return 0;
}