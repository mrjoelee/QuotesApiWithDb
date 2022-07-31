using QuotesApi.Models;

namespace QuotesApi.Repository
{
    public interface IQuoteRepository
    {
        IEnumerable<Quote> GetAll();   
        Quote GetById(int id);
        int AddQuote(Quote quoteEntity);
        int UpdateQuote(Quote quoteEntity);
        void DeleteQuote(int id);
    }
}
