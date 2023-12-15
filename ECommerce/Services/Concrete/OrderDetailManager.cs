using ECommerce.Models;
using ECommerce.Repository;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        IEntityRepositoryBase<OrderDetail> _orderDetailRepository;
        public OrderDetailManager(IEntityRepositoryBase<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

 
        public async Task<IResult> AddAsync(OrderDetail orderDetail)
        {
            await _orderDetailRepository.AddAsync(orderDetail);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _orderDetailRepository.DeleteAsync(id);
            return new SuccessResult();
        }

      
        public async Task<IDataResult<OrderDetail>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<OrderDetail>(await _orderDetailRepository.GetAsync(od => od.Id == id));   
        }

      

       
        public async Task<IResult> UpdateAsync(OrderDetail orderDetail)
        {
            await _orderDetailRepository.UpdateAsync(orderDetail);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<OrderDetail>>> GetAllAsync()
        {
            return new SuccessDataResult<List<OrderDetail>>(await _orderDetailRepository.GetAllAsync());
        }
    }
}
