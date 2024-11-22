
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResearchTopicBLEx
 表名:vResearchTopic(01120612)
 生成代码版本:2020.08.03.1
 生成日期:2020/08/03 13:51:03
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
public static class clsvResearchTopicBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvResearchTopicENS">源对象</param>
 /// <returns>目标对象=>clsvResearchTopicEN:objvResearchTopicENT</returns>
 public static clsvResearchTopicENEx CopyToEx(this clsvResearchTopicEN objvResearchTopicENS)
{
try
{
 clsvResearchTopicENEx objvResearchTopicENT = new clsvResearchTopicENEx();
clsvResearchTopicBL.vResearchTopicDA.CopyTo(objvResearchTopicENS, objvResearchTopicENT);
 return objvResearchTopicENT;
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
 /// <param name = "objvResearchTopicENS">源对象</param>
 /// <returns>目标对象=>clsvResearchTopicEN:objvResearchTopicENT</returns>
 public static clsvResearchTopicEN CopyTo(this clsvResearchTopicENEx objvResearchTopicENS)
{
try
{
 clsvResearchTopicEN objvResearchTopicENT = new clsvResearchTopicEN();
clsvResearchTopicBL.CopyTo(objvResearchTopicENS, objvResearchTopicENT);
 return objvResearchTopicENT;
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
 /// 研究主题视图(vResearchTopic)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvResearchTopicBLEx : clsvResearchTopicBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvResearchTopicDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvResearchTopicDAEx vResearchTopicDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvResearchTopicDAEx();
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
public static List<clsvResearchTopicENEx> GetObjExLst(string strCondition)
{
List <clsvResearchTopicEN> arrObjLst = clsvResearchTopicBL.GetObjLst(strCondition);
List <clsvResearchTopicENEx> arrObjExLst = new List<clsvResearchTopicENEx>();
foreach (clsvResearchTopicEN objInFor in arrObjLst)
{
clsvResearchTopicENEx objvResearchTopicENEx = new clsvResearchTopicENEx();
clsvResearchTopicBL.CopyTo(objInFor, objvResearchTopicENEx);
arrObjExLst.Add(objvResearchTopicENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvResearchTopicENEx GetObjExByTopicId(string strTopicId)
{
clsvResearchTopicEN objvResearchTopicEN = clsvResearchTopicBL.GetObjByTopicId(strTopicId);
clsvResearchTopicENEx objvResearchTopicENEx = new clsvResearchTopicENEx();
clsvResearchTopicBL.CopyTo(objvResearchTopicEN, objvResearchTopicENEx);
return objvResearchTopicENEx;
}
}
}