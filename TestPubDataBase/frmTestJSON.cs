using com.taishsoft.json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPubDataBase
{
    public partial class frmTestJSON : Form
    {
        public frmTestJSON()
        {
            InitializeComponent();
        }

        private void btnGetTestCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = clsJSON.GetTestCode();
        }

        private void btnTransObjJSON_Click(object sender, EventArgs e)
        {
            User u = new User(1, "EE", "123");
            lblMsg.Text = clsJSON.GetJsonFromObj2<User>(u);
            //lblResult.Text = clsJSON.DataContractJsonSerialize<User>(u);
            User objUser = clsJSON.GetObjFromJson<User>(lblMsg.Text);
            lblMsg2.Text = clsJSON.GetJsonFromObj2<User>(objUser);
            //Console.WriteLine(ToJson2<User>(u));
            //Console.ReadLine();
        }

        private void btnTransObjLstJSON_Click(object sender, EventArgs e)
        {
            User u1 = new User(1, "EE", "123");
            User u2 = new User(2, "EE2", "1223");
            List<User> arrUserObjLst = new List<User>();
            arrUserObjLst.Add(u1);
            arrUserObjLst.Add(u2);

            lblMsg.Text = clsJSON.GetJsonFromObjLst<User>(arrUserObjLst);
            List<User> arrUserObjLst2 = clsJSON.GetObjLstFromJson<User>(lblMsg.Text);
            lblMsg2.Text = clsJSON.GetJsonFromObjLst<User>(arrUserObjLst2);
        }
    }
}
