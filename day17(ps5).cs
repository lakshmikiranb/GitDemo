using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegatesDemo
{
    //delegate also called event handler
    public class Staff
    {
        //001_1: Member variables
        private int StaffId;
        private string StaffName;
        
        //001_2: Constructor for Staff
        public Staff(int id, string name)
        {
            StaffId = id;
            StaffName = name;
            
        }
        //001_3: String representation of staff
        public override string ToString()
        {
            return string.Format("{0} - {1}",
                StaffName, StaffId);
        }
    }
    //002: Oraganization has Staffs for its Operation
    public class Organization
    {
        //002_1: Delegate that Calculates 
        //and return the Total
        public delegate int
            GetTotalDelegate(Staff[] staffs);
        //002_2: Other member variables
        private Staff[] Staffs;
        private string Org_Name;
        //002_3: Constructor for Organization
        public Organization(string Org_name,
            params Staff[] staffs)
        {
            //002_3.1: Initialize the Staffs Array
            Staffs = new Staff[staffs.Length];
            for (int i = 0; i<staffs.Length; i++)
                Staffs[i] = staffs[i];
            //002_3.2: Initialize other 
            //member variables
            Org_Name = Org_name;
        }
        //002_4: Function that delegates the 
        //work of Calculating Total
        public int Calculate_Total(
            GetTotalDelegate delegateRef)
        {
            return delegateRef(Staffs);
        }
        //002_5: Diaplay all Staffs
        public void DisplayStaffs()
        {
            foreach (Staff staff in Staffs)
                Console.WriteLine(staff);
        }
    }
 

    
    
}