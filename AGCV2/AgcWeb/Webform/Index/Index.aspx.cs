using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commexception;
using com.taishsoft.common;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using AGC.WebSrv;

using GeneralPlatform.Entity;
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using GeneralPlatform4WApi;
using GP4WApi;

namespace AGC
{
    /// <summary>
    /// load ��ժҪ˵����
    /// </summary>
    public partial class Index : CommWebPageBase
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			//���´���־ΪDEBUGʹ��
			if (!IsPostBack)
			{
				string strIP = Request.UserHostAddress.ToString();
				if (strIP == "127.0.0.1" || strIP == "59.78.151.114")
				{
					InitViewForDebug();
				}
			}
		}

		private void InitViewForDebug()
		{
			txtUid.Text = "pyf";
			txtPassWord.Text = "mm012345";
		}

		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
				{
					strBackErrPageLinkStr = "";
				}
				return strBackErrPageLinkStr;
			}
			set
			{
				string strBackErrPageLinkStr = value;
				Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
			}
		}
		private string ErrMessage
		{
			get
			{
				string strErrMessage;
				strErrMessage = (string)Session["ErrMessage"];
				if (strErrMessage==null) 
				{
					strErrMessage = "";
				}
				return strErrMessage;
			}
			set
			{
				string strErrMessage = value;
				Session.Add("ErrMessage", strErrMessage);
			}
		}

        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}


        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string strUserId,strPassword;
			strUserId = txtUid.Text.Trim();
			strPassword = txtPassWord.Text;
			Login(strUserId, strPassword);
