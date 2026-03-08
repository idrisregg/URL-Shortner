
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

    public async Task GoTo(string url)
    {
        using var process = new Process();
        process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
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

}