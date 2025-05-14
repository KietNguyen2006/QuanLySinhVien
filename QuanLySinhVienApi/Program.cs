using QuanLySinhVienApi.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<SinhVienRepository>();
builder.Services.AddSingleton<LopRepository>();
builder.Services.AddSingleton<MonHocRepository>();
builder.Services.AddSingleton<GiaoVienRepository>();
builder.Services.AddSingleton<DiemRepository>();
builder.Services.AddSingleton<AccountRepository>();

builder.Services.AddControllers();

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