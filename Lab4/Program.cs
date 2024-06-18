using System;
using System.Collections.Generic;
using CommandLine;
using FluentChaining;

namespace Itmo.ObjectOrientedProgramming.Lab4;

internal class Program
{
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<string>(args).WithParsed(RunProgram);
    }

    private static void RunProgram(string command)
    {
        while (!string.Equals(command, "disconnect", StringComparison.Ordinal))
        {
        }
    }
}