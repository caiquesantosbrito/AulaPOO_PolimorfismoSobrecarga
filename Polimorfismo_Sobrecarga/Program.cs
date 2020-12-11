using System;
using Polimorfismo_Sobrecarga.Classes;

namespace Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("oKaiiN");
            fun.Mostrar(3);
        }
    }
}
