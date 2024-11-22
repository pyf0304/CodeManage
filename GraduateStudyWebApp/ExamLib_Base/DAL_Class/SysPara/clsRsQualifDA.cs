
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsQualifDA
 表名:RsQualif(01120109)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 学历(RsQualif)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsRsQualifDA : clsCommBase4DA
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
 return clsRsQualifEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsRsQualifEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRsQualifEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsRsQualifEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsRsQualifEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdQualif">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdQualif)
{
strIdQualif = strIdQualif.Replace("'", "''");
if (strIdQualif.Length > 4)
{
throw new Exception("(errid:Data000001)在表:RsQualif中,检查关键字,长度不正确!(clsRsQualifDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdQualif)  ==  true)
{
throw new Exception("(errid:Data000002)在表:RsQualif中,关键字不能为空 或 null!(clsRsQualifDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdQualif);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsRsQualifDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_RsQualif(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable_RsQualif)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RsQualif where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RsQualif where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RsQualif where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RsQualif.* from RsQualif Left Join {1} on {2} where {3} and RsQualif.IdQualif not in (Select top {5} RsQualif.IdQualif from RsQualif Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RsQualif where {1} and IdQualif not in (Select top {2} IdQualif from RsQualif where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RsQualif where {1} and IdQualif not in (Select top {3} IdQualif from RsQualif where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsRsQualifDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RsQualif.* from RsQualif Left Join {1} on {2} where {3} and RsQualif.IdQualif not in (Select top {5} RsQualif.IdQualif from RsQualif Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RsQualif where {1} and IdQualif not in (Select top {2} IdQualif from RsQualif where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RsQualif where {1} and IdQualif not in (Select top {3} IdQualif from RsQualif where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsRsQualifEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsRsQualifDA:GetObjLst)", objException.Message));
}
List<clsRsQualifEN> arrObjLst = new List<clsRsQualifEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRsQualifEN objRsQualifEN = new clsRsQualifEN();
try
{
objRsQualifEN.IdQualif = objRow[conRsQualif.IdQualif].ToString().Trim(); //学历流水号
objRsQualifEN.QualifID = objRow[conRsQualif.QualifID].ToString().Trim(); //学历
objRsQualifEN.QualifDesc = objRow[conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc
objRsQualifEN.ModifyDate = objRow[conRsQualif.ModifyDate] == DBNull.Value ? null : objRow[conRsQualif.ModifyDate].ToString().Trim(); //修改日期
objRsQualifEN.ModifyUserId = objRow[conRsQualif.ModifyUserId] == DBNull.Value ? null : objRow[conRsQualif.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRsQualifDA: GetObjLst)", objException.Message));
}
objRsQualifEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRsQualifEN);
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
public List<clsRsQualifEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsRsQualifDA:GetObjLstByTabName)", objException.Message));
}
List<clsRsQualifEN> arrObjLst = new List<clsRsQualifEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRsQualifEN objRsQualifEN = new clsRsQualifEN();
try
{
objRsQualifEN.IdQualif = objRow[conRsQualif.IdQualif].ToString().Trim(); //学历流水号
objRsQualifEN.QualifID = objRow[conRsQualif.QualifID].ToString().Trim(); //学历
objRsQualifEN.QualifDesc = objRow[conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc
objRsQualifEN.ModifyDate = objRow[conRsQualif.ModifyDate] == DBNull.Value ? null : objRow[conRsQualif.ModifyDate].ToString().Trim(); //修改日期
objRsQualifEN.ModifyUserId = objRow[conRsQualif.ModifyUserId] == DBNull.Value ? null : objRow[conRsQualif.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRsQualifDA: GetObjLst)", objException.Message));
}
objRsQualifEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRsQualifEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objRsQualifEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetRsQualif(ref clsRsQualifEN objRsQualifEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where IdQualif = " + "'"+ objRsQualifEN.IdQualif+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objRsQualifEN.IdQualif = objDT.Rows[0][conRsQualif.IdQualif].ToString().Trim(); //学历流水号(字段类型:char,字段长度:4,是否可空:False)
 objRsQualifEN.QualifID = objDT.Rows[0][conRsQualif.QualifID].ToString().Trim(); //学历(字段类型:char,字段长度:4,是否可空:False)
 objRsQualifEN.QualifDesc = objDT.Rows[0][conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc(字段类型:varchar,字段长度:30,是否可空:True)
 objRsQualifEN.ModifyDate = objDT.Rows[0][conRsQualif.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRsQualifEN.ModifyUserId = objDT.Rows[0][conRsQualif.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsRsQualifDA: GetRsQualif)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdQualif">表关键字</param>
 /// <returns>表对象</returns>
public clsRsQualifEN GetObjByIdQualif(string strIdQualif)
{
CheckPrimaryKey(strIdQualif);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where IdQualif = " + "'"+ strIdQualif+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsRsQualifEN objRsQualifEN = new clsRsQualifEN();
try
{
 objRsQualifEN.IdQualif = objRow[conRsQualif.IdQualif].ToString().Trim(); //学历流水号(字段类型:char,字段长度:4,是否可空:False)
 objRsQualifEN.QualifID = objRow[conRsQualif.QualifID].ToString().Trim(); //学历(字段类型:char,字段长度:4,是否可空:False)
 objRsQualifEN.QualifDesc = objRow[conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc(字段类型:varchar,字段长度:30,是否可空:True)
 objRsQualifEN.ModifyDate = objRow[conRsQualif.ModifyDate] == DBNull.Value ? null : objRow[conRsQualif.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRsQualifEN.ModifyUserId = objRow[conRsQualif.ModifyUserId] == DBNull.Value ? null : objRow[conRsQualif.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsRsQualifDA: GetObjByIdQualif)", objException.Message));
}
return objRsQualifEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsRsQualifEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsRsQualifDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsRsQualifEN objRsQualifEN = new clsRsQualifEN()
{
IdQualif = objRow[conRsQualif.IdQualif].ToString().Trim(), //学历流水号
QualifID = objRow[conRsQualif.QualifID].ToString().Trim(), //学历
QualifDesc = objRow[conRsQualif.QualifDesc].ToString().Trim(), //QualifDesc
ModifyDate = objRow[conRsQualif.ModifyDate] == DBNull.Value ? null : objRow[conRsQualif.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conRsQualif.ModifyUserId] == DBNull.Value ? null : objRow[conRsQualif.ModifyUserId].ToString().Trim() //修改人
};
objRsQualifEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRsQualifEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsRsQualifDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsRsQualifEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRsQualifEN objRsQualifEN = new clsRsQualifEN();
try
{
objRsQualifEN.IdQualif = objRow[conRsQualif.IdQualif].ToString().Trim(); //学历流水号
objRsQualifEN.QualifID = objRow[conRsQualif.QualifID].ToString().Trim(); //学历
objRsQualifEN.QualifDesc = objRow[conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc
objRsQualifEN.ModifyDate = objRow[conRsQualif.ModifyDate] == DBNull.Value ? null : objRow[conRsQualif.ModifyDate].ToString().Trim(); //修改日期
objRsQualifEN.ModifyUserId = objRow[conRsQualif.ModifyUserId] == DBNull.Value ? null : objRow[conRsQualif.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsRsQualifDA: GetObjByDataRowRsQualif)", objException.Message));
}
objRsQualifEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRsQualifEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsRsQualifEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRsQualifEN objRsQualifEN = new clsRsQualifEN();
try
{
objRsQualifEN.IdQualif = objRow[conRsQualif.IdQualif].ToString().Trim(); //学历流水号
objRsQualifEN.QualifID = objRow[conRsQualif.QualifID].ToString().Trim(); //学历
objRsQualifEN.QualifDesc = objRow[conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc
objRsQualifEN.ModifyDate = objRow[conRsQualif.ModifyDate] == DBNull.Value ? null : objRow[conRsQualif.ModifyDate].ToString().Trim(); //修改日期
objRsQualifEN.ModifyUserId = objRow[conRsQualif.ModifyUserId] == DBNull.Value ? null : objRow[conRsQualif.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsRsQualifDA: GetObjByDataRow)", objException.Message));
}
objRsQualifEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRsQualifEN;
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
objSQL = clsRsQualifDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRsQualifEN._CurrTabName, conRsQualif.IdQualif, 4, "");
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
objSQL = clsRsQualifDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRsQualifEN._CurrTabName, conRsQualif.IdQualif, 4, strPrefix);
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdQualif from RsQualif where " + strCondition;
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdQualif from RsQualif where " + strCondition;
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
 /// <param name = "strIdQualif">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdQualif)
{
CheckPrimaryKey(strIdQualif);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RsQualif", "IdQualif = " + "'"+ strIdQualif+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsRsQualifDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RsQualif", strCondition))
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
objSQL = clsRsQualifDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("RsQualif");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsRsQualifEN objRsQualifEN)
 {
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsQualifEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RsQualif");
objRow = objDS.Tables["RsQualif"].NewRow();
objRow[conRsQualif.IdQualif] = objRsQualifEN.IdQualif; //学历流水号
objRow[conRsQualif.QualifID] = objRsQualifEN.QualifID; //学历
objRow[conRsQualif.QualifDesc] = objRsQualifEN.QualifDesc; //QualifDesc
 if (objRsQualifEN.ModifyDate !=  "")
 {
objRow[conRsQualif.ModifyDate] = objRsQualifEN.ModifyDate; //修改日期
 }
 if (objRsQualifEN.ModifyUserId !=  "")
 {
objRow[conRsQualif.ModifyUserId] = objRsQualifEN.ModifyUserId; //修改人
 }
objDS.Tables[clsRsQualifEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsRsQualifEN._CurrTabName);
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
 /// <param name = "objRsQualifEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRsQualifEN objRsQualifEN)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsQualifEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsQualifEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.IdQualif);
 var strIdQualif = objRsQualifEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objRsQualifEN.QualifID !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifID);
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifID + "'");
 }
 
 if (objRsQualifEN.QualifDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifDesc);
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifDesc + "'");
 }
 
 if (objRsQualifEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyDate);
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyUserId);
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsQualif");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objRsQualifEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRsQualifEN objRsQualifEN)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsQualifEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsQualifEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.IdQualif);
 var strIdQualif = objRsQualifEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objRsQualifEN.QualifID !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifID);
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifID + "'");
 }
 
 if (objRsQualifEN.QualifDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifDesc);
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifDesc + "'");
 }
 
 if (objRsQualifEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyDate);
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyUserId);
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsQualif");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objRsQualifEN.IdQualif;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objRsQualifEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRsQualifEN objRsQualifEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsQualifEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsQualifEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.IdQualif);
 var strIdQualif = objRsQualifEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objRsQualifEN.QualifID !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifID);
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifID + "'");
 }
 
 if (objRsQualifEN.QualifDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifDesc);
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifDesc + "'");
 }
 
 if (objRsQualifEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyDate);
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyUserId);
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsQualif");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objRsQualifEN.IdQualif;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objRsQualifEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRsQualifEN objRsQualifEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsQualifEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsQualifEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.IdQualif);
 var strIdQualif = objRsQualifEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objRsQualifEN.QualifID !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifID);
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifID + "'");
 }
 
 if (objRsQualifEN.QualifDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.QualifDesc);
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQualifDesc + "'");
 }
 
 if (objRsQualifEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyDate);
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsQualif.ModifyUserId);
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsQualif");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewRsQualifs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where IdQualif = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RsQualif");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdQualif = oRow[conRsQualif.IdQualif].ToString().Trim();
if (IsExist(strIdQualif))
{
 string strResult = "关键字变量值为:" + string.Format("IdQualif = {0}", strIdQualif) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsRsQualifEN._CurrTabName ].NewRow();
