
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_RTqa_PaperRelaDA
 表名:vgs_RTqa_PaperRela(01120695)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 主题答疑关系视图(vgs_RTqa_PaperRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_RTqa_PaperRelaDA : clsCommBase4DA
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
 return clsvgs_RTqa_PaperRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_RTqa_PaperRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_RTqa_PaperRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_RTqa_PaperRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable_vgs_RTqa_PaperRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_RTqa_PaperRela.* from vgs_RTqa_PaperRela Left Join {1} on {2} where {3} and vgs_RTqa_PaperRela.mId not in (Select top {5} vgs_RTqa_PaperRela.mId from vgs_RTqa_PaperRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1} and mId not in (Select top {2} mId from vgs_RTqa_PaperRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1} and mId not in (Select top {3} mId from vgs_RTqa_PaperRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_RTqa_PaperRela.* from vgs_RTqa_PaperRela Left Join {1} on {2} where {3} and vgs_RTqa_PaperRela.mId not in (Select top {5} vgs_RTqa_PaperRela.mId from vgs_RTqa_PaperRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1} and mId not in (Select top {2} mId from vgs_RTqa_PaperRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_RTqa_PaperRela where {1} and mId not in (Select top {3} mId from vgs_RTqa_PaperRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_RTqa_PaperRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA:GetObjLst)", objException.Message));
}
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = TransNullToInt(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetObjLst)", objException.Message));
}
objvgs_RTqa_PaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
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
public List<clsvgs_RTqa_PaperRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = TransNullToInt(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetObjLst)", objException.Message));
}
objvgs_RTqa_PaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_RTqa_PaperRela(ref clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where mId = " + ""+ objvgs_RTqa_PaperRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_RTqa_PaperRelaEN.mId = TransNullToInt(objDT.Rows[0][convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_RTqa_PaperRelaEN.TopicId = objDT.Rows[0][convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_RTqa_PaperRelaEN.TopicName = objDT.Rows[0][convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objDT.Rows[0][convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_RTqa_PaperRelaEN.QaPaperId = objDT.Rows[0][convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_RTqa_PaperRelaEN.PaperId = objDT.Rows[0][convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_RTqa_PaperRelaEN.QuestionsCount = TransNullToInt(objDT.Rows[0][convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.IsPublic = TransNullToBool(objDT.Rows[0][convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_RTqa_PaperRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_RTqa_PaperRelaEN.PaperTitle = objDT.Rows[0][convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_RTqa_PaperRelaEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.AnswerCount = TransNullToInt(objDT.Rows[0][convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.ShareId = objDT.Rows[0][convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_RTqa_PaperRelaEN.TagsCount = TransNullToInt(objDT.Rows[0][convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.UpdDate = objDT.Rows[0][convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.UpdUser = objDT.Rows[0][convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.Memo = objDT.Rows[0][convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_RTqa_PaperRelaEN.qaUser = objDT.Rows[0][convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.qaDate = objDT.Rows[0][convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.qaUserName = objDT.Rows[0][convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: Getvgs_RTqa_PaperRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_RTqa_PaperRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
 objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetObjBymId)", objException.Message));
}
return objvgs_RTqa_PaperRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_RTqa_PaperRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_RTqa_PaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN()
{
mId = TransNullToInt(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()), //mId
TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(), //栏目主题
IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(), //论文答疑Id
PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(), //论文Id
QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()), //提问计数
IsPublic = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()), //是否公开
IsSubmit = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()), //是否提交
PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(), //论文标题
AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()), //附件计数
AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()), //回答计数
ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(), //分享Id
TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()), //论文标注数
UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(), //备注
qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(), //qaUser
qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(), //qaDate
qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim() //qaUserName
};
objvgs_RTqa_PaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_RTqa_PaperRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_RTqa_PaperRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = TransNullToInt(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetObjByDataRowvgs_RTqa_PaperRela)", objException.Message));
}
objvgs_RTqa_PaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_RTqa_PaperRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_RTqa_PaperRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = TransNullToInt(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = TransNullToBool(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_RTqa_PaperRelaDA: GetObjByDataRow)", objException.Message));
}
objvgs_RTqa_PaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_RTqa_PaperRelaEN;
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
objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_RTqa_PaperRelaEN._CurrTabName, convgs_RTqa_PaperRela.mId, 8, "");
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
objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_RTqa_PaperRelaEN._CurrTabName, convgs_RTqa_PaperRela.mId, 8, strPrefix);
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_RTqa_PaperRela where " + strCondition;
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_RTqa_PaperRela where " + strCondition;
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_RTqa_PaperRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_RTqa_PaperRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_RTqa_PaperRela", strCondition))
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
objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_RTqa_PaperRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaENS">源对象</param>
 /// <param name = "objvgs_RTqa_PaperRelaENT">目标对象</param>
