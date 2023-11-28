# AOC-2022

Simple framework and solutions for Advent of Code. 

How to use:
Create Class to be the main Class for the challenge. One Class per challenge. 

Then reimplement the ISolver interface this will give the Class the method GetSolution(StreamReader input) use this to create your answer

 this method should be coded as such
 
   public int GetSolution( StreamReader input)
        {
          int answer;
          //Read stream using streamreader passed
          //Work out answer
          return answer;
        }

To execute run the Gui app - this will list all Classes that implement ISolver. Choose the one to run, then select the input file and click run.
        
 Input is also provided for the solver in this folder. create a file called input.txt and paste in your input. Remember your input id persoanlized to you as is the answer.
 C.copy and paste into the file is the easiest way to vary input - use the example/someone elses input/ your own test input
 
