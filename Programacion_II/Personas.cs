using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II
{
    public class Personas
    {
        public DataTable ListaDT { get; set; } = new DataTable();






        public void InsertaPersona(Persona aPersona)
        {
            ListaDT.Rows.Add();
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aPersona.Nombre;
            ListaDT.Rows[NuevoRenglon]["Apellido"] = aPersona.Apellido;
            ListaDT.Rows[NuevoRenglon]["Dni"] = aPersona.Dni;
            ListaDT.Rows[NuevoRenglon]["Fecha Nacimiento"] = aPersona.Fecha_nac;


            ListaDT.WriteXml("Personas.xml");


        }

        public Personas()
        {
            ListaDT.TableName = "ListaPersonas";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Apellido");
            ListaDT.Columns.Add("Dni");
            ListaDT.Columns.Add("Fecha Nacimiento", typeof(DateTime));


            LeeArchivos();

        }


        public void LeeArchivos()
        {
            if (System.IO.File.Exists("Personas.xml"))
            {
                ListaDT.ReadXml("Personas.xml");
            }

        }
    }
}
