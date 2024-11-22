
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointDA
 表名:vPaperSubViewpoint(01120551)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v子观点表(vPaperSubViewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperSubViewpointDA : clsCommBase4DA
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
 return clsvPaperSubViewpointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperSubViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperSubViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperSubViewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable_vPaperSubViewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperSubViewpoint.* from vPaperSubViewpoint Left Join {1} on {2} where {3} and vPaperSubViewpoint.SubViewpointId not in (Select top {5} vPaperSubViewpoint.SubViewpointId from vPaperSubViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1} and SubViewpointId not in (Select top {2} SubViewpointId from vPaperSubViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1} and SubViewpointId not in (Select top {3} SubViewpointId from vPaperSubViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperSubViewpoint.* from vPaperSubViewpoint Left Join {1} on {2} where {3} and vPaperSubViewpoint.SubViewpointId not in (Select top {5} vPaperSubViewpoint.SubViewpointId from vPaperSubViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1} and SubViewpointId not in (Select top {2} SubViewpointId from vPaperSubViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpoint where {1} and SubViewpointId not in (Select top {3} SubViewpointId from vPaperSubViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperSubViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA:GetObjLst)", objException.Message));
}
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = TransNullToBool(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetObjLst)", objException.Message));
}
objvPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperSubViewpointEN);
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
public List<clsvPaperSubViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = TransNullToBool(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetObjLst)", objException.Message));
}
objvPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperSubViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperSubViewpoint(ref clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where SubViewpointId = " + ""+ objvPaperSubViewpointEN.SubViewpointId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperSubViewpointEN.SubViewpointId = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.SubViewpointContent = objDT.Rows[0][convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperSubViewpointEN.PaperRWId = objDT.Rows[0][convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.PaperId = objDT.Rows[0][convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.PaperTitle = objDT.Rows[0][convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperSubViewpointEN.IsSubmit = TransNullToBool(objDT.Rows[0][convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSubViewpointEN.IdCurrEduCls = objDT.Rows[0][convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperSubViewpointEN.UserId = objDT.Rows[0][convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvPaperSubViewpointEN.SectionId = objDT.Rows[0][convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.SectionName = objDT.Rows[0][convPaperSubViewpoint.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSubViewpointEN.SubViewpointTypeId = objDT.Rows[0][convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvPaperSubViewpointEN.SubViewpointTypeName = objDT.Rows[0][convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.DefaTitle = objDT.Rows[0][convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.gsKnowledgeTypeId = objDT.Rows[0][convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperSubViewpointEN.RWTitle = objDT.Rows[0][convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.ExplainTypeId = objDT.Rows[0][convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperSubViewpointEN.ExplainTypeName = objDT.Rows[0][convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.ExplainContent = objDT.Rows[0][convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointEN.IsPublic = TransNullToBool(objDT.Rows[0][convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSubViewpointEN.LiteratureSourcesId = objDT.Rows[0][convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.OperationTypeId = objDT.Rows[0][convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPaperSubViewpointEN.LevelId = objDT.Rows[0][convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperSubViewpointEN.Conclusion = objDT.Rows[0][convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointEN.Nationality = objDT.Rows[0][convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.Achievement = objDT.Rows[0][convPaperSubViewpoint.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointEN.Major = objDT.Rows[0][convPaperSubViewpoint.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.WorkUnit = objDT.Rows[0][convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSubViewpointEN.PageNumber = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.OrderNum = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.PdfContent = objDT.Rows[0][convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSubViewpointEN.selectSpanRange = objDT.Rows[0][convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.PaperLineNum = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.PaperPageNum = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.OkCount = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.Score = TransNullToFloat(objDT.Rows[0][convPaperSubViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.CreateDate = objDT.Rows[0][convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.ShareId = objDT.Rows[0][convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperSubViewpointEN.AttitudesId = objDT.Rows[0][convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperSubViewpointEN.AttitudesName = objDT.Rows[0][convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperSubViewpointEN.UpdDate = objDT.Rows[0][convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.UpdUser = objDT.Rows[0][convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.Memo = objDT.Rows[0][convPaperSubViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSubViewpointEN.SectionOrderNum = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.SubViewpointTypeOrderNum = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.IsRecommend = TransNullToBool(objDT.Rows[0][convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSubViewpointEN.gsKnowledgeTypeName = objDT.Rows[0][convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPaperSubViewpointEN.LevelName = objDT.Rows[0][convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.OperationTypeName = objDT.Rows[0][convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPaperSubViewpointEN.CourseId = objDT.Rows[0][convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetvPaperSubViewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperSubViewpointEN GetObjBySubViewpointId(long lngSubViewpointId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where SubViewpointId = " + ""+ lngSubViewpointId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
 objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetObjBySubViewpointId)", objException.Message));
}
return objvPaperSubViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperSubViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN()
{
SubViewpointId = TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()), //子观点Id
SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(), //详情内容
PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(), //课文阅读
PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(), //论文标题
IsSubmit = TransNullToBool(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()), //是否提交
IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(), //用户ID
SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(), //节名
SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(), //类型Id
SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(), //类型名称
DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(), //默认标题
gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(), //知识类型Id
RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(), //读写标题
ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(), //说明类型Id
ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(), //说明类型名
ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(), //说明内容
IsPublic = TransNullToBool(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()), //是否公开
LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(), //文献来源
OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(), //操作类型ID
LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(), //级别Id
Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(), //结论
Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(), //国籍
Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(), //成就
Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(), //专业
WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(), //工作单位
PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()), //页码
OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()), //序号
PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(), //Pdf内容
selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(), //选择Span范围
PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()), //论文行号
PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()), //论文页码
AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()), //点赞统计
Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.Score].ToString().Trim()), //评分
StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(), //分享Id
AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(), //态度Id
AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(), //名称
UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(), //备注
SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()), //SectionOrderNum
SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()), //子观点类型序号
CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()), //版本统计
IsRecommend = TransNullToBool(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()), //是否推荐
gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(), //知识类型名
LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(), //级别名称
OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(), //操作类型名
CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim() //课程Id
};
objvPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSubViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperSubViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = TransNullToBool(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetObjByDataRowvPaperSubViewpoint)", objException.Message));
}
objvPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSubViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperSubViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = TransNullToBool(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperSubViewpointDA: GetObjByDataRow)", objException.Message));
}
objvPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSubViewpointEN;
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
objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperSubViewpointEN._CurrTabName, convPaperSubViewpoint.SubViewpointId, 8, "");
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
objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperSubViewpointEN._CurrTabName, convPaperSubViewpoint.SubViewpointId, 8, strPrefix);
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SubViewpointId from vPaperSubViewpoint where " + strCondition;
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SubViewpointId from vPaperSubViewpoint where " + strCondition;
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngSubViewpointId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperSubViewpoint", "SubViewpointId = " + ""+ lngSubViewpointId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperSubViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperSubViewpoint", strCondition))
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
objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperSubViewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperSubViewpointENS">源对象</param>
 /// <param name = "objvPaperSubViewpointENT">目标对象</param>
