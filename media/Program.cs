using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDeAlunos = 5;
            int nota1 = 9;
            int nota2 = 5;
            int nota3 = 4;
            int nota4 = 10;
            int nota5 = 2;

            int media = (nota1+nota2+nota3+nota4+nota5)/numDeAlunos;

            Console.WriteLine($"A media da turma foi de {media}");
        }
    }
}
