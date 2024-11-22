
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_GroupQuestionRelaBLEx
 表名:zx_GroupQuestionRela(01120737)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/15 14:31:38
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文
 模块英文名:zxGroupText
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
public static class clszx_GroupQuestionRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_GroupQuestionRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupQuestionRelaEN:objzx_GroupQuestionRelaENT</returns>
 public static clszx_GroupQuestionRelaENEx CopyToEx(this clszx_GroupQuestionRelaEN objzx_GroupQuestionRelaENS)
{
try
{
 clszx_GroupQuestionRelaENEx objzx_GroupQuestionRelaENT = new clszx_GroupQuestionRelaENEx();
clszx_GroupQuestionRelaBL.zx_GroupQuestionRelaDA.CopyTo(objzx_GroupQuestionRelaENS, objzx_GroupQuestionRelaENT);
 return objzx_GroupQuestionRelaENT;
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
 /// <param name = "objzx_GroupQuestionRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupQuestionRelaEN:objzx_GroupQuestionRelaENT</returns>
 public static clszx_GroupQuestionRelaEN CopyTo(this clszx_GroupQuestionRelaENEx objzx_GroupQuestionRelaENS)
{
try
{
 clszx_GroupQuestionRelaEN objzx_GroupQuestionRelaENT = new clszx_GroupQuestionRelaEN();
clszx_GroupQuestionRelaBL.CopyTo(objzx_GroupQuestionRelaENS, objzx_GroupQuestionRelaENT);
 return objzx_GroupQuestionRelaENT;
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
 /// 小组问题关系(zx_GroupQuestionRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_GroupQuestionRelaBLEx : clszx_GroupQuestionRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_GroupQuestionRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_GroupQuestionRelaDAEx zx_GroupQuestionRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_GroupQuestionRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_GroupQuestionRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupQuestionRelaEN:objzx_GroupQuestionRelaENT</returns>
 public static clszx_GroupQuestionRelaENEx CopyToEx(clszx_GroupQuestionRelaEN objzx_GroupQuestionRelaENS)
{
try
{
 clszx_GroupQuestionRelaENEx objzx_GroupQuestionRelaENT = new clszx_GroupQuestionRelaENEx();
clszx_GroupQuestionRelaBL.zx_GroupQuestionRelaDA.CopyTo(objzx_GroupQuestionRelaENS, objzx_GroupQuestionRelaENT);
 return objzx_GroupQuestionRelaENT;
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
public static List<clszx_GroupQuestionRelaENEx> GetObjExLst(string strCondition)
{
List <clszx_GroupQuestionRelaEN> arrObjLst = clszx_GroupQuestionRelaBL.GetObjLst(strCondition);
List <clszx_GroupQuestionRelaENEx> arrObjExLst = new List<clszx_GroupQuestionRelaENEx>();
foreach (clszx_GroupQuestionRelaEN objInFor in arrObjLst)
{
clszx_GroupQuestionRelaENEx objzx_GroupQuestionRelaENEx = new clszx_GroupQuestionRelaENEx();
clszx_GroupQuestionRelaBL.CopyTo(objInFor, objzx_GroupQuestionRelaENEx);
arrObjExLst.Add(objzx_GroupQuestionRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_GroupQuestionRelaENEx GetObjExBymId(long lngmId)
{
clszx_GroupQuestionRelaEN objzx_GroupQuestionRelaEN = clszx_GroupQuestionRelaBL.GetObjBymId(lngmId);
clszx_GroupQuestionRelaENEx objzx_GroupQuestionRelaENEx = new clszx_GroupQuestionRelaENEx();
clszx_GroupQuestionRelaBL.CopyTo(objzx_GroupQuestionRelaEN, objzx_GroupQuestionRelaENEx);
return objzx_GroupQuestionRelaENEx;
}
}
}