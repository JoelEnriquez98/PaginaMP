using System;
using System.Collections.Generic;
using System.Data;
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
        string pathDeparments = "Files/Deparments.txt";
        string pathMunicipalities = "Files/Municipalities.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem listItemGuatemalteco = new ListItem("Guatemalteco", "Guatemalteco");
            ListItem listItemExtranjero = new ListItem("Extranjero", "Extranjero");
            DropDownEstado.Items.Add(listItemGuatemalteco);
            DropDownEstado.Items.Add(listItemExtranjero);

            if (!IsPostBack)
            {
                DataTable tableDepartments = new DataTable();
                tableDepartments.Columns.Add("Codigo");
                tableDepartments.Columns.Add("Departamento");

                using (StreamReader file = new StreamReader(Server.MapPath(pathDeparments)))
                {
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] lineSplit = line.Split(',');

                        tableDepartments.Rows.Add(lineSplit);
                    }
                }
                DropDownDepartamento.DataSource = tableDepartments;
                DropDownDepartamento.DataTextField = "Departamento";
                DropDownDepartamento.DataValueField = "Codigo";
                DropDownDepartamento.DataBind();
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            String newData = DropDownEstado.Text + "," + TextBoxDPI.Text + "," + TextBoxBirth.Text + "," +
                TextBoxYearBirth.Text + "," + TextBoxEmail.Text + "," + TextBoxFirstName.Text + "," +
                TextBoxSecondName.Text + "," + TextBoxThirdName.Text + "," + TextBoxFirstLastName.Text + "," +
                TextBoxSecondLastName.Text + "," + TextBoxMarryLastName.Text + "," + TextBoxPhone.Text + "," +
                TextBoxNombreInstitucion.Text + "," + TextBoxTelefonoInstitucion.Text + "," + TextBoxActividadEconomica.Text + "," +
                DropDownDepartamento.SelectedItem.Text + "," + DropDownMunicipio.SelectedItem.Text + "," + TextBoxMotivo.Text;
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
            TextBoxNombreInstitucion.Text = "";
            TextBoxTelefonoInstitucion.Text = "";
            TextBoxActividadEconomica.Text = "";
            TextBoxMotivo.Text = "";
        }

        protected void DropDownDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tableMunicipalities = new DataTable();
            tableMunicipalities.Columns.Add("Codigo");
            tableMunicipalities.Columns.Add("Departamento");

            using (StreamReader file = new StreamReader(Server.MapPath(pathMunicipalities)))
            {
                string departmentCode = DropDownDepartamento.SelectedValue;
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] lineSplit = line.Split(',');

                    if (lineSplit[2] == departmentCode)
                        tableMunicipalities.Rows.Add(lineSplit[0], lineSplit[1]);
                }
            }
            DropDownMunicipio.DataSource = tableMunicipalities;
            DropDownMunicipio.DataTextField = "Departamento";
            DropDownMunicipio.DataValueField = "Codigo";
            DropDownMunicipio.DataBind();
        }
    }
}