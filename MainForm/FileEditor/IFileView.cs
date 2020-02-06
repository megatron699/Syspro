using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    interface IFileView
    {
        //    event EventHandler OpenFile_Click;
        //    event EventHandler SaveFile_Click;
        //    event EventHandler AddFile_Click;
        //    event EventHandler DeleteFile_Click;
        //    event EventHandler EditFile_Click;
        int Index { get; }
        string Address { get; set; }
        int Port { get; set; }
        string ServerType { get; set; }

    }
}
