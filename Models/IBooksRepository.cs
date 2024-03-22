namespace Mission11_Hart.Models
{
    public interface IBooksRepository
    {
        public IQueryable<Book > Books { get; }
    }
}
