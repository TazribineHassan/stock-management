using stock_management.database;
using stock_management.database.modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.Services.Implementation
{
    internal class DailyService : IDailyService
    {
        DatabaseContext context = new DatabaseContext();

        IArticleService articleService = new ArticleService();

        public List<Sell> getSells()
        {
            return context.Sells.ToList();
        }

        public List<Sell> getSellsBetweenDates(DateTime start, DateTime end)
        {
            return context.Sells.Where( sell => sell.Date >= start.Date && sell.Date <= end.Date).ToList();
        }

        public List<Sell> getSellsUsingDate(DateTime date)
        {
            return context.Sells.Where(sell => sell.Date == date.Date).ToList();
        }
    }
}
