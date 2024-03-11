using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncaoSenha senha = new FuncaoSenha();

            string aste = new string('*', 42);

            Console.WriteLine(aste);
            Console.WriteLine("Sistema de Senha - Descubra o Segredo ");
            Console.WriteLine(aste);

            Console.Write("Digite a Senha que você deseja Cadastrar: ");
            senha.senhaCadastrada = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(aste);
            Console.WriteLine("A Senha Digitada foi ****** ");
            Console.WriteLine(aste);

            senha.Senha();

        }
    }
}



