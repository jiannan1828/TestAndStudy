using System.IO.Ports;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// �[�J�������O����֨��ASession �ݭn���A��
builder.Services.AddDistributedMemoryCache();

// �[�J Session �A�ȡA�ó]�w�L���ɶ��P Cookie �ݩ�
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20); // �]�w Session �L���ɶ�
    options.Cookie.HttpOnly = true;                // �����w����
    options.Cookie.IsEssential = true;             // ���n�� Cookie
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

// �ҥ� Session �����n��
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();