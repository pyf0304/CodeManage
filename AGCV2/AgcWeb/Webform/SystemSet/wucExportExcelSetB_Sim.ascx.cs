

namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucExportExcelSetB ��ժҪ˵����
    /// </summary>
    public partial class wucExportExcelSetB_Sim : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
       

        /// <summary>
        /// ��������
        /// </summary>
        public string ViewName
        {
            get
            {
                return txtViewName.Text.Trim();
            }
            set
            {
                txtViewName.Text = value.ToString();
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string TabName
        {
            get
            {
                return txtTabName.Text.Trim();
            }
            set
            {
                txtTabName.Text = value.ToString();
            }
        }

        /// <summary>
        /// �û�ID
        /// </summary>
        public string UserID
        {
            get
            {
                return txtUserID.Text.Trim();
            }
            set
            {
                txtUserID.Text = value.ToString();
            }
        }
        /// <summary>
        /// �����ļ���
        /// </summary>
        public string ExportFileName
        {
            get
            {
                return txtExportFileName.Text.Trim();
            }
            set
            {
                txtExportFileName.Text = value.ToString();
            }
        }


        /// <summary>
        ///  �Ƿ�Ĭ���û�
        /// </summary>
        public bool IsDefaultUser
        {
            set
            {
                lblIsDefaultUser.Text = value ? "Ĭ���û�" : "��Ĭ���û�";
            }
        }



        public void Clear()
        {
          
            txtViewName.Text = "";
            txtTabName.Text = "";
            txtUserID.Text = "";
          
            txtExportFileName.Text = "";
        
        }
        /// <summary>
        /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�
        /// һ�����
        ///		1������У�����ͣ����͡������͡������͵ȣ�
        ///			��Щ�������Զ����ɴ����������
        ///		2��У����ֵ�������ֵ����Сֵ��
        ///			��Щ�������Զ����ɴ����������
        ///		��Щ�������ݿ����޸�
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
        /// һ�����
        ///		1����������;�Ĭ��Ϊ0��
        ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
        ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
        ///		4�������λ(bit)�;�Ĭ��Ϊfalse;
        ///		��ЩĬ��ֵ���������޸�
        /// </summary>
        public void SetDefaultValue()
        {
          
            txtViewName.Text = "";
            txtTabName.Text = "";
            txtUserID.Text = "";
         
            txtExportFileName.Text = "";
       
        }
    }
}