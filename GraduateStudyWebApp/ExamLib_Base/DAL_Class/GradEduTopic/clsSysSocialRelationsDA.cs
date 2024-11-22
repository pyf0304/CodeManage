
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSocialRelationsDA
 表名:SysSocialRelations(01120644)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// 社会关系表(SysSocialRelations)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysSocialRelationsDA : clsCommBase4DA
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
 return clsSysSocialRelationsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysSocialRelationsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSocialRelationsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysSocialRelationsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysSocialRelationsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSocialId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSocialId)
{
strSocialId = strSocialId.Replace("'", "''");
if (strSocialId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:SysSocialRelations中,检查关键字,长度不正确!(clsSysSocialRelationsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSocialId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SysSocialRelations中,关键字不能为空 或 null!(clsSysSocialRelationsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSocialId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSysSocialRelationsDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysSocialRelations(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable_SysSocialRelations)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSocialRelations.* from SysSocialRelations Left Join {1} on {2} where {3} and SysSocialRelations.SocialId not in (Select top {5} SysSocialRelations.SocialId from SysSocialRelations Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1} and SocialId not in (Select top {2} SocialId from SysSocialRelations where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1} and SocialId not in (Select top {3} SocialId from SysSocialRelations where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSocialRelations.* from SysSocialRelations Left Join {1} on {2} where {3} and SysSocialRelations.SocialId not in (Select top {5} SysSocialRelations.SocialId from SysSocialRelations Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1} and SocialId not in (Select top {2} SocialId from SysSocialRelations where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelations where {1} and SocialId not in (Select top {3} SocialId from SysSocialRelations where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysSocialRelationsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA:GetObjLst)", objException.Message));
}
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = TransNullToBool(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSocialRelationsDA: GetObjLst)", objException.Message));
}
objSysSocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSocialRelationsEN);
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
public List<clsSysSocialRelationsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = TransNullToBool(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSocialRelationsDA: GetObjLst)", objException.Message));
}
objSysSocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSocialRelationsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysSocialRelations(ref clsSysSocialRelationsEN objSysSocialRelationsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where SocialId = " + "'"+ objSysSocialRelationsEN.SocialId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysSocialRelationsEN.SocialId = objDT.Rows[0][conSysSocialRelations.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSocialRelationsEN.FullName = objDT.Rows[0][conSysSocialRelations.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsEN.Nationality = objDT.Rows[0][conSysSocialRelations.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsEN.WorkUnit = objDT.Rows[0][conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objSysSocialRelationsEN.Major = objDT.Rows[0][conSysSocialRelations.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsEN.Achievement = objDT.Rows[0][conSysSocialRelations.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsEN.DetailedDescription = objDT.Rows[0][conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsEN.LevelId = objDT.Rows[0][conSysSocialRelations.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSocialRelationsEN.UpdUser = objDT.Rows[0][conSysSocialRelations.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsEN.UpdDate = objDT.Rows[0][conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsEN.IsSubmit = TransNullToBool(objDT.Rows[0][conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objSysSocialRelationsEN.OkCount = TransNullToInt(objDT.Rows[0][conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.CitationCount = TransNullToInt(objDT.Rows[0][conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.VersionCount = TransNullToInt(objDT.Rows[0][conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.IdCurrEduCls = objDT.Rows[0][conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSocialRelationsEN.Memo = objDT.Rows[0][conSysSocialRelations.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysSocialRelationsEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.Score = TransNullToFloat(objDT.Rows[0][conSysSocialRelations.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.StuScore = TransNullToFloat(objDT.Rows[0][conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.TeaScore = TransNullToFloat(objDT.Rows[0][conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.CitationId = objDT.Rows[0][conSysSocialRelations.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.CreateDate = objDT.Rows[0][conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsEN.ShareId = objDT.Rows[0][conSysSocialRelations.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objSysSocialRelationsEN.PdfContent = objDT.Rows[0][conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysSocialRelationsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysSocialRelationsDA: GetSysSocialRelations)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSocialId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysSocialRelationsEN GetObjBySocialId(string strSocialId)
{
CheckPrimaryKey(strSocialId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where SocialId = " + "'"+ strSocialId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
 objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysSocialRelationsDA: GetObjBySocialId)", objException.Message));
}
return objSysSocialRelationsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysSocialRelationsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN()
{
SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(), //社会Id
FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(), //姓名
Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(), //专业
Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(), //详细说明
LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(), //级别Id
UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(), //修改日期
IsSubmit = TransNullToBool(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()), //是否提交
OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.OkCount].ToString().Trim()), //点赞统计
CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.VersionCount].ToString().Trim()), //版本统计
IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(), //教学班流水号
Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(), //备注
AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.Score].ToString().Trim()), //评分
StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.TeaScore].ToString().Trim()), //教师评分
CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(), //引用Id
CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(), //分享Id
PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()) //Pdf页码
};
objSysSocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSocialRelationsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysSocialRelationsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysSocialRelationsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = TransNullToBool(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysSocialRelationsDA: GetObjByDataRowSysSocialRelations)", objException.Message));
}
objSysSocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSocialRelationsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysSocialRelationsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = TransNullToBool(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysSocialRelationsDA: GetObjByDataRow)", objException.Message));
}
objSysSocialRelationsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSocialRelationsEN;
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
objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSocialRelationsEN._CurrTabName, conSysSocialRelations.SocialId, 10, "");
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
objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSocialRelationsEN._CurrTabName, conSysSocialRelations.SocialId, 10, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SocialId from SysSocialRelations where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SocialId from SysSocialRelations where " + strCondition;
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
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSocialId)
{
CheckPrimaryKey(strSocialId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSocialRelations", "SocialId = " + "'"+ strSocialId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSocialRelations", strCondition))
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
objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysSocialRelations");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysSocialRelationsEN objSysSocialRelationsEN)
 {
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSocialRelations");
objRow = objDS.Tables["SysSocialRelations"].NewRow();
objRow[conSysSocialRelations.SocialId] = objSysSocialRelationsEN.SocialId; //社会Id
 if (objSysSocialRelationsEN.FullName !=  "")
 {
objRow[conSysSocialRelations.FullName] = objSysSocialRelationsEN.FullName; //姓名
 }
 if (objSysSocialRelationsEN.Nationality !=  "")
 {
objRow[conSysSocialRelations.Nationality] = objSysSocialRelationsEN.Nationality; //国籍
 }
 if (objSysSocialRelationsEN.WorkUnit !=  "")
 {
objRow[conSysSocialRelations.WorkUnit] = objSysSocialRelationsEN.WorkUnit; //工作单位
 }
 if (objSysSocialRelationsEN.Major !=  "")
 {
objRow[conSysSocialRelations.Major] = objSysSocialRelationsEN.Major; //专业
 }
 if (objSysSocialRelationsEN.Achievement !=  "")
 {
objRow[conSysSocialRelations.Achievement] = objSysSocialRelationsEN.Achievement; //成就
 }
 if (objSysSocialRelationsEN.DetailedDescription !=  "")
 {
objRow[conSysSocialRelations.DetailedDescription] = objSysSocialRelationsEN.DetailedDescription; //详细说明
 }
 if (objSysSocialRelationsEN.LevelId !=  "")
 {
objRow[conSysSocialRelations.LevelId] = objSysSocialRelationsEN.LevelId; //级别Id
 }
 if (objSysSocialRelationsEN.UpdUser !=  "")
 {
objRow[conSysSocialRelations.UpdUser] = objSysSocialRelationsEN.UpdUser; //修改人
 }
 if (objSysSocialRelationsEN.UpdDate !=  "")
 {
objRow[conSysSocialRelations.UpdDate] = objSysSocialRelationsEN.UpdDate; //修改日期
 }
objRow[conSysSocialRelations.IsSubmit] = objSysSocialRelationsEN.IsSubmit; //是否提交
objRow[conSysSocialRelations.OkCount] = objSysSocialRelationsEN.OkCount; //点赞统计
objRow[conSysSocialRelations.CitationCount] = objSysSocialRelationsEN.CitationCount; //引用统计
objRow[conSysSocialRelations.VersionCount] = objSysSocialRelationsEN.VersionCount; //版本统计
 if (objSysSocialRelationsEN.IdCurrEduCls !=  "")
 {
objRow[conSysSocialRelations.IdCurrEduCls] = objSysSocialRelationsEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSocialRelationsEN.Memo !=  "")
 {
objRow[conSysSocialRelations.Memo] = objSysSocialRelationsEN.Memo; //备注
 }
objRow[conSysSocialRelations.AppraiseCount] = objSysSocialRelationsEN.AppraiseCount; //评论数
objRow[conSysSocialRelations.Score] = objSysSocialRelationsEN.Score; //评分
objRow[conSysSocialRelations.StuScore] = objSysSocialRelationsEN.StuScore; //学生平均分
objRow[conSysSocialRelations.TeaScore] = objSysSocialRelationsEN.TeaScore; //教师评分
 if (objSysSocialRelationsEN.CitationId !=  "")
 {
objRow[conSysSocialRelations.CitationId] = objSysSocialRelationsEN.CitationId; //引用Id
 }
 if (objSysSocialRelationsEN.CreateDate !=  "")
 {
objRow[conSysSocialRelations.CreateDate] = objSysSocialRelationsEN.CreateDate; //建立日期
 }
 if (objSysSocialRelationsEN.ShareId !=  "")
 {
objRow[conSysSocialRelations.ShareId] = objSysSocialRelationsEN.ShareId; //分享Id
 }
 if (objSysSocialRelationsEN.PdfContent !=  "")
 {
objRow[conSysSocialRelations.PdfContent] = objSysSocialRelationsEN.PdfContent; //Pdf内容
 }
objRow[conSysSocialRelations.PdfPageNum] = objSysSocialRelationsEN.PdfPageNum; //Pdf页码
objDS.Tables[clsSysSocialRelationsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysSocialRelationsEN._CurrTabName);
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSocialRelationsEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.SocialId);
 var strSocialId = objSysSocialRelationsEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.FullName);
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Nationality);
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.WorkUnit);
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Major);
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Achievement);
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.LevelId);
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdUser);
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdDate);
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.OkCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.OkCount.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.CitationCount.ToString());
 }
 
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.VersionCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.VersionCount.ToString());
 }
 
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Memo);
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objSysSocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Score);
 arrValueListForInsert.Add(objSysSocialRelationsEN.Score.ToString());
 }
 
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.StuScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.StuScore.ToString());
 }
 
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.TeaScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.TeaScore.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationId);
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CreateDate);
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.ShareId);
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfContent);
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objSysSocialRelationsEN.PdfPageNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSocialRelationsEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.SocialId);
 var strSocialId = objSysSocialRelationsEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.FullName);
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Nationality);
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.WorkUnit);
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Major);
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Achievement);
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.LevelId);
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdUser);
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdDate);
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.OkCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.OkCount.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.CitationCount.ToString());
 }
 
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.VersionCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.VersionCount.ToString());
 }
 
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Memo);
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objSysSocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Score);
 arrValueListForInsert.Add(objSysSocialRelationsEN.Score.ToString());
 }
 
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.StuScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.StuScore.ToString());
 }
 
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.TeaScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.TeaScore.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationId);
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CreateDate);
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.ShareId);
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfContent);
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objSysSocialRelationsEN.PdfPageNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSysSocialRelationsEN.SocialId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSocialRelationsEN objSysSocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSocialRelationsEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.SocialId);
 var strSocialId = objSysSocialRelationsEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.FullName);
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Nationality);
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.WorkUnit);
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Major);
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Achievement);
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.LevelId);
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdUser);
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdDate);
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.OkCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.OkCount.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.CitationCount.ToString());
 }
 
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.VersionCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.VersionCount.ToString());
 }
 
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Memo);
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objSysSocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Score);
 arrValueListForInsert.Add(objSysSocialRelationsEN.Score.ToString());
 }
 
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.StuScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.StuScore.ToString());
 }
 
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.TeaScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.TeaScore.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationId);
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CreateDate);
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.ShareId);
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfContent);
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objSysSocialRelationsEN.PdfPageNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSysSocialRelationsEN.SocialId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSocialRelationsEN objSysSocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSocialRelationsEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.SocialId);
 var strSocialId = objSysSocialRelationsEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.FullName);
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Nationality);
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.WorkUnit);
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Major);
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Achievement);
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.LevelId);
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdUser);
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.UpdDate);
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSocialRelations.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSocialRelationsEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.OkCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.OkCount.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.CitationCount.ToString());
 }
 
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.VersionCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.VersionCount.ToString());
 }
 
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Memo);
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.AppraiseCount);
 arrValueListForInsert.Add(objSysSocialRelationsEN.AppraiseCount.ToString());
 }
 
 if (objSysSocialRelationsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.Score);
 arrValueListForInsert.Add(objSysSocialRelationsEN.Score.ToString());
 }
 
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.StuScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.StuScore.ToString());
 }
 
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.TeaScore);
 arrValueListForInsert.Add(objSysSocialRelationsEN.TeaScore.ToString());
 }
 
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CitationId);
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.CreateDate);
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.ShareId);
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfContent);
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelations.PdfPageNum);
 arrValueListForInsert.Add(objSysSocialRelationsEN.PdfPageNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelations");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysSocialRelationss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where SocialId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSocialRelations");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strSocialId = oRow[conSysSocialRelations.SocialId].ToString().Trim();
