﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSQL_DataBaseDA
 表名:SQL_DataBase(00050172)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// SQL数据库(SQL_DataBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsSQL_DataBaseDA : clsCommBase4DA
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
 return clsSQL_DataBaseEN._CurrTabName;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsSQL_DataBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSQL_DataBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSQL_DataBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSQL_DataBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDataBaseName">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDataBaseName)
{
strDataBaseName = strDataBaseName.Replace("'", "''");
if (strDataBaseName.Length > 50)
{
throw new Exception("(errid:Data000001)在表:SQL_DataBase中,检查关键字,长度不正确!(clsSQL_DataBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDataBaseName)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SQL_DataBase中,关键字不能为空 或 null!(clsSQL_DataBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataBaseName);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSQL_DataBaseDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strDataBaseName">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strDataBaseName)
{
strDataBaseName = strDataBaseName.Replace("'", "''");
if (strDataBaseName.Length > 50 + 4)
{
throw new Exception("(errid:Data000004)在表:SQL_DataBase中,检查关键字,长度不正确!(简化版)(clsSQL_DataBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDataBaseName)  ==  true)
{
throw new Exception("(errid:Data000005)在表:SQL_DataBase中,关键字不能为空 或 null!(clsSQL_DataBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataBaseName);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsSQL_DataBaseDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCond_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = "Select * from SQL_DataBase where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "SQL_DataBase");
 return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("SQL_DataBase_SelectByCond",values, "SQL_DataBase");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "SQL_DataBase");
 return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "SQL_DataBase");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "SQL_DataBase");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns>返回满足条件一定范围的DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSet)ByRange", objException.Message));
}
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "SQL_DataBase");
return objDS;
}

 #endregion 获取数据表的DataSet

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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SQL_DataBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable_SQL_DataBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} SQL_DataBase.* from SQL_DataBase Left Join {1} on {2} where {3} and SQL_DataBase.DataBaseName not in (Select top {5} SQL_DataBase.DataBaseName from SQL_DataBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} and DataBaseName not in (Select top {2} DataBaseName from SQL_DataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} and DataBaseName not in (Select top {3} DataBaseName from SQL_DataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} SQL_DataBase.* from SQL_DataBase Left Join {1} on {2} where {3} and SQL_DataBase.DataBaseName not in (Select top {5} SQL_DataBase.DataBaseName from SQL_DataBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} and DataBaseName not in (Select top {2} DataBaseName from SQL_DataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} and DataBaseName not in (Select top {3} DataBaseName from SQL_DataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} SQL_DataBase.* from SQL_DataBase Left Join {1} on {2} where {3} and SQL_DataBase.DataBaseName not in (Select top {5} SQL_DataBase.DataBaseName from SQL_DataBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} and DataBaseName not in (Select top {2} DataBaseName from SQL_DataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SQL_DataBase where {1} and DataBaseName not in (Select top {3} DataBaseName from SQL_DataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from SQL_DataBase a where {0} And a.DataBaseName not in (Select Top {2} DataBaseName From SQL_DataBase Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSQL_DataBaseDA: GetSQL_DataBaseByRange)", intMaxNum, intMinNum));
 }
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("SQL_DataBase_SelectByCond",values);
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
public List<clsSQL_DataBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA:GetObjLst)", objException.Message));
}
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSQL_DataBaseDA: GetObjLst)", objException.Message));
}
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSQL_DataBaseEN);
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
public List<clsSQL_DataBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSQL_DataBaseDA: GetObjLst)", objException.Message));
}
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsSQL_DataBaseEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA:GetObjLstBySP)", objException.Message));
}
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("SQL_DataBase_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsSQL_DataBaseDA: GetObjLstBySP)", objException.Message));
}
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSQL_DataBase(ref clsSQL_DataBaseEN objSQL_DataBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where DataBaseName = " + "'"+ objSQL_DataBaseEN.DataBaseName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSQL_DataBaseEN.Server = objDT.Rows[0][conSQL_DataBase.Server].ToString().Trim(); //服务器(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.UserId = objDT.Rows[0][conSQL_DataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSQL_DataBaseEN.Password = objDT.Rows[0][conSQL_DataBase.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.UserIdForMaster = objDT.Rows[0][conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master(字段类型:varchar,字段长度:18,是否可空:False)
 objSQL_DataBaseEN.PasswordForMaster = objDT.Rows[0][conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.PrjId = objDT.Rows[0][conSQL_DataBase.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objSQL_DataBaseEN.DatabaseOwner = objDT.Rows[0][conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objSQL_DataBaseEN.DataBaseName = objDT.Rows[0][conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSQL_DataBaseDA: GetSQL_DataBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDataBaseName">表关键字</param>
 /// <returns>表对象</returns>
public clsSQL_DataBaseEN GetObjByDataBaseName(string strDataBaseName)
{
CheckPrimaryKey(strDataBaseName);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where DataBaseName = " + "'"+ strDataBaseName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
 objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master(字段类型:varchar,字段长度:18,是否可空:False)
 objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSQL_DataBaseDA: GetObjByDataBaseName)", objException.Message));
}
return objSQL_DataBaseEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程SQL_DataBase_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSQL_DataBaseOneBySP(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objSQL_DataBaseEN.DataBaseName
};
 objDT = objSQL.ExecSpReturnDT("SQL_DataBase_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objSQL_DataBaseEN.Server = objDT.Rows[0][conSQL_DataBase.Server].ToString().Trim(); //服务器(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.UserId = objDT.Rows[0][conSQL_DataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSQL_DataBaseEN.Password = objDT.Rows[0][conSQL_DataBase.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.UserIdForMaster = objDT.Rows[0][conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master(字段类型:varchar,字段长度:18,是否可空:False)
 objSQL_DataBaseEN.PasswordForMaster = objDT.Rows[0][conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master(字段类型:varchar,字段长度:20,是否可空:False)
 objSQL_DataBaseEN.PrjId = objDT.Rows[0][conSQL_DataBase.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objSQL_DataBaseEN.DatabaseOwner = objDT.Rows[0][conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objSQL_DataBaseEN.DataBaseName = objDT.Rows[0][conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSQL_DataBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN()
{
Server = objRow[conSQL_DataBase.Server].ToString().Trim(), //服务器
UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(), //用户Id
Password = objRow[conSQL_DataBase.Password].ToString().Trim(), //口令
UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(), //用户ID4Master
PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(), //口令4Master
PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(), //工程ID
DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(), //数据库拥有者
DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim() //数据库名
};
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSQL_DataBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSQL_DataBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSQL_DataBaseEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("SQL_DataBase_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN()
{
Server = objRow[conSQL_DataBase.Server].ToString().Trim(), //服务器
UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(), //用户Id
Password = objRow[conSQL_DataBase.Password].ToString().Trim(), //口令
UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(), //用户ID4Master
PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(), //口令4Master
PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(), //工程ID
DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(), //数据库拥有者
DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim() //数据库名
};
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSQL_DataBaseEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSQL_DataBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSQL_DataBaseDA: GetObjByDataRowSQL_DataBase)", objException.Message));
}
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSQL_DataBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSQL_DataBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSQL_DataBaseDA: GetObjByDataRow)", objException.Message));
}
objSQL_DataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSQL_DataBaseEN;
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
objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSQL_DataBaseEN._CurrTabName, conSQL_DataBase.DataBaseName, 50, "");
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
objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSQL_DataBaseEN._CurrTabName, conSQL_DataBase.DataBaseName, 50, strPrefix);
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DataBaseName from SQL_DataBase where " + strCondition;
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DataBaseName from SQL_DataBase where " + strCondition;
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
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDataBaseName)
{
CheckPrimaryKey(strDataBaseName);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SQL_DataBase", "DataBaseName = " + "'"+ strDataBaseName+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistBySP)
 /// </summary>
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strDataBaseName)
{
CheckPrimaryKey(strDataBaseName);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strDataBaseName,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("SQL_DataBase_IsExist", values);
if (arrReturn[0].ToString()  ==  "1")
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SQL_DataBase", strCondition))
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
objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SQL_DataBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSQL_DataBaseEN objSQL_DataBaseEN)
 {
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSQL_DataBaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SQL_DataBase");
objRow = objDS.Tables["SQL_DataBase"].NewRow();
objRow[conSQL_DataBase.Server] = objSQL_DataBaseEN.Server; //服务器
objRow[conSQL_DataBase.UserId] = objSQL_DataBaseEN.UserId; //用户Id
objRow[conSQL_DataBase.Password] = objSQL_DataBaseEN.Password; //口令
objRow[conSQL_DataBase.UserIdForMaster] = objSQL_DataBaseEN.UserIdForMaster; //用户ID4Master
objRow[conSQL_DataBase.PasswordForMaster] = objSQL_DataBaseEN.PasswordForMaster; //口令4Master
objRow[conSQL_DataBase.PrjId] = objSQL_DataBaseEN.PrjId; //工程ID
 if (objSQL_DataBaseEN.DatabaseOwner !=  "")
 {
objRow[conSQL_DataBase.DatabaseOwner] = objSQL_DataBaseEN.DatabaseOwner; //数据库拥有者
 }
objRow[conSQL_DataBase.DataBaseName] = objSQL_DataBaseEN.DataBaseName; //数据库名
objDS.Tables[clsSQL_DataBaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSQL_DataBaseEN._CurrTabName);
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSQL_DataBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSQL_DataBaseEN.Server !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Server);
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Server + "'");
 }
 
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserId);
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserId + "'");
 }
 
 if (objSQL_DataBaseEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Password);
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Password + "'");
 }
 
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserIdForMaster);
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserIdForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PasswordForMaster);
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PasswordForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PrjId);
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PrjId + "'");
 }
 
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DatabaseOwner);
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DatabaseOwner + "'");
 }
 
 if (objSQL_DataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DataBaseName);
 objSQL_DataBaseEN.DataBaseName = objSQL_DataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DataBaseName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SQL_DataBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSQL_DataBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSQL_DataBaseEN.Server !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Server);
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Server + "'");
 }
 
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserId);
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserId + "'");
 }
 
 if (objSQL_DataBaseEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Password);
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Password + "'");
 }
 
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserIdForMaster);
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserIdForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PasswordForMaster);
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PasswordForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PrjId);
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PrjId + "'");
 }
 
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DatabaseOwner);
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DatabaseOwner + "'");
 }
 
 if (objSQL_DataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DataBaseName);
 objSQL_DataBaseEN.DataBaseName = objSQL_DataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DataBaseName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SQL_DataBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSQL_DataBaseEN.DataBaseName;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSQL_DataBaseEN objSQL_DataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSQL_DataBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSQL_DataBaseEN.Server !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Server);
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Server + "'");
 }
 
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserId);
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserId + "'");
 }
 
 if (objSQL_DataBaseEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Password);
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Password + "'");
 }
 
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserIdForMaster);
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserIdForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PasswordForMaster);
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PasswordForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PrjId);
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PrjId + "'");
 }
 
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DatabaseOwner);
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DatabaseOwner + "'");
 }
 
 if (objSQL_DataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DataBaseName);
 objSQL_DataBaseEN.DataBaseName = objSQL_DataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DataBaseName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SQL_DataBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSQL_DataBaseEN.DataBaseName;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSQL_DataBaseEN objSQL_DataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSQL_DataBaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSQL_DataBaseEN.Server !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Server);
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Server + "'");
 }
 
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserId);
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserId + "'");
 }
 
 if (objSQL_DataBaseEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.Password);
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.Password + "'");
 }
 
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.UserIdForMaster);
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.UserIdForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PasswordForMaster);
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PasswordForMaster + "'");
 }
 
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.PrjId);
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.PrjId + "'");
 }
 
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DatabaseOwner);
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DatabaseOwner + "'");
 }
 
 if (objSQL_DataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conSQL_DataBase.DataBaseName);
 objSQL_DataBaseEN.DataBaseName = objSQL_DataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSQL_DataBaseEN.DataBaseName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SQL_DataBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewSQL_DataBaseBySP(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objSQL_DataBaseEN.Server,
 objSQL_DataBaseEN.UserId,
 objSQL_DataBaseEN.Password,
 objSQL_DataBaseEN.UserIdForMaster,
 objSQL_DataBaseEN.PasswordForMaster,
 objSQL_DataBaseEN.PrjId,
 objSQL_DataBaseEN.DatabaseOwner,
objSQL_DataBaseEN.DataBaseName
};
 objSQL.ExecSP("SQL_DataBase_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSQL_DataBases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where DataBaseName = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SQL_DataBase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDataBaseName = oRow[conSQL_DataBase.DataBaseName].ToString().Trim();
if (IsExist(strDataBaseName))
{
 string strResult = "关键字变量值为:" + string.Format("DataBaseName = {0}", strDataBaseName) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSQL_DataBaseEN._CurrTabName ].NewRow();
objRow[conSQL_DataBase.Server] = oRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objRow[conSQL_DataBase.UserId] = oRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objRow[conSQL_DataBase.Password] = oRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objRow[conSQL_DataBase.UserIdForMaster] = oRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objRow[conSQL_DataBase.PasswordForMaster] = oRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objRow[conSQL_DataBase.PrjId] = oRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程ID
objRow[conSQL_DataBase.DatabaseOwner] = oRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objRow[conSQL_DataBase.DataBaseName] = oRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
 objDS.Tables[clsSQL_DataBaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSQL_DataBaseEN._CurrTabName);
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
 /// <param name = "objSQL_DataBaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSQL_DataBaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
strSQL = "Select * from SQL_DataBase where DataBaseName = " + "'"+ objSQL_DataBaseEN.DataBaseName+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSQL_DataBaseEN._CurrTabName);
if (objDS.Tables[clsSQL_DataBaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DataBaseName = " + "'"+ objSQL_DataBaseEN.DataBaseName+"'");
return false;
}
objRow = objDS.Tables[clsSQL_DataBaseEN._CurrTabName].Rows[0];
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Server))
 {
objRow[conSQL_DataBase.Server] = objSQL_DataBaseEN.Server; //服务器
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserId))
 {
objRow[conSQL_DataBase.UserId] = objSQL_DataBaseEN.UserId; //用户Id
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Password))
 {
objRow[conSQL_DataBase.Password] = objSQL_DataBaseEN.Password; //口令
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserIdForMaster))
 {
objRow[conSQL_DataBase.UserIdForMaster] = objSQL_DataBaseEN.UserIdForMaster; //用户ID4Master
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PasswordForMaster))
 {
objRow[conSQL_DataBase.PasswordForMaster] = objSQL_DataBaseEN.PasswordForMaster; //口令4Master
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PrjId))
 {
objRow[conSQL_DataBase.PrjId] = objSQL_DataBaseEN.PrjId; //工程ID
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.DatabaseOwner))
 {
objRow[conSQL_DataBase.DatabaseOwner] = objSQL_DataBaseEN.DatabaseOwner; //数据库拥有者
 }
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.DataBaseName))
 {
objRow[conSQL_DataBase.DataBaseName] = objSQL_DataBaseEN.DataBaseName; //数据库名
 }
