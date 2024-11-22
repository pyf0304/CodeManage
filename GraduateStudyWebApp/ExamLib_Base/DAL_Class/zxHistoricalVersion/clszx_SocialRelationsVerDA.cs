
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SocialRelationsVerDA
 表名:zx_SocialRelationsVer(01120739)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 社会关系版本(zx_SocialRelationsVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_SocialRelationsVerDA : clsCommBase4DA
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
 return clszx_SocialRelationsVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_SocialRelationsVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SocialRelationsVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_SocialRelationsVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_SocialRelationsVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_SocialRelationsVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable_zx_SocialRelationsVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SocialRelationsVer.* from zx_SocialRelationsVer Left Join {1} on {2} where {3} and zx_SocialRelationsVer.SocialVId not in (Select top {5} zx_SocialRelationsVer.SocialVId from zx_SocialRelationsVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1} and SocialVId not in (Select top {2} SocialVId from zx_SocialRelationsVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1} and SocialVId not in (Select top {3} SocialVId from zx_SocialRelationsVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SocialRelationsVer.* from zx_SocialRelationsVer Left Join {1} on {2} where {3} and zx_SocialRelationsVer.SocialVId not in (Select top {5} zx_SocialRelationsVer.SocialVId from zx_SocialRelationsVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1} and SocialVId not in (Select top {2} SocialVId from zx_SocialRelationsVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SocialRelationsVer where {1} and SocialVId not in (Select top {3} SocialVId from zx_SocialRelationsVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_SocialRelationsVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA:GetObjLst)", objException.Message));
}
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SocialRelationsVerDA: GetObjLst)", objException.Message));
}
objzx_SocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SocialRelationsVerEN);
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
public List<clszx_SocialRelationsVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SocialRelationsVerDA: GetObjLst)", objException.Message));
}
objzx_SocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SocialRelationsVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_SocialRelationsVer(ref clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where SocialVId = " + ""+ objzx_SocialRelationsVerEN.SocialVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_SocialRelationsVerEN.SocialVId = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_SocialRelationsVerEN.zxSocialId = objDT.Rows[0][conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SocialRelationsVerEN.FullName = objDT.Rows[0][conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.Nationality = objDT.Rows[0][conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.WorkUnit = objDT.Rows[0][conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_SocialRelationsVerEN.Major = objDT.Rows[0][conzx_SocialRelationsVer.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.Achievement = objDT.Rows[0][conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_SocialRelationsVerEN.DetailedDescription = objDT.Rows[0][conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SocialRelationsVerEN.zxLevelId = objDT.Rows[0][conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SocialRelationsVerEN.UpdUser = objDT.Rows[0][conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsVerEN.CreateDate = objDT.Rows[0][conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsVerEN.UpdDate = objDT.Rows[0][conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SocialRelationsVerEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.IdCurrEduCls = objDT.Rows[0][conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsVerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.Score = TransNullToFloat(objDT.Rows[0][conzx_SocialRelationsVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsVerEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsVerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsVerEN.TextId = objDT.Rows[0][conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsVerEN.zxShareId = objDT.Rows[0][conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SocialRelationsVerEN.PdfContent = objDT.Rows[0][conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SocialRelationsVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.Memo = objDT.Rows[0][conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SocialRelationsVerEN.PdfDivLet = objDT.Rows[0][conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.PdfDivTop = objDT.Rows[0][conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.PdfPageNumIn = objDT.Rows[0][conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.PdfZoom = objDT.Rows[0][conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.GroupTextId = objDT.Rows[0][conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_SocialRelationsVerDA: Getzx_SocialRelationsVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSocialVId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_SocialRelationsVerEN GetObjBySocialVId(long lngSocialVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where SocialVId = " + ""+ lngSocialVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
 objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_SocialRelationsVerDA: GetObjBySocialVId)", objException.Message));
}
return objzx_SocialRelationsVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_SocialRelationsVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN()
{
SocialVId = TransNullToInt(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()), //SocialVId
zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(), //社会Id
FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(), //姓名
Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(), //专业
Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(), //详细说明
zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(), //级别Id
UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(), //修改日期
IsSubmit = TransNullToBool(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()), //点赞计数
CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()), //版本统计
IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()), //教师评分
TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(), //课件Id
zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(), //分享Id
PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()), //Pdf页码
Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim() //小组Id
};
objzx_SocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SocialRelationsVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_SocialRelationsVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_SocialRelationsVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_SocialRelationsVerDA: GetObjByDataRowzx_SocialRelationsVer)", objException.Message));
}
objzx_SocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SocialRelationsVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_SocialRelationsVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = TransNullToBool(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_SocialRelationsVerDA: GetObjByDataRow)", objException.Message));
}
objzx_SocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SocialRelationsVerEN;
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
objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SocialRelationsVerEN._CurrTabName, conzx_SocialRelationsVer.SocialVId, 8, "");
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
objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SocialRelationsVerEN._CurrTabName, conzx_SocialRelationsVer.SocialVId, 8, strPrefix);
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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SocialVId from zx_SocialRelationsVer where " + strCondition;
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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SocialVId from zx_SocialRelationsVer where " + strCondition;
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
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngSocialVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SocialRelationsVer", "SocialVId = " + ""+ lngSocialVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SocialRelationsVer", strCondition))
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
objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_SocialRelationsVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
 {
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SocialRelationsVer");
objRow = objDS.Tables["zx_SocialRelationsVer"].NewRow();
objRow[conzx_SocialRelationsVer.zxSocialId] = objzx_SocialRelationsVerEN.zxSocialId; //社会Id
 if (objzx_SocialRelationsVerEN.FullName !=  "")
 {
objRow[conzx_SocialRelationsVer.FullName] = objzx_SocialRelationsVerEN.FullName; //姓名
 }
 if (objzx_SocialRelationsVerEN.Nationality !=  "")
 {
objRow[conzx_SocialRelationsVer.Nationality] = objzx_SocialRelationsVerEN.Nationality; //国籍
 }
 if (objzx_SocialRelationsVerEN.WorkUnit !=  "")
 {
objRow[conzx_SocialRelationsVer.WorkUnit] = objzx_SocialRelationsVerEN.WorkUnit; //工作单位
 }
 if (objzx_SocialRelationsVerEN.Major !=  "")
 {
objRow[conzx_SocialRelationsVer.Major] = objzx_SocialRelationsVerEN.Major; //专业
 }
 if (objzx_SocialRelationsVerEN.Achievement !=  "")
 {
objRow[conzx_SocialRelationsVer.Achievement] = objzx_SocialRelationsVerEN.Achievement; //成就
 }
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  "")
 {
objRow[conzx_SocialRelationsVer.DetailedDescription] = objzx_SocialRelationsVerEN.DetailedDescription; //详细说明
 }
 if (objzx_SocialRelationsVerEN.zxLevelId !=  "")
 {
objRow[conzx_SocialRelationsVer.zxLevelId] = objzx_SocialRelationsVerEN.zxLevelId; //级别Id
 }
 if (objzx_SocialRelationsVerEN.UpdUser !=  "")
 {
objRow[conzx_SocialRelationsVer.UpdUser] = objzx_SocialRelationsVerEN.UpdUser; //修改人
 }
 if (objzx_SocialRelationsVerEN.CreateDate !=  "")
 {
objRow[conzx_SocialRelationsVer.CreateDate] = objzx_SocialRelationsVerEN.CreateDate; //建立日期
 }
 if (objzx_SocialRelationsVerEN.UpdDate !=  "")
 {
objRow[conzx_SocialRelationsVer.UpdDate] = objzx_SocialRelationsVerEN.UpdDate; //修改日期
 }
