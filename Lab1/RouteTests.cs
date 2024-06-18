using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Route;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class RouteTests
{
    [Fact]
    public void AugurAndShuttleInHighDensityNebulae()
    {
        // Arrange
        IEnvironment environment = new HighDensityNebula();
        IRoute route = new MiddleDistanceRoute();
        SpaceShip pleasureWalker = new PleasureShuttle();
        SpaceShip augur = new Augur(null);
        var travel = new Travel();

        // Act
        Travel firstResult = travel.TryToFly(pleasureWalker, environment);
        Travel secondResult = travel.TryToFly(augur, environment);
        Travel thirdResult = travel.Fly(route, augur, environment);

        // Assert
        Assert.IsType<ShipCanNotGoThere>(firstResult);
        Assert.IsType<ShipInEnvironment>(secondResult);
        Assert.IsType<ShipDidNotReach>(thirdResult);
    }

    [Fact]
    public void AntiMatterHitVaclas()
    {
        // Arrange
        IEnvironment environment = new HighDensityNebula();
        SpaceShip vaclas = new Vaclas(null);
        IPhotonicDeflector photonicDeflector = new PhotonicDeflector();
        SpaceShip coolerVaclas = new Vaclas(photonicDeflector);
        IObstacles light = new AntimatterFlares();
        var obstaclesList = new List<IObstacles> { light };
        ICollisions collisions = new Collision(obstaclesList, vaclas);
        ICollisions againCollisions = new Collision(obstaclesList, coolerVaclas);

        // Act
        collisions.TryToCollide(environment);
        againCollisions.TryToCollide(environment);

        // Assert
        Assert.IsType<CrewWasKilled>(vaclas.CrewStatus);
        Assert.IsType<CrewIsAlive>(coolerVaclas.CrewStatus);
    }

    [Theory]
    [MemberData(nameof(TestGenerator.ShipsStatus), MemberType = typeof(TestGenerator))]
    public void CosmoWhaleAttacking(SpaceShip ship, Type collisionResult)
    {
        // Arrange
        IEnvironment environment = new NitrideParticlesNebula();
        IObstacles whale = new CosmoWhale();
        var obstacles = new List<IObstacles> { whale };
        ArgumentNullException.ThrowIfNull(ship);
        ICollisions collisions = new Collision(obstacles, ship);

        // Act
        collisions.TryToCollide(environment);

        // Assert
        Assert.IsType(collisionResult, ship.ShipStatus);
    }

    [Fact]
    public void OptimalShuttleOrVaclas()
    {
        // Arrange
        SpaceShip firstShip = new Vaclas(null);
        SpaceShip secondShip = new PleasureShuttle();
        var route = new ShortDistanceRoute();
        IEnvironment space = new Space();
        var travel = new Travel();
        var optimal = new FindOptimalShip(firstShip, secondShip);

        // Act
        travel.Fly(route, firstShip, space);
        travel.Fly(route, secondShip, space);
        optimal.OptimalForPulseEngine();

        // Assert
        Assert.IsType<NotOptimalShip>(optimal.FirstShip);
        Assert.IsType<OptimalShip>(optimal.SecondShip);
    }

    [Fact]
    public void OptimalAugurOrStella()
    {
        // Arrange
        SpaceShip firstShip = new Augur(null);
        SpaceShip secondShip = new Stella(null);
        var route = new MiddleDistanceRoute();
        IEnvironment environment = new HighDensityNebula();
        var travel = new Travel();
        var optimalShip = new FindOptimalShip(firstShip, secondShip);

        // Act
        travel.Fly(route, firstShip, environment);
        travel.Fly(route, secondShip, environment);
        optimalShip.OptimalForJumpEngine();

        // Assert
        Assert.IsType<NotOptimalShip>(optimalShip.FirstShip);
        Assert.IsType<OptimalShip>(optimalShip.SecondShip);
    }

    [Fact]
    public void FasterVaclasOrPleasureShuttle()
    {
        // Arrange
        SpaceShip firstShip = new Vaclas(null);
        SpaceShip secondShip = new PleasureShuttle();
        var optimalShip = new FindOptimalShip(firstShip, secondShip);

        // Act
        optimalShip.FastestShipWithPulseEngine();

        // Assert
        Assert.IsType<NotOptimalShip>(optimalShip.FirstShip);
        Assert.IsType<OptimalShip>(optimalShip.SecondShip);
    }

    [Fact]
    public void SeveralSegmentsOfTheWay()
    {
        // Arrange
        SpaceShip shuttle = new PleasureShuttle();
        IEnvironment space = new Space();
        var firstPartOfTheWay = new ShortDistanceRoute();
        var secondsPartOfTheWay = new ShortDistanceRoute();
        var allTheWay = new List<IRoute> { firstPartOfTheWay, secondsPartOfTheWay };
        var travel = new Travel();

        // Act
        var path = new Path(allTheWay);
        Travel result = travel.Fly(path, shuttle, space);

        // Assert
        Assert.IsType<ShipDidNotReach>(result);
    }
}