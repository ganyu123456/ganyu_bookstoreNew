using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAbpProject.LoginUsers.Dto
{
    public class LoginUserInputDto
    {
        public string Code { get; set; }

        public string Password { get; set; }
    }
}
