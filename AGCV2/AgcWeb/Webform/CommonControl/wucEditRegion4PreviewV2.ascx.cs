
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Collections;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using AGC.PureClass;
    using AGC.PureClassEx;

    /// <summary>
    ///		wucEditRegionFlds ��ժҪ˵����
    /// </summary>
    public partial class wucEditRegion4PreviewV2 : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��


        }
        /// <summary>
        /// ���ñ���
        /// </summary>
        public string Title
        {
            set
            {
                lblTitle.Text = value;
            }
        }

        public class ControlIdComparer : IEqualityComparer<ASPControlEx>
        {
            public bool Equals(ASPControlEx t1, ASPControlEx t2)
            {
                return (t1.CtrlId == t2.CtrlId);
            }
            public int GetHashCode(ASPControlEx t)
            {
                return t.ToString().GetHashCode();
            }
        }
        public void ShowControl4RegoinBak(string lngRegionId, string strPrjId, bool bolInUse)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (objViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false )
                {
                    lblTitleOutUse.Text = string.Format("�༭��: <span class='text-secondary  font-weight-bold'>(����:{0})</span>", objViewRegion.ClsName);
                }
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false && lblTitle.Text.Contains("���ӻ�"))
                {
                    lblTitle.Text = string.Format("���ӻ� <span class='text-secondary  font-weight-bold'>(����:{0})</span>", objViewRegion.ClsName);
                }
                else
                {
                    lblTitle.Text = string.Format("�༭��: <span class='text-secondary  font-weight-bold'>(����:{0})</span>", objViewRegion.ClsName);
                }
                if (objViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
                {
                    if (lblTitle.Text.IndexOf("-����ʾ") == -1)
                    {
                        lblTitle.Text += "-����ʾ";
                    }
                    lblTitle.CssClass += " text-danger";
                }
                lblTitleOutUse.Visible = false;
            }

            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objDiv.Style["width"] = string.Format("{0}px", objViewRegion.Width);


            IEnumerable<ASPControlGroupEx> arrControlGroups = clsEditRegionFldsBLEx.GetControlGroup(lngRegionId, clsPubVar.CurrCmPrjId, strPrjId, "");
                                   
            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objTable.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objFormControl = clsASPDivBLEx.PackageByFormControl4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormControl.GeneHtmlControl(objDiv);
                    break;

                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4EditRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objUl.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4EditRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objUl2.GeneHtmlControl(objDiv);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objTable2.GeneHtmlControl(objDiv);
                    break;
            }


            pnlControlLst.Controls.Clear();
            pnlControlLst.Controls.Add(objDiv);
            divEditRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }


        public void ShowControl4Regoin(string lngRegionId, string strPrjId, bool bolInUse, bool bolIsDisp)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (bolInUse == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false)
                {
                    lblTitleOutUse.Text = string.Format("�༭��: <span class='text-secondary  font-weight-bold'>(����:{0})</span>", objViewRegion.ClsName);
                }
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false && lblTitle.Text.Contains("���ӻ�"))
                {
                    lblTitle.Text = string.Format("���ӻ� <span class='text-secondary  font-weight-bold'>(����:{0})</span>", objViewRegion.ClsName);
                }
                else
                {
                    lblTitle.Text = string.Format("�༭��: <span class='text-secondary  font-weight-bold'>(����:{0})</span>", objViewRegion.ClsName);
                }
                if (bolIsDisp == false)
                {
                    if (lblTitle.Text.IndexOf("-����ʾ") == -1)
                    {
                        lblTitle.Text += "-����ʾ";
                    }
                    lblTitle.CssClass += " text-danger";
                }
                lblTitleOutUse.Visible = false;
            }

            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objDiv.Style["width"] = string.Format("{0}px", objViewRegion.Width);


            IEnumerable<ASPControlGroupEx> arrControlGroups = clsEditRegionFldsBLEx.GetControlGroup(lngRegionId, clsPubVar.CurrCmPrjId, strPrjId, "");

            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objTable.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objFormControl = clsASPDivBLEx.PackageByFormControl4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormControl.GeneHtmlControl(objDiv);
                    break;

                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4EditRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objUl.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4EditRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objUl2.GeneHtmlControl(objDiv);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objTable2.GeneHtmlControl(objDiv);
                    break;
            }


            pnlControlLst.Controls.Clear();
            pnlControlLst.Controls.Add(objDiv);
            divEditRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }

        public void ShowControl4Regoin4Query(string lngRegionId, string strCmPrjId, string strPrjId)
        {
            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroupV2(lngRegionId, strCmPrjId, strPrjId, "");
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objTable.GeneHtmlControl(objDiv);

            pnlControlLst.Controls.Add(objDiv);
            divEditRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }
    }
}