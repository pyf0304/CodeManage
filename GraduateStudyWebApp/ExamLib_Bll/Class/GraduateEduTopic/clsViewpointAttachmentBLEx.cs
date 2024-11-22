
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointAttachmentBLEx
 表名:ViewpointAttachment(01120591)
 生成代码版本:2020.06.17.1
 生成日期:2020/06/18 16:37:34
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
public static class clsViewpointAttachmentBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objViewpointAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsViewpointAttachmentEN:objViewpointAttachmentENT</returns>
 public static clsViewpointAttachmentENEx CopyToEx(this clsViewpointAttachmentEN objViewpointAttachmentENS)
{
try
{
 clsViewpointAttachmentENEx objViewpointAttachmentENT = new clsViewpointAttachmentENEx();
clsViewpointAttachmentBL.ViewpointAttachmentDA.CopyTo(objViewpointAttachmentENS, objViewpointAttachmentENT);
 return objViewpointAttachmentENT;
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
 /// <param name = "objViewpointAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsViewpointAttachmentEN:objViewpointAttachmentENT</returns>
 public static clsViewpointAttachmentEN CopyTo(this clsViewpointAttachmentENEx objViewpointAttachmentENS)
{
try
{
 clsViewpointAttachmentEN objViewpointAttachmentENT = new clsViewpointAttachmentEN();
clsViewpointAttachmentBL.CopyTo(objViewpointAttachmentENS, objViewpointAttachmentENT);
 return objViewpointAttachmentENT;
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
 /// 观点附件表(ViewpointAttachment)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsViewpointAttachmentBLEx : clsViewpointAttachmentBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsViewpointAttachmentDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsViewpointAttachmentDAEx ViewpointAttachmentDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsViewpointAttachmentDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objViewpointAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsViewpointAttachmentEN:objViewpointAttachmentENT</returns>
 public static clsViewpointAttachmentENEx CopyToEx(clsViewpointAttachmentEN objViewpointAttachmentENS)
{
try
{
 clsViewpointAttachmentENEx objViewpointAttachmentENT = new clsViewpointAttachmentENEx();
clsViewpointAttachmentBL.ViewpointAttachmentDA.CopyTo(objViewpointAttachmentENS, objViewpointAttachmentENT);
 return objViewpointAttachmentENT;
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
public static List<clsViewpointAttachmentENEx> GetObjExLst(string strCondition)
{
List <clsViewpointAttachmentEN> arrObjLst = clsViewpointAttachmentBL.GetObjLst(strCondition);
List <clsViewpointAttachmentENEx> arrObjExLst = new List<clsViewpointAttachmentENEx>();
foreach (clsViewpointAttachmentEN objInFor in arrObjLst)
{
clsViewpointAttachmentENEx objViewpointAttachmentENEx = new clsViewpointAttachmentENEx();
clsViewpointAttachmentBL.CopyTo(objInFor, objViewpointAttachmentENEx);
arrObjExLst.Add(objViewpointAttachmentENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngViewpointAttachmentId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsViewpointAttachmentENEx GetObjExByViewpointAttachmentId(long lngViewpointAttachmentId)
{
clsViewpointAttachmentEN objViewpointAttachmentEN = clsViewpointAttachmentBL.GetObjByViewpointAttachmentId(lngViewpointAttachmentId);
clsViewpointAttachmentENEx objViewpointAttachmentENEx = new clsViewpointAttachmentENEx();
clsViewpointAttachmentBL.CopyTo(objViewpointAttachmentEN, objViewpointAttachmentENEx);
return objViewpointAttachmentENEx;
}
}
}