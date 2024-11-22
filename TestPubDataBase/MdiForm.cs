using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestPubDataBase
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class MdiForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.MainMenu mainMenu1;
        private MenuItem menuItem8;
        private MenuItem menuItem10;
        private MenuItem menuItem2;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private MenuItem menuItem7;
        private MenuItem menuItem1;
        private MenuItem menuItem3;
        private MenuItem menuItem9;
        private MenuItem menuItem11;
        private MenuItem menuItem12;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem16;
        private MenuItem menuItem17;
        private MenuItem menuItem18;
        private IContainer components;

		public MdiForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem2,
            this.menuItem16,
            this.menuItem18});
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10});
            this.menuItem8.Text = "测试FTP";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Text = "测试FTP";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem1,
            this.menuItem3,
            this.menuItem9,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem15});
            this.menuItem2.Text = "系统测试";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "日期类测试1";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "周时间片冲突检查";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "表数据测试";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "检查日期有效性";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click_1);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "测试Access";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 5;
            this.menuItem3.Text = "测试JSON";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 6;
            this.menuItem9.Text = "编码转换";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 7;
            this.menuItem11.Text = "测试Sql语句";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 8;
            this.menuItem12.Text = "测试Sql注入";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 9;
            this.menuItem13.Text = "综合测试";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 10;
            this.menuItem14.Text = "文件类测试";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 11;
            this.menuItem15.Text = "字符串测试";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem17});
            this.menuItem16.Text = "教育数据计算";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 0;
            this.menuItem17.Text = "教育数据计算";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 3;
            this.menuItem18.Text = "测试实体层";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(896, 321);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "MdiForm";
            this.Text = "公共数据底层、公共函数测试工程";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
//		[STAThread]
//		static void Main(string[] args) 
//		{
//			Application.Run(new MdiForm());
//
////			if (args.Length == 0) 
////			{
////				return ; 
////			}
////			if (args[0]=="教学班集合维护")
////			{
////				Application.Run(new frmxkCollectOfClass_QUDI());
////			}
////			if (args[0]=="教学班维护")
////			{
////				Application.Run(new frmXkEduClassInfo_QUDI_LV());
////			}
////			if(args[0]=="教学班集合关系维护")
////			{
////				Application.Run(new Edu_ClassCollect());
////			}
////			if(args[0]=="筛选学生")
////			{
////				Application.Run(new frmXkGradeCrsInfo_QUDI_LV());
////			}
////			if(args[0]=="人员移动")
////			{
////				Application.Run(new frmxkPersonMove_QUDI_LV());
////			}
////			if(args[0]=="选课情况查询")
////			{
////				Application.Run(new frmxkCircsOfStuSelectClass_QUDI());
////			}
////			if(args[0]=="选课批次设定")
////			{
////				Application.Run(new frmxkCircsOfStuSelectClass_QUDI_LV());
////			}
////			if(args[0]=="选课门数控制")
////			{
////				Application.Run(new frmxkClsNumMarkCtrl_QUDI_LV());	
////			}
//
//			
//		}
//

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//获取当前用户的权限列表
			ArrayList arrMenuObjList = new ArrayList();
         
//			foreach(Control ctl in this.Controls)
//			{
//				if (ctl.Name.Substring(0,2) == "mi" )//是菜单 )
//				{
//					if (同时属于当前用户的权限列表)
//					{
//						ctl.Visible = true;
//					}
//				}
//			}
		}

		private bool IsInclude(ArrayList arrPrivacy, string strPrivacy)
		{
			foreach(string str in arrPrivacy)
			{
				if (str ==  strPrivacy)
				{
					return true;
				}
			}
			return false;
		}

        private void menuItem7_Click(object sender, EventArgs e)
        {
            frmTestFtpUpLoad frm = new frmTestFtpUpLoad();
            frm.Show();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            //clsSysPara.strAppPath = "D:\\EduAdmin\\Bin";// clsApplicatoin.AppPath();
            //frmAutoUpdate frm = new frmAutoUpdate();
            //frm.Show();
            frmTestFtpUpLoad frm = new frmTestFtpUpLoad();
            frm.Show();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            frmTestDateTime frm = new frmTestDateTime();
            frm.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            frmTestTimeConflict frm = new frmTestTimeConflict();
            frm.Show();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            frmTestTableData frm = new frmTestTableData();
            frm.Show();
        }

        private void menuItem7_Click_1(object sender, EventArgs e)
        {
            frmTestDateRange frm = new frmTestDateRange();
            frm.Show();
        }

        private void menuItem84_Click(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            frmTestAccess frm = new frmTestAccess();
            frm.Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            frmTestJSON frm = new frmTestJSON();
            frm.Show();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            frmEncodingConvert frm = new frmEncodingConvert();
            frm.Show();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmTestSqlStatement frm = new frmTestSqlStatement();
            frm.Show();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            frmTestSqlIn frm = new frmTestSqlIn();
            frm.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            frmTestFile frm = new frmTestFile();
            frm.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            frmString frm = new frmString();
            frm.Show();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            frmMath_Edu frm = new frmMath_Edu();
            frm.Show();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            frmTestEntity frm = new frmTestEntity();
            frm.Show();
        }

     
    }
}
