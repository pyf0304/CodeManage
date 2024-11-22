
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSocialRelationsVerDA
 表名:SysSocialRelationsVer(01120645)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:07
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
 /// 社会关系版本表(SysSocialRelationsVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysSocialRelationsVerDA : clsCommBase4DA
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
 return clsSysSocialRelationsVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysSocialRelationsVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSocialRelationsVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysSocialRelationsVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysSocialRelationsVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysSocialRelationsVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable_SysSocialRelationsVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSocialRelationsVer.* from SysSocialRelationsVer Left Join {1} on {2} where {3} and SysSocialRelationsVer.SocialVId not in (Select top {5} SysSocialRelationsVer.SocialVId from SysSocialRelationsVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1} and SocialVId not in (Select top {2} SocialVId from SysSocialRelationsVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1} and SocialVId not in (Select top {3} SocialVId from SysSocialRelationsVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSocialRelationsVer.* from SysSocialRelationsVer Left Join {1} on {2} where {3} and SysSocialRelationsVer.SocialVId not in (Select top {5} SysSocialRelationsVer.SocialVId from SysSocialRelationsVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1} and SocialVId not in (Select top {2} SocialVId from SysSocialRelationsVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSocialRelationsVer where {1} and SocialVId not in (Select top {3} SocialVId from SysSocialRelationsVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysSocialRelationsVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA:GetObjLst)", objException.Message));
}
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetObjLst)", objException.Message));
}
objSysSocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSocialRelationsVerEN);
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
public List<clsSysSocialRelationsVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetObjLst)", objException.Message));
}
objSysSocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSocialRelationsVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysSocialRelationsVer(ref clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where SocialVId = " + ""+ objSysSocialRelationsVerEN.SocialVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysSocialRelationsVerEN.SocialVId = TransNullToInt(objDT.Rows[0][conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId(字段类型:bigint,字段长度:8,是否可空:False)
 objSysSocialRelationsVerEN.SocialId = objDT.Rows[0][conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSocialRelationsVerEN.FullName = objDT.Rows[0][conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsVerEN.Nationality = objDT.Rows[0][conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsVerEN.WorkUnit = objDT.Rows[0][conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objSysSocialRelationsVerEN.Major = objDT.Rows[0][conSysSocialRelationsVer.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsVerEN.Achievement = objDT.Rows[0][conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsVerEN.DetailedDescription = objDT.Rows[0][conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsVerEN.LevelId = objDT.Rows[0][conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSocialRelationsVerEN.UpdUser = objDT.Rows[0][conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsVerEN.UpdDate = objDT.Rows[0][conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsVerEN.IdCurrEduCls = objDT.Rows[0][conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSocialRelationsVerEN.Memo = objDT.Rows[0][conSysSocialRelationsVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysSocialRelationsVerEN.CitationId = objDT.Rows[0][conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetSysSocialRelationsVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSocialVId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysSocialRelationsVerEN GetObjBySocialVId(long lngSocialVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where SocialVId = " + ""+ lngSocialVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
 objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId(字段类型:bigint,字段长度:8,是否可空:False)
 objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:5000,是否可空:True)
 objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetObjBySocialVId)", objException.Message));
}
return objSysSocialRelationsVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysSocialRelationsVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN()
{
SocialVId = TransNullToInt(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()), //SocialVId
SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(), //社会Id
FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(), //姓名
Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(), //专业
Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(), //详细说明
LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(), //级别Id
UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(), //修改日期
IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(), //备注
CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim() //引用Id
};
objSysSocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSocialRelationsVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysSocialRelationsVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetObjByDataRowSysSocialRelationsVer)", objException.Message));
}
objSysSocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSocialRelationsVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysSocialRelationsVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = TransNullToInt(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysSocialRelationsVerDA: GetObjByDataRow)", objException.Message));
}
objSysSocialRelationsVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSocialRelationsVerEN;
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
objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSocialRelationsVerEN._CurrTabName, conSysSocialRelationsVer.SocialVId, 8, "");
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
objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSocialRelationsVerEN._CurrTabName, conSysSocialRelationsVer.SocialVId, 8, strPrefix);
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SocialVId from SysSocialRelationsVer where " + strCondition;
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SocialVId from SysSocialRelationsVer where " + strCondition;
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSocialRelationsVer", "SocialVId = " + ""+ lngSocialVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSocialRelationsVer", strCondition))
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
objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysSocialRelationsVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
 {
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSocialRelationsVer");
objRow = objDS.Tables["SysSocialRelationsVer"].NewRow();
objRow[conSysSocialRelationsVer.SocialId] = objSysSocialRelationsVerEN.SocialId; //社会Id
 if (objSysSocialRelationsVerEN.FullName !=  "")
 {
objRow[conSysSocialRelationsVer.FullName] = objSysSocialRelationsVerEN.FullName; //姓名
 }
 if (objSysSocialRelationsVerEN.Nationality !=  "")
 {
objRow[conSysSocialRelationsVer.Nationality] = objSysSocialRelationsVerEN.Nationality; //国籍
 }
 if (objSysSocialRelationsVerEN.WorkUnit !=  "")
 {
objRow[conSysSocialRelationsVer.WorkUnit] = objSysSocialRelationsVerEN.WorkUnit; //工作单位
 }
 if (objSysSocialRelationsVerEN.Major !=  "")
 {
objRow[conSysSocialRelationsVer.Major] = objSysSocialRelationsVerEN.Major; //专业
 }
 if (objSysSocialRelationsVerEN.Achievement !=  "")
 {
objRow[conSysSocialRelationsVer.Achievement] = objSysSocialRelationsVerEN.Achievement; //成就
 }
 if (objSysSocialRelationsVerEN.DetailedDescription !=  "")
 {
objRow[conSysSocialRelationsVer.DetailedDescription] = objSysSocialRelationsVerEN.DetailedDescription; //详细说明
 }
 if (objSysSocialRelationsVerEN.LevelId !=  "")
 {
objRow[conSysSocialRelationsVer.LevelId] = objSysSocialRelationsVerEN.LevelId; //级别Id
 }
 if (objSysSocialRelationsVerEN.UpdUser !=  "")
 {
objRow[conSysSocialRelationsVer.UpdUser] = objSysSocialRelationsVerEN.UpdUser; //修改人
 }
 if (objSysSocialRelationsVerEN.UpdDate !=  "")
 {
objRow[conSysSocialRelationsVer.UpdDate] = objSysSocialRelationsVerEN.UpdDate; //修改日期
 }
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  "")
 {
objRow[conSysSocialRelationsVer.IdCurrEduCls] = objSysSocialRelationsVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSocialRelationsVerEN.Memo !=  "")
 {
objRow[conSysSocialRelationsVer.Memo] = objSysSocialRelationsVerEN.Memo; //备注
 }
 if (objSysSocialRelationsVerEN.CitationId !=  "")
 {
objRow[conSysSocialRelationsVer.CitationId] = objSysSocialRelationsVerEN.CitationId; //引用Id
 }
objDS.Tables[clsSysSocialRelationsVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysSocialRelationsVerEN._CurrTabName);
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
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.SocialId);
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.FullName);
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Nationality);
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.WorkUnit);
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Major);
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Achievement);
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.LevelId);
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdUser);
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdDate);
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Memo);
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.CitationId);
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.SocialId);
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.FullName);
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Nationality);
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.WorkUnit);
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Major);
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Achievement);
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.LevelId);
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdUser);
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdDate);
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Memo);
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.CitationId);
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.SocialId);
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.FullName);
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Nationality);
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.WorkUnit);
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Major);
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Achievement);
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.LevelId);
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdUser);
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdDate);
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Memo);
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.CitationId);
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSocialRelationsVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.SocialId);
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.FullName);
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFullName + "'");
 }
 
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Nationality);
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.WorkUnit);
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Major);
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Achievement);
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.DetailedDescription);
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailedDescription + "'");
 }
 
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.LevelId);
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdUser);
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.UpdDate);
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.Memo);
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSocialRelationsVer.CitationId);
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSocialRelationsVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysSocialRelationsVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where SocialVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSocialRelationsVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngSocialVId = TransNullToInt(oRow[conSysSocialRelationsVer.SocialVId].ToString().Trim());
if (IsExist(lngSocialVId))
{
 string strResult = "关键字变量值为:" + string.Format("SocialVId = {0}", lngSocialVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysSocialRelationsVerEN._CurrTabName ].NewRow();
objRow[conSysSocialRelationsVer.SocialId] = oRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objRow[conSysSocialRelationsVer.FullName] = oRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objRow[conSysSocialRelationsVer.Nationality] = oRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objRow[conSysSocialRelationsVer.WorkUnit] = oRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objRow[conSysSocialRelationsVer.Major] = oRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objRow[conSysSocialRelationsVer.Achievement] = oRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objRow[conSysSocialRelationsVer.DetailedDescription] = oRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objRow[conSysSocialRelationsVer.LevelId] = oRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objRow[conSysSocialRelationsVer.UpdUser] = oRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objRow[conSysSocialRelationsVer.UpdDate] = oRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objRow[conSysSocialRelationsVer.IdCurrEduCls] = oRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conSysSocialRelationsVer.Memo] = oRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objRow[conSysSocialRelationsVer.CitationId] = oRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
 objDS.Tables[clsSysSocialRelationsVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysSocialRelationsVerEN._CurrTabName);
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
 /// <param name = "objSysSocialRelationsVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSocialRelationsVer where SocialVId = " + ""+ objSysSocialRelationsVerEN.SocialVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysSocialRelationsVerEN._CurrTabName);
