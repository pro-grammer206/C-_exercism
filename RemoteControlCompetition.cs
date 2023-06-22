using System;
using System.Collections.Generic;

// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar
{
    int DistanceTravelled { get; set; }
    void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; set; } = 10;
    public int NumberOfVictories { get; set; }

    public int CompareTo(ProductionRemoteControlCar? other)
    {
        int otherVictories = other is not null ? other.NumberOfVictories : 0;
        return this.NumberOfVictories - otherVictories;
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; set; } = 20;

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static List<IRemoteControlCar> cars = new();
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        List<ProductionRemoteControlCar> pc = new();
        pc.Add(prc1);
        pc.Add(prc2);
        pc.Sort();
        return pc;

    }
}
