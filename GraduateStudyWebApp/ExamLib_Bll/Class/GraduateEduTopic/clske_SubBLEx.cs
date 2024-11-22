
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clske_SubBLEx
 表名:ke_Sub(01120660)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/08 14:18:24
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clske_SubBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objke_SubENS">源对象</param>
 /// <returns>目标对象=>clske_SubEN:objke_SubENT</returns>
 public static clske_SubENEx CopyToEx(this clske_SubEN objke_SubENS)
{
try
{
 clske_SubENEx objke_SubENT = new clske_SubENEx();
clske_SubBL.ke_SubDA.CopyTo(objke_SubENS, objke_SubENT);
 return objke_SubENT;
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
 /// <param name = "objke_SubENS">源对象</param>
 /// <returns>目标对象=>clske_SubEN:objke_SubENT</returns>
 public static clske_SubEN CopyTo(this clske_SubENEx objke_SubENS)
{
try
{
 clske_SubEN objke_SubENT = new clske_SubEN();
clske_SubBL.CopyTo(objke_SubENS, objke_SubENT);
 return objke_SubENT;
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
 /// 知识经济子类(ke_Sub)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clske_SubBLEx : clske_SubBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clske_SubDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clske_SubDAEx ke_SubDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clske_SubDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objke_SubENS">源对象</param>
 /// <returns>目标对象=>clske_SubEN:objke_SubENT</returns>
 public static clske_SubENEx CopyToEx(clske_SubEN objke_SubENS)
{
try
{
 clske_SubENEx objke_SubENT = new clske_SubENEx();
clske_SubBL.ke_SubDA.CopyTo(objke_SubENS, objke_SubENT);
 return objke_SubENT;
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
public static List<clske_SubENEx> GetObjExLst(string strCondition)
{
List <clske_SubEN> arrObjLst = clske_SubBL.GetObjLst(strCondition);
List <clske_SubENEx> arrObjExLst = new List<clske_SubENEx>();
foreach (clske_SubEN objInFor in arrObjLst)
{
clske_SubENEx objke_SubENEx = new clske_SubENEx();
clske_SubBL.CopyTo(objInFor, objke_SubENEx);
arrObjExLst.Add(objke_SubENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strke_SubId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clske_SubENEx GetObjExByke_SubId(string strke_SubId)
{
clske_SubEN objke_SubEN = clske_SubBL.GetObjByKeSubId(strke_SubId);
clske_SubENEx objke_SubENEx = new clske_SubENEx();
clske_SubBL.CopyTo(objke_SubEN, objke_SubENEx);
return objke_SubENEx;
}
}
}