public void CopyTo(clsvPaperSubViewpointEN objvPaperSubViewpointENS, clsvPaperSubViewpointEN objvPaperSubViewpointENT)
{
objvPaperSubViewpointENT.SubViewpointId = objvPaperSubViewpointENS.SubViewpointId; //子观点Id
objvPaperSubViewpointENT.SubViewpointContent = objvPaperSubViewpointENS.SubViewpointContent; //详情内容
objvPaperSubViewpointENT.PaperRWId = objvPaperSubViewpointENS.PaperRWId; //课文阅读
objvPaperSubViewpointENT.PaperId = objvPaperSubViewpointENS.PaperId; //论文Id
objvPaperSubViewpointENT.PaperTitle = objvPaperSubViewpointENS.PaperTitle; //论文标题
objvPaperSubViewpointENT.IsSubmit = objvPaperSubViewpointENS.IsSubmit; //是否提交
objvPaperSubViewpointENT.IdCurrEduCls = objvPaperSubViewpointENS.IdCurrEduCls; //教学班流水号
objvPaperSubViewpointENT.UserId = objvPaperSubViewpointENS.UserId; //用户ID
objvPaperSubViewpointENT.SectionId = objvPaperSubViewpointENS.SectionId; //节Id
objvPaperSubViewpointENT.SectionName = objvPaperSubViewpointENS.SectionName; //节名
objvPaperSubViewpointENT.SubViewpointTypeId = objvPaperSubViewpointENS.SubViewpointTypeId; //类型Id
objvPaperSubViewpointENT.SubViewpointTypeName = objvPaperSubViewpointENS.SubViewpointTypeName; //类型名称
objvPaperSubViewpointENT.DefaTitle = objvPaperSubViewpointENS.DefaTitle; //默认标题
objvPaperSubViewpointENT.gsKnowledgeTypeId = objvPaperSubViewpointENS.gsKnowledgeTypeId; //知识类型Id
objvPaperSubViewpointENT.RWTitle = objvPaperSubViewpointENS.RWTitle; //读写标题
objvPaperSubViewpointENT.ExplainTypeId = objvPaperSubViewpointENS.ExplainTypeId; //说明类型Id
objvPaperSubViewpointENT.ExplainTypeName = objvPaperSubViewpointENS.ExplainTypeName; //说明类型名
objvPaperSubViewpointENT.ExplainContent = objvPaperSubViewpointENS.ExplainContent; //说明内容
objvPaperSubViewpointENT.IsPublic = objvPaperSubViewpointENS.IsPublic; //是否公开
objvPaperSubViewpointENT.LiteratureSourcesId = objvPaperSubViewpointENS.LiteratureSourcesId; //文献来源
objvPaperSubViewpointENT.OperationTypeId = objvPaperSubViewpointENS.OperationTypeId; //操作类型ID
objvPaperSubViewpointENT.LevelId = objvPaperSubViewpointENS.LevelId; //级别Id
objvPaperSubViewpointENT.Conclusion = objvPaperSubViewpointENS.Conclusion; //结论
objvPaperSubViewpointENT.Nationality = objvPaperSubViewpointENS.Nationality; //国籍
objvPaperSubViewpointENT.Achievement = objvPaperSubViewpointENS.Achievement; //成就
objvPaperSubViewpointENT.Major = objvPaperSubViewpointENS.Major; //专业
objvPaperSubViewpointENT.WorkUnit = objvPaperSubViewpointENS.WorkUnit; //工作单位
objvPaperSubViewpointENT.PageNumber = objvPaperSubViewpointENS.PageNumber; //页码
objvPaperSubViewpointENT.OrderNum = objvPaperSubViewpointENS.OrderNum; //序号
objvPaperSubViewpointENT.PdfContent = objvPaperSubViewpointENS.PdfContent; //Pdf内容
objvPaperSubViewpointENT.selectSpanRange = objvPaperSubViewpointENS.selectSpanRange; //选择Span范围
objvPaperSubViewpointENT.PaperLineNum = objvPaperSubViewpointENS.PaperLineNum; //论文行号
objvPaperSubViewpointENT.PaperPageNum = objvPaperSubViewpointENS.PaperPageNum; //论文页码
objvPaperSubViewpointENT.AppraiseCount = objvPaperSubViewpointENS.AppraiseCount; //评论数
objvPaperSubViewpointENT.OkCount = objvPaperSubViewpointENS.OkCount; //点赞统计
objvPaperSubViewpointENT.Score = objvPaperSubViewpointENS.Score; //评分
objvPaperSubViewpointENT.StuScore = objvPaperSubViewpointENS.StuScore; //学生平均分
objvPaperSubViewpointENT.TeaScore = objvPaperSubViewpointENS.TeaScore; //教师评分
objvPaperSubViewpointENT.CreateDate = objvPaperSubViewpointENS.CreateDate; //建立日期
objvPaperSubViewpointENT.ShareId = objvPaperSubViewpointENS.ShareId; //分享Id
objvPaperSubViewpointENT.AttitudesId = objvPaperSubViewpointENS.AttitudesId; //态度Id
objvPaperSubViewpointENT.AttitudesName = objvPaperSubViewpointENS.AttitudesName; //名称
objvPaperSubViewpointENT.UpdDate = objvPaperSubViewpointENS.UpdDate; //修改日期
objvPaperSubViewpointENT.UpdUser = objvPaperSubViewpointENS.UpdUser; //修改人
objvPaperSubViewpointENT.Memo = objvPaperSubViewpointENS.Memo; //备注
objvPaperSubViewpointENT.SectionOrderNum = objvPaperSubViewpointENS.SectionOrderNum; //SectionOrderNum
objvPaperSubViewpointENT.SubViewpointTypeOrderNum = objvPaperSubViewpointENS.SubViewpointTypeOrderNum; //子观点类型序号
objvPaperSubViewpointENT.CitationCount = objvPaperSubViewpointENS.CitationCount; //引用统计
objvPaperSubViewpointENT.VersionCount = objvPaperSubViewpointENS.VersionCount; //版本统计
objvPaperSubViewpointENT.IsRecommend = objvPaperSubViewpointENS.IsRecommend; //是否推荐
objvPaperSubViewpointENT.gsKnowledgeTypeName = objvPaperSubViewpointENS.gsKnowledgeTypeName; //知识类型名
objvPaperSubViewpointENT.LevelName = objvPaperSubViewpointENS.LevelName; //级别名称
objvPaperSubViewpointENT.OperationTypeName = objvPaperSubViewpointENS.OperationTypeName; //操作类型名
objvPaperSubViewpointENT.CourseId = objvPaperSubViewpointENS.CourseId; //课程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.SubViewpointContent, 500, convPaperSubViewpoint.SubViewpointContent);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.PaperRWId, 8, convPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.PaperId, 8, convPaperSubViewpoint.PaperId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.PaperTitle, 500, convPaperSubViewpoint.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.IdCurrEduCls, 8, convPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.UserId, 18, convPaperSubViewpoint.UserId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.SectionId, 8, convPaperSubViewpoint.SectionId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.SectionName, 100, convPaperSubViewpoint.SectionName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.SubViewpointTypeId, 8, convPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.SubViewpointTypeName, 50, convPaperSubViewpoint.SubViewpointTypeName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.DefaTitle, 20, convPaperSubViewpoint.DefaTitle);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.gsKnowledgeTypeId, 2, convPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.RWTitle, 50, convPaperSubViewpoint.RWTitle);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.ExplainTypeId, 2, convPaperSubViewpoint.ExplainTypeId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.ExplainTypeName, 50, convPaperSubViewpoint.ExplainTypeName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.ExplainContent, 5000, convPaperSubViewpoint.ExplainContent);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.LiteratureSourcesId, 8, convPaperSubViewpoint.LiteratureSourcesId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.OperationTypeId, 4, convPaperSubViewpoint.OperationTypeId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.LevelId, 2, convPaperSubViewpoint.LevelId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.Conclusion, 5000, convPaperSubViewpoint.Conclusion);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.Nationality, 50, convPaperSubViewpoint.Nationality);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.Achievement, 5000, convPaperSubViewpoint.Achievement);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.Major, 50, convPaperSubViewpoint.Major);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.WorkUnit, 100, convPaperSubViewpoint.WorkUnit);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.PdfContent, 2000, convPaperSubViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.selectSpanRange, 50, convPaperSubViewpoint.selectSpanRange);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.CreateDate, 20, convPaperSubViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.ShareId, 2, convPaperSubViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.AttitudesId, 2, convPaperSubViewpoint.AttitudesId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.AttitudesName, 200, convPaperSubViewpoint.AttitudesName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.UpdDate, 20, convPaperSubViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.UpdUser, 20, convPaperSubViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.Memo, 1000, convPaperSubViewpoint.Memo);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.gsKnowledgeTypeName, 50, convPaperSubViewpoint.gsKnowledgeTypeName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.LevelName, 50, convPaperSubViewpoint.LevelName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.OperationTypeName, 50, convPaperSubViewpoint.OperationTypeName);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointEN.CourseId, 8, convPaperSubViewpoint.CourseId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.SubViewpointContent, convPaperSubViewpoint.SubViewpointContent);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.PaperRWId, convPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.PaperId, convPaperSubViewpoint.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.PaperTitle, convPaperSubViewpoint.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.IdCurrEduCls, convPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.UserId, convPaperSubViewpoint.UserId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.SectionId, convPaperSubViewpoint.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.SectionName, convPaperSubViewpoint.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.SubViewpointTypeId, convPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.SubViewpointTypeName, convPaperSubViewpoint.SubViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.DefaTitle, convPaperSubViewpoint.DefaTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.gsKnowledgeTypeId, convPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.RWTitle, convPaperSubViewpoint.RWTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.ExplainTypeId, convPaperSubViewpoint.ExplainTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.ExplainTypeName, convPaperSubViewpoint.ExplainTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.ExplainContent, convPaperSubViewpoint.ExplainContent);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.LiteratureSourcesId, convPaperSubViewpoint.LiteratureSourcesId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.OperationTypeId, convPaperSubViewpoint.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.LevelId, convPaperSubViewpoint.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.Conclusion, convPaperSubViewpoint.Conclusion);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.Nationality, convPaperSubViewpoint.Nationality);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.Achievement, convPaperSubViewpoint.Achievement);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.Major, convPaperSubViewpoint.Major);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.WorkUnit, convPaperSubViewpoint.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.PdfContent, convPaperSubViewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.selectSpanRange, convPaperSubViewpoint.selectSpanRange);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.CreateDate, convPaperSubViewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.ShareId, convPaperSubViewpoint.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.AttitudesId, convPaperSubViewpoint.AttitudesId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.AttitudesName, convPaperSubViewpoint.AttitudesName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.UpdDate, convPaperSubViewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.UpdUser, convPaperSubViewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.Memo, convPaperSubViewpoint.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.gsKnowledgeTypeName, convPaperSubViewpoint.gsKnowledgeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.LevelName, convPaperSubViewpoint.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.OperationTypeName, convPaperSubViewpoint.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointEN.CourseId, convPaperSubViewpoint.CourseId);
//检查外键字段长度
 objvPaperSubViewpointEN._IsCheckProperty = true;
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperSubViewpointEN._CurrTabName);
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperSubViewpointEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}