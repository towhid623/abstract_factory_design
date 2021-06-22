using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public class AppleStorage : IStorage
    {
        private int storageSize;
        public AppleStorage(int storageSize)
        {
            this.storageSize = storageSize;
            Console.WriteLine(storageSize + "GB SSD will be used");
        }
        public void getType()
        {
            Console.WriteLine("SSD");
        }

        public String getInfo()
        {
            return storageSize + "GB Solid State Drive";
        }
    }
}
