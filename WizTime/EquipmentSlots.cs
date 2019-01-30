namespace WizTime
{

    public class EquipSlot
    {
        public EquipmentSlots Slot;
        public Item Item;

        public EquipSlot(EquipmentSlots slot)
        {
            Slot = slot;
        }
        public EquipSlot(EquipmentSlots slot, Item item)
        {
            Slot = slot;
            Item = item;
    
        }
    }
    
    public enum EquipmentSlots
    {
        None,
        Head,
        Torso,
        Left_Hand,
        Right_Hand,
        Legs,
        Feet
    }
}