using BookRealm.Services.Mapping;
using BookRealm.Services.Mapping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRealm.Services
{
    public interface ICountService
    {
        CountDto GetCounts();
    }
}
