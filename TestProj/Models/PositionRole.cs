using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProj.Models
{
    public class PositionRole
    {
        [Key]
        [Column(Order = 1)]
        public string RoleId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int PositionId { get; set; }
    }
}