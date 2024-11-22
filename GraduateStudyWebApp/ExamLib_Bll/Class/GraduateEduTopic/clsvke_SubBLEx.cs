
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvke_SubBLEx
 表名:vke_Sub(01120659)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/08 14:18:20
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
public static class clsvke_SubBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvke_SubENS">源对象</param>
 /// <returns>目标对象=>clsvke_SubEN:objvke_SubENT</returns>
 public static clsvke_SubENEx CopyToEx(this clsvke_SubEN objvke_SubENS)
{
try
{
 clsvke_SubENEx objvke_SubENT = new clsvke_SubENEx();
clsvke_SubBL.vke_SubDA.CopyTo(objvke_SubENS, objvke_SubENT);
 return objvke_SubENT;
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
 /// <param name = "objvke_SubENS">源对象</param>
 /// <returns>目标对象=>clsvke_SubEN:objvke_SubENT</returns>
 public static clsvke_SubEN CopyTo(this clsvke_SubENEx objvke_SubENS)
{
try
{
 clsvke_SubEN objvke_SubENT = new clsvke_SubEN();
clsvke_SubBL.CopyTo(objvke_SubENS, objvke_SubENT);
 return objvke_SubENT;
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
 /// 知识经济子类视图(vke_Sub)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvke_SubBLEx : clsvke_SubBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvke_SubDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvke_SubDAEx vke_SubDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvke_SubDAEx();
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
public static List<clsvke_SubENEx> GetObjExLst(string strCondition)
{
List <clsvke_SubEN> arrObjLst = clsvke_SubBL.GetObjLst(strCondition);
List <clsvke_SubENEx> arrObjExLst = new List<clsvke_SubENEx>();
foreach (clsvke_SubEN objInFor in arrObjLst)
{
clsvke_SubENEx objvke_SubENEx = new clsvke_SubENEx();
clsvke_SubBL.CopyTo(objInFor, objvke_SubENEx);
arrObjExLst.Add(objvke_SubENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strke_SubId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvke_SubENEx GetObjExByke_SubId(string strke_SubId)
{
clsvke_SubEN objvke_SubEN = clsvke_SubBL.GetObjByKeSubId(strke_SubId);
clsvke_SubENEx objvke_SubENEx = new clsvke_SubENEx();
clsvke_SubBL.CopyTo(objvke_SubEN, objvke_SubENEx);
return objvke_SubENEx;
}
}
}