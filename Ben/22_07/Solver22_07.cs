using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_07
{
    class Solver22_07 : ISolver
    {
        StreamReader input;
        Directory topLevel;
        Directory currentDirectory;
        int lineCount = 0;
        private void SetCurrentDir(Directory dir)
        {
            if (dir == null)
            {
                var a = 'a';
            }
            currentDirectory = dir;
        }


        
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public Solver22_07()
        {
            topLevel = new Directory();
            topLevel.name = "/";
            SetCurrentDir(topLevel);
        }
        public string GetSolution()
        {
            bool listMode = false;
            string line;
            List<Directory> directories = new List<Directory>();

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                lineCount++;
                if (lineCount == 16)
                {
                    var a = 'a';
                }

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

            // topLevel.GetSize();
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
            return totalSize.ToString();
        }

        private void Move(string line)
        {
            if (line[5] =='.' && line[6] == '.')
            {
                if (currentDirectory.myParent == null)
                {
                    var a = 'a';
                }
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
