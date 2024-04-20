namespace FinalProjectIOOP
{
    public class EquipmentCategory
    {
        private int equipmentCategoryID;
        private string categoryName;

        public int EquipmentCategoryID { get; set; }

        public string CategoryName { get; set; }

        public EquipmentCategory(int equipmentCategoryID, string categoryName)
        {
            EquipmentCategoryID = equipmentCategoryID;
            CategoryName = categoryName;
        }

        public EquipmentCategory()
        {
        }

        public override string ToString()
        {
            return "Equipment Category ID: " + EquipmentCategoryID + "\nCategory Name: " + CategoryName;
        }
    }
}
