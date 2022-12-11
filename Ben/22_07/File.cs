using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_07
{
   public class File :  FileSystemEntity
    {
        public int size;

        public override int GetSize()
        {
            return size;
        }
    }
}
