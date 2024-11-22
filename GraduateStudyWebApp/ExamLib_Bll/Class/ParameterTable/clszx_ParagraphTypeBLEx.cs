
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ParagraphTypeBLEx
 表名:zx_ParagraphType(01120821)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:59:48
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数
 模块英文名:ParameterTable
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
public static class clszx_ParagraphTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ParagraphTypeEN:objzx_ParagraphTypeENT</returns>
 public static clszx_ParagraphTypeENEx CopyToEx(this clszx_ParagraphTypeEN objzx_ParagraphTypeENS)
{
try
{
 clszx_ParagraphTypeENEx objzx_ParagraphTypeENT = new clszx_ParagraphTypeENEx();
clszx_ParagraphTypeBL.zx_ParagraphTypeDA.CopyTo(objzx_ParagraphTypeENS, objzx_ParagraphTypeENT);
 return objzx_ParagraphTypeENT;
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
 /// <param name = "objzx_ParagraphTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ParagraphTypeEN:objzx_ParagraphTypeENT</returns>
 public static clszx_ParagraphTypeEN CopyTo(this clszx_ParagraphTypeENEx objzx_ParagraphTypeENS)
{
try
{
 clszx_ParagraphTypeEN objzx_ParagraphTypeENT = new clszx_ParagraphTypeEN();
clszx_ParagraphTypeBL.CopyTo(objzx_ParagraphTypeENS, objzx_ParagraphTypeENT);
 return objzx_ParagraphTypeENT;
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
 /// 中学段落类型(zx_ParagraphType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ParagraphTypeBLEx : clszx_ParagraphTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ParagraphTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ParagraphTypeDAEx zx_ParagraphTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ParagraphTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ParagraphTypeEN:objzx_ParagraphTypeENT</returns>
 public static clszx_ParagraphTypeENEx CopyToEx(clszx_ParagraphTypeEN objzx_ParagraphTypeENS)
{
try
{
 clszx_ParagraphTypeENEx objzx_ParagraphTypeENT = new clszx_ParagraphTypeENEx();
clszx_ParagraphTypeBL.zx_ParagraphTypeDA.CopyTo(objzx_ParagraphTypeENS, objzx_ParagraphTypeENT);
 return objzx_ParagraphTypeENT;
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
public static List<clszx_ParagraphTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_ParagraphTypeEN> arrObjLst = clszx_ParagraphTypeBL.GetObjLst(strCondition);
List <clszx_ParagraphTypeENEx> arrObjExLst = new List<clszx_ParagraphTypeENEx>();
foreach (clszx_ParagraphTypeEN objInFor in arrObjLst)
{
clszx_ParagraphTypeENEx objzx_ParagraphTypeENEx = new clszx_ParagraphTypeENEx();
clszx_ParagraphTypeBL.CopyTo(objInFor, objzx_ParagraphTypeENEx);
arrObjExLst.Add(objzx_ParagraphTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxParagraphTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ParagraphTypeENEx GetObjExByzxParagraphTypeId(string strzxParagraphTypeId)
{
clszx_ParagraphTypeEN objzx_ParagraphTypeEN = clszx_ParagraphTypeBL.GetObjByzxParagraphTypeId(strzxParagraphTypeId);
clszx_ParagraphTypeENEx objzx_ParagraphTypeENEx = new clszx_ParagraphTypeENEx();
clszx_ParagraphTypeBL.CopyTo(objzx_ParagraphTypeEN, objzx_ParagraphTypeENEx);
return objzx_ParagraphTypeENEx;
}
}
}