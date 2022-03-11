using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookRealm.Data;
using BookRealm.Data.Common.Repositories;
using BookRealm.Data.Models;
using BookRealm.Services.Mapping;
using BookRealm.Services.Mapping.Models;
using BookRealm.ViewModels.Authors;
using BookRealm.ViewModels.Books;
using Microsoft.EntityFrameworkCore;
//using BookRealm.ViewModels.Books;

namespace BookRealm.Services
{
    public class BookService : IBookService
    {
        private readonly IDeletableEntityRepository<Book> booksRepo;
        private readonly IDeletableEntityRepository<Author> authorRepo;

        public BookService( IDeletableEntityRepository<Book> booksRepo, IDeletableEntityRepository<Author> authorRepo)
        {         
            this.booksRepo = booksRepo;
            this.authorRepo = authorRepo;
        }
       
        public async Task DeleteAsync(string id)
        {
            var book = this.booksRepo.All().FirstOrDefault(x => x.Id == id);
            this.booksRepo.Delete(book);
            await this.booksRepo.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var books = this.booksRepo.AllAsNoTracking()
                .OrderByDescending(x => x.DateOfPublish)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<T>()
                .ToList();
            
            return books;

        
        }

        public T GetById<T>(string id)
        {
            var recipe = this.booksRepo.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();

            return recipe;
        }

        public IEnumerable<T> GetByAuthorId<T>(int authorId)
        {
            var query = this.booksRepo.All()
                .Where(x=>x.Authors.Any(y => y.AuthorId == authorId))
                .To<T>()
                .ToList();          
            return query;
           
        }
        public IEnumerable<T> GetByAuthorName<T>(string authorName, int page, int itemsPerPage = 12)
        {
            var authorIds=this.authorRepo.AllAsNoTracking()
                .Where(x=>(!String.IsNullOrEmpty(x.Name) && x.Name.Contains(authorName))
                ||x.Name==authorName)
                .Select(x=>x.Id).ToList();

            var query = this.booksRepo.All().AsQueryable();
            foreach (var authorId in authorIds)
            {
                query = query.Where(x => x.Authors.Any(i => i.AuthorId == authorId));
            }

            return query.To<T>().ToList();

           

        }
        public IEnumerable<T> GetByTitle<T>(string titleName)
        {
            var query = this.booksRepo.All()
                .Where(x => (!String.IsNullOrEmpty(x.Title) && x.Title.Contains(titleName))
                || x.Title == titleName)
                .To<T>()
                .ToList();
             
            return query;

        }

        public int GetCount()
        {
            return this.booksRepo.All().Count();
        }

        public IEnumerable<T> GetRandom<T>(int count)
        {
            var books= this.booksRepo.All()
                .OrderBy(x => Guid.NewGuid())
                .Take(count)
                .To<T>().ToList();
            return books;
        }

        public IEnumerable<T> GetByCategory<T>(string categoryName)
        {
            var query = this.booksRepo.All()
                .Where(x => x.Genres.Any(y => y.Genre.Name == categoryName))
                .To<T>()
                .ToList();
            return query;
        }
    }
}