if (IsExist(strSocialId))
{
 string strResult = "关键字变量值为:" + string.Format("SocialId = {0}", strSocialId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysSocialRelationsEN._CurrTabName ].NewRow();
objRow[conSysSocialRelations.SocialId] = oRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objRow[conSysSocialRelations.FullName] = oRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objRow[conSysSocialRelations.Nationality] = oRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objRow[conSysSocialRelations.WorkUnit] = oRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objRow[conSysSocialRelations.Major] = oRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objRow[conSysSocialRelations.Achievement] = oRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objRow[conSysSocialRelations.DetailedDescription] = oRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objRow[conSysSocialRelations.LevelId] = oRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objRow[conSysSocialRelations.UpdUser] = oRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objRow[conSysSocialRelations.UpdDate] = oRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objRow[conSysSocialRelations.IsSubmit] = oRow[conSysSocialRelations.IsSubmit].ToString().Trim(); //是否提交
objRow[conSysSocialRelations.OkCount] = oRow[conSysSocialRelations.OkCount].ToString().Trim(); //点赞统计
objRow[conSysSocialRelations.CitationCount] = oRow[conSysSocialRelations.CitationCount].ToString().Trim(); //引用统计
objRow[conSysSocialRelations.VersionCount] = oRow[conSysSocialRelations.VersionCount].ToString().Trim(); //版本统计
objRow[conSysSocialRelations.IdCurrEduCls] = oRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conSysSocialRelations.Memo] = oRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objRow[conSysSocialRelations.AppraiseCount] = oRow[conSysSocialRelations.AppraiseCount].ToString().Trim(); //评论数
objRow[conSysSocialRelations.Score] = oRow[conSysSocialRelations.Score].ToString().Trim(); //评分
objRow[conSysSocialRelations.StuScore] = oRow[conSysSocialRelations.StuScore].ToString().Trim(); //学生平均分
objRow[conSysSocialRelations.TeaScore] = oRow[conSysSocialRelations.TeaScore].ToString().Trim(); //教师评分
objRow[conSysSocialRelations.CitationId] = oRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objRow[conSysSocialRelations.CreateDate] = oRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objRow[conSysSocialRelations.ShareId] = oRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objRow[conSysSocialRelations.PdfContent] = oRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objRow[conSysSocialRelations.PdfPageNum] = oRow[conSysSocialRelations.PdfPageNum].ToString().Trim(); //Pdf页码
 objDS.Tables[clsSysSocialRelationsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysSocialRelationsEN._CurrTabName);
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
 /// <param name = "objSysSocialRelationsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelations where SocialId = " + "'"+ objSysSocialRelationsEN.SocialId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysSocialRelationsEN._CurrTabName);
