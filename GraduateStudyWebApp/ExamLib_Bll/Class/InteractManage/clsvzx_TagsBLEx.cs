
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TagsBLEx
 表名:vzx_Tags(01120854)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:01:06
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvzx_TagsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_TagsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TagsEN:objvzx_TagsENT</returns>
 public static clsvzx_TagsENEx CopyToEx(this clsvzx_TagsEN objvzx_TagsENS)
{
try
{
 clsvzx_TagsENEx objvzx_TagsENT = new clsvzx_TagsENEx();
clsvzx_TagsBL.vzx_TagsDA.CopyTo(objvzx_TagsENS, objvzx_TagsENT);
 return objvzx_TagsENT;
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
 /// <param name = "objvzx_TagsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TagsEN:objvzx_TagsENT</returns>
 public static clsvzx_TagsEN CopyTo(this clsvzx_TagsENEx objvzx_TagsENS)
{
try
{
 clsvzx_TagsEN objvzx_TagsENT = new clsvzx_TagsEN();
clsvzx_TagsBL.CopyTo(objvzx_TagsENS, objvzx_TagsENT);
 return objvzx_TagsENT;
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
 /// vzx_Tags(vzx_Tags)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_TagsBLEx : clsvzx_TagsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_TagsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_TagsDAEx vzx_TagsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_TagsDAEx();
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
public static List<clsvzx_TagsENEx> GetObjExLst(string strCondition)
{
List <clsvzx_TagsEN> arrObjLst = clsvzx_TagsBL.GetObjLst(strCondition);
List <clsvzx_TagsENEx> arrObjExLst = new List<clsvzx_TagsENEx>();
foreach (clsvzx_TagsEN objInFor in arrObjLst)
{
clsvzx_TagsENEx objvzx_TagsENEx = new clsvzx_TagsENEx();
clsvzx_TagsBL.CopyTo(objInFor, objvzx_TagsENEx);
arrObjExLst.Add(objvzx_TagsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_TagsENEx GetObjExByzxTagsId(string strzxTagsId)
{
clsvzx_TagsEN objvzx_TagsEN = clsvzx_TagsBL.GetObjByzxTagsId(strzxTagsId);
clsvzx_TagsENEx objvzx_TagsENEx = new clsvzx_TagsENEx();
clsvzx_TagsBL.CopyTo(objvzx_TagsEN, objvzx_TagsENEx);
return objvzx_TagsENEx;
}
}
}