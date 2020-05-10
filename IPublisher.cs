using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisher_subscriber_pattern
{
    interface IPublisher
    {
        event EventHandler<SampleEventArgs> onPublish;
        void Publish();
    }
}
