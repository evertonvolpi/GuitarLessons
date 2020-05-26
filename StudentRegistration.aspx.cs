using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GuitarLessons
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        List<Students> studentsList = new List<Students>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["allStudents"] != null)
            {
                studentsList = (List<Students>)Session["allStudents"];

                foreach(Students student in studentsList)
                {
                    TableStudents.Rows.Add(NewRow(student));
                }
            }

        }

        protected void ButtonStudents_Click(object sender, EventArgs e)
        {
            string name = TextBoxStudentName.Text;
            string type = DropDownListCourseType.SelectedValue;

            Students newStudent;

            if(type == "one")
            {
                newStudent = new OneDay(name);
            }

            else if(type == "two")
            {
                newStudent = new TwoDays(name);
            }

            else
            {
                newStudent = new ThreeDays(name);
            }

            TableRowNoStudents.Cells.Clear();
            TableStudents.Rows.Add(NewRow(newStudent));

            studentsList.Add(newStudent);
            Session["allStudents"] = studentsList;

            DropDownListCourseType.SelectedValue = "empty";
            TextBoxStudentName.Text = "";
        }

        private static TableRow NewRow(Students newStudent)
        {
            TableRow newRow = new TableRow();

            TableCell ID = new TableCell();
            TableCell Name = new TableCell();
            TableCell Course = new TableCell();

            ID.Text = $"{newStudent.ID}";
            Name.Text = $"{newStudent.Name}";
            Course.Text = $"{newStudent.Course}";

            newRow.Cells.Add(ID);
            newRow.Cells.Add(Name);
            newRow.Cells.Add(Course);

            return newRow;
        }
    }
}