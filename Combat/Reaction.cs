namespace GenshinCalculator.Services
{
    public class Reaction
    {
        // This function is for TRANSFORMATIVE reactions only. 
        // Precondition: The elementalMastery must be a valid double number
        // Postcondition: This function will return the bonus damage a character
        // will recieve based on their elemental mastery.        
        public double BonusTransformative(double elementalMastery)
        {
            return (16*elementalMastery)/(elementalMastery+2000);    
        }
        // This function is for AMPLIFYING reactions only. 
        // Precondition: The elementalMastery must be a valid double number
        // Postcondition: This function will return the bonus damage a character
        // will recieve based on their elemental mastery.        
        public double BonusAmplify(double elementalMastery)
        {
            return (25/9)*((elementalMastery)/(elementalMastery+1400));    
        }
        // This function is for Catalyze reactions only. 
        // Precondition: The elementalMastery must be a valid double number
        // Postcondition: This function will return the bonus damage a character
        // will recieve based on their elemental mastery.        
        public double BonusCatalyze(double elementalMastery)
        {
            return (5 * elementalMastery)/(elementalMastery+1200);    
        }
    }
}