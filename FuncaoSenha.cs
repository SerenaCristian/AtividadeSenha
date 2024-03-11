using System;


namespace Senha
{
    public class FuncaoSenha
    {
        
        public string senhaCadastrada;
        public string senhaDigitada;
        public string senhaMin;
        public string senhaMai;
        public int tentativas = 0;

        public void Senha()
        {
            while (tentativas < 5)
            {
                Console.Write("Digite a senha Cadastrada: ");
                senhaDigitada = Console.ReadLine();

                senhaMin = senhaCadastrada.ToLower();
                senhaMai = senhaCadastrada.ToUpper();

                if (senhaDigitada == senhaMin)
                {
                    Console.WriteLine($"Parabéns! Você acertou a senha digitada {senhaMai}");
                    break;
                }
                else if (senhaDigitada == senhaMai)
                {
                    Console.WriteLine($"Parabéns! Você acertou a senha digitada {senhaMin}");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha incorreta. Tente novamente.");
                    tentativas++;
                }
            }

            if (tentativas >= 5)
            {
                Console.WriteLine("Limite de tentativas excedido. Tente novamente mais tarde.");
            }
        }
    }
}
        
    

