using System;
using System.Windows.Forms;
using NoteApp.Model;

namespace WindowsFormsApp1
{
    public partial class NoteApp : Form
    {
        private Project _project=new Project();

        public NoteApp()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Загрузить список контактов, добавить в ListBox.
        /// </summary>
        private void ProjectLoad()
        {
            _project = ProjectManager<Project>.Deserializer(@"NoteApp.aaa");

            foreach (var note in _project.ListNote)
            {
                NoteListBox.Items.Add(note.Name);
            }
        }

        private void ProjectSave()
        {
            ProjectManager<Project>.Serializer(_project, @"NoteApp.aaa");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddEditNote addForm= new AddEditNote();
            addForm.ShowDialog();
            _project.ListNote.Add(addForm.NewNote);
            NoteListBox.Items.Add(addForm.NewNote.Name);
        }


        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Testbutton_Click(object sender, EventArgs e)
        {
            Note note = new Note {Name="12",Category = 0, Text = "123"};
            NoteListBox.Items.Add(note.Name);
            _project.ListNote.Add(note);
        }
    }

}
