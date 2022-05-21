//burasý ilk aþama çantaya malzemeleri koymak gibi. iþlemleri hazýrla yani. hangi nesnelerle iþ yapýcaksam builder.Services diyerek onlarýn nesnelerini ekliyorum.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => opt.AddPolicy("AllowAll", p =>  //ekledik.
{
    p.AllowAnyOrigin();
    p.AllowAnyMethod();
    p.AllowAnyHeader();
}));





// burasý 2.aþama yani requestten gelen her talepte yapýlacak iþlemleri belirtiyoruz.
// use ile baþlayan herþey seri imalattaki bir iþlem gibi düþünebiliriz.
// bunlarýn sýrasý da önemli.

var app = builder.Build();

app.UseWelcomePage();  // bu satýrý yazarak bütün requestleri buraya yönlendirdik.


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();


app.MapControllers();

app.Run();

