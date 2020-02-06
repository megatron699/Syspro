using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDLL
{
    
    public interface INote
    {
        string Address { get; set; }
        int Port { get; set; }
        string ServerType { get; set; }
    }
}
