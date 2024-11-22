using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using AGC.Entity;
using AGC4WApi;

namespace AGC_CSWin
{
	/// <summary>
	/// MaintainPassWord ��ժҪ˵����
	/// </summary>
	public class MaintainPassWord : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbStuID;
		public  System.Windows.Forms.TextBox txtStuID;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtnewPassWord;
		private System.Windows.Forms.TextBox txtConfirmPassWord;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtCardNo;
		private System.Windows.Forms.TextBox txtCitizenID;
		private System.Windows.Forms.TextBox txtEmial;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.RadioButton rdbtnteacher;
		private System.Windows.Forms.RadioButton rdbtnStudent;
		public string strMsg;
		private System.Windows.Forms.GroupBox gpbxNewpwd;
		private System.Windows.Forms.PictureBox ptbPhoto;
		private System.Windows.Forms.RadioButton rdbtnPassEmail;
		private System.Windows.Forms.RadioButton rdbtnResumePassWord;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnJorn;
		public string strTeacherID;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MaintainPassWord()
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
				if(components != null)
				{
					components.Dispose();
				}
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnteacher = new System.Windows.Forms.RadioButton();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.lbStuID = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            this.txtEmial = new System.Windows.Forms.TextBox();
            this.txtCitizenID = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnPassEmail = new System.Windows.Forms.RadioButton();
            this.rdbtnResumePassWord = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gpbxNewpwd = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtConfirmPassWord = new System.Windows.Forms.TextBox();
            this.txtnewPassWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJorn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gpbxNewpwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnteacher);
            this.groupBox1.Controls.Add(this.rdbtnStudent);
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "���";
            // 
            // rdbtnteacher
            // 
            this.rdbtnteacher.Location = new System.Drawing.Point(120, 16);
            this.rdbtnteacher.Name = "rdbtnteacher";
            this.rdbtnteacher.Size = new System.Drawing.Size(104, 24);
            this.rdbtnteacher.TabIndex = 1;
            this.rdbtnteacher.Text = "��ʦ";
            this.rdbtnteacher.CheckedChanged += new System.EventHandler(this.rdbtnteacher_CheckedChanged);
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.Checked = true;
            this.rdbtnStudent.Location = new System.Drawing.Point(16, 16);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(104, 24);
            this.rdbtnStudent.TabIndex = 0;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "ѧ��";
            this.rdbtnStudent.CheckedChanged += new System.EventHandler(this.rdbtnStudent_CheckedChanged);
            // 
            // lbStuID
            // 
            this.lbStuID.Location = new System.Drawing.Point(312, 32);
            this.lbStuID.Name = "lbStuID";
            this.lbStuID.Size = new System.Drawing.Size(40, 23);
            this.lbStuID.TabIndex = 1;
            this.lbStuID.Text = "ѧ��";
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(360, 24);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(160, 21);
            this.txtStuID.TabIndex = 2;
            this.txtStuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStuID_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptbPhoto);
            this.groupBox2.Controls.Add(this.txtEmial);
            this.groupBox2.Controls.Add(this.txtCitizenID);
            this.groupBox2.Controls.Add(this.txtCardNo);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "������Ϣ";
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Location = new System.Drawing.Point(488, 24);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(160, 200);
            this.ptbPhoto.TabIndex = 8;
            this.ptbPhoto.TabStop = false;
            // 
            // txtEmial
            // 
            this.txtEmial.Enabled = false;
            this.txtEmial.Location = new System.Drawing.Point(80, 156);
            this.txtEmial.Name = "txtEmial";
            this.txtEmial.Size = new System.Drawing.Size(152, 21);
            this.txtEmial.TabIndex = 7;
            // 
            // txtCitizenID
            // 
            this.txtCitizenID.Enabled = false;
            this.txtCitizenID.Location = new System.Drawing.Point(80, 110);
            this.txtCitizenID.Name = "txtCitizenID";
            this.txtCitizenID.Size = new System.Drawing.Size(152, 21);
            this.txtCitizenID.TabIndex = 6;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Enabled = false;
            this.txtCardNo.Location = new System.Drawing.Point(80, 64);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(152, 21);
            this.txtCardNo.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(80, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 21);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "�����ʼ�";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "���֤��";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "����";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "����";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnPassEmail);
            this.groupBox3.Controls.Add(this.rdbtnResumePassWord);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(8, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "�޸ķ�ʽ";
            // 
            // rdbtnPassEmail
            // 
            this.rdbtnPassEmail.Location = new System.Drawing.Point(408, 32);
            this.rdbtnPassEmail.Name = "rdbtnPassEmail";
            this.rdbtnPassEmail.Size = new System.Drawing.Size(136, 24);
            this.rdbtnPassEmail.TabIndex = 2;
            this.rdbtnPassEmail.Text = "��ǰ���뷢������";
            this.rdbtnPassEmail.CheckedChanged += new System.EventHandler(this.rdbtnPassEmail_CheckedChanged);
            // 
            // rdbtnResumePassWord
            // 
            this.rdbtnResumePassWord.Location = new System.Drawing.Point(224, 32);
            this.rdbtnResumePassWord.Name = "rdbtnResumePassWord";
            this.rdbtnResumePassWord.Size = new System.Drawing.Size(104, 24);
            this.rdbtnResumePassWord.TabIndex = 1;
            this.rdbtnResumePassWord.Text = "�ָ�Ĭ������";
            this.rdbtnResumePassWord.CheckedChanged += new System.EventHandler(this.rdbtnResumePassWord_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(56, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "�ֹ�����";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // gpbxNewpwd
            // 
            this.gpbxNewpwd.Controls.Add(this.button1);
            this.gpbxNewpwd.Controls.Add(this.btnOK);
            this.gpbxNewpwd.Controls.Add(this.txtConfirmPassWord);
            this.gpbxNewpwd.Controls.Add(this.txtnewPassWord);
            this.gpbxNewpwd.Controls.Add(this.label6);
            this.gpbxNewpwd.Controls.Add(this.label5);
            this.gpbxNewpwd.Location = new System.Drawing.Point(8, 392);
            this.gpbxNewpwd.Name = "gpbxNewpwd";
            this.gpbxNewpwd.Size = new System.Drawing.Size(712, 145);
            this.gpbxNewpwd.TabIndex = 5;
            this.gpbxNewpwd.TabStop = false;
            this.gpbxNewpwd.Text = "��������";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("����", 10.5F);
            this.button1.Location = new System.Drawing.Point(352, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "ȡ��";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("����", 10.5F);
            this.btnOK.Location = new System.Drawing.Point(224, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ȷ��";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtConfirmPassWord
            // 
            this.txtConfirmPassWord.Location = new System.Drawing.Point(144, 56);
            this.txtConfirmPassWord.Name = "txtConfirmPassWord";
            this.txtConfirmPassWord.Size = new System.Drawing.Size(168, 21);
            this.txtConfirmPassWord.TabIndex = 3;
            // 
            // txtnewPassWord
            // 
            this.txtnewPassWord.Location = new System.Drawing.Point(144, 24);
            this.txtnewPassWord.Name = "txtnewPassWord";
            this.txtnewPassWord.Size = new System.Drawing.Size(168, 21);
            this.txtnewPassWord.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(40, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "ȷ��������";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(40, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "������";
            // 
            // btnJorn
            // 
            this.btnJorn.Location = new System.Drawing.Point(544, 24);
            this.btnJorn.Name = "btnJorn";
            this.btnJorn.Size = new System.Drawing.Size(56, 23);
            this.btnJorn.TabIndex = 6;
            this.btnJorn.Text = "......";
            this.btnJorn.Click += new System.EventHandler(this.btnJorn_Click);
            // 
            // MaintainPassWord
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 549);
            this.Controls.Add(this.btnJorn);
            this.Controls.Add(this.gpbxNewpwd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.lbStuID);
            this.Controls.Add(this.groupBox1);
            this.Name = "MaintainPassWord";
            this.Text = "ά������";
            this.Load += new System.EventHandler(this.MaintainPassWord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gpbxNewpwd.ResumeLayout(false);
            this.gpbxNewpwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void MaintainPassWord_Load(object sender, System.EventArgs e)
		{
			
			
		}

//		private void LoadNewPict()
//		{
//			// You should replace the bold image 
//			// in the sample below with an icon of your own choosing.
//			// Note the escape character used (@) when specifying the path.
//			pictureBox1.Image = Image.FromFile
//				(System.Environment.GetFolderPath
//				(System.Environment.SpecialFolder.Personal)
//				+ @"\Image.jpeg");
//		}




     
        /// <summary>
        /// ��ʾ��ʦ��Ϣ
        /// </summary>
		private void ShowteacherMessage()
		{
//            string TeacherID = this.txtStuID.Text.Replace(" ","");
//            if(clsTeacherInfo.IsExistCondRec("TeacherInfo"," TeacherID = '"+TeacherID+"' ") == false)
//            {
//                strMsg = "����д�Ĺ��Ų���ȷ!";
//                MessageBox.Show(strMsg);
//                return;
//            }
//            clsTeacherInfo objTeacher = new clsTeacherInfo();
//            string strTeacherID = this.txtStuID.Text.ToString().Trim();
//            clsTeacherInfo objTeacherInfo = new clsTeacherInfo();
//            objTeacherInfo = objTeacher.GetFirstTeacherInfo("TeacherID='"+strTeacherID+"' ");
//            this.txtName.Text = objTeacherInfo.TeacherName.ToString();
//            this.txtCardNo.Text = objTeacherInfo.CardNo.ToString();
//            this.txtCitizenID.Text = objTeacherInfo.CitizenID.ToString();
//            this.txtEmial.Text =objTeacherInfo.Email.ToString();
//            //��ʾ��Ƭ
////			this.ptbPhoto.Image = Image.FromFile("d:\\222.jpg"); 
          
		}
		/// <summary>
		/// ��ʾѧ����Ϣ
		/// </summary>
		private void showstudentMessage()
		{
//            string StuID = this.txtStuID.Text.Replace(" ","");
//            if(clsXsStu.IsExistCondRec("XsStu","StuID='"+StuID+"' ") == false)
//            {
//                strMsg = "����д��ѧ�Ų���ȷ!";
//                MessageBox.Show(strMsg);
//                return;
//            }
//            clsXsStu objXsStu = new clsXsStu();
//            string strStuID = this.txtStuID.Text.ToString().Trim();
//            clsXsStu objXsStuInfo = new clsXsStu();
//            objXsStuInfo = objXsStu.GetFirstXsStu("StuID ='"+strStuID+"' ");
//            this.txtName.Text = objXsStuInfo.StuName.ToString();
//            this.txtCardNo.Text = objXsStuInfo.CardNo.ToString();
//            this.txtCitizenID.Text = objXsStuInfo.CitizenID.ToString();
////			this.txtEmial.Text = objXsStuInfo.Email
//            //��ʾ��Ƭ
////			this.ptbPhoto.Image = Image.FromFile("d:\\111.jpg");  //new Bitmap.Image("d:\\222.jpg");
		}
		/// <summary>
		/// �ı���س��¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void txtStuID_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (rdbtnStudent.Checked)
			{
				
				if(e.KeyChar==(char)13 )
				{
					//�س�����Ҫ�������¼�
					showstudentMessage();
				}
			}
			if(rdbtnteacher.Checked )
			{
				
				if(e.KeyChar==(char)13 )
				{
					//�س�����Ҫ�������¼�		
					ShowteacherMessage();
				}
			}
			
		}
		/// <summary>
		/// �ж�2���ı����Ƿ�Ϊ��
		/// </summary>
		/// <returns></returns>
		private bool isempty()
		{
			string strMsg;
			if(txtnewPassWord.Text == "")
			{
				strMsg = "������������!";
				MessageBox.Show(strMsg);
				return false;
			}
			if(txtConfirmPassWord.Text == "")
			{
				strMsg = "���ٴ�����������!";
				MessageBox.Show(strMsg);
				return false;
			}

			return true;
			
		}
		/// <summary>
		/// �ж����������Ƿ�һ��
		/// </summary>
		/// <returns></returns>
		private bool isPassWordSame()
		{
			string strMsg;
			if(this.txtnewPassWord.Text == this.txtConfirmPassWord.Text)
			{
				return true;
			}
			else
			{
				strMsg = "��������������һ��!";
				MessageBox.Show(strMsg);
				return false;
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
            if (this.radioButton3.Checked)
            {
                //�ж�2���ı����Ƿ�Ϊ��
                if (isempty() == false)
                {
                    return;
                }
                //�ж����������Ƿ�һ��
                if (isPassWordSame() == false)
                {
                    return;
                }

                //�����û����е�pwd�ֶ�
                string NewPassWord = this.txtnewPassWord.Text.Trim();
                string strStuID = this.txtStuID.Text.ToString().Trim();

                string strMsg;
                try
                {
                    string strCondition = string.Format("StuTeacherID = '{0}'", strStuID);
                    clsUsersEN objUsers = clsUsersWApi.GetFirstObj(strCondition);
                    objUsers.Password = NewPassWord;
                    objUsers.Update();
                    strMsg = "�޸�����ɹ�!";
                    MessageBox.Show(strMsg);
                    return;
                }
                catch
                {
                    strMsg = "�޸Ĳ��ɹ�";
                    MessageBox.Show(strMsg);
                    return;
                }
            }
            if (this.rdbtnResumePassWord.Checked)
            {
                try
                {
                    string strCardNo = this.txtCardNo.Text.ToString().Trim();
                    string strStuID = this.txtStuID.Text.ToString().Trim();
                    string strCondition = string.Format("StuTeacherID = '{0}'", strStuID );
                    clsUsersEN objUsers = clsUsersWApi.GetFirstObj(strCondition);
                    objUsers.Password = strCardNo;
                    objUsers.Update();
                    this.txtnewPassWord.Enabled = false;
                    this.txtConfirmPassWord.Enabled = false;
                    MessageBox.Show("����ָ��ɹ�");
                    return;
                }
                catch
                {
                    MessageBox.Show("����ָ����ɹ�");
                    return;
                }
            }
            if (this.rdbtnPassEmail.Checked)
            {
                this.txtnewPassWord.Enabled = false;
                this.txtConfirmPassWord.Enabled = false;
                MessageBox.Show("�����ѷ�������");
                return;
 
            }
		}
		/// <summary>
		/// ����ָ����밴ťʱ�ָ�Ԥ������
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void rdbtnResumePassWord_CheckedChanged(object sender, System.EventArgs e)
		{
            //try
            //{
            //    string strCardNo = this.txtCardNo.Text.ToString().Trim();
            //    string strStuID = this.txtStuID.Text.ToString().Trim();
            //    clsUsersEN objUsers = new clsUsersEN();
            //    objUsers.funSetFldValue("PassWord", strCardNo, "StuTeacherID = '" + strStuID + "' ");
            //    this.txtnewPassWord.Enabled = false;
            //    this.txtConfirmPassWord.Enabled = false;
            //    MessageBox.Show("����ָ��ɹ�");
            //    return;
            //}
            //catch
            //{
            //    MessageBox.Show("����ָ����ɹ�");
            //    return;
            //}
		}
		/// <summary>
		/// �����ťʱʹ�ı��򲻿ɼ�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void rdbtnPassEmail_CheckedChanged(object sender, System.EventArgs e)
		{
			
		}
		/// <summary>
		/// ����ֹ����ð�ť
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.txtnewPassWord.Text = "";
			this.txtConfirmPassWord.Text = "";
			this.txtnewPassWord.Enabled = true;
			this.txtConfirmPassWord.Enabled = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void rdbtnStudent_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lbStuID.Text = "ѧ��";
		
		}

		private void rdbtnteacher_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lbStuID.Text = "����";
		
		}

		private void btnJorn_Click(object sender, System.EventArgs e)
		{
            //if (rdbtnStudent.Checked)
            //{
            //    frmXsStu_QD_LV frm = new frmXsStu_QD_LV();
            //    frm.ShowDialog();
            //    this.txtStuID.Text = frm.strStuID;
            //    showstudentMessage();
            //}
            //if(rdbtnteacher.Checked )
            //{
            //    frmTeacher_QUDI frm = new frmTeacher_QUDI();
            //    frm.ShowDialog();
            //    string ss = frm.strTeacherID;
            //    this.txtStuID.Text = ss;
            //    ShowteacherMessage();
            //}
		
		}
		


		



		




	}
}
