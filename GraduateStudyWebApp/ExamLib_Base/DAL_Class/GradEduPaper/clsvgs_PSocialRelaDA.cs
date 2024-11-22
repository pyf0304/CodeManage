
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSocialRelaDA
 表名:vgs_PSocialRela(01120665)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文社会关系视图(vgs_PSocialRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PSocialRelaDA : clsCommBase4DA
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
 return clsvgs_PSocialRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PSocialRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PSocialRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PSocialRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PSocialRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PSocialRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable_vgs_PSocialRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PSocialRela.* from vgs_PSocialRela Left Join {1} on {2} where {3} and vgs_PSocialRela.mId not in (Select top {5} vgs_PSocialRela.mId from vgs_PSocialRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1} and mId not in (Select top {2} mId from vgs_PSocialRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1} and mId not in (Select top {3} mId from vgs_PSocialRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PSocialRela.* from vgs_PSocialRela Left Join {1} on {2} where {3} and vgs_PSocialRela.mId not in (Select top {5} vgs_PSocialRela.mId from vgs_PSocialRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1} and mId not in (Select top {2} mId from vgs_PSocialRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSocialRela where {1} and mId not in (Select top {3} mId from vgs_PSocialRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PSocialRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA:GetObjLst)", objException.Message));
}
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = TransNullToInt(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PSocialRelaDA: GetObjLst)", objException.Message));
}
objvgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PSocialRelaEN);
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
public List<clsvgs_PSocialRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = TransNullToInt(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PSocialRelaDA: GetObjLst)", objException.Message));
}
objvgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PSocialRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PSocialRela(ref clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where mId = " + ""+ objvgs_PSocialRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PSocialRelaEN.mId = TransNullToInt(objDT.Rows[0][convgs_PSocialRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.PaperId = objDT.Rows[0][convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.PaperTitle = objDT.Rows[0][convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PSocialRelaEN.PaperTypeId = objDT.Rows[0][convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSocialRelaEN.SectionId = objDT.Rows[0][convgs_PSocialRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.SectionName = objDT.Rows[0][convgs_PSocialRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PSocialRelaEN.SocialId = objDT.Rows[0][convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PSocialRelaEN.UpdDate = objDT.Rows[0][convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.UpdUser = objDT.Rows[0][convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.Memo = objDT.Rows[0][convgs_PSocialRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PSocialRelaEN.FullName = objDT.Rows[0][convgs_PSocialRela.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.Nationality = objDT.Rows[0][convgs_PSocialRela.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.WorkUnit = objDT.Rows[0][convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PSocialRelaEN.Major = objDT.Rows[0][convgs_PSocialRela.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.Achievement = objDT.Rows[0][convgs_PSocialRela.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvgs_PSocialRelaEN.DetailedDescription = objDT.Rows[0][convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PSocialRelaEN.LevelId = objDT.Rows[0][convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSocialRelaEN.LevelName = objDT.Rows[0][convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PSocialRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.Score = TransNullToFloat(objDT.Rows[0][convgs_PSocialRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.SocialUserId = objDT.Rows[0][convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.SocialDate = objDT.Rows[0][convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.CreateDate = objDT.Rows[0][convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.ShareId = objDT.Rows[0][convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PSocialRelaDA: Getvgs_PSocialRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PSocialRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
 objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PSocialRelaDA: GetObjBymId)", objException.Message));
}
return objvgs_PSocialRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PSocialRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN()
{
mId = TransNullToInt(objRow[convgs_PSocialRela.mId].ToString().Trim()), //mId
PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(), //论文标题
PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(), //论文类型Id
SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(), //节名
SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(), //社会Id
UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(), //备注
FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(), //姓名
Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(), //专业
Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(), //详细说明
LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(), //级别Id
LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(), //级别名称
IsSubmit = TransNullToBool(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()), //是否提交
OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.OkCount].ToString().Trim()), //点赞统计
CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()), //版本统计
AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.Score].ToString().Trim()), //评分
StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()), //教师评分
SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(), //SocialUserId
SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(), //SocialDate
CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim() //分享Id
};
objvgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PSocialRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PSocialRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PSocialRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = TransNullToInt(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PSocialRelaDA: GetObjByDataRowvgs_PSocialRela)", objException.Message));
}
objvgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PSocialRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PSocialRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = TransNullToInt(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PSocialRelaDA: GetObjByDataRow)", objException.Message));
}
objvgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PSocialRelaEN;
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
objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PSocialRelaEN._CurrTabName, convgs_PSocialRela.mId, 8, "");
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
objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PSocialRelaEN._CurrTabName, convgs_PSocialRela.mId, 8, strPrefix);
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_PSocialRela where " + strCondition;
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_PSocialRela where " + strCondition;
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PSocialRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PSocialRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PSocialRela", strCondition))
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
objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PSocialRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaENS">源对象</param>
 /// <param name = "objvgs_PSocialRelaENT">目标对象</param>
