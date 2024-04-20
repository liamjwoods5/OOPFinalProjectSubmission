using System.ComponentModel.DataAnnotations;

namespace FinalProjectIOOP
{
    public class Equipment
    {
        private int equipmentID;
        private string equipmentName;
        private string equipmentDescription;
        private int equipmentCategoryID;
        private string equipmentStatus;

        [Required]
        [Range(0, 99999999999)]
        public int EquipmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string EquipmentName { get; set; }

        [Required]
        [StringLength(100)]
        public string EquipmentDescription { get; set; }

        [Required]
        [Range(0, 99999999999)]
        public int EquipmentCategoryID { get; set; }

        [Required]
        public string EquipmentStatus { get; set; }

        public Equipment(int equipmentID, string equipmentName, string equipmentDescription, int equipmentCategoryID, string equipmentStatus)
        {
            EquipmentID = equipmentID;
            EquipmentName = equipmentName;
            EquipmentDescription = equipmentDescription;
            EquipmentCategoryID = equipmentCategoryID;
            EquipmentStatus = equipmentStatus;
        }

        public Equipment()
        {
        }

        public override string ToString()
        {
            return "Equipment ID: " + EquipmentID + "\nEquipment Name: " + EquipmentName + "\nEquipment Description: " + EquipmentDescription + "\nEquipment Category ID: " + EquipmentCategoryID + "\nEquipment Status: " + EquipmentStatus;
        }
    }
}
