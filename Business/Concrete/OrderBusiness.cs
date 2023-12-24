using Business.Abstract;
using Core.Utility.Results;
using Dto;
using Model;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderBusiness : IOrderBusiness
    {
        IOrderService _orderService;
        IModelMapper<OrderModel, OrderDto> _modelMapper;

        public OrderBusiness(IOrderService orderService, IModelMapper<OrderModel, OrderDto> modelMapper)
        {
            _modelMapper = modelMapper;
            _orderService = orderService;
        }

        public async Task<IResult> AddAsync(OrderModel orderModel)
        {
            var orderDto = _modelMapper.MapToDto(orderModel);
            await _orderService.AddAsync(orderDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _orderService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<OrderModel>>> GetAllAsync()
        {
            var orderDtos = await _orderService.GetAllAsync();
            var orderModels = orderDtos.Select(orderDto => _modelMapper.MapToModel(orderDto)).ToList();
            return new SuccessDataResult<List<OrderModel>>(orderModels);   
        }

        public async Task<IDataResult<OrderModel>> GetByIdAsync(int id)
        {
            var orderDto = await _orderService.GetByIdAsync(id);
            return new SuccessDataResult<OrderModel>(_modelMapper.MapToModel(orderDto));
        }

        public async Task<IResult> UpdateAsync(OrderModel orderModel)
        {
            var orderDto = _modelMapper.MapToDto(orderModel);
            await _orderService.UpdateAsync(orderDto);
            return new SuccessResult();
        }
    }
}