objRow[conzx_SocialRelationsVer.IsSubmit] = objzx_SocialRelationsVerEN.IsSubmit; //是否提交
objRow[conzx_SocialRelationsVer.VoteCount] = objzx_SocialRelationsVerEN.VoteCount; //点赞计数
objRow[conzx_SocialRelationsVer.CitationCount] = objzx_SocialRelationsVerEN.CitationCount; //引用统计
objRow[conzx_SocialRelationsVer.VersionCount] = objzx_SocialRelationsVerEN.VersionCount; //版本统计
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  "")
 {
objRow[conzx_SocialRelationsVer.IdCurrEduCls] = objzx_SocialRelationsVerEN.IdCurrEduCls; //教学班流水号
 }
objRow[conzx_SocialRelationsVer.AppraiseCount] = objzx_SocialRelationsVerEN.AppraiseCount; //评论数
objRow[conzx_SocialRelationsVer.Score] = objzx_SocialRelationsVerEN.Score; //评分
objRow[conzx_SocialRelationsVer.StuScore] = objzx_SocialRelationsVerEN.StuScore; //学生平均分
objRow[conzx_SocialRelationsVer.TeaScore] = objzx_SocialRelationsVerEN.TeaScore; //教师评分
 if (objzx_SocialRelationsVerEN.TextId !=  "")
 {
objRow[conzx_SocialRelationsVer.TextId] = objzx_SocialRelationsVerEN.TextId; //课件Id
 }
 if (objzx_SocialRelationsVerEN.zxShareId !=  "")
 {
objRow[conzx_SocialRelationsVer.zxShareId] = objzx_SocialRelationsVerEN.zxShareId; //分享Id
 }
 if (objzx_SocialRelationsVerEN.PdfContent !=  "")
 {
objRow[conzx_SocialRelationsVer.PdfContent] = objzx_SocialRelationsVerEN.PdfContent; //Pdf内容
 }
