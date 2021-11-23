using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstApproach.Models
{
    [Table("memberrecords")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Column("membername",TypeName ="varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
