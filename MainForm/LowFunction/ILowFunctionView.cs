using System;

namespace MainForm
{
    interface ILowFunctionView
    {
        event EventHandler Button_Click;
        int Arg1 { get; set; }
        int Arg2 { get; set; }
        int Result { get; set; }
    }
}
