namespace WizTime
{
    public interface IEquipable
    {
        void Equip();
        void UnEquip();
    }

    public interface IAttackable
    {
        void Attack();
        void Defend();
    }

    public interface ITalkable
    {
        void Talk();
    }

    public interface IInteractable
    {
        void Interact();
    }

    public interface IConsumable
    {
        void Consume();
    }
    
}