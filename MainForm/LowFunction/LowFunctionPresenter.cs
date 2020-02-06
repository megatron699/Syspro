using System;
using System.IO;
using System.Reflection;

namespace MainForm
{
    class LowFunctionPresenter
    {
        readonly IView view;

        public LowFunctionPresenter(IView view)
        {
            this.view = view;
            view.Button_Click += ViewButton_Click;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.Load(File.ReadAllBytes("XOR.dll"));
            Type type = asm.GetType("XOR");
            MethodInfo method = type.GetMethod("XOR", BindingFlags.Instance | BindingFlags.Public);
            object obj = Activator.CreateInstance(type);
            view.Result = (Int32)method.Invoke(obj, new object[] { view.Arg1, view.Arg2 });
        }
    }
}
