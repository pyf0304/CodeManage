
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointCitationDA
 表名:zx_ViewpointCitation(01120860)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:05:41
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
 /// 中学观点引用关系(zx_ViewpointCitation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ViewpointCitationDA : clsCommBase4DA
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
 return clszx_ViewpointCitationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ViewpointCitationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointCitationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ViewpointCitationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ViewpointCitationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_ViewpointCitation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable_zx_ViewpointCitation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ViewpointCitation.* from zx_ViewpointCitation Left Join {1} on {2} where {3} and zx_ViewpointCitation.mId not in (Select top {5} zx_ViewpointCitation.mId from zx_ViewpointCitation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1} and mId not in (Select top {2} mId from zx_ViewpointCitation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1} and mId not in (Select top {3} mId from zx_ViewpointCitation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ViewpointCitation.* from zx_ViewpointCitation Left Join {1} on {2} where {3} and zx_ViewpointCitation.mId not in (Select top {5} zx_ViewpointCitation.mId from zx_ViewpointCitation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1} and mId not in (Select top {2} mId from zx_ViewpointCitation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointCitation where {1} and mId not in (Select top {3} mId from zx_ViewpointCitation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ViewpointCitationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA:GetObjLst)", objException.Message));
}
List<clszx_ViewpointCitationEN> arrObjLst = new List<clszx_ViewpointCitationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointCitationEN objzx_ViewpointCitationEN = new clszx_ViewpointCitationEN();
try
{
objzx_ViewpointCitationEN.mId = TransNullToInt(objRow[conzx_ViewpointCitation.mId].ToString().Trim()); //mId
objzx_ViewpointCitationEN.zxViewpointId = objRow[conzx_ViewpointCitation.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointCitationEN.TextId = objRow[conzx_ViewpointCitation.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id
objzx_ViewpointCitationEN.UpdUserId = objRow[conzx_ViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointCitationEN.Memo = objRow[conzx_ViewpointCitation.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.Memo].ToString().Trim(); //备注
objzx_ViewpointCitationEN.UpdDate = objRow[conzx_ViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ViewpointCitationDA: GetObjLst)", objException.Message));
}
objzx_ViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ViewpointCitationEN);
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
public List<clszx_ViewpointCitationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ViewpointCitationEN> arrObjLst = new List<clszx_ViewpointCitationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointCitationEN objzx_ViewpointCitationEN = new clszx_ViewpointCitationEN();
try
{
objzx_ViewpointCitationEN.mId = TransNullToInt(objRow[conzx_ViewpointCitation.mId].ToString().Trim()); //mId
objzx_ViewpointCitationEN.zxViewpointId = objRow[conzx_ViewpointCitation.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointCitationEN.TextId = objRow[conzx_ViewpointCitation.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id
objzx_ViewpointCitationEN.UpdUserId = objRow[conzx_ViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointCitationEN.Memo = objRow[conzx_ViewpointCitation.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.Memo].ToString().Trim(); //备注
objzx_ViewpointCitationEN.UpdDate = objRow[conzx_ViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ViewpointCitationDA: GetObjLst)", objException.Message));
}
objzx_ViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ViewpointCitationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ViewpointCitationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_ViewpointCitation(ref clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where mId = " + ""+ objzx_ViewpointCitationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ViewpointCitationEN.mId = TransNullToInt(objDT.Rows[0][conzx_ViewpointCitation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_ViewpointCitationEN.zxViewpointId = objDT.Rows[0][conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_ViewpointCitationEN.TextId = objDT.Rows[0][conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointCitationEN.UpdUserId = objDT.Rows[0][conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointCitationEN.Memo = objDT.Rows[0][conzx_ViewpointCitation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ViewpointCitationEN.UpdDate = objDT.Rows[0][conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ViewpointCitationDA: Getzx_ViewpointCitation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ViewpointCitationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ViewpointCitationEN objzx_ViewpointCitationEN = new clszx_ViewpointCitationEN();
try
{
 objzx_ViewpointCitationEN.mId = Int32.Parse(objRow[conzx_ViewpointCitation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_ViewpointCitationEN.zxViewpointId = objRow[conzx_ViewpointCitation.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_ViewpointCitationEN.TextId = objRow[conzx_ViewpointCitation.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointCitationEN.UpdUserId = objRow[conzx_ViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointCitationEN.Memo = objRow[conzx_ViewpointCitation.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ViewpointCitationEN.UpdDate = objRow[conzx_ViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ViewpointCitationDA: GetObjBymId)", objException.Message));
}
return objzx_ViewpointCitationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ViewpointCitationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ViewpointCitationEN objzx_ViewpointCitationEN = new clszx_ViewpointCitationEN()
{
mId = TransNullToInt(objRow[conzx_ViewpointCitation.mId].ToString().Trim()), //mId
zxViewpointId = objRow[conzx_ViewpointCitation.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(), //观点Id
TextId = objRow[conzx_ViewpointCitation.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.TextId].ToString().Trim(), //课件Id
UpdUserId = objRow[conzx_ViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conzx_ViewpointCitation.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.Memo].ToString().Trim(), //备注
UpdDate = objRow[conzx_ViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdDate].ToString().Trim() //修改日期
};
objzx_ViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointCitationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ViewpointCitationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ViewpointCitationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ViewpointCitationEN objzx_ViewpointCitationEN = new clszx_ViewpointCitationEN();
try
{
objzx_ViewpointCitationEN.mId = TransNullToInt(objRow[conzx_ViewpointCitation.mId].ToString().Trim()); //mId
objzx_ViewpointCitationEN.zxViewpointId = objRow[conzx_ViewpointCitation.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointCitationEN.TextId = objRow[conzx_ViewpointCitation.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id
objzx_ViewpointCitationEN.UpdUserId = objRow[conzx_ViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointCitationEN.Memo = objRow[conzx_ViewpointCitation.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.Memo].ToString().Trim(); //备注
objzx_ViewpointCitationEN.UpdDate = objRow[conzx_ViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ViewpointCitationDA: GetObjByDataRowzx_ViewpointCitation)", objException.Message));
}
objzx_ViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointCitationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ViewpointCitationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ViewpointCitationEN objzx_ViewpointCitationEN = new clszx_ViewpointCitationEN();
try
{
objzx_ViewpointCitationEN.mId = TransNullToInt(objRow[conzx_ViewpointCitation.mId].ToString().Trim()); //mId
objzx_ViewpointCitationEN.zxViewpointId = objRow[conzx_ViewpointCitation.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointCitationEN.TextId = objRow[conzx_ViewpointCitation.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id
objzx_ViewpointCitationEN.UpdUserId = objRow[conzx_ViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointCitationEN.Memo = objRow[conzx_ViewpointCitation.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.Memo].ToString().Trim(); //备注
objzx_ViewpointCitationEN.UpdDate = objRow[conzx_ViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ViewpointCitationDA: GetObjByDataRow)", objException.Message));
}
objzx_ViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointCitationEN;
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
objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ViewpointCitationEN._CurrTabName, conzx_ViewpointCitation.mId, 8, "");
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
objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ViewpointCitationEN._CurrTabName, conzx_ViewpointCitation.mId, 8, strPrefix);
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from zx_ViewpointCitation where " + strCondition;
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from zx_ViewpointCitation where " + strCondition;
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ViewpointCitation", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ViewpointCitation", strCondition))
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
objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_ViewpointCitation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
 {
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointCitationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ViewpointCitation");
objRow = objDS.Tables["zx_ViewpointCitation"].NewRow();
 if (objzx_ViewpointCitationEN.zxViewpointId !=  "")
 {
objRow[conzx_ViewpointCitation.zxViewpointId] = objzx_ViewpointCitationEN.zxViewpointId; //观点Id
 }
 if (objzx_ViewpointCitationEN.TextId !=  "")
 {
objRow[conzx_ViewpointCitation.TextId] = objzx_ViewpointCitationEN.TextId; //课件Id
 }
 if (objzx_ViewpointCitationEN.UpdUserId !=  "")
 {
objRow[conzx_ViewpointCitation.UpdUserId] = objzx_ViewpointCitationEN.UpdUserId; //修改用户Id
 }
 if (objzx_ViewpointCitationEN.Memo !=  "")
 {
objRow[conzx_ViewpointCitation.Memo] = objzx_ViewpointCitationEN.Memo; //备注
 }
 if (objzx_ViewpointCitationEN.UpdDate !=  "")
 {
objRow[conzx_ViewpointCitation.UpdDate] = objzx_ViewpointCitationEN.UpdDate; //修改日期
 }
objDS.Tables[clszx_ViewpointCitationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ViewpointCitationEN._CurrTabName);
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
 /// <param name = "objzx_ViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointCitationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.TextId);
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdUserId);
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.Memo);
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdDate);
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointCitationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.TextId);
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdUserId);
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.Memo);
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdDate);
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ViewpointCitationEN objzx_ViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointCitationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.TextId);
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdUserId);
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.Memo);
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdDate);
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ViewpointCitationEN objzx_ViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointCitationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.TextId);
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdUserId);
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.Memo);
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointCitation.UpdDate);
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_ViewpointCitations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ViewpointCitation");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ViewpointCitationEN._CurrTabName ].NewRow();
objRow[conzx_ViewpointCitation.zxViewpointId] = oRow[conzx_ViewpointCitation.zxViewpointId].ToString().Trim(); //观点Id
objRow[conzx_ViewpointCitation.TextId] = oRow[conzx_ViewpointCitation.TextId].ToString().Trim(); //课件Id
objRow[conzx_ViewpointCitation.UpdUserId] = oRow[conzx_ViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conzx_ViewpointCitation.Memo] = oRow[conzx_ViewpointCitation.Memo].ToString().Trim(); //备注
objRow[conzx_ViewpointCitation.UpdDate] = oRow[conzx_ViewpointCitation.UpdDate].ToString().Trim(); //修改日期
 objDS.Tables[clszx_ViewpointCitationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ViewpointCitationEN._CurrTabName);
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
 /// <param name = "objzx_ViewpointCitationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointCitationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointCitation where mId = " + ""+ objzx_ViewpointCitationEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ViewpointCitationEN._CurrTabName);
if (objDS.Tables[clszx_ViewpointCitationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objzx_ViewpointCitationEN.mId+"");
return false;
}
objRow = objDS.Tables[clszx_ViewpointCitationEN._CurrTabName].Rows[0];
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.zxViewpointId))
 {
objRow[conzx_ViewpointCitation.zxViewpointId] = objzx_ViewpointCitationEN.zxViewpointId; //观点Id
 }
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.TextId))
 {
objRow[conzx_ViewpointCitation.TextId] = objzx_ViewpointCitationEN.TextId; //课件Id
 }
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdUserId))
 {
objRow[conzx_ViewpointCitation.UpdUserId] = objzx_ViewpointCitationEN.UpdUserId; //修改用户Id
 }
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.Memo))
 {
objRow[conzx_ViewpointCitation.Memo] = objzx_ViewpointCitationEN.Memo; //备注
 }
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdDate))
 {
objRow[conzx_ViewpointCitation.UpdDate] = objzx_ViewpointCitationEN.UpdDate; //修改日期
 }