if (objDS.Tables[clsSysSocialRelationsVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SocialVId = " + ""+ objSysSocialRelationsVerEN.SocialVId+"");
return false;
}
objRow = objDS.Tables[clsSysSocialRelationsVerEN._CurrTabName].Rows[0];
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.SocialId))
 {
objRow[conSysSocialRelationsVer.SocialId] = objSysSocialRelationsVerEN.SocialId; //社会Id
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.FullName))
 {
objRow[conSysSocialRelationsVer.FullName] = objSysSocialRelationsVerEN.FullName; //姓名
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Nationality))
 {
objRow[conSysSocialRelationsVer.Nationality] = objSysSocialRelationsVerEN.Nationality; //国籍
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.WorkUnit))
 {
objRow[conSysSocialRelationsVer.WorkUnit] = objSysSocialRelationsVerEN.WorkUnit; //工作单位
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Major))
 {
objRow[conSysSocialRelationsVer.Major] = objSysSocialRelationsVerEN.Major; //专业
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Achievement))
 {
objRow[conSysSocialRelationsVer.Achievement] = objSysSocialRelationsVerEN.Achievement; //成就
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.DetailedDescription))
 {
objRow[conSysSocialRelationsVer.DetailedDescription] = objSysSocialRelationsVerEN.DetailedDescription; //详细说明
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.LevelId))
 {
objRow[conSysSocialRelationsVer.LevelId] = objSysSocialRelationsVerEN.LevelId; //级别Id
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdUser))
 {
objRow[conSysSocialRelationsVer.UpdUser] = objSysSocialRelationsVerEN.UpdUser; //修改人
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdDate))
 {
objRow[conSysSocialRelationsVer.UpdDate] = objSysSocialRelationsVerEN.UpdDate; //修改日期
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.IdCurrEduCls))
 {
objRow[conSysSocialRelationsVer.IdCurrEduCls] = objSysSocialRelationsVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Memo))
 {
objRow[conSysSocialRelationsVer.Memo] = objSysSocialRelationsVerEN.Memo; //备注
 }
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.CitationId))
 {
objRow[conSysSocialRelationsVer.CitationId] = objSysSocialRelationsVerEN.CitationId; //引用Id
 }