if (objDS.Tables[clsSysSocialRelationsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SocialId = " + "'"+ objSysSocialRelationsEN.SocialId+"'");
return false;
}
objRow = objDS.Tables[clsSysSocialRelationsEN._CurrTabName].Rows[0];
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.SocialId))
 {
objRow[conSysSocialRelations.SocialId] = objSysSocialRelationsEN.SocialId; //社会Id
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.FullName))
 {
objRow[conSysSocialRelations.FullName] = objSysSocialRelationsEN.FullName; //姓名
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Nationality))
 {
objRow[conSysSocialRelations.Nationality] = objSysSocialRelationsEN.Nationality; //国籍
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.WorkUnit))
 {
objRow[conSysSocialRelations.WorkUnit] = objSysSocialRelationsEN.WorkUnit; //工作单位
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Major))
 {
objRow[conSysSocialRelations.Major] = objSysSocialRelationsEN.Major; //专业
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Achievement))
 {
objRow[conSysSocialRelations.Achievement] = objSysSocialRelationsEN.Achievement; //成就
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.DetailedDescription))
 {
objRow[conSysSocialRelations.DetailedDescription] = objSysSocialRelationsEN.DetailedDescription; //详细说明
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.LevelId))
 {
objRow[conSysSocialRelations.LevelId] = objSysSocialRelationsEN.LevelId; //级别Id
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdUser))
 {
objRow[conSysSocialRelations.UpdUser] = objSysSocialRelationsEN.UpdUser; //修改人
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdDate))
 {
objRow[conSysSocialRelations.UpdDate] = objSysSocialRelationsEN.UpdDate; //修改日期
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IsSubmit))
 {
objRow[conSysSocialRelations.IsSubmit] = objSysSocialRelationsEN.IsSubmit; //是否提交
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.OkCount))
 {
objRow[conSysSocialRelations.OkCount] = objSysSocialRelationsEN.OkCount; //点赞统计
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationCount))
 {
objRow[conSysSocialRelations.CitationCount] = objSysSocialRelationsEN.CitationCount; //引用统计
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.VersionCount))
 {
objRow[conSysSocialRelations.VersionCount] = objSysSocialRelationsEN.VersionCount; //版本统计
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IdCurrEduCls))
 {
objRow[conSysSocialRelations.IdCurrEduCls] = objSysSocialRelationsEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Memo))
 {
objRow[conSysSocialRelations.Memo] = objSysSocialRelationsEN.Memo; //备注
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.AppraiseCount))
 {
objRow[conSysSocialRelations.AppraiseCount] = objSysSocialRelationsEN.AppraiseCount; //评论数
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Score))
 {
objRow[conSysSocialRelations.Score] = objSysSocialRelationsEN.Score; //评分
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.StuScore))
 {
objRow[conSysSocialRelations.StuScore] = objSysSocialRelationsEN.StuScore; //学生平均分
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.TeaScore))
 {
objRow[conSysSocialRelations.TeaScore] = objSysSocialRelationsEN.TeaScore; //教师评分
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationId))
 {
objRow[conSysSocialRelations.CitationId] = objSysSocialRelationsEN.CitationId; //引用Id
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CreateDate))
 {
objRow[conSysSocialRelations.CreateDate] = objSysSocialRelationsEN.CreateDate; //建立日期
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.ShareId))
 {
objRow[conSysSocialRelations.ShareId] = objSysSocialRelationsEN.ShareId; //分享Id
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfContent))
 {
objRow[conSysSocialRelations.PdfContent] = objSysSocialRelationsEN.PdfContent; //Pdf内容
 }
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfPageNum))
 {
objRow[conSysSocialRelations.PdfPageNum] = objSysSocialRelationsEN.PdfPageNum; //Pdf页码
 }
