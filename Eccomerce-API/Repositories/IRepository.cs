using System.Collections.Generic;

namespace Eccomerce_API.Repositories
{
    public interface IRepository<TModel>
    {
        IEnumerable<TModel> GetAll();
        TModel GetSingle(int id);
        TModel Add(TModel model);
        TModel Update(TModel model);
        void Delete(TModel model);
        int Save();

    }
}
