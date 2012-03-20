using System;
using System.Collections.Generic;

namespace Rebus.Snoop.ViewModel.Models
{
    public class Message : ViewModel
    {
        readonly Dictionary<string, string> headers = new Dictionary<string, string>();
        string body;
        int bytes;
        string id;
        string label;
        string queuePath;
        DateTime time;

        public string Body
        {
            get { return body; }
            set { SetValue("Body", value); }
        }

        public Dictionary<string, string> Headers
        {
            get { return headers; }
            set { SetValue("Headers", value); }
        }

        public string Label
        {
            get { return label; }
            set { SetValue("Label", value); }
        }

        public int Bytes
        {
            get { return bytes; }
            set { SetValue("Bytes", value); }
        }

        public DateTime Time
        {
            get { return time; }
            set { SetValue("Time", value); }
        }

        public string Id
        {
            get { return id; }
            set { SetValue("Id", value); }
        }

        public string QueuePath
        {
            get { return queuePath; }
            set { SetValue("QueuePath", value); }
        }
    }
}