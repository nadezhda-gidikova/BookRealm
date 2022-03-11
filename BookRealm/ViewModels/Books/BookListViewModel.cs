using BookRealm.Data.Models;
using BookRealm.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRealm.ViewModels.Books
{
    public class BookListViewModel: PagingViewModel
    {  
            public IEnumerable<BookInListViewModel> Books { get; set; }=new List<BookInListViewModel>();
        
    }
}
