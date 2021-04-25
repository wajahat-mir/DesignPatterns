using Adaptor.Adaptors;
using Adaptor.Consumers;
using System;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReviewConsumer consumer = new ReviewConsumer();
            InsertionProcess process = new InsertionProcess();

            process.Insert(consumer.Get());

            ScrapedConsumer scrapedConsumer = new ScrapedConsumer();
            ScrapedAdaptor adaptor = new ScrapedAdaptor();
            process.Insert(adaptor.Get());
        }
    }
}
