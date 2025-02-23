using AutoMapper;
using ZooKitchen.Application.Contracts.Repositories;
using ZooKitchen.Application.Contracts.Services;
using ZooKitchen.Domain.Entities;
using ZooKitchen.Infrastructure.Contracts.Services.Commons;

namespace ZooKitchen.Infrastructure.Contracts.Services
{
    public class DeliveryDetailService : ServiceBase<DeliveryDetail, IDeliveryDetailRepository>, IDeliveryDetailService
    {
        private readonly IMapper _mapper;


        public DeliveryDetailService(IDeliveryDetailRepository repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }




    }
}
