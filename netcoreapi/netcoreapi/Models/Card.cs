using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Models
{
    [Table("cards")]
    public class Card
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Column("cardNumber")]
        public string CardNumber { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
