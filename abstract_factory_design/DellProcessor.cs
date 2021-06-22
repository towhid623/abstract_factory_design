using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public class DellProcessor : IProcessor
    {
        private String storage;
        public DellProcessor()
        {
            Console.WriteLine("AMD Processor will be used for Dell Laptop");
        }
        // This method will attach Storage Object with Processor
        public void attachStorage(IStorage storage)
        {
            this.storage = storage.getInfo();
            Console.WriteLine(storage + " is attached to Dell Laptop");
        }
        public void printSpecs()
        {
            Console.WriteLine(this.getInfo());
        }

        public String getInfo()
        {
            return "DellProcessor is created using AMD Processor and " + this.storage;
        }
    }
}
