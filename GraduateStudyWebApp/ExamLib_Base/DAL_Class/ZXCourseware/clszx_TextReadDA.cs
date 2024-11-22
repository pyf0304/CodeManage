
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextReadDA
 表名:zx_TextRead(01120716)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 课文阅读(zx_TextRead)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TextReadDA : clsCommBase4DA
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
 return clszx_TextReadEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TextReadEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TextReadEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TextReadEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TextReadEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTextRId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTextRId)
{
strTextRId = strTextRId.Replace("'", "''");
if (strTextRId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_TextRead中,检查关键字,长度不正确!(clszx_TextReadDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextRId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_TextRead中,关键字不能为空 或 null!(clszx_TextReadDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextRId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_TextReadDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_TextRead(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable_zx_TextRead)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TextRead.* from zx_TextRead Left Join {1} on {2} where {3} and zx_TextRead.TextRId not in (Select top {5} zx_TextRead.TextRId from zx_TextRead Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1} and TextRId not in (Select top {2} TextRId from zx_TextRead where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1} and TextRId not in (Select top {3} TextRId from zx_TextRead where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TextReadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TextRead.* from zx_TextRead Left Join {1} on {2} where {3} and zx_TextRead.TextRId not in (Select top {5} zx_TextRead.TextRId from zx_TextRead Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1} and TextRId not in (Select top {2} TextRId from zx_TextRead where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TextRead where {1} and TextRId not in (Select top {3} TextRId from zx_TextRead where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TextReadEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TextReadDA:GetObjLst)", objException.Message));
}
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = TransNullToBool(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = TransNullToBool(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TextReadDA: GetObjLst)", objException.Message));
}
objzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TextReadEN);
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
public List<clszx_TextReadEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TextReadDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = TransNullToBool(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = TransNullToBool(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TextReadDA: GetObjLst)", objException.Message));
}
objzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TextReadEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_TextRead(ref clszx_TextReadEN objzx_TextReadEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where TextRId = " + "'"+ objzx_TextReadEN.TextRId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TextReadEN.TextId = objDT.Rows[0][conzx_TextRead.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextReadEN.ReadTypeId = objDT.Rows[0][conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型(字段类型:char,字段长度:2,是否可空:False)
 objzx_TextReadEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextReadEN.IsPublic = TransNullToBool(objDT.Rows[0][conzx_TextRead.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextReadEN.Submitter = objDT.Rows[0][conzx_TextRead.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TextReadEN.IdCurrEduCls = objDT.Rows[0][conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextReadEN.QuestionCount = TransNullToInt(objDT.Rows[0][conzx_TextRead.QuestionCount].ToString().Trim()); //问题数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextReadEN.CreateDate = objDT.Rows[0][conzx_TextRead.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextReadEN.UpdUser = objDT.Rows[0][conzx_TextRead.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextReadEN.UpdDate = objDT.Rows[0][conzx_TextRead.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextReadEN.Memo = objDT.Rows[0][conzx_TextRead.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextReadEN.TextRId = objDT.Rows[0][conzx_TextRead.TextRId].ToString().Trim(); //TextRId(字段类型:char,字段长度:10,是否可空:False)
 objzx_TextReadEN.ReaderUserId = objDT.Rows[0][conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TextReadDA: Getzx_TextRead)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TextReadEN GetObjByTextRId(string strTextRId)
{
CheckPrimaryKey(strTextRId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where TextRId = " + "'"+ strTextRId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
 objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型(字段类型:char,字段长度:2,是否可空:False)
 objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId(字段类型:char,字段长度:10,是否可空:False)
 objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TextReadDA: GetObjByTextRId)", objException.Message));
}
return objzx_TextReadEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TextReadEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TextReadDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN()
{
TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(), //课件Id
ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(), //阅读类型
IsSubmit = TransNullToBool(objRow[conzx_TextRead.IsSubmit].ToString().Trim()), //是否提交
IsPublic = TransNullToBool(objRow[conzx_TextRead.IsPublic].ToString().Trim()), //是否公开
Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(), //提交人
IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(), //教学班流水号
QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TextRead.QuestionCount].ToString().Trim()), //问题数
CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(), //建立日期
UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(), //备注
TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(), //TextRId
ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim() //ReaderUserId
};
objzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TextReadEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TextReadDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TextReadEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = TransNullToBool(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = TransNullToBool(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TextReadDA: GetObjByDataRowzx_TextRead)", objException.Message));
}
objzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TextReadEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TextReadEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = TransNullToBool(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = TransNullToBool(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TextReadDA: GetObjByDataRow)", objException.Message));
}
objzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TextReadEN;
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
objSQL = clszx_TextReadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TextReadEN._CurrTabName, conzx_TextRead.TextRId, 10, "");
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
objSQL = clszx_TextReadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TextReadEN._CurrTabName, conzx_TextRead.TextRId, 10, strPrefix);
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TextRId from zx_TextRead where " + strCondition;
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TextRId from zx_TextRead where " + strCondition;
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
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTextRId)
{
CheckPrimaryKey(strTextRId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TextRead", "TextRId = " + "'"+ strTextRId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TextReadDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TextRead", strCondition))
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
objSQL = clszx_TextReadDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_TextRead");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TextReadEN objzx_TextReadEN)
 {
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextReadEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TextRead");
objRow = objDS.Tables["zx_TextRead"].NewRow();
 if (objzx_TextReadEN.TextId !=  "")
 {
objRow[conzx_TextRead.TextId] = objzx_TextReadEN.TextId; //课件Id
 }
objRow[conzx_TextRead.ReadTypeId] = objzx_TextReadEN.ReadTypeId; //阅读类型
objRow[conzx_TextRead.IsSubmit] = objzx_TextReadEN.IsSubmit; //是否提交
objRow[conzx_TextRead.IsPublic] = objzx_TextReadEN.IsPublic; //是否公开
 if (objzx_TextReadEN.Submitter !=  "")
 {
objRow[conzx_TextRead.Submitter] = objzx_TextReadEN.Submitter; //提交人
 }
 if (objzx_TextReadEN.IdCurrEduCls !=  "")
 {
objRow[conzx_TextRead.IdCurrEduCls] = objzx_TextReadEN.IdCurrEduCls; //教学班流水号
 }
objRow[conzx_TextRead.QuestionCount] = objzx_TextReadEN.QuestionCount; //问题数
 if (objzx_TextReadEN.CreateDate !=  "")
 {
objRow[conzx_TextRead.CreateDate] = objzx_TextReadEN.CreateDate; //建立日期
 }
 if (objzx_TextReadEN.UpdUser !=  "")
 {
objRow[conzx_TextRead.UpdUser] = objzx_TextReadEN.UpdUser; //修改人
 }
objRow[conzx_TextRead.UpdDate] = objzx_TextReadEN.UpdDate; //修改日期
 if (objzx_TextReadEN.Memo !=  "")
 {
objRow[conzx_TextRead.Memo] = objzx_TextReadEN.Memo; //备注
 }
objRow[conzx_TextRead.TextRId] = objzx_TextReadEN.TextRId; //TextRId
 if (objzx_TextReadEN.ReaderUserId !=  "")
 {
objRow[conzx_TextRead.ReaderUserId] = objzx_TextReadEN.ReaderUserId; //ReaderUserId
 }
objDS.Tables[clszx_TextReadEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TextReadEN._CurrTabName);
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TextReadEN objzx_TextReadEN)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextReadEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextId);
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReadTypeId);
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReadTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TextRead.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_TextRead.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextReadEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Submitter);
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.QuestionCount);
 arrValueListForInsert.Add(objzx_TextReadEN.QuestionCount.ToString());
 }
 
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.CreateDate);
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdUser);
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdDate);
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextReadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Memo);
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextReadEN.TextRId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextRId);
 var strTextRId = objzx_TextReadEN.TextRId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextRId + "'");
 }
 
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReaderUserId);
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TextRead");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TextReadEN objzx_TextReadEN)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextReadEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextId);
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReadTypeId);
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReadTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TextRead.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_TextRead.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextReadEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Submitter);
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.QuestionCount);
 arrValueListForInsert.Add(objzx_TextReadEN.QuestionCount.ToString());
 }
 
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.CreateDate);
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdUser);
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdDate);
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextReadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Memo);
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextReadEN.TextRId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextRId);
 var strTextRId = objzx_TextReadEN.TextRId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextRId + "'");
 }
 
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReaderUserId);
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TextRead");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_TextReadEN.TextRId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TextReadEN objzx_TextReadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextReadEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextId);
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReadTypeId);
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReadTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TextRead.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_TextRead.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextReadEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Submitter);
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.QuestionCount);
 arrValueListForInsert.Add(objzx_TextReadEN.QuestionCount.ToString());
 }
 
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.CreateDate);
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdUser);
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdDate);
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextReadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Memo);
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextReadEN.TextRId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextRId);
 var strTextRId = objzx_TextReadEN.TextRId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextRId + "'");
 }
 
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReaderUserId);
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TextRead");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_TextReadEN.TextRId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TextReadEN objzx_TextReadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextReadEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextId);
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReadTypeId);
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReadTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TextRead.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_TextRead.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextReadEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextReadEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Submitter);
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.QuestionCount);
 arrValueListForInsert.Add(objzx_TextReadEN.QuestionCount.ToString());
 }
 
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.CreateDate);
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdUser);
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.UpdDate);
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextReadEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.Memo);
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextReadEN.TextRId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.TextRId);
 var strTextRId = objzx_TextReadEN.TextRId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextRId + "'");
 }
 
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TextRead.ReaderUserId);
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TextRead");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_TextReads(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where TextRId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TextRead");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTextRId = oRow[conzx_TextRead.TextRId].ToString().Trim();
if (IsExist(strTextRId))
{
 string strResult = "关键字变量值为:" + string.Format("TextRId = {0}", strTextRId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TextReadEN._CurrTabName ].NewRow();
objRow[conzx_TextRead.TextId] = oRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objRow[conzx_TextRead.ReadTypeId] = oRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objRow[conzx_TextRead.IsSubmit] = oRow[conzx_TextRead.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_TextRead.IsPublic] = oRow[conzx_TextRead.IsPublic].ToString().Trim(); //是否公开
objRow[conzx_TextRead.Submitter] = oRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objRow[conzx_TextRead.IdCurrEduCls] = oRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_TextRead.QuestionCount] = oRow[conzx_TextRead.QuestionCount].ToString().Trim(); //问题数
objRow[conzx_TextRead.CreateDate] = oRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_TextRead.UpdUser] = oRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objRow[conzx_TextRead.UpdDate] = oRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_TextRead.Memo] = oRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objRow[conzx_TextRead.TextRId] = oRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objRow[conzx_TextRead.ReaderUserId] = oRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
 objDS.Tables[clszx_TextReadEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TextReadEN._CurrTabName);
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
 /// <param name = "objzx_TextReadEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TextReadEN objzx_TextReadEN)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextReadEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from zx_TextRead where TextRId = " + "'"+ objzx_TextReadEN.TextRId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TextReadEN._CurrTabName);