try
{
objDA.Update(objDS, clsSQL_DataBaseEN._CurrTabName);
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
 /// /// 功能:通过存储过程(StoreProcedure)来修改记录
 /// /// 缺点:1、不能支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySP)
 /// </summary>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySP(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSQL_DataBaseEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objSQL_DataBaseEN.Server,
 objSQL_DataBaseEN.UserId,
 objSQL_DataBaseEN.Password,
 objSQL_DataBaseEN.UserIdForMaster,
 objSQL_DataBaseEN.PasswordForMaster,
 objSQL_DataBaseEN.PrjId,
 objSQL_DataBaseEN.DatabaseOwner,
 objSQL_DataBaseEN.DataBaseName
};
 objSQL.ExecSP("SQL_DataBase_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSQL_DataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SQL_DataBase Set ");
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Server))
 {
 if (objSQL_DataBaseEN.Server !=  null)
 {
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.Server, conSQL_DataBase.Server); //服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.Server); //服务器
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserId))
 {
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.UserId, conSQL_DataBase.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.UserId); //用户Id
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Password))
 {
 if (objSQL_DataBaseEN.Password !=  null)
 {
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.Password, conSQL_DataBase.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.Password); //口令
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserIdForMaster))
 {
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.UserIdForMaster, conSQL_DataBase.UserIdForMaster); //用户ID4Master
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.UserIdForMaster); //用户ID4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PasswordForMaster))
 {
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.PasswordForMaster, conSQL_DataBase.PasswordForMaster); //口令4Master
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.PasswordForMaster); //口令4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PrjId))
 {
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.PrjId, conSQL_DataBase.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.PrjId); //工程ID
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.DatabaseOwner))
 {
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.DatabaseOwner, conSQL_DataBase.DatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.DatabaseOwner); //数据库拥有者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataBaseName = '{0}'", objSQL_DataBaseEN.DataBaseName); 
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
 /// <param name = "objSQL_DataBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSQL_DataBaseEN objSQL_DataBaseEN, string strCondition)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSQL_DataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SQL_DataBase Set ");
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Server))
 {
 if (objSQL_DataBaseEN.Server !=  null)
 {
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Server = '{0}',", objSQL_DataBaseEN.Server); //服务器
 }
 else
 {
 sbSQL.Append(" Server = null,"); //服务器
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserId))
 {
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", objSQL_DataBaseEN.UserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Password))
 {
 if (objSQL_DataBaseEN.Password !=  null)
 {
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", objSQL_DataBaseEN.Password); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserIdForMaster))
 {
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserIdForMaster = '{0}',", objSQL_DataBaseEN.UserIdForMaster); //用户ID4Master
 }
 else
 {
 sbSQL.Append(" UserIdForMaster = null,"); //用户ID4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PasswordForMaster))
 {
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PasswordForMaster = '{0}',", objSQL_DataBaseEN.PasswordForMaster); //口令4Master
 }
 else
 {
 sbSQL.Append(" PasswordForMaster = null,"); //口令4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PrjId))
 {
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", objSQL_DataBaseEN.PrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.DatabaseOwner))
 {
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DatabaseOwner = '{0}',", objSQL_DataBaseEN.DatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.Append(" DatabaseOwner = null,"); //数据库拥有者
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
 /// <param name = "objSQL_DataBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSQL_DataBaseEN objSQL_DataBaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSQL_DataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SQL_DataBase Set ");
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Server))
 {
 if (objSQL_DataBaseEN.Server !=  null)
 {
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Server = '{0}',", objSQL_DataBaseEN.Server); //服务器
 }
 else
 {
 sbSQL.Append(" Server = null,"); //服务器
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserId))
 {
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", objSQL_DataBaseEN.UserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Password))
 {
 if (objSQL_DataBaseEN.Password !=  null)
 {
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", objSQL_DataBaseEN.Password); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserIdForMaster))
 {
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserIdForMaster = '{0}',", objSQL_DataBaseEN.UserIdForMaster); //用户ID4Master
 }
 else
 {
 sbSQL.Append(" UserIdForMaster = null,"); //用户ID4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PasswordForMaster))
 {
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PasswordForMaster = '{0}',", objSQL_DataBaseEN.PasswordForMaster); //口令4Master
 }
 else
 {
 sbSQL.Append(" PasswordForMaster = null,"); //口令4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PrjId))
 {
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", objSQL_DataBaseEN.PrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.DatabaseOwner))
 {
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DatabaseOwner = '{0}',", objSQL_DataBaseEN.DatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.Append(" DatabaseOwner = null,"); //数据库拥有者
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSQL_DataBaseEN objSQL_DataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSQL_DataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSQL_DataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SQL_DataBase Set ");
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Server))
 {
 if (objSQL_DataBaseEN.Server !=  null)
 {
 objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.Server, conSQL_DataBase.Server); //服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.Server); //服务器
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserId))
 {
 if (objSQL_DataBaseEN.UserId !=  null)
 {
 objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.UserId, conSQL_DataBase.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.UserId); //用户Id
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.Password))
 {
 if (objSQL_DataBaseEN.Password !=  null)
 {
 objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.Password, conSQL_DataBase.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.Password); //口令
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.UserIdForMaster))
 {
 if (objSQL_DataBaseEN.UserIdForMaster !=  null)
 {
 objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.UserIdForMaster, conSQL_DataBase.UserIdForMaster); //用户ID4Master
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.UserIdForMaster); //用户ID4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PasswordForMaster))
 {
 if (objSQL_DataBaseEN.PasswordForMaster !=  null)
 {
 objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.PasswordForMaster, conSQL_DataBase.PasswordForMaster); //口令4Master
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.PasswordForMaster); //口令4Master
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.PrjId))
 {
 if (objSQL_DataBaseEN.PrjId !=  null)
 {
 objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.PrjId, conSQL_DataBase.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.PrjId); //工程ID
 }
 }
 
 if (objSQL_DataBaseEN.IsUpdated(conSQL_DataBase.DatabaseOwner))
 {
 if (objSQL_DataBaseEN.DatabaseOwner !=  null)
 {
 objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSQL_DataBaseEN.DatabaseOwner, conSQL_DataBase.DatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSQL_DataBase.DatabaseOwner); //数据库拥有者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataBaseName = '{0}'", objSQL_DataBaseEN.DataBaseName); 
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
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDataBaseName) 
{
CheckPrimaryKey(strDataBaseName);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDataBaseName,
};
 objSQL.ExecSP("SQL_DataBase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDataBaseName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDataBaseName);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
//删除SQL_DataBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SQL_DataBase where DataBaseName = " + "'"+ strDataBaseName+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSQL_DataBase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
//删除SQL_DataBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SQL_DataBase where DataBaseName in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDataBaseName) 
{
CheckPrimaryKey(strDataBaseName);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
//删除SQL_DataBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SQL_DataBase where DataBaseName = " + "'"+ strDataBaseName+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSQL_DataBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: DelSQL_DataBase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SQL_DataBase where " + strCondition ;
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
public bool DelSQL_DataBaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSQL_DataBaseDA: DelSQL_DataBaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SQL_DataBase where " + strCondition ;
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
 /// <param name = "objSQL_DataBaseENS">源对象</param>
 /// <param name = "objSQL_DataBaseENT">目标对象</param>
public void CopyTo(clsSQL_DataBaseEN objSQL_DataBaseENS, clsSQL_DataBaseEN objSQL_DataBaseENT)
{
objSQL_DataBaseENT.Server = objSQL_DataBaseENS.Server; //服务器
objSQL_DataBaseENT.UserId = objSQL_DataBaseENS.UserId; //用户Id
objSQL_DataBaseENT.Password = objSQL_DataBaseENS.Password; //口令
objSQL_DataBaseENT.UserIdForMaster = objSQL_DataBaseENS.UserIdForMaster; //用户ID4Master
objSQL_DataBaseENT.PasswordForMaster = objSQL_DataBaseENS.PasswordForMaster; //口令4Master
objSQL_DataBaseENT.PrjId = objSQL_DataBaseENS.PrjId; //工程ID
objSQL_DataBaseENT.DatabaseOwner = objSQL_DataBaseENS.DatabaseOwner; //数据库拥有者
objSQL_DataBaseENT.DataBaseName = objSQL_DataBaseENS.DataBaseName; //数据库名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSQL_DataBaseEN.Server, conSQL_DataBase.Server);
clsCheckSql.CheckFieldNotNull(objSQL_DataBaseEN.UserId, conSQL_DataBase.UserId);
clsCheckSql.CheckFieldNotNull(objSQL_DataBaseEN.Password, conSQL_DataBase.Password);
clsCheckSql.CheckFieldNotNull(objSQL_DataBaseEN.UserIdForMaster, conSQL_DataBase.UserIdForMaster);
clsCheckSql.CheckFieldNotNull(objSQL_DataBaseEN.PasswordForMaster, conSQL_DataBase.PasswordForMaster);
clsCheckSql.CheckFieldNotNull(objSQL_DataBaseEN.PrjId, conSQL_DataBase.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.Server, 20, conSQL_DataBase.Server);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.UserId, 18, conSQL_DataBase.UserId);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.Password, 20, conSQL_DataBase.Password);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.UserIdForMaster, 18, conSQL_DataBase.UserIdForMaster);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.PasswordForMaster, 20, conSQL_DataBase.PasswordForMaster);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.PrjId, 4, conSQL_DataBase.PrjId);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.DatabaseOwner, 30, conSQL_DataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.DataBaseName, 50, conSQL_DataBase.DataBaseName);
//检查字段外键固定长度
 objSQL_DataBaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.Server, 20, conSQL_DataBase.Server);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.UserId, 18, conSQL_DataBase.UserId);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.Password, 20, conSQL_DataBase.Password);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.UserIdForMaster, 18, conSQL_DataBase.UserIdForMaster);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.PasswordForMaster, 20, conSQL_DataBase.PasswordForMaster);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.PrjId, 4, conSQL_DataBase.PrjId);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.DatabaseOwner, 30, conSQL_DataBase.DatabaseOwner);