objRow[conRsQualif.IdQualif] = oRow[conRsQualif.IdQualif].ToString().Trim(); //学历流水号
objRow[conRsQualif.QualifID] = oRow[conRsQualif.QualifID].ToString().Trim(); //学历
objRow[conRsQualif.QualifDesc] = oRow[conRsQualif.QualifDesc].ToString().Trim(); //QualifDesc
objRow[conRsQualif.ModifyDate] = oRow[conRsQualif.ModifyDate].ToString().Trim(); //修改日期
objRow[conRsQualif.ModifyUserId] = oRow[conRsQualif.ModifyUserId].ToString().Trim(); //修改人
 objDS.Tables[clsRsQualifEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsRsQualifEN._CurrTabName);
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
 /// <param name = "objRsQualifEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsRsQualifEN objRsQualifEN)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsQualifEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
strSQL = "Select * from RsQualif where IdQualif = " + "'"+ objRsQualifEN.IdQualif+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsRsQualifEN._CurrTabName);
if (objDS.Tables[clsRsQualifEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdQualif = " + "'"+ objRsQualifEN.IdQualif+"'");
return false;
}
objRow = objDS.Tables[clsRsQualifEN._CurrTabName].Rows[0];
 if (objRsQualifEN.IsUpdated(conRsQualif.IdQualif))
 {
objRow[conRsQualif.IdQualif] = objRsQualifEN.IdQualif; //学历流水号
 }
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifID))
 {
objRow[conRsQualif.QualifID] = objRsQualifEN.QualifID; //学历
 }
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifDesc))
 {
objRow[conRsQualif.QualifDesc] = objRsQualifEN.QualifDesc; //QualifDesc
 }
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyDate))
 {
objRow[conRsQualif.ModifyDate] = objRsQualifEN.ModifyDate; //修改日期
 }
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyUserId))
 {
objRow[conRsQualif.ModifyUserId] = objRsQualifEN.ModifyUserId; //修改人
 }