//			string strTemp = strUserId.ToLower();
//			int i = strTemp.IndexOf("or");
//			int j = strTemp.IndexOf("'");
//			if (i>0 && j>=0)
//			{
//				Response.Write("<script>alert('��������ȷ���û�����')</script>");
//				return;
//			}
//			if(txtUid.Text=="")
//			{
//				Response.Write("<script>alert('�������û�����')</script>");
//				return;
//			}
//			
//			clsUsersEN objUser = new clsUsersEN(strUserId);
//			objUser.GetUsers();
//			strPassword = objUser.PassWord;
//			if(txtPassWord.Text != strPassword)
//			{
//				Response.Write("<script>alert('���벻��ȷ��')</script>");
//				return;
//			}
//			///���浱ǰ�û�ID
//			Session.Add("objUser",objUser);
//			Session.Add("UserId",objUser.UserId);
//			//��ӵ�¼��־
//			AddSysLogForLogin(strUserId);
//			string strPrjId;
//			///����Ĭ��ȱʡ����
//			CurrPrjId = ConfigurationSettings.AppSettings["CurrPrjId"];
//
//			//��鵱ǰ�û��м�����Ȩ����
//			ArrayList arrUserPrjGrantObjList = new clsUserPrjGrantBL.GetObjLst("UserId = '" + strUserId + "'");
//			if (arrUserPrjGrantObjList.Count == 0)
//			{
//				Response.Write("<script>alert('��û�и�Ȩ���̣�����ϵϵͳ����Ա��')</script>");
//				return;
//			}
//			else if (arrUserPrjGrantObjList.Count == 1)
//			{
//				clsUserPrjGrantEN objUserPrjGrant = (clsUserPrjGrantEN)arrUserPrjGrantObjList[0];
//				strPrjId = objUserPrjGrant.PrjId;;
//				RoleId = objUserPrjGrant.RoleId;
//				Session.Add("PrjId",strPrjId);
//				///����Ĭ�ϵ����ݿ�
//				clsProjectsEN objProject = new clsProjectsEN(strPrjId, true);
//				string strPrjDataBaseName;
//				strPrjDataBaseName = objPrjDataBase.DataBaseName;
//				Session.Add("PrjDataBaseName",strPrjDataBaseName);
//				Response.Write("<script>alert('��½�ɹ���')</script>");
//				Response.Redirect("FrameSet.htm");
//				return;
//			}
//			else 
//			{
//				Response.Redirect("./wfmSelectProject.aspx");
//			}		
		}
		private void AddSysLogForLogin(string strUserId)
		{
//			string strUserId = strUserId;
			string strUserIp = Request.UserHostAddress;
            if (strUserIp == "127.0.0.1")
            {
                return;
            }
			string strUserName = clsUsersBL.GetObjByUserId(strUserId).UserName;
			string strOperationType = "0005"; //��¼;
			string strTableName = "Users";
			string strTableKey = strUserId;
			string strJournal="ִ���˵�¼����!";
		
			bool IsSuccesful=true;
            try
            {
                IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(
                    strUserId,
                    strUserIp,
                    strOperationType,
                    strTableName,
                    strTableKey,
                    strJournal,
                    null);
            }
            catch(Exception objException)
            {
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);

            }
            if (IsSuccesful)
			{
				//					Response.Write("<script>alert('��־��ӳɹ�!')</script>");
			}

		}
		private void LoginBak(string strUserId, string strPassword)
		{
           
			string strMsg;
			string strTemp = strUserId.ToLower();
			int i = strTemp.IndexOf("or");
			int j = strTemp.IndexOf("'");
			
			if (i>0 && j>=0)
			{
				strMsg = "��������ȷ���û�����";
				clsCommonJsFunc.Alert(this, strMsg);
				return;

                //throw new clsDbObjException(strMsg);
			}
			if(strUserId=="")
			{
				strMsg = "�������û�����";
				clsCommonJsFunc.Alert(this, strMsg);
				return;
			}
			clsUsersEN objUser = new clsUsersEN(strUserId);
            try
            {
                clsUsersBL .GetUsers(ref objUser);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��¼�Զ����ɴ���ϵͳ���ɹ�!\r\n" + objException.Message;
                clsCommonJsFunc.Alert(this, clsCommonSession.seErrMessage);
                return;
                //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }
			if(strPassword != objUser.Password)
			{
				strMsg = "���벻��ȷ��";
				clsCommonJsFunc.Alert(this, strMsg);
				return;
//				throw new clsDbObjException(strMsg);
					
			}

            clsCommonSession.UserName = objUser.UserName;
			///���浱ǰ�û�ID
			Session.Add("objUser",objUser);
			Session.Add("UserId",objUser.UserId);
			//��ӵ�¼��־
			AddSysLogForLogin(strUserId);
			string strPrjId;
			///����Ĭ��ȱʡ����
            clsCommonSession.CurrPrjId = Entity.clsSysParaEN.CurrPrjId;

            //��鵱ǰ�û��м�����Ȩ����
            List<clsUserPrjGrantEN> arrUserPrjGrantObjList = clsUserPrjGrantBL.GetObjLst("UserId = '" + strUserId + "'");
			if (arrUserPrjGrantObjList.Count == 0)
			{
				strMsg = "��û�и�Ȩ���̣�����ϵϵͳ����Ա��";
				//					clsCommonJsFunc.Alert(this, strMsg);
				//					return;
				throw new clsDbObjException(strMsg);
			}
			else if (arrUserPrjGrantObjList.Count == 1)
			{
				clsUserPrjGrantEN objUserPrjGrant = (clsUserPrjGrantEN)arrUserPrjGrantObjList[0];
				strPrjId = objUserPrjGrant.PrjId;;
                
                WS_FieldName.autoCompleteWordList = null;
                WS_FieldName.strPrjId = objUserPrjGrant.PrjId;
                clsPubVar.CurrSelPrjId = strPrjId;

                clsCommonSession.RoleId = objUserPrjGrant.RoleId;
				Session.Add("PrjId",strPrjId);
				///����Ĭ�ϵ����ݿ�
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                if (objvUserDefaPrjDataBaseEN != null)
                {
                    clsPubVar.CurrPrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId;
                    new clsCommonSession().PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName;
                }
                else
                {
                    string strPrjDataBaseName;
                    string strDefaPrjDataBaseId = "";
                    string strCondition = string.Format("PrjId='{0}'", strPrjId);
                    clsProjectDatabaseRelEN objProjectDatabaseRelEN = clsProjectDatabaseRelBL.GetFirstObj_S(strCondition);
                    if (objProjectDatabaseRelEN == null)
                    {
                         strMsg = string.Format("���̣�{0}({1})û������������ݿ⣬�������Ա��ϵ��", objProject.PrjName, objProject.PrjId);

                         clsCommonJsFunc.Alert(this, strMsg);
                         return;
                    }
                    strDefaPrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                    clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(strPrjId, strUserId, strDefaPrjDataBaseId);
                    clsPubVar.CurrPrjDataBaseId = strDefaPrjDataBaseId;
                    clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                    clsPubVar.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                    strPrjDataBaseName = objPrjDataBase.DataBaseName;
                    Session.Add("PrjDataBaseName", strPrjDataBaseName);
                    new clsCommonSession().PrjDataBaseName = strPrjDataBaseName;
                }
                try
                {
                    clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(objProject.PrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                }
                catch (Exception objException)
                {
                    ErrorInformationBL.AddInformation("wfmSelectProject", "dgUserPrjGrant_SelectedIndexChanged", objException.Message, clsCommonSession.UserId);
                    clsCommonJsFunc.Alert(this, objException.Message);
                }

                Response.Redirect("~/Frame1/Admin/index.aspx");

    //            Response.Write("<script>alert('��½�ɹ���')</script>");
				//Response.Redirect("FrameSet.htm");
				return;
			}
			else 
			{
					
			}
			Response.Redirect("./wfmSelectProject.aspx", true);
			//			strPrjId = new clsUserDefaValueEx().getUserDefaValue(strCurrPrjId, objUser.UserId, "Ĭ�Ϲ���");
			//			Session.Add("PrjId",strPrjId);
			//			///����Ĭ�ϵ����ݿ�
			//			clsProjectsEN objProject = new clsProjectsEN(strPrjId, true);
			//			string strPrjDataBaseName;
			//			strPrjDataBaseName = objPrjDataBase.DataBaseName;
			//			Session.Add("PrjDataBaseName",strPrjDataBaseName);
			
			//�����־
		}

        private void Login(string strUserId, string strPassword)
        {

            string strMsg;
            string strTemp = strUserId.ToLower();
            int i = strTemp.IndexOf("or");
            int j = strTemp.IndexOf("'");

            if (i > 0 && j >= 0)
            {
                strMsg = "��������ȷ���û�����";
                clsCommonJsFunc.Alert(this, strMsg);
                return;

                //throw new clsDbObjException(strMsg);
            }
            if (strUserId == "")
            {
                strMsg = "�������û�����";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            stuLoginPara objLoginPara = new stuLoginPara()
            {
                LoginName = strUserId,
                UserPassword = strPassword,
                EffectiveDate = clsDateTime.getTodayStr(0),
            QxPrjId = clsPubVar.CurrPrjId
            };

            //if (strValidateCode != strValidateCode4Session)
            //{
            //    clsCommonJsFunc.Alert(this, "��У�벻��ȷ��");
            //    return;
            //}
            if (strUserId == "")
            {
                clsCommonJsFunc.Alert(this, "�������û�����");
                return;
            }
                bool bolResult = false;
            try
            {
                bolResult = clsLoginWApi.UserLogin(objLoginPara);
            }
            catch(Exception objException)
            {
                strMsg = string.Format("�û���֤��������{0}. ��֤��ַ:{1}.(In {2})", 
                    objException.Message, 
                    clsSysPara4WebApi_GP.strCurrIPAddressAndPort,
                    clsStackTrace.GetCurrClassFunction());
                clsPubVar.objLog.WriteDebugLog(strMsg);
                try
                {
                    clsSysPara4WebApi_GP.strCurrIPAddressAndPort = clsMyConfig.CurrIPAddressAndPortBackup;// "202.121.63.9";
                    clsSysPara4WebApi_GP.strCurrPrx = clsMyConfig.CurrPrxWA;// "GP_SHNU_WS";
                    bolResult = clsLoginWApi.UserLogin(objLoginPara);
                    clsSpecSQLforSql.IsUseBackupConnect = true;
                }
                catch(Exception objException2)
                {
                    strMsg = string.Format("�û���֤�ٴγ�������{0}. ������֤��ַ:{1}.(In {2})",
          objException2.Message,
          clsSysPara4WebApi_GP.strCurrIPAddressAndPort,
          clsStackTrace.GetCurrClassFunction());
                    clsPubVar.objLog.WriteDebugLog(strMsg);

                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            if (bolResult == false)
            {
                clsCommonJsFunc.Alert(this, "�û������������");
                return;
            }


            //if (strPassword != objUser.Password)
            //{
            //    strMsg = "���벻��ȷ��";
            //    clsCommonJsFunc.Alert(this, strMsg);
            //    return;
            //    //				throw new clsDbObjException(strMsg);

            //}

            clsQxUsersEN objQxUsers = clsQxUsersWApi.GetObjByUserId(strUserId);
            clsCommonSession.UserName = objQxUsers.UserName;
            ///���浱ǰ�û�ID
            Session.Add("objUser", objQxUsers);
            Session.Add("UserId", objQxUsers.UserId);
            //��ӵ�¼��־
            AddSysLogForLogin(strUserId);
            string strPrjId;
            ///����Ĭ��ȱʡ����
            clsCommonSession.CurrPrjId = Entity.clsSysParaEN.CurrPrjId;

            //��鵱ǰ�û��м�����Ȩ����
            List<clsUserPrjGrantEN> arrUserPrjGrantObjList = clsUserPrjGrantBL.GetObjLst("UserId = '" + strUserId + "'");
            if (arrUserPrjGrantObjList.Count == 0)
            {
                strMsg = "��û�и�Ȩ���̣�����ϵϵͳ����Ա��";
                //					clsCommonJsFunc.Alert(this, strMsg);
                //					return;
                throw new clsDbObjException(strMsg);
            }
            else if (arrUserPrjGrantObjList.Count == 1)
            {
                clsUserPrjGrantEN objUserPrjGrant = (clsUserPrjGrantEN)arrUserPrjGrantObjList[0];
                strPrjId = objUserPrjGrant.PrjId; ;

                WS_FieldName.autoCompleteWordList = null;
                WS_FieldName.strPrjId = objUserPrjGrant.PrjId;
                clsPubVar.CurrSelPrjId = strPrjId;

                clsCommonSession.RoleId = objUserPrjGrant.RoleId;
                Session.Add("PrjId", strPrjId);
                ///����Ĭ�ϵ����ݿ�
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                if (objvUserDefaPrjDataBaseEN != null)
                {
                    clsPubVar.CurrPrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId;
                    new clsCommonSession().PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName;
                }
                else
                {
                    string strPrjDataBaseName;
                    string strDefaPrjDataBaseId = "";
                    string strCondition = string.Format("PrjId='{0}'", strPrjId);
                    clsProjectDatabaseRelEN objProjectDatabaseRelEN = clsProjectDatabaseRelBL.GetFirstObj_S(strCondition);
                    if (objProjectDatabaseRelEN == null)
                    {
                        strMsg = string.Format("���̣�{0}({1})û������������ݿ⣬�������Ա��ϵ��", objProject.PrjName, objProject.PrjId);

                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    strDefaPrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                    clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(strPrjId, strUserId, strDefaPrjDataBaseId);
                    clsPubVar.CurrPrjDataBaseId = strDefaPrjDataBaseId;
                    clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                    clsPubVar.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                    strPrjDataBaseName = objPrjDataBase.DataBaseName;
                    Session.Add("PrjDataBaseName", strPrjDataBaseName);
                    new clsCommonSession().PrjDataBaseName = strPrjDataBaseName;
                }
                try
                {
                    clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(objProject.PrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                }
                catch (Exception objException)
                {
                    ErrorInformationBL.AddInformation("wfmSelectProject", "dgUserPrjGrant_SelectedIndexChanged", objException.Message, clsCommonSession.UserId);
                    clsCommonJsFunc.Alert(this, objException.Message);
                }

                Response.Redirect("~/Frame1/Admin/index.aspx");

                //            Response.Write("<script>alert('��½�ɹ���')</script>");
                //Response.Redirect("FrameSet.htm");
                return;
            }
            else
            {

            }
            Response.Redirect("./wfmSelectProject.aspx", true);
            //			strPrjId = new clsUserDefaValueEx().getUserDefaValue(strCurrPrjId, objUser.UserId, "Ĭ�Ϲ���");
            //			Session.Add("PrjId",strPrjId);
            //			///����Ĭ�ϵ����ݿ�
            //			clsProjectsEN objProject = new clsProjectsEN(strPrjId, true);
            //			string strPrjDataBaseName;
            //			strPrjDataBaseName = objPrjDataBase.DataBaseName;
            //			Session.Add("PrjDataBaseName",strPrjDataBaseName);

            //�����־
        }

        protected void lbFileDown_Click(object sender, EventArgs e)
        {
            string c1 = "<script language='javascript'>window.open('./Webform/DownLoad/wfmDownLoadClsFile.aspx','FileDown'); </script>";
            Response.Write(c1);
        }

        protected void lbRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webform/UserManage/wfmRegister.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserId, strPassword;
            strUserId = txtUid.Text.Trim();
            strPassword = txtPassWord.Text;
            Login(strUserId, strPassword);
        }
        #region ����ҳ����Ϣ�Լ���ת������ҳ��

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    
                    
                    //{
                    
                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// ��ת������ҳ��
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion ����ҳ����Ϣ

        /// <summary>
        /// ����:��ǰҳ������
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}
