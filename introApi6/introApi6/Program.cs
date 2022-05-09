var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




// bu kýsýmda Api de ihtiyaç duyduðumuz nesneler oluþturuluyor. Yani çantayý malzemeleri hazýrla kýsmý. 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// ne istiyorsak onu buradan builder a ekliyoruz. 






// bu kýsým http protokolü aracýlýðý ile istemci den gelen her talebte yapýlacak iþlemleri belirtir.
// Yani bu kýsým iþe baþla kýsmý, iþi yap kýsmý.
// bu iþlemlerin bir sýrasý var.
// middleware bir API ye gelen bütün requestlerin baþýna gelecek herþeyin yönetilebilmesi için kullanýlan yapýdýr.
var app = builder.Build();
// Configure the HTTP request pipeline.


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseWelcomePage();


app.MapControllers();

app.Run();
