using stock_management.database.modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.Services
{
    internal interface IDailyService
    {
        List<Sell> getSells();
        List<Sell> getSellsBetweenDates(DateTime start, DateTime end);
        List<Sell> getSellsUsingDate(DateTime date);
    }
}
