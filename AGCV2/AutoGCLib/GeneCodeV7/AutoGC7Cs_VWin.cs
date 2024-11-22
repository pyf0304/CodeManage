using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.file;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 
    /// </summary>
    class AutoGC7Cs_VWin : AutoGC_Cs_VWin_PubFun
    {
        private string strFolder;   //˽����ʱ����
                                    //		int intZIndex;		///�ؼ��������
                                    //		int intCurrLeft;   ///�ؼ�����߿�;
                                    //		int intCurrTop;   ///�ؼ��Ķ����;
                                    //bool objViewInfoENEx.IsUseCtl = true;

        //private string objViewInfoENEx.MainSubViewType;
        //private string objViewInfoENEx.NetVersion;//NET�İ汾,��Ҫ����NET2003��NET2005
        //private bool objViewInfoENEx.IsDesign;//���NET2005������ļ�

        //public bool IsDesign
        //{
        //    get { return objViewInfoENEx.IsDesign; }
        //    set { objViewInfoENEx.IsDesign = value; }
        //}

        //public string NetVersion
        //{
        //    get { return objViewInfoENEx.NetVersion; }
        //    set { objViewInfoENEx.NetVersion = value; }
        //}

        //public bool IsUseCtl
        //{
        //    set 
        //    {
        //        objViewInfoENEx.IsUseCtl = value;
        //    }
        //    get
        //    {
        //        return objViewInfoENEx.IsUseCtl;
        //    }
        //}
        //public string MainSubViewType
        //{
        //    set
        //    {
        //        objViewInfoENEx.MainSubViewType = value;
        //    }
        //    get
        //    {
        //        return objViewInfoENEx.MainSubViewType;
        //    }
        //}
        //		private objViewInfoENEx.FileName;		//���ɵ��ļ�����
        #region ���캯��
        public AutoGC7Cs_VWin()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }

        public AutoGC7Cs_VWin(string strViewId) : base(strViewId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        #endregion


        /// <summary>
        /// ���ɱ�ؼ�����
        /// </summary>
        /// <returns></returns>
        public string A_GenCtlCodeforTabNew(Encoding myEncoding, clsViewInfoENEx objViewInfoENEx)
        {
            //���û���������;
            //string strFolder ;
            string strTemp;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }


            StringBuilder strCodeForCs = new StringBuilder();   ///�������WebForm�Ĵ���;
			ArrayList arrInnerCtlSet = new ArrayList();     //�ڲ��ؼ�����
                                                            //			int intZIndex;
            float fltCtlHeight = 150, fltCtlWidth = 750;
            //			int intCurrTop;   ///�ؼ��Ķ����;
            Point pntLocation = new Point();
            objViewInfoENEx.WinUserCtlCsFName = objViewInfoENEx.FolderName + "uc" + objViewInfoENEx.TabName + ".cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WinUserCtlCsFName;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                    objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                    objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
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
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "");
                
                clsProjectsEN objProject = clsProjectsBLEx.GetProjectsENExObjByPrjId(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "///		uc{0} ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class uc{0} : System.Windows.Forms.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }
                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// ����������������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "public uc{0}()",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �õ����� Windows.Forms ���������������ġ�");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: �� InitializeComponent ���ú�����κγ�ʼ��");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //���岽:������������ʹ�õ���Դ
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n" + "/// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }
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
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
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
                        //end of if(objEditRegionFldsEx.IsIdentity  ==  false && objEditRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objEditRegionFldsEx in arrViewCtlFldSet)
                    intFieldIndex++;
                }

                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//");
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add({0});",
                        strCtlName);
                }
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"uc{0}\";", objViewInfoENEx.TabName);
                fltCtlHeight = objBiDimDistribue.GetCtlHeigh(intFieldIndex);
                fltCtlWidth = objBiDimDistribue.GetCtlWidth();
                strCodeForCs.AppendFormat("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.Size = new System.Drawing.Size({0}, {1});",
                    fltCtlWidth, fltCtlHeight);
                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.uc{0}_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");
                //���߲�:����this.load����
                strCodeForCs.AppendFormat("\r\n" + "private void uc{0}_Load(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //�ڰ˲�:���ɿؼ�����,һ��Ϊÿ���ڲ��ؼ�����Ӧ����һ������

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                            objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                            objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":    ///����ؼ���������;
								if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString()  ==  \"0\")",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":     ///����ؼ��������ı���;
								strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //����༭���������ؼ���
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                        objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
								strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                     objEditRegionFldsEx.CtrlId, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n" + "/// һ�����:");
                strCodeForCs.Append("\r\n" + "///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n" + "///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n" + "///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n" + "///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n" + "///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
								strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, strInitValue);

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                 objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n" + "/// һ�����:");
                strCodeForCs.Append("\r\n" + "///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n" + "///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n" + "///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n" + "///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n" + "///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strTemp = clsPubFun4GC.GenGetCurrMonth();
                strCodeForCs.Append(strTemp);
                strTemp = clsPubFun4GC.GenGetTodayStr();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                strTemp = GenComboBoxBindFunction();
                strCodeForCs.Append(strTemp);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                            objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId4Win,
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ�岽:����һЩ�ж��������͵ĵĹ�������

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);


                //���һ��:������Ľ������������ռ�Ľ�����
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
                //������д���ļ���;
                //          clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WinUserCtlCsFName, strCodeForCs.ToString(), objViewInfoENEx.BackupFolderName, myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

      
        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral()
        {
            Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();     //�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_LV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_LV.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

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
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commform;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                
                clsProjectsEN objProject = clsProjectsBLEx.GetProjectsENExObjByPrjId(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "///		frm{0}_QD_LV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class frm{0}_QD_LV : System.Windows.Forms.Form, IBindListView", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }


                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnUpdate;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnAdd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.GroupBox gbQueryCondition;");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.ListView lv{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0};",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private clsListViewSorter obj{0}Sorter;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "private int intLastSelected{0}ColumIndex ;",
                    objViewInfoENEx.TabName_Out);

                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// ����������������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
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
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n" + "/// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnUpdate = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnAdd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");

                strCodeForCs.AppendFormat("\r\n" + "this.lv{0} = new System.Windows.Forms.ListView();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition = new System.Windows.Forms.GroupBox();");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.SuspendLayout();");

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 18;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity  ==  false && objQryRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;    //�ֶ������1
                }

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(192, 144);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                    intIndex++);
                // 
                // btnAdd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnAdd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Location = new System.Drawing.Point(408, 137);");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Name = \"btnAdd\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnAdd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnAdd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Click +=  new System.EventHandler(this.btnAdd_Click);");
                // 
                // 
                // btnUpdate
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnUpdate");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Location = new System.Drawing.Point(496, 137);");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Name = \"btnUpdate\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnUpdate.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Text = \"�޸�\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Click +=  new System.EventHandler(this.btnUpdate_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(576, 137);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"ɾ����¼\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click +=  new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"����Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click +=  new System.EventHandler(this.btnExportExcel4Dg_Click);");
                //
                //��ѯ��ť<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(328, 137);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"��ѯ\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click +=  new System.EventHandler(this.btnQuery_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(752, 144);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"��¼��:\";");


                // 
                // lv{0}
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// lv{0}",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Dock = System.Windows.Forms.DockStyle.Fill;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Location = new System.Drawing.Point(0, 176);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Name = \"lv{0}\";",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Size = new System.Drawing.Size(1000, 524);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ColumnClick +=  new System.Windows.Forms.ColumnClickEventHandler(this.lv{0}_ColumnClick);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.TabIndex = {1};",
                    objViewInfoENEx.TabName_Out,
                    intIndex++);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.View = System.Windows.Forms.View.Details;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Click +=  new System.EventHandler(this.lv{0}_Click);",
                    objViewInfoENEx.TabName_Out);

                // 
                // gbQueryCondition
                // 
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.Controls.Add({0});",
                        strCtlName);
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnUpdate);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnAdd);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblRecNum);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Name = \"gbQueryCondition\";");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);");
                strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.TabStop = false;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Text = \"��ѯ����\";");

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                // 
                // frm{0}_QD_LV
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QD_LV",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                //				strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(1000, 700);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.lv{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.gbQueryCondition);");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");

                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_QD_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //���߲�:����this.load����

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
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ������İ󶨺���");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.BindCbo_{0}(this.ddl{1});",
                            objQryRegionFldsEx.FldName,
                            objQryRegionFldsEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                            objQryRegionFldsEx.ObjFieldTabENEx.CsType(),
                            objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":    ///����ؼ���������;
								if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString()  ==  \"0\")",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":     ///����ؼ��������ı���;
								strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //����༭���������ؼ���
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
								strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;

                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;

                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n" + "/// һ�����:");
                strCodeForCs.Append("\r\n" + "///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n" + "///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n" + "///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n" + "///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n" + "///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
								strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                     objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n" + "/// һ�����:");
                strCodeForCs.Append("\r\n" + "///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n" + "///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n" + "///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n" + "///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n" + "///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strTemp = clsPubFun4GC.GenGetCurrMonth();
                strCodeForCs.Append(strTemp);
                strTemp = clsPubFun4GC.GenGetTodayStr();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                strTemp = GenComboBoxBindFunction();
                strCodeForCs.Append(strTemp);

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                            objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win,
                            objQryRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
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
                strTemp = GenCombineCondition();
                strCodeForCs.Append(strTemp);
                strTemp = GenCombineConditionWithSel();
                strCodeForCs.Append(strTemp);
                strTemp = GenCombineConditionWithTabName();
                strCodeForCs.Append(strTemp);



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

                strCodeForCs.Append("\r\n" + "private void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//�ѱ��¼��������ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                //��ʮ��:���ɻ�ȡDataGrid�е�ǰ�е�����ֵ��
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4ListView();
                strCodeForCs.Append(strTemp);

                //��ʮһ��:���ɴ���ListView�ĵ����¼���
                strCodeForCs.AppendFormat("\r\n" + "private void lv{0}_Click(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�Ĳ�:///�����޸ĵ��¼�����
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n" + "///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnUpdate_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Update{2}Record();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�岽:///������ӵ��¼�����
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n" + "///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnAdd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "frm{0}_UI frm = new frm{0}_UI();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "frm.iBindListView = this;");
                strCodeForCs.Append("\r\n" + "frm.OperateType = \"Add\";");
                strCodeForCs.Append("\r\n" + "frm.ShowDialog();");
                strCodeForCs.Append("\r\n" + "}");



                //��ʮ����:����ɾ����ť�ĵ����¼�����
                strCodeForCs.Append("\r\n" + "private void btnDelRec_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Delete{0}Record();",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005()
        {
            //            Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_LV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_LV.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

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
                
                clsProjectsEN objProject = clsProjectsBLEx.GetProjectsENExObjByPrjId(objViewInfoENEx.PrjId); //
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
                //���߲�:����this.load����

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
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������İ󶨺���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.BindCbo_{0}(this.cbo{1});",
                            objQryRegionFldsEx.FldName,
                            objQryRegionFldsEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                            objQryRegionFldsEx.ObjFieldTabENEx.CsType(),
                            objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":    ///����ؼ���������;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString()  ==  \"0\")",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":     ///����ؼ��������ı���;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                //clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                //if (objEditRegionKeyFld !=  null)	//����༭���������ؼ���
                //{
                //    if (getEditRegionKeyFld().objPrjTabFldENEx.PrimaryTypeId !=  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                //    {
                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                //        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                //        strCodeForCs.Append("\r\n" + "{");
                //        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                //        strCodeForCs.Append("\r\n" + "}");
                //    }
                //}
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                  objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n ///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n ///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                   objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strTemp = clsPubFun4GC.GenGetCurrMonth();
                strCodeForCs.Append(strTemp);
                strTemp = clsPubFun4GC.GenGetTodayStr();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                strTemp = GenComboBoxBindFunction();
                strCodeForCs.Append(strTemp);

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                            objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win,
                            objQryRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
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
                strTemp = GenCombineCondition();
                strCodeForCs.Append(strTemp);
                strTemp = GenCombineConditionWithSel();
                strCodeForCs.Append(strTemp);
                strTemp = GenCombineConditionWithTabName();
                strCodeForCs.Append(strTemp);



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

                strCodeForCs.Append("\r\n" + "private void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//�ѱ��¼��������ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                //��ʮ��:���ɻ�ȡDataGrid�е�ǰ�е�����ֵ��
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4ListView();
                strCodeForCs.Append(strTemp);


                //��ʮһ��:���ɴ���ListView�ĵ����¼���
                strCodeForCs.AppendFormat("\r\n" + "private void lv{0}_Click(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�Ĳ�:///�����޸ĵ��¼�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnUpdate_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Update{2}Record();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�岽:///������ӵ��¼�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnAdd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "frm{0}_UI frm = new frm{0}_UI();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "frm.iBindListView = this;");
                strCodeForCs.Append("\r\n" + "frm.OperateType = \"Add\";");
                strCodeForCs.Append("\r\n" + "frm.ShowDialog();");
                strCodeForCs.Append("\r\n" + "}");



                //��ʮ����:����ɾ����ť�ĵ����¼�����
                strCodeForCs.Append("\r\n" + "private void btnDelRec_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Delete{0}Record();",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl),��ʾ�б���DataGridView
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithDGV_NoContral_Net2005()
        {
            //            Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = (clsDataGridStyleENEx)clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_DGV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_DGV.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

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
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objViewInfoENEx.NameSpace);

                clsProjectsEN objProject = clsProjectsBLEx.GetProjectsENExObjByPrjId(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");


                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_DGV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class frm{0}_QD_DGV : System.Windows.Forms.Form, IBindListView", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ��б���������


                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0} = null;",
                    objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "private clsListViewSorter obj{0}Sorter;",
                //    objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "private int intLastSelected{0}ColumIndex ;",
                //    objViewInfoENEx.TabName_Out);

                //���Ĳ�:���ɱ�������������
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_QD_DGV()",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �õ����� Windows.Forms ���������������ġ�");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: �� InitializeComponent ���ú�����κγ�ʼ��");
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter = new clsListViewSorter();",
                //    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + "//ΪListViewItemSorterָ��������");
                //strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ListViewItemSorter = obj{0}Sorter;",
                //    objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter.SortOrder = SortOrder.Ascending;",
                //    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //���岽:������������ʹ�õ���Դ
                //������:�����������ɵĴ���
                //���߲�:����this.load����

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_QD_Load(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                //1��Ϊ��������������Դ,���б�����

                strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //����������İ󶨺���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������İ󶨺���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.BindCbo_{0}(this.cbo{1});",
                            objQryRegionFldsEx.FldName,
                            objQryRegionFldsEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                            objQryRegionFldsEx.ObjFieldTabENEx.CsType(),
                            objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":    ///����ؼ���������;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString()  ==  \"0\")",
                                            objQryRegionFldsEx.CtrlId4Win);

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "long"
                                        || objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                                        || objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "short")
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse( {0}.SelectedValue.ToString());",
                                         objQryRegionFldsEx.CtrlId4Win,
                                         objQryRegionFldsEx.ObjFieldTabENEx.CsType());
                                    }
                                    else
                                    {

                                        strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                             objQryRegionFldsEx.CtrlId4Win);
                                    }


                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "long"
                                        || objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                                        || objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "short")
                                    {
                                        strCodeForCs.Append("\r\n" + "if (value  ==  0)");
                                    }
                                    else
                                    {
                                        strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":     ///����ؼ��������ı���;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)	//����༭���������ؼ���
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                        objQryRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                           objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n ///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n ///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                     objQryRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strTemp = clsPubFun4GC.GenGetCurrMonth();
                strCodeForCs.Append(strTemp);
                strTemp = clsPubFun4GC.GenGetTodayStr();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                strTemp = GenComboBoxBindFunction();
                strCodeForCs.Append(strTemp);

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                            objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win,
                            objQryRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
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
                strTemp = GenCombineCondition();
                strCodeForCs.Append(strTemp);
                strTemp = GenCombineConditionWithSel();
                strCodeForCs.Append(strTemp);
                strTemp = GenCombineConditionWithTabName();
                strCodeForCs.Append(strTemp);

                //���������ж�ɾ����ť�Ƿ����
                strTemp = gfunGenJudgebtnDelete4DataGridView();
                strCodeForCs.Append(strTemp);
                //�����ж��޸İ�ť�Ƿ����
                strTemp = gfunGenJudgebtnUpdate4DataGridView();
                strCodeForCs.Append(strTemp);

                //�ڰ˲�:���ɰ�ListView�Ĵ���

                strTemp = gfunGenBindDataGridView();
                strCodeForCs.Append(strTemp);


                //�ھŲ�:���ɴ����ѯ��ť�ĵ����¼���

                strCodeForCs.Append("\r\n" + "private void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//�ѱ��¼��������ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                //��ʮ��:���ɻ�ȡDataGrid�е�ǰ�е�����ֵ��
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4DataGridView();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4ListView();
                strCodeForCs.Append(strTemp);


                //��ʮһ��:���ɴ���ListView�ĵ����¼���
                strCodeForCs.AppendFormat("\r\n" + "private void dgv{0}_Click(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "private void dgv{0}_CellClick(object sender, DataGridViewCellEventArgs e)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�Ĳ�:///�����޸ĵ��¼�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnUpdate_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Update{2}Record();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�岽:///������ӵ��¼�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnAdd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "frm{0}_UI frm = new frm{0}_UI();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "frm.iBindListView = this;");
                strCodeForCs.Append("\r\n" + "frm.OperateType = \"Add\";");
                strCodeForCs.Append("\r\n" + "frm.ShowDialog();");
                strCodeForCs.Append("\r\n" + "}");



                //��ʮ����:����ɾ����ť�ĵ����¼�����
                strCodeForCs.Append("\r\n" + "private void btnDelRec_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Delete{0}Record();",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�߲�:���ɵ���Excel��ť�ĵ����¼�����
                strTemp = gfunGenbtnExportExcel4ListView_Click();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel_SelColumns();
                strCodeForCs.Append(strTemp);

                //��ʮ�˲�:����LISTVIEW���е����¼�����
                //strTemp = gfunGenListView_ColumnClick();
                //strCodeForCs.Append(strTemp);

                ///ʵ�ֽӿں���,ͨ���Ӵ������,��ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
                strTemp = gfunGenIBindListView_BindListView4DataGridView();
                strCodeForCs.Append(strTemp);

                //�޸ļ�¼׼������
                strTemp = GenUpdateRecordCode4DataGridView();
                strCodeForCs.Append(strTemp);

                //ɾ����¼����
                strTemp = GenDelRecordCode4DataGridView();
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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005_Design()
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_LV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_LV.Designer.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_LV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_QD_LV", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

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
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
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

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnUpdate = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnAdd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");

                strCodeForCs.AppendFormat("\r\n" + "this.lv{0} = new System.Windows.Forms.ListView();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition = new System.Windows.Forms.GroupBox();");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.SuspendLayout();");

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 18;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            case "ComboBox":
                            case "DropDownList":

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                     objQryRegionFldsEx.CtrlId4Win);

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity  ==  false && objQryRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;	//�ֶ������1
                }

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(192, 144);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                    intIndex++);
                // 
                // btnAdd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnAdd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Location = new System.Drawing.Point(408, 137);");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Name = \"btnAdd\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnAdd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnAdd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Click +=  new System.EventHandler(this.btnAdd_Click);");
                // 
                // 
                // btnUpdate
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnUpdate");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Location = new System.Drawing.Point(496, 137);");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Name = \"btnUpdate\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnUpdate.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Text = \"�޸�\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Click +=  new System.EventHandler(this.btnUpdate_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(576, 137);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"ɾ����¼\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click +=  new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"����Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click +=  new System.EventHandler(this.btnExportExcel4Dg_Click);");
                //
                //��ѯ��ť<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(328, 137);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"��ѯ\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click +=  new System.EventHandler(this.btnQuery_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(752, 144);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"��¼��:\";");


                // 
                // lv{0}
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// lv{0}",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Dock = System.Windows.Forms.DockStyle.Fill;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Location = new System.Drawing.Point(0, 176);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Name = \"lv{0}\";",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Size = new System.Drawing.Size(1000, 524);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ColumnClick +=  new System.Windows.Forms.ColumnClickEventHandler(this.lv{0}_ColumnClick);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.TabIndex = {1};",
                    objViewInfoENEx.TabName_Out,
                    intIndex++);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.View = System.Windows.Forms.View.Details;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Click +=  new System.EventHandler(this.lv{0}_Click);",
                    objViewInfoENEx.TabName_Out);

                // 
                // gbQueryCondition
                // 
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.Controls.Add({0});",
                        strCtlName);
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnUpdate);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnAdd);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblRecNum);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Name = \"gbQueryCondition\";");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);");
                strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.TabStop = false;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Text = \"��ѯ����\";");

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                // 
                // frm{0}_QD_LV
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QD_LV",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                //				strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(1000, 700);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.lv{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.gbQueryCondition);");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");

                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_QD_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }


                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnUpdate;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnAdd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.GroupBox gbQueryCondition;");

                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.ListView lv{0};",
                    objViewInfoENEx.TabName_Out);

                //���߲�:����this.load����

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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }

        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithDGV_NoContral_Net2005_Design()
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_DGV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_DGV.Designer.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_DGV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_QD_DGV", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

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
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
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

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnUpdate = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnAdd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0} = new System.Windows.Forms.DataGridView();",
                    objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0} = new System.Windows.Forms.DataGridViewTextBoxColumn();",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition = new System.Windows.Forms.GroupBox();");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.SuspendLayout();");

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 18;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            case "ComboBox":
                            case "DropDownList":
                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity  ==  false && objQryRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;	//�ֶ������1
                }

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(192, 144);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                    intIndex++);
                // 
                // btnAdd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnAdd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Location = new System.Drawing.Point(408, 137);");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Name = \"btnAdd\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnAdd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnAdd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Click +=  new System.EventHandler(this.btnAdd_Click);");
                // 
                // 
                // btnUpdate
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnUpdate");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Location = new System.Drawing.Point(496, 137);");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Name = \"btnUpdate\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnUpdate.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Text = \"�޸�\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Click +=  new System.EventHandler(this.btnUpdate_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(576, 137);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"ɾ����¼\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click +=  new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"����Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click +=  new System.EventHandler(this.btnExportExcel4Dg_Click);");
                //
                //��ѯ��ť<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(328, 137);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"��ѯ\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click +=  new System.EventHandler(this.btnQuery_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(752, 144);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"��¼��:\";");


                // 
                // dgv{0}
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// dgv{0}",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] ",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                for (int i = 0; i < objViewInfoENEx.arrDGRegionFldSet.Count; i++)
                {
                    clsDGRegionFldsENEx ObjLstViewRegionFldsEx = objViewInfoENEx.arrDGRegionFldSet[i] as clsDGRegionFldsENEx;
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        if (i + 1 == objViewInfoENEx.arrDGRegionFldSet.Count)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}",
                             ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "});");
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0},",
                                ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        }
                    }
                }


                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Dock = System.Windows.Forms.DockStyle.Fill;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Location = new System.Drawing.Point(0, 176);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Name = \"dgv{0}\";",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Size = new System.Drawing.Size(1000, 524);",
                    objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.ColumnClick +=  new System.Windows.Forms.ColumnClickEventHandler(this.dgv{0}_ColumnClick);",
                //    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.TabIndex = {1};",
                    objViewInfoENEx.TabName_Out,
                    intIndex++);
                //strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.View = System.Windows.Forms.View.Details;",
                //    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.CellClick +=  new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv{0}_CellClick);",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Click +=  new System.EventHandler(this.dgv{0}_Click);",
                    objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {

                        strCodeForCs.Append("\r\n" + "// ");
                        strCodeForCs.AppendFormat("\r\n" + "// dgvc{0}",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "// ");
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.DataPropertyName = \"{0}\";",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.HeaderText = \"{1}\";",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName,
                            ObjLstViewRegionFldsEx.HeaderText);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.Name = \"dgvc{0}\";",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.Visible = true;",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                // 
                // gbQueryCondition
                // 
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.Controls.Add({0});",
                        strCtlName);
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnUpdate);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnAdd);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblRecNum);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Name = \"gbQueryCondition\";");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);");
                strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.TabStop = false;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Text = \"��ѯ����\";");

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                // 
                // frm{0}_QD_LV
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QD_LV",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                //				strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(1000, 700);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.dgv{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.gbQueryCondition);");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");

                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_QD_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }


                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnUpdate;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnAdd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.GroupBox gbQueryCondition;");

                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridView dgv{0};",
                    objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridViewTextBoxColumn dgvc{0};",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                //���߲�:����this.load����

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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }
     

        /// <summary>
        /// �������ڱ༭ĳ����Ľ���,����:�޸ġ����,�ý�����Ҫ���ڱ���������������
        /// ע:��ʹ�ÿؼ�(NoContral)
        /// </summary>
        /// <returns></returns>
        public string A_GenUpdInsRecCode_NoContral()
        {
            Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();     //�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //���༭����
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_UI.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                clsProjectsEN objProject = clsProjectsBLEx.GetProjectsENExObjByPrjId(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
                strCodeForCs.Append("\r\n" + "using CommFunc4Win;");


                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "///		frm{0}_UI ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class frm{0}_UI : System.Windows.Forms.Form", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnClose;");
                strCodeForCs.AppendFormat("\r\n" + "private string {0};		//���ڴ��ݹؼ���ֵ�ı���",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "public string OperateType;");
                strCodeForCs.Append("\r\n" + "public IBindListView iBindListView = null;");


                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// ����������������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_UI()",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �õ����� Windows.Forms ���������������ġ�");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: �� InitializeComponent ���ú�����κγ�ʼ��");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //���岽:������������ʹ�õ���Դ
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n" + "/// <summary> ");
                strCodeForCs.Append("\r\n" + "/// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n" + "/// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n" + "/// </summary>");
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
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
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
                        //end of if(objEditRegionFldsEx.IsIdentity  ==  false && objEditRegionFldsEx.IsCtlField  ==  true)
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
                    fltCtlWidth / 4,
                    fltCtlHeight + 30);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click +=  new System.EventHandler(this.btnOKUpd_Click);");

                // 
                // btnClose
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnClose");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnClose.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4 + 120,
                    fltCtlHeight + 30);
                strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"�ر�\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Click +=  new System.EventHandler(this.btnClose_Click);");
                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4,
                    fltCtlHeight + 60);
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
                    fltCtlWidth + 30,
                    fltCtlHeight + 100);
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
                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_UI_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //���߲�:����this.load����

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_UI_Load(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");

                strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                //1��Ϊ��������������Դ,���б�����
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.Append("\r\n" + "if (OperateType  ==  \"Update\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ�����\";");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //����������İ󶨺���
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ������İ󶨺���");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.BindCbo_{0}(this.ddl{1});",
                            objEditRegionFldEx.ObjFieldTabENEx.FldName,
                            objEditRegionFldEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //�������Ա���:
                //�ڰ˲�:���ɿؼ�����,һ��Ϊÿ���ڲ��ؼ�����Ӧ����һ������

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                            objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":    ///����ؼ���������;
								if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString()  ==  \"0\")",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":     ///����ؼ��������ı���;
								strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //����༭���������ؼ���
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                        objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
								strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, strInitValue);

                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n" + "/// һ�����:");
                strCodeForCs.Append("\r\n" + "///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n" + "///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n" + "///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n" + "///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n" + "///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
								strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                              objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n" + "/// һ�����:");
                strCodeForCs.Append("\r\n" + "///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n" + "///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n" + "///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n" + "///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n" + "///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strTemp = clsPubFun4GC.GenGetCurrMonth();
                strCodeForCs.Append(strTemp);
                strTemp = clsPubFun4GC.GenGetTodayStr();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                strTemp = GenComboBoxBindFunction();
                strCodeForCs.Append(strTemp);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                            objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId4Win,
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ�岽:����һЩ�ж��������͵ĵĹ�������

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);



                //��ʮ����:������ʾ���ݺ���(ShowData)У�麯����

                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n" + GenShowDataCode_Win());
                }

                //��ʮ����:���ɰ�����������������ʾ��������;
                strTemp = GenGetDataFromClass();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�://����ȷ���޸ĵ��¼�����
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n" + "///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.Append("\r\n" + "Button btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"���\":");
                objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //����༭���������ؼ���
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "SetKeyReadOnly(false);",
                            objViewInfoENEx.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ�����\";");
                //��ȡ���ֵ
                strCodeForCs.AppendFormat("\r\n" + "//this.{1} = cls{0}BL.GetMaxStrId_S();",
                    objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);

                strCodeForCs.Append("\r\n" + "break;				");
                strCodeForCs.Append("\r\n" + "case \"ȷ�����\":");
                strCodeForCs.Append("\r\n" + "//����һ������Ĳ���Ĵ���,�����߼���̫��,");
                strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"ȷ���޸�\":");
                strCodeForCs.Append("\r\n" + "//����һ��������޸ĵĴ���,�����߼���̫��,");
                strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");

                strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�岽:���ɰѽ����ϵ��������ݴ���������еĴ���
                strTemp = GenPutDataToClass();
                strCodeForCs.Append(strTemp);
                //��ʮ����:���ɹرմ���ĵĵ����¼�����
                strCodeForCs.Append("\r\n" + "private void btnClose_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.Close();");
                strCodeForCs.Append("\r\n" + "}");
                //				//��ʮ����:�������ڴ��ݹؼ���ֵ�����Ժ���
                strCodeForCs.AppendFormat("\r\n" + "public {0} {1}_key",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return {0};",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} = value;",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //��Ӽ�¼׼������
                strTemp = GenAddRecordCode();
                strCodeForCs.Append(strTemp);

                //��Ӽ�¼���̹���
                strTemp = GenAddRecordSaveCode();
                strCodeForCs.Append(strTemp);

                //				//��Ӽ�¼���̹���V5��
                //				strTemp = GenAddRecordSaveCodeV5();
                //				strCodeForCs.Append(strTemp);
                //�޸ļ�¼���̹���
                strTemp = GenUpdateRecordSaveCode();
                strCodeForCs.Append(strTemp);
                //				//�޸ļ�¼���̹���V5��
                //				strTemp = GenUpdateRecordSaveCodeV5();
                //				strCodeForCs.Append(strTemp);


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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �������ڱ༭ĳ����Ľ���,����:�޸ġ����,�ý�����Ҫ���ڱ���������������
        /// ע:��ʹ�ÿؼ�(NoContral)
        /// </summary>
        /// <returns></returns>
        public string A_GenUpdInsRecCode_NoContral_Net2005()
        {
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;

            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //���༭����
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_UI.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "");

                clsProjectsEN objProject = clsProjectsBLEx.GetProjectsENExObjByPrjId(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
                strCodeForCs.Append("\r\n" + "using CommFunc4Win;");


                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_UI ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class frm{0}_UI : System.Windows.Forms.Form", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private {1} {0};		//���ڴ��ݹؼ���ֵ�ı���",
                    objKeyField.ObjFieldTabENEx.PrivPropName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "public string OperateType;");
                strCodeForCs.Append("\r\n" + "public IBindListView iBindListView = null;");

                //���Ĳ�:���ɱ�������������
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_UI()",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �õ����� Windows.Forms ���������������ġ�");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: �� InitializeComponent ���ú�����κγ�ʼ��");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //���岽:������������ʹ�õ���Դ
                //������:�����������ɵĴ���


                //���߲�:����this.load����

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_UI_Load(object sender, System.EventArgs e)",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");

                strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                //1��Ϊ��������������Դ,���б�����
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.Append("\r\n" + "if (OperateType  ==  \"Update\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                                objViewInfoENEx.TabName);
                //                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ�����\";");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //����������İ󶨺���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������İ󶨺���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.BindCbo_{0}(this.cbo{1});",
                            objEditRegionFldEx.ObjFieldTabENEx.FldName,
                            objEditRegionFldEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //�������Ա���:
                //�ڰ˲�:���ɿؼ�����,һ��Ϊÿ���ڲ��ؼ�����Ӧ����һ������

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                            objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":    ///����ؼ���������;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString()  ==  \"0\")",
                                        objEditRegionFldsEx.CtrlId4Win);

                                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "long"
                                        || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                                        || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short")
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse( {0}.SelectedValue.ToString());",
                                         objEditRegionFldsEx.CtrlId4Win,
                                         objEditRegionFldsEx.ObjFieldTabENEx.CsType());
                                    }
                                    else
                                    {

                                        strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                             objEditRegionFldsEx.CtrlId4Win);
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "long"
                                        || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                                        || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short")
                                    {
                                        strCodeForCs.Append("\r\n" + "if (value  ==  0)");
                                    }
                                    else
                                    {
                                        strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":     ///����ؼ��������ı���;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

                //�ھŲ�:�������ÿؼ��йؼ���ֻ�����ԡ�SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)	//����༭���������ؼ���
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ��:����Clear()������������ʼ���ؼ����ڲ��ؼ���ֵ��

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                        objEditRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                        objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                       objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮһ��:��������ȱʡֵ�ĺ��������øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n ///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n ///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":    ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                    objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":     ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                               objEditRegionFldsEx.CtrlId4Win, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                //��ʮ����:����У�麯��(IsValid())��У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                                objEditRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ����:���ɻ�ȡ��ǰ���ڵ��ַ���(getTodayStr) ��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strTemp = clsPubFun4GC.GenGetCurrMonth();
                strCodeForCs.Append(strTemp);
                strTemp = clsPubFun4GC.GenGetTodayStr();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�:���ɿؼ����������BIND����,������������б���ĺ���;
                strTemp = GenComboBoxBindFunction();
                strCodeForCs.Append(strTemp);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "ComboBox")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                            objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId4Win,
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //��ʮ�岽:����һЩ�ж��������͵ĵĹ�������

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);



                //��ʮ����:������ʾ���ݺ���(ShowData)У�麯����

                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n" + GenShowDataCode_Win());
                }

                //��ʮ����:���ɰ�����������������ʾ��������;
                strTemp = GenGetDataFromClass();
                strCodeForCs.Append(strTemp);

                //��ʮ�Ĳ�://����ȷ���޸ĵ��¼�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                //strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.Append("\r\n" + "Button btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"���\":");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "break;				");
                strCodeForCs.Append("\r\n" + "case \"ȷ�����\":");
                strCodeForCs.Append("\r\n" + "//����һ������Ĳ���Ĵ���,�����߼���̫��,");
                strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"ȷ���޸�\":");
                strCodeForCs.Append("\r\n" + "//����һ��������޸ĵĴ���,�����߼���̫��,");
                strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");

                strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //��ʮ�岽:���ɰѽ����ϵ��������ݴ���������еĴ���
                strTemp = GenPutDataToClass();
                strCodeForCs.Append(strTemp);
                //��ʮ����:���ɹرմ���ĵĵ����¼�����
                strCodeForCs.Append("\r\n" + "private void btnClose_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.Close();");
                strCodeForCs.Append("\r\n" + "}");
                //				//��ʮ����:�������ڴ��ݹؼ���ֵ�����Ժ���
                strCodeForCs.AppendFormat("\r\n" + "public {0} {1}_key",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return {0};",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} = value;",
                    objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //��Ӽ�¼׼������
                strTemp = GenAddRecordCode();
                strCodeForCs.Append(strTemp);

                //��Ӽ�¼���̹���
                strTemp = GenAddRecordSaveCode();
                strCodeForCs.Append(strTemp);

                //				//��Ӽ�¼���̹���V5��
                //				strTemp = GenAddRecordSaveCodeV5();
                //				strCodeForCs.Append(strTemp);
                //�޸ļ�¼���̹���
                strTemp = GenUpdateRecordSaveCode();
                strCodeForCs.Append(strTemp);
                //				//�޸ļ�¼���̹���V5��
                //				strTemp = GenUpdateRecordSaveCodeV5();
                //				strCodeForCs.Append(strTemp);


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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �������ڱ༭ĳ����Ľ���,����:�޸ġ����,�ý�����Ҫ���ڱ���������������
        /// ע:��ʹ�ÿؼ�(NoContral)
        /// </summary>
        /// <returns></returns>
        public string A_GenUpdInsRecCode_NoContral_Net2005_Design()
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //���༭����
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_UI.Designer.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
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
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
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
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
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
                        //end of if(objEditRegionFldsEx.IsIdentity  ==  false && objEditRegionFldsEx.IsCtlField  ==  true)
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
                    fltCtlWidth / 4,
                    fltCtlHeight + 30);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click +=  new System.EventHandler(this.btnOKUpd_Click);");

                // 
                // btnClose
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnClose");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnClose.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4 + 120,
                    fltCtlHeight + 30);
                strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"�ر�\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Click +=  new System.EventHandler(this.btnClose_Click);");
                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4,
                    fltCtlHeight + 60);
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
                    fltCtlWidth + 30,
                    fltCtlHeight + 100);
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
                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_UI_Load);",
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
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }


        ///���¾��ǽ��������(VIEW) ==  == = 

        public string A_GenViewCode_Win_New(Encoding myEncoding, clsViewInfoENEx objViewInfoENEx)
        {
            //switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
            //{
            //    case enumViewTypeCodeTab.Table_Update_2:// "0002":	//�����޸�
            //                                          //return A_GenUpdRecCode();
            //    case enumViewTypeCodeTab.Table_Query_3:// "0003":	//�����ѯ
            //                                         //return A_GenQueryRecCode(myEncoding, objViewInfoENEx);

            //    case enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20:// "0020":	//�����QUDI_GridView
            //                                                        //return A_GenQueryUpdDelInsRecCode();
            //    case enumViewTypeCodeTab.Table_QUDI_4:// "0004":	//�����QUDI
            //                                        //return A_GenQueryUpdDelInsRecCode();
            //                                        //case enumViewTypeCodeTab.Table_QUDI_LV:// "0008":	//�����QUDI_LV,Windows��,��ʾ��ListView
            //                                        //return A_GenQueryUpdDelInsRecCodeWithLV_New();
            //                                        //case enumViewTypeCodeTab.Table_UI_9:// "0009":	//�����UI,����༭,����:�޸ġ����
            //                                        //    return A_GenUpdInsRecCode();
            //                                        //case enumViewTypeCodeTab.Table_QD_InvokeUI:// "0010":	//�����QD,����UI,����༭,����:�޸ġ����
            //                                        //return A_GenQueryDelAffitUpdInsRecCodeWithLV();
            //    case enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11:// "0011":	//�������Ͻ���,����������(��ѯ��ɾ��)���ӽ���(�޸ġ����)QD,����UI,����༭,����:�޸ġ����
            //        if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.MainView && objViewInfoENEx.IsUseCtl == true)
            //        {
            //            //return A_GenQueryDelAffitUpdInsRecCodeWithLV();
            //        }
            //        else if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.MainView && objViewInfoENEx.IsUseCtl == false)
            //        {
            //            //if (objViewInfoENEx.NetVersion == "2005")
            //            //{
            //                if (objViewInfoENEx.IsDesign)
            //                {
            //                    return A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005_Design();
            //                }
            //                else
            //                {
            //                    return A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005();
            //                }
            //            //}
            //            //else
            //            //{
            //            //    return A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral();
            //            //}
            //        }
            //        else if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.SubView && objViewInfoENEx.IsUseCtl == true)
            //        {
            //            //return A_GenUpdInsRecCode();
            //        }
            //        else if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.SubView && objViewInfoENEx.IsUseCtl == false)
            //        {
            //            //if (objViewInfoENEx.NetVersion == "2005")
            //            //{
            //                if (objViewInfoENEx.IsDesign)
            //                {
            //                    return A_GenUpdInsRecCode_NoContral_Net2005_Design();
            //                }
            //                else
            //                {
            //                    return A_GenUpdInsRecCode_NoContral_Net2005();
            //                }
            //            //}
            //            //else
            //            //{
            //            //    return A_GenUpdInsRecCode_NoContral();
            //            //}
            //        }
            //        break;
            //    default:
            //        clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
            //        string strMsg = string.Format("�������ͣ�[{0}({1})]�ں���:[{2}]��û�б�����,����ϵ����Ա!",
            //            objViewTypeCodeTabEN.ViewTypeName,
            //            objViewInfoENEx.ViewTypeCode,
            //            clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //}
            return "";
        }

  
        public string GenCombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition()", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '1'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '0'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '1'\"; ",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '0'\";",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenCombineConditionWithSel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition(bool bolIsWithTabName)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                strCodeForCs.Append("\r\n" + "if (bolIsWithTabName  ==  true)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '1'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '0'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '1'\"; ",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '0'\";",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '1'\";",
                                objQryRegionFldsEx.FldName);
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '0'\";",
                                objQryRegionFldsEx.FldName);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '1'\"; ",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '0'\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenCombineConditionWithTabName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition(string strTabName)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {1} + \".{0} = '1'\";",
                                objQryRegionFldsEx.FldName, "strTabName");
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {1} + \".{0} = '0'\";",
                                objQryRegionFldsEx.FldName, "strTabName");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {0} + \".{1} = '1'\"; ",
                                    "strTabName", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {0} + \".{1} = '0'\";",
                                    "strTabName", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} + \".{0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} + \".{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} +\".{0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} +\".{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} + \".{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //��ʮ��:���ɻ�ȡListView�е�ǰ�е�����ֵ��
        /// <summary>
        /// ����LISTVIEW �е�����������
        /// </summary>
        /// <returns></returns>

      
    }
}

