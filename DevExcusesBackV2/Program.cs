﻿using DevExcusesBackV2.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ExcuseDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//var excuses = new List<Excuse>()
//{
//    new Excuse() { Http_code = 701,Tag= "Inexcusable",Message=" Meh"},
//    new Excuse() { Http_code = 702,Tag= "Inexcusable",Message=" Emacs"},
//    new Excuse() { Http_code = 703,Tag= "Inexcusable",Message=" Explosion"},
//    new Excuse() { Http_code = 704,Tag= "Inexcusable",Message=" Goto Fail"},
//    new Excuse() { Http_code = 705,Tag= "Inexcusable",Message=" I wrote the code and missed the necessary validation by an oversight(see 795)"},
//    new Excuse() { Http_code = 706,Tag= "Inexcusable",Message=" Delete Your Account"},
//    new Excuse() { Http_code = 707,Tag= "Inexcusable",Message=" Can't quit vi"},
//    new Excuse() { Http_code = 710,Tag= "Novelty Implementations",Message=" PHP"},
//    new Excuse() { Http_code = 711,Tag= "Novelty Implementations",Message=" Convenience Store"},
//    new Excuse() { Http_code = 712,Tag= "Novelty Implementations",Message=" NoSQL"},
//    new Excuse() { Http_code = 718,Tag= "Novelty Implementations",Message=" I am not a teapot"},
//    new Excuse() { Http_code = 719,Tag= "Novelty Implementations",Message=" Haskell"},
//    new Excuse() { Http_code = 720,Tag= "Edge Cases",Message=" Unpossible"},
//    new Excuse() { Http_code = 721,Tag= "Edge Cases",Message=" Known Unknowns"},
//    new Excuse() { Http_code = 722,Tag= "Edge Cases",Message=" Unknown Unknowns"},
//    new Excuse() { Http_code = 723,Tag= "Edge Cases",Message=" Tricky"},
//    new Excuse() { Http_code = 724,Tag= "Edge Cases",Message=" This line should be unreachable"},
//    new Excuse() { Http_code = 725,Tag= "Edge Cases",Message=" It works on my machine"},
//    new Excuse() { Http_code = 726,Tag= "Edge Cases",Message=" It's a feature, not a bug"},
//    new Excuse() { Http_code = 727,Tag= "Edge Cases",Message=" 32 bits is plenty"},
//    new Excuse() { Http_code = 728,Tag= "Edge Cases",Message=" It works in my timezone"},
//    new Excuse() { Http_code = 730,Tag= "Fucking",Message=" Fucking npm"},
//    new Excuse() { Http_code = 731,Tag= "Fucking",Message=" Fucking Rubygems"},
//    new Excuse() { Http_code = 732,Tag= "Fucking",Message=" Fucking Unic💩de"},
//    new Excuse() { Http_code = 733,Tag= "Fucking",Message=" Fucking Deadlocks"},
//    new Excuse() { Http_code = 734,Tag= "Fucking",Message=" Fucking Deferreds"},
//    new Excuse() { Http_code = 736,Tag= "Fucking",Message=" Fucking Race Conditions"},
//    new Excuse() { Http_code = 735,Tag= "Fucking",Message=" Fucking IE"},
//    new Excuse() { Http_code = 737,Tag= "Fucking",Message=" FuckThreadsing"},
//    new Excuse() { Http_code = 738,Tag= "Fucking",Message=" Fucking Exactly-once Delivery"},
//    new Excuse() { Http_code = 739,Tag= "Fucking",Message=" Fucking Windows"},
//    new Excuse() { Http_code = 738,Tag= "Fucking",Message=" Fucking Exactly"},
//    new Excuse() { Http_code = 739,Tag= "Fucking",Message=" Fucking McAfee"},
//    new Excuse() { Http_code = 750,Tag= "Syntax Errors",Message=" Didn't bother to compile it"},
//    new Excuse() { Http_code = 753,Tag= "Syntax Errors",Message=" Syntax Error"},
//    new Excuse() { Http_code = 754,Tag= "Syntax Errors",Message=" Too many semi-colons"},
//    new Excuse() { Http_code = 755,Tag= "Syntax Errors",Message=" Not enough semi-colons"},
//    new Excuse() { Http_code = 756,Tag= "Syntax Errors",Message=" Insufficiently polite"},
//    new Excuse() { Http_code = 757,Tag= "Syntax Errors",Message=" Excessively polite"},
//    new Excuse() { Http_code = 759,Tag= "Syntax Errors",Message=" Unexpected `T_PAAMAYIM_NEKUDOTAYIM`"},
//    new Excuse() { Http_code = 761,Tag= "Substance",Message=" Hungover"},
//    new Excuse() { Http_code = 762,Tag= "Substance",Message=" Stoned"},
//    new Excuse() { Http_code = 763,Tag= "Substance",Message=" Under-Caffeinated"},
//    new Excuse() { Http_code = 764,Tag= "Substance",Message=" Over-Caffeinated"},
//    new Excuse() { Http_code = 765,Tag= "Substance",Message=" Railscamp"},
//    new Excuse() { Http_code = 766,Tag= "Substance",Message=" Sober"},
//    new Excuse() { Http_code = 767,Tag= "Substance",Message=" Drunk"},
//    new Excuse() { Http_code = 768,Tag= "Substance",Message=" Accidentally Took Sleeping Pills Instead Of Migraine Pills During Crunch Week"},
//    new Excuse() { Http_code = 771,Tag= "Predictable Problems",Message=" Cached for too long"},
//    new Excuse() { Http_code = 772,Tag= "Predictable Problems",Message=" Not cached long enough"},
//    new Excuse() { Http_code = 773,Tag= "Predictable Problems",Message=" Not cached at all"},
//    new Excuse() {Http_code = 774,Tag="Predictable Problems",Message="Why was this cached ? "},
//    new Excuse() {Http_code = 775,Tag="Predictable Problems",Message="Out of cash"},
//    new Excuse() {Http_code = 776,Tag= "Predictable Problems",Message=" Error on the Exception"},
//    new Excuse() {Http_code = 777,Tag= "Predictable Problems",Message=" Coincidence"},
//    new Excuse() {Http_code = 778,Tag= "Predictable Problems",Message=" Off By One Error"},
//    new Excuse() {Http_code = 779,Tag= "Predictable Problems",Message=" Off By Too Many To Count Error"},
//    new Excuse() {Http_code = 780,Tag= "Somebody Else's Problem",Message=" Project owner not responding"},
//    new Excuse() {Http_code = 781,Tag= "Somebody Else's Problem",Message=" Operations"},
//    new Excuse() {Http_code = 782,Tag= "Somebody Else's Problem",Message=" QA"},
//    new Excuse() {Http_code = 783,Tag= "Somebody Else's Problem",Message=" It was a customer request, honestly"},
//    new Excuse() {Http_code = 784,Tag= "Somebody Else's Problem",Message=" Management, obviously"},
//    new Excuse() {Http_code = 785,Tag= "Somebody Else's Problem",Message=" TPS Cover Sheet not attached"},
//    new Excuse() {Http_code = 786,Tag= "Somebody Else's Problem",Message=" Try it now"},
//    new Excuse() {Http_code = 787,Tag= "Somebody Else's Problem",Message=" Further Funding Required"},
//    new Excuse() {Http_code = 788,Tag= "Somebody Else's Problem",Message=" Designer's final designs weren't"},
//    new Excuse() {Http_code = 789,Tag= "Somebody Else's Problem",Message=" Not my department"},
//    new Excuse() {Http_code = 791,Tag= "Internet crashed",Message=" The Internet shut down due to copyright restrictions"},
//    new Excuse() {Http_code = 792,Tag= "Internet crashed",Message=" Climate change driven catastrophic weather event"},
//    new Excuse() {Http_code = 793,Tag= "Internet crashed",Message=" Zombie Apocalypse"},
//    new Excuse() {Http_code = 794,Tag= "Internet crashed",Message=" Someone let PG near a REPL"},
//    new Excuse() {Http_code = 795,Tag= "Internet crashed",Message=" #heartbleed (see 705)"},
//    new Excuse() {Http_code = 796,Tag= "Internet crashed",Message=" Some DNS fuckery idno"},
//    new Excuse() {Http_code = 797,Tag= "Internet crashed",Message=" This is the last page of the Internet.Go back"},
//    new Excuse() {Http_code = 798,Tag= "Internet crashed",Message=" I checked the db backups cupboard and the cupboard was bare"},
//    new Excuse() { Http_code = 799,Tag= "Internet crashed",Message=" End of the world"}
//};


