using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            TVVolumeUpCommand upp = new TVVolumeUpCommand(tv);
            TVVolumeDownCommand ner = new TVVolumeDownCommand(tv);
            Fjärrkontroll fjärr = new Fjärrkontroll(upp, ner);
            fjärr.Plus();
            fjärr.Minus();

            Hiss hiss = new Hiss();
            HissUpp up = new HissUpp(hiss);
            HissNed ned = new HissNed(hiss);
            Fjärrkontroll hissKnapp = new Fjärrkontroll(up, ned);
            hissKnapp.Plus();
            hissKnapp.Minus();
        }
    }
}
