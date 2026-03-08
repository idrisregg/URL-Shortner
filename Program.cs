using Microsoft.Extensions.DependencyInjection;
using Prac.helper;
using Prac.src;

namespace Prac;

public class Program()
{
    private static List<string> li = new List<string>();
    private static string path = "db.txt";
    private static string Our = "Regg.com/";
    public static async Task Main(string[] args)
    {

        if (!File.Exists(path))
        {
            FileStream fs = File.Create(path);
        }

        //Registering dependency in our program
        var serviceProv = new ServiceCollection()
        .AddSingleton<IHelper, Helper>()
        .AddSingleton<IGenerator, Generator>()
        .BuildServiceProvider();

        var _helper = serviceProv.GetRequiredService<IHelper>();
        var _service = serviceProv.GetRequiredService<IGenerator>();

        _helper.Quest("_______ Welcome To Simple Encoder_______");
        Console.WriteLine("These are your Already Created Links : ");
        li = File.ReadAllLines(path).ToList();
        foreach (var item in li)
        {
            Console.WriteLine(item);
        }
        _helper.Quest("Enter the url you wish to Shorten");

        var url = _helper.SubmitUrl();

        li.Add(Our += _service.Generate(4));
        //added link to local data file 
        File.WriteAllLines(path, li);

        Thread.Sleep(3000);

        Console.Write("Your new Url : ");
        Console.WriteLine(Our);


        await _helper.GoTo(url);
    }
}