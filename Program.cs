using System;

namespace listaConvidados
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado!");
            var nome = Console.ReadLine();

            if(nome == null || string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome não informado para seguir com o programa");
                return;
            }

            Console.WriteLine("Informe a idade ");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não é vaálida para seguir com o programa");
            }


            bool estaConvidado;
            switch (nome)
            {

                case "Anderson": // index 0
                    estaConvidado = true;
                    break;
                case "Joana": // index 1
                    estaConvidado = true;
                    break;
                case "Maria": // index 2
                    estaConvidado = true;
                    break;
                case "Pedro": //index 3
                    estaConvidado = true;
                break;
                default:
                    estaConvidado = false;
                break;
        }

        if(estaConvidado == true && idade > 18)
        {
            Console.WriteLine("Bem vindo a festa");
        }
        else if (estaConvidado == false)
        {
            Console.WriteLine("Seu nome não está na lista de convidados");

        }
        else
        {
            Console.WriteLine("Você não tem 18 anos para entrar na festa");
        }
        

        }
    }
}
