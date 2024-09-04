using FlintSoft.Version;
using Microsoft.Extensions.DependencyInjection;
using Version = FlintSoft.Version.Version;


var sp = new ServiceCollection()
    .AddFlintSoftVersion(typeof(Program).Assembly)
    .BuildServiceProvider();

var v = sp.GetRequiredService<Version>();

Console.WriteLine(v.GetVersion());

Console.WriteLine(typeof(Program).Assembly.GetVersion());