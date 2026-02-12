namespace GenshinCalculator.Services
{
    public class Reaction
    {
        // This function is for TRANSFORMATIVE reactions only. 
        // Precondition: The elementalBonus must be a valid double number
        // Postcondition: This function will return the bonus damage a character
        // will recieve based on their elemental mastery.        
        public double BonusTransformative(double elementalBonus)
        {
            return (16*elementalBonus)/(elementalBonus+2000);    
        }
        // This function is for AMPLIFYING reactions only. 
        // Precondition: The elementalBonus must be a valid double number
        // Postcondition: This function will return the bonus damage a character
        // will recieve based on their elemental mastery.        
        public double BonusAmplify(double elementalBonus)
        {
            return (25/9)*((elementalBonus)/(elementalBonus+1400));    
        }
        // This function is for Catalyze reactions only. 
        // Precondition: The elementalBonus must be a valid double number
        // Postcondition: This function will return the bonus damage a character
        // will recieve based on their elemental mastery.        
        public double BonusCatalyze(double elementalBonus)
        {
            return (5 * elementalBonus)/(elementalBonus+1200);    
        }
    }
}