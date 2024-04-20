namespace FinalProjectIOOP
{
    public abstract class MemberServices
    {
        //method to add a new member
        public abstract void AddMember(Member member);

        //method to update a member
        public abstract void UpdateMember(Member member);

        //method to delete a member
        public abstract void DeleteMember(int memberID);

        //method to get all members
        public abstract List<Member> GetAllMembers();

        //method to get a member by ID
        public abstract Member GetMemberByID(int id);
    }

}
