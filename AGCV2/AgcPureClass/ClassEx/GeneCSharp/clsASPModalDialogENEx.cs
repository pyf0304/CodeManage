﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:ASPModalDialogEx
表名:ASPModalDialog(00050443)
生成代码版本:2019.04.13.1
生成日期:2019/04/19 09:59:07
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.PureClass
{
    /// <summary>
    /// ASP模态对话框(ASPModalDialog)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class ASPModalDialogEx : ASPModalDialog
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public ASPModalDialogEx()
        {

        }
        public Func<string> ContentFunc = null;
    }
}