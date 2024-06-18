using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ComputerTdp
{
    private readonly Computer _computer;

    public ComputerTdp(Computer computer)
    {
        _computer = computer;
    }

    public double TotalTdp()
    {
        double tdp = 0;
        if (_computer.Processor != null)
        {
            tdp += _computer.Processor.ThermalDesignPower.Power;
        }

        if (_computer.ProcessorCoolingSystem != null)
        {
            tdp += _computer.ProcessorCoolingSystem.MaximumThermalDesignPower.Power;
        }

        if (_computer.RandomAccessMemory != null)
        {
            tdp += _computer.RandomAccessMemory.PowerConsumption.Power;
        }

        if (_computer.VideoCard != null)
        {
            tdp += _computer.VideoCard.PowerConsumption.Power;
        }

        if (_computer.HardDrive != null)
        {
            tdp += _computer.HardDrive.PowerConsumption.Power;
        }

        if (_computer.SsdDrive != null)
        {
           tdp += _computer.SsdDrive.PowerConsumption.Power;
        }

        if (_computer.WiFi != null)
        {
            tdp += _computer.WiFi.PowerConsumption.Power;
        }

        return tdp;
    }
}