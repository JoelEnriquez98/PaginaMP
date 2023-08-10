using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPServicePage
{
    public partial class Records : System.Web.UI.Page
    {
        string pathRegisters = "Files/Registers.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            bindDataTable();
        }


        private void bindDataTable()
        {
            DataTable recordsDataTable = new DataTable();
            recordsDataTable.Columns.Add("#");
            recordsDataTable.Columns.Add("Estado");
            recordsDataTable.Columns.Add("DPI");
            recordsDataTable.Columns.Add("Fecha de Nacimiento");
            recordsDataTable.Columns.Add("Año de Nacimiento");
            recordsDataTable.Columns.Add("Correo Electronico");
            recordsDataTable.Columns.Add("Primer Nombre");
            recordsDataTable.Columns.Add("Segundo Nombre");
            recordsDataTable.Columns.Add("Tercer Nombre");
            recordsDataTable.Columns.Add("Primer Apellido");
            recordsDataTable.Columns.Add("Segundo Apellido");
            recordsDataTable.Columns.Add("Apellido de Casada");
            recordsDataTable.Columns.Add("Telefono Celular");
            recordsDataTable.Columns.Add("Nombre de Institucion");
            recordsDataTable.Columns.Add("Telefono de Institucion");
            recordsDataTable.Columns.Add("Actividad academica");
            recordsDataTable.Columns.Add("Departamento");
            recordsDataTable.Columns.Add("Municipio");
            recordsDataTable.Columns.Add("Motivo");

            int id = 1;
            using (StreamReader file = new StreamReader(Server.MapPath(pathRegisters)))
            {
                while (!file.EndOfStream)
                {
                    string[] data = file.ReadLine().Split(',');
                    string[] aux = new string[data.Length + 1];
                    aux[0] = id.ToString();

                    for (int i = 1; i < aux.Length; i++)
                    {
                        aux[i] = data[i - 1];
                    }

                    recordsDataTable.Rows.Add(aux);

                    id++;
                }
            }

            GVRecords.DataSource = recordsDataTable;
            GVRecords.DataBind();
        }
    }
}