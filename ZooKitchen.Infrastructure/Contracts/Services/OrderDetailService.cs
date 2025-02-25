using AutoMapper;
using ZooKitchen.Application.Contracts.Repositories;
using ZooKitchen.Application.Contracts.Services;
using ZooKitchen.Domain.Entities;
using ZooKitchen.Infrastructure.Contracts.Services.Commons;

namespace ZooKitchen.Infrastructure.Contracts.Services
{
    public class OrderDetailService : ServiceBase<OrderDetail, IOrderDetailRepository>, IOrderDetailService
    {
        private readonly IMapper _mapper;


        public OrderDetailService(IOrderDetailRepository repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
    }
}
