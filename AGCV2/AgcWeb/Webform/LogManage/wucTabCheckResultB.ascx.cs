

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
    ///		wucTabCheckResultB ��ժҪ˵����
    /// </summary>
    public partial class wucTabCheckResultB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string PrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue == "0")
                    return "";
                return ddlPrjId.SelectedValue;
            }
            set
            {
                if (ddlPrjId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrjId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPrjId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// ��ID
        /// </summary>
        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
                return ddlTabId.SelectedValue;
            }
            set
            {
                if (ddlTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// �ֶ�ID
        /// </summary>
        public string FldId
        {
            get
            {
                return txtFldID.Text.Trim();
            }
            set
            {
                txtFldID.Text = value.ToString();
            }
        }

        /// <summary>
        /// ����ȼ�Id
        /// </summary>
        public int ErrorLevelId
        {
            get
            {
                return int.Parse( txtErrorLevelId.Text.Trim());
            }
            set
            {
                txtErrorLevelId.Text = value.ToString();
            }
        }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string errorMsg
        {
            get
            {
                return txtErrorMsg.Text.Trim();
            }
            set
            {
                txtErrorMsg.Text = value.ToString();
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string CheckDate
        {
            get
            {
                return txtCheckDate.Text.Trim();
            }
            set
            {
                txtCheckDate.Text = value.ToString();
            }
        }

        /// <summary>
        /// �����
        /// </summary>
        public string CheckUser
        {
            get
            {
                return txtCheckUser.Text.Trim();
            }
            set
            {
                txtCheckUser.Text = value.ToString();
            }
        }

        /// <summary>
        /// ˵��
        /// </summary>
        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }


        public void Clear()
        {
            ddlPrjId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtFldID.Text = "";
            txtErrorLevelId.Text = "";
            txtErrorMsg.Text = "";
            txtCheckDate.Text = "";
            txtCheckUser.Text = "";
            txtMemo.Text = "";
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
            ddlPrjId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtFldID.Text = "";
            txtErrorLevelId.Text = "";
            txtErrorMsg.Text = "";
            txtCheckDate.Text = "";
            txtCheckUser.Text = "";
            txtMemo.Text = "";
        }
  
      
        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_TabId()
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, clsPubVar.CurrSelPrjId);
        }
    }
}