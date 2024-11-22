
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSexDA
 表名:Sex(01120103)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:13
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
 /// 性别(Sex)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSexDA : clsCommBase4DA
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
 return clsSexEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSexEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSexEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSexEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSexEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSex">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSex)
{
strIdSex = strIdSex.Replace("'", "''");
if (strIdSex.Length > 4)
{
throw new Exception("(errid:Data000001)在表:Sex中,检查关键字,长度不正确!(clsSexDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSex)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Sex中,关键字不能为空 或 null!(clsSexDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSex);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSexDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Sex(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable_Sex)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Sex where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Sex where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSexDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Sex where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSexDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Sex.* from Sex Left Join {1} on {2} where {3} and Sex.IdSex not in (Select top {5} Sex.IdSex from Sex Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Sex where {1} and IdSex not in (Select top {2} IdSex from Sex where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Sex where {1} and IdSex not in (Select top {3} IdSex from Sex where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSexDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Sex.* from Sex Left Join {1} on {2} where {3} and Sex.IdSex not in (Select top {5} Sex.IdSex from Sex Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Sex where {1} and IdSex not in (Select top {2} IdSex from Sex where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Sex where {1} and IdSex not in (Select top {3} IdSex from Sex where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSexEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSexDA:GetObjLst)", objException.Message));
}
List<clsSexEN> arrObjLst = new List<clsSexEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSexEN objSexEN = new clsSexEN();
try
{
objSexEN.IdSex = objRow[conSex.IdSex].ToString().Trim(); //性别流水号
objSexEN.SexID = objRow[conSex.SexID] == DBNull.Value ? null : objRow[conSex.SexID].ToString().Trim(); //性别ID
objSexEN.SexDesc = objRow[conSex.SexDesc] == DBNull.Value ? null : objRow[conSex.SexDesc].ToString().Trim(); //性别名称
objSexEN.SexDescEn = objRow[conSex.SexDescEn] == DBNull.Value ? null : objRow[conSex.SexDescEn].ToString().Trim(); //SexDesc_EN
objSexEN.ModifyDate = objRow[conSex.ModifyDate] == DBNull.Value ? null : objRow[conSex.ModifyDate].ToString().Trim(); //修改日期
objSexEN.ModifyUserId = objRow[conSex.ModifyUserId] == DBNull.Value ? null : objRow[conSex.ModifyUserId].ToString().Trim(); //修改人
objSexEN.Memo = objRow[conSex.Memo] == DBNull.Value ? null : objRow[conSex.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSexDA: GetObjLst)", objException.Message));
}
objSexEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSexEN);
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
public List<clsSexEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSexDA:GetObjLstByTabName)", objException.Message));
}
List<clsSexEN> arrObjLst = new List<clsSexEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSexEN objSexEN = new clsSexEN();
try
{
objSexEN.IdSex = objRow[conSex.IdSex].ToString().Trim(); //性别流水号
objSexEN.SexID = objRow[conSex.SexID] == DBNull.Value ? null : objRow[conSex.SexID].ToString().Trim(); //性别ID
objSexEN.SexDesc = objRow[conSex.SexDesc] == DBNull.Value ? null : objRow[conSex.SexDesc].ToString().Trim(); //性别名称
objSexEN.SexDescEn = objRow[conSex.SexDescEn] == DBNull.Value ? null : objRow[conSex.SexDescEn].ToString().Trim(); //SexDesc_EN
objSexEN.ModifyDate = objRow[conSex.ModifyDate] == DBNull.Value ? null : objRow[conSex.ModifyDate].ToString().Trim(); //修改日期
objSexEN.ModifyUserId = objRow[conSex.ModifyUserId] == DBNull.Value ? null : objRow[conSex.ModifyUserId].ToString().Trim(); //修改人
objSexEN.Memo = objRow[conSex.Memo] == DBNull.Value ? null : objRow[conSex.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSexDA: GetObjLst)", objException.Message));
}
objSexEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSexEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSexEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSex(ref clsSexEN objSexEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where IdSex = " + "'"+ objSexEN.IdSex+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSexEN.IdSex = objDT.Rows[0][conSex.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objSexEN.SexID = objDT.Rows[0][conSex.SexID].ToString().Trim(); //性别ID(字段类型:varchar,字段长度:4,是否可空:True)
 objSexEN.SexDesc = objDT.Rows[0][conSex.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objSexEN.SexDescEn = objDT.Rows[0][conSex.SexDescEn].ToString().Trim(); //SexDesc_EN(字段类型:varchar,字段长度:10,是否可空:True)
 objSexEN.ModifyDate = objDT.Rows[0][conSex.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSexEN.ModifyUserId = objDT.Rows[0][conSex.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objSexEN.Memo = objDT.Rows[0][conSex.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSexDA: GetSex)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSex">表关键字</param>
 /// <returns>表对象</returns>
public clsSexEN GetObjByIdSex(string strIdSex)
{
CheckPrimaryKey(strIdSex);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where IdSex = " + "'"+ strIdSex+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSexEN objSexEN = new clsSexEN();
try
{
 objSexEN.IdSex = objRow[conSex.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objSexEN.SexID = objRow[conSex.SexID] == DBNull.Value ? null : objRow[conSex.SexID].ToString().Trim(); //性别ID(字段类型:varchar,字段长度:4,是否可空:True)
 objSexEN.SexDesc = objRow[conSex.SexDesc] == DBNull.Value ? null : objRow[conSex.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objSexEN.SexDescEn = objRow[conSex.SexDescEn] == DBNull.Value ? null : objRow[conSex.SexDescEn].ToString().Trim(); //SexDesc_EN(字段类型:varchar,字段长度:10,是否可空:True)
 objSexEN.ModifyDate = objRow[conSex.ModifyDate] == DBNull.Value ? null : objRow[conSex.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSexEN.ModifyUserId = objRow[conSex.ModifyUserId] == DBNull.Value ? null : objRow[conSex.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objSexEN.Memo = objRow[conSex.Memo] == DBNull.Value ? null : objRow[conSex.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSexDA: GetObjByIdSex)", objException.Message));
}
return objSexEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSexEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSexDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSexEN objSexEN = new clsSexEN()
{
IdSex = objRow[conSex.IdSex].ToString().Trim(), //性别流水号
SexID = objRow[conSex.SexID] == DBNull.Value ? null : objRow[conSex.SexID].ToString().Trim(), //性别ID
SexDesc = objRow[conSex.SexDesc] == DBNull.Value ? null : objRow[conSex.SexDesc].ToString().Trim(), //性别名称
SexDescEn = objRow[conSex.SexDescEn] == DBNull.Value ? null : objRow[conSex.SexDescEn].ToString().Trim(), //SexDesc_EN
ModifyDate = objRow[conSex.ModifyDate] == DBNull.Value ? null : objRow[conSex.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conSex.ModifyUserId] == DBNull.Value ? null : objRow[conSex.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conSex.Memo] == DBNull.Value ? null : objRow[conSex.Memo].ToString().Trim() //备注
};
objSexEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSexEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSexDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSexEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSexEN objSexEN = new clsSexEN();
try
{
objSexEN.IdSex = objRow[conSex.IdSex].ToString().Trim(); //性别流水号
objSexEN.SexID = objRow[conSex.SexID] == DBNull.Value ? null : objRow[conSex.SexID].ToString().Trim(); //性别ID
objSexEN.SexDesc = objRow[conSex.SexDesc] == DBNull.Value ? null : objRow[conSex.SexDesc].ToString().Trim(); //性别名称
objSexEN.SexDescEn = objRow[conSex.SexDescEn] == DBNull.Value ? null : objRow[conSex.SexDescEn].ToString().Trim(); //SexDesc_EN
objSexEN.ModifyDate = objRow[conSex.ModifyDate] == DBNull.Value ? null : objRow[conSex.ModifyDate].ToString().Trim(); //修改日期
objSexEN.ModifyUserId = objRow[conSex.ModifyUserId] == DBNull.Value ? null : objRow[conSex.ModifyUserId].ToString().Trim(); //修改人
objSexEN.Memo = objRow[conSex.Memo] == DBNull.Value ? null : objRow[conSex.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSexDA: GetObjByDataRowSex)", objException.Message));
}
objSexEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSexEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSexEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSexEN objSexEN = new clsSexEN();
try
{
objSexEN.IdSex = objRow[conSex.IdSex].ToString().Trim(); //性别流水号
objSexEN.SexID = objRow[conSex.SexID] == DBNull.Value ? null : objRow[conSex.SexID].ToString().Trim(); //性别ID
objSexEN.SexDesc = objRow[conSex.SexDesc] == DBNull.Value ? null : objRow[conSex.SexDesc].ToString().Trim(); //性别名称
objSexEN.SexDescEn = objRow[conSex.SexDescEn] == DBNull.Value ? null : objRow[conSex.SexDescEn].ToString().Trim(); //SexDesc_EN
objSexEN.ModifyDate = objRow[conSex.ModifyDate] == DBNull.Value ? null : objRow[conSex.ModifyDate].ToString().Trim(); //修改日期
objSexEN.ModifyUserId = objRow[conSex.ModifyUserId] == DBNull.Value ? null : objRow[conSex.ModifyUserId].ToString().Trim(); //修改人
objSexEN.Memo = objRow[conSex.Memo] == DBNull.Value ? null : objRow[conSex.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSexDA: GetObjByDataRow)", objException.Message));
}
objSexEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSexEN;
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
objSQL = clsSexDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSexEN._CurrTabName, conSex.IdSex, 4, "");
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
objSQL = clsSexDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSexEN._CurrTabName, conSex.IdSex, 4, strPrefix);
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
 objSQL = clsSexDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSex from Sex where " + strCondition;
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
 objSQL = clsSexDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSex from Sex where " + strCondition;
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
 /// <param name = "strIdSex">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSex)
{
CheckPrimaryKey(strIdSex);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Sex", "IdSex = " + "'"+ strIdSex+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSexDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Sex", strCondition))
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
objSQL = clsSexDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Sex");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSexEN objSexEN)
 {
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSexEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Sex");
objRow = objDS.Tables["Sex"].NewRow();
objRow[conSex.IdSex] = objSexEN.IdSex; //性别流水号
 if (objSexEN.SexID !=  "")
 {
objRow[conSex.SexID] = objSexEN.SexID; //性别ID
 }
 if (objSexEN.SexDesc !=  "")
 {
objRow[conSex.SexDesc] = objSexEN.SexDesc; //性别名称
 }
 if (objSexEN.SexDescEn !=  "")
 {
objRow[conSex.SexDescEn] = objSexEN.SexDescEn; //SexDesc_EN
 }
 if (objSexEN.ModifyDate !=  "")
 {
objRow[conSex.ModifyDate] = objSexEN.ModifyDate; //修改日期
 }
 if (objSexEN.ModifyUserId !=  "")
 {
objRow[conSex.ModifyUserId] = objSexEN.ModifyUserId; //修改人
 }
 if (objSexEN.Memo !=  "")
 {
objRow[conSex.Memo] = objSexEN.Memo; //备注
 }
objDS.Tables[clsSexEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSexEN._CurrTabName);
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
 /// <param name = "objSexEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSexEN objSexEN)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSexEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSexEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conSex.IdSex);
 var strIdSex = objSexEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objSexEN.SexID !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexID);
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexID + "'");
 }
 
 if (objSexEN.SexDesc !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDesc);
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDesc + "'");
 }
 
 if (objSexEN.SexDescEn !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDescEn);
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDescEn + "'");
 }
 
 if (objSexEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyDate);
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objSexEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyUserId);
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objSexEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSex.Memo);
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Sex");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSexEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSexEN objSexEN)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSexEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSexEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conSex.IdSex);
 var strIdSex = objSexEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objSexEN.SexID !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexID);
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexID + "'");
 }
 
 if (objSexEN.SexDesc !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDesc);
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDesc + "'");
 }
 
 if (objSexEN.SexDescEn !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDescEn);
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDescEn + "'");
 }
 
 if (objSexEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyDate);
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objSexEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyUserId);
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objSexEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSex.Memo);
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Sex");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSexEN.IdSex;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSexEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSexEN objSexEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSexEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSexEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conSex.IdSex);
 var strIdSex = objSexEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objSexEN.SexID !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexID);
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexID + "'");
 }
 
 if (objSexEN.SexDesc !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDesc);
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDesc + "'");
 }
 
 if (objSexEN.SexDescEn !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDescEn);
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDescEn + "'");
 }
 
 if (objSexEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyDate);
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objSexEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyUserId);
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objSexEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSex.Memo);
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Sex");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSexEN.IdSex;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSexEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSexEN objSexEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSexEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSexEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conSex.IdSex);
 var strIdSex = objSexEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objSexEN.SexID !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexID);
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexID + "'");
 }
 
 if (objSexEN.SexDesc !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDesc);
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDesc + "'");
 }
 
 if (objSexEN.SexDescEn !=  null)
 {
 arrFieldListForInsert.Add(conSex.SexDescEn);
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSexDescEn + "'");
 }
 
 if (objSexEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyDate);
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objSexEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conSex.ModifyUserId);
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objSexEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSex.Memo);
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Sex");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSexs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where IdSex = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Sex");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdSex = oRow[conSex.IdSex].ToString().Trim();
if (IsExist(strIdSex))
{
 string strResult = "关键字变量值为:" + string.Format("IdSex = {0}", strIdSex) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSexEN._CurrTabName ].NewRow();
