using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task7
{
    public partial class FormSubmission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string nameValue = name.Text;
            string emailValue = email.Text;
            string idValue = id.Text;
            string genderValue = genderMale.Checked ? "Male" : "Female";
            List <string> courses = new List<string>();
            if (courseCSS.Checked)
            {
                courses.Add("CSS");
            }
            if (courseHTML.Checked)
            {
                courses.Add("HTML");
            }
            if (courseJavaScript.Checked)
            {
                courses.Add("JavaScript");
            }
            string descriptionValue = description.Text;


            name1.InnerHtml = "Name : "+nameValue;
            email1.InnerText = "Email : " + emailValue;
            id1.InnerHtml = "ID : " + idValue;
            gender1.InnerText = "Gender : " + genderValue;
            courses1.InnerText = "Courses : " + string.Join(",", courses);
            dec.InnerText = "Description : " + descriptionValue;
        }
    }
}