
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscussionSubContentDA
 表名:DiscussionSubContent(01120587)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 讨论子内容(DiscussionSubContent)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDiscussionSubContentDA : clsCommBase4DA
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
 return clsDiscussionSubContentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDiscussionSubContentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDiscussionSubContentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDiscussionSubContentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDiscussionSubContentEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:DiscussionSubContent中,检查关键字,长度不正确!(clsDiscussionSubContentDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSubContentId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DiscussionSubContent中,关键字不能为空 或 null!(clsDiscussionSubContentDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSubContentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDiscussionSubContentDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DiscussionSubContent(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable_DiscussionSubContent)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DiscussionSubContent.* from DiscussionSubContent Left Join {1} on {2} where {3} and DiscussionSubContent.SubContentId not in (Select top {5} DiscussionSubContent.SubContentId from DiscussionSubContent Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1} and SubContentId not in (Select top {2} SubContentId from DiscussionSubContent where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1} and SubContentId not in (Select top {3} SubContentId from DiscussionSubContent where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DiscussionSubContent.* from DiscussionSubContent Left Join {1} on {2} where {3} and DiscussionSubContent.SubContentId not in (Select top {5} DiscussionSubContent.SubContentId from DiscussionSubContent Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1} and SubContentId not in (Select top {2} SubContentId from DiscussionSubContent where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DiscussionSubContent where {1} and SubContentId not in (Select top {3} SubContentId from DiscussionSubContent where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDiscussionSubContentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA:GetObjLst)", objException.Message));
}
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = TransNullToBool(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDiscussionSubContentDA: GetObjLst)", objException.Message));
}
objDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDiscussionSubContentEN);
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
public List<clsDiscussionSubContentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA:GetObjLstByTabName)", objException.Message));
}
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = TransNullToBool(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDiscussionSubContentDA: GetObjLst)", objException.Message));
}
objDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDiscussionSubContentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDiscussionSubContent(ref clsDiscussionSubContentEN objDiscussionSubContentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where SubContentId = " + "'"+ objDiscussionSubContentEN.SubContentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDiscussionSubContentEN.SubContentId = objDT.Rows[0][conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id(字段类型:char,字段长度:10,是否可空:False)
 objDiscussionSubContentEN.SubContent = objDT.Rows[0][conDiscussionSubContent.SubContent].ToString().Trim(); //子内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objDiscussionSubContentEN.TopicsId = objDT.Rows[0][conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objDiscussionSubContentEN.IsTop = TransNullToBool(objDT.Rows[0][conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objDiscussionSubContentEN.UpdDate = objDT.Rows[0][conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDiscussionSubContentEN.UpdUser = objDT.Rows[0][conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objDiscussionSubContentEN.Memo = objDT.Rows[0][conDiscussionSubContent.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objDiscussionSubContentEN.ParentId = objDT.Rows[0][conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objDiscussionSubContentEN.UserId = objDT.Rows[0][conDiscussionSubContent.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDiscussionSubContentDA: GetDiscussionSubContent)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSubContentId">表关键字</param>
 /// <returns>表对象</returns>
public clsDiscussionSubContentEN GetObjBySubContentId(string strSubContentId)
{
CheckPrimaryKey(strSubContentId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where SubContentId = " + "'"+ strSubContentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
 objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id(字段类型:char,字段长度:10,是否可空:False)
 objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDiscussionSubContentDA: GetObjBySubContentId)", objException.Message));
}
return objDiscussionSubContentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDiscussionSubContentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN()
{
SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(), //子内容Id
SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(), //子内容
TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(), //主题Id
IsTop = TransNullToBool(objRow[conDiscussionSubContent.IsTop].ToString().Trim()), //是否置顶
UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(), //备注
ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(), //父节点Id
UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim() //用户ID
};
objDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDiscussionSubContentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDiscussionSubContentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDiscussionSubContentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = TransNullToBool(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDiscussionSubContentDA: GetObjByDataRowDiscussionSubContent)", objException.Message));
}
objDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDiscussionSubContentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDiscussionSubContentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = TransNullToBool(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDiscussionSubContentDA: GetObjByDataRow)", objException.Message));
}
objDiscussionSubContentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDiscussionSubContentEN;
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
objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDiscussionSubContentEN._CurrTabName, conDiscussionSubContent.SubContentId, 10, "");
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
objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDiscussionSubContentEN._CurrTabName, conDiscussionSubContent.SubContentId, 10, strPrefix);
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SubContentId from DiscussionSubContent where " + strCondition;
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SubContentId from DiscussionSubContent where " + strCondition;
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DiscussionSubContent", "SubContentId = " + "'"+ strSubContentId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DiscussionSubContent", strCondition))
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
objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DiscussionSubContent");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDiscussionSubContentEN objDiscussionSubContentEN)
 {
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDiscussionSubContentEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DiscussionSubContent");
objRow = objDS.Tables["DiscussionSubContent"].NewRow();
objRow[conDiscussionSubContent.SubContentId] = objDiscussionSubContentEN.SubContentId; //子内容Id
 if (objDiscussionSubContentEN.SubContent !=  "")
 {
objRow[conDiscussionSubContent.SubContent] = objDiscussionSubContentEN.SubContent; //子内容
 }
 if (objDiscussionSubContentEN.TopicsId !=  "")
 {
objRow[conDiscussionSubContent.TopicsId] = objDiscussionSubContentEN.TopicsId; //主题Id
 }
objRow[conDiscussionSubContent.IsTop] = objDiscussionSubContentEN.IsTop; //是否置顶
 if (objDiscussionSubContentEN.UpdDate !=  "")
 {
objRow[conDiscussionSubContent.UpdDate] = objDiscussionSubContentEN.UpdDate; //修改日期
 }
 if (objDiscussionSubContentEN.UpdUser !=  "")
 {
objRow[conDiscussionSubContent.UpdUser] = objDiscussionSubContentEN.UpdUser; //修改人
 }
 if (objDiscussionSubContentEN.Memo !=  "")
 {
objRow[conDiscussionSubContent.Memo] = objDiscussionSubContentEN.Memo; //备注
 }
 if (objDiscussionSubContentEN.ParentId !=  "")
 {
objRow[conDiscussionSubContent.ParentId] = objDiscussionSubContentEN.ParentId; //父节点Id
 }
 if (objDiscussionSubContentEN.UserId !=  "")
 {
objRow[conDiscussionSubContent.UserId] = objDiscussionSubContentEN.UserId; //用户ID
 }
objDS.Tables[clsDiscussionSubContentEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDiscussionSubContentEN._CurrTabName);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDiscussionSubContentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDiscussionSubContentEN.SubContentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContentId);
 var strSubContentId = objDiscussionSubContentEN.SubContentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContentId + "'");
 }
 
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContent);
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContent + "'");
 }
 
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.TopicsId);
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicsId + "'");
 }
 
 arrFieldListForInsert.Add(conDiscussionSubContent.IsTop);
 arrValueListForInsert.Add("'" + (objDiscussionSubContentEN.IsTop  ==  false ? "0" : "1") + "'");
 
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdDate);
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdUser);
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.Memo);
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.ParentId);
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UserId);
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DiscussionSubContent");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDiscussionSubContentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDiscussionSubContentEN.SubContentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContentId);
 var strSubContentId = objDiscussionSubContentEN.SubContentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContentId + "'");
 }
 
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContent);
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContent + "'");
 }
 
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.TopicsId);
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicsId + "'");
 }
 
 arrFieldListForInsert.Add(conDiscussionSubContent.IsTop);
 arrValueListForInsert.Add("'" + (objDiscussionSubContentEN.IsTop  ==  false ? "0" : "1") + "'");
 
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdDate);
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdUser);
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.Memo);
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.ParentId);
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UserId);
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DiscussionSubContent");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDiscussionSubContentEN.SubContentId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDiscussionSubContentEN objDiscussionSubContentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDiscussionSubContentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDiscussionSubContentEN.SubContentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContentId);
 var strSubContentId = objDiscussionSubContentEN.SubContentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContentId + "'");
 }
 
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContent);
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContent + "'");
 }
 
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.TopicsId);
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicsId + "'");
 }
 
 arrFieldListForInsert.Add(conDiscussionSubContent.IsTop);
 arrValueListForInsert.Add("'" + (objDiscussionSubContentEN.IsTop  ==  false ? "0" : "1") + "'");
 
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdDate);
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdUser);
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.Memo);
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.ParentId);
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UserId);
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DiscussionSubContent");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDiscussionSubContentEN.SubContentId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDiscussionSubContentEN objDiscussionSubContentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDiscussionSubContentEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDiscussionSubContentEN.SubContentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContentId);
 var strSubContentId = objDiscussionSubContentEN.SubContentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContentId + "'");
 }
 
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.SubContent);
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubContent + "'");
 }
 
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.TopicsId);
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicsId + "'");
 }
 
 arrFieldListForInsert.Add(conDiscussionSubContent.IsTop);
 arrValueListForInsert.Add("'" + (objDiscussionSubContentEN.IsTop  ==  false ? "0" : "1") + "'");
 
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdDate);
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UpdUser);
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.Memo);
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.ParentId);
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDiscussionSubContent.UserId);
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DiscussionSubContent");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDiscussionSubContents(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where SubContentId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DiscussionSubContent");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strSubContentId = oRow[conDiscussionSubContent.SubContentId].ToString().Trim();
if (IsExist(strSubContentId))
{
 string strResult = "关键字变量值为:" + string.Format("SubContentId = {0}", strSubContentId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDiscussionSubContentEN._CurrTabName ].NewRow();
objRow[conDiscussionSubContent.SubContentId] = oRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objRow[conDiscussionSubContent.SubContent] = oRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objRow[conDiscussionSubContent.TopicsId] = oRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objRow[conDiscussionSubContent.IsTop] = oRow[conDiscussionSubContent.IsTop].ToString().Trim(); //是否置顶
objRow[conDiscussionSubContent.UpdDate] = oRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objRow[conDiscussionSubContent.UpdUser] = oRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objRow[conDiscussionSubContent.Memo] = oRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objRow[conDiscussionSubContent.ParentId] = oRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objRow[conDiscussionSubContent.UserId] = oRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
 objDS.Tables[clsDiscussionSubContentEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDiscussionSubContentEN._CurrTabName);
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
 /// <param name = "objDiscussionSubContentEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDiscussionSubContentEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
strSQL = "Select * from DiscussionSubContent where SubContentId = " + "'"+ objDiscussionSubContentEN.SubContentId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDiscussionSubContentEN._CurrTabName);
if (objDS.Tables[clsDiscussionSubContentEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SubContentId = " + "'"+ objDiscussionSubContentEN.SubContentId+"'");
return false;
}
objRow = objDS.Tables[clsDiscussionSubContentEN._CurrTabName].Rows[0];
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.SubContentId))
 {
objRow[conDiscussionSubContent.SubContentId] = objDiscussionSubContentEN.SubContentId; //子内容Id
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.SubContent))
 {
objRow[conDiscussionSubContent.SubContent] = objDiscussionSubContentEN.SubContent; //子内容
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.TopicsId))
 {
objRow[conDiscussionSubContent.TopicsId] = objDiscussionSubContentEN.TopicsId; //主题Id
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.IsTop))
 {
objRow[conDiscussionSubContent.IsTop] = objDiscussionSubContentEN.IsTop; //是否置顶
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdDate))
 {
objRow[conDiscussionSubContent.UpdDate] = objDiscussionSubContentEN.UpdDate; //修改日期
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdUser))
 {
objRow[conDiscussionSubContent.UpdUser] = objDiscussionSubContentEN.UpdUser; //修改人
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.Memo))
 {
objRow[conDiscussionSubContent.Memo] = objDiscussionSubContentEN.Memo; //备注
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.ParentId))
 {
objRow[conDiscussionSubContent.ParentId] = objDiscussionSubContentEN.ParentId; //父节点Id
 }
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UserId))
 {
objRow[conDiscussionSubContent.UserId] = objDiscussionSubContentEN.UserId; //用户ID
 }
