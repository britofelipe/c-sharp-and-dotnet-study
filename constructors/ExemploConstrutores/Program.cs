// See https://aka.ms/new-console-template for more information
using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();

            // Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            
            // op.Invoke(10, 10);

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Aluno p1 = new Aluno("Felipe", "Brito", "Engenharia");
            // p1.Apresentar();

            // Data data = new Data();
            // data.SetMes(2);

            // data.Mes = 20;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();
        }
    }
}