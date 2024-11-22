
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UserGroupBLEx
 表名:zx_UserGroup(01120731)
 生成代码版本:2020.09.07.1
 生成日期:2020/09/09 09:07:45
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
public static class clszx_UserGroupBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_UserGroupENS">源对象</param>
 /// <returns>目标对象=>clszx_UserGroupEN:objzx_UserGroupENT</returns>
 public static clszx_UserGroupENEx CopyToEx(this clszx_UserGroupEN objzx_UserGroupENS)
{
try
{
 clszx_UserGroupENEx objzx_UserGroupENT = new clszx_UserGroupENEx();
clszx_UserGroupBL.zx_UserGroupDA.CopyTo(objzx_UserGroupENS, objzx_UserGroupENT);
 return objzx_UserGroupENT;
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
 /// <param name = "objzx_UserGroupENS">源对象</param>
 /// <returns>目标对象=>clszx_UserGroupEN:objzx_UserGroupENT</returns>
 public static clszx_UserGroupEN CopyTo(this clszx_UserGroupENEx objzx_UserGroupENS)
{
try
{
 clszx_UserGroupEN objzx_UserGroupENT = new clszx_UserGroupEN();
clszx_UserGroupBL.CopyTo(objzx_UserGroupENS, objzx_UserGroupENT);
 return objzx_UserGroupENT;
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
 /// 中学用户小组(zx_UserGroup)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_UserGroupBLEx : clszx_UserGroupBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_UserGroupDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_UserGroupDAEx zx_UserGroupDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_UserGroupDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_UserGroupENS">源对象</param>
 /// <returns>目标对象=>clszx_UserGroupEN:objzx_UserGroupENT</returns>
 public static clszx_UserGroupENEx CopyToEx(clszx_UserGroupEN objzx_UserGroupENS)
{
try
{
 clszx_UserGroupENEx objzx_UserGroupENT = new clszx_UserGroupENEx();
clszx_UserGroupBL.zx_UserGroupDA.CopyTo(objzx_UserGroupENS, objzx_UserGroupENT);
 return objzx_UserGroupENT;
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
public static List<clszx_UserGroupENEx> GetObjExLst(string strCondition)
{
List <clszx_UserGroupEN> arrObjLst = clszx_UserGroupBL.GetObjLst(strCondition);
List <clszx_UserGroupENEx> arrObjExLst = new List<clszx_UserGroupENEx>();
foreach (clszx_UserGroupEN objInFor in arrObjLst)
{
clszx_UserGroupENEx objzx_UserGroupENEx = new clszx_UserGroupENEx();
clszx_UserGroupBL.CopyTo(objInFor, objzx_UserGroupENEx);
arrObjExLst.Add(objzx_UserGroupENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_UserGroupENEx GetObjExBymId(long lngmId)
{
clszx_UserGroupEN objzx_UserGroupEN = clszx_UserGroupBL.GetObjBymId(lngmId);
clszx_UserGroupENEx objzx_UserGroupENEx = new clszx_UserGroupENEx();
clszx_UserGroupBL.CopyTo(objzx_UserGroupEN, objzx_UserGroupENEx);
return objzx_UserGroupENEx;
}
}
}