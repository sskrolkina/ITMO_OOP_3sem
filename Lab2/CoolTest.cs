using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class CoolTest
{
    [Fact]
    public void GoodComputer()
    {
        // Arrange
        var coolPc = new ComputerAssembly(
            computerCase: "HyperXXX",
            powerSupply: "DEEPCOOL PF-600",
            motherBoard: "GIGABYTE B550",
            ssd: "Kingston A400",
            processor: "Intel Core i7-13700KF",
            cooler: "ID-Cooling SE-224",
            ram: "Patriot Viper 3",
            hardDrive: "Seagate BarraCuda",
            videoCard: "GeForce GTX 2280",
            bios: "BIOS",
            wifi: null);

        // Act
        coolPc.Assemble();
        var validator = new Validator(coolPc.ComputerBuilder);

        // Assert
        Assert.IsType<Success>(coolPc.Assemble());
        Assert.IsType<GoodBuild>(validator.GerRuslt());
    }

    [Fact]
    public void WeakComputer()
    {
        // Arrange
        var coolPc = new ComputerAssembly(
            computerCase: "HyperXXX",
            powerSupply: "Cougar STX 700W",
            motherBoard: "GIGABYTE B550",
            ssd: "Kingston A400",
            processor: "Intel Core i7-13700KF",
            cooler: "ID-Cooling SE-224",
            ram: "Patriot Viper 3",
            hardDrive: "Seagate BarraCuda",
            videoCard: "GeForce GTX 2280",
            bios: "BIOS",
            wifi: null);

        // Act
        coolPc.Assemble();
        var validator = new Validator(coolPc.ComputerBuilder);

        // Assert
        Assert.IsType<Success>(coolPc.Assemble());
        Assert.IsType<GoodBuild>(validator.GerRuslt());
        Assert.IsType<CanStartButNotEnoughTdp>(validator.ErrorReason);
    }

    [Fact]
    public void HotComputer()
    {
        // Arrange
        var coolPc = new ComputerAssembly(
            computerCase: "HyperXXX",
            powerSupply: "DEEPCOOL PF-600",
            motherBoard: "GIGABYTE B550",
            ssd: "Kingston A400",
            processor: "Intel Core i7-13700KF",
            cooler: "DEEPCOOL AG400",
            ram: "Patriot Viper 3",
            hardDrive: "Seagate BarraCuda",
            videoCard: "GeForce GTX 2280",
            bios: "BIOS",
            wifi: null);

        // Act
        coolPc.Assemble();
        var validator = new Validator(coolPc.ComputerBuilder);

        // Assert
        Assert.IsType<Success>(coolPc.Assemble());
        Assert.IsType<GoodBuild>(validator.GerRuslt());
        Assert.IsType<CanStartButNotEnoughTdp>(validator.ErrorReason);
    }

    [Fact]
    public void BadComputer()
    {
        // Arrange
        var coolPc = new ComputerAssembly(
            computerCase: "HyperXXX",
            powerSupply: "DEEPCOOL PF-600",
            motherBoard: "GIGABYTE B550",
            ssd: "Kingston A400",
            processor: "Intel Core i5-11400F",
            cooler: "DEEPCOOL AG400",
            ram: "Patriot Viper 3",
            hardDrive: "Seagate BarraCuda",
            videoCard: "GeForce GTX 2280",
            bios: "BIOS",
            wifi: null);

        // Act
        coolPc.Assemble();
        var validator = new Validator(coolPc.ComputerBuilder);

        // Assert
        Assert.IsType<CanNotBuild>(coolPc.Assemble());
        Assert.IsType<BadBuild>(validator.GerRuslt());
        Assert.IsType<WrongSocket>(validator.ErrorReason);
    }
}