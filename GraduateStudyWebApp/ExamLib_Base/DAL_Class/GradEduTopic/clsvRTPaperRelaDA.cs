
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTPaperRelaDA
 表名:vRTPaperRela(01120583)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:13
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
 /// vRTPaperRela(vRTPaperRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTPaperRelaDA : clsCommBase4DA
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
 return clsvRTPaperRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTPaperRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTPaperRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTPaperRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTPaperRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTPaperRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable_vRTPaperRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTPaperRela.* from vRTPaperRela Left Join {1} on {2} where {3} and vRTPaperRela.mId not in (Select top {5} vRTPaperRela.mId from vRTPaperRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1} and mId not in (Select top {2} mId from vRTPaperRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1} and mId not in (Select top {3} mId from vRTPaperRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTPaperRela.* from vRTPaperRela Left Join {1} on {2} where {3} and vRTPaperRela.mId not in (Select top {5} vRTPaperRela.mId from vRTPaperRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1} and mId not in (Select top {2} mId from vRTPaperRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTPaperRela where {1} and mId not in (Select top {3} mId from vRTPaperRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTPaperRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = TransNullToInt(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = TransNullToBool(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTPaperRelaDA: GetObjLst)", objException.Message));
}
objvRTPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTPaperRelaEN);
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
public List<clsvRTPaperRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = TransNullToInt(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = TransNullToBool(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTPaperRelaDA: GetObjLst)", objException.Message));
}
objvRTPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTPaperRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTPaperRela(ref clsvRTPaperRelaEN objvRTPaperRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where mId = " + ""+ objvRTPaperRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTPaperRelaEN.mId = TransNullToInt(objDT.Rows[0][convRTPaperRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTPaperRelaEN.TopicId = objDT.Rows[0][convRTPaperRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTPaperRelaEN.PaperId = objDT.Rows[0][convRTPaperRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTPaperRelaEN.TopicName = objDT.Rows[0][convRTPaperRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTPaperRelaEN.TopicContent = objDT.Rows[0][convRTPaperRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTPaperRelaEN.TopicProposePeople = objDT.Rows[0][convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTPaperRelaEN.PaperTitle = objDT.Rows[0][convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvRTPaperRelaEN.PaperContent = objDT.Rows[0][convRTPaperRela.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTPaperRelaEN.Author = objDT.Rows[0][convRTPaperRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTPaperRelaEN.Periodical = objDT.Rows[0][convRTPaperRela.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTPaperRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTPaperRelaEN.IdCurrEduCls = objDT.Rows[0][convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTPaperRelaEN.PaperDate = objDT.Rows[0][convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.PaperStatusId = objDT.Rows[0][convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTPaperRelaEN.PaperTypeId = objDT.Rows[0][convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTPaperRelaEN.PaperUserId = objDT.Rows[0][convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTPaperRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTPaperRelaEN.PaperTypeName = objDT.Rows[0][convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTPaperRelaEN.UpdDate = objDT.Rows[0][convRTPaperRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.UpdUser = objDT.Rows[0][convRTPaperRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.Memo = objDT.Rows[0][convRTPaperRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTPaperRelaDA: GetvRTPaperRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTPaperRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
 objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTPaperRelaDA: GetObjBymId)", objException.Message));
}
return objvRTPaperRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTPaperRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTPaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN()
{
mId = TransNullToInt(objRow[convRTPaperRela.mId].ToString().Trim()), //mId
TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(), //主题Id
PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(), //论文Id
TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(), //主题提出人
PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(), //主题内容
Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(), //作者
Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(), //期刊
IsSubmit = TransNullToBool(objRow[convRTPaperRela.IsSubmit].ToString().Trim()), //是否提交
IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(), //PaperDate
PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(), //论文状态Id
PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(), //论文类型Id
PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(), //PaperUserId
VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTPaperRela.VersionCount].ToString().Trim()), //版本统计
PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(), //论文类型名
UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim() //备注
};
objvRTPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTPaperRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTPaperRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTPaperRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = TransNullToInt(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = TransNullToBool(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTPaperRelaDA: GetObjByDataRowvRTPaperRela)", objException.Message));
}
objvRTPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTPaperRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTPaperRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = TransNullToInt(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = TransNullToBool(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTPaperRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTPaperRelaEN;
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
objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTPaperRelaEN._CurrTabName, convRTPaperRela.mId, 8, "");
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
objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTPaperRelaEN._CurrTabName, convRTPaperRela.mId, 8, strPrefix);
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTPaperRela where " + strCondition;
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTPaperRela where " + strCondition;
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTPaperRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTPaperRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTPaperRela", strCondition))
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
objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTPaperRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTPaperRelaENS">源对象</param>
 /// <param name = "objvRTPaperRelaENT">目标对象</param>
