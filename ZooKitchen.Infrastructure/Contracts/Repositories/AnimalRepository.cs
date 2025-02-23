using ZooKitchen.Application.Contracts.Repositories;
using ZooKitchen.Domain.Entities;
using ZooKitchen.Infrastructure.Contracts.Repositories.Commons;
using ZooKitchen.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKitchen.Infrastructure.Contracts.Repositories
{
    public class AnimalRepository : RepositoryBase<Animal>, IAnimalRepository
    {
        public AnimalRepository(SiteContext dbContext) : base(dbContext)
        {
        }
    
    }
}