objRow[conSex.IdSex] = oRow[conSex.IdSex].ToString().Trim(); //性别流水号
objRow[conSex.SexID] = oRow[conSex.SexID].ToString().Trim(); //性别ID
objRow[conSex.SexDesc] = oRow[conSex.SexDesc].ToString().Trim(); //性别名称
objRow[conSex.SexDescEn] = oRow[conSex.SexDescEn].ToString().Trim(); //SexDesc_EN
objRow[conSex.ModifyDate] = oRow[conSex.ModifyDate].ToString().Trim(); //修改日期
objRow[conSex.ModifyUserId] = oRow[conSex.ModifyUserId].ToString().Trim(); //修改人
objRow[conSex.Memo] = oRow[conSex.Memo].ToString().Trim(); //备注
 objDS.Tables[clsSexEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSexEN._CurrTabName);
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
 /// <param name = "objSexEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSexEN objSexEN)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSexEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
strSQL = "Select * from Sex where IdSex = " + "'"+ objSexEN.IdSex+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSexEN._CurrTabName);
if (objDS.Tables[clsSexEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdSex = " + "'"+ objSexEN.IdSex+"'");
return false;
}
objRow = objDS.Tables[clsSexEN._CurrTabName].Rows[0];
 if (objSexEN.IsUpdated(conSex.IdSex))
 {
objRow[conSex.IdSex] = objSexEN.IdSex; //性别流水号
 }
 if (objSexEN.IsUpdated(conSex.SexID))
 {
objRow[conSex.SexID] = objSexEN.SexID; //性别ID
 }
 if (objSexEN.IsUpdated(conSex.SexDesc))
 {
objRow[conSex.SexDesc] = objSexEN.SexDesc; //性别名称
 }
 if (objSexEN.IsUpdated(conSex.SexDescEn))
 {
objRow[conSex.SexDescEn] = objSexEN.SexDescEn; //SexDesc_EN
 }
 if (objSexEN.IsUpdated(conSex.ModifyDate))
 {
objRow[conSex.ModifyDate] = objSexEN.ModifyDate; //修改日期
 }
 if (objSexEN.IsUpdated(conSex.ModifyUserId))
 {
objRow[conSex.ModifyUserId] = objSexEN.ModifyUserId; //修改人
 }
 if (objSexEN.IsUpdated(conSex.Memo))
 {
objRow[conSex.Memo] = objSexEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsSexEN._CurrTabName);
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
 /// <param name = "objSexEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSexEN objSexEN)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSexEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Sex Set ");
 
 if (objSexEN.IsUpdated(conSex.SexID))
 {
 if (objSexEN.SexID !=  null)
 {
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSexID, conSex.SexID); //性别ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.SexID); //性别ID
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDesc))
 {
 if (objSexEN.SexDesc !=  null)
 {
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSexDesc, conSex.SexDesc); //性别名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.SexDesc); //性别名称
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDescEn))
 {
 if (objSexEN.SexDescEn !=  null)
 {
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSexDescEn, conSex.SexDescEn); //SexDesc_EN
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.SexDescEn); //SexDesc_EN
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyDate))
 {
 if (objSexEN.ModifyDate !=  null)
 {
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conSex.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.ModifyDate); //修改日期
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyUserId))
 {
 if (objSexEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conSex.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.ModifyUserId); //修改人
 }
 }
 
 if (objSexEN.IsUpdated(conSex.Memo))
 {
 if (objSexEN.Memo !=  null)
 {
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSex.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSex = '{0}'", objSexEN.IdSex); 
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
 /// <param name = "objSexEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSexEN objSexEN, string strCondition)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSexEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Sex Set ");
 
 if (objSexEN.IsUpdated(conSex.SexID))
 {
 if (objSexEN.SexID !=  null)
 {
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SexID = '{0}',", strSexID); //性别ID
 }
 else
 {
 sbSQL.Append(" SexID = null,"); //性别ID
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDesc))
 {
 if (objSexEN.SexDesc !=  null)
 {
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SexDesc = '{0}',", strSexDesc); //性别名称
 }
 else
 {
 sbSQL.Append(" SexDesc = null,"); //性别名称
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDescEn))
 {
 if (objSexEN.SexDescEn !=  null)
 {
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SexDescEn = '{0}',", strSexDescEn); //SexDesc_EN
 }
 else
 {
 sbSQL.Append(" SexDescEn = null,"); //SexDesc_EN
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyDate))
 {
 if (objSexEN.ModifyDate !=  null)
 {
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyUserId))
 {
 if (objSexEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objSexEN.IsUpdated(conSex.Memo))
 {
 if (objSexEN.Memo !=  null)
 {
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objSexEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSexEN objSexEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSexEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Sex Set ");
 
 if (objSexEN.IsUpdated(conSex.SexID))
 {
 if (objSexEN.SexID !=  null)
 {
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SexID = '{0}',", strSexID); //性别ID
 }
 else
 {
 sbSQL.Append(" SexID = null,"); //性别ID
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDesc))
 {
 if (objSexEN.SexDesc !=  null)
 {
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SexDesc = '{0}',", strSexDesc); //性别名称
 }
 else
 {
 sbSQL.Append(" SexDesc = null,"); //性别名称
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDescEn))
 {
 if (objSexEN.SexDescEn !=  null)
 {
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SexDescEn = '{0}',", strSexDescEn); //SexDesc_EN
 }
 else
 {
 sbSQL.Append(" SexDescEn = null,"); //SexDesc_EN
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyDate))
 {
 if (objSexEN.ModifyDate !=  null)
 {
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyUserId))
 {
 if (objSexEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objSexEN.IsUpdated(conSex.Memo))
 {
 if (objSexEN.Memo !=  null)
 {
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objSexEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSexEN objSexEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSexEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSexEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Sex Set ");
 
 if (objSexEN.IsUpdated(conSex.SexID))
 {
 if (objSexEN.SexID !=  null)
 {
 var strSexID = objSexEN.SexID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSexID, conSex.SexID); //性别ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.SexID); //性别ID
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDesc))
 {
 if (objSexEN.SexDesc !=  null)
 {
 var strSexDesc = objSexEN.SexDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSexDesc, conSex.SexDesc); //性别名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.SexDesc); //性别名称
 }
 }
 
 if (objSexEN.IsUpdated(conSex.SexDescEn))
 {
 if (objSexEN.SexDescEn !=  null)
 {
 var strSexDescEn = objSexEN.SexDescEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSexDescEn, conSex.SexDescEn); //SexDesc_EN
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.SexDescEn); //SexDesc_EN
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyDate))
 {
 if (objSexEN.ModifyDate !=  null)
 {
 var strModifyDate = objSexEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conSex.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.ModifyDate); //修改日期
 }
 }
 
 if (objSexEN.IsUpdated(conSex.ModifyUserId))
 {
 if (objSexEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objSexEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conSex.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.ModifyUserId); //修改人
 }
 }
 
 if (objSexEN.IsUpdated(conSex.Memo))
 {
 if (objSexEN.Memo !=  null)
 {
 var strMemo = objSexEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSex.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSex.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSex = '{0}'", objSexEN.IdSex); 
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
 /// <param name = "strIdSex">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdSex) 
{
CheckPrimaryKey(strIdSex);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdSex,
};
 objSQL.ExecSP("Sex_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdSex">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdSex, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdSex);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
//删除Sex本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Sex where IdSex = " + "'"+ strIdSex+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSex(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
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
//删除Sex本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Sex where IdSex in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdSex">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdSex) 
{
CheckPrimaryKey(strIdSex);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
//删除Sex本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Sex where IdSex = " + "'"+ strIdSex+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSex(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSexDA: DelSex)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Sex where " + strCondition ;
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
public bool DelSexWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSexDA: DelSexWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSexDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Sex where " + strCondition ;
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
 /// <param name = "objSexENS">源对象</param>
 /// <param name = "objSexENT">目标对象</param>
public void CopyTo(clsSexEN objSexENS, clsSexEN objSexENT)
{
objSexENT.IdSex = objSexENS.IdSex; //性别流水号
objSexENT.SexID = objSexENS.SexID; //性别ID
objSexENT.SexDesc = objSexENS.SexDesc; //性别名称
objSexENT.SexDescEn = objSexENS.SexDescEn; //SexDesc_EN
objSexENT.ModifyDate = objSexENS.ModifyDate; //修改日期
objSexENT.ModifyUserId = objSexENS.ModifyUserId; //修改人
objSexENT.Memo = objSexENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSexEN objSexEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objSexEN.IdSex, 4, conSex.IdSex);
clsCheckSql.CheckFieldLen(objSexEN.SexID, 4, conSex.SexID);
clsCheckSql.CheckFieldLen(objSexEN.SexDesc, 10, conSex.SexDesc);
clsCheckSql.CheckFieldLen(objSexEN.SexDescEn, 10, conSex.SexDescEn);
clsCheckSql.CheckFieldLen(objSexEN.ModifyDate, 20, conSex.ModifyDate);
clsCheckSql.CheckFieldLen(objSexEN.ModifyUserId, 18, conSex.ModifyUserId);
clsCheckSql.CheckFieldLen(objSexEN.Memo, 1000, conSex.Memo);
//检查字段外键固定长度
 objSexEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSexEN objSexEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSexEN.SexID, 4, conSex.SexID);
clsCheckSql.CheckFieldLen(objSexEN.SexDesc, 10, conSex.SexDesc);
clsCheckSql.CheckFieldLen(objSexEN.SexDescEn, 10, conSex.SexDescEn);
clsCheckSql.CheckFieldLen(objSexEN.ModifyDate, 20, conSex.ModifyDate);
clsCheckSql.CheckFieldLen(objSexEN.ModifyUserId, 18, conSex.ModifyUserId);
clsCheckSql.CheckFieldLen(objSexEN.Memo, 1000, conSex.Memo);
//检查外键字段长度
 objSexEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSexEN objSexEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSexEN.IdSex, 4, conSex.IdSex);
clsCheckSql.CheckFieldLen(objSexEN.SexID, 4, conSex.SexID);
clsCheckSql.CheckFieldLen(objSexEN.SexDesc, 10, conSex.SexDesc);
clsCheckSql.CheckFieldLen(objSexEN.SexDescEn, 10, conSex.SexDescEn);
clsCheckSql.CheckFieldLen(objSexEN.ModifyDate, 20, conSex.ModifyDate);
clsCheckSql.CheckFieldLen(objSexEN.ModifyUserId, 18, conSex.ModifyUserId);
clsCheckSql.CheckFieldLen(objSexEN.Memo, 1000, conSex.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSexEN.IdSex, conSex.IdSex);
clsCheckSql.CheckSqlInjection4Field(objSexEN.SexID, conSex.SexID);
clsCheckSql.CheckSqlInjection4Field(objSexEN.SexDesc, conSex.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objSexEN.SexDescEn, conSex.SexDescEn);
clsCheckSql.CheckSqlInjection4Field(objSexEN.ModifyDate, conSex.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objSexEN.ModifyUserId, conSex.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objSexEN.Memo, conSex.Memo);
//检查外键字段长度
 objSexEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSex()
{
//获取某学院所有专业信息
string strSQL = "select IdSex, SexDesc from Sex ";
 clsSpecSQLforSql mySql = clsSexDA.GetSpecSQLObj();
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
 objSQL = clsSexDA.GetSpecSQLObj();
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
 objSQL = clsSexDA.GetSpecSQLObj();
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
 objSQL = clsSexDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSexEN._CurrTabName);
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
 objSQL = clsSexDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSexEN._CurrTabName, strCondition);
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
 objSQL = clsSexDA.GetSpecSQLObj();
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
 objSQL = clsSexDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}