public void CopyTo(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENS, clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENT)
{
objvgs_RTqa_PaperRelaENT.mId = objvgs_RTqa_PaperRelaENS.mId; //mId
objvgs_RTqa_PaperRelaENT.TopicId = objvgs_RTqa_PaperRelaENS.TopicId; //主题Id
objvgs_RTqa_PaperRelaENT.TopicName = objvgs_RTqa_PaperRelaENS.TopicName; //栏目主题
objvgs_RTqa_PaperRelaENT.IdCurrEduCls = objvgs_RTqa_PaperRelaENS.IdCurrEduCls; //教学班流水号
objvgs_RTqa_PaperRelaENT.QaPaperId = objvgs_RTqa_PaperRelaENS.QaPaperId; //论文答疑Id
objvgs_RTqa_PaperRelaENT.PaperId = objvgs_RTqa_PaperRelaENS.PaperId; //论文Id
objvgs_RTqa_PaperRelaENT.QuestionsCount = objvgs_RTqa_PaperRelaENS.QuestionsCount; //提问计数
objvgs_RTqa_PaperRelaENT.IsPublic = objvgs_RTqa_PaperRelaENS.IsPublic; //是否公开
objvgs_RTqa_PaperRelaENT.IsSubmit = objvgs_RTqa_PaperRelaENS.IsSubmit; //是否提交
objvgs_RTqa_PaperRelaENT.PaperTitle = objvgs_RTqa_PaperRelaENS.PaperTitle; //论文标题
objvgs_RTqa_PaperRelaENT.AttachmentCount = objvgs_RTqa_PaperRelaENS.AttachmentCount; //附件计数
objvgs_RTqa_PaperRelaENT.AnswerCount = objvgs_RTqa_PaperRelaENS.AnswerCount; //回答计数
objvgs_RTqa_PaperRelaENT.ShareId = objvgs_RTqa_PaperRelaENS.ShareId; //分享Id
objvgs_RTqa_PaperRelaENT.TagsCount = objvgs_RTqa_PaperRelaENS.TagsCount; //论文标注数
objvgs_RTqa_PaperRelaENT.UpdDate = objvgs_RTqa_PaperRelaENS.UpdDate; //修改日期
objvgs_RTqa_PaperRelaENT.UpdUser = objvgs_RTqa_PaperRelaENS.UpdUser; //修改人
objvgs_RTqa_PaperRelaENT.Memo = objvgs_RTqa_PaperRelaENS.Memo; //备注
objvgs_RTqa_PaperRelaENT.qaUser = objvgs_RTqa_PaperRelaENS.qaUser; //qaUser
objvgs_RTqa_PaperRelaENT.qaDate = objvgs_RTqa_PaperRelaENS.qaDate; //qaDate
objvgs_RTqa_PaperRelaENT.qaUserName = objvgs_RTqa_PaperRelaENS.qaUserName; //qaUserName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.TopicId, 8, convgs_RTqa_PaperRela.TopicId);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.TopicName, 200, convgs_RTqa_PaperRela.TopicName);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.IdCurrEduCls, 8, convgs_RTqa_PaperRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.QaPaperId, 8, convgs_RTqa_PaperRela.QaPaperId);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.PaperId, 8, convgs_RTqa_PaperRela.PaperId);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.PaperTitle, 500, convgs_RTqa_PaperRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.ShareId, 2, convgs_RTqa_PaperRela.ShareId);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.UpdDate, 20, convgs_RTqa_PaperRela.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.UpdUser, 20, convgs_RTqa_PaperRela.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.Memo, 1000, convgs_RTqa_PaperRela.Memo);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.qaUser, 20, convgs_RTqa_PaperRela.qaUser);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.qaDate, 20, convgs_RTqa_PaperRela.qaDate);
clsCheckSql.CheckFieldLen(objvgs_RTqa_PaperRelaEN.qaUserName, 30, convgs_RTqa_PaperRela.qaUserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.TopicId, convgs_RTqa_PaperRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.TopicName, convgs_RTqa_PaperRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.IdCurrEduCls, convgs_RTqa_PaperRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.QaPaperId, convgs_RTqa_PaperRela.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.PaperId, convgs_RTqa_PaperRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.PaperTitle, convgs_RTqa_PaperRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.ShareId, convgs_RTqa_PaperRela.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.UpdDate, convgs_RTqa_PaperRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.UpdUser, convgs_RTqa_PaperRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.Memo, convgs_RTqa_PaperRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.qaUser, convgs_RTqa_PaperRela.qaUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.qaDate, convgs_RTqa_PaperRela.qaDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_RTqa_PaperRelaEN.qaUserName, convgs_RTqa_PaperRela.qaUserName);
//检查外键字段长度
 objvgs_RTqa_PaperRelaEN._IsCheckProperty = true;
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_RTqa_PaperRelaEN._CurrTabName);
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_RTqa_PaperRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_RTqa_PaperRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}