using System;
using System.Windows.Forms;
using NoteApp.Model;

namespace WindowsFormsApp1
{
    public partial class AddEditNote : Form
    {
        private Note _note;

        public Note NewNote
        {
            get
            {
                return _note;
            }
            set
            {
                if (value != null)
                {
                    _note = value;
                }
            }
        }

        public AddEditNote()
        {
            InitializeComponent();
            foreach (var note in Enum.GetValues(typeof(CategoryName)))
            {
                ComboBoxCategory.Items.Add(note);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            NewNote=new Note();
            NewNote.Name = TextBoxName.Text;
            NewNote.Category = (CategoryName)ComboBoxCategory.SelectedItem;
            NewNote.Text = TextBoxNote.Text;

            Close();
        }

        private void TextBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}