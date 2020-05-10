using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisher_subscriber_pattern
{
    class Subscriber
    {
        public IPublisher Publisher { get; private set; }
        public Subscriber(IPublisher publisher) {
            this.Publisher = publisher;
        }
    }
}
