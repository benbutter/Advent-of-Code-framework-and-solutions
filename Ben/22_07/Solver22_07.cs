using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_07
{
    public class Solver22_07 : ISolver
    {
      
        Directory topLevel;
        Directory currentDirectory;
        int lineCount = 0;
        private void SetCurrentDir(Directory dir)
        {
            currentDirectory = dir;
        }


        
      
        public Solver22_07()
        {
            topLevel = new Directory();
            topLevel.name = "/";
            SetCurrentDir(topLevel);
        }
        public string GetSolution(StreamReader input)
        {
            bool listMode = false;
            string line;
            List<Directory> directories = new List<Directory>();

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                lineCount++;
             
                if (line.Contains("$ cd"))
                {
                    listMode = false;
                    Move(line);
                }

                if (listMode)
                {
                    if (line.Contains("dir"))
                    {
                        CreateDirectory(line);
                    }
                    else if (Char.IsNumber(line[1]))
                    {
                        CreateFile(line);
                    }

                }

                if (line=="$ ls")
                {
                    listMode = true; 
                }


            }

            //part 2 
            const int spaceNeeded = 30000000;
            const int diskSize = 70000000;
            var amountAvailable = diskSize - topLevel.GetSize();

            var minimunSizeOfDirToDelete = spaceNeeded - amountAvailable;

            Directory deletionCandidate = null;

            topLevel.GetDirectories(directories);
            foreach (var dir in directories)
            {
                var size = dir.GetSize();
                
                if (size >= minimunSizeOfDirToDelete )
                {
                    if (deletionCandidate == null)
                    {
                        deletionCandidate = dir;
                    }

                    if (dir.GetSize() < deletionCandidate.GetSize())
                    {
                        deletionCandidate = dir;
                    }
                }
            }

            return deletionCandidate.GetSize().ToString();
            /*part1
            topLevel.GetDirectories(directories);
            int totalSize = 0;

            foreach (var dir in directories)
            {
                var size = dir.GetSize();
                if (size <= 100000)
                {
                    totalSize += size;
                }
            }
            return totalSize.ToString(); part1*/
        }

        private void Move(string line)
        {
            if (line[5] =='.' && line[6] == '.')
            {
                
                SetCurrentDir(currentDirectory.myParent);
            }
            else if (Char.IsLetter(line[5]))
            {
                foreach (var dir in currentDirectory.contents)
                {
                    if (dir.name == line.Replace("$ cd ", ""))
                    {
                        SetCurrentDir((Directory)dir);
                        break;
                    }
                }
            }
        }
        
        private void CreateFile(string line)
        {
            File file = new File();
            file.myParent = currentDirectory;
            currentDirectory.contents.Add(file);

            string sizeString ="";
            foreach (var c in line)
            {
                if (Char.IsNumber(c))
                {
                    sizeString += c;
                }
                else if (Char.IsLetter(c))
                {
                    file.name = c.ToString();
                }
            }

            file.size = Int32.Parse(sizeString);
        }

        private void CreateDirectory(string line)
        {
            Directory dir = new Directory();
            dir.myParent = currentDirectory;
            dir.name = line.Replace("dir ","");
            currentDirectory.contents.Add(dir);
            Console.WriteLine(dir.name);
        }
    }
}
