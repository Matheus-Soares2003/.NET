using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula03.models
{
    public class Calculadora
    {
        public void Somar(int a, int b){
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b){
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiplicar(int a, int b){
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public void Dividir(int a, int b){
            Console.WriteLine($"{a} / {b} = {a / b}");
        }

        public void Pot(int a, int b){
            double pot = Math.Pow(a, b);
            Console.WriteLine($"{a}^{b} = {pot}");
        }

        public void RaizQuadrada(double a){
            double raiz = Math.Sqrt(a);
            Console.WriteLine($"Raiz quadrada de {a} = {Math.Round(raiz, 2)}");
        }

        public void Seno(double angulo) {
            double rad = angulo * Math.PI / 180;
            double sen = Math.Sin(rad);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(sen, 4)}");
        }

        public void Cosseno(double angulo){
            double rad = angulo * Math.PI / 180;
            double cos = Math.Cos(rad);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cos, 4)}");
        }

        public void Tangente(double angulo){
            double rad = angulo * Math.PI / 180;
            double tan = Math.Tan(rad);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(tan, 4)}");
        }
    }
}