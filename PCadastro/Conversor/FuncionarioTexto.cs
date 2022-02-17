using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace PCadastro.Conversor
{
    public class FuncionarioTexto
    {
        /// <summary>
        /// Converte o funcionario para uma string unica, sendo assim possivel passar seus dados 
        /// para um .txt
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        public static string ConverterParaTexto(Funcionario funcionario)
        {

            string texto = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                funcionario.Nome,
                funcionario.DataNascimento,
                funcionario.Telefone,
                funcionario.CPF,
                funcionario.RG,
                funcionario.CEP,
                funcionario.Estado,
                funcionario.Cidade,
                funcionario.Endereco,
                funcionario.Cargo,
                funcionario.Salario,
                funcionario.DataContratacao); ;

            return texto;
        }
        /// <summary>
        /// Converte uma string para uma instância de funcionario, permitindo que ele seja
        /// interpretado pelo programa como um objeto.
        /// </summary>
        /// <param name="linha"></param>
        /// <returns></returns>
        public static Funcionario ConverterParaCliente(string linha)
        {
            string[] elementos = linha.Split(',');

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = elementos[0];
            funcionario.DataNascimento = DateTime.Parse(elementos[1]);
            funcionario.Telefone = elementos[2];
            funcionario.CPF = elementos[3];
            funcionario.RG = elementos[4];
            funcionario.CEP = int.Parse(elementos[5]);
            funcionario.Estado = elementos[6];
            funcionario.Cidade = elementos[7];
            funcionario.Endereco = elementos[8];
            funcionario.Cargo = elementos[9];
            funcionario.Salario = Double.Parse(elementos[10]);
            funcionario.DataContratacao = DateTime.Parse(elementos[11]);

            return funcionario;
        }
    }
}
