
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_qa_PushDA
 表名:vzx_qa_Push(01120850)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// vzx_qa_Push(vzx_qa_Push)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_qa_PushDA : clsCommBase4DA
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
 return clsvzx_qa_PushEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_qa_PushEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_qa_PushEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_qa_PushEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_qa_PushEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_qa_Push(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable_vzx_qa_Push)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_qa_Push.* from vzx_qa_Push Left Join {1} on {2} where {3} and vzx_qa_Push.PushId not in (Select top {5} vzx_qa_Push.PushId from vzx_qa_Push Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1} and PushId not in (Select top {2} PushId from vzx_qa_Push where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1} and PushId not in (Select top {3} PushId from vzx_qa_Push where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_qa_Push.* from vzx_qa_Push Left Join {1} on {2} where {3} and vzx_qa_Push.PushId not in (Select top {5} vzx_qa_Push.PushId from vzx_qa_Push Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1} and PushId not in (Select top {2} PushId from vzx_qa_Push where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Push where {1} and PushId not in (Select top {3} PushId from vzx_qa_Push where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_qa_PushEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA:GetObjLst)", objException.Message));
}
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = TransNullToInt(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = TransNullToBool(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = TransNullToBool(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = TransNullToBool(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = TransNullToBool(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = TransNullToBool(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_qa_PushDA: GetObjLst)", objException.Message));
}
objvzx_qa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_qa_PushEN);
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
public List<clsvzx_qa_PushEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = TransNullToInt(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = TransNullToBool(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = TransNullToBool(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = TransNullToBool(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = TransNullToBool(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = TransNullToBool(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_qa_PushDA: GetObjLst)", objException.Message));
}
objvzx_qa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_qa_PushEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_qa_Push(ref clsvzx_qa_PushEN objvzx_qa_PushEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where PushId = " + ""+ objvzx_qa_PushEN.PushId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_qa_PushEN.PushId = TransNullToInt(objDT.Rows[0][convzx_qa_Push.PushId].ToString().Trim()); //推送d(字段类型:bigint,字段长度:8,是否可空:False)
 objvzx_qa_PushEN.zxQuestionsId = objDT.Rows[0][convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PushEN.ReceiveUser = objDT.Rows[0][convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.ReceiveDate = objDT.Rows[0][convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.IsReceive = TransNullToBool(objDT.Rows[0][convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.UpdDate = objDT.Rows[0][convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.Memo = objDT.Rows[0][convzx_qa_Push.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PushEN.IsReply = TransNullToBool(objDT.Rows[0][convzx_qa_Push.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.IsRequestReply = TransNullToBool(objDT.Rows[0][convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.ReplyDate = objDT.Rows[0][convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.TextTitle = objDT.Rows[0][convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_qa_PushEN.UserName = objDT.Rows[0][convzx_qa_Push.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_qa_PushEN.QuestionsTypeName = objDT.Rows[0][convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_qa_PushEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.zxQuestionsTypeId = objDT.Rows[0][convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_qa_PushEN.QuestionsContent = objDT.Rows[0][convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PushEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PushEN.PdfContent = objDT.Rows[0][convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_qa_PushEN.IsEnd = TransNullToBool(objDT.Rows[0][convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PushEN.AnswerCount = TransNullToInt(objDT.Rows[0][convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PushEN.TextId = objDT.Rows[0][convzx_qa_Push.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PushEN.ZxqaPaperId = objDT.Rows[0][convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_qa_PushDA: Getvzx_qa_Push)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_qa_PushEN GetObjByPushId(long lngPushId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where PushId = " + ""+ lngPushId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
 objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d(字段类型:bigint,字段长度:8,是否可空:False)
 objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_qa_PushDA: GetObjByPushId)", objException.Message));
}
return objvzx_qa_PushEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_qa_PushEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Push where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN()
{
PushId = TransNullToInt(objRow[convzx_qa_Push.PushId].ToString().Trim()), //推送d
zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(), //提问Id
ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(), //接收用户
ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(), //接收日期
IsReceive = TransNullToBool(objRow[convzx_qa_Push.IsReceive].ToString().Trim()), //是否接收
UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(), //备注
IsReply = TransNullToBool(objRow[convzx_qa_Push.IsReply].ToString().Trim()), //是否回复
IsRequestReply = TransNullToBool(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()), //是否要求回复
ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(), //回复日期
TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(), //TextTitle
UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(), //用户名
QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(), //问题类型名称
IsPublic = TransNullToBool(objRow[convzx_qa_Push.IsPublic].ToString().Trim()), //是否公开
zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(), //问题类型Id
QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(), //提问内容
PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()), //Pdf页码
PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(), //Pdf内容
IsEnd = TransNullToBool(objRow[convzx_qa_Push.IsEnd].ToString().Trim()), //是否结束
VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.VoteCount].ToString().Trim()), //点赞计数
AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()), //回答计数
TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(), //课件Id
ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim() //论文答疑Id
};
objvzx_qa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_qa_PushEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_qa_PushDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_qa_PushEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = TransNullToInt(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = TransNullToBool(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = TransNullToBool(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = TransNullToBool(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = TransNullToBool(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = TransNullToBool(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_qa_PushDA: GetObjByDataRowvzx_qa_Push)", objException.Message));
}
objvzx_qa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_qa_PushEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_qa_PushEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = TransNullToInt(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = TransNullToBool(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = TransNullToBool(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = TransNullToBool(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = TransNullToBool(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = TransNullToBool(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_qa_PushDA: GetObjByDataRow)", objException.Message));
}
objvzx_qa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_qa_PushEN;
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
objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_qa_PushEN._CurrTabName, convzx_qa_Push.PushId, 8, "");
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
objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_qa_PushEN._CurrTabName, convzx_qa_Push.PushId, 8, strPrefix);
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PushId from vzx_qa_Push where " + strCondition;
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PushId from vzx_qa_Push where " + strCondition;
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
 /// <param name = "lngPushId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPushId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_qa_Push", "PushId = " + ""+ lngPushId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_qa_PushDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_qa_Push", strCondition))
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
objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_qa_Push");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_qa_PushENS">源对象</param>
 /// <param name = "objvzx_qa_PushENT">目标对象</param>
public void CopyTo(clsvzx_qa_PushEN objvzx_qa_PushENS, clsvzx_qa_PushEN objvzx_qa_PushENT)
{
objvzx_qa_PushENT.PushId = objvzx_qa_PushENS.PushId; //推送d
objvzx_qa_PushENT.zxQuestionsId = objvzx_qa_PushENS.zxQuestionsId; //提问Id
objvzx_qa_PushENT.ReceiveUser = objvzx_qa_PushENS.ReceiveUser; //接收用户
objvzx_qa_PushENT.ReceiveDate = objvzx_qa_PushENS.ReceiveDate; //接收日期
objvzx_qa_PushENT.IsReceive = objvzx_qa_PushENS.IsReceive; //是否接收
objvzx_qa_PushENT.UpdDate = objvzx_qa_PushENS.UpdDate; //修改日期
objvzx_qa_PushENT.Memo = objvzx_qa_PushENS.Memo; //备注
objvzx_qa_PushENT.IsReply = objvzx_qa_PushENS.IsReply; //是否回复
objvzx_qa_PushENT.IsRequestReply = objvzx_qa_PushENS.IsRequestReply; //是否要求回复
objvzx_qa_PushENT.ReplyDate = objvzx_qa_PushENS.ReplyDate; //回复日期
objvzx_qa_PushENT.TextTitle = objvzx_qa_PushENS.TextTitle; //TextTitle
objvzx_qa_PushENT.UserName = objvzx_qa_PushENS.UserName; //用户名
objvzx_qa_PushENT.QuestionsTypeName = objvzx_qa_PushENS.QuestionsTypeName; //问题类型名称
objvzx_qa_PushENT.IsPublic = objvzx_qa_PushENS.IsPublic; //是否公开
objvzx_qa_PushENT.zxQuestionsTypeId = objvzx_qa_PushENS.zxQuestionsTypeId; //问题类型Id
objvzx_qa_PushENT.QuestionsContent = objvzx_qa_PushENS.QuestionsContent; //提问内容
objvzx_qa_PushENT.PdfPageNum = objvzx_qa_PushENS.PdfPageNum; //Pdf页码
objvzx_qa_PushENT.PdfContent = objvzx_qa_PushENS.PdfContent; //Pdf内容
objvzx_qa_PushENT.IsEnd = objvzx_qa_PushENS.IsEnd; //是否结束
objvzx_qa_PushENT.VoteCount = objvzx_qa_PushENS.VoteCount; //点赞计数
objvzx_qa_PushENT.AnswerCount = objvzx_qa_PushENS.AnswerCount; //回答计数
objvzx_qa_PushENT.TextId = objvzx_qa_PushENS.TextId; //课件Id
objvzx_qa_PushENT.ZxqaPaperId = objvzx_qa_PushENS.ZxqaPaperId; //论文答疑Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_qa_PushEN objvzx_qa_PushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.zxQuestionsId, 8, convzx_qa_Push.zxQuestionsId);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.ReceiveUser, 20, convzx_qa_Push.ReceiveUser);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.ReceiveDate, 20, convzx_qa_Push.ReceiveDate);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.UpdDate, 20, convzx_qa_Push.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.Memo, 1000, convzx_qa_Push.Memo);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.ReplyDate, 20, convzx_qa_Push.ReplyDate);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.TextTitle, 500, convzx_qa_Push.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.UserName, 30, convzx_qa_Push.UserName);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.QuestionsTypeName, 50, convzx_qa_Push.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.zxQuestionsTypeId, 2, convzx_qa_Push.zxQuestionsTypeId);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.QuestionsContent, 1000, convzx_qa_Push.QuestionsContent);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.PdfContent, 2000, convzx_qa_Push.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.TextId, 8, convzx_qa_Push.TextId);
clsCheckSql.CheckFieldLen(objvzx_qa_PushEN.ZxqaPaperId, 8, convzx_qa_Push.ZxqaPaperId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.zxQuestionsId, convzx_qa_Push.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.ReceiveUser, convzx_qa_Push.ReceiveUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.ReceiveDate, convzx_qa_Push.ReceiveDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.UpdDate, convzx_qa_Push.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.Memo, convzx_qa_Push.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.ReplyDate, convzx_qa_Push.ReplyDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.TextTitle, convzx_qa_Push.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.UserName, convzx_qa_Push.UserName);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.QuestionsTypeName, convzx_qa_Push.QuestionsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.zxQuestionsTypeId, convzx_qa_Push.zxQuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.QuestionsContent, convzx_qa_Push.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.PdfContent, convzx_qa_Push.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.TextId, convzx_qa_Push.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PushEN.ZxqaPaperId, convzx_qa_Push.ZxqaPaperId);
//检查外键字段长度
 objvzx_qa_PushEN._IsCheckProperty = true;
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_qa_PushEN._CurrTabName);
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_qa_PushEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_qa_PushDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}