if (objDS.Tables[clszx_TextReadEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TextRId = " + "'"+ objzx_TextReadEN.TextRId+"'");
return false;
}
objRow = objDS.Tables[clszx_TextReadEN._CurrTabName].Rows[0];
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.TextId))
 {
objRow[conzx_TextRead.TextId] = objzx_TextReadEN.TextId; //课件Id
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReadTypeId))
 {
objRow[conzx_TextRead.ReadTypeId] = objzx_TextReadEN.ReadTypeId; //阅读类型
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsSubmit))
 {
objRow[conzx_TextRead.IsSubmit] = objzx_TextReadEN.IsSubmit; //是否提交
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsPublic))
 {
objRow[conzx_TextRead.IsPublic] = objzx_TextReadEN.IsPublic; //是否公开
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Submitter))
 {
objRow[conzx_TextRead.Submitter] = objzx_TextReadEN.Submitter; //提交人
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IdCurrEduCls))
 {
objRow[conzx_TextRead.IdCurrEduCls] = objzx_TextReadEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.QuestionCount))
 {
objRow[conzx_TextRead.QuestionCount] = objzx_TextReadEN.QuestionCount; //问题数
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.CreateDate))
 {
objRow[conzx_TextRead.CreateDate] = objzx_TextReadEN.CreateDate; //建立日期
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdUser))
 {
objRow[conzx_TextRead.UpdUser] = objzx_TextReadEN.UpdUser; //修改人
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdDate))
 {
objRow[conzx_TextRead.UpdDate] = objzx_TextReadEN.UpdDate; //修改日期
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Memo))
 {
objRow[conzx_TextRead.Memo] = objzx_TextReadEN.Memo; //备注
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.TextRId))
 {
objRow[conzx_TextRead.TextRId] = objzx_TextReadEN.TextRId; //TextRId
 }
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReaderUserId))
 {
objRow[conzx_TextRead.ReaderUserId] = objzx_TextReadEN.ReaderUserId; //ReaderUserId
 }
