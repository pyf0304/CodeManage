///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using CommFunc4WebForm;


using TzCommWebServerCtrlLib;
using AGC.BusinessLogic;
using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;


using System.Collections.Generic;

using AutoGCLib;
using System.Linq;
using com.taishsoft.datetime;

namespace AGC.Webform
{
    /// <summary>
    /// wfmQryRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPreviewViewRegion3 : System.Web.UI.Page
    {
        //�����йصı����������
        private const string ViewId4Potence = "00260203";       //������


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{

                //1��Ϊ��������������Դ�����б�����
                //2����ʾ�������ı�������DATAGRID��
                ///
                //if (clsMyConfig.IsDebug == "True")
                //{
                //    ViewId = "01120006";
                //    UserId = "pyf";
                //    clsCommonSession.UserName = "pyf";
                //}
                if (ViewId == "")
                {
                    return;
                }
                var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

                List<clsViewRegionEN> arrViewRegion = clsViewRegionBL.GetObjLstCache(clsPubVar.CurrSelPrjId);
                List<clsViewRegionEN> arrViewRegion_Curr = arrViewRegion.Where(x => arrRegionId.Contains( x.RegionId)).ToList();
                arrViewRegion_Curr.ForEach(x =>
                {
                    switch (x.RegionTypeId)
                    {
                        case enumRegionType.QueryRegion_0001:
                            chkInUse_QueryRegion.Checked = x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                            if (x.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
                            {
                                chkInUse_QueryRegion.CssClass += " text-danger";
                                chkInUse_QueryRegion.Text += "(����ʾ)";
                            }
                            break;
                        case enumRegionType.FeatureRegion_0008:
                            chkInUse_FeatureRegion.Checked = x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                            break;
                        case enumRegionType.ListRegion_0002:
                            chkInUse_ListRegion.Checked = x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                            break;
                        case enumRegionType.EditRegion_0003:
                            chkInUse_EditRegion.Checked = x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                            if (x.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
                            {
                                chkInUse_EditRegion.CssClass += " text-danger";
                                chkInUse_EditRegion.Text += "(����ʾ)";
                            }
                            break;
                        case enumRegionType.DetailRegion_0006:
                            chkInUse_DetailRegion.Checked = x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                            break;
                        case enumRegionType.ExcelExportRegion_0007:
                            chkInUse_ExcelExportRegion.Checked = x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                            break;
                    }
                });
                
                ShowAllRegion();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
            }
        }

        private void ShowAllRegion()
        {
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(ViewId, clsPubVar.CurrSelPrjId);
            List<clsViewRegionENEx> arrViewRegion = clsViewRegionBLEx.GetObjExLstByViewIdCache(ViewId, clsPubVar.CurrSelPrjId);


            try
            {
                clsViewRegionENEx objViewRegion_Qry = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion_Qry != null)
                {
                    bool bolIsDisp = objViewRegion_Qry.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                    bool bolInUse = objViewRegion_Qry.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

                    wucQryRegion4Preview1.Title = "��ѯ��";

                    wucQryRegion4Preview1.ShowControl4Regoin(objViewRegion_Qry.RegionId, clsPubVar.CurrSelPrjId, bolInUse, bolIsDisp);
                }
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000319)��ѯ����ʾ����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsViewRegionENEx objViewRegion_Feature = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (objViewRegion_Feature != null)
                {
                    wucFeatureRegionButton4Visible1.Title = "������";
                    bool bolInUse = objViewRegion_Feature.InUseInViewId(ViewId, clsPubVar.CurrSelPrjId);

                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.MainTabId, clsPubVar.CurrSelPrjId);
                    if (objPrjTab != null)
                    {
                        wucFeatureRegionButton4Visible1.ShowButton4Regoin(objViewRegion_Feature.RegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId, bolInUse);

                    }
                    else
                    {
                        wucFeatureRegionButton4Visible1.ShowButton4Regoin(objViewRegion_Feature.RegionId, "����", clsPubVar.CurrSelPrjId, bolInUse);
                    }
                }
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000320)��������ʾ����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }


            try
            {
                clsViewRegionENEx objViewRegion_List = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
                if (objViewRegion_List != null)
                {
                    bool bolIsDisp = objViewRegion_List.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                    bool bolInUse = objViewRegion_List.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

                    wucListRegion4Preview1.Title = "�б���";
                    wucListRegion4Preview1.ShowControl4Regoin(objViewRegion_List.RegionId, clsPubVar.CurrSelPrjId, 5, bolInUse, clsPubVar.CurrCmPrjId);
                }
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000321)�б�����ʾ����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsViewRegionENEx objViewRegion_Edit = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
                if (objViewRegion_Edit != null)
                {
                 bool   bolIsDisp = objViewRegion_Edit.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                  bool   bolInUse = objViewRegion_Edit.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

                    wucEditRegion4Preview1.Title = "�༭��";
                    wucEditRegion4Preview1.ShowControl4Regoin(objViewRegion_Edit.RegionId, clsPubVar.CurrSelPrjId, bolInUse, bolIsDisp);
                }
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000322)�༭����ʾ����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsViewRegionENEx objViewRegion_Detail = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
                if (objViewRegion_Detail != null)
                {
                    bool bolIsDisp = objViewRegion_Detail.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                    bool bolInUse = objViewRegion_Detail.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

                    wucDetailRegion4Preview1.Title = "��ϸ��Ϣ��";
                    wucDetailRegion4Preview1.ShowControl4Regoin(objViewRegion_Detail.RegionId, clsPubVar.CurrSelPrjId, objViewInfo.KeyId4Test, bolInUse);
                }
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000322)��ϸ��Ϣ����ʾ����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }



            try
            {
                clsViewRegionENEx objViewRegion_ExcelExport = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ExcelExportRegion_0007);
                if (objViewRegion_ExcelExport != null)
                {
                    bool bolIsDisp = objViewRegion_ExcelExport.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                    bool bolInUse = objViewRegion_ExcelExport.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

                    wucExcelExportRegion4Preview1.Title = "������";
                    wucExcelExportRegion4Preview1.ShowControl4Regoin(objViewRegion_ExcelExport.RegionId, clsPubVar.CurrSelPrjId, 5, bolInUse);
                }
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

     
        //����Ȩ�޵ȼ�������
        private string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }

        private string SimpleFName  //�������ļ���������Ŀ¼��
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)Session["SimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                Session.Add("SimpleFName", strSimpleFName);
            }
        }

        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }

        private string ViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)Session["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
            set
            {
                string strViewId = value;
                Session.Add("ViewId", strViewId);
            }
        }
        private string RegionId
        {
            get
            {
                string lngRegionId;
                if (Session["RegionId"] == null)
                {
                    lngRegionId = "";
                }
                else
                {
                    string strRegionId = Session["RegionId"].ToString();
                    lngRegionId = strRegionId;
                }
                return lngRegionId;
            }
            set
            {
                string lngRegionId = value;
                Session.Add("RegionId", lngRegionId);
            }
        }

        ///private clsUsersEN objUserBak
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}

        private string BackViewRegionLinkStr
        {
            get
            {
                string strBackViewRegionLinkStr;
                strBackViewRegionLinkStr = (string)Session["BackViewRegionLinkStr"];
                if (strBackViewRegionLinkStr == null)
                {
                    strBackViewRegionLinkStr = "";
                }
                return strBackViewRegionLinkStr;
            }
            set
            {
                string strBackViewRegionLinkStr = value;
                Session.Add("BackViewRegionLinkStr", strBackViewRegionLinkStr);
            }
        }
        private string BackGeneCode4JavaLinkStr
        {
            get
            {
                string strBackGeneCode4JavaLinkStr;
                strBackGeneCode4JavaLinkStr = (string)Session["BackGeneCode4JavaLinkStr"];
                if (strBackGeneCode4JavaLinkStr == null)
                {
                    strBackGeneCode4JavaLinkStr = "";
                }
                return strBackGeneCode4JavaLinkStr;
            }
            set
            {
                string strBackGeneCode4JavaLinkStr = value;
                Session.Add("BackGeneCode4JavaLinkStr", strBackGeneCode4JavaLinkStr);
            }
        }
        private string BackGeneCode4WebV5LinkStr
        {
            get
            {
                string strBackGeneCode4WebV5LinkStr;
                strBackGeneCode4WebV5LinkStr = (string)Session["BackGeneCode4WebV5LinkStr"];
                if (strBackGeneCode4WebV5LinkStr == null)
                {
                    strBackGeneCode4WebV5LinkStr = "";
                }
                return strBackGeneCode4WebV5LinkStr;
            }
            set
            {
                string strBackGeneCode4WebV5LinkStr = value;
                Session.Add("BackGeneCode4WebV5LinkStr", strBackGeneCode4WebV5LinkStr);
            }
        }
        private string BackGeneCode4WinV5LinkStr
        {
            get
            {
                string strBackGeneCode4WinV5LinkStr;
                strBackGeneCode4WinV5LinkStr = (string)Session["BackGeneCode4WinV5LinkStr"];
                if (strBackGeneCode4WinV5LinkStr == null)
                {
                    strBackGeneCode4WinV5LinkStr = "";
                }
                return strBackGeneCode4WinV5LinkStr;
            }
            set
            {
                string strBackGeneCode4WinV5LinkStr = value;
                Session.Add("BackGeneCode4WinV5LinkStr", strBackGeneCode4WinV5LinkStr);
            }
        }
        private string BackGeneCode4WebV2005LinkStr
        {
            get
            {
                string strBackGeneCode4WebV2005LinkStr;
                strBackGeneCode4WebV2005LinkStr = (string)Session["BackGeneCode4WebV2005LinkStr"];
                if (strBackGeneCode4WebV2005LinkStr == null)
                {
                    strBackGeneCode4WebV2005LinkStr = "";
                }
                return strBackGeneCode4WebV2005LinkStr;
            }
            set
            {
                string strBackGeneCode4WebV2005LinkStr = value;
                Session.Add("BackGeneCode4WebV2005LinkStr", strBackGeneCode4WebV2005LinkStr);
            }
        }

        private string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)ViewState["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                ViewState.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }

        /// <summary>
        /// ���ܣ�����DataGrid��ҳ��
        /// </summary>
        /// <param name="intRecCount">�ܹ��ļ�¼��</param>
        /// <param name="intPageSize">ÿҳ�ļ�¼��</param>
        /// <returns>���������ҳ��</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }



        protected void btnGoBack_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(BackErrPageLinkStr);
        }
            
       
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {

        }
        protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox objCurrCheckBox = (CheckBox)sender;
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBL.GetObjLstCache(clsPubVar.CurrSelPrjId);
            //List<clsViewRegionEN> arrViewRegion_Curr = arrViewRegion.Where(x => x.ViewId == clsCommonSession.ViewId).ToList();
            //string strRegionTypeId = "";
            //switch (objCurrCheckBox.ID)
            //{
            //    case "chkInUse_QueryRegion":
            //        strRegionTypeId = enumRegionType.QueryRegion_0001;
            //        break;
            //    case "chkInUse_FeatureRegion":
            //        strRegionTypeId = enumRegionType.FeatureRegion_0008;
            //        break;
            //    case "chkInUse_ListRegion":
            //        strRegionTypeId = enumRegionType.ListRegion_0002;
            //        break;
            //    case "chkInUse_EditRegion":
            //        strRegionTypeId = enumRegionType.EditRegion_0003;
            //        break;
            //    case "chkInUse_ExcelExportRegion":
            //        strRegionTypeId = enumRegionType.ExcelExportRegion_0007;
            //        break;
            //}

            bool bolInUse = objCurrCheckBox.Checked;



            //clsViewRegionEN objViewRegion = arrViewRegion_Curr.Find(x => x.RegionTypeId == strRegionTypeId);
            //if (objViewRegion == null)
            //{
            //    objCurrCheckBox.Enabled = false;
            //}
            //objViewRegion.SetInUse(bolInUse)
            //    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            //    .SetUpdUser(clsCommonSession.UserId)
            //    .Update();

            ShowAllRegion();
            //try
            //{
            //    switch (strRegionTypeId)
            //    {
            //        case enumRegionType.QueryRegion_0001:
            //            wucQryRegion4Preview1.ShowControl4Regoin(objViewRegion.RegionId, clsPubVar.CurrSelPrjId);
            //            break;
            //        case enumRegionType.FeatureRegion_0008:
            //            wucFeatureRegionButton4Visible1.Title = "������";
            //            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(ViewId, clsPubVar.CurrSelPrjId);

            //            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.MainTabId, clsPubVar.CurrSelPrjId);
            //            if (objPrjTab != null)
            //            {
            //                wucFeatureRegionButton4Visible1.ShowButton4Regoin(objViewRegion.RegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId);

            //            }
            //            else
            //            {
            //                wucFeatureRegionButton4Visible1.ShowButton4Regoin(objViewRegion.RegionId, "����", clsPubVar.CurrSelPrjId);
            //            }
            //            break;
            //        case enumRegionType.ListRegion_0002:
            //            wucListRegion4Preview1.ShowControl4Regoin(objViewRegion.RegionId, clsPubVar.CurrSelPrjId, 5);
            //            break;
            //        case enumRegionType.EditRegion_0003:
            //            wucEditRegion4Preview1.ShowControl4Regoin(objViewRegion.RegionId, clsPubVar.CurrSelPrjId);
            //            break;
            //        case enumRegionType.ExcelExportRegion_0007:
            //            wucQryRegion4Preview1.ShowControl4Regoin(objViewRegion.RegionId, clsPubVar.CurrSelPrjId);
            //            break;

            //    }
            //    //	3������Gv�ؼ���ĳЩ�в��ɼ���

            //    //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
            //    clsCommonJsFunc.Alert(this, strMsg);
            //    return;
            //}
        }
    }
}