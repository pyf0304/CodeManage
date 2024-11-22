using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

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
    partial class AppViewUnitTest_UDF4JAVA : clsGeneCodeBase
    {



        #region ���캯��

        public AppViewUnitTest_UDF4JAVA()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AppViewUnitTest_UDF4JAVA(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


         

        /// <summary>
        /// ����Ddl���ļ����� 
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_DdlBind(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            //���û���������;
            
            string strClassFName;
            
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("����Ҫ�����ļ�����ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("����Ҫ�����ļ�����ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            objPrjTabENEx.ClsName = "ddlBind" + objPrjTabENEx.TabName;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".java";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".java";

            objPrjTabENEx.FileName = strClassFName;

            string strTextFieldName = "";
            string strValueFieldName = "";

            ///���ɽ��б���;
            //��0��:�ѿؼ���������ComboBoxת����ComboBox
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (string.IsNullOrEmpty(strValueFieldName) == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "//����Ҫ�����ļ�����[{0}]�Ĺؼ��ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strCodeForCs.ToString());
                throw new Exception(strCodeForCs.ToString());
                //return strCodeForCs.ToString();

            }
            if (string.IsNullOrEmpty(strTextFieldName) == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "//����Ҫ�����ļ�����[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strCodeForCs.ToString());
                throw new Exception(strCodeForCs.ToString());
                //return strCodeForCs.ToString();
            }

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);          

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L51_AppBusiness.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.os.Message;");
                strCodeForCs.Append("\r\n" + "import android.os.Handler;");
                strCodeForCs.Append("\r\n" + "import android.widget.Spinner;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");

                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsDate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName,
                                    objPrjTabENEx.TabName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsParentObjDelegate;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //

                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                //strCodeForCs.AppendFormat("\r\n" + "public class  {1} extends ac{0}_UnitTest",
                //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "public class  {1}",
                    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "  public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "private Spinner mspnObject = null;");
                strCodeForCs.AppendFormat("\r\n" + "private ddlAdapter{0} mobjDdlAdapter{0} = null;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "private Activity macPage = null;");
                strCodeForCs.Append("\r\n" + "private clsParentObjDelegate mobjParentObjDelegate = null;");
                strCodeForCs.AppendFormat("\r\n" + "public {0}(clsParentObjDelegate objParentObjDelegate)",
                    objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "mobjParentObjDelegate = objParentObjDelegate;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "public ddlAdapter{0} getDdlAdapter{0}()",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return mobjDdlAdapter{0};",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + Gen_Controller_Java_BindDdl(objPrjTabENEx.TabName, strValueFieldName, strTextFieldName));

                strCodeForCs.Append("\r\n" + Gen_Controller_Java_GetJSONObjLst4DdlBind(objPrjTabENEx.TabName, strValueFieldName, strTextFieldName));
              //  strCodeForCs.Append("\r\n" + Gen_Controller_Java_SendMessage(objPrjTabENEx.TabName, strValueFieldName, strTextFieldName));

                


                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Ddl���ļ����� 
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_DdlAdapter(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            //���û���������;

            string strClassFName;

            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("����Ҫ�����ļ�����ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("����Ҫ�����ļ�����ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            objPrjTabENEx.ClsName = "ddlAdapter" + objPrjTabENEx.TabName;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".java";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".java";

            objPrjTabENEx.FileName = strClassFName;

            string strTextFieldName = "";
            string strValueFieldName = "";

            ///���ɽ��б���;
            //��0��:�ѿؼ���������ComboBoxת����ComboBox
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (string.IsNullOrEmpty(strValueFieldName) == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "//����Ҫ�����ļ�����[{0}]�Ĺؼ��ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strCodeForCs.ToString());
                throw new Exception(strCodeForCs.ToString());

                //return strCodeForCs.ToString();

            }
            if (string.IsNullOrEmpty(strTextFieldName) == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "//����Ҫ�����ļ�����[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strCodeForCs.ToString());
                throw new Exception(strCodeForCs.ToString());

                //return strCodeForCs.ToString();
            }

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);



            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L51_AppBusiness.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.content.Context;");
                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.os.Message;");
                strCodeForCs.Append("\r\n" + "import android.os.Handler;");
                strCodeForCs.Append("\r\n" + "import android.view.LayoutInflater;");
                strCodeForCs.Append("\r\n" + "import android.view.ViewGroup;");
                strCodeForCs.Append("\r\n" + "import android.widget.BaseAdapter;");
                strCodeForCs.Append("\r\n" + "import android.widget.Spinner;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + " import com.taishsoft.R;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsDate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName,
                                    objPrjTabENEx.TabName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //

                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {1} extends BaseAdapter",
                    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{"); 
                strCodeForCs.AppendFormat("\r\n" + "private List<cls{0}EN> mList;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "private Context mContext;");

                strCodeForCs.AppendFormat("\r\n" + "public ddlAdapter{0}(Context pContext, List<cls{0}EN> pList)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.mContext = pContext;");
                strCodeForCs.Append("\r\n" + "this.mList = pList;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public int getCount()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return mList.size();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public Object getItem(int position)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return mList.get(position);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public long getItemId(int position)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return position;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "public String get{0}(int position)",
                    strValueFieldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = mList.get(position);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.get{1}();",
                    objPrjTabENEx.TabName, strValueFieldName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* ��������Ҫ����");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public View getView(int position, View convertView, ViewGroup parent)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "LayoutInflater _LayoutInflater = LayoutInflater.from(mContext);");
                strCodeForCs.Append("\r\n" + "convertView = _LayoutInflater.inflate(R.layout.ddlitem_style, null);");
                strCodeForCs.Append("\r\n" + "if (convertView != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//            ImageView imageView = (ImageView)convertView.findViewById(R.id.image);");
                strCodeForCs.Append("\r\n" + "//            imageView.setImageResource(R.drawable.ic_launcher);");
                strCodeForCs.Append("\r\n" + "TextView txtDdlValue = (TextView)convertView.findViewById(R.id.txtDdlValue);");
                strCodeForCs.Append("\r\n" + "TextView txtDdlText = (TextView)convertView.findViewById(R.id.txtDdlText);");
                strCodeForCs.AppendFormat("\r\n" + "txtDdlValue.setText(mList.get(position).get{0}());",
                    strValueFieldName);
                strCodeForCs.AppendFormat("\r\n" + "txtDdlText.setText(mList.get(position).get{0}());",
                    strTextFieldName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return convertView;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "ac" + objWebSrvClassENEx.ClsName + "4SD_UnitTest";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L6_AppViewUnitTest.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                //    objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}4SD_Controller;",
                    objProjectsENEx.JavaPackageName,
                      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.{1}WS4SDController;",
                    objProjectsENEx.JavaPackageName,
                      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                //    objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //

                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //

                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class ac{0}4SD_UnitTest extends Activity",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "private TextView tvMsg;");
                List<string> arrValueLst = new List<string>();
                //Ϊ���еĺ������尴ť
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = GC_DeclareCtrlVar4FuncPara(objWebSrvFunctionsENEx, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "//Ϊ����[{0}]�Ĳ�����������ؼ���", objWebSrvFunctionsENEx.FunctionName);
                            strCodeForCs.Append(strTemp + "\r\n");
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //�������еĺ���
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Java_btnClickByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
               
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

      
        /// <summary>
        /// �����Զ���WS�����̨����
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_SelfDefWs4UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "ac" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            string strXmlFileName = "ac_" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            strXmlFileName = strXmlFileName.ToLower();
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("UT_{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.L7_UI.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.net.Uri;");
                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + "import android.widget.Button;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import com.taishsoft.R;");

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                //    objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.{1}WS4SDController;",
                    objProjectsENEx.JavaPackageName,
                      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}4SD_Controller;",
                    objProjectsENEx.JavaPackageName,
                      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //

                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //

                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} extends Activity",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "  private TextView tvMsg;");


                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "protected void onCreate(Bundle savedInstanceState)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.onCreate(savedInstanceState);");
                string strLayOut = string.Format("{0}", strXmlFileName).ToLower();
                strCodeForCs.AppendFormat("\r\n" + "setContentView(R.layout.{0});", strLayOut);

                strCodeForCs.Append("\r\n" + "tvMsg = (TextView)findViewById(R.id.tvMsg);");

          
                strCodeForCs.Append("\r\n" + "}");

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Java_btnClickByCommonFunction(objWebSrvFunctionsENEx);
                        string strSource = string.Format("ac{0}4SD_UnitTest", objWebSrvClassENEx.ClsName);
                        string strTarget = string.Format("ac{0}4SD_UTScript", objWebSrvClassENEx.ClsName);

                        strTemp = strTemp.Replace(strSource, strTarget);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
               

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �����Զ���WS�����̨����,ͨ��TabHost
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_SelfDefWs4UTScriptCSByTabHost(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "ac" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            string strXmlFileName = "ac_" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            strXmlFileName = strXmlFileName.ToLower();
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("UT_{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.L7_UI.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.net.Uri;");
                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + "import android.widget.Button;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.widget.TabHost;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import com.taishsoft.R;");

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                //    objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.{1}WS4SDController;",
                    objProjectsENEx.JavaPackageName,
                      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}4SD_Controller;",
                    objProjectsENEx.JavaPackageName,
                      objWebSrvClassENEx.ClsName, objFuncModule.FuncModuleEnName4GC()); //

                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //

                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} extends Activity",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "  private TextView tvMsg;");
                strCodeForCs.Append("\r\n" + "private TabHost tabHost;");

                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = GC_DeclareCtrlVar4FuncPara(objWebSrvFunctionsENEx, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "//Ϊ����[{0}]�Ĳ�����������ؼ���", objWebSrvFunctionsENEx.FunctionName);
                            strCodeForCs.Append(strTemp + "\r\n");
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                
                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "protected void onCreate(Bundle savedInstanceState)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.onCreate(savedInstanceState);");
                string strLayOut = string.Format("{0}", strXmlFileName).ToLower();
                strCodeForCs.AppendFormat("\r\n" + "setContentView(R.layout.{0});", strLayOut);

                strCodeForCs.Append("\r\n" + "tvMsg = (TextView)findViewById(R.id.tvMsg);");
                //setSupportActionBar(toolbar);
                strCodeForCs.Append("\r\n" + "tabHost = (TabHost)findViewById(R.id.tabHost);");
                strCodeForCs.Append("\r\n" + "tabHost.setup();");

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strCodeForCs.AppendFormat("\r\n" + "tabHost.addTab(tabHost.newTabSpec(\"tab{0}\").setIndicator(\"{1}\").setContent(R.id.tab{0}));",
                          objWebSrvFunctionsENEx.FunctionName,
                          objWebSrvFunctionsENEx.FunctionName);

                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //Ϊ�����Ĳ�������ؼ����а�
                arrValueLst = new List<string>();
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = GC_BindCtrlVar4FuncPara(objWebSrvFunctionsENEx, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "//Ϊ����[{0}]�������������ؼ����а󶨣�", objWebSrvFunctionsENEx.FunctionName);
                            strCodeForCs.Append(strTemp + "\r\n");
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
               
                strCodeForCs.Append("\r\n" + "}");

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Java_btnClickByCommonFunction(objWebSrvFunctionsENEx);
                        string strSource = string.Format("ac{0}4SD_UnitTest", objWebSrvClassENEx.ClsName);
                        string strTarget = string.Format("ac{0}4SD_UTScript", objWebSrvClassENEx.ClsName);

                        strTemp = strTemp.Replace(strSource, strTarget);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
              

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        
        private AndroidLinearLayoutEx GetLinearLayout4Function1(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
            objAndroidLinearLayoutENEx.CtrlId = string.Format("tab{0}",
                objvFunction4GeneCodeEN.FuncName4Code);

            objAndroidLinearLayoutENEx.layout_width = "match_parent";
            objAndroidLinearLayoutENEx.layout_height = "match_parent";
            objAndroidLinearLayoutENEx.orientation = "vertical";



            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objvFunction4GeneCodeEN.FuncName4Code);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objvFunction4GeneCodeEN.FuncName4Code); ;
            objAndroidButtonENEx.Text = objvFunction4GeneCodeEN.FuncCHName4Code;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
            objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidLinearLayoutENEx;
        }

        private AndroidConstraintLayoutEx GetConstraintLayout4Function(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
            List<string> arrValueLst)
        {
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("tab{0}",
                objvFunction4GeneCodeEN.FuncName4Code);

            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "match_parent";
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
                clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            string strMsg = "";
            bool bolIsFirstPara = true;//�Ƿ��ǵ�һ������
            string strLastParaName = "";
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {

                    }
                    else
                    {
                        string strParaName_New = clsString.GetUniqueStrValue_S(objFuncPara4CodeEN.ParaName, arrValueLst);
                        arrValueLst.Add(strParaName_New);
                        AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                        objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", strParaName_New);
                        objAndroidTextViewENEx.Text = string.Format("{0}:", objFuncPara4CodeEN.ParaName);
                        objAndroidTextViewENEx.layout_width = "wrap_content";
                        objAndroidTextViewENEx.layout_height = "wrap_content";
                        objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                        if (bolIsFirstPara == true)
                        {
                            objAndroidTextViewENEx.layout_marginTop = 8;

                            objAndroidTextViewENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                        }
                        else
                        {
                            objAndroidTextViewENEx.layout_marginTop = 16 + 8;

                            objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
                        }
                        objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                        AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                        objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", strParaName_New);
                        //  objAndroidEditTextENEx.Text = "����Add";
                        objAndroidEditTextENEx.layout_width = "wrap_content";
                        objAndroidEditTextENEx.layout_height = "wrap_content";
                        objAndroidEditTextENEx.layout_marginLeft = 8;
                        objAndroidEditTextENEx.layout_constraintLeft_toRightOf = string.Format("@+id/lbl{0}", strParaName_New);
                        if (bolIsFirstPara == true)
                        {
                            objAndroidEditTextENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                        }
                        else
                        {
                            objAndroidEditTextENEx.layout_marginTop = 16;

                            objAndroidEditTextENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);

                        }
                        objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);

                        strLastParaName = strParaName_New;
                        bolIsFirstPara = false;
                    }
                }
            }
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objvFunction4GeneCodeEN.FuncName4Code);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objvFunction4GeneCodeEN.FuncName4Code); ;
            objAndroidButtonENEx.Text = objvFunction4GeneCodeEN.FuncCHName4Code;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            if (string.IsNullOrEmpty(strLastParaName) == true)
            {
                objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";
            }
            else
            {
                objAndroidButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
            }
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidConstraintLayoutENEx);
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidConstraintLayoutENEx;
        }


        private AndroidLinearLayoutEx GetLinearLayout4Function4SelfDefWs1(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
            objAndroidLinearLayoutENEx.CtrlId = string.Format("tab{0}",
                objWebSrvFunctionsENEx.FunctionName);

            objAndroidLinearLayoutENEx.layout_width = "match_parent";
            objAndroidLinearLayoutENEx.layout_height = "match_parent";
            objAndroidLinearLayoutENEx.orientation = "vertical";
            string strMsg = "";
            bool bolIsFirstPara = true;//�Ƿ��ǵ�һ������
            string strLastParaName = "";
            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    //strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
                    //    objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    //if (objSelfDefDataTypeEN_Para != null)
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    //}
                    //sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", objWebSrvFuncParaEN.ParaName);
                    objAndroidTextViewENEx.Text = objWebSrvFuncParaEN.ParaName;
                    objAndroidTextViewENEx.layout_width = "wrap_content";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                    if (bolIsFirstPara == true)
                    {
                        objAndroidTextViewENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
                    }
                    objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", objWebSrvFuncParaEN.ParaName);
                    //  objAndroidEditTextENEx.Text = "����Add";
                    objAndroidEditTextENEx.layout_width = "wrap_content";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.layout_constraintLeft_toRightOf = string.Format("lbl{0}", objWebSrvFuncParaEN.ParaName);
                    if (bolIsFirstPara == true)
                    {
                        objAndroidEditTextENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidEditTextENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);

                    }
                    objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);

                    strLastParaName = objWebSrvFuncParaEN.ParaName;

                }
            }
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
            objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidLinearLayoutENEx;
        }
        private AndroidConstraintLayoutEx GetConstraintLayout4Function4SelfDefWs(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
            List<string> arrValueLst)
        {
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("tab{0}",
                objWebSrvFunctionsENEx.FunctionName);

            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "match_parent";
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            bool bolIsFirstPara = true;//�Ƿ��ǵ�һ������
            string strLastParaName = "";
            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    //strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
                    //    objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    //if (objSelfDefDataTypeEN_Para != null)
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    //}
                    //sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    arrValueLst.Add(strParaName_New);
                    AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", strParaName_New);
                    objAndroidTextViewENEx.Text = string.Format("{0}:", objWebSrvFuncParaEN.ParaName);
                    objAndroidTextViewENEx.layout_width = "wrap_content";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                    if (bolIsFirstPara == true)
                    {
                        objAndroidTextViewENEx.layout_marginTop = 8;

                        objAndroidTextViewENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_marginTop = 16 + 8;

                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
                    }
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", strParaName_New);
                    //  objAndroidEditTextENEx.Text = "����Add";
                    objAndroidEditTextENEx.layout_width = "wrap_content";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.layout_marginLeft = 8;
                    objAndroidEditTextENEx.layout_constraintLeft_toRightOf = string.Format("@+id/lbl{0}", strParaName_New);
                    if (bolIsFirstPara == true)
                    {
                        objAndroidEditTextENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidEditTextENEx.layout_marginTop = 16;

                        objAndroidEditTextENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);

                    }
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);

                    strLastParaName = strParaName_New;
                    bolIsFirstPara = false;
                }
            }
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.layout_marginTop = 16;

            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            if (string.IsNullOrEmpty(strLastParaName) == true)
            {
                objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";
            }
            else
            {
                objAndroidButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
            }
            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidConstraintLayoutENEx;
        }
        private string GC_DeclareCtrlVar4FuncPara(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
            List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                }
                else
                {
                    string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    arrValueLst.Add(strParaName_New);
                    objWebSrvFuncParaEN._StrTag = strParaName_New;
                    sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                }
            }
            return sbCode.ToString();
        }

        private string GC_DeclareCtrlVar4FuncPara(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
       List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
               clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {

                    }
                    else
                    {
                        string strParaName_New = clsString.GetUniqueStrValue_S(objFuncPara4CodeEN.ParaName, arrValueLst);
                        arrValueLst.Add(strParaName_New);
                        objFuncPara4CodeEN._StrTag = strParaName_New;
                        sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                    }
                }
            }
            return sbCode.ToString();
        }
        private string GC_BindCtrlVar4FuncPara(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
         List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                }
                else
                {
                    string strParaName_New = objWebSrvFuncParaEN._StrTag;
                    //string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    //arrValueLst.Add(strParaName_New);
                    //objWebSrvFuncParaEN._StrTag = strParaName_New;
                    sbCode.AppendFormat("\r\n" + "txt{0} = (EditText)findViewById(R.id.txt{0});", strParaName_New);
                }
            }
            return sbCode.ToString();
        }

        private string GC_BindCtrlVar4FuncPara(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
    List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {

                    }
                    else
                    {
                        string strParaName_New = objFuncPara4CodeEN._StrTag;
                        //string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                        //arrValueLst.Add(strParaName_New);
                        //objWebSrvFuncParaEN._StrTag = strParaName_New;
                        sbCode.AppendFormat("\r\n" + "txt{0} = (EditText)findViewById(R.id.txt{0});", strParaName_New);
                    }
                }
            }
            return sbCode.ToString();
        }
        /// <summary>
        /// �����Զ���WS��App����ű�
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_SelfDefWs4UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "ac_" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName.ToLower();
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".xml";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("UT_{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".xml";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //

            try
            {
                //������ʼ

                //   strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                strCodeForCs.Append("\r\n" + "<LinearLayout xmlns:android=\"http://schemas.android.com/apk/res/android\"");
                strCodeForCs.Append("\r\n" + "    xmlns:app=\"http://schemas.android.com/apk/res-auto\"");
                strCodeForCs.Append("\r\n" + "    xmlns:tools=\"http://schemas.android.com/tools\"");
                strCodeForCs.Append("\r\n" + "    android:orientation=\"vertical\"");
                strCodeForCs.Append("\r\n" + "    android:layout_width=\"match_parent\"");
                strCodeForCs.Append("\r\n" + "    android:layout_height=\"match_parent\"");
                strCodeForCs.Append("\r\n" + "    android:paddingBottom=\"@dimen/activity_vertical_margin\"");
                strCodeForCs.Append("\r\n" + "    android:paddingLeft=\"@dimen/activity_horizontal_margin\"");
                strCodeForCs.Append("\r\n" + "    android:paddingRight=\"@dimen/activity_horizontal_margin\"");
                strCodeForCs.Append("\r\n" + "    android:paddingTop=\"@dimen/activity_vertical_margin\">");
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Java_DefButtonByCommonFunction(objWebSrvFunctionsENEx);

                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
              
                strTemp = A_GeneFuncCodeByFuncName("Gen_Controller_Java_DefButtontvMsg");
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "</LinearLayout>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �����Զ���WS��App����ű�
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_SelfDefWs4UTScriptByTabHost(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "ac" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName.ToLower();
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".xml";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("UT_{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".xml";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //

            try
            {
                //������ʼ

                //   strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
                objAndroidConstraintLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                objAndroidConstraintLayoutENEx.app = "http://schemas.android.com/apk/res-auto";
                objAndroidConstraintLayoutENEx.tools = "http://schemas.android.com/tools";

                objAndroidConstraintLayoutENEx.layout_width = "match_parent";
                objAndroidConstraintLayoutENEx.layout_height = "match_parent";

                //objAndroidConstraintLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                //objAndroidConstraintLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                objAndroidConstraintLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";

                AndroidTabHostEx objAndroidTabHostENEx = new AndroidTabHostEx();
                objAndroidTabHostENEx.CtrlId = "tabHost";
                objAndroidTabHostENEx.layout_width = "wrap_content";
                objAndroidTabHostENEx.layout_height = "300dip";
                objAndroidTabHostENEx.layout_constraintStart_toStartOf = "parent";
                objAndroidTabHostENEx.layout_constraintTop_toTopOf = "parent";
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTabHostENEx);

                AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
                //objAndroidLinearLayoutENEx.CtrlId = "txtAdd";

                objAndroidLinearLayoutENEx.layout_width = "match_parent";
                objAndroidLinearLayoutENEx.layout_height = "match_parent";
                objAndroidLinearLayoutENEx.orientation = "vertical";
                objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);

                AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = new AndroidHorizontalScrollViewEx();
                //objAndroidHorizontalScrollViewENEx.CtrlId = "tabs";
                objAndroidHorizontalScrollViewENEx.layout_width = "match_parent";
                objAndroidHorizontalScrollViewENEx.layout_height = "wrap_content";
                objAndroidHorizontalScrollViewENEx.scrollbars = "none";

                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidHorizontalScrollViewENEx);

                AndroidTabWidgetEx objAndroidTabWidgetENEx = new AndroidTabWidgetEx();
                objAndroidTabWidgetENEx.CtrlId = "tabs";

                objAndroidTabWidgetENEx.layout_width = "match_parent";
                objAndroidTabWidgetENEx.layout_height = "wrap_content";

                objAndroidHorizontalScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidTabWidgetENEx);

                AndroidFrameLayoutEx objAndroidFrameLayoutENEx = new AndroidFrameLayoutEx();
                objAndroidFrameLayoutENEx.CtrlId = "tabcontent";
                objAndroidFrameLayoutENEx.layout_width = "match_parent";
                objAndroidFrameLayoutENEx.layout_height = "match_parent";
                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidFrameLayoutENEx);
                List<string> arrValueLst = new List<string>();
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        //strTemp = Gen_Controller_Java_DefButtonByCommonFunction(objWebSrvFunctionsENEx);
                        AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx1 =
                           GetConstraintLayout4Function4SelfDefWs(objWebSrvFunctionsENEx, arrValueLst);
                        objAndroidFrameLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidConstraintLayoutENEx1);
                        //                   

                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                objAndroidTextViewENEx.CtrlId = "tvMsg";

                objAndroidTextViewENEx.Text = "���ؽ��";
                objAndroidTextViewENEx.layout_width = "wrap_content";
                objAndroidTextViewENEx.layout_height = "wrap_content";
                objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                objAndroidTextViewENEx.layout_constraintTop_toBottomOf = "@+id/tabHost";

                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                string strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClsName + "4SD_Controller";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L5_Controller.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.L0Entity.cls{1}EN;",
                //    objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName); //
                strCodeForCs.Append("\r\n" + " import android.app.Activity;");

                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{1}.{2}WS4SDController;",
                    objProjectsENEx.JavaPackageName,
                    objFuncModule.FuncModuleEnName4GC(),
                    objWebSrvClassENEx.ClsName); //


                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                    objProjectsENEx.JavaPackageName); //
                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  cls{0}4SD_Controller extends Activity",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //�������еĺ���
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Java_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
               
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Java_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�����Web������߲�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objWebSrvClassENEx.ClsName = string.Format("{0}WS4SDController", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L4_Controller4WS.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.L0Entity.cls{1}EN;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "import {0}.Logic.cls{1}BL;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName);
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;");
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L3_ForWS.{1}.{2}WS4SD;",
                   objProjectsENEx.JavaPackageName,
                   objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.ClsName);

                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.os.Handler;");
                strCodeForCs.Append("\r\n" + "import android.os.Looper;");
                strCodeForCs.Append("\r\n" + "import android.os.Message;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import android.widget.Toast;");

                strCodeForCs.Append("\r\n" + "import org.json.JSONObject;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.SoapEnvelope;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.serialization.SoapObject;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.serialization.SoapPrimitive;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.serialization.SoapSerializationEnvelope;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.transport.HttpTransportSE;");

                strCodeForCs.Append("\r\n" + "import java.util.HashMap;");

                strCodeForCs.Append("\r\n" + "import java.util.Iterator;");
                strCodeForCs.Append("\r\n" + "import java.util.List;");
                strCodeForCs.Append("\r\n" + "import java.util.Map;");

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.PageName,
                    objWebSrvClassENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}",
                       objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "public clsTableObjWS4ControllerDelegate objTableObjWS4ControllerDelegate;");

                strCodeForCs.AppendFormat("\r\n" + "public {0}()", objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

  
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_Java_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strTemp = A_GeneFuncCode_Java("Gen_4WS4Controller_Java_SelfDefWs_handleMessage");
                strTemp = Gen_4WS4Controller_Java_SelfDefWs_handleMessage();
                strCodeForCs.Append("\r\n" + strTemp);


                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetRecordObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ��ֵ�ֵ</param>",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void GetObjBy{1}({3} {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {1});",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.ToString4GC_Java);
            }

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjBy{1}\",",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }
            strCodeForCs.AppendFormat("\r\n /// <returns>����{0}</returns>",
                     objWebSrvFunctionsENEx.ReturnValueDescription);

            strCodeForCs.AppendFormat("\r\n" + "public void {0}({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                        objWebSrvFuncParaEN.ParaName,
                          objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);

                    //if (objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0}.toString());",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.JavaType)
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Integer.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Long.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "float":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Float.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "double":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Double.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            default:
                                strMsg = string.Format("Java���ͣ�[{0}]û���ں����б�����!({1})",
                                    objDataTypeAbbrEN.JavaType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                }
            }

            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SD obj{0}WS4SD = new {0}WS4SD(mHandler, \"{1}\",",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "mapParam);");
            //strCodeForCs.AppendFormat("obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS4SD);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WS4Controller_Java_GetFirstJSONObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void GetFirstJSONObj(String strWhereCond)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.Append("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetFirstJSONObj\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Controller_Java_btnGetJSONObjByKey_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjByKey_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetObjBy{1} iobj{0}GetObjBy{1} = new icls{0}GetObjBy{1}();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetObjBy{1} extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1} {0} = \"{2}\";",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{1} {0} = {2};",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"���ݹؼ��֡�01�� ��ȡ����%s!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnGetFirstJSONObj_Click(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnGetFirstJSONObj_Click(View myView) {");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetFirstJSONObj iobj{0}GetFirstJSONObj = new icls{0}GetFirstJSONObj();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetFirstJSONObj.main();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetFirstJSONObj extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s] ��ȡ��һ����¼����%s!\", strWhereCond, obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void GetJSONObjLst(String strWhereCond)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetTopJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void GetTopJSONObjLst(Integer intTopSize, String strWhereCond)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"intTopSize\", intTopSize.toString());");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetTopJSONObjLst\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetJSONObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void GetJSONObjLstByPager(Integer intPageIndex, Integer intPageSize, String strWhereCond, String strOrderBy)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"intPageIndex\", intPageIndex.toString());");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"intPageSize\", intPageSize.toString());");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strOrderBy\", strOrderBy);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLstByPager\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetJSONObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��С��¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">����¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void GetJSONObjLstByRange(String strWhereCond, String strOrderBy, Integer intMinNum, Integer intMaxNum)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strOrderBy\", strOrderBy);");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"intMinNum\", intMinNum.toString());");
            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"intMaxNum\", intMaxNum.toString());");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLstByRange\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnGetJSONObjLst_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetJSONObjLst iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLst();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLst extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����ȡ�����б�����%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnGetTopJSONObjLst_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ��������б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetTopJSONObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetTopJSONObjLst iobj{0}GetTopJSONObjLst = new icls{0}GetTopJSONObjLst();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetTopJSONObjLst extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "Integer intTopSize = 2;");
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize, strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetTopRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetTopRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����ȡ�����б�����%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnGetJSONObjLstByPager_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjLstByPager_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByPager iobj{0}GetJSONObjLstByPager = new icls{0}GetJSONObjLstByPager();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByPager extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "String strOrderBy =\"\";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByPager,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByPager,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����ȡ�����б�����%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_btnIsExistRecord_Click(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "public void btnIsExistRecord_Click(View myView) {");


            strCodeForCs.Append("\r\n" + "iclsIsExistRecord iobjIsExistRecord = new iclsIsExistRecord();");
            strCodeForCs.Append("\r\n" + "iobjIsExistRecord.main();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsIsExistRecord extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch (strClassName) {");
            strCodeForCs.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s] ������!\", strWhereCond);",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s] ����!\", strWhereCond);",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default: ");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_GetRecCountByCond_Click(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "public void GetRecCountByCond_Click(View myView) {");


            strCodeForCs.Append("\r\n" + "iclsGetRecCountByCond iobjGetRecCountByCond = new iclsGetRecCountByCond();");
            strCodeForCs.Append("\r\n" + "iobjGetRecCountByCond.main();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetRecCountByCond extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s]�ļ�¼��:[%s]!\", strWhereCond, returnInt);",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, strInfo);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���������ڱ��м���Ƿ����������ļ�¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">�����ڵ�����</param>");
            strCodeForCs.Append("\r\n /// <returns>���ڷ���true,�����ڷ��أ�false</returns>");
            strCodeForCs.Append("\r\n" + "public void IsExistRecord(String strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.Append("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"IsExistRecord\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���������ڱ��л�ȡ��¼��");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����¼��������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ڼ�¼��</returns>");
            strCodeForCs.Append("\r\n" + "public void GetRecCountByCond(String strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.Append("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetRecCountByCond\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //    strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">�����ڵ�����</param>");
            strCodeForCs.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
            strCodeForCs.Append("\r\n" + "public void GetMaxStrId()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            //    strCodeForCs.Append("\r\n" + "mapParam.put(\"strWhereCond\", strWhereCond);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetMaxStrId\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strPrefix\">�ؼ���ֵ��ǰ׺</param>");
            strCodeForCs.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
            strCodeForCs.Append("\r\n" + "public void GetMaxStrIdByPrefix(String strPrefix)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.Append("\r\n" + "mapParam.put(\"strPrefix\", strPrefix);");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetMaxStrIdByPrefix\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_handleMessage()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strCodeForCs.Append("\r\n" + "private Handler mHandler = new Handler()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "public void handleMessage(Message msg)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Bundle data = null;");

            strCodeForCs.Append("\r\n" + "String strResultValue = \"\";");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "clsResponseData objResponseData = cls{0}WS.objResponseData;",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "boolean bolResult;");
            strCodeForCs.Append("\r\n" + "int intResult;");

            strCodeForCs.Append("\r\n" + "String strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "switch (msg.what)");

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "case 1: //\"GetObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");
            //                    int count = data.getInt("COUNT");
            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");
            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ���󲻳ɹ�!����GetObjBy{1}��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = cls{0}BL.GetObjByJSONStr(strResultValue);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(obj{0}EN, \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
         

            strCodeForCs.AppendFormat("\r\n" + "case 2: //\"GetJSONObjLst\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");
            //                    int count = data.getInt("COUNT");
            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ�����б��ɹ�!����GetJSONObjLst��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strResultValue);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");", 
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(arr{0}ObjLst, \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
          

            strCodeForCs.Append("\r\n" + "case 3: //\"AddNewRecord\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��Ӳ��ɹ�,����AddNewRecord��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "bolResult = data.getBoolean(\"bolResult\");");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 4: //\"UpdateRecord\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");
            //                    int count = data.getInt("COUNT");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"�޸Ĳ��ɹ�!����UpdateRecord��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "bolResult = data.getBoolean(\"bolResult\");");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //          clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
            //    enumDict4GC_DictKey2.conFinished));         

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 5: //\"DelRecord\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"ɾ�����ɹ�!����DelRecord��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "intResult = data.getInt(\"intResult\");");
            strCodeForCs.Append("\r\n" + "objResponseData.returnInt = intResult;");

            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(intResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.AppendFormat("\r\n" + "case 6: //\"GetFirst{0}\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");
            //                    int count = data.getInt("COUNT");
            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��һ����¼���ɹ�!����GetFirst{0}��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = cls{0}BL.GetObjByJSONStr(strResultValue);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
            //    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(obj{0}EN, \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 7: //\"IsExistRecord\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����IsExistRecord��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "bolResult = data.getBoolean(\"bolResult\");");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
            //    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 8: //\"GetMaxStrId\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");
            //                    int count = data.getInt("COUNT");
            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����GetMaxStrId��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "let strResult : String = clsPubFun.myBool(strResult);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnString = strResultValue;");
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
            //    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(strResultValue, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 9: //\"GetMaxStrIdByPrefix\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");
            //                    int count = data.getInt("COUNT");
            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����GetMaxStrIdByPrefix��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "let strResult : String = clsPubFun.myBool(strResult);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnString = strResultValue;");
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(strResultValue, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.AppendFormat("\r\n" + " case 10: //\"GetTopJSONObjLst\":",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ȡ���ݵ�����");
            strCodeForCs.Append("\r\n" + "data = msg.getData();");
            strCodeForCs.Append("\r\n" + "//                    int count = data.getInt(\"COUNT\");");


            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\"); ");
            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ�������б��ɹ�!����GetTopQx{0}ObjLst��������%s\",",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//                        clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strResultValue);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0}(objResponseData, \"clsQx{0}WS4Controller\");",
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(arr{0}ObjLst, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
           
            strCodeForCs.AppendFormat("\r\n" + "case 11: //\"GetJSONObjLstByPager\":",
 objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ȡ���ݵ�����");
            strCodeForCs.Append("\r\n" + "data = msg.getData();");
            strCodeForCs.Append("\r\n" + "//                    int count = data.getInt(\"COUNT\");");


            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\"); ");
            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��ҳ�����б��ɹ�!����GetTopQx{0}ObjLst��������%s\",",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//                        clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strResultValue);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0}(objResponseData, \"clsQx{0}WS4Controller\");",
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(arr{0}ObjLst, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 12: //\"GetRecCountByCond\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����GetRecCountByCond��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intResult = data.getInt(\"intResult\");");
            strCodeForCs.Append("\r\n" + "objResponseData.returnInt = intResult;");
            //         strCodeForCs.Append("\r\n" + "objTableObjWS4ControllerDelegate.GetRecCountByCondCorrectFinished(intResult, "cls{0}WS4Controller");");



            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
            //    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(intResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "case 13: //\"DelRecordsByJSON\":");
            strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
            strCodeForCs.Append("\r\n" + " data = msg.getData();");

            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"ɾ�����ɹ�!����DelRecordsByJSON��������%s\", cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "intResult = data.getInt(\"intResult\");");
            strCodeForCs.Append("\r\n" + "objResponseData.returnInt = intResult;");

            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}\");",
            //    objPrjTabENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(intResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecordsByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "case 14: //\"GetJSONObjLstByRange\":",
 objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ȡ���ݵ�����");
            strCodeForCs.Append("\r\n" + "data = msg.getData();");
            strCodeForCs.Append("\r\n" + "//                    int count = data.getInt(\"COUNT\");");


            strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\"); ");
            strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WS.objResponseData.errorId >= 2)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.objResponseData.errorId == 1)",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��ҳ�����б��ɹ�!����GetTopQx{0}ObjLst��������%s\",",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "//                        clsPubFun.myAlertIOS7(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strResultValue);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0}(objResponseData, \"clsQx{0}WS4Controller\");",
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
            //    enumDict4GC_DictKey2.conFinished));

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(arr{0}ObjLst, \"cls{0}WS4Controller\");",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "};");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_SelfDefWs_handleMessage()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strCodeForCs.Append("\r\n" + "private Handler mHandler = new Handler()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "public void handleMessage(Message msg)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Bundle data = null;");

            strCodeForCs.Append("\r\n" + "String strResultValue = \"\";");
            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            //    objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "clsResponseData objResponseData = {0}WS4SD.objResponseData;",
                objWebSrvClassENEx.ClsName);

            strCodeForCs.Append("\r\n" + "boolean bolResult;");
            strCodeForCs.Append("\r\n" + "String strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "switch (msg.what)");

            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                            objWebSrvFunctionsENEx.FunctionName,
                            intIndex);
                strCodeForCs.Append("\r\n" + " //��ȡ���ݵ����� ");
                strCodeForCs.Append("\r\n" + " data = msg.getData();");
                //                    int count = data.getInt("COUNT");
                strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");
                strCodeForCs.AppendFormat("\r\n" + " if ({0}WS4SD.objResponseData.errorId >= 2)",
                        objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\", \"{2}\");",
                    objWebSrvClassENEx.ClsName,
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished),
                   objWebSrvFunctionsENEx.FunctionName);

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "else if ({0}WS4SD.objResponseData.errorId == 1)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"����{0}��������%s\", {0}WS4SD.objResponseData.faultString);",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
                strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}WS4Controller\", \"{2}\");",
                     objWebSrvClassENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                    enumDict4GC_DictKey2.conFinished),
                    objWebSrvFunctionsENEx.FunctionName);
                strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");

                //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = cls{0}BL.GetObjByJSONStr(strResultValue);",
                //    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnString = strResultValue;");
                //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(objResponseData, \"{0}\", \"{1}\");",
                //    objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName,
                //clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                //enumDict4GC_DictKey2.conFinished));

                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(strResultValue, \"{0}\", \"{1}\");",
                     objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName,
                     clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                     enumDict4GC_DictKey2.conCorrectFinished));

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                intIndex++;
            }

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "};");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ͨ�õĵ���WebService���� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ͨ�õĵ���WebService����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��Ҫɾ���Ĺؼ��ֵ�ֵ</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n /// <returns>ɾ���Ƿ�ɹ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void DelRecord({1} {0}) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {1});",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.ToString4GC_Java);
                //strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0}.toString());",
                //objKeyField.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ͨ�õĵ���WebService���� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_DelRecordsByJSON()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ͨ�õĵ���WebService����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strKeyIdLst\">��Ҫɾ���Ĺؼ��ֵ��б�,ͨ��JSON��</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n /// <returns>ɾ���ļ�¼��</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void DelRecordsByJSON(String strKeyIdLst) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");

            strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"strKeyIdLst\", strKeyIdLst);",
                   objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecordsByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_btnDelRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ɾ����¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnDelRecord_Click(View myView) {");

            strCodeForCs.Append("\r\n" + "iclsDelRecord iobjDelRecord = new iclsDelRecord();");
            strCodeForCs.Append("\r\n" + "iobjDelRecord.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsDelRecord extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord(\"{1}\");",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1});",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"ɾ����¼�ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"ɾ����¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_btnDelRecordsByJSON_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ɾ����¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnDelRecordsByJSON_Click(View myView) {");

            strCodeForCs.Append("\r\n" + "iclsDelRecordsByJSON iobjDelRecordsByJSON = new iclsDelRecordsByJSON();");
            strCodeForCs.Append("\r\n" + "iobjDelRecordsByJSON.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsDelRecordsByJSON extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecordsByJSON(\"{1}\");",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecordsByJSON({1});",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��DelRecordsByJSON,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecordsByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��DelRecordsByJSON,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"ɾ����¼�ɹ�, ��ɾ����%s����¼!\", returnInt);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"ɾ����¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string Gen_Controller_Java_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void Invoke_{0}(Object vcParentView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1} iobj{0}_{1} = new icls{0}_{1}(vcParentView);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "public static class icls{0}_{1} extends clsTableObjWS4ControllerDelegate",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);
            strCodeForCs.Append("\r\n" + "public Object vcParent = null;");
            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}(Object pvcParent)",
                    objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.objTableObjWS4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"{2}\";",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {2};",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
             objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"����ֵΪ��[%s]!\", returnString);");
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_btnAddNewRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnAddNewRecord_Click(View myView) {");
            strCodeForCs.Append("\r\n" + "iclsAddNewRecord iobjAddNewRecord = new iclsAddNewRecord();");
            strCodeForCs.Append("\r\n" + "iobjAddNewRecord.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsAddNewRecord extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\",obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"�ؼ���Ϊ��%s���ļ�¼�Ѿ�����,���������!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"��Ӽ�¼�ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"��Ӽ�¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnAddNewRecord4GetMaxStrId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnAddNewRecord4GetMaxStrId_Click(View myView) {");
            strCodeForCs.Append("\r\n" + "iclsAddNewRecord4GetMaxStrId iobjAddNewRecord4GetMaxStrId = new iclsAddNewRecord4GetMaxStrId();");
            strCodeForCs.Append("\r\n" + "iobjAddNewRecord4GetMaxStrId.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsAddNewRecord4GetMaxStrId extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(returnString);",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"�ؼ���Ϊ��%s���ļ�¼�Ѿ�����,���������!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"��Ӽ�¼�ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"��Ӽ�¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnGetMaxStrId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnGetMaxStrId_Click(View myView) {");
            strCodeForCs.Append("\r\n" + "iclsGetMaxStrId iobjGetMaxStrId = new iclsGetMaxStrId();");
            strCodeForCs.Append("\r\n" + "iobjGetMaxStrId.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetMaxStrId extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��{0}�����ؼ���Ϊ��%s!\", returnString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnGetMaxStrIdByPrefix_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnGetMaxStrIdByPrefix_Click(View myView) {");
            strCodeForCs.Append("\r\n" + "iclsGetMaxStrIdByPrefix iobjGetMaxStrIdByPrefix = new iclsGetMaxStrIdByPrefix();");
            strCodeForCs.Append("\r\n" + "iobjGetMaxStrIdByPrefix.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetMaxStrIdByPrefix extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��ȡ��{0}�����ؼ���Ϊ��%s!\", returnString);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void AddNewRecord(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"AddNewRecordByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mThread.start();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void UpdateRecord(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"UpdateRecordByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam,");
            strCodeForCs.AppendFormat("obj{0}EN);",
                objPrjTabENEx.TabName);
            //Thread mThread = new Thread(obj{0}WS);
            //mThread.start();
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnUpdateRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnUpdateRecord_Click(View myView) {");
            strCodeForCs.Append("\r\n" + "iclsUpdateRecord iobjUpdateRecord = new iclsUpdateRecord();");
            strCodeForCs.Append("\r\n" + "iobjUpdateRecord.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsUpdateRecord extends clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"�޸ļ�¼�ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"�޸ļ�¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_Controller(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;

            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            try
            {
                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                 else   if (strFuncName.IndexOf("Java_DeclareButton") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_DefButton") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_DefBtnClickEvent") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_BindButton") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
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
                Type t = typeof(AppViewUnitTest_UDF4JAVA);
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
            this.ClsName = string.Format("ac{0}4SD_UnitTest", objWebSrvClassENEx.ClsName);
            objWebSrvClassENEx.ClsName = this.ClsName;
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

        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {
            
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(AppViewUnitTest_UDF4JAVA);
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
                        strCode = (string)mt.Invoke(this, new object[] { objFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }
    }
}
