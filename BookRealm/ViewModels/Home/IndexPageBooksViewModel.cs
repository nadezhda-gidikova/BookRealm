using BookRealm.Data.Models;
using BookRealm.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRealm.ViewModels.Home
{
    public class IndexPageBooksViewModel:IMapFrom<Book>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public DateTime? DateOfPublish { get; set; }
        public string CoverUrl { get; set; }
    }
}
