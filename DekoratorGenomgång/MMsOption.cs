using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorGenomgång
{
    internal class MMsOption : ICake
    {
        ICake cake;

        public MMsOption(ICake cake)
        {
            this.cake = cake;
        }

        public decimal Cost
        {
            get
            {
                return this.cake.Cost + 1300M;
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}