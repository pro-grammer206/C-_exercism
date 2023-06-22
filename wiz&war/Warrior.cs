namespace wizard_warriors;

class Warrior:Character{
    public Warrior():base("Warrior"){

    }
    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable()){
            return 10;
        }
        return 6;
    }
    public override bool Vulnerable()
    {
        return base.Vulnerable();
    }

}