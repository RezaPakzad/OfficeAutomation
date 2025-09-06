using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OfficeAutomation.Application;
using OfficeAutomation.Infrastructure;
using OfficeAutomation.Infrastructure.Context;
using Serilog;
using System.Reflection;

// ساخت یک WebApplicationBuilder که تنظیمات اولیه اپلیکیشن (DI, Logging, Configurations و ...) رو آماده می‌کنه
var builder = WebApplication.CreateBuilder(args);

// ✨ ثبت سرویس‌های مورد نیاز در DI Container ✨

// اضافه کردن پشتیبانی از Controller ها و View ها (الگوی MVC)
builder.Services.AddControllersWithViews();

// اضافه کردن پشتیبانی از Razor Pages (صفحات Razor)
builder.Services.AddRazorPages();





// اضافه کردن پشتیبانی از Blazor Server (برای کامپوننت‌های تعاملی Blazor)
builder.Services.AddServerSideBlazor();

// اضافه کردن سرویس‌های لایه Application (یک Extension Method که خودت تعریف کردی)
builder.Services.AddApplication();

// پیکربندی Entity Framework Core
builder.Services.AddInfrastructure(builder.Configuration);//اکستنشن متد سفارشی
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// پیکربندی Serilog
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

// افزودن Swagger
builder.Services.AddEndpointsApiExplorer();

// ساخت اپلیکیشن (WebApplication) بر اساس تنظیماتی که بالا تعریف شده
var app = builder.Build();


//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// پیکربندی pipeline
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSerilogRequestLogging(); // ثبت لاگ درخواست‌ها
// ✨ تنظیمات Middleware ها ✨

// اگر محیط Development نباشد (یعنی Production یا Staging باشه)
if (!app.Environment.IsDevelopment())
{
    // در صورت خطا، به صفحه‌ی Error هدایت می‌کنه (به جای نمایش خطای دقیق)
    app.UseExceptionHandler("/Error");

    // فعال‌سازی HSTS (HTTP Strict Transport Security) برای امنیت بیشتر HTTPS
    app.UseHsts();
}

// ریدایرکت اتوماتیک درخواست‌های HTTP به HTTPS
app.UseHttpsRedirection();

// فعال‌سازی دسترسی به فایل‌های استاتیک (wwwroot مثل CSS, JS, Images)
app.UseStaticFiles();

// فعال‌سازی Routing (برای مسیردهی درخواست‌ها)
app.UseRouting();

// ✨ تعریف Endpoints ✨

// نگاشت آدرس‌ها به Controller ها (برای MVC)
app.MapControllers();

// نگاشت آدرس‌ها به Razor Pages
app.MapRazorPages();

// نگاشت Blazor Hub (ارتباط SignalR برای Blazor Server)
app.MapBlazorHub();

// اجرای اپلیکیشن (شروع به گوش دادن روی پورت تعریف‌شده)
app.Run();

//🎯 تشبیه ساده

//builder = مثل «آشپزخانه» که مواد اولیه رو آماده می‌کنی (برنج، گوشت، ادویه‌ها). 🍚🍖

//app = مثل «سرآشپز» که حالا اون غذا رو با مواد آماده شده می‌پزه و سرو می‌کنه. 🍲

//یعنی اول باید سرویس‌ها رو توی builder ثبت کنی، بعد توی app بگی که این سرویس‌ها کجا و چطور استفاده بشن.

//🔹 در مرحله‌ی builder سرویس‌ها و تنظیمات ثبت می‌شن.

//🔹 بعد با builder.Build() اپلیکیشن ساخته می‌شه و شیء app رو داریم.

//🔹 در نهایت با app.Run()، Pipeline (یعنی Middlewareها، Routing و ...) اجرا می‌شه.

//می‌خوای برات یه نمونه کد خیلی ساده بزنم که هر سه مرحله (builder → app → pipeline) رو کنار هم نشون بده؟

