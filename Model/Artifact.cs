public class Artifact{
    private string name;
    private double atkBonus;
    private double critRateBonus;
    private double critDamageBonus;
    private double elementalMastery;
    private double elementalbonus;
    Artifact(string name, double atkBonus, double critRateBonus, double critDamageBonus, 
            double elementalMastery)
    {
        this.name = name;
        this.atkBonus = atkBonus;
        this.critRateBonus = critRateBonus;
        this.elementalMastery = elementalMastery;
        this.elementalbonus = elementalbonus;
    }

    public double GetCritRate(){
        return critRate;
    }
    public double GetCritDamage() {
        critDamage;
    }
    public double GetElementalBonus() {
        elementalBonus;
    }
    public double GetEM() {
        elementalMastery;
    }
    public double GetAtkPercent() {
        atkPercent;
    }
}