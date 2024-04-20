namespace FinalProjectIOOP
{
    public class membershipType
    {
        private int membershipTypeID;
        private string membershipName;
        private string membershipDescription;
        private double membershipPrice;

        public int MembershipTypeID { get; set; }
        public string MembershipName { get; set; }
        public string MembershipDescription { get; set; }
        public double MembershipPrice { get; set; }

        public membershipType(int membershipTypeID, string membershipName, string membershipDescription, double membershipPrice)
        {
            MembershipTypeID = membershipTypeID;
            MembershipName = membershipName;
            MembershipDescription = membershipDescription;
            MembershipPrice = membershipPrice;
        }

        public override string ToString()
        {
            return "Membership Type ID: " + MembershipTypeID + "\nMembership Name: " + MembershipName + "\nMembership Description: " + MembershipDescription + "\nMembership Price: " + MembershipPrice;
        }
    }
}
