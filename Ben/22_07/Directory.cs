using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_07
{
    public class Directory : FileSystemEntity
    {
        public List<FileSystemEntity> contents;

        public Directory()
        {
            contents = new List<FileSystemEntity>();
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (var item in contents)
            {
                size += item.GetSize();
            }

          //  Console.WriteLine(name + ":" + size.ToString());
            return size;
            
        }

        public override void GetDirectories(List<Directory> list)
        {
            foreach (var item in contents)
            {
                item.GetDirectories(list);
            }

            list.Add(this);
        }
    }
}
