﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_CommKeyWordsDA
 表名:tz_CommKeyWords(00050330)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:56:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// tz_通用关键字(tz_CommKeyWords)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clstz_CommKeyWordsDA : clsCommBase4DA
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
 return clstz_CommKeyWordsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clstz_CommKeyWordsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clstz_CommKeyWordsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clstz_CommKeyWordsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clstz_CommKeyWordsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strKeyId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strKeyId)
{
strKeyId = strKeyId.Replace("'", "''");
if (strKeyId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:tz_CommKeyWords中,检查关键字,长度不正确!(clstz_CommKeyWordsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strKeyId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:tz_CommKeyWords中,关键字不能为空 或 null!(clstz_CommKeyWordsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeyId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clstz_CommKeyWordsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_tz_CommKeyWords(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable_tz_CommKeyWords)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} tz_CommKeyWords.* from tz_CommKeyWords Left Join {1} on {2} where {3} and tz_CommKeyWords.KeyId not in (Select top {5} tz_CommKeyWords.KeyId from tz_CommKeyWords Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1} and KeyId not in (Select top {2} KeyId from tz_CommKeyWords where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1} and KeyId not in (Select top {3} KeyId from tz_CommKeyWords where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} tz_CommKeyWords.* from tz_CommKeyWords Left Join {1} on {2} where {3} and tz_CommKeyWords.KeyId not in (Select top {5} tz_CommKeyWords.KeyId from tz_CommKeyWords Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1} and KeyId not in (Select top {2} KeyId from tz_CommKeyWords where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from tz_CommKeyWords where {1} and KeyId not in (Select top {3} KeyId from tz_CommKeyWords where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clstz_CommKeyWordsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA:GetObjLst)", objException.Message));
}
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clstz_CommKeyWordsDA: GetObjLst)", objException.Message));
}
objtz_CommKeyWordsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objtz_CommKeyWordsEN);
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
public List<clstz_CommKeyWordsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA:GetObjLstByTabName)", objException.Message));
}
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clstz_CommKeyWordsDA: GetObjLst)", objException.Message));
}
objtz_CommKeyWordsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objtz_CommKeyWordsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Gettz_CommKeyWords(ref clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where KeyId = " + "'"+ objtz_CommKeyWordsEN.KeyId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objtz_CommKeyWordsEN.KeyId = objDT.Rows[0][contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id(字段类型:varchar,字段长度:8,是否可空:False)
 objtz_CommKeyWordsEN.Keyword = objDT.Rows[0][contz_CommKeyWords.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objtz_CommKeyWordsEN.TableName = objDT.Rows[0][contz_CommKeyWords.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objtz_CommKeyWordsEN.TableKey = objDT.Rows[0][contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objtz_CommKeyWordsEN.UpdUser = objDT.Rows[0][contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_CommKeyWordsEN.UpdDate = objDT.Rows[0][contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_CommKeyWordsEN.Memo = objDT.Rows[0][contz_CommKeyWords.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clstz_CommKeyWordsDA: Gettz_CommKeyWords)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKeyId">表关键字</param>
 /// <returns>表对象</returns>
public clstz_CommKeyWordsEN GetObjByKeyId(string strKeyId)
{
CheckPrimaryKey(strKeyId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where KeyId = " + "'"+ strKeyId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
 objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id(字段类型:varchar,字段长度:8,是否可空:False)
 objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clstz_CommKeyWordsDA: GetObjByKeyId)", objException.Message));
}
return objtz_CommKeyWordsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clstz_CommKeyWordsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN()
{
KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(), //关键字Id
Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(), //关键字
TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(), //表名
TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(), //数据表关键字值
UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim() //说明
};
objtz_CommKeyWordsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objtz_CommKeyWordsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clstz_CommKeyWordsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clstz_CommKeyWordsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clstz_CommKeyWordsDA: GetObjByDataRowtz_CommKeyWords)", objException.Message));
}
objtz_CommKeyWordsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objtz_CommKeyWordsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clstz_CommKeyWordsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clstz_CommKeyWordsDA: GetObjByDataRow)", objException.Message));
}
objtz_CommKeyWordsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objtz_CommKeyWordsEN;
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
objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clstz_CommKeyWordsEN._CurrTabName, contz_CommKeyWords.KeyId, 8, "");
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
objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clstz_CommKeyWordsEN._CurrTabName, contz_CommKeyWords.KeyId, 8, strPrefix);
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select KeyId from tz_CommKeyWords where " + strCondition;
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select KeyId from tz_CommKeyWords where " + strCondition;
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
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strKeyId)
{
CheckPrimaryKey(strKeyId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("tz_CommKeyWords", "KeyId = " + "'"+ strKeyId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("tz_CommKeyWords", strCondition))
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
objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("tz_CommKeyWords");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
 {
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_CommKeyWordsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "tz_CommKeyWords");
objRow = objDS.Tables["tz_CommKeyWords"].NewRow();
objRow[contz_CommKeyWords.Keyword] = objtz_CommKeyWordsEN.Keyword; //关键字
objRow[contz_CommKeyWords.TableName] = objtz_CommKeyWordsEN.TableName; //表名
objRow[contz_CommKeyWords.TableKey] = objtz_CommKeyWordsEN.TableKey; //数据表关键字值
 if (objtz_CommKeyWordsEN.UpdUser !=  "")
 {
objRow[contz_CommKeyWords.UpdUser] = objtz_CommKeyWordsEN.UpdUser; //修改者
 }
 if (objtz_CommKeyWordsEN.UpdDate !=  "")
 {
objRow[contz_CommKeyWords.UpdDate] = objtz_CommKeyWordsEN.UpdDate; //修改日期
 }
 if (objtz_CommKeyWordsEN.Memo !=  "")
 {
objRow[contz_CommKeyWords.Memo] = objtz_CommKeyWordsEN.Memo; //说明
 }
objDS.Tables[clstz_CommKeyWordsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clstz_CommKeyWordsEN._CurrTabName);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_CommKeyWordsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Keyword);
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableName);
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableKey);
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdUser);
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdDate);
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Memo);
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_CommKeyWords");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_CommKeyWordsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Keyword);
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableName);
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableKey);
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdUser);
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdDate);
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Memo);
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_CommKeyWords");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_CommKeyWordsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Keyword);
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableName);
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableKey);
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdUser);
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdDate);
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Memo);
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_CommKeyWords");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_CommKeyWordsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Keyword);
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableName);
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.TableKey);
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdUser);
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.UpdDate);
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_CommKeyWords.Memo);
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_CommKeyWords");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewtz_CommKeyWordss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where KeyId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "tz_CommKeyWords");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strKeyId = oRow[contz_CommKeyWords.KeyId].ToString().Trim();
if (IsExist(strKeyId))
{
 string strResult = "关键字变量值为:" + string.Format("KeyId = {0}", strKeyId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clstz_CommKeyWordsEN._CurrTabName ].NewRow();
objRow[contz_CommKeyWords.Keyword] = oRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objRow[contz_CommKeyWords.TableName] = oRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objRow[contz_CommKeyWords.TableKey] = oRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objRow[contz_CommKeyWords.UpdUser] = oRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objRow[contz_CommKeyWords.UpdDate] = oRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objRow[contz_CommKeyWords.Memo] = oRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
 objDS.Tables[clstz_CommKeyWordsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clstz_CommKeyWordsEN._CurrTabName);
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_CommKeyWordsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
strSQL = "Select * from tz_CommKeyWords where KeyId = " + "'"+ objtz_CommKeyWordsEN.KeyId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clstz_CommKeyWordsEN._CurrTabName);
if (objDS.Tables[clstz_CommKeyWordsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:KeyId = " + "'"+ objtz_CommKeyWordsEN.KeyId+"'");
return false;
}
objRow = objDS.Tables[clstz_CommKeyWordsEN._CurrTabName].Rows[0];
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Keyword))
 {
objRow[contz_CommKeyWords.Keyword] = objtz_CommKeyWordsEN.Keyword; //关键字
 }
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableName))
 {
objRow[contz_CommKeyWords.TableName] = objtz_CommKeyWordsEN.TableName; //表名
 }
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableKey))
 {
objRow[contz_CommKeyWords.TableKey] = objtz_CommKeyWordsEN.TableKey; //数据表关键字值
 }
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdUser))
 {
objRow[contz_CommKeyWords.UpdUser] = objtz_CommKeyWordsEN.UpdUser; //修改者
 }
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdDate))
 {
objRow[contz_CommKeyWords.UpdDate] = objtz_CommKeyWordsEN.UpdDate; //修改日期
 }
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Memo))
 {
objRow[contz_CommKeyWords.Memo] = objtz_CommKeyWordsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clstz_CommKeyWordsEN._CurrTabName);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_CommKeyWordsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update tz_CommKeyWords Set ");
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Keyword))
 {
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, contz_CommKeyWords.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.Keyword); //关键字
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableName))
 {
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableName, contz_CommKeyWords.TableName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.TableName); //表名
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableKey))
 {
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, contz_CommKeyWords.TableKey); //数据表关键字值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.TableKey); //数据表关键字值
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdUser))
 {
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, contz_CommKeyWords.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.UpdUser); //修改者
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdDate))
 {
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, contz_CommKeyWords.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.UpdDate); //修改日期
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Memo))
 {
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, contz_CommKeyWords.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KeyId = '{0}'", objtz_CommKeyWordsEN.KeyId); 
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strCondition)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_CommKeyWordsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update tz_CommKeyWords Set ");
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Keyword))
 {
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableName))
 {
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableName = '{0}',", strTableName); //表名
 }
 else
 {
 sbSQL.Append(" TableName = null,"); //表名
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableKey))
 {
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //数据表关键字值
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //数据表关键字值
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdUser))
 {
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdDate))
 {
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Memo))
 {
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_CommKeyWordsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update tz_CommKeyWords Set ");
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Keyword))
 {
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableName))
 {
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableName = '{0}',", strTableName); //表名
 }
 else
 {
 sbSQL.Append(" TableName = null,"); //表名
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableKey))
 {
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //数据表关键字值
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //数据表关键字值
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdUser))
 {
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdDate))
 {
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Memo))
 {
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objtz_CommKeyWordsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_CommKeyWordsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update tz_CommKeyWords Set ");
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Keyword))
 {
 if (objtz_CommKeyWordsEN.Keyword !=  null)
 {
 var strKeyword = objtz_CommKeyWordsEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, contz_CommKeyWords.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.Keyword); //关键字
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableName))
 {
 if (objtz_CommKeyWordsEN.TableName !=  null)
 {
 var strTableName = objtz_CommKeyWordsEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableName, contz_CommKeyWords.TableName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.TableName); //表名
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.TableKey))
 {
 if (objtz_CommKeyWordsEN.TableKey !=  null)
 {
 var strTableKey = objtz_CommKeyWordsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, contz_CommKeyWords.TableKey); //数据表关键字值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.TableKey); //数据表关键字值
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdUser))
 {
 if (objtz_CommKeyWordsEN.UpdUser !=  null)
 {
 var strUpdUser = objtz_CommKeyWordsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, contz_CommKeyWords.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.UpdUser); //修改者
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.UpdDate))
 {
 if (objtz_CommKeyWordsEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_CommKeyWordsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, contz_CommKeyWords.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.UpdDate); //修改日期
 }
 }
 
 if (objtz_CommKeyWordsEN.IsUpdated(contz_CommKeyWords.Memo))
 {
 if (objtz_CommKeyWordsEN.Memo !=  null)
 {
 var strMemo = objtz_CommKeyWordsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, contz_CommKeyWords.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_CommKeyWords.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KeyId = '{0}'", objtz_CommKeyWordsEN.KeyId); 
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
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strKeyId) 
{
CheckPrimaryKey(strKeyId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strKeyId,
};
 objSQL.ExecSP("tz_CommKeyWords_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strKeyId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strKeyId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
//删除tz_CommKeyWords本表中与当前对象有关的记录
strSQL = strSQL + "Delete from tz_CommKeyWords where KeyId = " + "'"+ strKeyId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Deltz_CommKeyWords(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
//删除tz_CommKeyWords本表中与当前对象有关的记录
strSQL = strSQL + "Delete from tz_CommKeyWords where KeyId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strKeyId) 
{
CheckPrimaryKey(strKeyId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
//删除tz_CommKeyWords本表中与当前对象有关的记录
strSQL = strSQL + "Delete from tz_CommKeyWords where KeyId = " + "'"+ strKeyId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Deltz_CommKeyWords(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: Deltz_CommKeyWords)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from tz_CommKeyWords where " + strCondition ;
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
public bool Deltz_CommKeyWordsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clstz_CommKeyWordsDA: Deltz_CommKeyWordsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from tz_CommKeyWords where " + strCondition ;
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
 /// <param name = "objtz_CommKeyWordsENS">源对象</param>
 /// <param name = "objtz_CommKeyWordsENT">目标对象</param>
public void CopyTo(clstz_CommKeyWordsEN objtz_CommKeyWordsENS, clstz_CommKeyWordsEN objtz_CommKeyWordsENT)
{
objtz_CommKeyWordsENT.KeyId = objtz_CommKeyWordsENS.KeyId; //关键字Id
objtz_CommKeyWordsENT.Keyword = objtz_CommKeyWordsENS.Keyword; //关键字
objtz_CommKeyWordsENT.TableName = objtz_CommKeyWordsENS.TableName; //表名
objtz_CommKeyWordsENT.TableKey = objtz_CommKeyWordsENS.TableKey; //数据表关键字值
objtz_CommKeyWordsENT.UpdUser = objtz_CommKeyWordsENS.UpdUser; //修改者
objtz_CommKeyWordsENT.UpdDate = objtz_CommKeyWordsENS.UpdDate; //修改日期
objtz_CommKeyWordsENT.Memo = objtz_CommKeyWordsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objtz_CommKeyWordsEN.Keyword, contz_CommKeyWords.Keyword);
clsCheckSql.CheckFieldNotNull(objtz_CommKeyWordsEN.TableName, contz_CommKeyWords.TableName);
clsCheckSql.CheckFieldNotNull(objtz_CommKeyWordsEN.TableKey, contz_CommKeyWords.TableKey);
//检查字段长度
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.KeyId, 8, contz_CommKeyWords.KeyId);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.Keyword, 50, contz_CommKeyWords.Keyword);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.TableName, 100, contz_CommKeyWords.TableName);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.TableKey, 100, contz_CommKeyWords.TableKey);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.UpdUser, 20, contz_CommKeyWords.UpdUser);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.UpdDate, 20, contz_CommKeyWords.UpdDate);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.Memo, 1000, contz_CommKeyWords.Memo);
//检查字段外键固定长度
 objtz_CommKeyWordsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.Keyword, 50, contz_CommKeyWords.Keyword);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.TableName, 100, contz_CommKeyWords.TableName);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.TableKey, 100, contz_CommKeyWords.TableKey);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.UpdUser, 20, contz_CommKeyWords.UpdUser);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.UpdDate, 20, contz_CommKeyWords.UpdDate);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.Memo, 1000, contz_CommKeyWords.Memo);
//检查外键字段长度
 objtz_CommKeyWordsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.KeyId, 8, contz_CommKeyWords.KeyId);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.Keyword, 50, contz_CommKeyWords.Keyword);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.TableName, 100, contz_CommKeyWords.TableName);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.TableKey, 100, contz_CommKeyWords.TableKey);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.UpdUser, 20, contz_CommKeyWords.UpdUser);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.UpdDate, 20, contz_CommKeyWords.UpdDate);
clsCheckSql.CheckFieldLen(objtz_CommKeyWordsEN.Memo, 1000, contz_CommKeyWords.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.KeyId, contz_CommKeyWords.KeyId);
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.Keyword, contz_CommKeyWords.Keyword);
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.TableName, contz_CommKeyWords.TableName);
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.TableKey, contz_CommKeyWords.TableKey);
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.UpdUser, contz_CommKeyWords.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.UpdDate, contz_CommKeyWords.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objtz_CommKeyWordsEN.Memo, contz_CommKeyWords.Memo);
//检查外键字段长度
 objtz_CommKeyWordsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--tz_CommKeyWords(tz_通用关键字),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clstz_CommKeyWordsEN._CurrTabName);
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clstz_CommKeyWordsEN._CurrTabName, strCondition);
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
 objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}