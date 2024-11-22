
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PViewpointRelaDA
 表名:vgs_PViewpointRela(01120669)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:23
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
 /// 论文观点关系视图(vgs_PViewpointRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PViewpointRelaDA : clsCommBase4DA
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
 return clsvgs_PViewpointRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PViewpointRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PViewpointRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PViewpointRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PViewpointRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PViewpointRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable_vgs_PViewpointRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PViewpointRela.* from vgs_PViewpointRela Left Join {1} on {2} where {3} and vgs_PViewpointRela.mId not in (Select top {5} vgs_PViewpointRela.mId from vgs_PViewpointRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1} and mId not in (Select top {2} mId from vgs_PViewpointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1} and mId not in (Select top {3} mId from vgs_PViewpointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PViewpointRela.* from vgs_PViewpointRela Left Join {1} on {2} where {3} and vgs_PViewpointRela.mId not in (Select top {5} vgs_PViewpointRela.mId from vgs_PViewpointRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1} and mId not in (Select top {2} mId from vgs_PViewpointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PViewpointRela where {1} and mId not in (Select top {3} mId from vgs_PViewpointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PViewpointRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA:GetObjLst)", objException.Message));
}
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = TransNullToInt(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: GetObjLst)", objException.Message));
}
objvgs_PViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PViewpointRelaEN);
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
public List<clsvgs_PViewpointRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = TransNullToInt(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: GetObjLst)", objException.Message));
}
objvgs_PViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PViewpointRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PViewpointRela(ref clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where mId = " + ""+ objvgs_PViewpointRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PViewpointRelaEN.mId = TransNullToInt(objDT.Rows[0][convgs_PViewpointRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.PaperId = objDT.Rows[0][convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.PaperTitle = objDT.Rows[0][convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PViewpointRelaEN.PaperTypeId = objDT.Rows[0][convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PViewpointRelaEN.SectionId = objDT.Rows[0][convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.SectionName = objDT.Rows[0][convgs_PViewpointRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointId = objDT.Rows[0][convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointName = objDT.Rows[0][convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointContent = objDT.Rows[0][convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointTypeId = objDT.Rows[0][convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointTypeName = objDT.Rows[0][convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PViewpointRelaEN.Reason = objDT.Rows[0][convgs_PViewpointRela.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PViewpointRelaEN.VPProposePeople = objDT.Rows[0][convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PViewpointRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PViewpointRelaEN.UserTypeId = objDT.Rows[0][convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PViewpointRelaEN.UserTypeName = objDT.Rows[0][convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.Score = TransNullToFloat(objDT.Rows[0][convgs_PViewpointRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.ProposePeople = objDT.Rows[0][convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PViewpointRelaEN.UpdDate = objDT.Rows[0][convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.UpdUser = objDT.Rows[0][convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.Memo = objDT.Rows[0][convgs_PViewpointRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PViewpointRelaEN.ViewsDate = objDT.Rows[0][convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.ViewsUserId = objDT.Rows[0][convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.CreateDate = objDT.Rows[0][convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.ShareId = objDT.Rows[0][convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: Getvgs_PViewpointRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PViewpointRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
 objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: GetObjBymId)", objException.Message));
}
return objvgs_PViewpointRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PViewpointRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN()
{
mId = TransNullToInt(objRow[convgs_PViewpointRela.mId].ToString().Trim()), //mId
PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(), //论文标题
PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(), //论文类型Id
SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(), //节名
ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(), //观点内容
ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(), //观点类型Id
ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(), //观点类型名
Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(), //理由
VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(), //观点提出人
IsSubmit = TransNullToBool(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()), //是否提交
UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(), //用户类型名称
AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.Score].ToString().Trim()), //评分
StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()), //教师评分
OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()), //点赞统计
CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()), //版本统计
ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(), //提出人
UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(), //备注
ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(), //ViewsDate
ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(), //ViewsUserId
CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim() //分享Id
};
objvgs_PViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PViewpointRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PViewpointRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = TransNullToInt(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: GetObjByDataRowvgs_PViewpointRela)", objException.Message));
}
objvgs_PViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PViewpointRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PViewpointRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = TransNullToInt(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PViewpointRelaDA: GetObjByDataRow)", objException.Message));
}
objvgs_PViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PViewpointRelaEN;
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
objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PViewpointRelaEN._CurrTabName, convgs_PViewpointRela.mId, 8, "");
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
objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PViewpointRelaEN._CurrTabName, convgs_PViewpointRela.mId, 8, strPrefix);
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_PViewpointRela where " + strCondition;
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_PViewpointRela where " + strCondition;
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PViewpointRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PViewpointRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PViewpointRela", strCondition))
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
objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PViewpointRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaENS">源对象</param>
 /// <param name = "objvgs_PViewpointRelaENT">目标对象</param>
