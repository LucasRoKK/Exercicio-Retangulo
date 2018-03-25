using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------CALCULO DE UM RETÂNGULO------");
            Console.ReadLine();

            Console.Write("Digite a largura do retangulo: ");
            Retangulo val = new Retangulo();
            val.largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retangulo: ");
            val.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor da área é de:{0}",val.Area());

            Console.WriteLine("O valor do perimetro é de:{0}", val.Perimetro());

            Console.WriteLine("O valor da diagonal é de:{0}", val.Diagonal());

            Console.ReadLine();

        }
    }
}
