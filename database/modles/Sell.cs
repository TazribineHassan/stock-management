using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.database.modles
{
    public class Sell
    {
        [Column(name: "ID")]
        [Key]
        public int Id { get; set; }

        [Column(name: "DATE")]
        public DateTime Date { get; set; }

        [Column(name: "QUANTITY")]
        public int Quantity { get; set; }

        [Column(name: "TOTAL")]
        public float Total { get; set; }

        [Column(name: "ARTICLE_ID")]
        [ForeignKey("Article")]
        public int ArticleId { get; set; }
        public Article? Article { get; set; }

    }
}
