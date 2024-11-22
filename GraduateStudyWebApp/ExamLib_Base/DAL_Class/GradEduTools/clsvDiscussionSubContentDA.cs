
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDiscussionSubContentDA
 表名:vDiscussionSubContent(01120585)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:53:45
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
 /// v讨论子内容视图(vDiscussionSubContent)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDiscussionSubContentDA : clsCommBase4DA
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
 return clsvDiscussionSubContentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDiscussionSubContentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDiscussionSubContentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDiscussionSubContentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDiscussionSubContentEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSubContentId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSubContentId)
{
strSubContentId = strSubContentId.Replace("'", "''");
if (strSubContentId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vDiscussionSubContent中,检查关键字,长度不正确!(clsvDiscussionSubContentDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSubContentId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDiscussionSubContent中,关键字不能为空 或 null!(clsvDiscussionSubContentDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSubContentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDiscussionSubContentDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDiscussionSubContent(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable_vDiscussionSubContent)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vDiscussionSubContent.* from vDiscussionSubContent Left Join {1} on {2} where {3} and vDiscussionSubContent.SubContentId not in (Select top {5} vDiscussionSubContent.SubContentId from vDiscussionSubContent Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1} and SubContentId not in (Select top {2} SubContentId from vDiscussionSubContent where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1} and SubContentId not in (Select top {3} SubContentId from vDiscussionSubContent where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vDiscussionSubContent.* from vDiscussionSubContent Left Join {1} on {2} where {3} and vDiscussionSubContent.SubContentId not in (Select top {5} vDiscussionSubContent.SubContentId from vDiscussionSubContent Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1} and SubContentId not in (Select top {2} SubContentId from vDiscussionSubContent where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDiscussionSubContent where {1} and SubContentId not in (Select top {3} SubContentId from vDiscussionSubContent where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDiscussionSubContentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA:GetObjLst)", objException.Message));
}
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = TransNullToBool(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetObjLst)", objException.Message));
}
objvDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDiscussionSubContentEN);
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
public List<clsvDiscussionSubContentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = TransNullToBool(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetObjLst)", objException.Message));
}
objvDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDiscussionSubContentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDiscussionSubContent(ref clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where SubContentId = " + "'"+ objvDiscussionSubContentEN.SubContentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDiscussionSubContentEN.SubContent = objDT.Rows[0][convDiscussionSubContent.SubContent].ToString().Trim(); //子内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvDiscussionSubContentEN.TopicsId = objDT.Rows[0][convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvDiscussionSubContentEN.TopicsTitle = objDT.Rows[0][convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvDiscussionSubContentEN.IsTop = TransNullToBool(objDT.Rows[0][convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvDiscussionSubContentEN.UpdDate = objDT.Rows[0][convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionSubContentEN.UpdUser = objDT.Rows[0][convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionSubContentEN.Memo = objDT.Rows[0][convDiscussionSubContent.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDiscussionSubContentEN.CollegeName = objDT.Rows[0][convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionSubContentEN.IdXzCollege = objDT.Rows[0][convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvDiscussionSubContentEN.IdXzMajor = objDT.Rows[0][convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionSubContentEN.MajorName = objDT.Rows[0][convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionSubContentEN.UserName = objDT.Rows[0][convDiscussionSubContent.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvDiscussionSubContentEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvDiscussionSubContentEN.IdCurrEduCls = objDT.Rows[0][convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionSubContentEN.ParentId = objDT.Rows[0][convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objvDiscussionSubContentEN.TopicsContent = objDT.Rows[0][convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvDiscussionSubContentEN.UserId = objDT.Rows[0][convDiscussionSubContent.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvDiscussionSubContentEN.vUpdDate = objDT.Rows[0][convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionSubContentEN.vUpdUser = objDT.Rows[0][convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser(字段类型:varchar,字段长度:50,是否可空:True)
 objvDiscussionSubContentEN.SubContentId = objDT.Rows[0][convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetvDiscussionSubContent)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSubContentId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDiscussionSubContentEN GetObjBySubContentId(string strSubContentId)
{
CheckPrimaryKey(strSubContentId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where SubContentId = " + "'"+ strSubContentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
 objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser(字段类型:varchar,字段长度:50,是否可空:True)
 objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetObjBySubContentId)", objException.Message));
}
return objvDiscussionSubContentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDiscussionSubContentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from vDiscussionSubContent where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN()
{
SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(), //子内容
TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(), //主题Id
TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(), //主题标题
IsTop = TransNullToBool(objRow[convDiscussionSubContent.IsTop].ToString().Trim()), //是否置顶
UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(), //备注
CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(), //专业名称
UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(), //用户名
BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()), //浏览量
IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(), //教学班流水号
ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(), //父节点Id
TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(), //主题内容
UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(), //用户ID
vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(), //vUpdDate
vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(), //vUpdUser
SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim() //子内容Id
};
objvDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDiscussionSubContentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDiscussionSubContentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = TransNullToBool(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetObjByDataRowvDiscussionSubContent)", objException.Message));
}
objvDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDiscussionSubContentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDiscussionSubContentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = TransNullToBool(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDiscussionSubContentDA: GetObjByDataRow)", objException.Message));
}
objvDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDiscussionSubContentEN;
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
objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDiscussionSubContentEN._CurrTabName, convDiscussionSubContent.SubContentId, 10, "");
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
objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDiscussionSubContentEN._CurrTabName, convDiscussionSubContent.SubContentId, 10, strPrefix);
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SubContentId from vDiscussionSubContent where " + strCondition;
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SubContentId from vDiscussionSubContent where " + strCondition;
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
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSubContentId)
{
CheckPrimaryKey(strSubContentId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDiscussionSubContent", "SubContentId = " + "'"+ strSubContentId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDiscussionSubContentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDiscussionSubContent", strCondition))
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
objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDiscussionSubContent");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDiscussionSubContentENS">源对象</param>
 /// <param name = "objvDiscussionSubContentENT">目标对象</param>
public void CopyTo(clsvDiscussionSubContentEN objvDiscussionSubContentENS, clsvDiscussionSubContentEN objvDiscussionSubContentENT)
{
objvDiscussionSubContentENT.SubContent = objvDiscussionSubContentENS.SubContent; //子内容
objvDiscussionSubContentENT.TopicsId = objvDiscussionSubContentENS.TopicsId; //主题Id
objvDiscussionSubContentENT.TopicsTitle = objvDiscussionSubContentENS.TopicsTitle; //主题标题
objvDiscussionSubContentENT.IsTop = objvDiscussionSubContentENS.IsTop; //是否置顶
objvDiscussionSubContentENT.UpdDate = objvDiscussionSubContentENS.UpdDate; //修改日期
objvDiscussionSubContentENT.UpdUser = objvDiscussionSubContentENS.UpdUser; //修改人
objvDiscussionSubContentENT.Memo = objvDiscussionSubContentENS.Memo; //备注
objvDiscussionSubContentENT.CollegeName = objvDiscussionSubContentENS.CollegeName; //学院名称
objvDiscussionSubContentENT.IdXzCollege = objvDiscussionSubContentENS.IdXzCollege; //学院流水号
objvDiscussionSubContentENT.IdXzMajor = objvDiscussionSubContentENS.IdXzMajor; //专业流水号
objvDiscussionSubContentENT.MajorName = objvDiscussionSubContentENS.MajorName; //专业名称
objvDiscussionSubContentENT.UserName = objvDiscussionSubContentENS.UserName; //用户名
objvDiscussionSubContentENT.BrowseNumber = objvDiscussionSubContentENS.BrowseNumber; //浏览量
objvDiscussionSubContentENT.IdCurrEduCls = objvDiscussionSubContentENS.IdCurrEduCls; //教学班流水号
objvDiscussionSubContentENT.ParentId = objvDiscussionSubContentENS.ParentId; //父节点Id
objvDiscussionSubContentENT.TopicsContent = objvDiscussionSubContentENS.TopicsContent; //主题内容
objvDiscussionSubContentENT.UserId = objvDiscussionSubContentENS.UserId; //用户ID
objvDiscussionSubContentENT.vUpdDate = objvDiscussionSubContentENS.vUpdDate; //vUpdDate
objvDiscussionSubContentENT.vUpdUser = objvDiscussionSubContentENS.vUpdUser; //vUpdUser
objvDiscussionSubContentENT.SubContentId = objvDiscussionSubContentENS.SubContentId; //子内容Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.TopicsId, 8, convDiscussionSubContent.TopicsId);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.TopicsTitle, 200, convDiscussionSubContent.TopicsTitle);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.UpdDate, 20, convDiscussionSubContent.UpdDate);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.UpdUser, 20, convDiscussionSubContent.UpdUser);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.Memo, 1000, convDiscussionSubContent.Memo);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.CollegeName, 100, convDiscussionSubContent.CollegeName);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.IdXzCollege, 4, convDiscussionSubContent.IdXzCollege);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.IdXzMajor, 8, convDiscussionSubContent.IdXzMajor);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.MajorName, 100, convDiscussionSubContent.MajorName);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.UserName, 30, convDiscussionSubContent.UserName);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.IdCurrEduCls, 8, convDiscussionSubContent.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.ParentId, 10, convDiscussionSubContent.ParentId);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.UserId, 18, convDiscussionSubContent.UserId);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.vUpdDate, 20, convDiscussionSubContent.vUpdDate);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.vUpdUser, 50, convDiscussionSubContent.vUpdUser);
clsCheckSql.CheckFieldLen(objvDiscussionSubContentEN.SubContentId, 10, convDiscussionSubContent.SubContentId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.TopicsId, convDiscussionSubContent.TopicsId);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.TopicsTitle, convDiscussionSubContent.TopicsTitle);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.UpdDate, convDiscussionSubContent.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.UpdUser, convDiscussionSubContent.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.Memo, convDiscussionSubContent.Memo);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.CollegeName, convDiscussionSubContent.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.IdXzCollege, convDiscussionSubContent.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.IdXzMajor, convDiscussionSubContent.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.MajorName, convDiscussionSubContent.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.UserName, convDiscussionSubContent.UserName);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.IdCurrEduCls, convDiscussionSubContent.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.ParentId, convDiscussionSubContent.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.UserId, convDiscussionSubContent.UserId);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.vUpdDate, convDiscussionSubContent.vUpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.vUpdUser, convDiscussionSubContent.vUpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDiscussionSubContentEN.SubContentId, convDiscussionSubContent.SubContentId);
//检查外键字段长度
 objvDiscussionSubContentEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vDiscussionSubContent(v讨论子内容视图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SubContentId = '{0}'", objvDiscussionSubContentEN.SubContentId);
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDiscussionSubContentEN._CurrTabName);
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDiscussionSubContentEN._CurrTabName, strCondition);
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
 objSQL = clsvDiscussionSubContentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}