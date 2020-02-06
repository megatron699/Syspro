using System;
using LogicDLL;

namespace MainForm
{
    class AnalyzerPresenter
    {
        readonly IView view;
        readonly IAnalyzer analyzer;
        public AnalyzerPresenter(IAnalyzer analyzer, IView view)
        {
            this.view = view;
            this.analyzer = analyzer;
            view.AnalyzerButtonEvent += new EventHandler(Analyzer);
        }
        private void Analyzer(object sender, EventArgs e)
        {
            //try
            //{
                view.AnalyzerResult = analyzer.Analyze(view.InputAnalyzeLines);
            //}
            //catch
            //{
            //    string result = "Ошибка в входной строке";

            //    view.AnalyzerResult = result;

            //}
        }
    }
}
