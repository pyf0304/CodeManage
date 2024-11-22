
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PaperDA
 表名:qa_Paper(01120643)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 论文答疑表(qa_Paper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsqa_PaperDA : clsCommBase4DA
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
 return clsqa_PaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsqa_PaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_PaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsqa_PaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsqa_PaperEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQaPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQaPaperId)
{
strQaPaperId = strQaPaperId.Replace("'", "''");
if (strQaPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:qa_Paper中,检查关键字,长度不正确!(clsqa_PaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQaPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:qa_Paper中,关键字不能为空 或 null!(clsqa_PaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsqa_PaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_qa_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable_qa_Paper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_Paper.* from qa_Paper Left Join {1} on {2} where {3} and qa_Paper.QaPaperId not in (Select top {5} qa_Paper.QaPaperId from qa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1} and QaPaperId not in (Select top {2} QaPaperId from qa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1} and QaPaperId not in (Select top {3} QaPaperId from qa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsqa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_Paper.* from qa_Paper Left Join {1} on {2} where {3} and qa_Paper.QaPaperId not in (Select top {5} qa_Paper.QaPaperId from qa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1} and QaPaperId not in (Select top {2} QaPaperId from qa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Paper where {1} and QaPaperId not in (Select top {3} QaPaperId from qa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsqa_PaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsqa_PaperDA:GetObjLst)", objException.Message));
}
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = TransNullToBool(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = TransNullToBool(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = TransNullToBool(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_PaperDA: GetObjLst)", objException.Message));
}
objqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_PaperEN);
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
public List<clsqa_PaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsqa_PaperDA:GetObjLstByTabName)", objException.Message));
}
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = TransNullToBool(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = TransNullToBool(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = TransNullToBool(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_PaperDA: GetObjLst)", objException.Message));
}
objqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_PaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getqa_Paper(ref clsqa_PaperEN objqa_PaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where QaPaperId = " + "'"+ objqa_PaperEN.QaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objqa_PaperEN.QaPaperId = objDT.Rows[0][conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_PaperEN.PaperId = objDT.Rows[0][conqa_Paper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_PaperEN.QuestionsCount = TransNullToInt(objDT.Rows[0][conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_PaperEN.IsDelete = TransNullToBool(objDT.Rows[0][conqa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objqa_PaperEN.IsPublic = TransNullToBool(objDT.Rows[0][conqa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objqa_PaperEN.IsSubmit = TransNullToBool(objDT.Rows[0][conqa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objqa_PaperEN.UpdUser = objDT.Rows[0][conqa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_PaperEN.UpdDate = objDT.Rows[0][conqa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_PaperEN.Memo = objDT.Rows[0][conqa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objqa_PaperEN.IdCurrEduCls = objDT.Rows[0][conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objqa_PaperEN.AnswerCount = TransNullToInt(objDT.Rows[0][conqa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_PaperEN.ShareId = objDT.Rows[0][conqa_Paper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objqa_PaperEN.TagsCount = TransNullToInt(objDT.Rows[0][conqa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsqa_PaperDA: Getqa_Paper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsqa_PaperEN GetObjByQaPaperId(string strQaPaperId)
{
CheckPrimaryKey(strQaPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where QaPaperId = " + "'"+ strQaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
 objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsqa_PaperDA: GetObjByQaPaperId)", objException.Message));
}
return objqa_PaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsqa_PaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsqa_PaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN()
{
QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(), //论文答疑Id
PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(), //论文Id
QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.QuestionsCount].ToString().Trim()), //提问计数
IsDelete = TransNullToBool(objRow[conqa_Paper.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[conqa_Paper.IsPublic].ToString().Trim()), //是否公开
IsSubmit = TransNullToBool(objRow[conqa_Paper.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(), //教学班流水号
AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.AnswerCount].ToString().Trim()), //回答计数
ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(), //分享Id
TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.TagsCount].ToString().Trim()) //论文标注数
};
objqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_PaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsqa_PaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsqa_PaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = TransNullToBool(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = TransNullToBool(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = TransNullToBool(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsqa_PaperDA: GetObjByDataRowqa_Paper)", objException.Message));
}
objqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_PaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsqa_PaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = TransNullToBool(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = TransNullToBool(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = TransNullToBool(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsqa_PaperDA: GetObjByDataRow)", objException.Message));
}
objqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_PaperEN;
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
objSQL = clsqa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_PaperEN._CurrTabName, conqa_Paper.QaPaperId, 8, "");
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
objSQL = clsqa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_PaperEN._CurrTabName, conqa_Paper.QaPaperId, 8, strPrefix);
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QaPaperId from qa_Paper where " + strCondition;
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QaPaperId from qa_Paper where " + strCondition;
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
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQaPaperId)
{
CheckPrimaryKey(strQaPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_Paper", "QaPaperId = " + "'"+ strQaPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsqa_PaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_Paper", strCondition))
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
objSQL = clsqa_PaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("qa_Paper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsqa_PaperEN objqa_PaperEN)
 {
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_PaperEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_Paper");
objRow = objDS.Tables["qa_Paper"].NewRow();
objRow[conqa_Paper.QaPaperId] = objqa_PaperEN.QaPaperId; //论文答疑Id
 if (objqa_PaperEN.PaperId !=  "")
 {
objRow[conqa_Paper.PaperId] = objqa_PaperEN.PaperId; //论文Id
 }
objRow[conqa_Paper.QuestionsCount] = objqa_PaperEN.QuestionsCount; //提问计数
objRow[conqa_Paper.IsDelete] = objqa_PaperEN.IsDelete; //是否删除
objRow[conqa_Paper.IsPublic] = objqa_PaperEN.IsPublic; //是否公开
objRow[conqa_Paper.IsSubmit] = objqa_PaperEN.IsSubmit; //是否提交
 if (objqa_PaperEN.UpdUser !=  "")
 {
objRow[conqa_Paper.UpdUser] = objqa_PaperEN.UpdUser; //修改人
 }
 if (objqa_PaperEN.UpdDate !=  "")
 {
objRow[conqa_Paper.UpdDate] = objqa_PaperEN.UpdDate; //修改日期
 }
 if (objqa_PaperEN.Memo !=  "")
 {
objRow[conqa_Paper.Memo] = objqa_PaperEN.Memo; //备注
 }
 if (objqa_PaperEN.IdCurrEduCls !=  "")
 {
objRow[conqa_Paper.IdCurrEduCls] = objqa_PaperEN.IdCurrEduCls; //教学班流水号
 }
objRow[conqa_Paper.AnswerCount] = objqa_PaperEN.AnswerCount; //回答计数
 if (objqa_PaperEN.ShareId !=  "")
 {
objRow[conqa_Paper.ShareId] = objqa_PaperEN.ShareId; //分享Id
 }
objRow[conqa_Paper.TagsCount] = objqa_PaperEN.TagsCount; //论文标注数
objDS.Tables[clsqa_PaperEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsqa_PaperEN._CurrTabName);
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_PaperEN objqa_PaperEN)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_PaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_PaperEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QaPaperId);
 var strQaPaperId = objqa_PaperEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_PaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.PaperId);
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objqa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdUser);
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdDate);
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.Memo);
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.AnswerCount);
 arrValueListForInsert.Add(objqa_PaperEN.AnswerCount.ToString());
 }
 
 if (objqa_PaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.ShareId);
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objqa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.TagsCount);
 arrValueListForInsert.Add(objqa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_PaperEN objqa_PaperEN)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_PaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_PaperEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QaPaperId);
 var strQaPaperId = objqa_PaperEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_PaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.PaperId);
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objqa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdUser);
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdDate);
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.Memo);
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.AnswerCount);
 arrValueListForInsert.Add(objqa_PaperEN.AnswerCount.ToString());
 }
 
 if (objqa_PaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.ShareId);
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objqa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.TagsCount);
 arrValueListForInsert.Add(objqa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objqa_PaperEN.QaPaperId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_PaperEN objqa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_PaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_PaperEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QaPaperId);
 var strQaPaperId = objqa_PaperEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_PaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.PaperId);
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objqa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdUser);
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdDate);
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.Memo);
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.AnswerCount);
 arrValueListForInsert.Add(objqa_PaperEN.AnswerCount.ToString());
 }
 
 if (objqa_PaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.ShareId);
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objqa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.TagsCount);
 arrValueListForInsert.Add(objqa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objqa_PaperEN.QaPaperId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_PaperEN objqa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_PaperEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_PaperEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QaPaperId);
 var strQaPaperId = objqa_PaperEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_PaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.PaperId);
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objqa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdUser);
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.UpdDate);
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.Memo);
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.AnswerCount);
 arrValueListForInsert.Add(objqa_PaperEN.AnswerCount.ToString());
 }
 
 if (objqa_PaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.ShareId);
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objqa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Paper.TagsCount);
 arrValueListForInsert.Add(objqa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewqa_Papers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where QaPaperId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_Paper");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strQaPaperId = oRow[conqa_Paper.QaPaperId].ToString().Trim();
if (IsExist(strQaPaperId))
{
 string strResult = "关键字变量值为:" + string.Format("QaPaperId = {0}", strQaPaperId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsqa_PaperEN._CurrTabName ].NewRow();
objRow[conqa_Paper.QaPaperId] = oRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objRow[conqa_Paper.PaperId] = oRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objRow[conqa_Paper.QuestionsCount] = oRow[conqa_Paper.QuestionsCount].ToString().Trim(); //提问计数
objRow[conqa_Paper.IsDelete] = oRow[conqa_Paper.IsDelete].ToString().Trim(); //是否删除
objRow[conqa_Paper.IsPublic] = oRow[conqa_Paper.IsPublic].ToString().Trim(); //是否公开
objRow[conqa_Paper.IsSubmit] = oRow[conqa_Paper.IsSubmit].ToString().Trim(); //是否提交
objRow[conqa_Paper.UpdUser] = oRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objRow[conqa_Paper.UpdDate] = oRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objRow[conqa_Paper.Memo] = oRow[conqa_Paper.Memo].ToString().Trim(); //备注
objRow[conqa_Paper.IdCurrEduCls] = oRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conqa_Paper.AnswerCount] = oRow[conqa_Paper.AnswerCount].ToString().Trim(); //回答计数
objRow[conqa_Paper.ShareId] = oRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objRow[conqa_Paper.TagsCount] = oRow[conqa_Paper.TagsCount].ToString().Trim(); //论文标注数
 objDS.Tables[clsqa_PaperEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsqa_PaperEN._CurrTabName);
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
 /// <param name = "objqa_PaperEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsqa_PaperEN objqa_PaperEN)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_PaperEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from qa_Paper where QaPaperId = " + "'"+ objqa_PaperEN.QaPaperId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsqa_PaperEN._CurrTabName);
if (objDS.Tables[clsqa_PaperEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QaPaperId = " + "'"+ objqa_PaperEN.QaPaperId+"'");
return false;
}
objRow = objDS.Tables[clsqa_PaperEN._CurrTabName].Rows[0];
 if (objqa_PaperEN.IsUpdated(conqa_Paper.QaPaperId))
 {
objRow[conqa_Paper.QaPaperId] = objqa_PaperEN.QaPaperId; //论文答疑Id
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.PaperId))
 {
objRow[conqa_Paper.PaperId] = objqa_PaperEN.PaperId; //论文Id
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.QuestionsCount))
 {
objRow[conqa_Paper.QuestionsCount] = objqa_PaperEN.QuestionsCount; //提问计数
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsDelete))
 {
objRow[conqa_Paper.IsDelete] = objqa_PaperEN.IsDelete; //是否删除
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsPublic))
 {
objRow[conqa_Paper.IsPublic] = objqa_PaperEN.IsPublic; //是否公开
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsSubmit))
 {
objRow[conqa_Paper.IsSubmit] = objqa_PaperEN.IsSubmit; //是否提交
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdUser))
 {
objRow[conqa_Paper.UpdUser] = objqa_PaperEN.UpdUser; //修改人
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdDate))
 {
objRow[conqa_Paper.UpdDate] = objqa_PaperEN.UpdDate; //修改日期
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.Memo))
 {
objRow[conqa_Paper.Memo] = objqa_PaperEN.Memo; //备注
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IdCurrEduCls))
 {
objRow[conqa_Paper.IdCurrEduCls] = objqa_PaperEN.IdCurrEduCls; //教学班流水号
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.AnswerCount))
 {
objRow[conqa_Paper.AnswerCount] = objqa_PaperEN.AnswerCount; //回答计数
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.ShareId))
 {
objRow[conqa_Paper.ShareId] = objqa_PaperEN.ShareId; //分享Id
 }
 if (objqa_PaperEN.IsUpdated(conqa_Paper.TagsCount))
 {
objRow[conqa_Paper.TagsCount] = objqa_PaperEN.TagsCount; //论文标注数
 }
