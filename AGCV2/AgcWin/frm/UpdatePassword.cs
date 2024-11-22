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
	/// UpdatePassword ��ժҪ˵����
	/// </summary>
	public class UpdatePassword : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtpwd;
		private System.Windows.Forms.TextBox txtNewped;
		private System.Windows.Forms.TextBox txtAgainpwd;
		private System.Windows.Forms.Button btnUpdatepwd;
		private System.Windows.Forms.Button btncancel;
        //string strUserID;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UpdatePassword()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtpwd = new System.Windows.Forms.TextBox();
			this.txtNewped = new System.Windows.Forms.TextBox();
			this.txtAgainpwd = new System.Windows.Forms.TextBox();
			this.btnUpdatepwd = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Font = new System.Drawing.Font("����", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "������������";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "��������ǰ������";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "����һ��������";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(56, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "�ٴ�����������ȷ��";
			// 
			// txtpwd
			// 
			this.txtpwd.Location = new System.Drawing.Point(184, 64);
			this.txtpwd.Name = "txtpwd";
			this.txtpwd.Size = new System.Drawing.Size(152, 21);
			this.txtpwd.TabIndex = 4;
			this.txtpwd.Text = "";
			// 
			// txtNewped
			// 
			this.txtNewped.Location = new System.Drawing.Point(184, 96);
			this.txtNewped.Name = "txtNewped";
			this.txtNewped.Size = new System.Drawing.Size(152, 21);
			this.txtNewped.TabIndex = 5;
			this.txtNewped.Text = "";
			// 
			// txtAgainpwd
			// 
			this.txtAgainpwd.Location = new System.Drawing.Point(184, 128);
			this.txtAgainpwd.Name = "txtAgainpwd";
			this.txtAgainpwd.Size = new System.Drawing.Size(152, 21);
			this.txtAgainpwd.TabIndex = 6;
			this.txtAgainpwd.Text = "";
			// 
			// btnUpdatepwd
			// 
			this.btnUpdatepwd.Location = new System.Drawing.Point(112, 208);
			this.btnUpdatepwd.Name = "btnUpdatepwd";
			this.btnUpdatepwd.TabIndex = 7;
			this.btnUpdatepwd.Text = "��������";
			this.btnUpdatepwd.Click += new System.EventHandler(this.btnUpdatepwd_Click);
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(240, 208);
			this.btncancel.Name = "btncancel";
			this.btncancel.TabIndex = 8;
			this.btncancel.Text = "ȡ��";
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			// 
			// UpdatePassword
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(576, 373);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnUpdatepwd);
			this.Controls.Add(this.txtAgainpwd);
			this.Controls.Add(this.txtNewped);
			this.Controls.Add(this.txtpwd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UpdatePassword";
			this.Text = "UpdatePassword";
			this.ResumeLayout(false);

		}
		#endregion
	   /// <summary>
	   /// �ж�3���ı����Ƿ�Ϊ��
	   /// </summary>
	   /// <returns></returns>
		private bool isempty()
		{
			string strMsg;
			if(txtpwd.Text == "")
			{
				strMsg = "�����������!";
				MessageBox.Show(strMsg);
				return false;
			}
			if(txtNewped.Text == "")
			{
				strMsg = "������������!";
				MessageBox.Show(strMsg);
				return false;
			}
			if(txtAgainpwd.Text == "")
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
			if(this.txtNewped.Text == this.txtAgainpwd.Text)
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
		/// <summary>
		/// �жϾ������Ƿ���ȷ
		/// </summary>
		/// <returns></returns>
		private bool isPassWordright()
		{
			string strMsg;
			clsUsersEN objUser = clsUsersWApi.GetObjByUserId(clsSysParaEN.strUserId);
			
            if (objUser != null)
			{
				string pwd = objUser.Password.ToString();
				if(pwd.Trim()==txtpwd.Text)//strPassWord.Trim())
					return true;
				else
				{
					strMsg = "����������벻��ȷ!";
					MessageBox.Show(strMsg);
					return false;
				}
			}
			else
			{  
				return false;
			}
		}

		private void btnUpdatepwd_Click(object sender, System.EventArgs e)
		{
		    //�ж�3���ı����Ƿ�Ϊ��
			if(isempty() == false )
			{
			   return;
			}
			//�жϾ������Ƿ���ȷ
			if(isPassWordright()==false)
			{
				return;
			}
			//�ж����������Ƿ�һ��
			if(isPassWordSame()==false)
			{
				return;
			}

			//�����û����е�pwd�ֶ�
			string NewPassWord = this.txtNewped.Text.Trim();

           
			string strMsg;
			try
			{
                string strCondition = string.Format("UserID = '{0}'", clsSysParaEN.strUserId);
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

		private void btncancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
