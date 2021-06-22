using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public class AppleProcessor : IProcessor
    {
        private String storage;

        public AppleProcessor()
        {
            Console.WriteLine("Intel Processor will be used for Apple Laptop");
        }
        public void attachStorage(IStorage storage)
        {
            this.storage = storage.getInfo();
            Console.WriteLine(storage + " is attached to Apple Laptop");
        }
        public void printSpecs()
        {
            Console.WriteLine(this.getInfo());
        }

        public String getInfo()
        {
            return "AppleProcessor is created using Intel Processor and " + this.storage;
        }
    }
}
