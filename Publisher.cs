using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisher_subscriber_pattern
{
    class Publisher : IPublisher
    {
        public event EventHandler<SampleEventArgs> onPublish;

        public void Publish() {

            onPublish(this, new SampleEventArgs("Event Published"));

        }

    }
}
