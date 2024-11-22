
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperParagraphVerBLEx
 表名:zx_PaperParagraphVer(01120760)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/12 15:18:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 public class RelatedActions_zx_PaperParagraphVerEx: RelatedActions_zx_PaperParagraphVer
{
public override bool UpdRelaTabDate(long lngParagraphVId, string strOpUser)
{
return true;
}
}
public static class clszx_PaperParagraphVerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperParagraphVerENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphVerEN:objzx_PaperParagraphVerENT</returns>
 public static clszx_PaperParagraphVerENEx CopyToEx(this clszx_PaperParagraphVerEN objzx_PaperParagraphVerENS)
{
try
{
 clszx_PaperParagraphVerENEx objzx_PaperParagraphVerENT = new clszx_PaperParagraphVerENEx();
clszx_PaperParagraphVerBL.zx_PaperParagraphVerDA.CopyTo(objzx_PaperParagraphVerENS, objzx_PaperParagraphVerENT);
 return objzx_PaperParagraphVerENT;
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
 /// <param name = "objzx_PaperParagraphVerENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphVerEN:objzx_PaperParagraphVerENT</returns>
 public static clszx_PaperParagraphVerEN CopyTo(this clszx_PaperParagraphVerENEx objzx_PaperParagraphVerENS)
{
try
{
 clszx_PaperParagraphVerEN objzx_PaperParagraphVerENT = new clszx_PaperParagraphVerEN();
clszx_PaperParagraphVerBL.CopyTo(objzx_PaperParagraphVerENS, objzx_PaperParagraphVerENT);
 return objzx_PaperParagraphVerENT;
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
 /// 作文段落版本(zx_PaperParagraphVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_PaperParagraphVerBLEx : clszx_PaperParagraphVerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_PaperParagraphVerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_PaperParagraphVerDAEx zx_PaperParagraphVerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_PaperParagraphVerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperParagraphVerENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphVerEN:objzx_PaperParagraphVerENT</returns>
 public static clszx_PaperParagraphVerENEx CopyToEx(clszx_PaperParagraphVerEN objzx_PaperParagraphVerENS)
{
try
{
 clszx_PaperParagraphVerENEx objzx_PaperParagraphVerENT = new clszx_PaperParagraphVerENEx();
clszx_PaperParagraphVerBL.zx_PaperParagraphVerDA.CopyTo(objzx_PaperParagraphVerENS, objzx_PaperParagraphVerENT);
 return objzx_PaperParagraphVerENT;
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
public static List<clszx_PaperParagraphVerENEx> GetObjExLst(string strCondition)
{
List <clszx_PaperParagraphVerEN> arrObjLst = clszx_PaperParagraphVerBL.GetObjLst(strCondition);
List <clszx_PaperParagraphVerENEx> arrObjExLst = new List<clszx_PaperParagraphVerENEx>();
foreach (clszx_PaperParagraphVerEN objInFor in arrObjLst)
{
clszx_PaperParagraphVerENEx objzx_PaperParagraphVerENEx = new clszx_PaperParagraphVerENEx();
clszx_PaperParagraphVerBL.CopyTo(objInFor, objzx_PaperParagraphVerENEx);
arrObjExLst.Add(objzx_PaperParagraphVerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngParagraphVId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_PaperParagraphVerENEx GetObjExByParagraphVId(long lngParagraphVId)
{
clszx_PaperParagraphVerEN objzx_PaperParagraphVerEN = clszx_PaperParagraphVerBL.GetObjByParagraphVId(lngParagraphVId);
clszx_PaperParagraphVerENEx objzx_PaperParagraphVerENEx = new clszx_PaperParagraphVerENEx();
clszx_PaperParagraphVerBL.CopyTo(objzx_PaperParagraphVerEN, objzx_PaperParagraphVerENEx);
return objzx_PaperParagraphVerENEx;
}
}
}