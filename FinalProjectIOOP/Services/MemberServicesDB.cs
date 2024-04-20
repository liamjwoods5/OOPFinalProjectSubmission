using Dapper;

namespace FinalProjectIOOP
{
    public class MemberServicesDB : DatabaseConnection
    {
        //method to add a new member
        public void AddMember(Member member)
        {
            connection.Open();

            string sql = "INSERT INTO member (memberID, firstName, lastName, memberEmail, memberPhoneNumber, JoinDate, membershipTypeID) VALUES (@ID, @firstName, @lastName, @Email, @PhoneNumber, @JoinDate, @membershipType)";

            connection.Execute(sql, new { ID = member.MemberID, firstName = member.FirstName, lastName = member.LastName, Email = member.MemberEmail, PhoneNumber = member.MemberPhoneNumber, JoinDate = member.JoinDate, membershipType = member.MembershipTypeID });

            connection.Close();
        }


        //method to update a member
        public void UpdateMember(Member member)
        {
            connection.Open();
            string sql = "UPDATE member SET firstName = @firstName, lastName = @lastName, memberEmail = @Email, memberPhoneNumber = @PhoneNumber, JoinDate = @JoinDate, membershipTypeID = @membershipType WHERE memberID = @ID";
            connection.Execute(sql, new { ID = member.MemberID, firstName = member.FirstName, lastName = member.LastName, Email = member.MemberEmail, PhoneNumber = member.MemberPhoneNumber, JoinDate = member.JoinDate, membershipType = member.MembershipTypeID });
            connection.Close();
        }

        //method to delete a member
        public void DeleteMember(int id)
        {
            connection.Open();
            string sql = "DELETE FROM member WHERE memberID = @ID";
            connection.Execute(sql, new { ID = id });
            connection.Close();
        }

        //method to get all members
        public List<Member> GetAllMembers()
        {
            connection.Open();
            string sql = "SELECT * FROM member";
            var members = connection.Query<Member>(sql).ToList();
            connection.Close();
            return members;
        }

        //method to get a member by ID
        public Member GetMemberByID(int id)
        {
            connection.Open();
            string sql = "SELECT * FROM member WHERE memberID = @ID";
            var member = connection.QueryFirstOrDefault<Member>(sql, new { ID = id });
            connection.Close();
            return member;
        }

    }
}
