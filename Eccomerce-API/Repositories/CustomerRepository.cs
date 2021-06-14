using Eccomerce_API.Migrations;
using Eccomerce_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Eccomerce_API.Repositories
{
    public class CustomerRepository : IRepository<CustomerModel>
    {
        private readonly DataBaseContext _DbContex;
        public CustomerRepository(DataBaseContext dbcontext)
        {
            _DbContex = dbcontext;
        }
        public CustomerModel Add(CustomerModel model)
        {
            _DbContex.Customers.Add(model);
            return model;
        }

        public void Delete(CustomerModel model)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            return _DbContex.Customers;
        }

        public CustomerModel GetSingle(int id)
        {
            return _DbContex.Customers.FirstOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return _DbContex.SaveChanges();
        }

        public CustomerModel Update(CustomerModel model)
        {
            _DbContex.Customers.Update(model);
            return model;
        }
    }
}
