var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => {  //her isteğe izin vermesi için bunu ekledik. bunu inşa etmezseniz bu api ye herkes request gönderemez.
    opt.AddPolicy("AllowAll", p => {  // yani beni kullanan her yazılımcı dilediği platformdan istek gönderir demiş oluyoruz. 
        p.AllowAnyOrigin();
        p.AllowAnyMethod();
        p.AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
app.UseSwaggerUI();
}

app.UseCors("AllowAll");  // aynı zamanda bunu ekledik. her isteğe izin vermesi için. 
app.UseHttpsRedirection();
app.UseRouting();  //biz ekledik.


app.UseAuthorization();  

app.MapControllers();

app.Run();
