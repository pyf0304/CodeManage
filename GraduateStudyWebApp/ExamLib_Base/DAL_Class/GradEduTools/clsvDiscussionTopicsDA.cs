
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDiscussionTopicsDA
 表名:vDiscussionTopics(01120586)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:00:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// v讨论主题视图(vDiscussionTopics)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDiscussionTopicsDA : clsCommBase4DA
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
 return clsvDiscussionTopicsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDiscussionTopicsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDiscussionTopicsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDiscussionTopicsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDiscussionTopicsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTopicsId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTopicsId)
{
strTopicsId = strTopicsId.Replace("'", "''");
if (strTopicsId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vDiscussionTopics中,检查关键字,长度不正确!(clsvDiscussionTopicsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTopicsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDiscussionTopics中,关键字不能为空 或 null!(clsvDiscussionTopicsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDiscussionTopicsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDiscussionTopics(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable_vDiscussionTopics)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vDiscussionTopics.* from vDiscussionTopics Left Join {1} on {2} where {3} and vDiscussionTopics.TopicsId not in (Select top {5} vDiscussionTopics.TopicsId from vDiscussionTopics Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1} and TopicsId not in (Select top {2} TopicsId from vDiscussionTopics where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1} and TopicsId not in (Select top {3} TopicsId from vDiscussionTopics where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vDiscussionTopics.* from vDiscussionTopics Left Join {1} on {2} where {3} and vDiscussionTopics.TopicsId not in (Select top {5} vDiscussionTopics.TopicsId from vDiscussionTopics Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1} and TopicsId not in (Select top {2} TopicsId from vDiscussionTopics where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionTopics where {1} and TopicsId not in (Select top {3} TopicsId from vDiscussionTopics where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDiscussionTopicsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA:GetObjLst)", objException.Message));
}
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = TransNullToBool(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = TransNullToBool(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetObjLst)", objException.Message));
}
objvDiscussionTopicsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDiscussionTopicsEN);
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
public List<clsvDiscussionTopicsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = TransNullToBool(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = TransNullToBool(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetObjLst)", objException.Message));
}
objvDiscussionTopicsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDiscussionTopicsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDiscussionTopics(ref clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where TopicsId = " + "'"+ objvDiscussionTopicsEN.TopicsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDiscussionTopicsEN.TopicsId = objDT.Rows[0][convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvDiscussionTopicsEN.DiscussionTypeId = objDT.Rows[0][convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionTopicsEN.DiscussionTypeName = objDT.Rows[0][convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvDiscussionTopicsEN.TopicsTitle = objDT.Rows[0][convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvDiscussionTopicsEN.TopicsContent = objDT.Rows[0][convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvDiscussionTopicsEN.IsAudit = TransNullToBool(objDT.Rows[0][convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvDiscussionTopicsEN.IsTop = TransNullToBool(objDT.Rows[0][convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvDiscussionTopicsEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvDiscussionTopicsEN.UpdDate = objDT.Rows[0][convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionTopicsEN.UpdUser = objDT.Rows[0][convDiscussionTopics.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionTopicsEN.Memo = objDT.Rows[0][convDiscussionTopics.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDiscussionTopicsEN.CollegeName = objDT.Rows[0][convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionTopicsEN.IdXzCollege = objDT.Rows[0][convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvDiscussionTopicsEN.IdXzMajor = objDT.Rows[0][convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionTopicsEN.MajorName = objDT.Rows[0][convDiscussionTopics.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionTopicsEN.UserName = objDT.Rows[0][convDiscussionTopics.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvDiscussionTopicsEN.SubCount = TransNullToInt(objDT.Rows[0][convDiscussionTopics.SubCount].ToString().Trim()); //SubCount(字段类型:int,字段长度:4,是否可空:True)
 objvDiscussionTopicsEN.IdCurrEduCls = objDT.Rows[0][convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetvDiscussionTopics)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTopicsId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDiscussionTopicsEN GetObjByTopicsId(string strTopicsId)
{
CheckPrimaryKey(strTopicsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where TopicsId = " + "'"+ strTopicsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
 objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount(字段类型:int,字段长度:4,是否可空:True)
 objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetObjByTopicsId)", objException.Message));
}
return objvDiscussionTopicsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDiscussionTopicsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionTopics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN()
{
TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(), //主题Id
DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(), //讨论类型Id
DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(), //讨论类型名称
TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(), //主题标题
TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(), //主题内容
IsAudit = TransNullToBool(objRow[convDiscussionTopics.IsAudit].ToString().Trim()), //是否审核
IsTop = TransNullToBool(objRow[convDiscussionTopics.IsTop].ToString().Trim()), //是否置顶
BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()), //浏览量
UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(), //备注
CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(), //专业名称
UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(), //用户名
SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.SubCount].ToString().Trim()), //SubCount
IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objvDiscussionTopicsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDiscussionTopicsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDiscussionTopicsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = TransNullToBool(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = TransNullToBool(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetObjByDataRowvDiscussionTopics)", objException.Message));
}
objvDiscussionTopicsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDiscussionTopicsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDiscussionTopicsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = TransNullToBool(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = TransNullToBool(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDiscussionTopicsDA: GetObjByDataRow)", objException.Message));
}
objvDiscussionTopicsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDiscussionTopicsEN;
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
objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDiscussionTopicsEN._CurrTabName, convDiscussionTopics.TopicsId, 8, "");
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
objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDiscussionTopicsEN._CurrTabName, convDiscussionTopics.TopicsId, 8, strPrefix);
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicsId from vDiscussionTopics where " + strCondition;
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicsId from vDiscussionTopics where " + strCondition;
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
 /// <param name = "strTopicsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTopicsId)
{
CheckPrimaryKey(strTopicsId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDiscussionTopics", "TopicsId = " + "'"+ strTopicsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDiscussionTopicsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDiscussionTopics", strCondition))
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
objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDiscussionTopics");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDiscussionTopicsENS">源对象</param>
 /// <param name = "objvDiscussionTopicsENT">目标对象</param>
public void CopyTo(clsvDiscussionTopicsEN objvDiscussionTopicsENS, clsvDiscussionTopicsEN objvDiscussionTopicsENT)
{
objvDiscussionTopicsENT.TopicsId = objvDiscussionTopicsENS.TopicsId; //主题Id
objvDiscussionTopicsENT.DiscussionTypeId = objvDiscussionTopicsENS.DiscussionTypeId; //讨论类型Id
objvDiscussionTopicsENT.DiscussionTypeName = objvDiscussionTopicsENS.DiscussionTypeName; //讨论类型名称
objvDiscussionTopicsENT.TopicsTitle = objvDiscussionTopicsENS.TopicsTitle; //主题标题
objvDiscussionTopicsENT.TopicsContent = objvDiscussionTopicsENS.TopicsContent; //主题内容
objvDiscussionTopicsENT.IsAudit = objvDiscussionTopicsENS.IsAudit; //是否审核
objvDiscussionTopicsENT.IsTop = objvDiscussionTopicsENS.IsTop; //是否置顶
objvDiscussionTopicsENT.BrowseNumber = objvDiscussionTopicsENS.BrowseNumber; //浏览量
objvDiscussionTopicsENT.UpdDate = objvDiscussionTopicsENS.UpdDate; //修改日期
objvDiscussionTopicsENT.UpdUser = objvDiscussionTopicsENS.UpdUser; //修改人
objvDiscussionTopicsENT.Memo = objvDiscussionTopicsENS.Memo; //备注
objvDiscussionTopicsENT.CollegeName = objvDiscussionTopicsENS.CollegeName; //学院名称
objvDiscussionTopicsENT.IdXzCollege = objvDiscussionTopicsENS.IdXzCollege; //学院流水号
objvDiscussionTopicsENT.IdXzMajor = objvDiscussionTopicsENS.IdXzMajor; //专业流水号
objvDiscussionTopicsENT.MajorName = objvDiscussionTopicsENS.MajorName; //专业名称
objvDiscussionTopicsENT.UserName = objvDiscussionTopicsENS.UserName; //用户名
objvDiscussionTopicsENT.SubCount = objvDiscussionTopicsENS.SubCount; //SubCount
objvDiscussionTopicsENT.IdCurrEduCls = objvDiscussionTopicsENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.TopicsId, 8, convDiscussionTopics.TopicsId);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.DiscussionTypeId, 8, convDiscussionTopics.DiscussionTypeId);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.DiscussionTypeName, 200, convDiscussionTopics.DiscussionTypeName);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.TopicsTitle, 200, convDiscussionTopics.TopicsTitle);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.UpdDate, 20, convDiscussionTopics.UpdDate);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.UpdUser, 20, convDiscussionTopics.UpdUser);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.Memo, 1000, convDiscussionTopics.Memo);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.CollegeName, 100, convDiscussionTopics.CollegeName);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.IdXzCollege, 4, convDiscussionTopics.IdXzCollege);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.IdXzMajor, 8, convDiscussionTopics.IdXzMajor);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.MajorName, 100, convDiscussionTopics.MajorName);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.UserName, 30, convDiscussionTopics.UserName);
clsCheckSql.CheckFieldLen(objvDiscussionTopicsEN.IdCurrEduCls, 8, convDiscussionTopics.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.TopicsId, convDiscussionTopics.TopicsId);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.DiscussionTypeId, convDiscussionTopics.DiscussionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.DiscussionTypeName, convDiscussionTopics.DiscussionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.TopicsTitle, convDiscussionTopics.TopicsTitle);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.UpdDate, convDiscussionTopics.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.UpdUser, convDiscussionTopics.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.Memo, convDiscussionTopics.Memo);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.CollegeName, convDiscussionTopics.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.IdXzCollege, convDiscussionTopics.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.IdXzMajor, convDiscussionTopics.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.MajorName, convDiscussionTopics.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.UserName, convDiscussionTopics.UserName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionTopicsEN.IdCurrEduCls, convDiscussionTopics.IdCurrEduCls);
//检查外键字段长度
 objvDiscussionTopicsEN._IsCheckProperty = true;
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDiscussionTopicsEN._CurrTabName);
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDiscussionTopicsEN._CurrTabName, strCondition);
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
 objSQL = clsvDiscussionTopicsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}