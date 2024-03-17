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
    /// 图书信息
    /// </summary>
    public class Book:Entity
    {
        /// <summary>
        /// 书名
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Author { get; set; }
        /// <summary>
        /// 出版社
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Publisher { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        [Required]
        public int StockNumber { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [Required]

        public decimal Price { get; set; }

    }
}
