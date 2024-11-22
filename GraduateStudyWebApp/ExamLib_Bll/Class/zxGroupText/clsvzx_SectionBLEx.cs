
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SectionBLEx
 表名:vzx_Section(01120834)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:00:38
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
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
public static class clsvzx_SectionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_SectionENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SectionEN:objvzx_SectionENT</returns>
 public static clsvzx_SectionENEx CopyToEx(this clsvzx_SectionEN objvzx_SectionENS)
{
try
{
 clsvzx_SectionENEx objvzx_SectionENT = new clsvzx_SectionENEx();
clsvzx_SectionBL.vzx_SectionDA.CopyTo(objvzx_SectionENS, objvzx_SectionENT);
 return objvzx_SectionENT;
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
 /// <param name = "objvzx_SectionENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SectionEN:objvzx_SectionENT</returns>
 public static clsvzx_SectionEN CopyTo(this clsvzx_SectionENEx objvzx_SectionENS)
{
try
{
 clsvzx_SectionEN objvzx_SectionENT = new clsvzx_SectionEN();
clsvzx_SectionBL.CopyTo(objvzx_SectionENS, objvzx_SectionENT);
 return objvzx_SectionENT;
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
 /// vzx_Section(vzx_Section)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_SectionBLEx : clsvzx_SectionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_SectionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_SectionDAEx vzx_SectionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_SectionDAEx();
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
public static List<clsvzx_SectionENEx> GetObjExLst(string strCondition)
{
List <clsvzx_SectionEN> arrObjLst = clsvzx_SectionBL.GetObjLst(strCondition);
List <clsvzx_SectionENEx> arrObjExLst = new List<clsvzx_SectionENEx>();
foreach (clsvzx_SectionEN objInFor in arrObjLst)
{
clsvzx_SectionENEx objvzx_SectionENEx = new clsvzx_SectionENEx();
clsvzx_SectionBL.CopyTo(objInFor, objvzx_SectionENEx);
arrObjExLst.Add(objvzx_SectionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxSectionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_SectionENEx GetObjExByzxSectionId(string strzxSectionId)
{
clsvzx_SectionEN objvzx_SectionEN = clsvzx_SectionBL.GetObjByzxSectionId(strzxSectionId);
clsvzx_SectionENEx objvzx_SectionENEx = new clsvzx_SectionENEx();
clsvzx_SectionBL.CopyTo(objvzx_SectionEN, objvzx_SectionENEx);
return objvzx_SectionENEx;
}
}
}