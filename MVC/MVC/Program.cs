using System.IO.Ports;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 加入分散式記憶體快取，Session 需要此服務
builder.Services.AddDistributedMemoryCache();

// 加入 Session 服務，並設定過期時間與 Cookie 屬性
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20); // 設定 Session 過期時間
    options.Cookie.HttpOnly = true;                // 提高安全性
    options.Cookie.IsEssential = true;             // 必要性 Cookie
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 啟用 Session 中介軟體
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();