using ECommerce.Context;
using ECommerce.Models;
using ECommerce.Repository;
using ECommerce.Repository.EntityFramework;
using ECommerce.Services.Abstract;
using ECommerce.Services.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ECommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ECommerceDbContext>();
            builder.Services.AddSingleton<IProductService, ProductManager>();
            builder.Services.AddSingleton<IEntityRepositoryBase<Product>, EfEntityRepositoryBase<Product, ECommerceDbContext>>();
            
            builder.Services.AddSingleton<IBrandService, BrandManager>();
            builder.Services.AddSingleton<IEntityRepositoryBase<Brand>, EfEntityRepositoryBase<Brand, ECommerceDbContext>>();

            builder.Services.AddSingleton<ICategorieService, CategorieManager>();
            builder.Services.AddSingleton<IEntityRepositoryBase<Categorie>, EfEntityRepositoryBase<Categorie, ECommerceDbContext>>();

            builder.Services.AddSingleton<ICustomerService, CustomerManager>();
            builder.Services.AddSingleton<IEntityRepositoryBase<Customer>, EfEntityRepositoryBase<Customer, ECommerceDbContext>>();

            builder.Services.AddSingleton<IOrderDetailService, OrderDetailManager>();
            builder.Services.AddSingleton<IEntityRepositoryBase<OrderDetail>, EfEntityRepositoryBase<OrderDetail, ECommerceDbContext>>();

            builder.Services.AddSingleton<IOrderService, OrderManager>();
            builder.Services.AddSingleton<IEntityRepositoryBase<Order>, EfEntityRepositoryBase<Order, ECommerceDbContext>>();

            




            builder.Services.AddControllers().AddFluentValidation(v => 
            {
                v.ImplicitlyValidateChildProperties = true;
                v.ImplicitlyValidateRootCollectionElements = true;
                v.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

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