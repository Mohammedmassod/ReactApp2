using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // يجب إضافته لكي تتمكن من فعل ذلك  
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1",
        Description = "وصف API الخاص بي",
        Contact = new OpenApiContact
        {
            Name = "محد مسعود",
            Email = "moh@ex.com",
            Url = new Uri("http://example.com")
        }
    });
    // إضافة إعدادات الأمان (مثل المصادقة)  
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "يرجى إدخال رموز التصريح كـ 'Bearer {token}'",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin() // يسمح بأي أصل  
                   .AllowAnyMethod() // يسمح بأي طريقة (GET, POST, PUT, DELETE, إلخ)  
                   .AllowAnyHeader(); // يسمح بأي رأس  
        });
});
var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // توليد وثائق Swagger  
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); // توفير الرابط لـ OpenAPI JSON  
        c.RoutePrefix = string.Empty; // أو يمكنك تركه كما هو في المجلد swagger  
    });

    app.MapOpenApi(); // إذا كان له حاجة في تقديم نقط نهاية JSON  
}
// استخدام سياسة CORS  
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
