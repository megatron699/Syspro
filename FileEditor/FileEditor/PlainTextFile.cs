using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDLL
{
    public class PlainTextFile : IFile
    {
        public LinkedList<INote> Notes { get; set; }
        public LinkedList<INote> Open(string path)
        {
            
            using (StreamReader streamReader = new StreamReader(path))
            {
               
                return Notes;
            }
        }
        public void Save(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var element = Notes.First;
                while (element != null)
                {
                    streamWriter.WriteLine();
                }
            }
        }
        public void Add(string address, int port, string servertype)
        {
            if (Notes == null) Notes = new LinkedList<INote>();
            Notes.AddLast(new PlainTextNote(address, port, servertype));
        }
      
        public void Edit(int index, string address, int port, string servertype)
        {
            if (Notes.First != null)
            {
                LinkedListNode<INote> node = Notes.First;
                while (index != 0 && node != null)
                {
                    index--;
                    node = node.Next;
                }
                if (index == 0)
                {
                    node.Value = new PlainTextNote(address, port, servertype);
                }
            }
        }
        public void Delete(int index)
        {
            LinkedListNode<INote> node = Notes.First;
            while (index != 0 && node != null)
            {
                index--;
                node = node.Next;
            }
            if(index==0)
            {
                Notes.Remove(node.Value);
            }
        }

    }
}