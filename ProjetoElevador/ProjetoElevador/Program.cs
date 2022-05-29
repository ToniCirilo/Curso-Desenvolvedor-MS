using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Elevador se inicializará aqui, com a mensagem que aparece apenas uma vez quando a pessoa entra nele.
            Elevador divertido = new Elevador();
            divertido.Inicializar(5, 7);
            Console.WriteLine("Bem vindo, esse é o Elevador Divertido!\nEsse elevador suporta 5 pessoas e o prédio tem 7 andares.\n Tenha uma boa viagem!");


            //Variável 'bool' que se encarrega de fazer a mensagem com as opções continuar aparecendo mesmo depois que o usuário faz o primeiro input
            bool continuar = true;

            do
            {
                //Menu com as opções que o usuário do elevador pode escolher
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("\n1-Adicionar uma pessoa\n2-Retirar uma pessoa\n3-Subir um andar\n4-Descer um andar\n5-Sair");
                string opcaoescolhida = Console.ReadLine();

                //Cada um dos 'cases' abaixo retorna uma ação ao elevador (adicionar uma pessoa, subir um andar, e seus opostos)
                switch (opcaoescolhida)
                {
                    case "1":
                        divertido.Entrar();
                        Console.WriteLine("Você adicionou uma pessoa. Total no elevador: " + (divertido.pessoas));
                        break;
                    case "2":
                        divertido.Sair();
                        Console.WriteLine("Você retirou uma pessoa. Total no elevador: " + (divertido.pessoas));
                        break;
                    case "3":
                        divertido.Subir();
                        Console.WriteLine("Você subiu um andar! Andar atual: " + (divertido.andar_atual));
                        break;
                    case "4":
                        divertido.Descer();
                        Console.WriteLine("Você desceu um andar! Andar atual: " + (divertido.andar_atual));
                        break;
                    case "5":
                        Console.WriteLine("Você saiu do elevador. Até mais.");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Desculpe, essa é uma opção inválida.");
                        break;


                }
            }

            while (continuar);




        }



    }
}