public void CopyTo(clsvgs_PSocialRelaEN objvgs_PSocialRelaENS, clsvgs_PSocialRelaEN objvgs_PSocialRelaENT)
{
objvgs_PSocialRelaENT.mId = objvgs_PSocialRelaENS.mId; //mId
objvgs_PSocialRelaENT.PaperId = objvgs_PSocialRelaENS.PaperId; //论文Id
objvgs_PSocialRelaENT.PaperTitle = objvgs_PSocialRelaENS.PaperTitle; //论文标题
objvgs_PSocialRelaENT.PaperTypeId = objvgs_PSocialRelaENS.PaperTypeId; //论文类型Id
objvgs_PSocialRelaENT.SectionId = objvgs_PSocialRelaENS.SectionId; //节Id
objvgs_PSocialRelaENT.SectionName = objvgs_PSocialRelaENS.SectionName; //节名
objvgs_PSocialRelaENT.SocialId = objvgs_PSocialRelaENS.SocialId; //社会Id
objvgs_PSocialRelaENT.UpdDate = objvgs_PSocialRelaENS.UpdDate; //修改日期
objvgs_PSocialRelaENT.UpdUser = objvgs_PSocialRelaENS.UpdUser; //修改人
objvgs_PSocialRelaENT.Memo = objvgs_PSocialRelaENS.Memo; //备注
objvgs_PSocialRelaENT.FullName = objvgs_PSocialRelaENS.FullName; //姓名
objvgs_PSocialRelaENT.Nationality = objvgs_PSocialRelaENS.Nationality; //国籍
objvgs_PSocialRelaENT.WorkUnit = objvgs_PSocialRelaENS.WorkUnit; //工作单位
objvgs_PSocialRelaENT.Major = objvgs_PSocialRelaENS.Major; //专业
objvgs_PSocialRelaENT.Achievement = objvgs_PSocialRelaENS.Achievement; //成就
objvgs_PSocialRelaENT.DetailedDescription = objvgs_PSocialRelaENS.DetailedDescription; //详细说明
objvgs_PSocialRelaENT.LevelId = objvgs_PSocialRelaENS.LevelId; //级别Id
objvgs_PSocialRelaENT.LevelName = objvgs_PSocialRelaENS.LevelName; //级别名称
objvgs_PSocialRelaENT.IsSubmit = objvgs_PSocialRelaENS.IsSubmit; //是否提交
objvgs_PSocialRelaENT.OkCount = objvgs_PSocialRelaENS.OkCount; //点赞统计
objvgs_PSocialRelaENT.CitationCount = objvgs_PSocialRelaENS.CitationCount; //引用统计
objvgs_PSocialRelaENT.VersionCount = objvgs_PSocialRelaENS.VersionCount; //版本统计
objvgs_PSocialRelaENT.AppraiseCount = objvgs_PSocialRelaENS.AppraiseCount; //评论数
objvgs_PSocialRelaENT.Score = objvgs_PSocialRelaENS.Score; //评分
objvgs_PSocialRelaENT.StuScore = objvgs_PSocialRelaENS.StuScore; //学生平均分
objvgs_PSocialRelaENT.TeaScore = objvgs_PSocialRelaENS.TeaScore; //教师评分
objvgs_PSocialRelaENT.SocialUserId = objvgs_PSocialRelaENS.SocialUserId; //SocialUserId
objvgs_PSocialRelaENT.SocialDate = objvgs_PSocialRelaENS.SocialDate; //SocialDate
objvgs_PSocialRelaENT.CreateDate = objvgs_PSocialRelaENS.CreateDate; //建立日期
objvgs_PSocialRelaENT.ShareId = objvgs_PSocialRelaENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.PaperId, 8, convgs_PSocialRela.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.PaperTitle, 500, convgs_PSocialRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.PaperTypeId, 2, convgs_PSocialRela.PaperTypeId);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.SectionId, 8, convgs_PSocialRela.SectionId);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.SectionName, 100, convgs_PSocialRela.SectionName);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.SocialId, 10, convgs_PSocialRela.SocialId);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.UpdDate, 20, convgs_PSocialRela.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.UpdUser, 20, convgs_PSocialRela.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.Memo, 1000, convgs_PSocialRela.Memo);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.FullName, 50, convgs_PSocialRela.FullName);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.Nationality, 50, convgs_PSocialRela.Nationality);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.WorkUnit, 100, convgs_PSocialRela.WorkUnit);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.Major, 50, convgs_PSocialRela.Major);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.Achievement, 5000, convgs_PSocialRela.Achievement);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.LevelId, 2, convgs_PSocialRela.LevelId);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.LevelName, 50, convgs_PSocialRela.LevelName);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.SocialUserId, 20, convgs_PSocialRela.SocialUserId);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.SocialDate, 20, convgs_PSocialRela.SocialDate);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.CreateDate, 20, convgs_PSocialRela.CreateDate);
clsCheckSql.CheckFieldLen(objvgs_PSocialRelaEN.ShareId, 2, convgs_PSocialRela.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.PaperId, convgs_PSocialRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.PaperTitle, convgs_PSocialRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.PaperTypeId, convgs_PSocialRela.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.SectionId, convgs_PSocialRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.SectionName, convgs_PSocialRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.SocialId, convgs_PSocialRela.SocialId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.UpdDate, convgs_PSocialRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.UpdUser, convgs_PSocialRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.Memo, convgs_PSocialRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.FullName, convgs_PSocialRela.FullName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.Nationality, convgs_PSocialRela.Nationality);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.WorkUnit, convgs_PSocialRela.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.Major, convgs_PSocialRela.Major);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.Achievement, convgs_PSocialRela.Achievement);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.LevelId, convgs_PSocialRela.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.LevelName, convgs_PSocialRela.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.SocialUserId, convgs_PSocialRela.SocialUserId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.SocialDate, convgs_PSocialRela.SocialDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.CreateDate, convgs_PSocialRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSocialRelaEN.ShareId, convgs_PSocialRela.ShareId);
//检查外键字段长度
 objvgs_PSocialRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetmId()
{
//获取某学院所有专业信息
string strSQL = "select mId, LevelId from vgs_PSocialRela ";
 clsSpecSQLforSql mySql = clsvgs_PSocialRelaDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PSocialRelaEN._CurrTabName);
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PSocialRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PSocialRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}