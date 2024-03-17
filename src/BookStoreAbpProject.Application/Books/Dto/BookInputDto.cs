using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BookStoreAbpProject.BookWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAbpProject.Books.Dto
{
    [AutoMap(typeof(Book))]
    public class BookInputDto:EntityDto
    {
        public string Name { get; set; }

        public string Author { get; set; }
        public string Publisher { get; set; }

        public int StockNumber { get; set; }

        public decimal Price { get; set; }
    }
}
