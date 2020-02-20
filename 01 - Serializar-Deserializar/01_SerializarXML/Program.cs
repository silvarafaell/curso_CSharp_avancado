using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Francisco Rafael Pereira", CPF = "068.778.653-32", Email = "francisco_rafael@hotmail.com.br" };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Fitbank\Projetos\curso_CSharp_avancado\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);



        }
    }
}
