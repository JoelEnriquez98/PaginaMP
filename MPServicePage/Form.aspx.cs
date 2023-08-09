using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPServicePage
{
    public partial class Form : System.Web.UI.Page
    {
        string pathRegisters = "Files/Registers.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem listItemGuatemalteco = new ListItem("Guatemalteco", "Guatemalteco");
            ListItem listItemExtranjero = new ListItem("Extranjero", "Extranjero");
            DropDownEstado.Items.Add(listItemGuatemalteco);
            DropDownEstado.Items.Add(listItemExtranjero);
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            String newData = DropDownEstado.Text + "," + TextBoxDPI.Text + "," + TextBoxBirth.Text + "," +
                TextBoxYearBirth.Text + "," + TextBoxEmail.Text + "," + TextBoxFirstName.Text + "," +
                TextBoxSecondName.Text + "," + TextBoxThirdName.Text + "," + TextBoxFirstLastName.Text + "," +
                TextBoxSecondLastName.Text + "," + TextBoxMarryLastName.Text + "," + TextBoxPhone.Text;
            writeData(newData);
            cleanData();
            Response.Write("<script>alert('Se ha creado un nuevo registro de forma exitosa');</script>");
        }

        private void writeData(string data)
        {

            using (StreamWriter writer = new StreamWriter(Server.MapPath(pathRegisters), true))
            {
                writer.WriteLine(data);
            }
        }

        private void cleanData()
        {
            TextBoxDPI.Text = "";
            TextBoxBirth.Text = "";
            TextBoxYearBirth.Text = "";
            TextBoxEmail.Text = "";
            TextBoxFirstName.Text = "";
            TextBoxSecondName.Text = "";
            TextBoxThirdName.Text = "";
            TextBoxFirstLastName.Text = "";
            TextBoxSecondLastName.Text = "";
            TextBoxMarryLastName.Text = "";
            TextBoxPhone.Text = "";

        }
    }
}