﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidImageButtonBLEx
表名:AndroidImageButton
生成代码版本:2018.02.11.1
生成日期:2018/02/17 10:13:37
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成Android
模块英文名:GCAndroid
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;

using AGC.PureClass;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using AgcCommBase;
using AGC.Entity;

namespace AGC.PureClassEx
{
    public static class clsAndroidImageButtonBLEx_Static
    {

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidImageButtonENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidImageButtonEx objAndroidImageButtonENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();


            strCodeForCs.AppendFormat("\r\n" + "<ImageButton");

            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidImageButtonENEx.CtrlId);

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidImageButtonENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidImageButtonENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidImageButtonENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidImageButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidImageButtonENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    objAndroidImageButtonENEx.OnClick);
            }
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidImageButtonENEx.Text);
            if (string.IsNullOrEmpty(objAndroidImageButtonENEx.mTextSize) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:textSize=\"{0}\"",
                    objAndroidImageButtonENEx.mTextSize);
            }

            if (string.IsNullOrEmpty(objAndroidImageButtonENEx.minHeight) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:minHeight=\"{0}\"",
                    objAndroidImageButtonENEx.minHeight);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidImageButtonENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidImageButtonENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(strCodeForCs);
            //}


        }
    }
        /// <summary>
        /// Android按钮(AndroidImageButton)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidImageButtonBLEx 
    {
                 
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidImageButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidImageButtonEx objAndroidImageButtonENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private ImageButton {0};",
                objAndroidImageButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidImageButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidImageButtonEx objAndroidImageButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (ImageButton)findViewById(R.id.btn{0}); ",
                objAndroidImageButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidImageButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidImageButtonEx objAndroidImageButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (ImageButton)view.findViewById(R.id.btn{0}); ",
                objAndroidImageButtonENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidImageButtonENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidImageButtonEx objAndroidImageButtonENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidImageButtonENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidImageButtonENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidImageButtonENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidImageButtonENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objAndroidImageButtonENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
    }
}