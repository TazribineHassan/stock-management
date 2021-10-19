
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_management.database.modles
{
    public class Article
    {
        [DisplayName("Id")]
        [Column(name:"ID")]
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Référence")]
        [Column(name: "REF")]
        public string Ref { get; set; }

        [DisplayName("Nom")]
        [Column(name: "NAME")]
        public string Name { get; set; }

        [DisplayName("Prix unitaire")]
        [Column(name: "PRICE")]
        public float Price { get; set; }

        [DisplayName("Quantité")]
        [Column(name: "QUANTITY")]
        public int Quantity { get; set; }

        public ICollection<Sell> Sells { get; set; }

    }
}
