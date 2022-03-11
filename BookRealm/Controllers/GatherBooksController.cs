using Microsoft.AspNetCore.Mvc;
using BookRealm.Services;

namespace BookRealm.Controllers
{
    public class GatherBooksController:Controller
    {
        private readonly IDataGatherer service;
        private readonly IBookService bookService;

        public GatherBooksController(IDataGatherer service, IBookService bookService)
        {
            this.service = service;
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
        public async Task<IActionResult> Add()
        {
            await this.service.ImportBooksAsync(1001,4413);
            //this.bookService.AddRating();
            return Redirect("/GatherBooks/Index");
        }
    }
}
