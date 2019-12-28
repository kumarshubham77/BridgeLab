// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Startup.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using BusinessManager.Manager;
using Common.Models.NotesModels;
using Common.Models.UserModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using FundooRepository.Interfaces.RedisCache;
using FundooRepository.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.Text;

namespace FundooApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RedisSetting>(Configuration.GetSection("RedisSetting"));

            services.Configure<ApplicationSetting>(Configuration.GetSection("ApplicationSetting"));
            services.AddDbContextPool<UserContexts>(options => options.UseSqlServer(Configuration.GetConnectionString("UserDBConncetion")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<INotesInterface, NotesRepository>();
            services.AddTransient<INotesManager, NotesManager>();
            services.AddTransient<ILabelInterface, LabelRepository>();
            services.AddTransient<ILabelManager, Labelmanager>();
            services.AddTransient<ICollaboratorInterface, CollaboratorRepository>();
            services.AddTransient<ICollaboratorManager, CollaboratorManager>();
            services.AddTransient<ICacheProvider, RedisCacheProvider>();
            services.AddTransient<IAdminInterface, AdminRepository>();
            services.AddTransient<IAdminManager, AdminManager>();

            //Implementation of Swagger 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "FUNDOO NOTE API",
                    Description = "ASP.NET Core Web API"
                });
                var security = new Dictionary<string, IEnumerable<string>>
               {
                   {"Bearer",new string[0]}
               };
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWt Authorization header using the bearer scheme",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                c.AddSecurityRequirement(security);
            });
            //Implementation of Content-Negotiator.
            services.AddMvc(options =>
            {
                options.ReturnHttpNotAcceptable = true;
                ///  options.RespectBrowserAcceptHeader = true;                
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            });
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));



            // var key = Encoding.UTF8.GetBytes(Configuration.GetSection("ApplicationSetting:JWT_Secret").ToString());
            //JwtAuthenticate
            //services.AddAuthentication(x => {
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(x=>
            //{
            //    x.RequireHttpsMetadata = false; x.SaveToken = true; x.TokenValidationParameters = new TokenValidationParameters { ValidateIssuerSigningKey = true, IssuerSigningKey = new SymmetricSecurityKey(key), ValidateIssuer = false, ValidateAudience = false };
            //    //x.RequireHttpsMetadata = false;
            //    //x.SaveToken = false;
            //    //x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            //    //{
            //    //    ValidateIssuerSigningKey = true,
            //    //    IssuerSigningKey = new SymmetricSecurityKey(key),
            //    //    ValidateIssuer = false,
            //    //    ValidateAudience = false,
            //    //    ClockSkew = TimeSpan.Zero
            //    //};
            //});
            var key = Encoding.UTF8.GetBytes(Configuration["ApplicationSetting:JWT_Secret"].ToString());
            services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {
                x.RequireHttpsMetadata = false; x.SaveToken = true; x.TokenValidationParameters = new TokenValidationParameters { ValidateIssuerSigningKey = true, IssuerSigningKey = new SymmetricSecurityKey(key), ValidateIssuer = false, ValidateAudience = false };
          
            });
       }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseCors("MyPolicy");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SHUBHAM");
            });
           // app.UseCors(x => x
           //    .AllowAnyOrigin()
           //    .AllowAnyHeader().AllowAnyMethod()
           //);
        }
    }
}
