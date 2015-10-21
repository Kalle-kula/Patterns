using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorVideo
{
    public interface IMediator
    {
        void saleOffer(string stock, int shares, int collCode);

        void buyOffer(string stock, int shares, int collCode);

        void addColleague(Colleague colleague);
    }
}
