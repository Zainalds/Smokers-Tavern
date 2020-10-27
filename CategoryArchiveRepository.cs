using SmokersTavernStore.Data;
using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public class CategoryArchiveRepository : ICategoryArchiveRepository
    {
        private ApplicationDbContext _datacontext = null;
        private readonly IRepositoryService<CategoryArchive> _productRepository;

        public CategoryArchiveRepository()
        {
            _datacontext = new ApplicationDbContext();
            _productRepository = new RepositoryService<CategoryArchive>(_datacontext);

        }

        public void Dispose()
        {
            _datacontext.Dispose();
            _datacontext = null;
        }

        public List<CategoryArchive> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public void Insert(CategoryArchive model)
        {
            _productRepository.Insert(model);
        }
    }
}
