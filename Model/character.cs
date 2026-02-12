namespace GenshinCalculator.Models{
    // For all double types, 0.XX will mean XX%
    public class Character
    {
        private string name;
        private Role role;
        private uint baseAtk;
        private long baseHp;
        private long baseDef;
        private double critRate;
        private double critDamage;
        private double elementalBonus;
        private double elementalMastery;
        private Artifact artifactSet;
        public Weapon EquippedWeapon;
        public Character(string name, Role role, uint baseAtk, long baseHp, long baseDef,
                        double critRate, double critDamage, double elementalMastery, Weapon weapon)
        {
            this.name = name;
            this.role = role;
            this.baseAtk = baseAtk;
            this.baseHp = baseHp;
            this.baseDef = baseDef;
            this.critRate = critRate;
            this.critDamage = critDamage;
            this.elementalBonus = elementalBonus;
            EquippedWeapon = weapon;
            elementalBonus = 0.0;

        }
        
        public double GetCritRate()
        {
            return critRate;
        }

        public double GetElementalMastery()
        {
            return elementalMastery;
        }

        public double GetBaseAttack()
        {
            return baseAtk;
        }

        // This function assumes that the character has crit. 
        // Precondition: This function must have been provided a non-negative 
        // critDamage of type double.
        // Postcondition: This function give the critDamage multiplier, which is 
        // to be used in the total damage calculation. The multiplier is already provided,
        // meaning any critdamage below 100% wouldn't mitigate your damage. 
        public double CritDamageMultiplier()
        {
            return (1+critDamage);
        }
    }   
}