using ZooKitchen.Application.Contracts.Services.Commons;
using ZooKitchen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZooKitchen.Application.Contracts.Services
{
    public interface IAnimalService : IServiceBase<Animal>
    {
    }
}