try
{
objDA.Update(objDS, clsRsQualifEN._CurrTabName);
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
 /// <param name = "objRsQualifEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRsQualifEN objRsQualifEN)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsQualifEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update RsQualif Set ");
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifID))
 {
 if (objRsQualifEN.QualifID !=  null)
 {
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQualifID, conRsQualif.QualifID); //学历
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.QualifID); //学历
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifDesc))
 {
 if (objRsQualifEN.QualifDesc !=  null)
 {
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQualifDesc, conRsQualif.QualifDesc); //QualifDesc
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.QualifDesc); //QualifDesc
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyDate))
 {
 if (objRsQualifEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conRsQualif.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.ModifyDate); //修改日期
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyUserId))
 {
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conRsQualif.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.ModifyUserId); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdQualif = '{0}'", objRsQualifEN.IdQualif); 
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
 /// <param name = "objRsQualifEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsRsQualifEN objRsQualifEN, string strCondition)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsQualifEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RsQualif Set ");
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifID))
 {
 if (objRsQualifEN.QualifID !=  null)
 {
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QualifID = '{0}',", strQualifID); //学历
 }
 else
 {
 sbSQL.Append(" QualifID = null,"); //学历
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifDesc))
 {
 if (objRsQualifEN.QualifDesc !=  null)
 {
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QualifDesc = '{0}',", strQualifDesc); //QualifDesc
 }
 else
 {
 sbSQL.Append(" QualifDesc = null,"); //QualifDesc
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyDate))
 {
 if (objRsQualifEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyUserId))
 {
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
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
 /// <param name = "objRsQualifEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsRsQualifEN objRsQualifEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsQualifEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RsQualif Set ");
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifID))
 {
 if (objRsQualifEN.QualifID !=  null)
 {
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QualifID = '{0}',", strQualifID); //学历
 }
 else
 {
 sbSQL.Append(" QualifID = null,"); //学历
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifDesc))
 {
 if (objRsQualifEN.QualifDesc !=  null)
 {
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QualifDesc = '{0}',", strQualifDesc); //QualifDesc
 }
 else
 {
 sbSQL.Append(" QualifDesc = null,"); //QualifDesc
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyDate))
 {
 if (objRsQualifEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyUserId))
 {
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
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
 /// <param name = "objRsQualifEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRsQualifEN objRsQualifEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objRsQualifEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsQualifEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RsQualif Set ");
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifID))
 {
 if (objRsQualifEN.QualifID !=  null)
 {
 var strQualifID = objRsQualifEN.QualifID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQualifID, conRsQualif.QualifID); //学历
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.QualifID); //学历
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.QualifDesc))
 {
 if (objRsQualifEN.QualifDesc !=  null)
 {
 var strQualifDesc = objRsQualifEN.QualifDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQualifDesc, conRsQualif.QualifDesc); //QualifDesc
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.QualifDesc); //QualifDesc
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyDate))
 {
 if (objRsQualifEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsQualifEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conRsQualif.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.ModifyDate); //修改日期
 }
 }
 
 if (objRsQualifEN.IsUpdated(conRsQualif.ModifyUserId))
 {
 if (objRsQualifEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsQualifEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conRsQualif.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsQualif.ModifyUserId); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdQualif = '{0}'", objRsQualifEN.IdQualif); 
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
 /// <param name = "strIdQualif">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdQualif) 
{
CheckPrimaryKey(strIdQualif);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdQualif,
};
 objSQL.ExecSP("RsQualif_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdQualif">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdQualif, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdQualif);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
//删除RsQualif本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RsQualif where IdQualif = " + "'"+ strIdQualif+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRsQualif(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
//删除RsQualif本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RsQualif where IdQualif in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdQualif">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdQualif) 
{
CheckPrimaryKey(strIdQualif);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
//删除RsQualif本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RsQualif where IdQualif = " + "'"+ strIdQualif+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelRsQualif(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsRsQualifDA: DelRsQualif)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RsQualif where " + strCondition ;
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
public bool DelRsQualifWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsRsQualifDA: DelRsQualifWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsQualifDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RsQualif where " + strCondition ;
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
 /// <param name = "objRsQualifENS">源对象</param>
 /// <param name = "objRsQualifENT">目标对象</param>
public void CopyTo(clsRsQualifEN objRsQualifENS, clsRsQualifEN objRsQualifENT)
{
objRsQualifENT.IdQualif = objRsQualifENS.IdQualif; //学历流水号
objRsQualifENT.QualifID = objRsQualifENS.QualifID; //学历
objRsQualifENT.QualifDesc = objRsQualifENS.QualifDesc; //QualifDesc
objRsQualifENT.ModifyDate = objRsQualifENS.ModifyDate; //修改日期
objRsQualifENT.ModifyUserId = objRsQualifENS.ModifyUserId; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsRsQualifEN objRsQualifEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objRsQualifEN.QualifID, conRsQualif.QualifID);
clsCheckSql.CheckFieldNotNull(objRsQualifEN.QualifDesc, conRsQualif.QualifDesc);
//检查字段长度
clsCheckSql.CheckFieldLen(objRsQualifEN.IdQualif, 4, conRsQualif.IdQualif);
clsCheckSql.CheckFieldLen(objRsQualifEN.QualifID, 4, conRsQualif.QualifID);
clsCheckSql.CheckFieldLen(objRsQualifEN.QualifDesc, 30, conRsQualif.QualifDesc);
clsCheckSql.CheckFieldLen(objRsQualifEN.ModifyDate, 20, conRsQualif.ModifyDate);
clsCheckSql.CheckFieldLen(objRsQualifEN.ModifyUserId, 18, conRsQualif.ModifyUserId);
//检查字段外键固定长度
 objRsQualifEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsRsQualifEN objRsQualifEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRsQualifEN.QualifID, 4, conRsQualif.QualifID);
clsCheckSql.CheckFieldLen(objRsQualifEN.QualifDesc, 30, conRsQualif.QualifDesc);
clsCheckSql.CheckFieldLen(objRsQualifEN.ModifyDate, 20, conRsQualif.ModifyDate);
clsCheckSql.CheckFieldLen(objRsQualifEN.ModifyUserId, 18, conRsQualif.ModifyUserId);
//检查外键字段长度
 objRsQualifEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsRsQualifEN objRsQualifEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRsQualifEN.IdQualif, 4, conRsQualif.IdQualif);
