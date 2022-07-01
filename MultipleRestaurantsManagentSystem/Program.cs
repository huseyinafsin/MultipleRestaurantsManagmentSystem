using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Utilities.Security.JWT;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext <RestaurantContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(RestaurantContext))?.GetName().Name);
    });
});

//builder.Services.AddControllers(options =>
//{
//    options.Filters.Add(new ValidateFilterAttribute());

//}).AddFluentValidation(x =>
//{
//    x.RegisterValidatorsFromAssemblyContaining<TakipCreateDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<HesabimFilterDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<MasrafCreateDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<MasrafFilterDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<OrtakForLoginDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<SerbestMeslekMakbuzuDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<OrtakDetayFilterDtoValidator>();
//    x.RegisterValidatorsFromAssemblyContaining<FaizHesapDtosValidator>();
//}).AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
//builder.Host.ConfigureContainer<ContainerBuilder>(configureBuilder =>
//    configureBuilder.RegisterModule(new RepoServiceModule()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
//builder.Services.AddSwaggerGen(opt =>
//{
//    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });
//    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        In = ParameterLocation.Header,
//        Description = "Please enter token",
//        Name = "Authorization",
//        Type = SecuritySchemeType.Http,
//        BearerFormat = "JWT",
//        Scheme = "bearer"
//    });
//    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type=ReferenceType.SecurityScheme,
//                    Id="Bearer"
//                }
//            },
//            new string[]{}
//        }
//    });
//});
builder.Services.AddRazorPages();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = "https://localhost:7204",
            ValidAudience = "https://localhost:7204",
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("fmp6546feff8fefFEFf46FEF68fef86gFE4FF4WQW684S"))
        };
    });

//builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<ITokenHelper, JwtHelper>();

//builder.Services.AddScoped((provider => new MapperConfiguration(cfg =>
//{
//    cfg.AddProfile(new EkspertizProfile());
//    cfg.AddProfile(new MapProfile());
//}).CreateMapper()));






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UserCustomException();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();

app.Run();