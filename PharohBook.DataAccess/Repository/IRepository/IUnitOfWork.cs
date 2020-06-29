using System;
using System.Collections.Generic;
using System.Text;

namespace PharohBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        SP_Call SP_Call { get; }
    }
}
