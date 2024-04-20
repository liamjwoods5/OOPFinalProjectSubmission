using Microsoft.AspNetCore.Components;

namespace FinalProjectIOOP
{
    public class EquipmentPageComponent : ComponentBase
    {

        [Inject]
        public DatabaseConnection? DatabaseConnection { get; set; }

        [Inject]
        public NavigationManager? NavigationManager { get; set; }

        [Inject]
        public EquipmentServicesDB EquipmentServiceDB { get; set; }


        protected int equipmentID { get; set; }

        //Navigate to Add Equipment Page
        public void NavigateToAddEquipment()
        {
            NavigationManager.NavigateTo("/addequipment");
        }


        //Navigate to Update Equipment Page
        public void NavigateToUpdateEquipment()
        {
            NavigationManager.NavigateTo("/updateequipment");
        }


        //Navigate to Delete Equipment Page
        public void NavigateToDeleteEquipment()
        {
            NavigationManager.NavigateTo("/deleteequipment");
        }

        //Navigate to Add Equipment Category Page
        public void NavigateToAddEquipmentCategory()
        {
            NavigationManager.NavigateTo("/newcategory");
        }

        //Navigate to Member Page
        public void NavigateToMemberPage()
        {
            NavigationManager.NavigateTo("/members");
        }

        //Navigate to Equipment Page
        public void NavigateToEquipmentPage()
        {
            NavigationManager.NavigateTo("/equipment");
        }

        public List<Equipment> equipmentList;

        //Get all equipment on initialization
        protected override async Task OnInitializedAsync()
        {
            equipmentList = await Task.Run(() => EquipmentServiceDB.GetAllEquipment());
        }


    }
}
