using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;

public class FileLogger : ILogger
{
    public async void GoodLog(string name)
    {
        using (var writer = new StreamWriter("cool.txt", true))
        {
            await writer.WriteLineAsync(name + "is sent").ConfigureAwait(true);
        }
    }

    public async void BadLog(string name)
    {
        using (var writer = new StreamWriter("cool.txt", true))
        {
            await writer.WriteLineAsync(name + "isn't sent").ConfigureAwait(true);
        }
    }
}