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
        public int id=0;


        public void ObterEquipamentos()
        {
            Equipamento cadastroEquipamneto = new Equipamento();

            Console.Write("Equipamento: ");
            cadastroEquipamneto.nome = Console.ReadLine();

            Console.Write("Preço equipamento: ");
            cadastroEquipamneto.preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número de série equipamento: ");
            cadastroEquipamneto.numSerie = Convert.ToInt32(Console.ReadLine());

            Console.Write("Data de Fabricação: ");
            cadastroEquipamneto.dataFabricação = Console.ReadLine();

            Console.Write("fabricante: ");
            cadastroEquipamneto.fabricante = Console.ReadLine();

            equipamento[id] = cadastroEquipamneto;

            id++;

        }

        public void VizualizarEquipamento()
        {
            if (id != -1)
            {
                Console.WriteLine("Lista DE EQUIPAMENTOS\n");
                Console.WriteLine($"ID |\t\t Equipamento \t\t|\t\t Preço \t\t|\t\t Fabricante \t\t|\t Data de Fabricação");
                Console.WriteLine("\n==============================================");
                for (int i = 0; i < id; i++)
                {

                 Console.WriteLine($"{i} |\t\t {equipamento[i].nome} \t\t|\t\t {equipamento[i].preco} \t\t|" +
                        $"\t\t {equipamento[i].fabricante} \t\t|\t\t {equipamento[i].dataFabricação}");
                }
            }
            else { Console.WriteLine("Nenhum Equipamenro registrado"); }
            } 
    }
}
