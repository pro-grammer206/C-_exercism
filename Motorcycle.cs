using System;

abstract class Motorcycle
{
    public void StartEngine(){}
    protected void AddGas(int gallons){}
    public virtual int Drive(int miles,int speed){return 1;}

    public virtual int Drive(TimeSpan time,int speed){return 1;}

    public abstract double GetTopSpeed();

}