try
{
objDA.Update(objDS, clsqa_PaperEN._CurrTabName);
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_PaperEN objqa_PaperEN)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update qa_Paper Set ");
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.PaperId))
 {
 if (objqa_PaperEN.PaperId !=  null)
 {
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conqa_Paper.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.PaperId); //论文Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.QuestionsCount))
 {
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.QuestionsCount, conqa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_PaperEN.IsDelete == true?"1":"0", conqa_Paper.IsDelete); //是否删除
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_PaperEN.IsPublic == true?"1":"0", conqa_Paper.IsPublic); //是否公开
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_PaperEN.IsSubmit == true?"1":"0", conqa_Paper.IsSubmit); //是否提交
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdUser))
 {
 if (objqa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_Paper.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.UpdUser); //修改人
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdDate))
 {
 if (objqa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_Paper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.UpdDate); //修改日期
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.Memo))
 {
 if (objqa_PaperEN.Memo !=  null)
 {
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_Paper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.Memo); //备注
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IdCurrEduCls))
 {
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conqa_Paper.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.AnswerCount))
 {
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.AnswerCount, conqa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.ShareId))
 {
 if (objqa_PaperEN.ShareId !=  null)
 {
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conqa_Paper.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.ShareId); //分享Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.TagsCount))
 {
 if (objqa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.TagsCount, conqa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.TagsCount); //论文标注数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QaPaperId = '{0}'", objqa_PaperEN.QaPaperId); 
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
 /// <param name = "objqa_PaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsqa_PaperEN objqa_PaperEN, string strCondition)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Paper Set ");
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.PaperId))
 {
 if (objqa_PaperEN.PaperId !=  null)
 {
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.QuestionsCount))
 {
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.QuestionsCount, conqa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objqa_PaperEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objqa_PaperEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objqa_PaperEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdUser))
 {
 if (objqa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdDate))
 {
 if (objqa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.Memo))
 {
 if (objqa_PaperEN.Memo !=  null)
 {
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IdCurrEduCls))
 {
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.AnswerCount))
 {
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.AnswerCount, conqa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.ShareId))
 {
 if (objqa_PaperEN.ShareId !=  null)
 {
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.TagsCount))
 {
 if (objqa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.TagsCount, conqa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.TagsCount); //论文标注数
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
 /// <param name = "objqa_PaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsqa_PaperEN objqa_PaperEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Paper Set ");
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.PaperId))
 {
 if (objqa_PaperEN.PaperId !=  null)
 {
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.QuestionsCount))
 {
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.QuestionsCount, conqa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objqa_PaperEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objqa_PaperEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objqa_PaperEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdUser))
 {
 if (objqa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdDate))
 {
 if (objqa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.Memo))
 {
 if (objqa_PaperEN.Memo !=  null)
 {
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IdCurrEduCls))
 {
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.AnswerCount))
 {
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.AnswerCount, conqa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.ShareId))
 {
 if (objqa_PaperEN.ShareId !=  null)
 {
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.TagsCount))
 {
 if (objqa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.TagsCount, conqa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.TagsCount); //论文标注数
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_PaperEN objqa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Paper Set ");
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.PaperId))
 {
 if (objqa_PaperEN.PaperId !=  null)
 {
 var strPaperId = objqa_PaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conqa_Paper.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.PaperId); //论文Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.QuestionsCount))
 {
 if (objqa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.QuestionsCount, conqa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_PaperEN.IsDelete == true?"1":"0", conqa_Paper.IsDelete); //是否删除
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_PaperEN.IsPublic == true?"1":"0", conqa_Paper.IsPublic); //是否公开
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_PaperEN.IsSubmit == true?"1":"0", conqa_Paper.IsSubmit); //是否提交
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdUser))
 {
 if (objqa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_Paper.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.UpdUser); //修改人
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.UpdDate))
 {
 if (objqa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_Paper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.UpdDate); //修改日期
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.Memo))
 {
 if (objqa_PaperEN.Memo !=  null)
 {
 var strMemo = objqa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_Paper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.Memo); //备注
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.IdCurrEduCls))
 {
 if (objqa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conqa_Paper.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.AnswerCount))
 {
 if (objqa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.AnswerCount, conqa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.ShareId))
 {
 if (objqa_PaperEN.ShareId !=  null)
 {
 var strShareId = objqa_PaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conqa_Paper.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.ShareId); //分享Id
 }
 }
 
 if (objqa_PaperEN.IsUpdated(conqa_Paper.TagsCount))
 {
 if (objqa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_PaperEN.TagsCount, conqa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Paper.TagsCount); //论文标注数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QaPaperId = '{0}'", objqa_PaperEN.QaPaperId); 
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
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strQaPaperId) 
{
CheckPrimaryKey(strQaPaperId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strQaPaperId,
};
 objSQL.ExecSP("qa_Paper_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strQaPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strQaPaperId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
//删除qa_Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Paper where QaPaperId = " + "'"+ strQaPaperId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delqa_Paper(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
//删除qa_Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Paper where QaPaperId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strQaPaperId) 
{
CheckPrimaryKey(strQaPaperId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
//删除qa_Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Paper where QaPaperId = " + "'"+ strQaPaperId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delqa_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsqa_PaperDA: Delqa_Paper)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_Paper where " + strCondition ;
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
public bool Delqa_PaperWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsqa_PaperDA: Delqa_PaperWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_Paper where " + strCondition ;
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
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <param name = "objqa_PaperENT">目标对象</param>
public void CopyTo(clsqa_PaperEN objqa_PaperENS, clsqa_PaperEN objqa_PaperENT)
{
objqa_PaperENT.QaPaperId = objqa_PaperENS.QaPaperId; //论文答疑Id
objqa_PaperENT.PaperId = objqa_PaperENS.PaperId; //论文Id
objqa_PaperENT.QuestionsCount = objqa_PaperENS.QuestionsCount; //提问计数
objqa_PaperENT.IsDelete = objqa_PaperENS.IsDelete; //是否删除
objqa_PaperENT.IsPublic = objqa_PaperENS.IsPublic; //是否公开
objqa_PaperENT.IsSubmit = objqa_PaperENS.IsSubmit; //是否提交
objqa_PaperENT.UpdUser = objqa_PaperENS.UpdUser; //修改人
objqa_PaperENT.UpdDate = objqa_PaperENS.UpdDate; //修改日期
objqa_PaperENT.Memo = objqa_PaperENS.Memo; //备注
objqa_PaperENT.IdCurrEduCls = objqa_PaperENS.IdCurrEduCls; //教学班流水号
objqa_PaperENT.AnswerCount = objqa_PaperENS.AnswerCount; //回答计数
objqa_PaperENT.ShareId = objqa_PaperENS.ShareId; //分享Id
objqa_PaperENT.TagsCount = objqa_PaperENS.TagsCount; //论文标注数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsqa_PaperEN objqa_PaperEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_PaperEN.QaPaperId, 8, conqa_Paper.QaPaperId);
clsCheckSql.CheckFieldLen(objqa_PaperEN.PaperId, 8, conqa_Paper.PaperId);
clsCheckSql.CheckFieldLen(objqa_PaperEN.UpdUser, 20, conqa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objqa_PaperEN.UpdDate, 20, conqa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objqa_PaperEN.Memo, 1000, conqa_Paper.Memo);
clsCheckSql.CheckFieldLen(objqa_PaperEN.IdCurrEduCls, 8, conqa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objqa_PaperEN.ShareId, 2, conqa_Paper.ShareId);
//检查字段外键固定长度
 objqa_PaperEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsqa_PaperEN objqa_PaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_PaperEN.PaperId, 8, conqa_Paper.PaperId);
clsCheckSql.CheckFieldLen(objqa_PaperEN.UpdUser, 20, conqa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objqa_PaperEN.UpdDate, 20, conqa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objqa_PaperEN.Memo, 1000, conqa_Paper.Memo);
clsCheckSql.CheckFieldLen(objqa_PaperEN.IdCurrEduCls, 8, conqa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objqa_PaperEN.ShareId, 2, conqa_Paper.ShareId);
//检查外键字段长度
 objqa_PaperEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsqa_PaperEN objqa_PaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_PaperEN.QaPaperId, 8, conqa_Paper.QaPaperId);
clsCheckSql.CheckFieldLen(objqa_PaperEN.PaperId, 8, conqa_Paper.PaperId);
clsCheckSql.CheckFieldLen(objqa_PaperEN.UpdUser, 20, conqa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objqa_PaperEN.UpdDate, 20, conqa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objqa_PaperEN.Memo, 1000, conqa_Paper.Memo);
clsCheckSql.CheckFieldLen(objqa_PaperEN.IdCurrEduCls, 8, conqa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objqa_PaperEN.ShareId, 2, conqa_Paper.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.QaPaperId, conqa_Paper.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.PaperId, conqa_Paper.PaperId);
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.UpdUser, conqa_Paper.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.UpdDate, conqa_Paper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.Memo, conqa_Paper.Memo);
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.IdCurrEduCls, conqa_Paper.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objqa_PaperEN.ShareId, conqa_Paper.ShareId);
//检查外键字段长度
 objqa_PaperEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--qa_Paper(论文答疑表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_PaperEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsqa_PaperEN objqa_PaperEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QaPaperId = '{0}'", objqa_PaperEN.QaPaperId);
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_PaperEN._CurrTabName);
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_PaperEN._CurrTabName, strCondition);
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsqa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}