using System;
using System.Collections.Generic;


namespace LogicDLL
{
    public interface IFile
    {
        //event EventHandler<LinkedList<INote>> UpdateEvent;
        LinkedList<INote> Notes { get; set; }
        /// <summary>
        /// Открывает файл из указанной директории
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        LinkedList<INote> Open(string path);
        /// <summary>
        /// Сохраняет файл в указанную директорию
        /// </summary>
        /// <param name="path"></param>
        void Save(string path);
        /// <summary>
        /// Редактирует выбранную запись
        /// </summary>
        /// <param name="index"></param>
        /// <param name="address"></param>
        /// <param name="port"></param>
        /// <param name="servertype"></param>
        void Edit(int index, string address, int port, string servertype);
        /// <summary>
        /// Добавляет запись о сервере в список записей
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        /// <param name="servertype"></param>
        void Add(string address, int port, string servertype);
        /// <summary>
        /// Удаляет выбранную запись
        /// </summary>
        /// <param name="index"></param>
        void Delete(int index);
    }
}
