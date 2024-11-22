
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PapersBigTopicDefaultBLEx
 表名:cc_PapersBigTopicDefault(01120088)
 生成代码版本:2022.11.19.1
 生成日期:2022/11/19 12:05:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_cc_PapersBigTopicDefaultEx: RelatedActions_cc_PapersBigTopicDefault
{
public override bool UpdRelaTabDate(string strPapersBigTopicDefaultId, string strOpUser)
{
return true;
}
}
public static class clscc_PapersBigTopicDefaultBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <returns>目标对象=>clscc_PapersBigTopicDefaultEN:objcc_PapersBigTopicDefaultENT</returns>
 public static clscc_PapersBigTopicDefaultENEx CopyToEx(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENS)
{
try
{
 clscc_PapersBigTopicDefaultENEx objcc_PapersBigTopicDefaultENT = new clscc_PapersBigTopicDefaultENEx();
clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.CopyTo(objcc_PapersBigTopicDefaultENS, objcc_PapersBigTopicDefaultENT);
 return objcc_PapersBigTopicDefaultENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <returns>目标对象=>clscc_PapersBigTopicDefaultEN:objcc_PapersBigTopicDefaultENT</returns>
 public static clscc_PapersBigTopicDefaultEN CopyTo(this clscc_PapersBigTopicDefaultENEx objcc_PapersBigTopicDefaultENS)
{
try
{
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENT = new clscc_PapersBigTopicDefaultEN();
clscc_PapersBigTopicDefaultBL.CopyTo(objcc_PapersBigTopicDefaultENS, objcc_PapersBigTopicDefaultENT);
 return objcc_PapersBigTopicDefaultENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 试卷大题目默认(cc_PapersBigTopicDefault)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_PapersBigTopicDefaultBLEx : clscc_PapersBigTopicDefaultBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_PapersBigTopicDefaultDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_PapersBigTopicDefaultDAEx cc_PapersBigTopicDefaultDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_PapersBigTopicDefaultDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <returns>目标对象=>clscc_PapersBigTopicDefaultEN:objcc_PapersBigTopicDefaultENT</returns>
 public static clscc_PapersBigTopicDefaultENEx CopyToEx(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENS)
{
try
{
 clscc_PapersBigTopicDefaultENEx objcc_PapersBigTopicDefaultENT = new clscc_PapersBigTopicDefaultENEx();
clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.CopyTo(objcc_PapersBigTopicDefaultENS, objcc_PapersBigTopicDefaultENT);
 return objcc_PapersBigTopicDefaultENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
public static List<clscc_PapersBigTopicDefaultENEx> GetObjExLst(string strCondition)
{
List <clscc_PapersBigTopicDefaultEN> arrObjLst = clscc_PapersBigTopicDefaultBL.GetObjLst(strCondition);
List <clscc_PapersBigTopicDefaultENEx> arrObjExLst = new List<clscc_PapersBigTopicDefaultENEx>();
foreach (clscc_PapersBigTopicDefaultEN objInFor in arrObjLst)
{
clscc_PapersBigTopicDefaultENEx objcc_PapersBigTopicDefaultENEx = new clscc_PapersBigTopicDefaultENEx();
clscc_PapersBigTopicDefaultBL.CopyTo(objInFor, objcc_PapersBigTopicDefaultENEx);
arrObjExLst.Add(objcc_PapersBigTopicDefaultENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_PapersBigTopicDefaultENEx GetObjExByPapersBigTopicDefaultId(string strPapersBigTopicDefaultId)
{
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = clscc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
clscc_PapersBigTopicDefaultENEx objcc_PapersBigTopicDefaultENEx = new clscc_PapersBigTopicDefaultENEx();
clscc_PapersBigTopicDefaultBL.CopyTo(objcc_PapersBigTopicDefaultEN, objcc_PapersBigTopicDefaultENEx);
return objcc_PapersBigTopicDefaultENEx;
}
}
}