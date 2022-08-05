using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioPOO.Auxiliares
{
    static class ConsoleUtility
    {
        const char _block = '■';
        const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
        const string _twirl = "-\\|/";
        public static void WriteProgressBar(int percent,bool update = false)
        {
            if (update)
                Console.Write(_back);
            Console.Write("[");
            var p = (int)((percent / 10f) + .5f);
            for (var i = 0; i < 10; ++i)
            {
                if (i >= p)
                    Console.Write(' ');
                else
                    Console.Write(_block);
            }
            Console.Write("] {0,3:##0}%", percent);

        }
        public static void WriteProgress(string type, bool update = false)
        {
            if (type == "corrida")
            {
                Console.WriteLine("\n--- Progresso da corrida entre origem e o destino ---\n");
            }
            else if (type == "motorista")
            {
                Console.WriteLine("\n--- Escolhendo o motorista mais próximo ---\n");
            }else if (type == "pagamento")
            {
                Console.WriteLine("\n--- Motorista aguardando o pagamento ser efetuado ---\n");
            }
            for (var i = 0; i <= 100; ++i)
            {
                ConsoleUtility.WriteProgressBar(i, true);
                Thread.Sleep(50);
            }
            Console.WriteLine("");
        }



    }
}
