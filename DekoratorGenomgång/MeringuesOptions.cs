using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorGenomgång
{
    internal class MeringuesOptions : ICake
    {
        ICake cake;

        public MeringuesOptions(ICake cake)
        {
            this.cake = cake;
        }

        public decimal Cost
        {
            get
            {
                return this.cake.Cost + 200M;
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}