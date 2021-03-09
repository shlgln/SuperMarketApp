using SuperMarket.Models.DBContext;

namespace SuperMarket.UnitOfWorks
{
    public class EFUnitOfWork : UnitOfWork
    {
        private readonly ApplicationContex _context;
        public EFUnitOfWork(ApplicationContex context)
        {
            _context = context;
        }
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