app.MapGet("/excuse", async (ExcuseDbContext context) =>
    await context.Excuses.ToListAsync());


app.MapGet("/excuse/{http_code}", async (ExcuseDbContext context, int http_code) =>
    await context.Excuses.FindAsync(http_code) is Excuse excuse ?
    Results.Ok(excuse) :
    Results.NotFound("Inéxistante"));

//app.MapGet("/excuse/{id}", (int id) =>
//{
//    var excuse = excuses.Find(e => e.ID == id);
//    if (excuse == null)
//        return Results.NotFound("Sorry, this excuse doesn't exist");

//    return Results.Ok(excuse);
//});

//app.MapPost("/excuse", (Excuse excuse) => {
//    excuses.Add(excuse);
//    return excuses;
//});

app.MapPost("/excuse", async (ExcuseDbContext context, Excuse excuse) =>
{
    context.Excuses.Add(excuse);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Excuses.ToListAsync());
});

app.MapDelete("/excuse/{id}", async (ExcuseDbContext context, int id) =>
{
    var excuse = await context.Excuses.FindAsync(id);
    if (excuse is null) return Results.NotFound("Cette excuse n'existe pas");

    context.Excuses.Remove(excuse);
    await context.SaveChangesAsync();

    return Results.Ok( await context.Excuses.ToListAsync());
});


app.Run();


