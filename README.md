# AOC-solutions and framework

c# framework and solutions for Advent of Code. 

How to use:
Create Class to be the main Class for the challenge. One Class per daily challenge. 

Implement the ISolver interface this will give the Class the method GetSolution(StreamReader input) use this to create your answer.

 this method should be coded as such
 
   public string GetSolution( StreamReader input)
        {
          int answer;
          //Read stream using streamreader passed
          //Work out answer
          return answer;
        }

To execute run the Gui app - this will list all Classes that implement ISolver. Choose the one to run, then select the input file and click run.
        
 
