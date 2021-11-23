using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCoreCodeFirstApproach.Models
{
    [Table("bookrecords")]
    public class Book
    {
        [Key]
        [Column("bookid")]
        public int Id { get; set; }

        [Column("bookname", TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("memberid")]
        public Member Member { get; set; }
    }
}
