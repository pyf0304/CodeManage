
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTUserRelaDA
 表名:vRTUserRela(01120584)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 主题用户关系视图(vRTUserRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTUserRelaDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsvRTUserRelaEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvRTUserRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTUserRelaEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsvRTUserRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTUserRelaEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTUserRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable_vRTUserRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vRTUserRela.* from vRTUserRela Left Join {1} on {2} where {3} and vRTUserRela.mId not in (Select top {5} vRTUserRela.mId from vRTUserRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1} and mId not in (Select top {2} mId from vRTUserRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1} and mId not in (Select top {3} mId from vRTUserRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vRTUserRela.* from vRTUserRela Left Join {1} on {2} where {3} and vRTUserRela.mId not in (Select top {5} vRTUserRela.mId from vRTUserRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1} and mId not in (Select top {2} mId from vRTUserRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTUserRela where {1} and mId not in (Select top {3} mId from vRTUserRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvRTUserRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTUserRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = TransNullToInt(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = TransNullToBool(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTUserRelaDA: GetObjLst)", objException.Message));
}
objvRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvRTUserRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTUserRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = TransNullToInt(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = TransNullToBool(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTUserRelaDA: GetObjLst)", objException.Message));
}
objvRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTUserRela(ref clsvRTUserRelaEN objvRTUserRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where mId = " + ""+ objvRTUserRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTUserRelaEN.mId = TransNullToInt(objDT.Rows[0][convRTUserRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTUserRelaEN.TopicId = objDT.Rows[0][convRTUserRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTUserRelaEN.UserId = objDT.Rows[0][convRTUserRela.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvRTUserRelaEN.UpdUserName = objDT.Rows[0][convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTUserRelaEN.TopicName = objDT.Rows[0][convRTUserRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTUserRelaEN.TopicContent = objDT.Rows[0][convRTUserRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTUserRelaEN.TopicProposePeople = objDT.Rows[0][convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTUserRelaEN.UserName = objDT.Rows[0][convRTUserRela.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvRTUserRelaEN.IdXzCollege = objDT.Rows[0][convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvRTUserRelaEN.CollegeName = objDT.Rows[0][convRTUserRela.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvRTUserRelaEN.IdXzMajor = objDT.Rows[0][convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTUserRelaEN.MajorName = objDT.Rows[0][convRTUserRela.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvRTUserRelaEN.TopicUserRoleId = objDT.Rows[0][convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objvRTUserRelaEN.TopicUserRoleName = objDT.Rows[0][convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色(字段类型:varchar,字段长度:100,是否可空:False)
 objvRTUserRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convRTUserRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTUserRelaEN.ColorId = objDT.Rows[0][convRTUserRela.ColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTUserRelaEN.ColorCode = objDT.Rows[0][convRTUserRela.ColorCode].ToString().Trim(); //颜色码(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTUserRelaEN.UserBgColor = objDT.Rows[0][convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTUserRelaEN.IdCurrEduCls = objDT.Rows[0][convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTUserRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTUserRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTUserRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTUserRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTUserRelaEN.Score = TransNullToFloat(objDT.Rows[0][convRTUserRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTUserRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTUserRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTUserRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convRTUserRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTUserRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTUserRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTUserRelaEN.UpdDate = objDT.Rows[0][convRTUserRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTUserRelaEN.UpdUser = objDT.Rows[0][convRTUserRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTUserRelaEN.Memo = objDT.Rows[0][convRTUserRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTUserRelaDA: GetvRTUserRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTUserRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
 objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色(字段类型:varchar,字段长度:100,是否可空:False)
 objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTUserRelaDA: GetObjBymId)", objException.Message));
}
return objvRTUserRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTUserRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTUserRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTUserRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN()
{
mId = TransNullToInt(objRow[convRTUserRela.mId].ToString().Trim()), //mId
TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(), //主题Id
UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(), //用户ID
UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(), //UpdUserName
TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(), //主题提出人
UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(), //用户名
IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(), //专业名称
TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(), //主键Id
TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(), //主题用户角色
OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OrderNum].ToString().Trim()), //序号
ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(), //颜色Id
ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(), //颜色码
UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(), //用户段落背景
IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.StuScore].ToString().Trim()), //学生平均分
Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.Score].ToString().Trim()), //评分
AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OkCount].ToString().Trim()), //点赞统计
IsSubmit = TransNullToBool(objRow[convRTUserRela.IsSubmit].ToString().Trim()), //是否提交
UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim() //备注
};
objvRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTUserRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTUserRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTUserRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = TransNullToInt(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = TransNullToBool(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTUserRelaDA: GetObjByDataRowvRTUserRela)", objException.Message));
}
objvRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTUserRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTUserRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = TransNullToInt(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = TransNullToBool(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTUserRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTUserRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTUserRelaEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTUserRelaEN._CurrTabName, convRTUserRela.mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTUserRelaEN._CurrTabName, convRTUserRela.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTUserRela where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTUserRela where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTUserRela", "mId = " + ""+ lngmId+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTUserRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTUserRela", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTUserRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTUserRelaENS">源对象</param>
 /// <param name = "objvRTUserRelaENT">目标对象</param>
public void CopyTo(clsvRTUserRelaEN objvRTUserRelaENS, clsvRTUserRelaEN objvRTUserRelaENT)
{
objvRTUserRelaENT.mId = objvRTUserRelaENS.mId; //mId
objvRTUserRelaENT.TopicId = objvRTUserRelaENS.TopicId; //主题Id
objvRTUserRelaENT.UserId = objvRTUserRelaENS.UserId; //用户ID
objvRTUserRelaENT.UpdUserName = objvRTUserRelaENS.UpdUserName; //UpdUserName
objvRTUserRelaENT.TopicName = objvRTUserRelaENS.TopicName; //栏目主题
objvRTUserRelaENT.TopicContent = objvRTUserRelaENS.TopicContent; //主题内容
objvRTUserRelaENT.TopicProposePeople = objvRTUserRelaENS.TopicProposePeople; //主题提出人
objvRTUserRelaENT.UserName = objvRTUserRelaENS.UserName; //用户名
objvRTUserRelaENT.IdXzCollege = objvRTUserRelaENS.IdXzCollege; //学院流水号
objvRTUserRelaENT.CollegeName = objvRTUserRelaENS.CollegeName; //学院名称
objvRTUserRelaENT.IdXzMajor = objvRTUserRelaENS.IdXzMajor; //专业流水号
objvRTUserRelaENT.MajorName = objvRTUserRelaENS.MajorName; //专业名称
objvRTUserRelaENT.TopicUserRoleId = objvRTUserRelaENS.TopicUserRoleId; //主键Id
objvRTUserRelaENT.TopicUserRoleName = objvRTUserRelaENS.TopicUserRoleName; //主题用户角色
objvRTUserRelaENT.OrderNum = objvRTUserRelaENS.OrderNum; //序号
objvRTUserRelaENT.ColorId = objvRTUserRelaENS.ColorId; //颜色Id
objvRTUserRelaENT.ColorCode = objvRTUserRelaENS.ColorCode; //颜色码
objvRTUserRelaENT.UserBgColor = objvRTUserRelaENS.UserBgColor; //用户段落背景
objvRTUserRelaENT.IdCurrEduCls = objvRTUserRelaENS.IdCurrEduCls; //教学班流水号
objvRTUserRelaENT.TeaScore = objvRTUserRelaENS.TeaScore; //教师评分
objvRTUserRelaENT.StuScore = objvRTUserRelaENS.StuScore; //学生平均分
objvRTUserRelaENT.Score = objvRTUserRelaENS.Score; //评分
objvRTUserRelaENT.AppraiseCount = objvRTUserRelaENS.AppraiseCount; //评论数
objvRTUserRelaENT.OkCount = objvRTUserRelaENS.OkCount; //点赞统计
objvRTUserRelaENT.IsSubmit = objvRTUserRelaENS.IsSubmit; //是否提交
objvRTUserRelaENT.UpdDate = objvRTUserRelaENS.UpdDate; //修改日期
objvRTUserRelaENT.UpdUser = objvRTUserRelaENS.UpdUser; //修改人
objvRTUserRelaENT.Memo = objvRTUserRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTUserRelaEN objvRTUserRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.TopicId, 8, convRTUserRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.UserId, 18, convRTUserRela.UserId);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.UpdUserName, 20, convRTUserRela.UpdUserName);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.TopicName, 200, convRTUserRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.TopicProposePeople, 50, convRTUserRela.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.UserName, 30, convRTUserRela.UserName);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.IdXzCollege, 4, convRTUserRela.IdXzCollege);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.CollegeName, 100, convRTUserRela.CollegeName);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.IdXzMajor, 8, convRTUserRela.IdXzMajor);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.MajorName, 100, convRTUserRela.MajorName);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.TopicUserRoleId, 4, convRTUserRela.TopicUserRoleId);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.TopicUserRoleName, 100, convRTUserRela.TopicUserRoleName);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.ColorId, 2, convRTUserRela.ColorId);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.ColorCode, 200, convRTUserRela.ColorCode);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.UserBgColor, 200, convRTUserRela.UserBgColor);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.IdCurrEduCls, 8, convRTUserRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.UpdDate, 20, convRTUserRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.UpdUser, 20, convRTUserRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTUserRelaEN.Memo, 1000, convRTUserRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.TopicId, convRTUserRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.UserId, convRTUserRela.UserId);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.UpdUserName, convRTUserRela.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.TopicName, convRTUserRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.TopicProposePeople, convRTUserRela.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.UserName, convRTUserRela.UserName);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.IdXzCollege, convRTUserRela.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.CollegeName, convRTUserRela.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.IdXzMajor, convRTUserRela.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.MajorName, convRTUserRela.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.TopicUserRoleId, convRTUserRela.TopicUserRoleId);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.TopicUserRoleName, convRTUserRela.TopicUserRoleName);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.ColorId, convRTUserRela.ColorId);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.ColorCode, convRTUserRela.ColorCode);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.UserBgColor, convRTUserRela.UserBgColor);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.IdCurrEduCls, convRTUserRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.UpdDate, convRTUserRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.UpdUser, convRTUserRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTUserRelaEN.Memo, convRTUserRela.Memo);
//检查外键字段长度
 objvRTUserRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTUserRelaEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTUserRelaEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTUserRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}