using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Recebendo informações do sistema...");
            DateTime horaSistema = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine($"A data e horário atual é: {horaSistema}");
        }
    }
}
