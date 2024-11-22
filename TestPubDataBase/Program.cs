using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestPubDataBase
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            SpecData.clsSpecSQL.strAppType = "WINAPP";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmTestBiDimDistribute());



            //Application.Run(new frmTestExcel());
            Application.Run(new MdiForm());
        }
    }
}
