using System;
using System.Collections;
using System.Text;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.common;
using System.Linq;

namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsFuncModuleEx ��ժҪ˵����
	/// </summary>
	public partial class clsFuncModule_AgcBLEx: clsFuncModule_AgcBL
    {
        ///// <summary>
        ///// ����ģ������б�
        ///// </summary>
        //public  static List<clsvFuncModule_AgcEN> arrvFuncModuleObjLst = null;// clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
       
      
		/// <summary>
		/// ����:��Դ���̵Ķ�������Ƶ��¹�����,ͬʱ������Щ������ص��ֶΡ�
		/// </summary>
		/// <param name = "strSouPrjId"></param>
		/// <param name = "strTarPrjId"></param>
		/// <param name = "arrSouObjId"></param>
		/// <returns></returns>
        public static bool CopyFuncModule(string strSouPrjId, string strTarPrjId, List<string> arrSouFuncModuleId, string strUserId)
		{
			//��������:
			//1����Դ�����е�Դ�����б���б���,Ȼ��������е�ÿ������ID���в���
			//2������<����ID>��ȡ��������
			//3�����ݵ�ǰ����ID������<������>����Ƿ���Ŀ�깤���д�����ͬ��<������>��
			//       ���������ͬ��<������>�ͷ����ö�����,����Ҫ���ơ�
			//4���ѵ�ǰ������ ���¹����С�
			//    4.1 ��Ŀ�깤�����½�һ������
			//    4.2 �ѵ�ǰ��������Զ����Ƶ��½��Ķ�����
			//5����ȡ��ǰ���������ֶ��б�
			//6���Ըñ����ѭ��,���ֶ�ID(Դ�ֶ�ID)���뵽һ��ArrayList
			//7��������Դ�ֶ�ID�б��Դ�����и��Ƶ�Ŀ�깤����,ͬʱ��ȡһ����뵽Ŀ�깤���е��ֶ�ID�б�
			//8���ѻ�ȡ��һ�����ֶ�ID�б����¶���ID������ϵ
			///

			clsFuncModule_AgcEN objSouFuncModule = null;
			clsFuncModule_AgcEN objNewFuncModule = null;
			string strNewclsFuncModuleId;
			//1����Դ�����е�Դ�����б���б���,Ȼ��������е�ÿ������ID���в���
			foreach (string  strSouFuncModuleId in arrSouFuncModuleId)
			{
				//2������<����ID>��ȡ��������
                objSouFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strSouFuncModuleId, strSouPrjId);
				//3�����ݵ�ǰ����ID������<������>����Ƿ���Ŀ�깤���д�����ͬ��<������>��
				//       ���������ͬ��<������>�ͷ����ö�����,����Ҫ���ơ�
                if (clsFuncModule_AgcBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and FuncModuleName = '" + objSouFuncModule.FuncModuleName + "'")  ==  true)
				{
					continue;
				}
				//4���ѵ�ǰ������ ���¹����С�
				//    4.1 ��Ŀ�깤�����½�һ������
				strNewclsFuncModuleId = clsGeneralTab.GetMaxStrId("FuncModule_Agc", "FuncModuleAgcId", 8, strTarPrjId);
				objNewFuncModule = new clsFuncModule_AgcEN(strNewclsFuncModuleId);
				//    4.2 �ѵ�ǰ��������Զ����Ƶ��½��Ķ�����
				objNewFuncModule.PrjId = strTarPrjId;
				objNewFuncModule.FuncModuleName = objSouFuncModule.FuncModuleName;
				objNewFuncModule.Memo = objSouFuncModule.Memo;
                if (clsFuncModule_AgcBL.AddNewRecordBySql2(objNewFuncModule)  ==  false)
				{
					return false;
				}
				else
				{
					//					strResult = "��Ӽ�¼�ɹ�!";
				}
			}
			return true;
		}
        /// <summary>
        /// ����:��Դ���̵Ķ�������Ƶ��¹�����,ͬʱ������Щ������ص��ֶΡ�
        /// </summary>
        /// <param name = "strSouPrjId">Դ����Id</param>
        /// <param name = "strTarPrjId">Ŀ�깤��Id</param>
        /// <param name = "strUserId">�����û�Id</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public static bool CopyFuncModule(string strSouPrjId, string strTarPrjId, string strUserId)
        {
            //��������:
            //1����Դ�����е�Դ�����б���б���,Ȼ��������е�ÿ������ID���в���
            //2������<����ID>��ȡ��������
            //3�����ݵ�ǰ����ID������<������>����Ƿ���Ŀ�깤���д�����ͬ��<������>��
            //       ���������ͬ��<������>�ͷ����ö�����,����Ҫ���ơ�
            //4���ѵ�ǰ������ ���¹����С�
            //    4.1 ��Ŀ�깤�����½�һ������
            //    4.2 �ѵ�ǰ��������Զ����Ƶ��½��Ķ�����
            //5����ȡ��ǰ���������ֶ��б�
            //6���Ըñ����ѭ��,���ֶ�ID(Դ�ֶ�ID)���뵽һ��ArrayList
            //7��������Դ�ֶ�ID�б��Դ�����и��Ƶ�Ŀ�깤����,ͬʱ��ȡһ����뵽Ŀ�깤���е��ֶ�ID�б�
            //8���ѻ�ȡ��һ�����ֶ�ID�б����¶���ID������ϵ
                   
            string strCondition = string.Format("PrjId = '{0}'", strSouPrjId);
            List<clsFuncModule_AgcEN> arrFuncModuleObjLst = clsFuncModule_AgcBL.GetObjLst(strCondition);
            string strNewclsFuncModuleId;
            //1����Դ�����е�Դ�����б���б���,Ȼ��������е�ÿ������ID���в���
            foreach (clsFuncModule_AgcEN objFuncModule_S in arrFuncModuleObjLst)
            {
                //2������<����ID>��ȡ��������
                //objSouFuncModule = new clsFuncModule_AgcEN(strSouFuncModuleId, true);
                //3�����ݵ�ǰ����ID������<������>����Ƿ���Ŀ�깤���д�����ͬ��<������>��
                //       ���������ͬ��<������>�ͷ����ö�����,����Ҫ���ơ�
                if (clsFuncModule_AgcBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and FuncModuleName = '" + objFuncModule_S.FuncModuleName + "'")  ==  true)
                {
                    continue;
                }
                //4���ѵ�ǰ������ ���¹����С�
                //    4.1 ��Ŀ�깤�����½�һ������
                strNewclsFuncModuleId = clsGeneralTab.GetMaxStrId("FuncModule_Agc", "FuncModuleAgcId", 8, strTarPrjId);
                objFuncModule_S.FuncModuleAgcId = strNewclsFuncModuleId;
                objFuncModule_S.PrjId = strTarPrjId;
                objFuncModule_S.UpdUser = strUserId;
                objFuncModule_S.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();

                if (clsFuncModule_AgcBL.AddNewRecordBySql2(objFuncModule_S)  ==  false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// �󶨻���Web��������
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">��Ҫ�󶨵�ǰ���������</param>
        /// <param name = "strPrjId">����ID</param>
        public static void BindDdl_FuncModuleAgcIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //Ϊ����Դ�ڱ����������������
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("ѡ[����ģ��_Agc]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conFuncModule_Agc.FuncModuleAgcId);
            IEnumerable<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcBL.GetObjLstCache(strPrjId);// strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
            objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}
