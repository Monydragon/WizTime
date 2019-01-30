namespace WizTime
{
    public class Item
    {
        public string Name;
        public int Value;
        public bool isEquipable;
        public bool isConsumable;
        public EquipmentSlots slotEquip = EquipmentSlots.None;

        public Item()
        {
            
        }
        
        public Item(string name, int value = 0, bool isequip = false, bool isconsumable = false, EquipmentSlots equipslot = EquipmentSlots.None)
        {
            Name = name;
            Value = value;
            isEquipable = isequip;
            isConsumable = isconsumable;
            slotEquip = equipslot;
        }
        
    }
}