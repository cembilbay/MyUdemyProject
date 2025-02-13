using HotelProject.Businesslayer.Abstract;
using HotelProject.Businesslayer.Concrate;
using HotelProject.DataAcessLayer.Abstract;
using HotelProject.DataAcessLayer.Concrate;
using HotelProject.DataAcessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();
builder.Services.AddScoped<IServicesDal, EfServiceDal>();
builder.Services.AddScoped<IServicesService, ServiceManager>();
builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();
builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<ISendMessageDal, EfSendMessageDal>();
builder.Services.AddScoped<ISendMessageService, SendMessageManager>();
builder.Services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
builder.Services.AddScoped<IMessageCategoryService, MessageCategoryManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IGuestDal, EfGuestDal>();
builder.Services.AddScoped<IGuestService, GuestManager>();
builder.Services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();
builder.Services.AddScoped<IWorkLocationService, WorkLocationManager>();

builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<IAppUserService, AppUserManager>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("OtelApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
