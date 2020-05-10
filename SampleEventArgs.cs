using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisher_subscriber_pattern
{
    class SampleEventArgs : EventArgs
    {
        public string Message { get; set; }

        public SampleEventArgs(string message) {
            Message = message;
        }
    }
}