try
{
objDA.Update(objDS, clsSysSocialRelationsEN._CurrTabName);
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysSocialRelations Set ");
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.FullName))
 {
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conSysSocialRelations.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.FullName); //姓名
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Nationality))
 {
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conSysSocialRelations.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Nationality); //国籍
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.WorkUnit))
 {
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conSysSocialRelations.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.WorkUnit); //工作单位
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Major))
 {
 if (objSysSocialRelationsEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conSysSocialRelations.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Major); //专业
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Achievement))
 {
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conSysSocialRelations.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Achievement); //成就
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.DetailedDescription))
 {
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conSysSocialRelations.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.DetailedDescription); //详细说明
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.LevelId))
 {
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSocialRelations.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.LevelId); //级别Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdUser))
 {
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSocialRelations.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.UpdUser); //修改人
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdDate))
 {
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSocialRelations.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.UpdDate); //修改日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSysSocialRelationsEN.IsSubmit == true?"1":"0", conSysSocialRelations.IsSubmit); //是否提交
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.OkCount))
 {
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.OkCount, conSysSocialRelations.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.OkCount); //点赞统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationCount))
 {
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.CitationCount, conSysSocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.VersionCount))
 {
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.VersionCount, conSysSocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IdCurrEduCls))
 {
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSocialRelations.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Memo))
 {
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSocialRelations.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Memo); //备注
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.AppraiseCount))
 {
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.AppraiseCount, conSysSocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Score))
 {
 if (objSysSocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.Score, conSysSocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Score); //评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.StuScore))
 {
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.StuScore, conSysSocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.TeaScore))
 {
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.TeaScore, conSysSocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationId))
 {
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSocialRelations.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CitationId); //引用Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CreateDate))
 {
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conSysSocialRelations.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CreateDate); //建立日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.ShareId))
 {
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conSysSocialRelations.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.ShareId); //分享Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfContent))
 {
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conSysSocialRelations.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.PdfContent); //Pdf内容
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfPageNum))
 {
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.PdfPageNum, conSysSocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.PdfPageNum); //Pdf页码
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SocialId = '{0}'", objSysSocialRelationsEN.SocialId); 
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
 /// <param name = "objSysSocialRelationsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysSocialRelationsEN objSysSocialRelationsEN, string strCondition)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSocialRelations Set ");
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.FullName))
 {
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Nationality))
 {
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.WorkUnit))
 {
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Major))
 {
 if (objSysSocialRelationsEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Achievement))
 {
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.DetailedDescription))
 {
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.LevelId))
 {
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdUser))
 {
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdDate))
 {
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objSysSocialRelationsEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.OkCount))
 {
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.OkCount, conSysSocialRelations.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.OkCount); //点赞统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationCount))
 {
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.CitationCount, conSysSocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.VersionCount))
 {
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.VersionCount, conSysSocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IdCurrEduCls))
 {
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Memo))
 {
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.AppraiseCount))
 {
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.AppraiseCount, conSysSocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Score))
 {
 if (objSysSocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.Score, conSysSocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Score); //评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.StuScore))
 {
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.StuScore, conSysSocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.TeaScore))
 {
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.TeaScore, conSysSocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationId))
 {
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CreateDate))
 {
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.ShareId))
 {
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfContent))
 {
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfPageNum))
 {
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.PdfPageNum, conSysSocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.PdfPageNum); //Pdf页码
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
 /// <param name = "objSysSocialRelationsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysSocialRelationsEN objSysSocialRelationsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSocialRelations Set ");
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.FullName))
 {
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Nationality))
 {
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.WorkUnit))
 {
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Major))
 {
 if (objSysSocialRelationsEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Achievement))
 {
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.DetailedDescription))
 {
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.LevelId))
 {
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdUser))
 {
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdDate))
 {
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objSysSocialRelationsEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.OkCount))
 {
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.OkCount, conSysSocialRelations.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.OkCount); //点赞统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationCount))
 {
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.CitationCount, conSysSocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.VersionCount))
 {
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.VersionCount, conSysSocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IdCurrEduCls))
 {
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Memo))
 {
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.AppraiseCount))
 {
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.AppraiseCount, conSysSocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Score))
 {
 if (objSysSocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.Score, conSysSocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Score); //评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.StuScore))
 {
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.StuScore, conSysSocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.TeaScore))
 {
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.TeaScore, conSysSocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationId))
 {
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CreateDate))
 {
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.ShareId))
 {
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfContent))
 {
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfPageNum))
 {
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.PdfPageNum, conSysSocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.PdfPageNum); //Pdf页码
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSocialRelationsEN objSysSocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSocialRelationsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSocialRelations Set ");
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.FullName))
 {
 if (objSysSocialRelationsEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conSysSocialRelations.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.FullName); //姓名
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Nationality))
 {
 if (objSysSocialRelationsEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conSysSocialRelations.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Nationality); //国籍
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.WorkUnit))
 {
 if (objSysSocialRelationsEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conSysSocialRelations.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.WorkUnit); //工作单位
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Major))
 {
 if (objSysSocialRelationsEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conSysSocialRelations.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Major); //专业
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Achievement))
 {
 if (objSysSocialRelationsEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conSysSocialRelations.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Achievement); //成就
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.DetailedDescription))
 {
 if (objSysSocialRelationsEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conSysSocialRelations.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.DetailedDescription); //详细说明
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.LevelId))
 {
 if (objSysSocialRelationsEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSocialRelations.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.LevelId); //级别Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdUser))
 {
 if (objSysSocialRelationsEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSocialRelations.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.UpdUser); //修改人
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.UpdDate))
 {
 if (objSysSocialRelationsEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSocialRelations.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.UpdDate); //修改日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSysSocialRelationsEN.IsSubmit == true?"1":"0", conSysSocialRelations.IsSubmit); //是否提交
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.OkCount))
 {
 if (objSysSocialRelationsEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.OkCount, conSysSocialRelations.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.OkCount); //点赞统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationCount))
 {
 if (objSysSocialRelationsEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.CitationCount, conSysSocialRelations.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CitationCount); //引用统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.VersionCount))
 {
 if (objSysSocialRelationsEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.VersionCount, conSysSocialRelations.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.VersionCount); //版本统计
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.IdCurrEduCls))
 {
 if (objSysSocialRelationsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSocialRelations.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Memo))
 {
 if (objSysSocialRelationsEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSocialRelations.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Memo); //备注
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.AppraiseCount))
 {
 if (objSysSocialRelationsEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.AppraiseCount, conSysSocialRelations.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.AppraiseCount); //评论数
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.Score))
 {
 if (objSysSocialRelationsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.Score, conSysSocialRelations.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.Score); //评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.StuScore))
 {
 if (objSysSocialRelationsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.StuScore, conSysSocialRelations.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.StuScore); //学生平均分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.TeaScore))
 {
 if (objSysSocialRelationsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.TeaScore, conSysSocialRelations.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.TeaScore); //教师评分
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CitationId))
 {
 if (objSysSocialRelationsEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSocialRelations.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CitationId); //引用Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.CreateDate))
 {
 if (objSysSocialRelationsEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSocialRelationsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conSysSocialRelations.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.CreateDate); //建立日期
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.ShareId))
 {
 if (objSysSocialRelationsEN.ShareId !=  null)
 {
 var strShareId = objSysSocialRelationsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conSysSocialRelations.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.ShareId); //分享Id
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfContent))
 {
 if (objSysSocialRelationsEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSocialRelationsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conSysSocialRelations.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.PdfContent); //Pdf内容
 }
 }
 
 if (objSysSocialRelationsEN.IsUpdated(conSysSocialRelations.PdfPageNum))
 {
 if (objSysSocialRelationsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSocialRelationsEN.PdfPageNum, conSysSocialRelations.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelations.PdfPageNum); //Pdf页码
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SocialId = '{0}'", objSysSocialRelationsEN.SocialId); 
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
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSocialId) 
{
CheckPrimaryKey(strSocialId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strSocialId,
};
 objSQL.ExecSP("SysSocialRelations_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strSocialId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strSocialId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
//删除SysSocialRelations本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSocialRelations where SocialId = " + "'"+ strSocialId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysSocialRelations(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除SysSocialRelations本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSocialRelations where SocialId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strSocialId) 
{
CheckPrimaryKey(strSocialId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
//删除SysSocialRelations本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSocialRelations where SocialId = " + "'"+ strSocialId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysSocialRelations(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: DelSysSocialRelations)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSocialRelations where " + strCondition ;
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
public bool DelSysSocialRelationsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysSocialRelationsDA: DelSysSocialRelationsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSocialRelations where " + strCondition ;
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
 /// <param name = "objSysSocialRelationsENS">源对象</param>
 /// <param name = "objSysSocialRelationsENT">目标对象</param>
public void CopyTo(clsSysSocialRelationsEN objSysSocialRelationsENS, clsSysSocialRelationsEN objSysSocialRelationsENT)
{
objSysSocialRelationsENT.SocialId = objSysSocialRelationsENS.SocialId; //社会Id
objSysSocialRelationsENT.FullName = objSysSocialRelationsENS.FullName; //姓名
objSysSocialRelationsENT.Nationality = objSysSocialRelationsENS.Nationality; //国籍
objSysSocialRelationsENT.WorkUnit = objSysSocialRelationsENS.WorkUnit; //工作单位
objSysSocialRelationsENT.Major = objSysSocialRelationsENS.Major; //专业
objSysSocialRelationsENT.Achievement = objSysSocialRelationsENS.Achievement; //成就
objSysSocialRelationsENT.DetailedDescription = objSysSocialRelationsENS.DetailedDescription; //详细说明
objSysSocialRelationsENT.LevelId = objSysSocialRelationsENS.LevelId; //级别Id
objSysSocialRelationsENT.UpdUser = objSysSocialRelationsENS.UpdUser; //修改人
objSysSocialRelationsENT.UpdDate = objSysSocialRelationsENS.UpdDate; //修改日期
objSysSocialRelationsENT.IsSubmit = objSysSocialRelationsENS.IsSubmit; //是否提交
objSysSocialRelationsENT.OkCount = objSysSocialRelationsENS.OkCount; //点赞统计
objSysSocialRelationsENT.CitationCount = objSysSocialRelationsENS.CitationCount; //引用统计
objSysSocialRelationsENT.VersionCount = objSysSocialRelationsENS.VersionCount; //版本统计
objSysSocialRelationsENT.IdCurrEduCls = objSysSocialRelationsENS.IdCurrEduCls; //教学班流水号
objSysSocialRelationsENT.Memo = objSysSocialRelationsENS.Memo; //备注
objSysSocialRelationsENT.AppraiseCount = objSysSocialRelationsENS.AppraiseCount; //评论数
objSysSocialRelationsENT.Score = objSysSocialRelationsENS.Score; //评分
objSysSocialRelationsENT.StuScore = objSysSocialRelationsENS.StuScore; //学生平均分
objSysSocialRelationsENT.TeaScore = objSysSocialRelationsENS.TeaScore; //教师评分
objSysSocialRelationsENT.CitationId = objSysSocialRelationsENS.CitationId; //引用Id
objSysSocialRelationsENT.CreateDate = objSysSocialRelationsENS.CreateDate; //建立日期
objSysSocialRelationsENT.ShareId = objSysSocialRelationsENS.ShareId; //分享Id
objSysSocialRelationsENT.PdfContent = objSysSocialRelationsENS.PdfContent; //Pdf内容
objSysSocialRelationsENT.PdfPageNum = objSysSocialRelationsENS.PdfPageNum; //Pdf页码
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.SocialId, 10, conSysSocialRelations.SocialId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.FullName, 50, conSysSocialRelations.FullName);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Nationality, 50, conSysSocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.WorkUnit, 100, conSysSocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Major, 50, conSysSocialRelations.Major);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Achievement, 5000, conSysSocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.DetailedDescription, 5000, conSysSocialRelations.DetailedDescription);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.LevelId, 2, conSysSocialRelations.LevelId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.UpdUser, 20, conSysSocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.UpdDate, 20, conSysSocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.IdCurrEduCls, 8, conSysSocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Memo, 1000, conSysSocialRelations.Memo);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.CitationId, 8, conSysSocialRelations.CitationId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.CreateDate, 20, conSysSocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.ShareId, 2, conSysSocialRelations.ShareId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.PdfContent, 2000, conSysSocialRelations.PdfContent);
//检查字段外键固定长度
 objSysSocialRelationsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.FullName, 50, conSysSocialRelations.FullName);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Nationality, 50, conSysSocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.WorkUnit, 100, conSysSocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Major, 50, conSysSocialRelations.Major);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Achievement, 5000, conSysSocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.DetailedDescription, 5000, conSysSocialRelations.DetailedDescription);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.LevelId, 2, conSysSocialRelations.LevelId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.UpdUser, 20, conSysSocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.UpdDate, 20, conSysSocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.IdCurrEduCls, 8, conSysSocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Memo, 1000, conSysSocialRelations.Memo);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.CitationId, 8, conSysSocialRelations.CitationId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.CreateDate, 20, conSysSocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.ShareId, 2, conSysSocialRelations.ShareId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.PdfContent, 2000, conSysSocialRelations.PdfContent);
