using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using roomapi.model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RoomDb>(opt => opt.UseInMemoryDatabase("Rooms"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


var app = builder.Build();

//configure HTTP Requuest Pipeline
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();
}

app.UseHttpsRedirection();
 
//app.MapGet("/", () => "Hello World!");

app.MapGet("/", () =>{
return "realeast I've ever known";
} );

app.MapGet("/rooms", ()=> { 
    return Results.Ok(Store.roomList);
});

app.MapGet("/rooms/{id:int}", (int id)=> { 
    return Results.Ok(Store.roomList.FirstOrDefault(u=>u.Id==id));
});

app.MapPost("/room", ([FromBody] Room room) =>{
if(room.Id != 0 || string.IsNullOrEmpty(room.Name)){
    return Results.BadRequest("Invalid Id or Name");
}

//Add another if for same name case

room.Id = Store.roomList.OrderByDescending(u=>u.Id).FirstOrDefault().Id + 1;
Store.roomList.Add(room);
return Results.Ok(room);
});

app.MapPut("/room", () =>{

});

app.MapDelete("/room/{id:int}", (int id) =>{

});



app.Run();



