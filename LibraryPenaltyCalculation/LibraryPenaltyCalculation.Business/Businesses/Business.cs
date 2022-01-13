using LibraryPenaltyCalculation.Core.Businesses;
using LibraryPenaltyCalculation.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Business.Businesses
{
    public class Business<TEntity>: IBusiness<TEntity> where TEntity : class
    {


        private readonly IRepository<TEntity> _repository;
        public Business(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.Where(predicate);
        }
    }
}
