using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Gabriela Aguiar de Oliveira", CPF = "060.133.293-89", Email = "gabrielaaguiar21@outlook.com"};

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Fitbank\Projetos\curso_CSharp_avancado\02_SerializarJSON.json");
            sw.WriteLine(stringObjSerializado);
            sw.Close();
        }
    }
}
