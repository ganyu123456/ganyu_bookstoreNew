using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using AutoMapper;
using BookStoreAbpProject.Books.Dto;
using BookStoreAbpProject.BookWeb;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace BookStoreAbpProject.Books
{
    public class BookAppService : AsyncCrudAppService<Book, BookInputDto, int, BookQueryInputDto, BookInputDto, BookInputDto>, IBookAppService
    {
        private readonly IRepository<Book, int> repository;

        public BookAppService(IRepository<Book, int> repository) : base(repository)
        {
            this.repository = repository;
        }
        public async Task<ListResultDto<BookInputDto>> Query(BookQueryInputDto input)
        {
            var result = await repository.GetAll()
                .WhereIf(!string.IsNullOrEmpty(input.Name), t => t.Name.Contains(input.Name))
                .WhereIf(!string.IsNullOrEmpty(input.Author), t => t.Author.Contains(input.Author))
                .WhereIf(!string.IsNullOrEmpty(input.Publisher), t => t.Publisher.Contains(input.Publisher))
                .OrderBy(t => t.Name).ToListAsync();
            return new ListResultDto<BookInputDto>(ObjectMapper.Map<List<BookInputDto>>(result));
        }

    }
}
