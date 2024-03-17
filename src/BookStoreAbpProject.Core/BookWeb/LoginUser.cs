using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAbpProject.BookWeb
{
    /// <summary>
    /// 登录用户
    /// </summary>
    public class LoginUser:Entity<string>
    {
        [Key]
        [Column("Code")]
        [Required]
        [StringLength(50)]
        public override string Id { get => base.Id; set => base.Id = value; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]

        public string Password { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

    }
}
