

using Core.Repository;
using Core.Utility.Results;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {
        IEntityRepositoryBase<OrderDetail> _orderDetailRepository;
        public OrderDetailService(IEntityRepositoryBase<OrderDetail> orderDetailRepository)
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
