using AngularApp1.Server.Data;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity; 


var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Konfiguracja bazy danych
builder.Services.AddDbContext<ContactDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("ContactDbConnectionString")));

// Konfiguracja Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ContactDbContext>()
    .AddDefaultTokenProviders();

// Konfiguracja uwierzytelniania JWT
var key = Encoding.ASCII.GetBytes(configuration["ApplicationSettings:JWT_Secret"]);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
        };
    });


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

// Dodatkowa konfiguracja
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors("AllowAllOrigins");

app.MapControllers();
app.MapSwagger();

app.Run();
