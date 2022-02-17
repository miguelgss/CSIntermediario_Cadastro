using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;
using PCadastro.Conversor;

namespace PCadastro.Tela
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();

            Console.WriteLine("CADASTRAR FUNCIONARIO");
            Console.WriteLine("-------------------");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.Write("CEP: (Digitar apenas números) ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.Write("Endereco: ");
            funcionario.Endereco = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario.Salario = Double.Parse(Console.ReadLine());

            Console.Write("Data de contratacao: ");
            funcionario.DataContratacao = DateTime.Parse(Console.ReadLine());

            GerenciaArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));

        }
        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("Lista de funcionarios: ");
            Console.WriteLine("-------------------");

            string[] linhas = GerenciaArquivo.LerArquivo("funcionario");

            for (int linha = 0; linha < linhas.Length; linha++)
            {
                Funcionario funcionario = Conversor.FuncionarioTexto.ConverterParaCliente(linhas[linha]);
                Console.WriteLine("Nome: " + funcionario.Nome + "| Cargo: " + funcionario.Cargo + "| Salario: " + funcionario.Salario + "| Telefone: " + funcionario.Telefone);
            }
        }
    }
}
