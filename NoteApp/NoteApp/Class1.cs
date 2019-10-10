using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{

    public class Project { }

    enum CategoryName
    { Работа, Дом, Здоровье, Люди, Докумнты, Финансы, Разное }


    public class Note
    {
        private string _name="Без имени";
        private string _category;
        private string _text;
        private DateTime _dateCreate = DateTime.Now;
        private DateTime _dateChange;

        public string GetName() { return _name; }
        public void SetName(string name)
        {
            if (name.Length > 50)
            {
                throw new ArgumentException("Имя мeньше 50 знаков ");
            }
            else
                _name = name;
            _dateChange = DateTime.Now;
        }

        public string GetCategory() { return _category; }
        public void SetCategory(string category)
        {
            string[] names = Enum.GetNames(typeof(CategoryName));
            for (int i = 0; i < names.Length; i++)
            {
                if (category == names[i])
                {
                    _category = category;
                    _dateChange = DateTime.Now;
                }
                else
                    if(i == names.Length)
                        throw new ArgumentException("Категории не существует");
            }
        }

        public string GetText() { return _text; }
        public void SetText(string text)
        {
            _text = text;
            _dateChange = DateTime.Now;
        }

        public DateTime GetDateCreate() { return _dateCreate; }

        public DateTime GetDateChange() { return _dateChange; }
    }

    public class ListNote
    {

    }
}
