namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();
            while (true)
            {
                MenuPrincipal();

                int opcao = cadastro.Opcao();
                switch (opcao)
                {

                    case '1':
                        cadastro.ObterEquipamentos();
                        break;
                    case '2':
                        cadastro.VizualizarEquipamento();
                        break;
                    case '3':
                        cadastro.EditarEquipamento();
                        break;
                    case '4':
                        cadastro.ExcluirEquipamento();
                        break;
                    case '5':
                        cadastro.ExcluirEquipamento();
                        break;

                }
            }
        }

        static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastra Equipamento");
            Console.WriteLine("2 - Visualizar Inventário Equipamento");
            Console.WriteLine("3 - Editar Cadastro de Equipamento");
            Console.WriteLine("4 - Excluir Equipamento");
            Console.WriteLine("5 - Sair");

        }
    }
}
