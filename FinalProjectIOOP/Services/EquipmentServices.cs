namespace FinalProjectIOOP
{
    public abstract class EquipmentServices
    {
        //method to add a new equipment
        public abstract void AddEquipment(Equipment equipment);

        //method to update an equipment
        public abstract void UpdateEquipment(Equipment equipment);

        //method to delete an equipment
        public abstract void DeleteEquipment(int equipmentID);

        //method to get all equipment
        public abstract List<Equipment> GetAllEquipment();

        //method to get equipment by ID
        public abstract Equipment GetEquipmentByID(int id);

        //method to add a new equipment category
        public abstract void AddEquipmentCategory(EquipmentCategory equipmentCategory);
    }

}
