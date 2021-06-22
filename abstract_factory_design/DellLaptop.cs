using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public class DellLaptop : ILaptopFactory
    {
        private int storageSize;
        public DellLaptop(int storageSize)
        {
            this.storageSize = storageSize;
        }

        public IProcessor createProcessor()
        {
            return new DellProcessor();
        }
        public IStorage createStorage()
        {
            return new DellStorage(storageSize);
        }
    }
}
