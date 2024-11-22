

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
    using CommonTable.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using CommonTable.BusinessLogic;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucFeatureRegionFldsB ��ժҪ˵����
    /// </summary>
    public partial class wucFeatureRegionFldsBak : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
        /// <summary>
        /// ����Id
        /// </summary>
        public long RegionId
        {
            get
            {
                return long.Parse(txtRegionId.Text.Trim());
            }
            set
            {
                txtRegionId.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��ť����
        /// </summary>
        public string ButtonName
        {
            get
            {
                return txtButtonName.Text.Trim();
            }
            set
            {
                txtButtonName.Text = value.ToString();
            }
        }

        /// <summary>
        /// �ı�����
        /// </summary>
        public string Text
        {
            get
            {
                return txtText.Text.Trim();
            }
            set
            {
                txtText.Text = value.ToString();
            }
        }

        /// <summary>
        /// �ؼ����ͺ�
        /// </summary>
        public string CtlTypeId
        {
            get
            {
                if (ddlCtlTypeId.SelectedValue == "0")
                    return "";
                return ddlCtlTypeId.SelectedValue;
            }
            set
            {
                if (ddlCtlTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlCtlTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlCtlTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// �߶�
        /// </summary>
        public int Height
        {
            get
            {
                return int.Parse(txtHeight.Text.Trim());
            }
            set
            {
                txtHeight.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��
        /// </summary>
        public int Width
        {
            get
            {
                return int.Parse(txtWidth.Text.Trim());
            }
            set
            {
                txtWidth.Text = value.ToString();
            }
        }

        /// <summary>
        /// �ֶ����
        /// </summary>
        public int SeqNum
        {
            get
            {
                return int.Parse(txtSeqNum.Text.Trim());
            }
            set
            {
                txtSeqNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��ʽ��
        /// </summary>
        public string CssClass
        {
            get
            {
                return txtCssClass.Text.Trim();
            }
            set
            {
                txtCssClass.Text = value.ToString();
            }
        }

        /// <summary>
        /// ͼƬ��Դ
        /// </summary>
        public string ImageUrl
        {
            get
            {
                return txtImageUrl.Text.Trim();
            }
            set
            {
                txtImageUrl.Text = value.ToString();
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
            txtRegionId.Text = "0";
            txtButtonName.Text = "";
            txtText.Text = "";
            ddlCtlTypeId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtSeqNum.Text = "0";
            txtCssClass.Text = "";
            txtImageUrl.Text = "";
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
            ComValid_RegionId.Validate();
            if (!ComValid_RegionId.IsValid) return false;
            ComValid_Height.Validate();
            if (!ComValid_Height.IsValid) return false;
            ComValid_Width.Validate();
            if (!ComValid_Width.IsValid) return false;
            ComValid_SeqNum.Validate();
            if (!ComValid_SeqNum.IsValid) return false;
            if (clsString.IsNumeric(txtRegionId.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
            if (clsString.IsNumeric(txtHeight.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
            if (clsString.IsNumeric(txtWidth.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
            if (clsString.IsNumeric(txtSeqNum.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
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
            txtRegionId.Text = "0";
            txtButtonName.Text = "";
            txtText.Text = "";
            ddlCtlTypeId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtSeqNum.Text = "0";
            txtCssClass.Text = "";
            txtImageUrl.Text = "";
            txtMemo.Text = "";
        }
        public void SetDdl_CtlTypeId()
        {
            clsCtlTypeAbbrBL.BindDdl_CtlTypeId(ddlCtlTypeId);
        }
    }
}