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
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Clear();

            Console.WriteLine("CADASTRAR CLIENTE");
            Console.WriteLine("-------------------");

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();

            Console.Write("CEP: (Digitar apenas números) ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Endereco: ");
            cliente.Endereco = Console.ReadLine();

            GerenciaArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));
        }
        public void ListarClientes()
        {
            Console.Clear();

            Console.WriteLine("Lista de clientes: ");
            Console.WriteLine("-------------------");

            string[] linhas = GerenciaArquivo.LerArquivo("cliente");

            for (int linha = 0; linha < linhas.Length; linha++)
            {
                Cliente cliente = Conversor.ClienteTexto.ConverterParaCliente(linhas[linha]);
                Console.WriteLine("Nome: " + cliente.Nome + "| Telefone: " + cliente.Telefone);
            }
        }
    }
}
