using Business.Abstract;
using Core.Utility.Results;
using Dto;
using Model;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderDetailBusiness : IOrderDetailBusiness
    {
        IOrderDetailService _orderDetailService;
        IModelMapper<OrderDetailModel, OrderDetailDto> _modelMapper;
        public OrderDetailBusiness(IOrderDetailService orderDetailService, IModelMapper<OrderDetailModel, OrderDetailDto> modelMapper)
        {
            _modelMapper = modelMapper;
            _orderDetailService = orderDetailService;   
        }

        public async Task<IResult> AddAsync(OrderDetailModel orderDetailModel)
        {
            var orderDetailDto = _modelMapper.MapToDto(orderDetailModel);
            await _orderDetailService.AddAsync(orderDetailDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _orderDetailService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<OrderDetailModel>>> GetAllAsync()
        {
            var orderDetailDtos = await _orderDetailService.GetAllAsync();
            var orderDetailModels = orderDetailDtos.Select(odDtos => _modelMapper.MapToModel(odDtos)).ToList();
            return new SuccessDataResult<List<OrderDetailModel>>(orderDetailModels);
        }

        public async Task<IDataResult<OrderDetailModel>> GetByIdAsync(int id)
        {
            var orderDetailDto = await _orderDetailService.GetByIdAsync(id);
            return new SuccessDataResult<OrderDetailModel>(_modelMapper.MapToModel(orderDetailDto));
        }

        public async Task<IResult> UpdateAsync(OrderDetailModel orderDetailModel)
        {
            var orderDetailDto = _modelMapper.MapToDto(orderDetailModel);
            await _orderDetailService.UpdateAsync(orderDetailDto);
            return new SuccessResult();
        }
    }
}
