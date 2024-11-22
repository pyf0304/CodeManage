using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 
    /// </summary>
    public class WinViewCode_UI_Design4CSharp : AutoGC_Cs_VWin_PubFun
    {
        //		int intZIndex;		///�ؼ��������
        //		int intCurrLeft;  ///�ؼ�����߿�;
        //		int intCurrTop;  ///�ؼ��Ķ����;
        //bool objViewInfoENEx.IsUseCtl = true;
        //private string strFolder;   //˽����ʱ����
        //private string objViewInfoENEx.MainSubViewType;
        //private string objViewInfoENEx.NetVersion;//NET�İ汾,��Ҫ����NET2003��NET2005
        //private bool objViewInfoENEx.IsDesign;//���NET2005������ļ�

        //public bool IsDesign
        //{
        //  get { return objViewInfoENEx.IsDesign; }
        //  set { objViewInfoENEx.IsDesign = value; }
        //}

        //public string NetVersion
        //{
        //  get { return objViewInfoENEx.NetVersion; }
        //  set { objViewInfoENEx.NetVersion = value; }
        //}

        //public bool IsUseCtl
        //{
        //  set 
        //  {
        //    objViewInfoENEx.IsUseCtl = value;
        //  }
        //  get
        //  {
        //    return objViewInfoENEx.IsUseCtl;
        //  }
        //}
        //public string MainSubViewType
        //{
        //  set
        //  {
        //    objViewInfoENEx.MainSubViewType = value;
        //  }
        //  get
        //  {
        //    return objViewInfoENEx.MainSubViewType;
        //  }
        //}
        //		private objViewInfoENEx.FileName;		//���ɵ��ļ�����

        #region ���캯��
        public WinViewCode_UI_Design4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public WinViewCode_UI_Design4CSharp(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WinViewCode_UI_Design4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
           
      

        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //      Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();     //�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_LV";
           objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_QD_LV.cs";
            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                //��һ��:���ɵ��������ռ�
                

                //������ʼ
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
                strCodeForCs.Append("\r\n" + "using CommFunc4Win;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_LV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class frm{0}_QD_LV : System.Windows.Forms.Form, IBindListView", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ��б���������


                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0} = null;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private clsListViewSorter obj{0}Sorter;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "private int intLastSelected{0}ColumIndex ;",
                  objViewInfoENEx.TabName_Out);

                //���Ĳ�:���ɱ�������������
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_QD_LV()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �õ����� Windows.Forms ���������������ġ�");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: �� InitializeComponent ���ú�����κγ�ʼ��");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter = new clsListViewSorter();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//ΪListViewItemSorterָ��������");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ListViewItemSorter = obj{0}Sorter;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter.SortOrder = SortOrder.Ascending;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //���岽:������������ʹ�õ���Դ
                //������:�����������ɵĴ���
                //���߲�:����objViewInfoENEx.load����

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_QD_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                //1��Ϊ��������������Դ,���б�����

                strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //����������İ󶨺���
                strTemp = Genfun_SetAllComboBox4Query();
                strCodeForCs.Append(strTemp);

                //���ɽ���ؼ����������
                strTemp = Genfun_ViewCtrlProperty4Query();
                strCodeForCs.Append(strTemp);


                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                //clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                //if (objEditRegionKeyFld != null)	//����༭���������ؼ���
                //{
                //  if (getEditRegionKeyFld().objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                //  {
                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                //    strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                //    strCodeForCs.Append("\r\n" + "}");
                //  }
                //}
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��
                strTemp = Genfun_Clear4QryRegion();
                strCodeForCs.Append(strTemp);

                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strTemp = Genfun_SetDefaultValue4QryRegion();
                strCodeForCs.Append(strTemp);

                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strTemp = Genfun_IsValid();
                strCodeForCs.Append(strTemp);

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                //strTemp = clsPubFun4GC.GenGetCurrMonth();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenGetTodayStr();
                //strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                //strTemp = GenComboBoxBindFunction();
                //strCodeForCs.Append(strTemp);


                //��ʮ�岽:����һЩ�ж��������͵ĵĹ�������

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);

                //��ʮ����:����������ϲ�ѯ�����ĺ���
                strTemp = GenCombineCondition(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithSel(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithTabName(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);



                //���������ж�ɾ����ť�Ƿ����
                strTemp = gfunGenJudgebtnDelete();
                strCodeForCs.Append(strTemp);
                //�����ж��޸İ�ť�Ƿ����
                strTemp = gfunGenJudgebtnUpdate();
                strCodeForCs.Append(strTemp);

                //�ڰ˲�:���ɰ�ListView�Ĵ���


                strTemp = gfunGenBindListView();
                strCodeForCs.Append(strTemp);


                //�ھŲ�:���ɴ����ѯ��ť�ĵ����¼���

                strTemp = Gen_btnQuery_Click();
                strCodeForCs.Append(strTemp);

                //��ʮ��:���ɻ�ȡDataGrid�е�ǰ�е�����ֵ��
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4ListView();
                strCodeForCs.Append(strTemp);


                //��ʮһ��:���ɴ���ListView�ĵ����¼���
                strTemp = Gen_lvListView_Click();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:///�����޸ĵ��¼�����
                strTemp = Gen_btnUpdate_Click();
                strCodeForCs.Append(strTemp);

                //��ʮ�岽:///������ӵ��¼�����

                strTemp = Gen_btnAdd_Click();
                strCodeForCs.Append(strTemp);


                //��ʮ����:����ɾ����ť�ĵ����¼�����

                strTemp = Gen_btnDelRec_Click();
                strCodeForCs.Append(strTemp);

                //��ʮ�߲�:���ɵ���Excel��ť�ĵ����¼�����
                strTemp = gfunGenbtnExportExcel4ListView_Click();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel_SelColumns();
                strCodeForCs.Append(strTemp);

                //��ʮ�˲�:����LISTVIEW���е����¼�����
                strTemp = gfunGenListView_ColumnClick();
                strCodeForCs.Append(strTemp);

                ///ʵ�ֽӿں���,ͨ���Ӵ������,��ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
                strTemp = gfunGenIBindListView_BindListView();
                strCodeForCs.Append(strTemp);

                //�޸ļ�¼׼������
                strTemp = GenUpdateRecordCode();
                strCodeForCs.Append(strTemp);

                //ɾ����¼����
                strTemp = GenDelRecordCode();
                strCodeForCs.Append(strTemp);

                //���һ��:������Ľ������������ռ�Ľ�����
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //������д���ļ���;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////�����ļ������ļ�����,���ж��Ƿ����;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// �������ڱ༭ĳ����Ľ���,����:�޸ġ����,�ý�����Ҫ���ڱ���������������
        /// ע:��ʹ�ÿؼ�(NoContral)
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();     //�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //���༭����
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_UI.Designer.cs";

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {

                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }

                //��һ��:���ɵ��������ռ�

                
                //������ʼ
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_UI ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_UI", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ����������������");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                //���岽:������������ʹ�õ���Դ
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n /// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                      objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnClose = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 10;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                  objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            case "ComboBox":
                            case "DropDownList":
                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objEditRegionFldsEx.FldName,
                                  objEditRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                    objEditRegionFldsEx.CtrlId4Win);

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objEditRegionFldsEx.FldName,
                                  objEditRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objEditRegionFldsEx.IsIdentity = false && objEditRegionFldsEx.IsCtlField == true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objEditRegionFldsEx in arrViewCtlFldSet)
                    intFieldIndex++;
                }



                // 
                // btnOKUpd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnOKUpd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.Location = new System.Drawing.Point({0}, {1});",
                  intCtlWidth / 4,
                  objBiDimDistribue.GetPosition(intFieldIndex + 1).Y + 30);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);");

                // 
                // btnClose
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnClose");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnClose.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.Location = new System.Drawing.Point({0}, {1});",
                  intCtlWidth / 4 + 120,
                  objBiDimDistribue.GetPosition(intFieldIndex + 1).Y + 30);
                strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"�ر�\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Click += new System.EventHandler(this.btnClose_Click);");
                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.Location = new System.Drawing.Point({0}, {1});",
                  intCtlWidth / 4,
                   objBiDimDistribue.GetPosition(intFieldIndex + 1).Y + 60);
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                  intIndex++);

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_UI",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.AppendFormat("\r\n" + "this.ClientSize = new System.Drawing.Size({0}, {1});",
                  intCtlWidth + 30,
                  objBiDimDistribue.GetPosition(intFieldIndex + 3).Y + 150);
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add({0});",
                      strCtlName);
                }


                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnClose);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnOKUpd);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblMsg);");
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_UI\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_UI\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_UI_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnClose;");

                //���һ��:������Ľ������������ռ�Ľ�����
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //������д���ļ���;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////�����ļ������ļ�����,���ж��Ƿ����;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                //{
                //    //strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //    //    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
                //}

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
    }
}

