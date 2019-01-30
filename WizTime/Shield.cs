namespace WizTime
{
    public class Shield : Item
    {
        public int Defense;

        public Shield()
        {
            
        }

        public Shield(string name, int def)
        {
            Name = name;
            Defense = def;
        }
    }
}