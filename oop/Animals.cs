namespace Oop;

class Animals{
    private  int numberOfLegs;
    private double weight;

    public Animals(int legs,double weight = 10.0){
        numberOfLegs = legs;
         this.weight = weight;
    }

    public override string ToString()
    {
        return $"The animal has {this.numberOfLegs} legs and weighs {this.weight} Kg";
    }
}