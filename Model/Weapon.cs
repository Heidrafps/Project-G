namespace GenshinCalculator.Models
{
    public class Weapon
    {
        uint baseAtk;
        double mainstat;
        double critDamage;
        double critRate;
        double atkBonus;
        double hpBonus;
        double defBonus;
        double elementalBonus;

        public Weapon(uint baseAtk, double mainstat, double critRate, double critDamage, double atkBonus,
                    double hpBonus, double defBonus, double elementalBonus)
        {
            this.baseAtk = baseAtk;
            this.mainstat = mainstat;
            this.critRate = critRate;
            this.critDamage = critDamage;
            this.atkBonus = atkBonus;
            this.hpBonus = hpBonus;
            this.defBonus = defBonus;
            this.elementalBonus = elementalBonus;
        }
    }
}