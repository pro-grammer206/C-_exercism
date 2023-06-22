namespace wizard_warriors;

class Wizard:Character{
    private bool isSpellPrepared;
    public Wizard():base("Wizard"){
        isSpellPrepared = false;
    }

    public override int DamagePoints(Character target)
    {
        if(isSpellPrepared){
            return 12;
        }
        return 3;
    }

    public void PrepareSpell(){
        this.isSpellPrepared = true;
    }
        public override bool Vulnerable()
    {
        if(!this.isSpellPrepared){
            base.isVulnerable = true;
        }
        return base.isVulnerable;
    }

}