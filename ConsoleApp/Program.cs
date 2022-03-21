using DesignPatterns.Builder.Builders;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressBuilder = new AddressBuilder();
            var address = addressBuilder.SetAddress("aaa", "bbb").Build();
            

        }
    }
}
