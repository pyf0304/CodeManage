
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSkillRelaDA
 表名:vgs_PSkillRela(01120666)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:17
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
 /// 论文技能关系视图(vgs_PSkillRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PSkillRelaDA : clsCommBase4DA
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
 return clsvgs_PSkillRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PSkillRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PSkillRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PSkillRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PSkillRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PSkillRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable_vgs_PSkillRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PSkillRela.* from vgs_PSkillRela Left Join {1} on {2} where {3} and vgs_PSkillRela.mId not in (Select top {5} vgs_PSkillRela.mId from vgs_PSkillRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1} and mId not in (Select top {2} mId from vgs_PSkillRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1} and mId not in (Select top {3} mId from vgs_PSkillRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PSkillRela.* from vgs_PSkillRela Left Join {1} on {2} where {3} and vgs_PSkillRela.mId not in (Select top {5} vgs_PSkillRela.mId from vgs_PSkillRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1} and mId not in (Select top {2} mId from vgs_PSkillRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PSkillRela where {1} and mId not in (Select top {3} mId from vgs_PSkillRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PSkillRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA:GetObjLst)", objException.Message));
}
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = TransNullToInt(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PSkillRelaDA: GetObjLst)", objException.Message));
}
objvgs_PSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PSkillRelaEN);
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
public List<clsvgs_PSkillRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = TransNullToInt(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PSkillRelaDA: GetObjLst)", objException.Message));
}
objvgs_PSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PSkillRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PSkillRela(ref clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where mId = " + ""+ objvgs_PSkillRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PSkillRelaEN.mId = TransNullToInt(objDT.Rows[0][convgs_PSkillRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.PaperId = objDT.Rows[0][convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.PaperTitle = objDT.Rows[0][convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PSkillRelaEN.PaperTypeId = objDT.Rows[0][convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSkillRelaEN.SectionId = objDT.Rows[0][convgs_PSkillRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.SectionName = objDT.Rows[0][convgs_PSkillRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PSkillRelaEN.SkillId = objDT.Rows[0][convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PSkillRelaEN.UpdDate = objDT.Rows[0][convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.UpdUser = objDT.Rows[0][convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.Memo = objDT.Rows[0][convgs_PSkillRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PSkillRelaEN.SkillName = objDT.Rows[0][convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_PSkillRelaEN.OperationTypeId = objDT.Rows[0][convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvgs_PSkillRelaEN.OperationTypeName = objDT.Rows[0][convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvgs_PSkillRelaEN.LevelName = objDT.Rows[0][convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSkillRelaEN.LevelId = objDT.Rows[0][convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSkillRelaEN.Process = objDT.Rows[0][convgs_PSkillRela.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PSkillRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PSkillRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.Score = TransNullToFloat(objDT.Rows[0][convgs_PSkillRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.SkillUserId = objDT.Rows[0][convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.SkillDate = objDT.Rows[0][convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.CreateDate = objDT.Rows[0][convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.ShareId = objDT.Rows[0][convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PSkillRelaDA: Getvgs_PSkillRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PSkillRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
 objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PSkillRelaDA: GetObjBymId)", objException.Message));
}
return objvgs_PSkillRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PSkillRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PSkillRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN()
{
mId = TransNullToInt(objRow[convgs_PSkillRela.mId].ToString().Trim()), //mId
PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(), //论文标题
PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(), //论文类型Id
SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(), //节名
SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(), //技能Id
UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(), //备注
SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(), //技能名称
OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(), //操作类型ID
OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(), //操作类型名
LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(), //级别名称
LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(), //级别Id
Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(), //实施过程
IsSubmit = TransNullToBool(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()), //是否提交
OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.OkCount].ToString().Trim()), //点赞统计
Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.Score].ToString().Trim()), //评分
AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()), //评论数
StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()), //教师评分
CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()), //版本统计
SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(), //SkillUserId
SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(), //SkillDate
CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim() //分享Id
};
objvgs_PSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PSkillRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PSkillRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PSkillRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = TransNullToInt(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PSkillRelaDA: GetObjByDataRowvgs_PSkillRela)", objException.Message));
}
objvgs_PSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PSkillRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PSkillRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = TransNullToInt(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PSkillRelaDA: GetObjByDataRow)", objException.Message));
}
objvgs_PSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PSkillRelaEN;
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
objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PSkillRelaEN._CurrTabName, convgs_PSkillRela.mId, 8, "");
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
objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PSkillRelaEN._CurrTabName, convgs_PSkillRela.mId, 8, strPrefix);
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_PSkillRela where " + strCondition;
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_PSkillRela where " + strCondition;
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PSkillRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PSkillRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PSkillRela", strCondition))
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
objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PSkillRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaENS">源对象</param>
 /// <param name = "objvgs_PSkillRelaENT">目标对象</param>