clsCheckSql.CheckFieldLen(objRsQualifEN.QualifID, 4, conRsQualif.QualifID);
clsCheckSql.CheckFieldLen(objRsQualifEN.QualifDesc, 30, conRsQualif.QualifDesc);
clsCheckSql.CheckFieldLen(objRsQualifEN.ModifyDate, 20, conRsQualif.ModifyDate);
clsCheckSql.CheckFieldLen(objRsQualifEN.ModifyUserId, 18, conRsQualif.ModifyUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objRsQualifEN.IdQualif, conRsQualif.IdQualif);
clsCheckSql.CheckSqlInjection4Field(objRsQualifEN.QualifID, conRsQualif.QualifID);
clsCheckSql.CheckSqlInjection4Field(objRsQualifEN.QualifDesc, conRsQualif.QualifDesc);
clsCheckSql.CheckSqlInjection4Field(objRsQualifEN.ModifyDate, conRsQualif.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objRsQualifEN.ModifyUserId, conRsQualif.ModifyUserId);
//检查外键字段长度
 objRsQualifEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdQualif()
{
//获取某学院所有专业信息
string strSQL = "select IdQualif, QualifDesc from RsQualif ";
 clsSpecSQLforSql mySql = clsRsQualifDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRsQualifEN._CurrTabName);
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRsQualifEN._CurrTabName, strCondition);
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
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
 objSQL = clsRsQualifDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}