objRow[conzx_SocialRelationsVer.PdfPageNum] = objzx_SocialRelationsVerEN.PdfPageNum; //Pdf页码
 if (objzx_SocialRelationsVerEN.Memo !=  "")
 {
objRow[conzx_SocialRelationsVer.Memo] = objzx_SocialRelationsVerEN.Memo; //备注
 }
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  "")
 {
objRow[conzx_SocialRelationsVer.PdfDivLet] = objzx_SocialRelationsVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  "")
 {
objRow[conzx_SocialRelationsVer.PdfDivTop] = objzx_SocialRelationsVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  "")
 {
objRow[conzx_SocialRelationsVer.PdfPageNumIn] = objzx_SocialRelationsVerEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_SocialRelationsVer.PdfPageTop] = objzx_SocialRelationsVerEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_SocialRelationsVerEN.PdfZoom !=  "")
 {
objRow[conzx_SocialRelationsVer.PdfZoom] = objzx_SocialRelationsVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_SocialRelationsVerEN.GroupTextId !=  "")
 {
objRow[conzx_SocialRelationsVer.GroupTextId] = objzx_SocialRelationsVerEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_SocialRelationsVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_SocialRelationsVerEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.FullName);
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Nationality);
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Major);
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Achievement);
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdUser);
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CreateDate);
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdDate);
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TextId);
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxShareId);
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfContent);
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Memo);
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.FullName);
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Nationality);
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Major);
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Achievement);
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdUser);
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CreateDate);
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdDate);
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TextId);
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxShareId);
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfContent);
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Memo);
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.FullName);
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Nationality);
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Major);
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Achievement);
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdUser);
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CreateDate);
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdDate);
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TextId);
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxShareId);
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfContent);
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Memo);
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SocialRelationsVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxSocialId);
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSocialId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.FullName);
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Nationality);
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.WorkUnit);
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Major);
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Achievement);
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxLevelId);
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdUser);
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CreateDate);
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.UpdDate);
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SocialRelationsVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VoteCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VoteCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.CitationCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.CitationCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.VersionCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.VersionCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Score);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.Score.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.StuScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.StuScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TeaScore);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.TeaScore.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.TextId);
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.zxShareId);
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfContent);
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.Memo);
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivLet);
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfDivTop);
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SocialRelationsVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.PdfZoom);
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SocialRelationsVer.GroupTextId);
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_SocialRelationsVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where SocialVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SocialRelationsVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngSocialVId = TransNullToInt(oRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim());
if (IsExist(lngSocialVId))
{
 string strResult = "关键字变量值为:" + string.Format("SocialVId = {0}", lngSocialVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_SocialRelationsVerEN._CurrTabName ].NewRow();
objRow[conzx_SocialRelationsVer.zxSocialId] = oRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objRow[conzx_SocialRelationsVer.FullName] = oRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objRow[conzx_SocialRelationsVer.Nationality] = oRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objRow[conzx_SocialRelationsVer.WorkUnit] = oRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objRow[conzx_SocialRelationsVer.Major] = oRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objRow[conzx_SocialRelationsVer.Achievement] = oRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objRow[conzx_SocialRelationsVer.DetailedDescription] = oRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objRow[conzx_SocialRelationsVer.zxLevelId] = oRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objRow[conzx_SocialRelationsVer.UpdUser] = oRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_SocialRelationsVer.CreateDate] = oRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_SocialRelationsVer.UpdDate] = oRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_SocialRelationsVer.IsSubmit] = oRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_SocialRelationsVer.VoteCount] = oRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_SocialRelationsVer.CitationCount] = oRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_SocialRelationsVer.VersionCount] = oRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_SocialRelationsVer.IdCurrEduCls] = oRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_SocialRelationsVer.AppraiseCount] = oRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_SocialRelationsVer.Score] = oRow[conzx_SocialRelationsVer.Score].ToString().Trim(); //评分
objRow[conzx_SocialRelationsVer.StuScore] = oRow[conzx_SocialRelationsVer.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_SocialRelationsVer.TeaScore] = oRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_SocialRelationsVer.TextId] = oRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objRow[conzx_SocialRelationsVer.zxShareId] = oRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_SocialRelationsVer.PdfContent] = oRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_SocialRelationsVer.PdfPageNum] = oRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_SocialRelationsVer.Memo] = oRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objRow[conzx_SocialRelationsVer.PdfDivLet] = oRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_SocialRelationsVer.PdfDivTop] = oRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_SocialRelationsVer.PdfPageNumIn] = oRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_SocialRelationsVer.PdfPageTop] = oRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_SocialRelationsVer.PdfZoom] = oRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_SocialRelationsVer.GroupTextId] = oRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_SocialRelationsVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_SocialRelationsVerEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SocialRelationsVer where SocialVId = " + ""+ objzx_SocialRelationsVerEN.SocialVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_SocialRelationsVerEN._CurrTabName);
if (objDS.Tables[clszx_SocialRelationsVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SocialVId = " + ""+ objzx_SocialRelationsVerEN.SocialVId+"");
return false;
}
objRow = objDS.Tables[clszx_SocialRelationsVerEN._CurrTabName].Rows[0];
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxSocialId))
 {
objRow[conzx_SocialRelationsVer.zxSocialId] = objzx_SocialRelationsVerEN.zxSocialId; //社会Id
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.FullName))
 {
objRow[conzx_SocialRelationsVer.FullName] = objzx_SocialRelationsVerEN.FullName; //姓名
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Nationality))
 {
objRow[conzx_SocialRelationsVer.Nationality] = objzx_SocialRelationsVerEN.Nationality; //国籍
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.WorkUnit))
 {
objRow[conzx_SocialRelationsVer.WorkUnit] = objzx_SocialRelationsVerEN.WorkUnit; //工作单位
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Major))
 {
objRow[conzx_SocialRelationsVer.Major] = objzx_SocialRelationsVerEN.Major; //专业
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Achievement))
 {
objRow[conzx_SocialRelationsVer.Achievement] = objzx_SocialRelationsVerEN.Achievement; //成就
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.DetailedDescription))
 {
objRow[conzx_SocialRelationsVer.DetailedDescription] = objzx_SocialRelationsVerEN.DetailedDescription; //详细说明
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxLevelId))
 {
objRow[conzx_SocialRelationsVer.zxLevelId] = objzx_SocialRelationsVerEN.zxLevelId; //级别Id
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdUser))
 {
objRow[conzx_SocialRelationsVer.UpdUser] = objzx_SocialRelationsVerEN.UpdUser; //修改人
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CreateDate))
 {
objRow[conzx_SocialRelationsVer.CreateDate] = objzx_SocialRelationsVerEN.CreateDate; //建立日期
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdDate))
 {
objRow[conzx_SocialRelationsVer.UpdDate] = objzx_SocialRelationsVerEN.UpdDate; //修改日期
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IsSubmit))
 {
objRow[conzx_SocialRelationsVer.IsSubmit] = objzx_SocialRelationsVerEN.IsSubmit; //是否提交
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VoteCount))
 {
objRow[conzx_SocialRelationsVer.VoteCount] = objzx_SocialRelationsVerEN.VoteCount; //点赞计数
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CitationCount))
 {
objRow[conzx_SocialRelationsVer.CitationCount] = objzx_SocialRelationsVerEN.CitationCount; //引用统计
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VersionCount))
 {
objRow[conzx_SocialRelationsVer.VersionCount] = objzx_SocialRelationsVerEN.VersionCount; //版本统计
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IdCurrEduCls))
 {
objRow[conzx_SocialRelationsVer.IdCurrEduCls] = objzx_SocialRelationsVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.AppraiseCount))
 {
objRow[conzx_SocialRelationsVer.AppraiseCount] = objzx_SocialRelationsVerEN.AppraiseCount; //评论数
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Score))
 {
objRow[conzx_SocialRelationsVer.Score] = objzx_SocialRelationsVerEN.Score; //评分
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.StuScore))
 {
objRow[conzx_SocialRelationsVer.StuScore] = objzx_SocialRelationsVerEN.StuScore; //学生平均分
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TeaScore))
 {
objRow[conzx_SocialRelationsVer.TeaScore] = objzx_SocialRelationsVerEN.TeaScore; //教师评分
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TextId))
 {
objRow[conzx_SocialRelationsVer.TextId] = objzx_SocialRelationsVerEN.TextId; //课件Id
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxShareId))
 {
objRow[conzx_SocialRelationsVer.zxShareId] = objzx_SocialRelationsVerEN.zxShareId; //分享Id
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfContent))
 {
objRow[conzx_SocialRelationsVer.PdfContent] = objzx_SocialRelationsVerEN.PdfContent; //Pdf内容
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNum))
 {
objRow[conzx_SocialRelationsVer.PdfPageNum] = objzx_SocialRelationsVerEN.PdfPageNum; //Pdf页码
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Memo))
 {
objRow[conzx_SocialRelationsVer.Memo] = objzx_SocialRelationsVerEN.Memo; //备注
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivLet))
 {
objRow[conzx_SocialRelationsVer.PdfDivLet] = objzx_SocialRelationsVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivTop))
 {
objRow[conzx_SocialRelationsVer.PdfDivTop] = objzx_SocialRelationsVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNumIn))
 {
objRow[conzx_SocialRelationsVer.PdfPageNumIn] = objzx_SocialRelationsVerEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageTop))
 {
objRow[conzx_SocialRelationsVer.PdfPageTop] = objzx_SocialRelationsVerEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfZoom))
 {
objRow[conzx_SocialRelationsVer.PdfZoom] = objzx_SocialRelationsVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.GroupTextId))
 {
objRow[conzx_SocialRelationsVer.GroupTextId] = objzx_SocialRelationsVerEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_SocialRelationsVerEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_SocialRelationsVer Set ");
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxSocialId))
 {
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxSocialId, conzx_SocialRelationsVer.zxSocialId); //社会Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.zxSocialId); //社会Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.FullName))
 {
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conzx_SocialRelationsVer.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.FullName); //姓名
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Nationality))
 {
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conzx_SocialRelationsVer.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Nationality); //国籍
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.WorkUnit))
 {
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conzx_SocialRelationsVer.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.WorkUnit); //工作单位
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Major))
 {
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conzx_SocialRelationsVer.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Major); //专业
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Achievement))
 {
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conzx_SocialRelationsVer.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Achievement); //成就
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.DetailedDescription))
 {
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conzx_SocialRelationsVer.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.DetailedDescription); //详细说明
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxLevelId))
 {
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_SocialRelationsVer.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdUser))
 {
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SocialRelationsVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.UpdUser); //修改人
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CreateDate))
 {
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_SocialRelationsVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdDate))
 {
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SocialRelationsVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SocialRelationsVerEN.IsSubmit == true?"1":"0", conzx_SocialRelationsVer.IsSubmit); //是否提交
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VoteCount))
 {
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VoteCount, conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CitationCount))
 {
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.CitationCount, conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VersionCount))
 {
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VersionCount, conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IdCurrEduCls))
 {
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.AppraiseCount))
 {
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.AppraiseCount, conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Score))
 {
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.Score, conzx_SocialRelationsVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.StuScore))
 {
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.StuScore, conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TeaScore))
 {
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.TeaScore, conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TextId))
 {
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_SocialRelationsVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.TextId); //课件Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxShareId))
 {
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_SocialRelationsVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfContent))
 {
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_SocialRelationsVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNum))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageNum, conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Memo))
 {
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SocialRelationsVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Memo); //备注
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivLet))
 {
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_SocialRelationsVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivTop))
 {
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_SocialRelationsVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNumIn))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_SocialRelationsVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageTop))
 {
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageTop, conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfZoom))
 {
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_SocialRelationsVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.GroupTextId))
 {
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_SocialRelationsVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SocialVId = {0}", objzx_SocialRelationsVerEN.SocialVId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strCondition)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SocialRelationsVer Set ");
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxSocialId))
 {
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxSocialId = '{0}',", strzxSocialId); //社会Id
 }
 else
 {
 sbSQL.Append(" zxSocialId = null,"); //社会Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.FullName))
 {
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Nationality))
 {
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.WorkUnit))
 {
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Major))
 {
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Achievement))
 {
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.DetailedDescription))
 {
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxLevelId))
 {
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdUser))
 {
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CreateDate))
 {
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdDate))
 {
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SocialRelationsVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VoteCount))
 {
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VoteCount, conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CitationCount))
 {
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.CitationCount, conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VersionCount))
 {
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VersionCount, conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IdCurrEduCls))
 {
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.AppraiseCount))
 {
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.AppraiseCount, conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Score))
 {
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.Score, conzx_SocialRelationsVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.StuScore))
 {
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.StuScore, conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TeaScore))
 {
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.TeaScore, conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TextId))
 {
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxShareId))
 {
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfContent))
 {
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNum))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageNum, conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Memo))
 {
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivLet))
 {
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivTop))
 {
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNumIn))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageTop))
 {
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageTop, conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfZoom))
 {
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.GroupTextId))
 {
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SocialRelationsVer Set ");
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxSocialId))
 {
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxSocialId = '{0}',", strzxSocialId); //社会Id
 }
 else
 {
 sbSQL.Append(" zxSocialId = null,"); //社会Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.FullName))
 {
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Nationality))
 {
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.WorkUnit))
 {
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Major))
 {
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Achievement))
 {
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.DetailedDescription))
 {
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxLevelId))
 {
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdUser))
 {
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CreateDate))
 {
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdDate))
 {
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SocialRelationsVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VoteCount))
 {
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VoteCount, conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CitationCount))
 {
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.CitationCount, conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VersionCount))
 {
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VersionCount, conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IdCurrEduCls))
 {
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.AppraiseCount))
 {
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.AppraiseCount, conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Score))
 {
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.Score, conzx_SocialRelationsVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.StuScore))
 {
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.StuScore, conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TeaScore))
 {
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.TeaScore, conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TextId))
 {
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxShareId))
 {
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfContent))
 {
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNum))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageNum, conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Memo))
 {
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivLet))
 {
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivTop))
 {
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNumIn))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageTop))
 {
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageTop, conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfZoom))
 {
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.GroupTextId))
 {
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SocialRelationsVer Set ");
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxSocialId))
 {
 if (objzx_SocialRelationsVerEN.zxSocialId !=  null)
 {
 var strzxSocialId = objzx_SocialRelationsVerEN.zxSocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxSocialId, conzx_SocialRelationsVer.zxSocialId); //社会Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.zxSocialId); //社会Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.FullName))
 {
 if (objzx_SocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objzx_SocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conzx_SocialRelationsVer.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.FullName); //姓名
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Nationality))
 {
 if (objzx_SocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objzx_SocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conzx_SocialRelationsVer.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Nationality); //国籍
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.WorkUnit))
 {
 if (objzx_SocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objzx_SocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conzx_SocialRelationsVer.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.WorkUnit); //工作单位
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Major))
 {
 if (objzx_SocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objzx_SocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conzx_SocialRelationsVer.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Major); //专业
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Achievement))
 {
 if (objzx_SocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objzx_SocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conzx_SocialRelationsVer.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Achievement); //成就
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.DetailedDescription))
 {
 if (objzx_SocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conzx_SocialRelationsVer.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.DetailedDescription); //详细说明
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxLevelId))
 {
 if (objzx_SocialRelationsVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SocialRelationsVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_SocialRelationsVer.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdUser))
 {
 if (objzx_SocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SocialRelationsVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.UpdUser); //修改人
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CreateDate))
 {
 if (objzx_SocialRelationsVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SocialRelationsVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_SocialRelationsVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.UpdDate))
 {
 if (objzx_SocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SocialRelationsVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SocialRelationsVerEN.IsSubmit == true?"1":"0", conzx_SocialRelationsVer.IsSubmit); //是否提交
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VoteCount))
 {
 if (objzx_SocialRelationsVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VoteCount, conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.CitationCount))
 {
 if (objzx_SocialRelationsVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.CitationCount, conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.VersionCount))
 {
 if (objzx_SocialRelationsVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.VersionCount, conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.IdCurrEduCls))
 {
 if (objzx_SocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.AppraiseCount))
 {
 if (objzx_SocialRelationsVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.AppraiseCount, conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Score))
 {
 if (objzx_SocialRelationsVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.Score, conzx_SocialRelationsVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Score); //评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.StuScore))
 {
 if (objzx_SocialRelationsVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.StuScore, conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TeaScore))
 {
 if (objzx_SocialRelationsVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.TeaScore, conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.TextId))
 {
 if (objzx_SocialRelationsVerEN.TextId !=  null)
 {
 var strTextId = objzx_SocialRelationsVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_SocialRelationsVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.TextId); //课件Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.zxShareId))
 {
 if (objzx_SocialRelationsVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SocialRelationsVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_SocialRelationsVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfContent))
 {
 if (objzx_SocialRelationsVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SocialRelationsVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_SocialRelationsVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNum))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageNum, conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.Memo))
 {
 if (objzx_SocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objzx_SocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SocialRelationsVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.Memo); //备注
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivLet))
 {
 if (objzx_SocialRelationsVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_SocialRelationsVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfDivTop))
 {
 if (objzx_SocialRelationsVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_SocialRelationsVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageNumIn))
 {
 if (objzx_SocialRelationsVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_SocialRelationsVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfPageTop))
 {
 if (objzx_SocialRelationsVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SocialRelationsVerEN.PdfPageTop, conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.PdfZoom))
 {
 if (objzx_SocialRelationsVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SocialRelationsVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_SocialRelationsVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SocialRelationsVerEN.IsUpdated(conzx_SocialRelationsVer.GroupTextId))
 {
 if (objzx_SocialRelationsVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SocialRelationsVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_SocialRelationsVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SocialRelationsVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SocialVId = {0}", objzx_SocialRelationsVerEN.SocialVId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngSocialVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngSocialVId,
};
 objSQL.ExecSP("zx_SocialRelationsVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngSocialVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
//删除zx_SocialRelationsVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SocialRelationsVer where SocialVId = " + ""+ lngSocialVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_SocialRelationsVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除zx_SocialRelationsVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SocialRelationsVer where SocialVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngSocialVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
//删除zx_SocialRelationsVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SocialRelationsVer where SocialVId = " + ""+ lngSocialVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_SocialRelationsVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: Delzx_SocialRelationsVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SocialRelationsVer where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool Delzx_SocialRelationsVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_SocialRelationsVerDA: Delzx_SocialRelationsVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SocialRelationsVer where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerENS">源对象</param>
 /// <param name = "objzx_SocialRelationsVerENT">目标对象</param>
public void CopyTo(clszx_SocialRelationsVerEN objzx_SocialRelationsVerENS, clszx_SocialRelationsVerEN objzx_SocialRelationsVerENT)
{
objzx_SocialRelationsVerENT.SocialVId = objzx_SocialRelationsVerENS.SocialVId; //SocialVId
objzx_SocialRelationsVerENT.zxSocialId = objzx_SocialRelationsVerENS.zxSocialId; //社会Id
objzx_SocialRelationsVerENT.FullName = objzx_SocialRelationsVerENS.FullName; //姓名
objzx_SocialRelationsVerENT.Nationality = objzx_SocialRelationsVerENS.Nationality; //国籍
objzx_SocialRelationsVerENT.WorkUnit = objzx_SocialRelationsVerENS.WorkUnit; //工作单位
objzx_SocialRelationsVerENT.Major = objzx_SocialRelationsVerENS.Major; //专业
objzx_SocialRelationsVerENT.Achievement = objzx_SocialRelationsVerENS.Achievement; //成就
objzx_SocialRelationsVerENT.DetailedDescription = objzx_SocialRelationsVerENS.DetailedDescription; //详细说明
objzx_SocialRelationsVerENT.zxLevelId = objzx_SocialRelationsVerENS.zxLevelId; //级别Id
objzx_SocialRelationsVerENT.UpdUser = objzx_SocialRelationsVerENS.UpdUser; //修改人
objzx_SocialRelationsVerENT.CreateDate = objzx_SocialRelationsVerENS.CreateDate; //建立日期
objzx_SocialRelationsVerENT.UpdDate = objzx_SocialRelationsVerENS.UpdDate; //修改日期
objzx_SocialRelationsVerENT.IsSubmit = objzx_SocialRelationsVerENS.IsSubmit; //是否提交
objzx_SocialRelationsVerENT.VoteCount = objzx_SocialRelationsVerENS.VoteCount; //点赞计数
objzx_SocialRelationsVerENT.CitationCount = objzx_SocialRelationsVerENS.CitationCount; //引用统计
objzx_SocialRelationsVerENT.VersionCount = objzx_SocialRelationsVerENS.VersionCount; //版本统计
objzx_SocialRelationsVerENT.IdCurrEduCls = objzx_SocialRelationsVerENS.IdCurrEduCls; //教学班流水号
objzx_SocialRelationsVerENT.AppraiseCount = objzx_SocialRelationsVerENS.AppraiseCount; //评论数
objzx_SocialRelationsVerENT.Score = objzx_SocialRelationsVerENS.Score; //评分
objzx_SocialRelationsVerENT.StuScore = objzx_SocialRelationsVerENS.StuScore; //学生平均分
objzx_SocialRelationsVerENT.TeaScore = objzx_SocialRelationsVerENS.TeaScore; //教师评分
objzx_SocialRelationsVerENT.TextId = objzx_SocialRelationsVerENS.TextId; //课件Id
objzx_SocialRelationsVerENT.zxShareId = objzx_SocialRelationsVerENS.zxShareId; //分享Id
objzx_SocialRelationsVerENT.PdfContent = objzx_SocialRelationsVerENS.PdfContent; //Pdf内容
objzx_SocialRelationsVerENT.PdfPageNum = objzx_SocialRelationsVerENS.PdfPageNum; //Pdf页码
objzx_SocialRelationsVerENT.Memo = objzx_SocialRelationsVerENS.Memo; //备注
objzx_SocialRelationsVerENT.PdfDivLet = objzx_SocialRelationsVerENS.PdfDivLet; //PdfDivLet
objzx_SocialRelationsVerENT.PdfDivTop = objzx_SocialRelationsVerENS.PdfDivTop; //PdfDivTop
objzx_SocialRelationsVerENT.PdfPageNumIn = objzx_SocialRelationsVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_SocialRelationsVerENT.PdfPageTop = objzx_SocialRelationsVerENS.PdfPageTop; //pdf页面顶部位置
objzx_SocialRelationsVerENT.PdfZoom = objzx_SocialRelationsVerENS.PdfZoom; //PdfZoom
objzx_SocialRelationsVerENT.GroupTextId = objzx_SocialRelationsVerENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_SocialRelationsVerEN.zxSocialId, conzx_SocialRelationsVer.zxSocialId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxSocialId, 10, conzx_SocialRelationsVer.zxSocialId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.FullName, 50, conzx_SocialRelationsVer.FullName);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Nationality, 50, conzx_SocialRelationsVer.Nationality);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.WorkUnit, 100, conzx_SocialRelationsVer.WorkUnit);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Major, 50, conzx_SocialRelationsVer.Major);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Achievement, 5000, conzx_SocialRelationsVer.Achievement);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxLevelId, 2, conzx_SocialRelationsVer.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.UpdUser, 20, conzx_SocialRelationsVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.CreateDate, 20, conzx_SocialRelationsVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.UpdDate, 20, conzx_SocialRelationsVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.IdCurrEduCls, 8, conzx_SocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.TextId, 8, conzx_SocialRelationsVer.TextId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxShareId, 2, conzx_SocialRelationsVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfContent, 2000, conzx_SocialRelationsVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Memo, 1000, conzx_SocialRelationsVer.Memo);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfDivLet, 50, conzx_SocialRelationsVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfDivTop, 50, conzx_SocialRelationsVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfPageNumIn, 50, conzx_SocialRelationsVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfZoom, 50, conzx_SocialRelationsVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.GroupTextId, 8, conzx_SocialRelationsVer.GroupTextId);
//检查字段外键固定长度
 objzx_SocialRelationsVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxSocialId, 10, conzx_SocialRelationsVer.zxSocialId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.FullName, 50, conzx_SocialRelationsVer.FullName);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Nationality, 50, conzx_SocialRelationsVer.Nationality);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.WorkUnit, 100, conzx_SocialRelationsVer.WorkUnit);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Major, 50, conzx_SocialRelationsVer.Major);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Achievement, 5000, conzx_SocialRelationsVer.Achievement);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxLevelId, 2, conzx_SocialRelationsVer.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.UpdUser, 20, conzx_SocialRelationsVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.CreateDate, 20, conzx_SocialRelationsVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.UpdDate, 20, conzx_SocialRelationsVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.IdCurrEduCls, 8, conzx_SocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.TextId, 8, conzx_SocialRelationsVer.TextId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxShareId, 2, conzx_SocialRelationsVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfContent, 2000, conzx_SocialRelationsVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Memo, 1000, conzx_SocialRelationsVer.Memo);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfDivLet, 50, conzx_SocialRelationsVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfDivTop, 50, conzx_SocialRelationsVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfPageNumIn, 50, conzx_SocialRelationsVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfZoom, 50, conzx_SocialRelationsVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.GroupTextId, 8, conzx_SocialRelationsVer.GroupTextId);