//检查外键字段长度
 objSysSocialRelationsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.SocialId, 10, conSysSocialRelations.SocialId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.FullName, 50, conSysSocialRelations.FullName);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Nationality, 50, conSysSocialRelations.Nationality);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.WorkUnit, 100, conSysSocialRelations.WorkUnit);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Major, 50, conSysSocialRelations.Major);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Achievement, 5000, conSysSocialRelations.Achievement);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.DetailedDescription, 5000, conSysSocialRelations.DetailedDescription);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.LevelId, 2, conSysSocialRelations.LevelId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.UpdUser, 20, conSysSocialRelations.UpdUser);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.UpdDate, 20, conSysSocialRelations.UpdDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.IdCurrEduCls, 8, conSysSocialRelations.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.Memo, 1000, conSysSocialRelations.Memo);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.CitationId, 8, conSysSocialRelations.CitationId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.CreateDate, 20, conSysSocialRelations.CreateDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.ShareId, 2, conSysSocialRelations.ShareId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsEN.PdfContent, 2000, conSysSocialRelations.PdfContent);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.SocialId, conSysSocialRelations.SocialId);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.FullName, conSysSocialRelations.FullName);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.Nationality, conSysSocialRelations.Nationality);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.WorkUnit, conSysSocialRelations.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.Major, conSysSocialRelations.Major);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.Achievement, conSysSocialRelations.Achievement);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.DetailedDescription, conSysSocialRelations.DetailedDescription);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.LevelId, conSysSocialRelations.LevelId);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.UpdUser, conSysSocialRelations.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.UpdDate, conSysSocialRelations.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.IdCurrEduCls, conSysSocialRelations.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.Memo, conSysSocialRelations.Memo);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.CitationId, conSysSocialRelations.CitationId);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.CreateDate, conSysSocialRelations.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.ShareId, conSysSocialRelations.ShareId);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsEN.PdfContent, conSysSocialRelations.PdfContent);
//检查外键字段长度
 objSysSocialRelationsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysSocialRelations(社会关系表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsEN.SocialId);
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSocialRelationsEN._CurrTabName);
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSocialRelationsEN._CurrTabName, strCondition);
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
 objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}