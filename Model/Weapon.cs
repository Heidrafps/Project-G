namespace GenshinCalculator.Models
{
    public class Weapon
    {
        uint baseAtk;
        double critDamage;
        double critRate;
        double atkBonus;
        double hpBonus;
        double defBonus;
        double elementalMastery;

        public Weapon(uint baseAtk, double critRate, double critDamage, double atkBonus,
                    double hpBonus, double defBonus, double elementalMastery)
        {
            this.baseAtk = baseAtk;
            this.critRate = critRate;
            this.critDamage = critDamage;
            this.atkBonus = atkBonus;
            this.hpBonus = hpBonus;
            this.defBonus = defBonus;
            this.elementalBonus = elementalBonus;
        }

        public uint GetBaseAtk()
        {
            return baseAtk;    
        }

        public double GetCritRate()
        {
            return critRate;
        }

        public double GetCritDamage()
        {
            return critDamage;
        }

        public double GetAtkBonus()
        {
            return (1+atkBonus);
        }

        public double hpBonus()
        {
            return (1+hpBonus);
        }

        public double defBonus()
        {
            return (1+defBonus);
        }

        public double GetEM()
        {
            return elementalMastery;
        }
    }
}