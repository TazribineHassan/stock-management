
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_management.database.modles
{
    public class Article
    {
        [Column(name:"ID")]
        [Key]
        public int Id { get; set; }

        [Column(name: "REF")]
        public string Ref { get; set; }

        [Column(name: "NAME")]
        public string Name { get; set; }

        [Column(name: "PRICE")]
        public float Price { get; set; }

        [Column(name: "QUANTITY")]
        public int Quantity { get; set; }

    }
}
