

using Core.Repository;
using Core.Utility.Results;
using Dto;
using DtoMapper;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {
        IEntityRepositoryBase<OrderDetail> _orderDetailRepository;
        IDtoMapper<OrderDetailDto, OrderDetail> _dtoMapper;
        public OrderDetailService(IEntityRepositoryBase<OrderDetail> orderDetailRepository, IDtoMapper<OrderDetailDto, OrderDetail> dtoMapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _dtoMapper = dtoMapper;
        }


        public async Task AddAsync(OrderDetailDto orderDetailDto)
        {
            var orderDetail = _dtoMapper.MapToEntity(orderDetailDto);
            await _orderDetailRepository.AddAsync(orderDetail);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderDetailRepository.DeleteAsync(id);
        }


        public async Task<OrderDetailDto> GetByIdAsync(int id)
        {
            var orderDetail = await _orderDetailRepository.GetAsync(od => od.Id == id);
            return _dtoMapper.MapToDto(orderDetail);
        }




        public async Task UpdateAsync(OrderDetailDto orderDetailDto)
        {
            var orderDetail = _dtoMapper.MapToEntity(orderDetailDto);
            await _orderDetailRepository.UpdateAsync(orderDetail);
        }

        public async Task<List<OrderDetailDto>> GetAllAsync()
        {
            var orderDetails = await _orderDetailRepository.GetAllAsync();
            return orderDetails.Select(od => _dtoMapper.MapToDto(od)).ToList();
        }

    }
}
