using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicDLL;

namespace MainForm
{
    public partial class FormAdd : Form
    {
        public enum FileWork
        {
            AddNotes, EditNotes
        }
        private IFile file;
        private LinkedList<INote> note;
        private IView view;
        private FileWork fileWork;
        private int indexElement;
        public FormAdd(FileWork fileWork, LinkedList<INote> note, int indexElement = -1)
        {
            InitializeComponent();
            this.indexElement = indexElement;
            this.note = note;
            this.fileWork = fileWork;
            if (fileWork == FileWork.EditNotes)
            {
                LinkedListNode<INote> node = note.First;
                int i = 0;
                while (i++ != indexElement) node = node.Next;
                addressTextBox.Text = view.Address;
                portTextBox.Text = view.Port.ToString();
                serverTypeComboBox.Text = view.ServerType;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch(fileWork)
                {
                    case FileWork.AddNotes:
                        file.Add(addressTextBox.Text, int.Parse(portTextBox.Text), serverTypeComboBox.Text);
                            break;
                    case FileWork.EditNotes:
                        file.Edit(indexElement, addressTextBox.Text, int.Parse(portTextBox.Text), serverTypeComboBox.Text);
                        break;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Произошла ошибка\n{exception.Message}");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
