
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupQuestionRelaDA
 表名:vzx_GroupQuestionRela(01120736)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 小组问题关系视图(vzx_GroupQuestionRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_GroupQuestionRelaDA : clsCommBase4DA
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
 return clsvzx_GroupQuestionRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_GroupQuestionRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_GroupQuestionRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_GroupQuestionRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_GroupQuestionRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_GroupQuestionRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable_vzx_GroupQuestionRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_GroupQuestionRela.* from vzx_GroupQuestionRela Left Join {1} on {2} where {3} and vzx_GroupQuestionRela.mId not in (Select top {5} vzx_GroupQuestionRela.mId from vzx_GroupQuestionRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1} and mId not in (Select top {2} mId from vzx_GroupQuestionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1} and mId not in (Select top {3} mId from vzx_GroupQuestionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_GroupQuestionRela.* from vzx_GroupQuestionRela Left Join {1} on {2} where {3} and vzx_GroupQuestionRela.mId not in (Select top {5} vzx_GroupQuestionRela.mId from vzx_GroupQuestionRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1} and mId not in (Select top {2} mId from vzx_GroupQuestionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupQuestionRela where {1} and mId not in (Select top {3} mId from vzx_GroupQuestionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_GroupQuestionRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA:GetObjLst)", objException.Message));
}
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = TransNullToInt(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = TransNullToBool(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = TransNullToBool(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = TransNullToBool(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: GetObjLst)", objException.Message));
}
objvzx_GroupQuestionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
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
public List<clsvzx_GroupQuestionRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = TransNullToInt(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = TransNullToBool(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = TransNullToBool(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = TransNullToBool(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: GetObjLst)", objException.Message));
}
objvzx_GroupQuestionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_GroupQuestionRela(ref clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where mId = " + ""+ objvzx_GroupQuestionRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_GroupQuestionRelaEN.GroupTextName = objDT.Rows[0][convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_GroupQuestionRelaEN.mId = TransNullToInt(objDT.Rows[0][convzx_GroupQuestionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_GroupQuestionRelaEN.GroupTextId = objDT.Rows[0][convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupQuestionRelaEN.zxQuestionsId = objDT.Rows[0][convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupQuestionRelaEN.UpdDate = objDT.Rows[0][convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupQuestionRelaEN.UpdUser = objDT.Rows[0][convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupQuestionRelaEN.Memo = objDT.Rows[0][convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_GroupQuestionRelaEN.QuestionsContent = objDT.Rows[0][convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfContent = objDT.Rows[0][convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_GroupQuestionRelaEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupQuestionRelaEN.IsEnd = TransNullToBool(objDT.Rows[0][convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupQuestionRelaEN.IsDelete = TransNullToBool(objDT.Rows[0][convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupQuestionRelaEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.AnswerCount = TransNullToInt(objDT.Rows[0][convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfPageNumIn = objDT.Rows[0][convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfDivTop = objDT.Rows[0][convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfDivLet = objDT.Rows[0][convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfZoom = objDT.Rows[0][convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.QuestionType = objDT.Rows[0][convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02(字段类型:char,字段长度:2,是否可空:True)
 objvzx_GroupQuestionRelaEN.TextId = objDT.Rows[0][convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: Getvzx_GroupQuestionRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_GroupQuestionRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
 objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02(字段类型:char,字段长度:2,是否可空:True)
 objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: GetObjBymId)", objException.Message));
}
return objvzx_GroupQuestionRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_GroupQuestionRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupQuestionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN()
{
GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(), //小组名称
mId = TransNullToInt(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()), //mId
GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(), //小组Id
zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(), //提问Id
UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(), //备注
QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(), //提问内容
PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()), //Pdf页码
PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(), //Pdf内容
IsPublic = TransNullToBool(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()), //是否公开
IsEnd = TransNullToBool(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()), //是否结束
IsDelete = TransNullToBool(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()), //是否删除
VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()), //点赞计数
AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()), //回答计数
OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()), //序号
PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(), //PdfZoom
QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(), //个人01小组02
TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim() //课件Id
};
objvzx_GroupQuestionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_GroupQuestionRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_GroupQuestionRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = TransNullToInt(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = TransNullToBool(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = TransNullToBool(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = TransNullToBool(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: GetObjByDataRowvzx_GroupQuestionRela)", objException.Message));
}
objvzx_GroupQuestionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_GroupQuestionRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_GroupQuestionRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = TransNullToInt(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = TransNullToBool(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = TransNullToBool(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = TransNullToBool(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_GroupQuestionRelaDA: GetObjByDataRow)", objException.Message));
}
objvzx_GroupQuestionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_GroupQuestionRelaEN;
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
objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_GroupQuestionRelaEN._CurrTabName, convzx_GroupQuestionRela.mId, 8, "");
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
objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_GroupQuestionRelaEN._CurrTabName, convzx_GroupQuestionRela.mId, 8, strPrefix);
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vzx_GroupQuestionRela where " + strCondition;
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vzx_GroupQuestionRela where " + strCondition;
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_GroupQuestionRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_GroupQuestionRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_GroupQuestionRela", strCondition))
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
objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_GroupQuestionRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaENS">源对象</param>
 /// <param name = "objvzx_GroupQuestionRelaENT">目标对象</param>
public void CopyTo(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENS, clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENT)
{
objvzx_GroupQuestionRelaENT.GroupTextName = objvzx_GroupQuestionRelaENS.GroupTextName; //小组名称
objvzx_GroupQuestionRelaENT.mId = objvzx_GroupQuestionRelaENS.mId; //mId
objvzx_GroupQuestionRelaENT.GroupTextId = objvzx_GroupQuestionRelaENS.GroupTextId; //小组Id
objvzx_GroupQuestionRelaENT.zxQuestionsId = objvzx_GroupQuestionRelaENS.zxQuestionsId; //提问Id
objvzx_GroupQuestionRelaENT.UpdDate = objvzx_GroupQuestionRelaENS.UpdDate; //修改日期
objvzx_GroupQuestionRelaENT.UpdUser = objvzx_GroupQuestionRelaENS.UpdUser; //修改人
objvzx_GroupQuestionRelaENT.Memo = objvzx_GroupQuestionRelaENS.Memo; //备注
objvzx_GroupQuestionRelaENT.QuestionsContent = objvzx_GroupQuestionRelaENS.QuestionsContent; //提问内容
objvzx_GroupQuestionRelaENT.PdfPageNum = objvzx_GroupQuestionRelaENS.PdfPageNum; //Pdf页码
objvzx_GroupQuestionRelaENT.PdfContent = objvzx_GroupQuestionRelaENS.PdfContent; //Pdf内容
objvzx_GroupQuestionRelaENT.IsPublic = objvzx_GroupQuestionRelaENS.IsPublic; //是否公开
objvzx_GroupQuestionRelaENT.IsEnd = objvzx_GroupQuestionRelaENS.IsEnd; //是否结束
objvzx_GroupQuestionRelaENT.IsDelete = objvzx_GroupQuestionRelaENS.IsDelete; //是否删除
objvzx_GroupQuestionRelaENT.VoteCount = objvzx_GroupQuestionRelaENS.VoteCount; //点赞计数
objvzx_GroupQuestionRelaENT.AnswerCount = objvzx_GroupQuestionRelaENS.AnswerCount; //回答计数
objvzx_GroupQuestionRelaENT.OrderNum = objvzx_GroupQuestionRelaENS.OrderNum; //序号
objvzx_GroupQuestionRelaENT.PdfPageTop = objvzx_GroupQuestionRelaENS.PdfPageTop; //pdf页面顶部位置
objvzx_GroupQuestionRelaENT.PdfPageNumIn = objvzx_GroupQuestionRelaENS.PdfPageNumIn; //PdfPageNumIn
objvzx_GroupQuestionRelaENT.PdfDivTop = objvzx_GroupQuestionRelaENS.PdfDivTop; //PdfDivTop
objvzx_GroupQuestionRelaENT.PdfDivLet = objvzx_GroupQuestionRelaENS.PdfDivLet; //PdfDivLet
objvzx_GroupQuestionRelaENT.PdfZoom = objvzx_GroupQuestionRelaENS.PdfZoom; //PdfZoom
objvzx_GroupQuestionRelaENT.QuestionType = objvzx_GroupQuestionRelaENS.QuestionType; //个人01小组02
objvzx_GroupQuestionRelaENT.TextId = objvzx_GroupQuestionRelaENS.TextId; //课件Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.GroupTextName, 2000, convzx_GroupQuestionRela.GroupTextName);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.GroupTextId, 8, convzx_GroupQuestionRela.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.zxQuestionsId, 8, convzx_GroupQuestionRela.zxQuestionsId);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.UpdDate, 20, convzx_GroupQuestionRela.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.UpdUser, 20, convzx_GroupQuestionRela.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.Memo, 1000, convzx_GroupQuestionRela.Memo);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.QuestionsContent, 1000, convzx_GroupQuestionRela.QuestionsContent);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.PdfContent, 2000, convzx_GroupQuestionRela.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.PdfPageNumIn, 50, convzx_GroupQuestionRela.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.PdfDivTop, 50, convzx_GroupQuestionRela.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.PdfDivLet, 50, convzx_GroupQuestionRela.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.PdfZoom, 50, convzx_GroupQuestionRela.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.QuestionType, 2, convzx_GroupQuestionRela.QuestionType);
clsCheckSql.CheckFieldLen(objvzx_GroupQuestionRelaEN.TextId, 8, convzx_GroupQuestionRela.TextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.GroupTextName, convzx_GroupQuestionRela.GroupTextName);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.GroupTextId, convzx_GroupQuestionRela.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.zxQuestionsId, convzx_GroupQuestionRela.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.UpdDate, convzx_GroupQuestionRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.UpdUser, convzx_GroupQuestionRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.Memo, convzx_GroupQuestionRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.QuestionsContent, convzx_GroupQuestionRela.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.PdfContent, convzx_GroupQuestionRela.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.PdfPageNumIn, convzx_GroupQuestionRela.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.PdfDivTop, convzx_GroupQuestionRela.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.PdfDivLet, convzx_GroupQuestionRela.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.PdfZoom, convzx_GroupQuestionRela.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.QuestionType, convzx_GroupQuestionRela.QuestionType);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupQuestionRelaEN.TextId, convzx_GroupQuestionRela.TextId);
//检查外键字段长度
 objvzx_GroupQuestionRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vzx_GroupQuestionRela(小组问题关系视图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objvzx_GroupQuestionRelaEN.GroupTextId);
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_GroupQuestionRelaEN._CurrTabName);
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_GroupQuestionRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_GroupQuestionRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}