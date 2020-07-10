using PharohBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharohBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}