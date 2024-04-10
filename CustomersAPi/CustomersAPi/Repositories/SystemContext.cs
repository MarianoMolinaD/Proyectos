using CustomersAPi.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CustomersAPi.Repositories
    
{
    public class SystemContext : DbContext
    {

        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        { 
        
        }
        public  DbSet<CustomerEntity> customers { get; set; }
    
        public async Task<CustomerEntity> Get(long id)
        {
            return await customers.FirstAsync(x => x.Id == id); 
        } 

        public async Task<CustomerEntity> Add(CreateCustomerDto customerDto)
        {
            CustomerEntity entity = new CustomerEntity()
            {
                Id = null,
                Address = customerDto.Address,
                Email = customerDto.Email,
                FirsName = customerDto.FirsName,
                LastName = customerDto.LastName,
            };
            EntityEntry<CustomerEntity> response = await customers.AddAsync(entity);
            await SaveChangesAsync();
            return await Get(response.Entity.Id ?? throw new Exception("No se ha podido guardar"));
        
        }
    }


    public class CustomerEntity
    {
        public long? Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public CustomerDto toDto()
        {
            return new CustomerDto()
            {
                Address = Address,
                Email = Email,
                FirsName = FirsName,
                LastName = LastName,
                Phone = Phone,
                Id = Id ?? throw new Exception("El id no puede ser null")
            };
        }

    }
}