try
{
objDA.Update(objDS, clsSysSocialRelationsVerEN._CurrTabName);
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
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysSocialRelationsVer Set ");
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.SocialId))
 {
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSocialId, conSysSocialRelationsVer.SocialId); //社会Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.SocialId); //社会Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.FullName))
 {
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conSysSocialRelationsVer.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.FullName); //姓名
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Nationality))
 {
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conSysSocialRelationsVer.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Nationality); //国籍
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.WorkUnit))
 {
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conSysSocialRelationsVer.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.WorkUnit); //工作单位
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Major))
 {
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conSysSocialRelationsVer.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Major); //专业
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Achievement))
 {
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conSysSocialRelationsVer.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Achievement); //成就
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.DetailedDescription))
 {
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conSysSocialRelationsVer.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.DetailedDescription); //详细说明
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.LevelId))
 {
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSocialRelationsVer.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.LevelId); //级别Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdUser))
 {
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSocialRelationsVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.UpdUser); //修改人
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdDate))
 {
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSocialRelationsVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.UpdDate); //修改日期
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.IdCurrEduCls))
 {
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Memo))
 {
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSocialRelationsVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Memo); //备注
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.CitationId))
 {
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSocialRelationsVer.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.CitationId); //引用Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SocialVId = {0}", objSysSocialRelationsVerEN.SocialVId); 
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
 /// <param name = "objSysSocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strCondition)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSocialRelationsVer Set ");
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.SocialId))
 {
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SocialId = '{0}',", strSocialId); //社会Id
 }
 else
 {
 sbSQL.Append(" SocialId = null,"); //社会Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.FullName))
 {
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Nationality))
 {
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.WorkUnit))
 {
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Major))
 {
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Achievement))
 {
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.DetailedDescription))
 {
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.LevelId))
 {
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdUser))
 {
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdDate))
 {
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.IdCurrEduCls))
 {
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Memo))
 {
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.CitationId))
 {
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
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
 /// <param name = "objSysSocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSocialRelationsVer Set ");
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.SocialId))
 {
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SocialId = '{0}',", strSocialId); //社会Id
 }
 else
 {
 sbSQL.Append(" SocialId = null,"); //社会Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.FullName))
 {
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FullName = '{0}',", strFullName); //姓名
 }
 else
 {
 sbSQL.Append(" FullName = null,"); //姓名
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Nationality))
 {
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.WorkUnit))
 {
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Major))
 {
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Achievement))
 {
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.DetailedDescription))
 {
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailedDescription = '{0}',", strDetailedDescription); //详细说明
 }
 else
 {
 sbSQL.Append(" DetailedDescription = null,"); //详细说明
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.LevelId))
 {
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdUser))
 {
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdDate))
 {
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.IdCurrEduCls))
 {
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Memo))
 {
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.CitationId))
 {
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
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
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSocialRelationsVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSocialRelationsVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSocialRelationsVer Set ");
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.SocialId))
 {
 if (objSysSocialRelationsVerEN.SocialId !=  null)
 {
 var strSocialId = objSysSocialRelationsVerEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSocialId, conSysSocialRelationsVer.SocialId); //社会Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.SocialId); //社会Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.FullName))
 {
 if (objSysSocialRelationsVerEN.FullName !=  null)
 {
 var strFullName = objSysSocialRelationsVerEN.FullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFullName, conSysSocialRelationsVer.FullName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.FullName); //姓名
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Nationality))
 {
 if (objSysSocialRelationsVerEN.Nationality !=  null)
 {
 var strNationality = objSysSocialRelationsVerEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conSysSocialRelationsVer.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Nationality); //国籍
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.WorkUnit))
 {
 if (objSysSocialRelationsVerEN.WorkUnit !=  null)
 {
 var strWorkUnit = objSysSocialRelationsVerEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conSysSocialRelationsVer.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.WorkUnit); //工作单位
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Major))
 {
 if (objSysSocialRelationsVerEN.Major !=  null)
 {
 var strMajor = objSysSocialRelationsVerEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conSysSocialRelationsVer.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Major); //专业
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Achievement))
 {
 if (objSysSocialRelationsVerEN.Achievement !=  null)
 {
 var strAchievement = objSysSocialRelationsVerEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conSysSocialRelationsVer.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Achievement); //成就
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.DetailedDescription))
 {
 if (objSysSocialRelationsVerEN.DetailedDescription !=  null)
 {
 var strDetailedDescription = objSysSocialRelationsVerEN.DetailedDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailedDescription, conSysSocialRelationsVer.DetailedDescription); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.DetailedDescription); //详细说明
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.LevelId))
 {
 if (objSysSocialRelationsVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSocialRelationsVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSocialRelationsVer.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.LevelId); //级别Id
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdUser))
 {
 if (objSysSocialRelationsVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSocialRelationsVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSocialRelationsVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.UpdUser); //修改人
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.UpdDate))
 {
 if (objSysSocialRelationsVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSocialRelationsVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSocialRelationsVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.UpdDate); //修改日期
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.IdCurrEduCls))
 {
 if (objSysSocialRelationsVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.Memo))
 {
 if (objSysSocialRelationsVerEN.Memo !=  null)
 {
 var strMemo = objSysSocialRelationsVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSocialRelationsVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.Memo); //备注
 }
 }
 
 if (objSysSocialRelationsVerEN.IsUpdated(conSysSocialRelationsVer.CitationId))
 {
 if (objSysSocialRelationsVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSocialRelationsVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSocialRelationsVer.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSocialRelationsVer.CitationId); //引用Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SocialVId = {0}", objSysSocialRelationsVerEN.SocialVId); 
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngSocialVId,
};
 objSQL.ExecSP("SysSocialRelationsVer_Delete", values);
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
//删除SysSocialRelationsVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSocialRelationsVer where SocialVId = " + ""+ lngSocialVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysSocialRelationsVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
//删除SysSocialRelationsVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSocialRelationsVer where SocialVId in (" + strKeyList + ")";
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
//删除SysSocialRelationsVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSocialRelationsVer where SocialVId = " + ""+ lngSocialVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysSocialRelationsVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: DelSysSocialRelationsVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSocialRelationsVer where " + strCondition ;
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
public bool DelSysSocialRelationsVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysSocialRelationsVerDA: DelSysSocialRelationsVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSocialRelationsVer where " + strCondition ;
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
 /// <param name = "objSysSocialRelationsVerENS">源对象</param>
 /// <param name = "objSysSocialRelationsVerENT">目标对象</param>
