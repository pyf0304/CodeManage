
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_RTqa_PaperRelaBLEx
 表名:vzx_RTqa_PaperRela(01120875)
 生成代码版本:2022.11.19.1
 生成日期:2022/11/19 13:53:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_vzx_RTqa_PaperRelaEx: RelatedActions_vzx_RTqa_PaperRela
{
public override bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
public static class clsvzx_RTqa_PaperRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_RTqa_PaperRelaEN:objvzx_RTqa_PaperRelaENT</returns>
 public static clsvzx_RTqa_PaperRelaENEx CopyToEx(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENS)
{
try
{
 clsvzx_RTqa_PaperRelaENEx objvzx_RTqa_PaperRelaENT = new clsvzx_RTqa_PaperRelaENEx();
clsvzx_RTqa_PaperRelaBL.vzx_RTqa_PaperRelaDA.CopyTo(objvzx_RTqa_PaperRelaENS, objvzx_RTqa_PaperRelaENT);
 return objvzx_RTqa_PaperRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_RTqa_PaperRelaEN:objvzx_RTqa_PaperRelaENT</returns>
 public static clsvzx_RTqa_PaperRelaEN CopyTo(this clsvzx_RTqa_PaperRelaENEx objvzx_RTqa_PaperRelaENS)
{
try
{
 clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENT = new clsvzx_RTqa_PaperRelaEN();
clsvzx_RTqa_PaperRelaBL.CopyTo(objvzx_RTqa_PaperRelaENS, objvzx_RTqa_PaperRelaENT);
 return objvzx_RTqa_PaperRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// vzx_RTqa_PaperRela(vzx_RTqa_PaperRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_RTqa_PaperRelaBLEx : clsvzx_RTqa_PaperRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_RTqa_PaperRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_RTqa_PaperRelaDAEx vzx_RTqa_PaperRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_RTqa_PaperRelaDAEx();
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
public static List<clsvzx_RTqa_PaperRelaENEx> GetObjExLst(string strCondition)
{
List <clsvzx_RTqa_PaperRelaEN> arrObjLst = clsvzx_RTqa_PaperRelaBL.GetObjLst(strCondition);
List <clsvzx_RTqa_PaperRelaENEx> arrObjExLst = new List<clsvzx_RTqa_PaperRelaENEx>();
foreach (clsvzx_RTqa_PaperRelaEN objInFor in arrObjLst)
{
clsvzx_RTqa_PaperRelaENEx objvzx_RTqa_PaperRelaENEx = new clsvzx_RTqa_PaperRelaENEx();
clsvzx_RTqa_PaperRelaBL.CopyTo(objInFor, objvzx_RTqa_PaperRelaENEx);
arrObjExLst.Add(objvzx_RTqa_PaperRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_RTqa_PaperRelaENEx GetObjExBymId(long lngmId)
{
clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = clsvzx_RTqa_PaperRelaBL.GetObjBymId(lngmId);
clsvzx_RTqa_PaperRelaENEx objvzx_RTqa_PaperRelaENEx = new clsvzx_RTqa_PaperRelaENEx();
clsvzx_RTqa_PaperRelaBL.CopyTo(objvzx_RTqa_PaperRelaEN, objvzx_RTqa_PaperRelaENEx);
return objvzx_RTqa_PaperRelaENEx;
}
}
}