namespace wizard_warriors;
abstract class Character{

    private string characterType;
    protected bool isVulnerable;
    protected Character(string characterType){
        this.characterType = characterType;
        this.isVulnerable = false;
    }
    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable(){
        return false;
    }
    public override string ToString()
    {
        return $"Character is a {this.characterType}";
    }
}