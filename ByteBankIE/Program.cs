using ByteBankIE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankIE
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}");

            // UsarStreamDeEntrada();
            // EscritaBinaria();
            // LeituraBinaria();
            // TestaEscrita();
            // CriarArquivoComWriter();

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();

        }
    }
}
