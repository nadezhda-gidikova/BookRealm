using AutoMapper;
using BookRealm.Data.Models;
using BookRealm.Services.Mapping;

namespace BookRealm.ViewModels.Home
{
    public class IndexViewModel:IMapFrom<Book>//.IHaveCustomMappings
    {
        public IEnumerable<IndexPageBooksViewModel> RandomBooks { get; set; }=new List<IndexPageBooksViewModel>();

        public int BooksCount { get; set; }

        public int ReviewsCount { get; set; }

        public int AuthorsCount { get; set; }
        public int GenresCount { get; set; }

            

        //public void CreateMappings(IProfileExpression configuration)
        //{
        //    configuration.CreateMap<Book, IndexViewModel>()
        //        .ForMember(x => x.BooksCount, opt =>
        //            opt.MapFrom(x =>
        //                x.books.Count()));
        //}
    }
}

