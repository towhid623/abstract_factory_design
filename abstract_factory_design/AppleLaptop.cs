using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public class AppleLaptop : ILaptopFactory
    {

        private int storageSize;

        public AppleLaptop(int storageSize)
        {
            this.storageSize = storageSize;
        }

        public IProcessor createProcessor()
        {
            return new AppleProcessor();
        }

        public IStorage createStorage()
        {
            return new AppleStorage(storageSize);
        }

    }
}
