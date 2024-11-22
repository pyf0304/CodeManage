using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AgcCommBase;
using System.Reflection;
using AGC.PureClass;
using AGC.PureClassEx;
using System.Linq;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �����㡣����:
    ///					1)���¼����ӡ�
    ///					2)���¼��ɾ��
    ///					3)���¼���޸�
    ///					4)���¼�Ĳ�ѯ
    ///					5)��ȡĳЩ���¼���й��ֶ�����
    ///					6)���ñ��¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ��������һЩͨ�ò���
    /// </summary>
    partial class AppViewUTScript4Swift4 : AppController4Swift4Base
    {


        #region ���캯��

        public AppViewUTScript4Swift4()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AppViewUTScript4Swift4(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion

       
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            ISOButtonEx objISOButton_Temp = null; ///��ʱ����;

          
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "sb" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".storyboard";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".storyboard";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //    //������ʼ
                ISOstoryBoardEx objISOstoryBoardEN = new ISOstoryBoardEx();
                ISOsceneEx objISOsceneEN = new ISOsceneEx();
                objISOsceneEN.Text = string.Format("{0}-��Ԫ����", objPrjTabENEx.TabName);

                objISOstoryBoardEN.arrSubIsoControlLst2.Add(objISOsceneEN);

                ISOviewControllerEx objISOviewControllerEN = new ISOviewControllerEx();
                string strViewControllerID = AgcCommBase.AgcPubFun.getSwiftID();
                objISOviewControllerEN.IsoControlId = strViewControllerID;
                objISOviewControllerEN.customClass = string.Format("vc{0}_UTScript", objPrjTabENEx.TabName);
                objISOviewControllerEN.customModule = objProject.IsoPrjName;//

                objISOsceneEN.arrSubIsoControlLst2.Add(objISOviewControllerEN);

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Top = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Top.type = "top";
              
                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Bottom = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Bottom.type = "bottom";
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Top);
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Bottom);
                ISOviewEx objISOviewEN = new ISOviewEx();
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewEN);
                ISOStackViewEx objISOStackViewEN = new ISOStackViewEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOStackViewEN);
                int intY = 0;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_DefButton") > 0)
                    {
                        objISOButton_Temp = A_GeneFuncCode_Swift4_DefButton(strFuncName, strViewControllerID, ref intY);
                        objISOStackViewEN.arrSubIsoControlLst2.Add(objISOButton_Temp);
                    }
                }
                ISOlabelEx objISOlabelEN = new ISOlabelEx();
                objISOlabelEN.Text = "���";
                objISOlabelEN.x = 10;
                objISOlabelEN.y = 550;
                objISOlabelEN.Width = 50;
                objISOlabelEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOlabelEN);

                ISOtextFieldEx objISOtextFieldEN = new ISOtextFieldEx();
                objISOtextFieldEN.x = 60;
                objISOtextFieldEN.y = 550;
                objISOtextFieldEN.Width = 150;
                objISOtextFieldEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOtextFieldEN);
                ISOnavigationBarEx objISOnavigationBarEN = new ISOnavigationBarEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOnavigationBarEN);

                ISONavigationItemEx objISOnavigationItemEN = new ISONavigationItemEx();
                objISOnavigationItemEN.Text = string.Format("{0}-��Ԫ����", objPrjTabENEx.TabName);

                objISOnavigationBarEN.arrSubIsoControlLst2.Add(objISOnavigationItemEN);

                ISOBarButtonItemEx objISOBarButtonItemEN = new ISOBarButtonItemEx();
                objISOBarButtonItemEN.mKey = "leftBarButtonItem";

                objISOnavigationItemEN.arrSubIsoControlLst2.Add(objISOBarButtonItemEN);
                ISOButtonEx objISOButtonEN = GetISOButton4NavigitionBar_Swift4("����", 
                    objISOviewControllerEN.IsoControlId, "btnReturnMainPage_Click");
                //ISOButtonEx objISOButtonEN =  new ISOButtonEx();
                //objISOButtonEN.Text = "����";
                //objISOButtonEN.IsoControlName = "ReturnMainPage";
                //objISOButtonEN.x = 16;
                //objISOButtonEN.y = 7;

                //objISOButtonEN.Width = 30;
                //objISOButtonEN.Height = 30;
                objISOBarButtonItemEN.arrSubIsoControlLst2.Add(objISOButtonEN);

                //    strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                ISOOutletEx objISOOutletEN = new ISOOutletEx();
                objISOOutletEN.property = "txtResult";
                objISOOutletEN.destination = objISOtextFieldEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN);

                ISOOutletEx objISOOutletEN2 = new ISOOutletEx();
                objISOOutletEN2.property = "lblResult";
                objISOOutletEN2.destination = objISOlabelEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN2);

                objISOstoryBoardEN.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);             

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

     
     
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppViewUTScript4Swift4);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("sb{0}_UTScript", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
