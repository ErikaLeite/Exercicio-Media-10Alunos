using System;

namespace Exercicio_Media_10Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 nomes alunos
            //4 notas para cada aluno
            //média do aluno
            //quantidade de aprovados
            //quantidade de reprovados
            //media geral

            //NOME DO ALUNO
            string[] nome = {"Ana", "Beatriz", "Claudia", "Debora","Eva", "Flavia", "Giovana", "Helena", "Iana", "Jaqueline"};
                    
            Console.WriteLine("Exercício Calculo de Media 10 Alunos");
            Console.WriteLine("Nome do Aluno:");
            Console.ReadLine();//CORRIGIR FALHA AQUI!!!

            
            //MEDIA DO ALUNO
            Console.WriteLine("Registre a Primeira Nota: ");
            int n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Registre a Segunda Nota: ");
            int n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Registre a Terceira Nota: ");
            int n3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Registre a Quarta Nota: ");
            int n4 = int.Parse(Console.ReadLine());

            float MediaAluno = MediaNotaAluno(n1,n2,n3,n4);
            //FUNCIONANDO


            //FN MEDIA INDIVIDUAL DO ALUNO
            float MediaNotaAluno(int nota1, int nota2, int nota3, int nota4)
            {
                float media = (nota1+nota2+nota3+nota4)/4;
                Console.WriteLine($"A média do Aluno é {media}");
                return media;
            }

            //FN MEDIA GERAL DA SALA
            float MediaGeral(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10)
            {
                float mediaG = (a1+a2+a3+a4+a5+a6+a7+a8+a9+a10)/10;
                Console.WriteLine($"A média do Aluno é {mediaG}");
                return mediaG;
            }

        }
        
    }
}
