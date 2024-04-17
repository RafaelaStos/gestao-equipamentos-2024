using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Cadastro
    {

        public Equipamento[] equipamento = new Equipamento[1000];
        public int id = 0;

        public void ExcluirEquipamento()
        {
            Console.Clear();
            VizualizarEquipamento();
            Console.WriteLine("Digite o Id do equipamento que deseja editar");
            int excluirId = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < excluirId - 1; j++)
            {

                for (int i = 0; i < id - 1; i++)
                {

                    equipamento[i].nome = equipamento[i+1].nome;

                    equipamento[i].preco = equipamento[i + 1].preco;

                    equipamento[i].numSerie = equipamento[i + 1].numSerie;

                    equipamento[i].dataFabricação = equipamento[i + 1].dataFabricação;

                    equipamento[i].fabricante = equipamento[i + 1].fabricante;

                }
                id--;
            }
        }

        public void EditarEquipamento()
        {

            VizualizarEquipamento();
            Console.WriteLine("Digite o Id do equipamento que deseja editar");
            int editarId = Convert.ToInt32(Console.ReadLine());
            MenuEditar();
            int opcao = Opcao();

            switch (opcao)
            {

                case '1':
                    equipamento[editarId].nome = ValidacaoNome();
                    break;

                case '2':
                    Console.Write("Preço equipamento: ");
                    equipamento[editarId].preco = Convert.ToDouble(Console.ReadLine());
                    break;

                case '3':
                    Console.Write("Número de série equipamento: ");
                    equipamento[editarId].numSerie = Convert.ToInt32(Console.ReadLine());
                    break;

                case '4':
                    Console.Write("Data de Fabricação: ");
                    equipamento[editarId].dataFabricação = Console.ReadLine();
                    break;

                case '5':
                    Console.Write("Fabricante: ");
                    equipamento[editarId].fabricante = Console.ReadLine();
                    break;
            }

            Console.Write("Item editado com sucesso!");
            Console.ReadLine();

        }

        static void MenuEditar()
        {
            Console.WriteLine("\n1 - Nome");
            Console.WriteLine("2 - Preço");
            Console.WriteLine("3 - Número de Série");
            Console.WriteLine("4 - Data de Fabricação");
            Console.WriteLine("5 - Fabricante");

        }
        public void ObterEquipamentos()
        {
            Equipamento cadastroEquipamneto = new Equipamento();

            Console.WriteLine("\t\tCADASTRO DE EQUIPAMENTOS\n");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            cadastroEquipamneto.nome = ValidacaoNome();

            Console.Write("Preço equipamento: ");
            cadastroEquipamneto.preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número de série equipamento: ");
            cadastroEquipamneto.numSerie = Convert.ToInt32(Console.ReadLine());

            Console.Write("Data de Fabricação: ");
            cadastroEquipamneto.dataFabricação = Console.ReadLine();

            Console.Write("Fabricante: ");
            cadastroEquipamneto.fabricante = Console.ReadLine();

            equipamento[id] = cadastroEquipamneto;

            id++;
            Console.ReadLine();

        }

        public string ValidacaoNome()
        {
            string nomeValidado;

            Console.Write("Equipamento: ");
            nomeValidado = Console.ReadLine();

            while (6 > nomeValidado.Length)
            {
                Console.Clear();
                Console.WriteLine("O nome do equipamento deve ter no mínimo 6 caracteres!\n");
                Console.Write("Nome do equipamento: ");
                nomeValidado = Console.ReadLine();

            }
            return nomeValidado;
        }

        public void VizualizarEquipamento()
        {
            if (id != -1)
            {
                Console.WriteLine("\t\tLISTA DE EQUIPAMENTOS\n");
                Console.WriteLine("\n------------------------------------------------------------------------------");
                Console.WriteLine($"ID |\t\t Equipamento \t|\t Preço \t\t|\t Fabricante \t\t|\t Data de Fabricação");
                Console.WriteLine("\n------------------------------------------------------------------------------");
                for (int i = 0; i < id; i++)
                {

                    Console.WriteLine($"{i} |\t\t {equipamento[i].nome} \t|\t {equipamento[i].preco} \t\t|" +
                           $"\t {equipamento[i].fabricante} \t\t|\t3 {equipamento[i].dataFabricação}");
                }
            }
            else SemCadastro();

            Console.ReadLine();
        }

        static void SemCadastro()
        {
            Console.WriteLine("Nenhum Equipamento Cadastrado");
            Console.ReadLine();
        }

        public int Opcao()
        {
            Console.WriteLine("Digite a opcao desejada:");
            int opcao = Convert.ToChar(Console.ReadLine());
            return opcao;
        }
    }
}
