
using Business.Abstract;
using Business.Concrete;
using Core.Repository;
using Core.Repository.EntityFramework;
using Dto;
using DtoMapper;
using Entity;
using Entity.Abstract;
using Microsoft.OpenApi.Models;
using Model;
using ModelMapper;
using Service.Context;
using Service.Services.Abstract;
using Service.Services.Concrete;
using System.Reflection;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IEntityRepositoryBase<Product>, EfEntityRepositoryBase<Product, ECommerceDbContext>>();
            builder.Services.AddSingleton<IDtoMapper<ProductDto, Product>, ProductDtoMapper>();
            builder.Services.AddSingleton<IProductService, ProductService>();
            builder.Services.AddSingleton<IModelMapper<ProductModel, ProductDto>, ProductModelMapper>();
            builder.Services.AddSingleton<IProductBusiness, ProductBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<Brand>, EfEntityRepositoryBase<Brand, ECommerceDbContext>>();
            builder.Services.AddSingleton<IDtoMapper<BrandDto, Brand>, BrandDtoMapper>();
            builder.Services.AddSingleton<IBrandService, BrandService>();
            builder.Services.AddSingleton<IModelMapper<BrandModel, BrandDto>, BrandModelMapper>();
            builder.Services.AddSingleton<IBrandBusiness, BrandBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<Categorie>, EfEntityRepositoryBase<Categorie, ECommerceDbContext>>();
            builder.Services.AddSingleton<IDtoMapper<CategorieDto, Categorie>, CategorieDtoMapper>();
            builder.Services.AddSingleton<ICategorieService, CategorieService>();
            builder.Services.AddSingleton<IModelMapper<CategorieModel, CategorieDto>, CategorieModelMapper>();
            builder.Services.AddSingleton<ICategorieBusiness, CategorieBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<Order>, EfEntityRepositoryBase<Order, ECommerceDbContext>>();
            builder.Services.AddSingleton<IDtoMapper<OrderDto, Order>, OrderDtoMapper>();
            builder.Services.AddSingleton<IOrderService, OrderService>();
            builder.Services.AddSingleton<IModelMapper<OrderModel, OrderDto>, OrderModelMapper>();
            builder.Services.AddSingleton<IOrderBusiness, OrderBusiness>();


            builder.Services.AddSingleton<IEntityRepositoryBase<Customer>, EfEntityRepositoryBase<Customer, ECommerceDbContext>>();
            builder.Services.AddSingleton<IDtoMapper<CustomerDto, Customer>, CustomerDtoMapper>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddSingleton<IModelMapper<CustomerModel, CustomerDto>, CustomerModelMapper>();
            builder.Services.AddSingleton<ICustomerBusiness, CustomerBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<OrderDetail>, EfEntityRepositoryBase<OrderDetail, ECommerceDbContext>>();
            builder.Services.AddSingleton<IDtoMapper<OrderDetailDto, OrderDetail>, OrderDetailDtoMapper>();
            builder.Services.AddSingleton<IOrderDetailService, OrderDetailService>();
            builder.Services.AddSingleton<IModelMapper<OrderDetailModel, OrderDetailDto>, OrderDetailMapper>();
            builder.Services.AddSingleton<IOrderDetailBusiness, OrderDetailBusiness>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options => 
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}