try
{
objDA.Update(objDS, clsDiscussionSubContentEN._CurrTabName);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDiscussionSubContentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DiscussionSubContent Set ");
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.SubContent))
 {
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubContent, conDiscussionSubContent.SubContent); //子内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.SubContent); //子内容
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.TopicsId))
 {
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicsId, conDiscussionSubContent.TopicsId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.TopicsId); //主题Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.IsTop))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDiscussionSubContentEN.IsTop == true?"1":"0", conDiscussionSubContent.IsTop); //是否置顶
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdDate))
 {
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDiscussionSubContent.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.UpdDate); //修改日期
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdUser))
 {
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDiscussionSubContent.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.UpdUser); //修改人
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.Memo))
 {
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDiscussionSubContent.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.Memo); //备注
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.ParentId))
 {
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conDiscussionSubContent.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.ParentId); //父节点Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UserId))
 {
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conDiscussionSubContent.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SubContentId = '{0}'", objDiscussionSubContentEN.SubContentId); 
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
 /// <param name = "objDiscussionSubContentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDiscussionSubContentEN objDiscussionSubContentEN, string strCondition)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDiscussionSubContentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DiscussionSubContent Set ");
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.SubContent))
 {
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubContent = '{0}',", strSubContent); //子内容
 }
 else
 {
 sbSQL.Append(" SubContent = null,"); //子内容
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.TopicsId))
 {
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicsId = '{0}',", strTopicsId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicsId = null,"); //主题Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.IsTop))
 {
 sbSQL.AppendFormat(" IsTop = '{0}',", objDiscussionSubContentEN.IsTop == true?"1":"0"); //是否置顶
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdDate))
 {
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdUser))
 {
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.Memo))
 {
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.ParentId))
 {
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UserId))
 {
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objDiscussionSubContentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDiscussionSubContentEN objDiscussionSubContentEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDiscussionSubContentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DiscussionSubContent Set ");
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.SubContent))
 {
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubContent = '{0}',", strSubContent); //子内容
 }
 else
 {
 sbSQL.Append(" SubContent = null,"); //子内容
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.TopicsId))
 {
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicsId = '{0}',", strTopicsId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicsId = null,"); //主题Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.IsTop))
 {
 sbSQL.AppendFormat(" IsTop = '{0}',", objDiscussionSubContentEN.IsTop == true?"1":"0"); //是否置顶
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdDate))
 {
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdUser))
 {
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.Memo))
 {
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.ParentId))
 {
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UserId))
 {
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDiscussionSubContentEN objDiscussionSubContentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDiscussionSubContentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDiscussionSubContentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DiscussionSubContent Set ");
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.SubContent))
 {
 if (objDiscussionSubContentEN.SubContent !=  null)
 {
 var strSubContent = objDiscussionSubContentEN.SubContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubContent, conDiscussionSubContent.SubContent); //子内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.SubContent); //子内容
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.TopicsId))
 {
 if (objDiscussionSubContentEN.TopicsId  ==  "")
 {
 objDiscussionSubContentEN.TopicsId = null;
 }
 if (objDiscussionSubContentEN.TopicsId !=  null)
 {
 var strTopicsId = objDiscussionSubContentEN.TopicsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicsId, conDiscussionSubContent.TopicsId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.TopicsId); //主题Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.IsTop))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDiscussionSubContentEN.IsTop == true?"1":"0", conDiscussionSubContent.IsTop); //是否置顶
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdDate))
 {
 if (objDiscussionSubContentEN.UpdDate !=  null)
 {
 var strUpdDate = objDiscussionSubContentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDiscussionSubContent.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.UpdDate); //修改日期
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UpdUser))
 {
 if (objDiscussionSubContentEN.UpdUser !=  null)
 {
 var strUpdUser = objDiscussionSubContentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDiscussionSubContent.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.UpdUser); //修改人
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.Memo))
 {
 if (objDiscussionSubContentEN.Memo !=  null)
 {
 var strMemo = objDiscussionSubContentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDiscussionSubContent.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.Memo); //备注
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.ParentId))
 {
 if (objDiscussionSubContentEN.ParentId !=  null)
 {
 var strParentId = objDiscussionSubContentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conDiscussionSubContent.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.ParentId); //父节点Id
 }
 }
 
 if (objDiscussionSubContentEN.IsUpdated(conDiscussionSubContent.UserId))
 {
 if (objDiscussionSubContentEN.UserId !=  null)
 {
 var strUserId = objDiscussionSubContentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conDiscussionSubContent.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDiscussionSubContent.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SubContentId = '{0}'", objDiscussionSubContentEN.SubContentId); 
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
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSubContentId) 
{
CheckPrimaryKey(strSubContentId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strSubContentId,
};
 objSQL.ExecSP("DiscussionSubContent_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strSubContentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strSubContentId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
//删除DiscussionSubContent本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DiscussionSubContent where SubContentId = " + "'"+ strSubContentId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDiscussionSubContent(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
//删除DiscussionSubContent本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DiscussionSubContent where SubContentId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strSubContentId) 
{
CheckPrimaryKey(strSubContentId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
//删除DiscussionSubContent本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DiscussionSubContent where SubContentId = " + "'"+ strSubContentId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDiscussionSubContent(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: DelDiscussionSubContent)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DiscussionSubContent where " + strCondition ;
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
public bool DelDiscussionSubContentWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDiscussionSubContentDA: DelDiscussionSubContentWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DiscussionSubContent where " + strCondition ;
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
 /// <param name = "objDiscussionSubContentENS">源对象</param>
 /// <param name = "objDiscussionSubContentENT">目标对象</param>
public void CopyTo(clsDiscussionSubContentEN objDiscussionSubContentENS, clsDiscussionSubContentEN objDiscussionSubContentENT)
{
objDiscussionSubContentENT.SubContentId = objDiscussionSubContentENS.SubContentId; //子内容Id
objDiscussionSubContentENT.SubContent = objDiscussionSubContentENS.SubContent; //子内容
objDiscussionSubContentENT.TopicsId = objDiscussionSubContentENS.TopicsId; //主题Id
objDiscussionSubContentENT.IsTop = objDiscussionSubContentENS.IsTop; //是否置顶
objDiscussionSubContentENT.UpdDate = objDiscussionSubContentENS.UpdDate; //修改日期
objDiscussionSubContentENT.UpdUser = objDiscussionSubContentENS.UpdUser; //修改人
objDiscussionSubContentENT.Memo = objDiscussionSubContentENS.Memo; //备注
objDiscussionSubContentENT.ParentId = objDiscussionSubContentENS.ParentId; //父节点Id
objDiscussionSubContentENT.UserId = objDiscussionSubContentENS.UserId; //用户ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.SubContentId, 10, conDiscussionSubContent.SubContentId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.TopicsId, 8, conDiscussionSubContent.TopicsId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UpdDate, 20, conDiscussionSubContent.UpdDate);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UpdUser, 20, conDiscussionSubContent.UpdUser);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.Memo, 1000, conDiscussionSubContent.Memo);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.ParentId, 10, conDiscussionSubContent.ParentId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UserId, 18, conDiscussionSubContent.UserId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objDiscussionSubContentEN.TopicsId, 8, conDiscussionSubContent.TopicsId);
 objDiscussionSubContentEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.TopicsId, 8, conDiscussionSubContent.TopicsId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UpdDate, 20, conDiscussionSubContent.UpdDate);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UpdUser, 20, conDiscussionSubContent.UpdUser);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.Memo, 1000, conDiscussionSubContent.Memo);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.ParentId, 10, conDiscussionSubContent.ParentId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UserId, 18, conDiscussionSubContent.UserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDiscussionSubContentEN.TopicsId, 8, conDiscussionSubContent.TopicsId);
 objDiscussionSubContentEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.SubContentId, 10, conDiscussionSubContent.SubContentId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.TopicsId, 8, conDiscussionSubContent.TopicsId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UpdDate, 20, conDiscussionSubContent.UpdDate);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UpdUser, 20, conDiscussionSubContent.UpdUser);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.Memo, 1000, conDiscussionSubContent.Memo);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.ParentId, 10, conDiscussionSubContent.ParentId);