//检查外键字段长度
 objSQL_DataBaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.Server, 20, conSQL_DataBase.Server);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.UserId, 18, conSQL_DataBase.UserId);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.Password, 20, conSQL_DataBase.Password);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.UserIdForMaster, 18, conSQL_DataBase.UserIdForMaster);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.PasswordForMaster, 20, conSQL_DataBase.PasswordForMaster);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.PrjId, 4, conSQL_DataBase.PrjId);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.DatabaseOwner, 30, conSQL_DataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objSQL_DataBaseEN.DataBaseName, 50, conSQL_DataBase.DataBaseName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.Server, conSQL_DataBase.Server);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.UserId, conSQL_DataBase.UserId);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.Password, conSQL_DataBase.Password);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.UserIdForMaster, conSQL_DataBase.UserIdForMaster);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.PasswordForMaster, conSQL_DataBase.PasswordForMaster);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.PrjId, conSQL_DataBase.PrjId);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.DatabaseOwner, conSQL_DataBase.DatabaseOwner);
clsCheckSql.CheckSqlInjection4Field(objSQL_DataBaseEN.DataBaseName, conSQL_DataBase.DataBaseName);
//检查外键字段长度
 objSQL_DataBaseEN._IsCheckProperty = true;
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSQL_DataBaseEN._CurrTabName);
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSQL_DataBaseEN._CurrTabName, strCondition);
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
 objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}