using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Casa casa = new Casa() { cidade = "Fortaleza", endereco = "Rua luciano alves 3520" };
            Usuario usuario = new Usuario() { Nome = "Francisco Rafael", Email = "francisco_rafael@hotmail.com.br", Senha = "123456" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);


            carro 2 = Serializador.Deserializar();
            carro 2 = Serializador.Deserializar();
            usuario 2 = Serializador.Deserializar();
        }
    }
}
