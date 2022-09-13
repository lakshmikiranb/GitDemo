using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAssembly
{
    public class Class1
    {
        protected void btnchange_Click(object sender, EventArgs e)
        {
            int changed;
            string loginemailid = txtloginemailid.Text.Trim();
            string oldpass = txtoldpassword.Text.Trim();
            string newpass = txtnewpassword.Text.Trim();


            if (loginemailid != null && oldpass != null)
            {
                changed = mydac.changeuserpassword(loginemailid, oldpass, newpass);
                if (changed == 1)
                {
                    lblmsg.Text = "Your new Password Updated";

                }
            }
            else
            {
                lblmsg.Text = "Updation Failed,Ensure Your Login Information Is Correct";
            }
        }
    }
}