//检查外键字段长度
 objzx_SocialRelationsVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxSocialId, 10, conzx_SocialRelationsVer.zxSocialId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.FullName, 50, conzx_SocialRelationsVer.FullName);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Nationality, 50, conzx_SocialRelationsVer.Nationality);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.WorkUnit, 100, conzx_SocialRelationsVer.WorkUnit);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Major, 50, conzx_SocialRelationsVer.Major);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Achievement, 5000, conzx_SocialRelationsVer.Achievement);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxLevelId, 2, conzx_SocialRelationsVer.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.UpdUser, 20, conzx_SocialRelationsVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.CreateDate, 20, conzx_SocialRelationsVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.UpdDate, 20, conzx_SocialRelationsVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.IdCurrEduCls, 8, conzx_SocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.TextId, 8, conzx_SocialRelationsVer.TextId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.zxShareId, 2, conzx_SocialRelationsVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfContent, 2000, conzx_SocialRelationsVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.Memo, 1000, conzx_SocialRelationsVer.Memo);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfDivLet, 50, conzx_SocialRelationsVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfDivTop, 50, conzx_SocialRelationsVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfPageNumIn, 50, conzx_SocialRelationsVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.PdfZoom, 50, conzx_SocialRelationsVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SocialRelationsVerEN.GroupTextId, 8, conzx_SocialRelationsVer.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.zxSocialId, conzx_SocialRelationsVer.zxSocialId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.FullName, conzx_SocialRelationsVer.FullName);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.Nationality, conzx_SocialRelationsVer.Nationality);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.WorkUnit, conzx_SocialRelationsVer.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.Major, conzx_SocialRelationsVer.Major);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.Achievement, conzx_SocialRelationsVer.Achievement);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.zxLevelId, conzx_SocialRelationsVer.zxLevelId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.UpdUser, conzx_SocialRelationsVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.CreateDate, conzx_SocialRelationsVer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.UpdDate, conzx_SocialRelationsVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.IdCurrEduCls, conzx_SocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.TextId, conzx_SocialRelationsVer.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.zxShareId, conzx_SocialRelationsVer.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.PdfContent, conzx_SocialRelationsVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.Memo, conzx_SocialRelationsVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.PdfDivLet, conzx_SocialRelationsVer.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.PdfDivTop, conzx_SocialRelationsVer.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.PdfPageNumIn, conzx_SocialRelationsVer.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.PdfZoom, conzx_SocialRelationsVer.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_SocialRelationsVerEN.GroupTextId, conzx_SocialRelationsVer.GroupTextId);
//检查外键字段长度
 objzx_SocialRelationsVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSocialVId()
{
//获取某学院所有专业信息
string strSQL = "select SocialVId, zxLevelId from zx_SocialRelationsVer ";
 clsSpecSQLforSql mySql = clszx_SocialRelationsVerDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_SocialRelationsVer(社会关系版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxSocialId = '{0}'", objzx_SocialRelationsVerEN.zxSocialId);
 if (objzx_SocialRelationsVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SocialRelationsVerEN.GroupTextId);
}
return sbCondition.ToString();
}

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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SocialRelationsVerEN._CurrTabName);
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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SocialRelationsVerEN._CurrTabName, strCondition);
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
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}