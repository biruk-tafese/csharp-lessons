class OOPdemo
{
        protected int annualFee;
        private string name = "";
        private int memberID; 
        private int memberSince;

public OOPdemo()
{
    Console.WriteLine("Parent Constructor with no parameter");
}

public OOPdemo(string pName, int pMemberID, int pMembeSince)
{
    Console.WriteLine("Parent Constructor with 3 parameter");
    name = pName;
    memberID = pMemberID;
    memberSince = pMembeSince;
}
    public override string ToString()
    {
        return "\nName: "+name+"\nMember ID: "+memberID+ "\nMemeber Since: "+memberSince+ "\nTotal Annual Fee: "+ annualFee;
    }
    
    


}