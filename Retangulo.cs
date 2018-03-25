using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Retangulo
    {
        public double largura;
        public double altura;

        
        public double Area()
        {
            double a = this.altura * this.largura;
            return a;
        } 

        public double Perimetro()
        {
            double b = (this.altura + this.largura) * 2;
            return b;
        }

        public double Diagonal()
        {
            double c = Math.Sqrt(this.largura * this.largura + this.altura * this.altura);
            return c;
        }
    }
}
