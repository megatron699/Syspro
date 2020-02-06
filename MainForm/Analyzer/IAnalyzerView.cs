using System;


namespace MainForm
{
    interface IAnalyzerView
    {
        event EventHandler AnalyzerButtonEvent;
        string InputAnalyzeLines { get; set; }
        string AnalyzerResult { get; set; }
    }
}
