using BookRealm.Data.Models;
using BookRealm.Services.Mapping.Models;
//using BookRealm.ViewModels.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRealm.Services
{
    public interface IBookService
    {
        public Task DeleteAsync(string id);
        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);
        public T GetById<T>(string id);

        public IEnumerable<T> GetByAuthorId<T>(int authorId);
        public IEnumerable<T> GetByCategory<T>(string categoryName);
        public IEnumerable<T> GetByTitle<T>(string titleName);
        public IEnumerable<T> GetByAuthorName<T>(string authorName, int page, int itemsPerPage = 12);
        public int GetCount();
        public IEnumerable<T> GetRandom<T>(int count);
       
    }
}
