using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisher_subscriber_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPublisher p = new Publisher();

            Subscriber s1 = new Subscriber(p);
            s1.Publisher.onPublish += Publisher_onPublish1;

            Subscriber s2 = new Subscriber(p);
            s2.Publisher.onPublish += Publisher_onPublish2;

            p.Publish();

            Console.ReadLine();
        }

        private static void Publisher_onPublish2(object sender, SampleEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private static void Publisher_onPublish1(object sender, SampleEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
