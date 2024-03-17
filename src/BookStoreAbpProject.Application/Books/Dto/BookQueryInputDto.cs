using Abp.Application.Services.Dto;

namespace BookStoreAbpProject.Books.Dto
{
    public class BookQueryInputDto 
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
