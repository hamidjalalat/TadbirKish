var builder = WebApplication.CreateBuilder(args);


// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

TadbirKish.Core.DependencyContainer.ConfigureServices
                (configuration: builder.Configuration, services: builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("ADMIN_CORS_POLICY",
        builder =>
        {
            builder
                .WithOrigins("https://localhost:7081")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
                ;
        });

    options.AddPolicy("OTHERS_CORS_POLICY",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                //.AllowCredentials()
                ;
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policyName:"ADMIN_CORS_POLICY");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
