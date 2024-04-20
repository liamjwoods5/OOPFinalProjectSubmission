
/* Unmerged change from project 'FinalProjectIOOP (net8.0-android)'
Before:
using System;
After:
using Microsoft.AspNetCore.Components;
using System;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-ios)'
Before:
using System;
After:
using Microsoft.AspNetCore.Components;
using System;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-maccatalyst)'
Before:
using System;
After:
using Microsoft.AspNetCore.Components;
using System;
*/
using
/* Unmerged change from project 'FinalProjectIOOP (net8.0-android)'
Before:
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-ios)'
Before:
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-maccatalyst)'
Before:
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
After:
using System.Threading.Tasks;
*/
Microsoft.AspNetCore.Components;

namespace FinalProjectIOOP
{
    public class MembersPageComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public MemberServicesDB MemberServiceDB { get; set; }

        public Member newMember = new Member();

        public List<Member> members;


        //method to get all members on initialization
        protected override async Task OnInitializedAsync()
        {
            members = await Task.Run(() => MemberServiceDB.GetAllMembers());
        }


        //method to navigate to the add member page
        public void NavigateToAddMember()
        {
            NavigationManager.NavigateTo("/addmember");
        }


        //method to navigate to the update member page
        public void NavigateToUpdateMember()
        {
            NavigationManager.NavigateTo("/updatemember");
        }


        //method to navigate to the delete member page
        public void NavigateToDeleteMember()
        {
            NavigationManager.NavigateTo("/deletemember");
        }
    }
}
