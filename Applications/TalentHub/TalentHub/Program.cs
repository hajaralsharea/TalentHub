using Employment.UI;

var builder = WebApplication.CreateBuilder(args);

// 1. إعدادات قاعدة البيانات
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. إضافة الـ Controllers
builder.Services.AddControllers();

// 3. تسجيل الموديولات الخاصة بك (مثل موديول التوظيف)
var modules = new List<IModule>
{
    new Module()
};
foreach (var module in modules)
{
  module.AddServices(builder.Services, builder.Configuration);
}

// 4. إعدادات Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSpaStaticFiles(configuration =>
{
  // لازم هاد المسار يطابق الـ outputPath الموجود في angular.json
  // وبما إن الأنجلر داخل مجلدات عميقة، يفضل كتابة المسار كامل من جذر المشروع
  configuration.RootPath = "src/dist/client-app";
});
var app = builder.Build();

// 5. إعداد خط أنابيب الطلبات (Middleware Pipeline)
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 6. السماح للمشروع بعرض الملفات الثابتة (مثل ملفات الأنجلر)
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// 7. ربط الـ API Controllers
app.MapControllers();

// 8. السطر الأهم: توجيه أي رابط غير معروف (مثل /employment) إلى ملف index.html الخاص بالأنجلر
app.MapFallbackToFile("index.html");

app.Run();
