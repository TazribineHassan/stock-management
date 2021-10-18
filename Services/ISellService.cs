using stock_management.database.modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.Services
{
    public interface ISellService
    {
        List<Sell> getSells();

        Sell getSell(int id);

        Sell addSell(Sell sell);

        Sell updateSell(Sell sell);

        void deleteSell(int id);

    }
}
