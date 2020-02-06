using System;
using System.Windows.Forms;
using LogicDLL;

namespace MainForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm form = new MainForm();
            _ = new AnalyzerPresenter(new Analyzer1(), form);
            _ = new LowFunctionPresenter(form);
            Application.Run(form);
        }
    }
}
