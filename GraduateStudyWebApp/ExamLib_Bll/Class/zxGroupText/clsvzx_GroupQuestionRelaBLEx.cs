
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupQuestionRelaBLEx
 表名:vzx_GroupQuestionRela(01120736)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/15 14:13:41
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
public static class clsvzx_GroupQuestionRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_GroupQuestionRelaEN:objvzx_GroupQuestionRelaENT</returns>
 public static clsvzx_GroupQuestionRelaENEx CopyToEx(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENS)
{
try
{
 clsvzx_GroupQuestionRelaENEx objvzx_GroupQuestionRelaENT = new clsvzx_GroupQuestionRelaENEx();
clsvzx_GroupQuestionRelaBL.vzx_GroupQuestionRelaDA.CopyTo(objvzx_GroupQuestionRelaENS, objvzx_GroupQuestionRelaENT);
 return objvzx_GroupQuestionRelaENT;
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
 /// <param name = "objvzx_GroupQuestionRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_GroupQuestionRelaEN:objvzx_GroupQuestionRelaENT</returns>
 public static clsvzx_GroupQuestionRelaEN CopyTo(this clsvzx_GroupQuestionRelaENEx objvzx_GroupQuestionRelaENS)
{
try
{
 clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENT = new clsvzx_GroupQuestionRelaEN();
clsvzx_GroupQuestionRelaBL.CopyTo(objvzx_GroupQuestionRelaENS, objvzx_GroupQuestionRelaENT);
 return objvzx_GroupQuestionRelaENT;
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
 /// 小组问题关系视图(vzx_GroupQuestionRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_GroupQuestionRelaBLEx : clsvzx_GroupQuestionRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_GroupQuestionRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_GroupQuestionRelaDAEx vzx_GroupQuestionRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_GroupQuestionRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvzx_GroupQuestionRelaENEx> GetObjExLst(string strCondition)
{
List <clsvzx_GroupQuestionRelaEN> arrObjLst = clsvzx_GroupQuestionRelaBL.GetObjLst(strCondition);
List <clsvzx_GroupQuestionRelaENEx> arrObjExLst = new List<clsvzx_GroupQuestionRelaENEx>();
foreach (clsvzx_GroupQuestionRelaEN objInFor in arrObjLst)
{
clsvzx_GroupQuestionRelaENEx objvzx_GroupQuestionRelaENEx = new clsvzx_GroupQuestionRelaENEx();
clsvzx_GroupQuestionRelaBL.CopyTo(objInFor, objvzx_GroupQuestionRelaENEx);
arrObjExLst.Add(objvzx_GroupQuestionRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_GroupQuestionRelaENEx GetObjExBymId(long lngmId)
{
clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = clsvzx_GroupQuestionRelaBL.GetObjBymId(lngmId);
clsvzx_GroupQuestionRelaENEx objvzx_GroupQuestionRelaENEx = new clsvzx_GroupQuestionRelaENEx();
clsvzx_GroupQuestionRelaBL.CopyTo(objvzx_GroupQuestionRelaEN, objvzx_GroupQuestionRelaENEx);
return objvzx_GroupQuestionRelaENEx;
}
}
}