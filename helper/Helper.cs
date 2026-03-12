
using System.Data;
using System.Diagnostics;

namespace Prac.helper;

internal class Helper : IHelper
{
    public void Quest(string question)
    {
        Console.WriteLine(question);
    }

    public string SubmitUrl()
    {
        string? response = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(response) || !response.StartsWith("https://"))
        {
            Console.WriteLine("Please Provide valid url");
            response = Console.ReadLine();
        }
        return response;
    }

    public static string OpenBrowser()
    {
        var fireFox = @"C:\Program Files\Mozilla Firefox\firefox.exe";
        var chrome = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

        if (!File.Exists(chrome))
        {
            return fireFox;
        }
        return chrome;
    }

    public async Task GoTo(string url)
    {
        using var process = new Process();
        process.StartInfo.FileName = OpenBrowser();
        process.StartInfo.Arguments = url;
        try
        {
            process.Start();
            await process.WaitForExitAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return;
    }

    public async Task Picker(List<string> li)
    {
        switch (Console.ReadLine())
        {
            case "1":
                await GoTo(li[0].Split().Last());
                break;
            case "2":
                await GoTo(li[1].Split().Last());
                break;
            case "3":
                await GoTo(li[2].Split().Last());
                break;
            case "4":
                await GoTo(li[3].Split().Last());
                break;
            case "5":
                await GoTo(li[4].Split().Last());
                break;
            case "6":
                await GoTo(li[5].Split().Last());
                break;
            case "7":
                await GoTo(li[6].Split().Last());
                break;
            case "8":
                await GoTo(li[7].Split().Last());
                break;
            case "9":
                await GoTo(li[8].Split().Last());
                break;
            case "10":
                await GoTo(li[9].Split().Last());
                break;
            case "11":
                await GoTo(li[10].Split().Last());
                break;
            case "12":
                await GoTo(li[11].Split().Last());
                break;
            case "13":
                await GoTo(li[12].Split().Last());
                break;
            case "14":
                await GoTo(li[13].Split().Last());
                break;
            case "15":
                await GoTo(li[14].Split().Last());
                break;
            case "16":
                await GoTo(li[15].Split().Last());
                break;
            case "17":
                await GoTo(li[16].Split().Last());
                break;
            case "18":
                await GoTo(li[17].Split().Last());
                break;
            case "19":
                await GoTo(li[18].Split().Last());
                break;
            case "20":
                await GoTo(li[19].Split().Last());
                break;
            default:
                throw new Exception("Invalid Link");
        }
    }
}