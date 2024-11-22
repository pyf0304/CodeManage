﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchResultAttachmentBLEx
 表名:gs_ResearchResultAttachment(01120779)
 生成代码版本:2020.12.17.1
 生成日期:2020/12/22 19:49:46
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clsgs_ResearchResultAttachmentBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsgs_ResearchResultAttachmentEN:objgs_ResearchResultAttachmentENT</returns>
 public static clsgs_ResearchResultAttachmentENEx CopyToEx(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENS)
{
try
{
 clsgs_ResearchResultAttachmentENEx objgs_ResearchResultAttachmentENT = new clsgs_ResearchResultAttachmentENEx();
clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.CopyTo(objgs_ResearchResultAttachmentENS, objgs_ResearchResultAttachmentENT);
 return objgs_ResearchResultAttachmentENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsgs_ResearchResultAttachmentEN:objgs_ResearchResultAttachmentENT</returns>
 public static clsgs_ResearchResultAttachmentEN CopyTo(this clsgs_ResearchResultAttachmentENEx objgs_ResearchResultAttachmentENS)
{
try
{
 clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENT = new clsgs_ResearchResultAttachmentEN();
clsgs_ResearchResultAttachmentBL.CopyTo(objgs_ResearchResultAttachmentENS, objgs_ResearchResultAttachmentENT);
 return objgs_ResearchResultAttachmentENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 研究成果附件表(gs_ResearchResultAttachment)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_ResearchResultAttachmentBLEx : clsgs_ResearchResultAttachmentBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_ResearchResultAttachmentDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_ResearchResultAttachmentDAEx gs_ResearchResultAttachmentDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_ResearchResultAttachmentDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsgs_ResearchResultAttachmentEN:objgs_ResearchResultAttachmentENT</returns>
 public static clsgs_ResearchResultAttachmentENEx CopyToEx(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENS)
{
try
{
 clsgs_ResearchResultAttachmentENEx objgs_ResearchResultAttachmentENT = new clsgs_ResearchResultAttachmentENEx();
clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.CopyTo(objgs_ResearchResultAttachmentENS, objgs_ResearchResultAttachmentENT);
 return objgs_ResearchResultAttachmentENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsgs_ResearchResultAttachmentENEx> GetObjExLst(string strCondition)
{
List <clsgs_ResearchResultAttachmentEN> arrObjLst = clsgs_ResearchResultAttachmentBL.GetObjLst(strCondition);
List <clsgs_ResearchResultAttachmentENEx> arrObjExLst = new List<clsgs_ResearchResultAttachmentENEx>();
foreach (clsgs_ResearchResultAttachmentEN objInFor in arrObjLst)
{
clsgs_ResearchResultAttachmentENEx objgs_ResearchResultAttachmentENEx = new clsgs_ResearchResultAttachmentENEx();
clsgs_ResearchResultAttachmentBL.CopyTo(objInFor, objgs_ResearchResultAttachmentENEx);
arrObjExLst.Add(objgs_ResearchResultAttachmentENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_ResearchResultAttachmentENEx GetObjExBymId(long lngmId)
{
clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = clsgs_ResearchResultAttachmentBL.GetObjBymId(lngmId);
clsgs_ResearchResultAttachmentENEx objgs_ResearchResultAttachmentENEx = new clsgs_ResearchResultAttachmentENEx();
clsgs_ResearchResultAttachmentBL.CopyTo(objgs_ResearchResultAttachmentEN, objgs_ResearchResultAttachmentENEx);
return objgs_ResearchResultAttachmentENEx;
}
}
}