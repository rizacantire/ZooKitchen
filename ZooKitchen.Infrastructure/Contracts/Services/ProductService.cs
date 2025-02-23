using AutoMapper;
using ZooKitchen.Application.Contracts.Repositories;
using ZooKitchen.Application.Contracts.Services;
using ZooKitchen.Domain.Entities;
using ZooKitchen.Infrastructure.Contracts.Services.Commons;


namespace ZooKitchen.Infrastructure.Contracts.Services
{
    public class ProductService : ServiceBase<Product, IProductRepository>, IProductService
    {
        private readonly IMapper _mapper;


        public ProductService(IProductRepository repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }




    }
}