public void CopyTo(clsvRTPaperRelaEN objvRTPaperRelaENS, clsvRTPaperRelaEN objvRTPaperRelaENT)
{
objvRTPaperRelaENT.mId = objvRTPaperRelaENS.mId; //mId
objvRTPaperRelaENT.TopicId = objvRTPaperRelaENS.TopicId; //主题Id
objvRTPaperRelaENT.PaperId = objvRTPaperRelaENS.PaperId; //论文Id
objvRTPaperRelaENT.TopicName = objvRTPaperRelaENS.TopicName; //栏目主题
objvRTPaperRelaENT.TopicContent = objvRTPaperRelaENS.TopicContent; //主题内容
objvRTPaperRelaENT.TopicProposePeople = objvRTPaperRelaENS.TopicProposePeople; //主题提出人
objvRTPaperRelaENT.PaperTitle = objvRTPaperRelaENS.PaperTitle; //论文标题
objvRTPaperRelaENT.PaperContent = objvRTPaperRelaENS.PaperContent; //主题内容
objvRTPaperRelaENT.Author = objvRTPaperRelaENS.Author; //作者
objvRTPaperRelaENT.Periodical = objvRTPaperRelaENS.Periodical; //期刊
objvRTPaperRelaENT.IsSubmit = objvRTPaperRelaENS.IsSubmit; //是否提交
objvRTPaperRelaENT.IdCurrEduCls = objvRTPaperRelaENS.IdCurrEduCls; //教学班流水号
objvRTPaperRelaENT.PaperDate = objvRTPaperRelaENS.PaperDate; //PaperDate
objvRTPaperRelaENT.PaperStatusId = objvRTPaperRelaENS.PaperStatusId; //论文状态Id
objvRTPaperRelaENT.PaperTypeId = objvRTPaperRelaENS.PaperTypeId; //论文类型Id
objvRTPaperRelaENT.PaperUserId = objvRTPaperRelaENS.PaperUserId; //PaperUserId
objvRTPaperRelaENT.VersionCount = objvRTPaperRelaENS.VersionCount; //版本统计
objvRTPaperRelaENT.PaperTypeName = objvRTPaperRelaENS.PaperTypeName; //论文类型名
objvRTPaperRelaENT.UpdDate = objvRTPaperRelaENS.UpdDate; //修改日期
objvRTPaperRelaENT.UpdUser = objvRTPaperRelaENS.UpdUser; //修改人
objvRTPaperRelaENT.Memo = objvRTPaperRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTPaperRelaEN objvRTPaperRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.TopicId, 8, convRTPaperRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperId, 8, convRTPaperRela.PaperId);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.TopicName, 200, convRTPaperRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.TopicProposePeople, 50, convRTPaperRela.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperTitle, 500, convRTPaperRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.Author, 200, convRTPaperRela.Author);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.Periodical, 100, convRTPaperRela.Periodical);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.IdCurrEduCls, 8, convRTPaperRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperDate, 20, convRTPaperRela.PaperDate);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperStatusId, 2, convRTPaperRela.PaperStatusId);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperTypeId, 2, convRTPaperRela.PaperTypeId);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperUserId, 20, convRTPaperRela.PaperUserId);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.PaperTypeName, 50, convRTPaperRela.PaperTypeName);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.UpdDate, 20, convRTPaperRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.UpdUser, 20, convRTPaperRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTPaperRelaEN.Memo, 1000, convRTPaperRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.TopicId, convRTPaperRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperId, convRTPaperRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.TopicName, convRTPaperRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.TopicProposePeople, convRTPaperRela.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperTitle, convRTPaperRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.Author, convRTPaperRela.Author);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.Periodical, convRTPaperRela.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.IdCurrEduCls, convRTPaperRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperDate, convRTPaperRela.PaperDate);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperStatusId, convRTPaperRela.PaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperTypeId, convRTPaperRela.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperUserId, convRTPaperRela.PaperUserId);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.PaperTypeName, convRTPaperRela.PaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.UpdDate, convRTPaperRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.UpdUser, convRTPaperRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTPaperRelaEN.Memo, convRTPaperRela.Memo);
//检查外键字段长度
 objvRTPaperRelaEN._IsCheckProperty = true;
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTPaperRelaEN._CurrTabName);
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTPaperRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvRTPaperRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}