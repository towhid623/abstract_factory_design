using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public class DellStorage : IStorage
    {
        private int storageSize;
        public DellStorage(int storageSize)
        {
            this.storageSize = storageSize;
            Console.WriteLine(storageSize + "GB HDD will be used");
        }
        public void getType()
        {
            Console.WriteLine("HDD");
        }

        public String getInfo()
        {
            return storageSize + "GB Hard Disk";
        }
    }
}
