using Datalayer.DbClasses;
using Microsoft.EntityFrameworkCore;
using Modellayer.basicdata;
using System.Threading.Tasks;

namespace DataLayer.DBOperations
{
    class Add_state
    {
        private readonly Database _db;
        public Add_state(Database db)
        {
            _db = db;
        }
        public async Task<int> AddstateAsync(states states)
        {
            _db.Entry(states).State = EntityState.Added;
            return await _db.SaveChangesAsync();
        }
        public async Task<int> AddpincodeAsync(pincode pincode)
        {
            _db.Entry(pincode).State = EntityState.Added;
            return await _db.SaveChangesAsync();
        }
    }
}
