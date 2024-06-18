using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using FluentChaining;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parsers;

public class DeleteCommandParse : ILink<ICollection<string>, ICommand>
{
    private IFileSystemCommandsReceiver _receiver;

    public DeleteCommandParse(IFileSystemCommandsReceiver receiver)
    {
        _receiver = receiver;
    }

    public ICommand Process(ICollection<string> request, SynchronousContext context, LinkDelegate<ICollection<string>, SynchronousContext, ICommand>? next)
   {
      if (request.ElementAt(0).Equals("file", StringComparison.OrdinalIgnoreCase) &&
          request.ElementAt(1).Equals("delete", StringComparison.OrdinalIgnoreCase))
      {
          return new DeleteCommand(request.ElementAt(2), _receiver);
      }
      else
      {
          if (next is not null) return next(request, context);
          return new NullCommand();
      }
   }
}