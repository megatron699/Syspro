using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form, IView
    {
        public event EventHandler AnalyzerButtonEvent;
        public event EventHandler Button_Click;
        public int Arg1 { get; set; }
        public int Arg2 { get; set; }
        public int Result { get; set; }
        public string InputAnalyzeLines { get; set; }
        public string AnalyzerResult { get; set; }
        public int Index { get; }
        public string Address { get; set; }
        public int Port { get; set; }
        public string ServerType { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        private void Calc_Click(object sender, EventArgs e)
        {
            Arg1 = (int)arg1.Value;
            Arg2 = (int)arg2.Value;
            Button_Click?.Invoke(this, EventArgs.Empty);
            textBoxResult.Text = Result.ToString();            
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            InputAnalyzeLines = analyzeTextBox.Text;
            AnalyzerButtonEvent?.Invoke(this, EventArgs.Empty);
            analyzeLabel.Text = AnalyzerResult;
        }
    }
}