clsCheckSql.CheckFieldLen(objDiscussionSubContentEN.UserId, 18, conDiscussionSubContent.UserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.SubContentId, conDiscussionSubContent.SubContentId);
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.TopicsId, conDiscussionSubContent.TopicsId);
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.UpdDate, conDiscussionSubContent.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.UpdUser, conDiscussionSubContent.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.Memo, conDiscussionSubContent.Memo);
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.ParentId, conDiscussionSubContent.ParentId);
clsCheckSql.CheckSqlInjection4Field(objDiscussionSubContentEN.UserId, conDiscussionSubContent.UserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDiscussionSubContentEN.TopicsId, 8, conDiscussionSubContent.TopicsId);
 objDiscussionSubContentEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DiscussionSubContent(讨论子内容),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objDiscussionSubContentEN.SubContent == null)
{
 sbCondition.AppendFormat(" and SubContent is null");
}
else
{
 sbCondition.AppendFormat(" and SubContent = '{0}'", objDiscussionSubContentEN.SubContent);
}
 if (objDiscussionSubContentEN.TopicsId == null)
{
 sbCondition.AppendFormat(" and TopicsId is null");
}
else
{
 sbCondition.AppendFormat(" and TopicsId = '{0}'", objDiscussionSubContentEN.TopicsId);
}
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDiscussionSubContentEN._CurrTabName);
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDiscussionSubContentEN._CurrTabName, strCondition);
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
 objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}