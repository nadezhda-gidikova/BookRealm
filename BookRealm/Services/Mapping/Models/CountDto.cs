using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRealm.Services.Mapping.Models
{
    public class CountDto
    {
        public int BooksCount { get; set; }

        public int AuthorsCount { get; set; }

        public int GenresCount { get; set; }

        public int ReviewsCount { get; set; }
    }
}
