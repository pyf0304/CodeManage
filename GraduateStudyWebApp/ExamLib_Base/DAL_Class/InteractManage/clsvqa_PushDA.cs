
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PushDA
 表名:vqa_Push(01120634)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:33
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
 /// v答疑推送(vqa_Push)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvqa_PushDA : clsCommBase4DA
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
 return clsvqa_PushEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvqa_PushEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_PushEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvqa_PushEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvqa_PushEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vqa_Push(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable_vqa_Push)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Push.* from vqa_Push Left Join {1} on {2} where {3} and vqa_Push.PushId not in (Select top {5} vqa_Push.PushId from vqa_Push Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1} and PushId not in (Select top {2} PushId from vqa_Push where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1} and PushId not in (Select top {3} PushId from vqa_Push where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvqa_PushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Push.* from vqa_Push Left Join {1} on {2} where {3} and vqa_Push.PushId not in (Select top {5} vqa_Push.PushId from vqa_Push Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1} and PushId not in (Select top {2} PushId from vqa_Push where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Push where {1} and PushId not in (Select top {3} PushId from vqa_Push where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvqa_PushEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvqa_PushDA:GetObjLst)", objException.Message));
}
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = TransNullToInt(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = TransNullToBool(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = TransNullToBool(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = TransNullToBool(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = TransNullToBool(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = TransNullToBool(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_PushDA: GetObjLst)", objException.Message));
}
objvqa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_PushEN);
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
public List<clsvqa_PushEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvqa_PushDA:GetObjLstByTabName)", objException.Message));
}
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = TransNullToInt(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = TransNullToBool(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = TransNullToBool(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = TransNullToBool(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = TransNullToBool(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = TransNullToBool(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_PushDA: GetObjLst)", objException.Message));
}
objvqa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_PushEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvqa_Push(ref clsvqa_PushEN objvqa_PushEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where PushId = " + ""+ objvqa_PushEN.PushId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvqa_PushEN.PushId = TransNullToInt(objDT.Rows[0][convqa_Push.PushId].ToString().Trim()); //推送d(字段类型:bigint,字段长度:8,是否可空:False)
 objvqa_PushEN.QuestionsId = objDT.Rows[0][convqa_Push.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PushEN.QuestionsContent = objDT.Rows[0][convqa_Push.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PushEN.ReceiveUser = objDT.Rows[0][convqa_Push.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.ReceiveDate = objDT.Rows[0][convqa_Push.ReceiveDate].ToString().Trim(); //接收日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.UserName = objDT.Rows[0][convqa_Push.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_PushEN.IsReceive = TransNullToBool(objDT.Rows[0][convqa_Push.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.UpdDate = objDT.Rows[0][convqa_Push.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.AnswerCount = TransNullToInt(objDT.Rows[0][convqa_Push.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PushEN.IsEnd = TransNullToBool(objDT.Rows[0][convqa_Push.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.VoteCount = TransNullToInt(objDT.Rows[0][convqa_Push.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PushEN.Memo = objDT.Rows[0][convqa_Push.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PushEN.IdCurrEduCls = objDT.Rows[0][convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PushEN.PdfContent = objDT.Rows[0][convqa_Push.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvqa_PushEN.QaPaperId = objDT.Rows[0][convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PushEN.IsPublic = TransNullToBool(objDT.Rows[0][convqa_Push.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.PaperId = objDT.Rows[0][convqa_Push.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_PushEN.PaperTitle = objDT.Rows[0][convqa_Push.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_PushEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PushEN.IsReply = TransNullToBool(objDT.Rows[0][convqa_Push.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.IsRequestReply = TransNullToBool(objDT.Rows[0][convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.ReplyDate = objDT.Rows[0][convqa_Push.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.QuestionsTypeId = objDT.Rows[0][convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_PushEN.QuestionsTypeName = objDT.Rows[0][convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvqa_PushDA: Getvqa_Push)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public clsvqa_PushEN GetObjByPushId(long lngPushId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where PushId = " + ""+ lngPushId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
 objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d(字段类型:bigint,字段长度:8,是否可空:False)
 objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvqa_PushDA: GetObjByPushId)", objException.Message));
}
return objvqa_PushEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvqa_PushEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvqa_PushDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Push where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN()
{
PushId = TransNullToInt(objRow[convqa_Push.PushId].ToString().Trim()), //推送d
QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(), //提问Id
QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(), //提问内容
ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(), //接收用户
ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(), //接收日期
UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(), //用户名
IsReceive = TransNullToBool(objRow[convqa_Push.IsReceive].ToString().Trim()), //是否接收
UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(), //修改日期
AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.AnswerCount].ToString().Trim()), //回答计数
IsEnd = TransNullToBool(objRow[convqa_Push.IsEnd].ToString().Trim()), //是否结束
VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.VoteCount].ToString().Trim()), //点赞计数
Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(), //Pdf内容
QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(), //论文答疑Id
IsPublic = TransNullToBool(objRow[convqa_Push.IsPublic].ToString().Trim()), //是否公开
PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(), //论文标题
PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.PdfPageNum].ToString().Trim()), //Pdf页码
IsReply = TransNullToBool(objRow[convqa_Push.IsReply].ToString().Trim()), //是否回复
IsRequestReply = TransNullToBool(objRow[convqa_Push.IsRequestReply].ToString().Trim()), //是否要求回复
ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(), //回复日期
QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(), //问题类型Id
QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim() //问题类型名称
};
objvqa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_PushEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvqa_PushDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvqa_PushEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = TransNullToInt(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = TransNullToBool(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = TransNullToBool(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = TransNullToBool(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = TransNullToBool(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = TransNullToBool(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvqa_PushDA: GetObjByDataRowvqa_Push)", objException.Message));
}
objvqa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_PushEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvqa_PushEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = TransNullToInt(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = TransNullToBool(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = TransNullToBool(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = TransNullToBool(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = TransNullToBool(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = TransNullToBool(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvqa_PushDA: GetObjByDataRow)", objException.Message));
}
objvqa_PushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_PushEN;
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
objSQL = clsvqa_PushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_PushEN._CurrTabName, convqa_Push.PushId, 8, "");
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
objSQL = clsvqa_PushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_PushEN._CurrTabName, convqa_Push.PushId, 8, strPrefix);
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PushId from vqa_Push where " + strCondition;
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PushId from vqa_Push where " + strCondition;
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Push", "PushId = " + ""+ lngPushId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvqa_PushDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Push", strCondition))
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
objSQL = clsvqa_PushDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vqa_Push");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvqa_PushENS">源对象</param>
 /// <param name = "objvqa_PushENT">目标对象</param>
public void CopyTo(clsvqa_PushEN objvqa_PushENS, clsvqa_PushEN objvqa_PushENT)
{
objvqa_PushENT.PushId = objvqa_PushENS.PushId; //推送d
objvqa_PushENT.QuestionsId = objvqa_PushENS.QuestionsId; //提问Id
objvqa_PushENT.QuestionsContent = objvqa_PushENS.QuestionsContent; //提问内容
objvqa_PushENT.ReceiveUser = objvqa_PushENS.ReceiveUser; //接收用户
objvqa_PushENT.ReceiveDate = objvqa_PushENS.ReceiveDate; //接收日期
objvqa_PushENT.UserName = objvqa_PushENS.UserName; //用户名
objvqa_PushENT.IsReceive = objvqa_PushENS.IsReceive; //是否接收
objvqa_PushENT.UpdDate = objvqa_PushENS.UpdDate; //修改日期
objvqa_PushENT.AnswerCount = objvqa_PushENS.AnswerCount; //回答计数
objvqa_PushENT.IsEnd = objvqa_PushENS.IsEnd; //是否结束
objvqa_PushENT.VoteCount = objvqa_PushENS.VoteCount; //点赞计数
objvqa_PushENT.Memo = objvqa_PushENS.Memo; //备注
objvqa_PushENT.IdCurrEduCls = objvqa_PushENS.IdCurrEduCls; //教学班流水号
objvqa_PushENT.PdfContent = objvqa_PushENS.PdfContent; //Pdf内容
objvqa_PushENT.QaPaperId = objvqa_PushENS.QaPaperId; //论文答疑Id
objvqa_PushENT.IsPublic = objvqa_PushENS.IsPublic; //是否公开
objvqa_PushENT.PaperId = objvqa_PushENS.PaperId; //论文Id
objvqa_PushENT.PaperTitle = objvqa_PushENS.PaperTitle; //论文标题
objvqa_PushENT.PdfPageNum = objvqa_PushENS.PdfPageNum; //Pdf页码
objvqa_PushENT.IsReply = objvqa_PushENS.IsReply; //是否回复
objvqa_PushENT.IsRequestReply = objvqa_PushENS.IsRequestReply; //是否要求回复
objvqa_PushENT.ReplyDate = objvqa_PushENS.ReplyDate; //回复日期
objvqa_PushENT.QuestionsTypeId = objvqa_PushENS.QuestionsTypeId; //问题类型Id
objvqa_PushENT.QuestionsTypeName = objvqa_PushENS.QuestionsTypeName; //问题类型名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvqa_PushEN objvqa_PushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvqa_PushEN.QuestionsId, 8, convqa_Push.QuestionsId);
clsCheckSql.CheckFieldLen(objvqa_PushEN.QuestionsContent, 1000, convqa_Push.QuestionsContent);
clsCheckSql.CheckFieldLen(objvqa_PushEN.ReceiveUser, 20, convqa_Push.ReceiveUser);
clsCheckSql.CheckFieldLen(objvqa_PushEN.ReceiveDate, 20, convqa_Push.ReceiveDate);
clsCheckSql.CheckFieldLen(objvqa_PushEN.UserName, 30, convqa_Push.UserName);
clsCheckSql.CheckFieldLen(objvqa_PushEN.UpdDate, 20, convqa_Push.UpdDate);
clsCheckSql.CheckFieldLen(objvqa_PushEN.Memo, 1000, convqa_Push.Memo);
clsCheckSql.CheckFieldLen(objvqa_PushEN.IdCurrEduCls, 8, convqa_Push.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvqa_PushEN.PdfContent, 2000, convqa_Push.PdfContent);
clsCheckSql.CheckFieldLen(objvqa_PushEN.QaPaperId, 8, convqa_Push.QaPaperId);
clsCheckSql.CheckFieldLen(objvqa_PushEN.PaperId, 8, convqa_Push.PaperId);
clsCheckSql.CheckFieldLen(objvqa_PushEN.PaperTitle, 500, convqa_Push.PaperTitle);
clsCheckSql.CheckFieldLen(objvqa_PushEN.ReplyDate, 20, convqa_Push.ReplyDate);
clsCheckSql.CheckFieldLen(objvqa_PushEN.QuestionsTypeId, 2, convqa_Push.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objvqa_PushEN.QuestionsTypeName, 50, convqa_Push.QuestionsTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.QuestionsId, convqa_Push.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.QuestionsContent, convqa_Push.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.ReceiveUser, convqa_Push.ReceiveUser);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.ReceiveDate, convqa_Push.ReceiveDate);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.UserName, convqa_Push.UserName);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.UpdDate, convqa_Push.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.Memo, convqa_Push.Memo);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.IdCurrEduCls, convqa_Push.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.PdfContent, convqa_Push.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.QaPaperId, convqa_Push.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.PaperId, convqa_Push.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.PaperTitle, convqa_Push.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.ReplyDate, convqa_Push.ReplyDate);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.QuestionsTypeId, convqa_Push.QuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvqa_PushEN.QuestionsTypeName, convqa_Push.QuestionsTypeName);
//检查外键字段长度
 objvqa_PushEN._IsCheckProperty = true;
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_PushEN._CurrTabName);
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_PushEN._CurrTabName, strCondition);
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
 objSQL = clsvqa_PushDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}