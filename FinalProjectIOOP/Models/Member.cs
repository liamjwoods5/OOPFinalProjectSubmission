using System.ComponentModel.DataAnnotations;

namespace FinalProjectIOOP
{
    public class Member
    {
        private int memberID;
        private string firstName;
        private string lastName;
        private string memberEmail;
        private string memberPhoneNumber;
        private string joinDate;
        private string membershipTypeID;

        [Required]
        [Range(0, 99999999999)]
        public int MemberID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string MemberEmail { get; set; }

        [StringLength(20)]
        [Phone]
        public string MemberPhoneNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string JoinDate { get; set; }

        public string MembershipTypeID { get; set; }

        public Member(int memberID, string firstName, string lastName, string memberEmail, string memberPhoneNumber, string joinDate, string membershipTypeID)
        {
            MemberID = memberID;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            MemberEmail = memberEmail ?? throw new ArgumentNullException(nameof(memberEmail));
            MemberPhoneNumber = memberPhoneNumber ?? throw new ArgumentNullException(nameof(memberPhoneNumber));
            JoinDate = joinDate ?? throw new ArgumentNullException(nameof(joinDate));
            MembershipTypeID = membershipTypeID ?? throw new ArgumentNullException(nameof(membershipTypeID));
        }

        public Member()
        {
        }


        public override string ToString()
        {
            return "Member ID: " + MemberID + "\nFirst Name: " + FirstName + "\nLast Name: " + LastName + "\nEmail: " + MemberEmail + "\nPhone Number: " + MemberPhoneNumber + "\nJoin Date: " + JoinDate + "\nMembership Type ID: " + MembershipTypeID;
        }

    }
}