public void CopyTo(clsSysSocialRelationsVerEN objSysSocialRelationsVerENS, clsSysSocialRelationsVerEN objSysSocialRelationsVerENT)
{
objSysSocialRelationsVerENT.SocialVId = objSysSocialRelationsVerENS.SocialVId; //SocialVId
objSysSocialRelationsVerENT.SocialId = objSysSocialRelationsVerENS.SocialId; //社会Id
objSysSocialRelationsVerENT.FullName = objSysSocialRelationsVerENS.FullName; //姓名
objSysSocialRelationsVerENT.Nationality = objSysSocialRelationsVerENS.Nationality; //国籍
objSysSocialRelationsVerENT.WorkUnit = objSysSocialRelationsVerENS.WorkUnit; //工作单位
objSysSocialRelationsVerENT.Major = objSysSocialRelationsVerENS.Major; //专业
objSysSocialRelationsVerENT.Achievement = objSysSocialRelationsVerENS.Achievement; //成就
objSysSocialRelationsVerENT.DetailedDescription = objSysSocialRelationsVerENS.DetailedDescription; //详细说明
objSysSocialRelationsVerENT.LevelId = objSysSocialRelationsVerENS.LevelId; //级别Id
objSysSocialRelationsVerENT.UpdUser = objSysSocialRelationsVerENS.UpdUser; //修改人
objSysSocialRelationsVerENT.UpdDate = objSysSocialRelationsVerENS.UpdDate; //修改日期
objSysSocialRelationsVerENT.IdCurrEduCls = objSysSocialRelationsVerENS.IdCurrEduCls; //教学班流水号
objSysSocialRelationsVerENT.Memo = objSysSocialRelationsVerENS.Memo; //备注
objSysSocialRelationsVerENT.CitationId = objSysSocialRelationsVerENS.CitationId; //引用Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSysSocialRelationsVerEN.SocialId, conSysSocialRelationsVer.SocialId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.SocialId, 10, conSysSocialRelationsVer.SocialId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.FullName, 50, conSysSocialRelationsVer.FullName);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Nationality, 50, conSysSocialRelationsVer.Nationality);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.WorkUnit, 100, conSysSocialRelationsVer.WorkUnit);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Major, 50, conSysSocialRelationsVer.Major);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Achievement, 5000, conSysSocialRelationsVer.Achievement);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.DetailedDescription, 5000, conSysSocialRelationsVer.DetailedDescription);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.LevelId, 2, conSysSocialRelationsVer.LevelId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.UpdUser, 20, conSysSocialRelationsVer.UpdUser);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.UpdDate, 20, conSysSocialRelationsVer.UpdDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.IdCurrEduCls, 8, conSysSocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Memo, 1000, conSysSocialRelationsVer.Memo);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.CitationId, 8, conSysSocialRelationsVer.CitationId);
//检查字段外键固定长度
 objSysSocialRelationsVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.SocialId, 10, conSysSocialRelationsVer.SocialId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.FullName, 50, conSysSocialRelationsVer.FullName);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Nationality, 50, conSysSocialRelationsVer.Nationality);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.WorkUnit, 100, conSysSocialRelationsVer.WorkUnit);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Major, 50, conSysSocialRelationsVer.Major);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Achievement, 5000, conSysSocialRelationsVer.Achievement);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.DetailedDescription, 5000, conSysSocialRelationsVer.DetailedDescription);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.LevelId, 2, conSysSocialRelationsVer.LevelId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.UpdUser, 20, conSysSocialRelationsVer.UpdUser);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.UpdDate, 20, conSysSocialRelationsVer.UpdDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.IdCurrEduCls, 8, conSysSocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Memo, 1000, conSysSocialRelationsVer.Memo);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.CitationId, 8, conSysSocialRelationsVer.CitationId);