try
{
objDA.Update(objDS, clszx_ViewpointCitationEN._CurrTabName);
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
 /// <param name = "objzx_ViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_ViewpointCitation Set ");
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.zxViewpointId))
 {
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointId, conzx_ViewpointCitation.zxViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.zxViewpointId); //观点Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.TextId))
 {
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ViewpointCitation.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.TextId); //课件Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdUserId))
 {
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conzx_ViewpointCitation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.UpdUserId); //修改用户Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.Memo))
 {
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ViewpointCitation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.Memo); //备注
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdDate))
 {
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ViewpointCitation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.UpdDate); //修改日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objzx_ViewpointCitationEN.mId); 
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
 /// <param name = "objzx_ViewpointCitationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ViewpointCitationEN objzx_ViewpointCitationEN, string strCondition)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ViewpointCitation Set ");
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.zxViewpointId))
 {
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointId = '{0}',", strzxViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" zxViewpointId = null,"); //观点Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.TextId))
 {
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdUserId))
 {
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.Memo))
 {
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdDate))
 {
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
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
 /// <param name = "objzx_ViewpointCitationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ViewpointCitationEN objzx_ViewpointCitationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ViewpointCitation Set ");
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.zxViewpointId))
 {
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointId = '{0}',", strzxViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" zxViewpointId = null,"); //观点Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.TextId))
 {
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdUserId))
 {
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.Memo))
 {
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdDate))
 {
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
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
 /// <param name = "objzx_ViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ViewpointCitationEN objzx_ViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objzx_ViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_ViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ViewpointCitation Set ");
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.zxViewpointId))
 {
 if (objzx_ViewpointCitationEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointCitationEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointId, conzx_ViewpointCitation.zxViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.zxViewpointId); //观点Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.TextId))
 {
 if (objzx_ViewpointCitationEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointCitationEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ViewpointCitation.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.TextId); //课件Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdUserId))
 {
 if (objzx_ViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objzx_ViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conzx_ViewpointCitation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.UpdUserId); //修改用户Id
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.Memo))
 {
 if (objzx_ViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ViewpointCitation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.Memo); //备注
 }
 }
 
 if (objzx_ViewpointCitationEN.IsUpdated(conzx_ViewpointCitation.UpdDate))
 {
 if (objzx_ViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ViewpointCitation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointCitation.UpdDate); //修改日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objzx_ViewpointCitationEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("zx_ViewpointCitation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
//删除zx_ViewpointCitation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ViewpointCitation where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_ViewpointCitation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除zx_ViewpointCitation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ViewpointCitation where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
//删除zx_ViewpointCitation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ViewpointCitation where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_ViewpointCitation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: Delzx_ViewpointCitation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ViewpointCitation where " + strCondition ;
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
public bool Delzx_ViewpointCitationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ViewpointCitationDA: Delzx_ViewpointCitationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ViewpointCitation where " + strCondition ;
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
 /// <param name = "objzx_ViewpointCitationENS">源对象</param>
 /// <param name = "objzx_ViewpointCitationENT">目标对象</param>
public void CopyTo(clszx_ViewpointCitationEN objzx_ViewpointCitationENS, clszx_ViewpointCitationEN objzx_ViewpointCitationENT)
{
objzx_ViewpointCitationENT.mId = objzx_ViewpointCitationENS.mId; //mId
objzx_ViewpointCitationENT.zxViewpointId = objzx_ViewpointCitationENS.zxViewpointId; //观点Id
objzx_ViewpointCitationENT.TextId = objzx_ViewpointCitationENS.TextId; //课件Id
objzx_ViewpointCitationENT.UpdUserId = objzx_ViewpointCitationENS.UpdUserId; //修改用户Id
objzx_ViewpointCitationENT.Memo = objzx_ViewpointCitationENS.Memo; //备注
objzx_ViewpointCitationENT.UpdDate = objzx_ViewpointCitationENS.UpdDate; //修改日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.zxViewpointId, 8, conzx_ViewpointCitation.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.TextId, 8, conzx_ViewpointCitation.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.UpdUserId, 20, conzx_ViewpointCitation.UpdUserId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.Memo, 1000, conzx_ViewpointCitation.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.UpdDate, 20, conzx_ViewpointCitation.UpdDate);
//检查字段外键固定长度
 objzx_ViewpointCitationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.zxViewpointId, 8, conzx_ViewpointCitation.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.TextId, 8, conzx_ViewpointCitation.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.UpdUserId, 20, conzx_ViewpointCitation.UpdUserId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.Memo, 1000, conzx_ViewpointCitation.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.UpdDate, 20, conzx_ViewpointCitation.UpdDate);
//检查外键字段长度
 objzx_ViewpointCitationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.zxViewpointId, 8, conzx_ViewpointCitation.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.TextId, 8, conzx_ViewpointCitation.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.UpdUserId, 20, conzx_ViewpointCitation.UpdUserId);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.Memo, 1000, conzx_ViewpointCitation.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointCitationEN.UpdDate, 20, conzx_ViewpointCitation.UpdDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointCitationEN.zxViewpointId, conzx_ViewpointCitation.zxViewpointId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointCitationEN.TextId, conzx_ViewpointCitation.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointCitationEN.UpdUserId, conzx_ViewpointCitation.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointCitationEN.Memo, conzx_ViewpointCitation.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointCitationEN.UpdDate, conzx_ViewpointCitation.UpdDate);
//检查外键字段长度
 objzx_ViewpointCitationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_ViewpointCitation(中学观点引用关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointCitationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ViewpointCitationEN objzx_ViewpointCitationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objzx_ViewpointCitationEN.mId);
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ViewpointCitationEN._CurrTabName);
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ViewpointCitationEN._CurrTabName, strCondition);
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
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
 objSQL = clszx_ViewpointCitationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}