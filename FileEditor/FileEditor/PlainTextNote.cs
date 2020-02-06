using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDLL
{
    [Serializable]
    class PlainTextNote: INote
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public string ServerType { get; set; }
        public PlainTextNote(string address, int port, string servertype)
        {
            Address = address;
            Port = port;
            ServerType = servertype;
        }
    }
}