try
{
objDA.Update(objDS, clszx_TextReadEN._CurrTabName);
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TextReadEN objzx_TextReadEN)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextReadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_TextRead Set ");
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.TextId))
 {
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_TextRead.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.TextId); //课件Id
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReadTypeId))
 {
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReadTypeId, conzx_TextRead.ReadTypeId); //阅读类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.ReadTypeId); //阅读类型
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextReadEN.IsSubmit == true?"1":"0", conzx_TextRead.IsSubmit); //是否提交
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextReadEN.IsPublic == true?"1":"0", conzx_TextRead.IsPublic); //是否公开
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Submitter))
 {
 if (objzx_TextReadEN.Submitter !=  null)
 {
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitter, conzx_TextRead.Submitter); //提交人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.Submitter); //提交人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IdCurrEduCls))
 {
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TextRead.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.QuestionCount))
 {
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextReadEN.QuestionCount, conzx_TextRead.QuestionCount); //问题数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.QuestionCount); //问题数
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.CreateDate))
 {
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_TextRead.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.CreateDate); //建立日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdUser))
 {
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TextRead.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.UpdUser); //修改人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdDate))
 {
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TextRead.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.UpdDate); //修改日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Memo))
 {
 if (objzx_TextReadEN.Memo !=  null)
 {
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TextRead.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.Memo); //备注
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReaderUserId))
 {
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReaderUserId, conzx_TextRead.ReaderUserId); //ReaderUserId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.ReaderUserId); //ReaderUserId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TextRId = '{0}'", objzx_TextReadEN.TextRId); 
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
 /// <param name = "objzx_TextReadEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TextReadEN objzx_TextReadEN, string strCondition)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextReadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TextRead Set ");
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.TextId))
 {
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReadTypeId))
 {
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReadTypeId = '{0}',", strReadTypeId); //阅读类型
 }
 else
 {
 sbSQL.Append(" ReadTypeId = null,"); //阅读类型
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TextReadEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_TextReadEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Submitter))
 {
 if (objzx_TextReadEN.Submitter !=  null)
 {
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Submitter = '{0}',", strSubmitter); //提交人
 }
 else
 {
 sbSQL.Append(" Submitter = null,"); //提交人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IdCurrEduCls))
 {
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.QuestionCount))
 {
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextReadEN.QuestionCount, conzx_TextRead.QuestionCount); //问题数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.QuestionCount); //问题数
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.CreateDate))
 {
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdUser))
 {
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdDate))
 {
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Memo))
 {
 if (objzx_TextReadEN.Memo !=  null)
 {
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReaderUserId))
 {
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReaderUserId = '{0}',", strReaderUserId); //ReaderUserId
 }
 else
 {
 sbSQL.Append(" ReaderUserId = null,"); //ReaderUserId
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
 /// <param name = "objzx_TextReadEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TextReadEN objzx_TextReadEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextReadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TextRead Set ");
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.TextId))
 {
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReadTypeId))
 {
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReadTypeId = '{0}',", strReadTypeId); //阅读类型
 }
 else
 {
 sbSQL.Append(" ReadTypeId = null,"); //阅读类型
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TextReadEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_TextReadEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Submitter))
 {
 if (objzx_TextReadEN.Submitter !=  null)
 {
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Submitter = '{0}',", strSubmitter); //提交人
 }
 else
 {
 sbSQL.Append(" Submitter = null,"); //提交人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IdCurrEduCls))
 {
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.QuestionCount))
 {
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextReadEN.QuestionCount, conzx_TextRead.QuestionCount); //问题数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.QuestionCount); //问题数
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.CreateDate))
 {
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdUser))
 {
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdDate))
 {
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Memo))
 {
 if (objzx_TextReadEN.Memo !=  null)
 {
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReaderUserId))
 {
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReaderUserId = '{0}',", strReaderUserId); //ReaderUserId
 }
 else
 {
 sbSQL.Append(" ReaderUserId = null,"); //ReaderUserId
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TextReadEN objzx_TextReadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TextReadEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextReadEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TextRead Set ");
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.TextId))
 {
 if (objzx_TextReadEN.TextId  ==  "")
 {
 objzx_TextReadEN.TextId = null;
 }
 if (objzx_TextReadEN.TextId !=  null)
 {
 var strTextId = objzx_TextReadEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_TextRead.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.TextId); //课件Id
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReadTypeId))
 {
 if (objzx_TextReadEN.ReadTypeId !=  null)
 {
 var strReadTypeId = objzx_TextReadEN.ReadTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReadTypeId, conzx_TextRead.ReadTypeId); //阅读类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.ReadTypeId); //阅读类型
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextReadEN.IsSubmit == true?"1":"0", conzx_TextRead.IsSubmit); //是否提交
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextReadEN.IsPublic == true?"1":"0", conzx_TextRead.IsPublic); //是否公开
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Submitter))
 {
 if (objzx_TextReadEN.Submitter !=  null)
 {
 var strSubmitter = objzx_TextReadEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitter, conzx_TextRead.Submitter); //提交人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.Submitter); //提交人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.IdCurrEduCls))
 {
 if (objzx_TextReadEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextReadEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TextRead.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.QuestionCount))
 {
 if (objzx_TextReadEN.QuestionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextReadEN.QuestionCount, conzx_TextRead.QuestionCount); //问题数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.QuestionCount); //问题数
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.CreateDate))
 {
 if (objzx_TextReadEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextReadEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_TextRead.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.CreateDate); //建立日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdUser))
 {
 if (objzx_TextReadEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextReadEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TextRead.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.UpdUser); //修改人
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.UpdDate))
 {
 if (objzx_TextReadEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextReadEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TextRead.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.UpdDate); //修改日期
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.Memo))
 {
 if (objzx_TextReadEN.Memo !=  null)
 {
 var strMemo = objzx_TextReadEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TextRead.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.Memo); //备注
 }
 }
 
 if (objzx_TextReadEN.IsUpdated(conzx_TextRead.ReaderUserId))
 {
 if (objzx_TextReadEN.ReaderUserId !=  null)
 {
 var strReaderUserId = objzx_TextReadEN.ReaderUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReaderUserId, conzx_TextRead.ReaderUserId); //ReaderUserId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TextRead.ReaderUserId); //ReaderUserId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TextRId = '{0}'", objzx_TextReadEN.TextRId); 
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
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTextRId) 
{
CheckPrimaryKey(strTextRId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTextRId,
};
 objSQL.ExecSP("zx_TextRead_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTextRId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTextRId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
//删除zx_TextRead本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TextRead where TextRId = " + "'"+ strTextRId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_TextRead(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
//删除zx_TextRead本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TextRead where TextRId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTextRId) 
{
CheckPrimaryKey(strTextRId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
//删除zx_TextRead本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TextRead where TextRId = " + "'"+ strTextRId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_TextRead(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TextReadDA: Delzx_TextRead)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TextRead where " + strCondition ;
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
public bool Delzx_TextReadWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TextReadDA: Delzx_TextReadWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TextRead where " + strCondition ;
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
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <param name = "objzx_TextReadENT">目标对象</param>
public void CopyTo(clszx_TextReadEN objzx_TextReadENS, clszx_TextReadEN objzx_TextReadENT)
{
objzx_TextReadENT.TextId = objzx_TextReadENS.TextId; //课件Id
objzx_TextReadENT.ReadTypeId = objzx_TextReadENS.ReadTypeId; //阅读类型
objzx_TextReadENT.IsSubmit = objzx_TextReadENS.IsSubmit; //是否提交
objzx_TextReadENT.IsPublic = objzx_TextReadENS.IsPublic; //是否公开
objzx_TextReadENT.Submitter = objzx_TextReadENS.Submitter; //提交人
objzx_TextReadENT.IdCurrEduCls = objzx_TextReadENS.IdCurrEduCls; //教学班流水号
objzx_TextReadENT.QuestionCount = objzx_TextReadENS.QuestionCount; //问题数
objzx_TextReadENT.CreateDate = objzx_TextReadENS.CreateDate; //建立日期
objzx_TextReadENT.UpdUser = objzx_TextReadENS.UpdUser; //修改人
objzx_TextReadENT.UpdDate = objzx_TextReadENS.UpdDate; //修改日期
objzx_TextReadENT.Memo = objzx_TextReadENS.Memo; //备注
objzx_TextReadENT.TextRId = objzx_TextReadENS.TextRId; //TextRId
objzx_TextReadENT.ReaderUserId = objzx_TextReadENS.ReaderUserId; //ReaderUserId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TextReadEN objzx_TextReadEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_TextReadEN.ReadTypeId, conzx_TextRead.ReadTypeId);
clsCheckSql.CheckFieldNotNull(objzx_TextReadEN.UpdDate, conzx_TextRead.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TextReadEN.TextId, 8, conzx_TextRead.TextId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.ReadTypeId, 2, conzx_TextRead.ReadTypeId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.Submitter, 50, conzx_TextRead.Submitter);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.IdCurrEduCls, 8, conzx_TextRead.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.CreateDate, 20, conzx_TextRead.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.UpdUser, 20, conzx_TextRead.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.UpdDate, 20, conzx_TextRead.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.Memo, 1000, conzx_TextRead.Memo);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.TextRId, 10, conzx_TextRead.TextRId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.ReaderUserId, 20, conzx_TextRead.ReaderUserId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objzx_TextReadEN.TextId, 8, conzx_TextRead.TextId);
 objzx_TextReadEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TextReadEN objzx_TextReadEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TextReadEN.TextId, 8, conzx_TextRead.TextId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.ReadTypeId, 2, conzx_TextRead.ReadTypeId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.Submitter, 50, conzx_TextRead.Submitter);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.IdCurrEduCls, 8, conzx_TextRead.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.CreateDate, 20, conzx_TextRead.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.UpdUser, 20, conzx_TextRead.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.UpdDate, 20, conzx_TextRead.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.Memo, 1000, conzx_TextRead.Memo);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.ReaderUserId, 20, conzx_TextRead.ReaderUserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objzx_TextReadEN.TextId, 8, conzx_TextRead.TextId);
 objzx_TextReadEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TextReadEN objzx_TextReadEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TextReadEN.TextId, 8, conzx_TextRead.TextId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.ReadTypeId, 2, conzx_TextRead.ReadTypeId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.Submitter, 50, conzx_TextRead.Submitter);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.IdCurrEduCls, 8, conzx_TextRead.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.CreateDate, 20, conzx_TextRead.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.UpdUser, 20, conzx_TextRead.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.UpdDate, 20, conzx_TextRead.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.Memo, 1000, conzx_TextRead.Memo);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.TextRId, 10, conzx_TextRead.TextRId);
clsCheckSql.CheckFieldLen(objzx_TextReadEN.ReaderUserId, 20, conzx_TextRead.ReaderUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.TextId, conzx_TextRead.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.ReadTypeId, conzx_TextRead.ReadTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.Submitter, conzx_TextRead.Submitter);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.IdCurrEduCls, conzx_TextRead.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.CreateDate, conzx_TextRead.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.UpdUser, conzx_TextRead.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.UpdDate, conzx_TextRead.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.Memo, conzx_TextRead.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.TextRId, conzx_TextRead.TextRId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextReadEN.ReaderUserId, conzx_TextRead.ReaderUserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objzx_TextReadEN.TextId, 8, conzx_TextRead.TextId);
 objzx_TextReadEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_TextRead(课文阅读),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TextReadEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TextReadEN objzx_TextReadEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_TextReadEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TextReadEN.TextId);
}
 sbCondition.AppendFormat(" and ReadTypeId = '{0}'", objzx_TextReadEN.ReadTypeId);
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TextReadEN._CurrTabName);
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TextReadEN._CurrTabName, strCondition);
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
 objSQL = clszx_TextReadDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}