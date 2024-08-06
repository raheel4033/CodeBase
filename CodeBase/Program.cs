using CodeBase.DbContextModelling;
using CodeBase.IRepositories;
using CodeBase.IServices;
using CodeBase.Repositories;
using CodeBase.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(o =>
        o.UseSqlServer(builder.Configuration.GetConnectionString("DBAPP")));

builder.Services.AddScoped<ICreateAccountRepository, CreateAccountRepository>();
builder.Services.AddScoped<IPinCodeRepository, PinCodeRepository>();
builder.Services.AddScoped<IPrivacyPolicyRepository, PrivacyPolicyRepository>();
builder.Services.AddScoped<ICreateAccountService, CreateAccountService>();
builder.Services.AddScoped<IPinCodeService, PinCodeService>();
builder.Services.AddScoped<IPrivacyPolicyService, PrivacyPolicyService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
