using System;

namespace abstract_factory_design
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessor dellProcessor = createLaptop(new DellLaptop(1024));
            dellProcessor.printSpecs();
            Console.WriteLine("*****************************************");
            IProcessor appleProcessor = createLaptop(new AppleLaptop(512));
            appleProcessor.printSpecs();
        }

        // config method that will create an instance of Processor with passed abstract class object
        public static IProcessor createLaptop(ILaptopFactory laptopFactory)
        {
            IProcessor processor = laptopFactory.createProcessor();
            IStorage storage = laptopFactory.createStorage();
            processor.attachStorage(storage);
            return processor;
        }
    }
}
