
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_RTqa_PaperRelaBLEx
 表名:zx_RTqa_PaperRela(01120865)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:56:33
 生成者:pyf
 生成服务器IP:103.116.76.183
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
public static class clszx_RTqa_PaperRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_RTqa_PaperRelaEN:objzx_RTqa_PaperRelaENT</returns>
 public static clszx_RTqa_PaperRelaENEx CopyToEx(this clszx_RTqa_PaperRelaEN objzx_RTqa_PaperRelaENS)
{
try
{
 clszx_RTqa_PaperRelaENEx objzx_RTqa_PaperRelaENT = new clszx_RTqa_PaperRelaENEx();
clszx_RTqa_PaperRelaBL.zx_RTqa_PaperRelaDA.CopyTo(objzx_RTqa_PaperRelaENS, objzx_RTqa_PaperRelaENT);
 return objzx_RTqa_PaperRelaENT;
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
 /// <param name = "objzx_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_RTqa_PaperRelaEN:objzx_RTqa_PaperRelaENT</returns>
 public static clszx_RTqa_PaperRelaEN CopyTo(this clszx_RTqa_PaperRelaENEx objzx_RTqa_PaperRelaENS)
{
try
{
 clszx_RTqa_PaperRelaEN objzx_RTqa_PaperRelaENT = new clszx_RTqa_PaperRelaEN();
clszx_RTqa_PaperRelaBL.CopyTo(objzx_RTqa_PaperRelaENS, objzx_RTqa_PaperRelaENT);
 return objzx_RTqa_PaperRelaENT;
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
 /// 中学答疑关系表(zx_RTqa_PaperRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_RTqa_PaperRelaBLEx : clszx_RTqa_PaperRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_RTqa_PaperRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_RTqa_PaperRelaDAEx zx_RTqa_PaperRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_RTqa_PaperRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_RTqa_PaperRelaEN:objzx_RTqa_PaperRelaENT</returns>
 public static clszx_RTqa_PaperRelaENEx CopyToEx(clszx_RTqa_PaperRelaEN objzx_RTqa_PaperRelaENS)
{
try
{
 clszx_RTqa_PaperRelaENEx objzx_RTqa_PaperRelaENT = new clszx_RTqa_PaperRelaENEx();
clszx_RTqa_PaperRelaBL.zx_RTqa_PaperRelaDA.CopyTo(objzx_RTqa_PaperRelaENS, objzx_RTqa_PaperRelaENT);
 return objzx_RTqa_PaperRelaENT;
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
public static List<clszx_RTqa_PaperRelaENEx> GetObjExLst(string strCondition)
{
List <clszx_RTqa_PaperRelaEN> arrObjLst = clszx_RTqa_PaperRelaBL.GetObjLst(strCondition);
List <clszx_RTqa_PaperRelaENEx> arrObjExLst = new List<clszx_RTqa_PaperRelaENEx>();
foreach (clszx_RTqa_PaperRelaEN objInFor in arrObjLst)
{
clszx_RTqa_PaperRelaENEx objzx_RTqa_PaperRelaENEx = new clszx_RTqa_PaperRelaENEx();
clszx_RTqa_PaperRelaBL.CopyTo(objInFor, objzx_RTqa_PaperRelaENEx);
arrObjExLst.Add(objzx_RTqa_PaperRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_RTqa_PaperRelaENEx GetObjExBymId(long lngmId)
{
clszx_RTqa_PaperRelaEN objzx_RTqa_PaperRelaEN = clszx_RTqa_PaperRelaBL.GetObjBymId(lngmId);
clszx_RTqa_PaperRelaENEx objzx_RTqa_PaperRelaENEx = new clszx_RTqa_PaperRelaENEx();
clszx_RTqa_PaperRelaBL.CopyTo(objzx_RTqa_PaperRelaEN, objzx_RTqa_PaperRelaENEx);
return objzx_RTqa_PaperRelaENEx;
}
}
}