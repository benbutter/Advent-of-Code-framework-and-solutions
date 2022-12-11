using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_07
{
   public  class FileSystemEntity
    {
        public Directory myParent;
        public string name;

        public virtual int GetSize()
        {
            return 0;
        }

        public virtual void GetDirectories(List<Directory> list)
        {
           
        }
    }
}
