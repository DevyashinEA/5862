using System;

namespace NoteApp.Model
{


    public class Note
    {
        private string _name = "Без имени";
        private CategoryName _category;
        private string _text;
        //private DateTime _dateCreate = DateTime.Now;
        //private DateTime _dateChange;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя мeньше 50 знаков ");
                }
                else
                {
                    _name = value;
                    //_dateChange = DateTime.Now;
                }
            }
        }

        public CategoryName Category
        {
            get { return _category; }
            set
            {
                _category = value;
                //_dateChange = DateTime.Now;
            }

        }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                //_dateChange = DateTime.Now;
            }
        }

        //public DateTime DateCreate { get { return _dateCreate; } }

        //public DateTime DateChange { get { return _dateChange; } }
    }


}