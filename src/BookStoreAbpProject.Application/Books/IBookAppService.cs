using Abp.Application.Services;
using BookStoreAbpProject.Books.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAbpProject.Books
{
    public interface IBookAppService:IAsyncCrudAppService<BookInputDto,int,BookQueryInputDto,BookInputDto,BookInputDto>
    {

    }
}
