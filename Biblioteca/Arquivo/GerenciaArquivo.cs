using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Arquivo
{
    public class GerenciaArquivo
    {
        public static void GravarArquivo(string nome, string texto)
        {
            string caminho = "C:\\Users\\Miguel\\Desktop\\Codigo Fonte\\Sec8Cadastro\\SolucaoCadastro\\Biblioteca\\Arquivo\\CadastrosSalvos\\" + nome + ".txt";

            if (File.Exists(caminho))
            {
                // AppendText tenta anexar um texto em um arquivo existente.
                // Caso o arquivo não exista, ele cria um novo.

                using(StreamWriter sw = File.AppendText(caminho))
                {
                    sw.WriteLine(texto);
                }

            } else
            {
                using(StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine(texto);
                }
            }
        }
        public static string[] LerArquivo(string nome)
        {
            string caminho = "C:\\Users\\Miguel\\Desktop\\Codigo Fonte\\Sec8Cadastro\\SolucaoCadastro\\Biblioteca\\Arquivo\\CadastrosSalvos\\" + nome + ".txt";
            return File.ReadAllLines(caminho);
        }
    }
}