public void CopyTo(clsvgs_PSkillRelaEN objvgs_PSkillRelaENS, clsvgs_PSkillRelaEN objvgs_PSkillRelaENT)
{
objvgs_PSkillRelaENT.mId = objvgs_PSkillRelaENS.mId; //mId
objvgs_PSkillRelaENT.PaperId = objvgs_PSkillRelaENS.PaperId; //论文Id
objvgs_PSkillRelaENT.PaperTitle = objvgs_PSkillRelaENS.PaperTitle; //论文标题
objvgs_PSkillRelaENT.PaperTypeId = objvgs_PSkillRelaENS.PaperTypeId; //论文类型Id
objvgs_PSkillRelaENT.SectionId = objvgs_PSkillRelaENS.SectionId; //节Id
objvgs_PSkillRelaENT.SectionName = objvgs_PSkillRelaENS.SectionName; //节名
objvgs_PSkillRelaENT.SkillId = objvgs_PSkillRelaENS.SkillId; //技能Id
objvgs_PSkillRelaENT.UpdDate = objvgs_PSkillRelaENS.UpdDate; //修改日期
objvgs_PSkillRelaENT.UpdUser = objvgs_PSkillRelaENS.UpdUser; //修改人
objvgs_PSkillRelaENT.Memo = objvgs_PSkillRelaENS.Memo; //备注
objvgs_PSkillRelaENT.SkillName = objvgs_PSkillRelaENS.SkillName; //技能名称
objvgs_PSkillRelaENT.OperationTypeId = objvgs_PSkillRelaENS.OperationTypeId; //操作类型ID
objvgs_PSkillRelaENT.OperationTypeName = objvgs_PSkillRelaENS.OperationTypeName; //操作类型名
objvgs_PSkillRelaENT.LevelName = objvgs_PSkillRelaENS.LevelName; //级别名称
objvgs_PSkillRelaENT.LevelId = objvgs_PSkillRelaENS.LevelId; //级别Id
objvgs_PSkillRelaENT.Process = objvgs_PSkillRelaENS.Process; //实施过程
objvgs_PSkillRelaENT.IsSubmit = objvgs_PSkillRelaENS.IsSubmit; //是否提交
objvgs_PSkillRelaENT.OkCount = objvgs_PSkillRelaENS.OkCount; //点赞统计
objvgs_PSkillRelaENT.Score = objvgs_PSkillRelaENS.Score; //评分
objvgs_PSkillRelaENT.AppraiseCount = objvgs_PSkillRelaENS.AppraiseCount; //评论数
objvgs_PSkillRelaENT.StuScore = objvgs_PSkillRelaENS.StuScore; //学生平均分
objvgs_PSkillRelaENT.TeaScore = objvgs_PSkillRelaENS.TeaScore; //教师评分
objvgs_PSkillRelaENT.CitationCount = objvgs_PSkillRelaENS.CitationCount; //引用统计
objvgs_PSkillRelaENT.VersionCount = objvgs_PSkillRelaENS.VersionCount; //版本统计
objvgs_PSkillRelaENT.SkillUserId = objvgs_PSkillRelaENS.SkillUserId; //SkillUserId
objvgs_PSkillRelaENT.SkillDate = objvgs_PSkillRelaENS.SkillDate; //SkillDate
objvgs_PSkillRelaENT.CreateDate = objvgs_PSkillRelaENS.CreateDate; //建立日期
objvgs_PSkillRelaENT.ShareId = objvgs_PSkillRelaENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.PaperId, 8, convgs_PSkillRela.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.PaperTitle, 500, convgs_PSkillRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.PaperTypeId, 2, convgs_PSkillRela.PaperTypeId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.SectionId, 8, convgs_PSkillRela.SectionId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.SectionName, 100, convgs_PSkillRela.SectionName);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.SkillId, 10, convgs_PSkillRela.SkillId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.UpdDate, 20, convgs_PSkillRela.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.UpdUser, 20, convgs_PSkillRela.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.Memo, 1000, convgs_PSkillRela.Memo);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.SkillName, 200, convgs_PSkillRela.SkillName);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.OperationTypeId, 4, convgs_PSkillRela.OperationTypeId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.OperationTypeName, 50, convgs_PSkillRela.OperationTypeName);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.LevelName, 50, convgs_PSkillRela.LevelName);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.LevelId, 2, convgs_PSkillRela.LevelId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.SkillUserId, 20, convgs_PSkillRela.SkillUserId);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.SkillDate, 20, convgs_PSkillRela.SkillDate);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.CreateDate, 20, convgs_PSkillRela.CreateDate);
clsCheckSql.CheckFieldLen(objvgs_PSkillRelaEN.ShareId, 2, convgs_PSkillRela.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.PaperId, convgs_PSkillRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.PaperTitle, convgs_PSkillRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.PaperTypeId, convgs_PSkillRela.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.SectionId, convgs_PSkillRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.SectionName, convgs_PSkillRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.SkillId, convgs_PSkillRela.SkillId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.UpdDate, convgs_PSkillRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.UpdUser, convgs_PSkillRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.Memo, convgs_PSkillRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.SkillName, convgs_PSkillRela.SkillName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.OperationTypeId, convgs_PSkillRela.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.OperationTypeName, convgs_PSkillRela.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.LevelName, convgs_PSkillRela.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.LevelId, convgs_PSkillRela.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.SkillUserId, convgs_PSkillRela.SkillUserId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.SkillDate, convgs_PSkillRela.SkillDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.CreateDate, convgs_PSkillRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PSkillRelaEN.ShareId, convgs_PSkillRela.ShareId);
//检查外键字段长度
 objvgs_PSkillRelaEN._IsCheckProperty = true;
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
string strSQL = "select mId, LevelId from vgs_PSkillRela ";
 clsSpecSQLforSql mySql = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PSkillRelaEN._CurrTabName);
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PSkillRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PSkillRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}