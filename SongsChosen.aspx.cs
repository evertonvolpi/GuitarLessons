using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GuitarLessons
{
    public partial class SongsChosen : System.Web.UI.Page
    {
        List<Students> students = new List<Students>();
        List<Song> songsToRegister = new List<Song>();
        protected void Page_Load(object sender, EventArgs e)
        {
            students = (List<Students>)Session["allStudents"];

            if (!IsPostBack)
            {
                foreach(Song song in ToolBox.AvailableSongs())
                {
                    CheckBoxListSongs.Items.Add(new ListItem($"\"{song.Title}\", by {song.Artist} - Complexity: {song.Complexity}", $"{song.Code}"));
                }

                if(Session["allStudents"] != null)
                {
                    foreach (Students student in students)
                    {
                        DropDownListStudents.Items.Add(new ListItem($"{student.ToString()}", $"{student.ID}"));
                    }
                }
            }
        }

        protected void EventStudentSelected(object sender, EventArgs e)
        {
            string selectedValue = DropDownListStudents.SelectedValue;
            CheckBoxListSongs.ClearSelection();

            if (selectedValue == "empty")
            {
                LiteralStudentStatus.Text = "";
            }

            else
            {
                foreach(Students student in students)
                {
                    int studentID = Convert.ToInt32(selectedValue);

                    if(student.ID == studentID)
                    {
                        DisplayStudentStatus(student);

                        foreach(Song songs in student.StSongsChosen)
                        {
                            foreach(ListItem checkboxItem in CheckBoxListSongs.Items)
                            {
                                if(checkboxItem.Value == songs.Code)
                                {
                                    checkboxItem.Selected = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void ButtonSongs_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(DropDownListStudents.SelectedValue);
            LiteralStudentStatus.Text = "";

            foreach(ListItem item in CheckBoxListSongs.Items)
            {
                if (item.Selected)
                {
                    songsToRegister.Add(ToolBox.GetSongByCode(item.Value));
                }
            }

            foreach(Students student in students)
            {
                if(student.ID == studentID)
                {
                    try
                    {
                        student.CreateListOfSongs(songsToRegister);
                        DisplayStudentStatus(student);
                    }

                    catch (Exception ex)
                    {
                        LiteralStudentStatus.Text = ex.Message;
                    }
                }
            }

        }

        private void DisplayStudentStatus(Students s)
        {
            LiteralStudentStatus.Text = $"{s.Name} (#{s.ID}) - {s.Course} course - Total songs: {s.StSongsChosen.Count()} - Complexity(total): {s.ComplexityTotal}";
        }
    }
}