//检查外键字段长度
 objSysSocialRelationsVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.SocialId, 10, conSysSocialRelationsVer.SocialId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.FullName, 50, conSysSocialRelationsVer.FullName);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Nationality, 50, conSysSocialRelationsVer.Nationality);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.WorkUnit, 100, conSysSocialRelationsVer.WorkUnit);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Major, 50, conSysSocialRelationsVer.Major);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Achievement, 5000, conSysSocialRelationsVer.Achievement);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.DetailedDescription, 5000, conSysSocialRelationsVer.DetailedDescription);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.LevelId, 2, conSysSocialRelationsVer.LevelId);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.UpdUser, 20, conSysSocialRelationsVer.UpdUser);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.UpdDate, 20, conSysSocialRelationsVer.UpdDate);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.IdCurrEduCls, 8, conSysSocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.Memo, 1000, conSysSocialRelationsVer.Memo);
clsCheckSql.CheckFieldLen(objSysSocialRelationsVerEN.CitationId, 8, conSysSocialRelationsVer.CitationId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.SocialId, conSysSocialRelationsVer.SocialId);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.FullName, conSysSocialRelationsVer.FullName);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.Nationality, conSysSocialRelationsVer.Nationality);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.WorkUnit, conSysSocialRelationsVer.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.Major, conSysSocialRelationsVer.Major);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.Achievement, conSysSocialRelationsVer.Achievement);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.DetailedDescription, conSysSocialRelationsVer.DetailedDescription);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.LevelId, conSysSocialRelationsVer.LevelId);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.UpdUser, conSysSocialRelationsVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.UpdDate, conSysSocialRelationsVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.IdCurrEduCls, conSysSocialRelationsVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.Memo, conSysSocialRelationsVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objSysSocialRelationsVerEN.CitationId, conSysSocialRelationsVer.CitationId);
//检查外键字段长度
 objSysSocialRelationsVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysSocialRelationsVer(社会关系版本表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsVerEN.SocialId);
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSocialRelationsVerEN._CurrTabName);
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSocialRelationsVerEN._CurrTabName, strCondition);
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
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
 objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}