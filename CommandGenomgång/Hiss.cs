using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class Hiss
    {
        private const int HögstaVåning = 5;
        private const int BottenVåning = 0;
        private int Våning = 1;

        public void ÅkaUppEnVåning()
        {
            if (Våning < HögstaVåning)
            {
                Våning++;
                Console.WriteLine("Du är nu på våning {0}", Våning);
            }
        }
        public void ÅkaNerEnVåning()
        {
            if (Våning > BottenVåning)
            {
                Våning--;
                Console.WriteLine("Du är nu på våning {0}", Våning);
            }
        }
    }
}
