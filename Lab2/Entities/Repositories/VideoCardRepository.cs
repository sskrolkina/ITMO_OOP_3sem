using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class VideoCardRepository : IRepository<VideoCard>
{
    private readonly List<VideoCard> _videoCardsList;

    public VideoCardRepository()
    {
        _videoCardsList = new List<VideoCard>();
    }

    public VideoCard? FindByName(string? name)
    {
        return _videoCardsList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(VideoCard obj)
    {
        _videoCardsList.Add(obj);
    }
}