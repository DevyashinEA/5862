using NoteApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace NoteAppUI
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
            Application.Run(new Form1());
            var Note = new Note();
            Note.SetName("One");
            Note.SetCategory("Дом");
            Note.SetText("Я делаю лабораторную, но у меня ничего не выходит");

            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(@"D:\vs\DevyashinEA\5862\Notes\Note.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, Note);
            }
        }
    }
}
