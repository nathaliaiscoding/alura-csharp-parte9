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
        static void LidandoComStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1 kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }

            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            // Usamos o membro estático Encoding.UTF8 para isto, mas podemos criar manualmente uma instância de Encoding com o código new UTF8Encoding(). 

        }
    }



}

