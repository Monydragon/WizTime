namespace WizTime
{
    public class Weapon : Item
    {
        public int Strength;

        public Weapon()
        {
            
        }

        public Weapon(string name, int str)
        {
            Name = name;
            Strength = str;
        }
    }
}