using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class PhotonicDeflector : IPhotonicDeflector
{
    private const int DeflectAntiMatterFlares = 3000;

    public void Add(IDeflector deflector)
    {
        ArgumentNullException.ThrowIfNull(deflector);
        deflector.Strength += DeflectAntiMatterFlares;
    }
}