public void CopyTo(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENS, clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENT)
{
objvgs_PViewpointRelaENT.mId = objvgs_PViewpointRelaENS.mId; //mId
objvgs_PViewpointRelaENT.PaperId = objvgs_PViewpointRelaENS.PaperId; //论文Id
objvgs_PViewpointRelaENT.PaperTitle = objvgs_PViewpointRelaENS.PaperTitle; //论文标题
objvgs_PViewpointRelaENT.PaperTypeId = objvgs_PViewpointRelaENS.PaperTypeId; //论文类型Id
objvgs_PViewpointRelaENT.SectionId = objvgs_PViewpointRelaENS.SectionId; //节Id
objvgs_PViewpointRelaENT.SectionName = objvgs_PViewpointRelaENS.SectionName; //节名
objvgs_PViewpointRelaENT.ViewpointId = objvgs_PViewpointRelaENS.ViewpointId; //观点Id
objvgs_PViewpointRelaENT.ViewpointName = objvgs_PViewpointRelaENS.ViewpointName; //观点名称
objvgs_PViewpointRelaENT.ViewpointContent = objvgs_PViewpointRelaENS.ViewpointContent; //观点内容
objvgs_PViewpointRelaENT.ViewpointTypeId = objvgs_PViewpointRelaENS.ViewpointTypeId; //观点类型Id
objvgs_PViewpointRelaENT.ViewpointTypeName = objvgs_PViewpointRelaENS.ViewpointTypeName; //观点类型名
objvgs_PViewpointRelaENT.Reason = objvgs_PViewpointRelaENS.Reason; //理由
objvgs_PViewpointRelaENT.VPProposePeople = objvgs_PViewpointRelaENS.VPProposePeople; //观点提出人
objvgs_PViewpointRelaENT.IsSubmit = objvgs_PViewpointRelaENS.IsSubmit; //是否提交
objvgs_PViewpointRelaENT.UserTypeId = objvgs_PViewpointRelaENS.UserTypeId; //用户类型Id
objvgs_PViewpointRelaENT.UserTypeName = objvgs_PViewpointRelaENS.UserTypeName; //用户类型名称
objvgs_PViewpointRelaENT.AppraiseCount = objvgs_PViewpointRelaENS.AppraiseCount; //评论数
objvgs_PViewpointRelaENT.Score = objvgs_PViewpointRelaENS.Score; //评分
objvgs_PViewpointRelaENT.StuScore = objvgs_PViewpointRelaENS.StuScore; //学生平均分
objvgs_PViewpointRelaENT.TeaScore = objvgs_PViewpointRelaENS.TeaScore; //教师评分
objvgs_PViewpointRelaENT.OkCount = objvgs_PViewpointRelaENS.OkCount; //点赞统计
objvgs_PViewpointRelaENT.CitationCount = objvgs_PViewpointRelaENS.CitationCount; //引用统计
objvgs_PViewpointRelaENT.VersionCount = objvgs_PViewpointRelaENS.VersionCount; //版本统计
objvgs_PViewpointRelaENT.ProposePeople = objvgs_PViewpointRelaENS.ProposePeople; //提出人
objvgs_PViewpointRelaENT.UpdDate = objvgs_PViewpointRelaENS.UpdDate; //修改日期
objvgs_PViewpointRelaENT.UpdUser = objvgs_PViewpointRelaENS.UpdUser; //修改人
objvgs_PViewpointRelaENT.Memo = objvgs_PViewpointRelaENS.Memo; //备注
objvgs_PViewpointRelaENT.ViewsDate = objvgs_PViewpointRelaENS.ViewsDate; //ViewsDate
objvgs_PViewpointRelaENT.ViewsUserId = objvgs_PViewpointRelaENS.ViewsUserId; //ViewsUserId
objvgs_PViewpointRelaENT.CreateDate = objvgs_PViewpointRelaENS.CreateDate; //建立日期
objvgs_PViewpointRelaENT.ShareId = objvgs_PViewpointRelaENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.PaperId, 8, convgs_PViewpointRela.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.PaperTitle, 500, convgs_PViewpointRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.PaperTypeId, 2, convgs_PViewpointRela.PaperTypeId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.SectionId, 8, convgs_PViewpointRela.SectionId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.SectionName, 100, convgs_PViewpointRela.SectionName);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ViewpointId, 8, convgs_PViewpointRela.ViewpointId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ViewpointName, 500, convgs_PViewpointRela.ViewpointName);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ViewpointTypeId, 4, convgs_PViewpointRela.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ViewpointTypeName, 50, convgs_PViewpointRela.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.VPProposePeople, 50, convgs_PViewpointRela.VPProposePeople);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.UserTypeId, 2, convgs_PViewpointRela.UserTypeId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.UserTypeName, 20, convgs_PViewpointRela.UserTypeName);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ProposePeople, 50, convgs_PViewpointRela.ProposePeople);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.UpdDate, 20, convgs_PViewpointRela.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.UpdUser, 20, convgs_PViewpointRela.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.Memo, 1000, convgs_PViewpointRela.Memo);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ViewsDate, 20, convgs_PViewpointRela.ViewsDate);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ViewsUserId, 20, convgs_PViewpointRela.ViewsUserId);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.CreateDate, 20, convgs_PViewpointRela.CreateDate);
clsCheckSql.CheckFieldLen(objvgs_PViewpointRelaEN.ShareId, 2, convgs_PViewpointRela.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.PaperId, convgs_PViewpointRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.PaperTitle, convgs_PViewpointRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.PaperTypeId, convgs_PViewpointRela.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.SectionId, convgs_PViewpointRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.SectionName, convgs_PViewpointRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ViewpointId, convgs_PViewpointRela.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ViewpointName, convgs_PViewpointRela.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ViewpointTypeId, convgs_PViewpointRela.ViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ViewpointTypeName, convgs_PViewpointRela.ViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.VPProposePeople, convgs_PViewpointRela.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.UserTypeId, convgs_PViewpointRela.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.UserTypeName, convgs_PViewpointRela.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ProposePeople, convgs_PViewpointRela.ProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.UpdDate, convgs_PViewpointRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.UpdUser, convgs_PViewpointRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.Memo, convgs_PViewpointRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ViewsDate, convgs_PViewpointRela.ViewsDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ViewsUserId, convgs_PViewpointRela.ViewsUserId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.CreateDate, convgs_PViewpointRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PViewpointRelaEN.ShareId, convgs_PViewpointRela.ShareId);
//检查外键字段长度
 objvgs_PViewpointRelaEN._IsCheckProperty = true;
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PViewpointRelaEN._CurrTabName);
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PViewpointRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PViewpointRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}