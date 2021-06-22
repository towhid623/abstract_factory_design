using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory_design
{
    public interface IProcessor
    {
        void attachStorage(IStorage storage);
        void printSpecs();
    }
}
