using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using AGC.Entity;
using AGC;
using Agc_CsWin.Main;
using Agc_CsWin.frm.Test;


using Agc_CsWin.frm.SystemSet;
using AGC4WApi;

//using ExcelImport;
//using EduAdmin;

namespace AGC_CSWin
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class MdiForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuStrip DataSynMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuItem84;
        private System.Windows.Forms.ToolStripMenuItem miImportExcelFile;
        private System.Windows.Forms.ToolStripMenuItem menuItem2;
        private ToolStripMenuItem menuItem10;
        private ToolStripMenuItem miProject_QUDI;
        private ToolStripMenuItem miSysPara;
        private ToolStripMenuItem menuItem13;
        private ToolStripMenuItem menuItem14;
        private ToolStripMenuItem menuItem15;
        private ToolStripMenuItem miImportSqlTable;
        private ToolStripMenuItem miUserRightManage;
        private ToolStripMenuItem menuItem21;
        private ToolStripMenuItem menuItem22;
        private ToolStripMenuItem menuItem23;
        private ToolStripMenuItem menuItem24;
        private ToolStripMenuItem menuItem25;
        private ToolStripMenuItem menuItem26;
        private ToolStripMenuItem menuItem27;
        private ToolStripMenuItem menuItem30;
        private ToolStripMenuItem menuItem31;
        private ToolStripMenuItem menuItem32;
        private ToolStripMenuItem menuItem11;
        private ToolStripMenuItem ��Ŀ���ݿ�ά��ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ת����ʽά��ToolStripMenuItem;
        private ToolStripMenuItem ���ɴ洢����ToolStripMenuItem;
        private ToolStripMenuItem ����ͬ������V2ToolStripMenuItem;
        private ToolStripMenuItem ���뷽ʽToolStripMenuItem;
        private ToolStripMenuItem ����ϵͳ����ToolStripMenuItem;
        private ToolStripMenuItem ���Ե���DllToolStripMenuItem;
        private ToolStripMenuItem ע��ToolStripMenuItem;
        private ToolStripMenuItem ����·������ToolStripMenuItem;
        private ToolStripMenuItem ����ToolStripMenuItem;
        private ToolStripMenuItem �������鿴ToolStripMenuItem;
        private ToolStripMenuItem ����ת������ToolStripMenuItem;
        private ToolStripMenuItem ���Լ�ʱ����ToolStripMenuItem;
        private ToolStripMenuItem �������ɴ���V7ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ���ɽ������NewToolStripMenuItem;
        private ToolStripMenuItem ������·������ToolStripMenuItem;
        private ToolStripMenuItem webService����ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem ����WebSrv����ش���ToolStripMenuItem;
        private ToolStripMenuItem ���Զ�������ϢToolStripMenuItem;
        private ToolStripMenuItem �������ToolStripMenuItem;
        private ToolStripMenuItem �������ToolStripMenuItem1;
        private ToolStripMenuItem ��Ŀ�ļ�����ToolStripMenuItem;
        private ToolStripMenuItem ������·�����ñ���ToolStripMenuItem;
        private ToolStripMenuItem ��Ŀ�ļ�����GvToolStripMenuItem;
        //private IContainer components;

        public MdiForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				//if (components != null) 
				//{
				//	components.Dispose();
				//}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            this.DataSynMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItem84 = new System.Windows.Forms.ToolStripMenuItem();
            this.miImportExcelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miImportSqlTable = new System.Windows.Forms.ToolStripMenuItem();
            this.���ɴ洢����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.����ͬ������V2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���Ե���DllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.miProject_QUDI = new System.Windows.Forms.ToolStripMenuItem();
            this.��Ŀ���ݿ�ά��ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.�������鿴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��Ŀ�ļ�����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.��Ŀ�ļ�����GvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.���ɽ������NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.����WebSrv����ش���ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�������ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.����ϵͳ����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.����·������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������·������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webService����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserRightManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miSysPara = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.ת����ʽά��ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���뷽ʽToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.����ת������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���Լ�ʱ����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�������ɴ���V7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.���Զ�������ϢToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ע��ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������·�����ñ���ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSynMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataSynMenuStrip
            // 
            this.DataSynMenuStrip.Font = new System.Drawing.Font("����", 10.5F);
            this.DataSynMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem84,
            this.menuItem10,
            this.menuItem15,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.�������ToolStripMenuItem,
            this.menuItem11,
            this.miUserRightManage,
            this.miSysPara,
            this.menuItem2,
            this.ע��ToolStripMenuItem});
            this.DataSynMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DataSynMenuStrip.Name = "DataSynMenuStrip";
            this.DataSynMenuStrip.Size = new System.Drawing.Size(896, 24);
            this.DataSynMenuStrip.TabIndex = 0;
            this.DataSynMenuStrip.Text = "menuStrip1";
            // 
            // menuItem84
            // 
            this.menuItem84.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miImportExcelFile,
            this.miImportSqlTable,
            this.���ɴ洢����ToolStripMenuItem,
            this.����ͬ������V2ToolStripMenuItem,
            this.���Ե���DllToolStripMenuItem});
            this.menuItem84.Name = "menuItem84";
            this.menuItem84.Size = new System.Drawing.Size(47, 20);
            this.menuItem84.Text = "����";
            // 
            // miImportExcelFile
            // 
            this.miImportExcelFile.Name = "miImportExcelFile";
            this.miImportExcelFile.Size = new System.Drawing.Size(172, 22);
            this.miImportExcelFile.Text = "Excel�������";
            this.miImportExcelFile.Click += new System.EventHandler(this.menuItem85_Click);
            // 
            // miImportSqlTable
            // 
            this.miImportSqlTable.Name = "miImportSqlTable";
            this.miImportSqlTable.Size = new System.Drawing.Size(172, 22);
            this.miImportSqlTable.Text = "����ͬ������";
            this.miImportSqlTable.Visible = false;
            this.miImportSqlTable.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // ���ɴ洢����ToolStripMenuItem
            // 
            this.���ɴ洢����ToolStripMenuItem.Name = "���ɴ洢����ToolStripMenuItem";
            this.���ɴ洢����ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.���ɴ洢����ToolStripMenuItem.Text = "���ɴ洢����";
            this.���ɴ洢����ToolStripMenuItem.Click += new System.EventHandler(this.���ɴ洢����ToolStripMenuItem_Click);
            // 
            // ����ͬ������V2ToolStripMenuItem
            // 
            this.����ͬ������V2ToolStripMenuItem.Name = "����ͬ������V2ToolStripMenuItem";
            this.����ͬ������V2ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.����ͬ������V2ToolStripMenuItem.Text = "����ͬ������V2";
            this.����ͬ������V2ToolStripMenuItem.Click += new System.EventHandler(this.����ͬ������V2ToolStripMenuItem_Click);
            // 
            // ���Ե���DllToolStripMenuItem
            // 
            this.���Ե���DllToolStripMenuItem.Name = "���Ե���DllToolStripMenuItem";
            this.���Ե���DllToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.���Ե���DllToolStripMenuItem.Text = "���Ե���_Dll";
            this.���Ե���DllToolStripMenuItem.Click += new System.EventHandler(this.���Ե���DllToolStripMenuItem_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProject_QUDI,
            this.��Ŀ���ݿ�ά��ToolStripMenuItem});
            this.menuItem10.Name = "menuItem10";
            this.menuItem10.Size = new System.Drawing.Size(75, 20);
            this.menuItem10.Text = "��Ŀά��";
            // 
            // miProject_QUDI
            // 
            this.miProject_QUDI.Name = "miProject_QUDI";
            this.miProject_QUDI.Size = new System.Drawing.Size(172, 22);
            this.miProject_QUDI.Text = "��Ŀά��";
            this.miProject_QUDI.Click += new System.EventHandler(this.menuItem11_Click_1);
            // 
            // ��Ŀ���ݿ�ά��ToolStripMenuItem
            // 
            this.��Ŀ���ݿ�ά��ToolStripMenuItem.Name = "��Ŀ���ݿ�ά��ToolStripMenuItem";
            this.��Ŀ���ݿ�ά��ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.��Ŀ���ݿ�ά��ToolStripMenuItem.Text = "��Ŀ���ݿ�ά��";
            this.��Ŀ���ݿ�ά��ToolStripMenuItem.Click += new System.EventHandler(this.��Ŀ���ݿ�ά��ToolStripMenuItem_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.�������鿴ToolStripMenuItem,
            this.��Ŀ�ļ�����ToolStripMenuItem,
            this.��Ŀ�ļ�����GvToolStripMenuItem});
            this.menuItem15.Name = "menuItem15";
            this.menuItem15.Size = new System.Drawing.Size(89, 20);
            this.menuItem15.Text = "��Ŀ�����";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem2.Text = "������Ŀ�����";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // �������鿴ToolStripMenuItem
            // 
            this.�������鿴ToolStripMenuItem.Name = "�������鿴ToolStripMenuItem";
            this.�������鿴ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.�������鿴ToolStripMenuItem.Text = "�������鿴";
            this.�������鿴ToolStripMenuItem.Click += new System.EventHandler(this.�������鿴ToolStripMenuItem_Click);
            // 
            // ��Ŀ�ļ�����ToolStripMenuItem
            // 
            this.��Ŀ�ļ�����ToolStripMenuItem.Name = "��Ŀ�ļ�����ToolStripMenuItem";
            this.��Ŀ�ļ�����ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.��Ŀ�ļ�����ToolStripMenuItem.Text = "��Ŀ�ļ�����Lv";
            this.��Ŀ�ļ�����ToolStripMenuItem.Visible = false;
            this.��Ŀ�ļ�����ToolStripMenuItem.Click += new System.EventHandler(this.��Ŀ�ļ�����ToolStripMenuItem_Click);
            // 
            // ��Ŀ�ļ�����GvToolStripMenuItem
            // 
            this.��Ŀ�ļ�����GvToolStripMenuItem.Name = "��Ŀ�ļ�����GvToolStripMenuItem";
            this.��Ŀ�ļ�����GvToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.��Ŀ�ļ�����GvToolStripMenuItem.Text = "��Ŀ�ļ�����Gv";
            this.��Ŀ�ļ�����GvToolStripMenuItem.Click += new System.EventHandler(this.��Ŀ�ļ�����GvToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.���ɽ������NewToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem1.Text = "�������";
            // 
            // ���ɽ������NewToolStripMenuItem
            // 
            this.���ɽ������NewToolStripMenuItem.Name = "���ɽ������NewToolStripMenuItem";
            this.���ɽ������NewToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.���ɽ������NewToolStripMenuItem.Text = "���ɽ������";
            this.���ɽ������NewToolStripMenuItem.Click += new System.EventHandler(this.���ɽ������NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.����WebSrv����ش���ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 20);
            this.toolStripMenuItem3.Text = "WebSrv����Ϣ";
            // 
            // ����WebSrv����ش���ToolStripMenuItem
            // 
            this.����WebSrv����ش���ToolStripMenuItem.Name = "����WebSrv����ش���ToolStripMenuItem";
            this.����WebSrv����ش���ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.����WebSrv����ش���ToolStripMenuItem.Text = "����WebSrv����ش���";
            this.����WebSrv����ش���ToolStripMenuItem.Click += new System.EventHandler(this.����WebSrv����ش���ToolStripMenuItem_Click);
            // 
            // �������ToolStripMenuItem
            // 
            this.�������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.�������ToolStripMenuItem1});
            this.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem";
            this.�������ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.�������ToolStripMenuItem.Text = "�������";
            // 
            // �������ToolStripMenuItem1
            // 
            this.�������ToolStripMenuItem1.Name = "�������ToolStripMenuItem1";
            this.�������ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.�������ToolStripMenuItem1.Text = "�������";
            this.�������ToolStripMenuItem1.Click += new System.EventHandler(this.�������ToolStripMenuItem1_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem27,
            this.����ϵͳ����ToolStripMenuItem,
            this.����·������ToolStripMenuItem,
            this.������·������ToolStripMenuItem,
            this.webService����ToolStripMenuItem,
            this.������·�����ñ���ToolStripMenuItem});
            this.menuItem11.Name = "menuItem11";
            this.menuItem11.Size = new System.Drawing.Size(75, 20);
            this.menuItem11.Text = "ϵͳ����";
            // 
            // menuItem27
            // 
            this.menuItem27.Name = "menuItem27";
            this.menuItem27.Size = new System.Drawing.Size(214, 22);
            this.menuItem27.Text = "�û���Ŀѡ��";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // ����ϵͳ����ToolStripMenuItem
            // 
            this.����ϵͳ����ToolStripMenuItem.Name = "����ϵͳ����ToolStripMenuItem";
            this.����ϵͳ����ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.����ϵͳ����ToolStripMenuItem.Text = "����ϵͳ����";
            this.����ϵͳ����ToolStripMenuItem.Click += new System.EventHandler(this.����ϵͳ����ToolStripMenuItem_Click);
            // 
            // ����·������ToolStripMenuItem
            // 
            this.����·������ToolStripMenuItem.Name = "����·������ToolStripMenuItem";
            this.����·������ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.����·������ToolStripMenuItem.Text = "����·������";
            this.����·������ToolStripMenuItem.Click += new System.EventHandler(this.����·������ToolStripMenuItem_Click);
            // 
            // ������·������ToolStripMenuItem
            // 
            this.������·������ToolStripMenuItem.Name = "������·������ToolStripMenuItem";
            this.������·������ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.������·������ToolStripMenuItem.Text = "������·������";
            this.������·������ToolStripMenuItem.Click += new System.EventHandler(this.������·������ToolStripMenuItem_Click);
            // 
            // webService����ToolStripMenuItem
            // 
            this.webService����ToolStripMenuItem.Name = "webService����ToolStripMenuItem";
            this.webService����ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.webService����ToolStripMenuItem.Text = "WebService����";
            this.webService����ToolStripMenuItem.Click += new System.EventHandler(this.webService����ToolStripMenuItem_Click);
            // 
            // miUserRightManage
            // 
            this.miUserRightManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem21,
            this.menuItem22,
            this.menuItem23,
            this.menuItem24,
            this.toolStripSeparator1,
            this.menuItem25,
            this.menuItem26,
            this.toolStripSeparator2});
            this.miUserRightManage.Name = "miUserRightManage";
            this.miUserRightManage.Size = new System.Drawing.Size(103, 20);
            this.miUserRightManage.Text = "�û�Ȩ�޹���";
            // 
            // menuItem21
            // 
            this.menuItem21.Name = "menuItem21";
            this.menuItem21.Size = new System.Drawing.Size(186, 22);
            this.menuItem21.Text = "������Ϣά��";
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Name = "menuItem22";
            this.menuItem22.Size = new System.Drawing.Size(186, 22);
            this.menuItem22.Text = "�û�״̬ά��";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Name = "menuItem23";
            this.menuItem23.Size = new System.Drawing.Size(186, 22);
            this.menuItem23.Text = "�û���ɫά��";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Name = "menuItem24";
            this.menuItem24.Size = new System.Drawing.Size(186, 22);
            this.menuItem24.Text = "�û���Ϣά��";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // menuItem25
            // 
            this.menuItem25.Name = "menuItem25";
            this.menuItem25.Size = new System.Drawing.Size(186, 22);
            this.menuItem25.Text = "�û���ɫ��ϵά��";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Name = "menuItem26";
            this.menuItem26.Size = new System.Drawing.Size(186, 22);
            this.menuItem26.Text = "�û���Ŀ��ϵά��";
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // miSysPara
            // 
            this.miSysPara.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem13,
            this.menuItem14,
            this.menuItem30,
            this.menuItem31,
            this.menuItem32,
            this.ת����ʽά��ToolStripMenuItem,
            this.���뷽ʽToolStripMenuItem});
            this.miSysPara.Name = "miSysPara";
            this.miSysPara.Size = new System.Drawing.Size(75, 20);
            this.miSysPara.Text = "ϵͳ����";
            // 
            // menuItem13
            // 
            this.menuItem13.Name = "menuItem13";
            this.menuItem13.Size = new System.Drawing.Size(180, 22);
            this.menuItem13.Text = "���ݿ�����";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Name = "menuItem14";
            this.menuItem14.Size = new System.Drawing.Size(180, 22);
            this.menuItem14.Text = "Sql����Դ����";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click_1);
            // 
            // menuItem30
            // 
            this.menuItem30.Name = "menuItem30";
            this.menuItem30.Size = new System.Drawing.Size(180, 22);
            this.menuItem30.Text = "��������";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Name = "menuItem31";
            this.menuItem31.Size = new System.Drawing.Size(180, 22);
            this.menuItem31.Text = "��¼������ʽ";
            this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click_1);
            // 
            // menuItem32
            // 
            this.menuItem32.Name = "menuItem32";
            this.menuItem32.Size = new System.Drawing.Size(180, 22);
            this.menuItem32.Text = "����ͬ����ʽ";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click_1);
            // 
            // ת����ʽά��ToolStripMenuItem
            // 
            this.ת����ʽά��ToolStripMenuItem.Name = "ת����ʽά��ToolStripMenuItem";
            this.ת����ʽά��ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ת����ʽά��ToolStripMenuItem.Text = "ת����ʽά��";
            this.ת����ʽά��ToolStripMenuItem.Click += new System.EventHandler(this.ת����ʽά��ToolStripMenuItem_Click);
            // 
            // ���뷽ʽToolStripMenuItem
            // 
            this.���뷽ʽToolStripMenuItem.Name = "���뷽ʽToolStripMenuItem";
            this.���뷽ʽToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.���뷽ʽToolStripMenuItem.Text = "���뷽ʽ";
            this.���뷽ʽToolStripMenuItem.Click += new System.EventHandler(this.���뷽ʽToolStripMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.����ToolStripMenuItem,
            this.����ת������ToolStripMenuItem,
            this.���Լ�ʱ����ToolStripMenuItem,
            this.�������ɴ���V7ToolStripMenuItem,
            this.���Զ�������ϢToolStripMenuItem});
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(47, 20);
            this.menuItem2.Text = "����";
            // 
            // ����ToolStripMenuItem
            // 
            this.����ToolStripMenuItem.Name = "����ToolStripMenuItem";
            this.����ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.����ToolStripMenuItem.Text = "����";
            this.����ToolStripMenuItem.Click += new System.EventHandler(this.����ToolStripMenuItem_Click);
            // 
            // ����ת������ToolStripMenuItem
            // 
            this.����ת������ToolStripMenuItem.Name = "����ת������ToolStripMenuItem";
            this.����ת������ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.����ת������ToolStripMenuItem.Text = "����ת������";
            this.����ת������ToolStripMenuItem.Click += new System.EventHandler(this.����ת������ToolStripMenuItem_Click);
            // 
            // ���Լ�ʱ����ToolStripMenuItem
            // 
            this.���Լ�ʱ����ToolStripMenuItem.Name = "���Լ�ʱ����ToolStripMenuItem";
            this.���Լ�ʱ����ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.���Լ�ʱ����ToolStripMenuItem.Text = "���Լ�ʱ����";
            this.���Լ�ʱ����ToolStripMenuItem.Click += new System.EventHandler(this.���Լ�ʱ����ToolStripMenuItem_Click);
            // 
            // �������ɴ���V7ToolStripMenuItem
            // 
            this.�������ɴ���V7ToolStripMenuItem.Name = "�������ɴ���V7ToolStripMenuItem";
            this.�������ɴ���V7ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.�������ɴ���V7ToolStripMenuItem.Text = "�������ɴ���V7";
            this.�������ɴ���V7ToolStripMenuItem.Click += new System.EventHandler(this.�������ɴ���V7ToolStripMenuItem_Click);
            // 
            // ���Զ�������ϢToolStripMenuItem
            // 
            this.���Զ�������ϢToolStripMenuItem.Name = "���Զ�������ϢToolStripMenuItem";
            this.���Զ�������ϢToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.���Զ�������ϢToolStripMenuItem.Text = "���Զ�������Ϣ";
            this.���Զ�������ϢToolStripMenuItem.Click += new System.EventHandler(this.���Զ�������ϢToolStripMenuItem_Click);
            // 
            // ע��ToolStripMenuItem
            // 
            this.ע��ToolStripMenuItem.Name = "ע��ToolStripMenuItem";
            this.ע��ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ע��ToolStripMenuItem.Text = "ע��";
            this.ע��ToolStripMenuItem.Click += new System.EventHandler(this.ע��ToolStripMenuItem_Click);
            // 
            // ������·�����ñ���ToolStripMenuItem
            // 
            this.������·�����ñ���ToolStripMenuItem.Name = "������·�����ñ���ToolStripMenuItem";
            this.������·�����ñ���ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.������·�����ñ���ToolStripMenuItem.Text = "������·������(����)";
            this.������·�����ñ���ToolStripMenuItem.Click += new System.EventHandler(this.������·�����ñ���ToolStripMenuItem_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 421);
            this.Controls.Add(this.DataSynMenuStrip);
            this.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.DataSynMenuStrip;
            this.Name = "MdiForm";
            this.Text = "��������ϵͳ(WebApi)V20180524";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DataSynMenuStrip.ResumeLayout(false);
            this.DataSynMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion



		private void Form1_Load(object sender, System.EventArgs e)
		{
            //clsSysParaEN.strUserId = "pyf";
            if (clsPubVar.bolIsDispMenu == false)
            {
                clsPubVar.objMainForm.DispMenu();
            }
            //clsProjectsEN objProjectEN = clsProjectsWApi.GetObjByPrjId(clsPubVar.CurrSelPrjId);
            SetTitle();


        }

        public void SetTitle()
        {
            if (string.IsNullOrEmpty(clsPubVar.CurrPrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                this.Text = string.Format("�Զ����ɴ���20241110--���̣�{0}({1}); ���ݿ⣺{2}({3}); ���ɴ���WebApi:{4} ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    objPrjDataBaseEN.PrjDataBaseName,
                    objPrjDataBaseEN.PrjDataBaseId,
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }
            else
            {
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                this.Text = string.Format("�Զ����ɴ���20241110--���̣�{0}({1}); ���ݿ⣺{2}({3}); ���ɴ���WebApi:{4} ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    "�����ݿ�",
                    "�����ݿ�Id",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }

        }

        private void menuItem6_Click(object sender, System.EventArgs e)
		{
            //frmSqlImport frm1 = new frmSqlImport();
            //frm1.Show();			
		}
		//�ɼ�����
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
            //frmImportExcelWithTrans frm1 = new frmImportExcelWithTrans();
            //frm1.Show();	
		}

		private void menuItem85_Click(object sender, System.EventArgs e)
		{
            //frmDataImport_Excel frm1=new frmDataImport_Excel();
            //frm1.Show();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
            //frmxlsDataImportTab_QD_LV frm1=new frmxlsDataImportTab_QD_LV();
            //frm1.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
            //frmxlsPrjField_QD_LV frm1=new frmxlsPrjField_QD_LV();
            //frm1.Show();
		}

		private void menuItem5_Click_1(object sender, System.EventArgs e)
		{
            //frmxlsFieldTabRela_QD_LV frm1=new frmxlsFieldTabRela_QD_LV();
            //frm1.Show();
		}


        private void menuItem9_Click(object sender, EventArgs e)
        {
            //frmSqlImport2 frm1 = new frmSqlImport2();
            //frm1.Show();	
        }

        private void menuItem11_Click_1(object sender, EventArgs e)
        {
            //frmProjects_QD_LV frm = new frmProjects_QD_LV();
            //frm.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            //frmDataBaseType_QD_LV frm = new frmDataBaseType_QD_LV();
            //frm.Show();
        }

        private void menuItem14_Click_1(object sender, EventArgs e)
        {
            //frmSQLDSType_QD_LV frm = new frmSQLDSType_QD_LV();
            //frm.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
           
        }

        //private void menuItem16_Click(object sender, EventArgs e)
        //{
        //    frmPrjTab_QD_LV frm = new frmPrjTab_QD_LV();
        //    frm.Show();
        //}

        private void menuItem17_Click(object sender, EventArgs e)
        {
            //frmPrjField_QD_LV frm = new frmPrjField_QD_LV();
            //frm.Show();
        }

        private void menuItem18_Click_1(object sender, EventArgs e)
        {
            //frmTabFieldRela_QD_LV frm = new frmTabFieldRela_QD_LV();
            //frm.Show();
        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.CurrSelPrjId) == true)
            {
                MessageBox.Show("��û��ͬ����Ŀ����ѡ��һ��ͬ����Ŀ��");
                return;
            }
            //frmDataImport frm = new frmDataImport();
            //frm.Show();
        }

        private void menuItem21_Click(object sender, EventArgs e)
        {
            //frmDepartmentInfo_QD_LV frm = new frmDepartmentInfo_QD_LV();
            //frm.Show();
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            //frmUserState_QD_LV frm = new frmUserState_QD_LV();
            //frm.Show();
        }

        private void menuItem23_Click(object sender, EventArgs e)
        {
            //frmUserRoles_QD_LV frm = new frmUserRoles_QD_LV();
            //frm.Show();
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            //frmUsers_QD_LV frm = new frmUsers_QD_LV();
            //frm.Show();
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            //frmUserRoleRelation_QD_LV frm = new frmUserRoleRelation_QD_LV();
            //frm.Show();
        }

        private void menuItem26_Click(object sender, EventArgs e)
        {
            frmUserPrjGrant_QD_LV frm = new frmUserPrjGrant_QD_LV();
            frm.Show();
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            frmUserPrjGrant_SelectPrj frm = new frmUserPrjGrant_SelectPrj();
            frm.ShowDialog();
        }

        private void menuItem30_Click(object sender, EventArgs e)
        {
            //frmPrimaryType_QD_LV frm = new frmPrimaryType_QD_LV();
            //frm.Show();
        }

        private void menuItem31_Click_1(object sender, EventArgs e)
        {
            //frmRecExclusiveWay_QD_LV frm = new frmRecExclusiveWay_QD_LV();
            //frm.Show();
        }

        private void menuItem32_Click_1(object sender, EventArgs e)
        {
            //frmDataSynchWay_QD_LV frm = new frmDataSynchWay_QD_LV();
            //frm.Show();
        }
        public void DispMenu()
        {
            if (clsSysParaEN.strUserRoleId == "00000001")
            {
                miUserRightManage.Visible = true;
                miSysPara.Visible = true;
                miProject_QUDI.Enabled = true;
            }
            else
            {
                miUserRightManage.Visible = false;
                miSysPara.Visible = false;
                miProject_QUDI.Enabled = false;
           
            }
            if (clsSysParaEN.strUserRoleId == "00000002")
            {
                miProject_QUDI.Enabled = false;
            }
            if (clsPubVar.objCurrSelProjectEN == null)
            {
                return;
            }
            //if (clsPubVar.objCurrSelProjectEN.DataSynchWayId == "0004")
            //{
            //    miImportExcelFile.Enabled = true;
            //    miImportSqlTable.Enabled = false;
            //}
            //else
            //{
                miImportSqlTable.Enabled = true;
                miImportExcelFile.Enabled = true;
            //}
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //frmPrjTab_CheckConsistency frm = new frmPrjTab_CheckConsistency();
            //frm.Show();
        }

        private void menuItem6_Click_1(object sender, EventArgs e)
        {
            //frmPrjTab_Import frm = new frmPrjTab_Import();
            //frm.Show();
        }

        private void ��Ŀ���ݿ�ά��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPrjDataBase_QD_LV frm = new frmPrjDataBase_QD_LV();
            //frm.Show();
        }

        //private void ͬ��������ά��ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmViewInfo_QD_LV().Show();
        //    //frmSynchTaskItem_QD_LV frm = new frmSynchTaskItem_QD_LV();
        //    //frm.Show();
        //}

        private void ����ά��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTaskScheduling_QD_LV frm = new frmTaskScheduling_QD_LV();
            //frm.Show();
        }

        private void ת����ʽά��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTransWay_QD_LV frm = new frmTransWay_QD_LV();
            //frm.Show();
        }

        private void ���ɴ洢����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGeneStoreProcedure frm = new frmGeneStoreProcedure();
            //frm.Show();

        }

        private void ����ͬ������V2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.CurrSelPrjId) == true)
            {
                MessageBox.Show("��û��ͬ����Ŀ����ѡ��һ��ͬ����Ŀ��");
                return;
            }
            //frmDataImportV2 frm = new frmDataImportV2();
            //frm.Show();
        }

        private void ���뷽ʽToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmImportType_QD_LV frm = new frmImportType_QD_LV();
            //frm.Show();
        }

        private void ����ϵͳ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmExportSysSet frm = new frmExportSysSet();
            //frm.Show();
        }

        private void ���Ե���DllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTestImportByDll frm1 = new frmTestImportByDll();
            //frm1.Show();
        }

        private void ���������ϵά��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmSchedulingTaskItemRela_QD_DGV().Show();
        }

        private void ע��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
        }

        private void ����·������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserCodePath_QD_LV().Show();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTest().Show();
        }

        private void �������鿴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTabCheckResult_QD_LV().Show();
        }

        private void ����ת������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTestWebService().Show();
        }

        private void ���Լ�ʱ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm��ʱ����().Show();
        }

        private void �������ɴ���V7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm��չ�����б�().Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frmPrjTab_GeneCode().Show();
        }

        private void ���ɽ������NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmViewInfo_GeneCode().Show();
        }

        private void ������·������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserCodePrjMainPath_QD_LV().Show();
        }

        private void webService����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWebServiceSet frm1 = new frmWebServiceSet();
            frm1.frmParentForm = this;
            //frm1.MdiParent = this;
            frm1.Show();
        }

        private void ����WebSrv����ش���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmWebSrvClass_GeneCode().Show();
        }

        private void ���Զ�������ϢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm��ȡ������Ϣ().Show();
        }

        private void �������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmCMUserProject_QD_LV().Show();
        }

        private void ��Ŀ�ļ�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFileResource_QD_LV().Show();
        }

        private void ��Ŀ�ļ�����GvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFileResource_QD_DGV().Show();
        }

        private void ������·�����ñ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserCodePrjMainPath_QD_LV_Machine().Show();
        }
    }
}
