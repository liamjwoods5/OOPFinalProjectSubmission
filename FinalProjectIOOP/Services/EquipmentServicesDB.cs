using Dapper;

namespace FinalProjectIOOP
{
    public class EquipmentServicesDB : DatabaseConnection
    {
        //method to get all equipment
        public List<Equipment> GetAllEquipment()
        {
            try
            {
                connection.Open();

                string sql = "SELECT * FROM equipment";

                var equipment = connection.Query<Equipment>(sql);

                connection.Close();

                return equipment.ToList();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
                return new List<Equipment>();
            }
        }

        //method to add a new equipment
        public void AddEquipment(Equipment equipment)
        {
            try
            {
                connection.Open();

                string sql = "INSERT INTO Equipment (equipmentID, equipmentName, equipmentDescription, equipmentCategoryID, equipmentStatus) VALUES (@EquipmentID, @EquipmentName, @EquipmentDescription, @EquipmentCategoryID, @EquipmentStatus)";

                connection.Execute(sql, equipment);

                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
            }
        }

        //method to update an equipment
        public void UpdateEquipment(Equipment equipment)
        {
            try
            {
                connection.Open();

                string sql = "UPDATE Equipment SET equipmentName = @EquipmentName, equipmentDescription = @EquipmentDescription, equipmentCategoryID = @EquipmentCategoryID, equipmentStatus = @EquipmentStatus WHERE equipmentID = @EquipmentID";

                connection.Execute(sql, new { EquipmentID = equipment.EquipmentID, EquipmentName = equipment.EquipmentName, EquipmentDescription = equipment.EquipmentDescription, EquipmentCategoryID = equipment.EquipmentCategoryID, EquipmentStatus = equipment.EquipmentStatus });

                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
            }
        }

        //method to delete an equipment
        public void DeleteEquipment(int id)
        {
            try
            {
                connection.Open();

                string sql = "DELETE FROM equipment WHERE equipmentID = @Id";

                connection.Execute(sql, new { Id = id });

                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
            }
        }


        //method to get equipment by ID
        public Equipment GetEquipmentByID(int id)
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM Equipment WHERE equipmentID = @ID";
                var equipment = connection.QueryFirstOrDefault<Equipment>(sql, new { ID = id });
                connection.Close();
                return equipment;
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //method to add a new equipment category
        public void AddEquipmentCategory(EquipmentCategory equipmentCategory)
        {
            try
            {
                connection.Open();

                string sql = "INSERT INTO EquipmentCategory (equipmentCategoryID, equipmentName) VALUES (@EquipmentCategoryID, @CategoryName)";

                connection.Execute(sql, equipmentCategory);

                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
            }
        }

    }
}
