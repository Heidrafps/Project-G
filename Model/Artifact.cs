public class Artifact{
    private string name;
    private double atkBonus;
    private double critRateBonus;
    private double critDamageBonus;
    private double elementalMasteryBonus;
    Artifact(string name, double atkBonus, double critRateBonus, double critDamageBonus, 
            double elementalMasteryBonus)
    {
        this.name = name;
        this.atkBonus = atkBonus;
        this.critRateBonus = critRateBonus;
        this.elementalMasteryBonus = elementalMasteryBonus;
    }
}