namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.ObterEquipamentos();
            cadastro.VizualizarEquipamento();
        }
    }
}
