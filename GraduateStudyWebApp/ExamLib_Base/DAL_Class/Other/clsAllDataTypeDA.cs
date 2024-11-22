
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAllDataTypeDA
 表名:AllDataType(01120531)
 生成代码版本:2021.04.08.1
 生成日期:2021/04/09 01:27:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他
 模块英文名:Other
 框架-层名:数据处理层(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 各种数据类型(AllDataType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsAllDataTypeDA : clsCommBase4DA
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
 public override string _CurrTabName_S
 {
 get
 {
 return clsAllDataTypeEN._CurrTabName_S;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
 clsSpecSQLforSql objSQL = null;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsAllDataTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAllDataTypeEN._ConnectString);
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
 clsSpecSQLforSql objSQL = null;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsAllDataTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAllDataTypeEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = "Select * from AllDataType where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "AllDataType");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("AllDataType_SelectByCond",values, "AllDataType");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AllDataType where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "AllDataType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "AllDataType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "AllDataType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "AllDataType");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_AllDataType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable_AllDataType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AllDataType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AllDataType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} and mId not in (Select top {2} mId from AllDataType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} and mId not in (Select top {3} mId from AllDataType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} and mId not in (Select top {2} mId from AllDataType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} and mId not in (Select top {3} mId from AllDataType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} and mId not in (Select top {2} mId from AllDataType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AllDataType where {1} and mId not in (Select top {3} mId from AllDataType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from AllDataType a where {0} And a.mId not in (Select Top {2} mId From AllDataType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsAllDataTypeDA: GetAllDataTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("AllDataType_SelectByCond",values);
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
public List<clsAllDataTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAllDataTypeDA:GetObjLst)", objException.Message));
}
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号
objAllDataTypeEN._IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAllDataTypeDA: GetObjLst)", objException.Message));
}
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAllDataTypeEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsAllDataTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAllDataTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号
objAllDataTypeEN._IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAllDataTypeDA: GetObjLst)", objException.Message));
}
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAllDataTypeEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsAllDataTypeEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsAllDataTypeDA:GetObjLstBySP)", objException.Message));
}
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("AllDataType_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号
objAllDataTypeEN._IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsAllDataTypeDA: GetObjLstBySP)", objException.Message));
}
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAllDataTypeEN);
	}
objDT = null;
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAllDataType(ref clsAllDataTypeEN objAllDataTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where mId = " + ""+ objAllDataTypeEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return false;
}
try
{
 objAllDataTypeEN.mId = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objAllDataTypeEN.mString = objDT.Rows[0][clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串(字段类型:varchar,字段长度:50,是否可空:True)
 objAllDataTypeEN.mInt = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型(字段类型:int,字段长度:4,是否可空:True)
 objAllDataTypeEN.mLong = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型(字段类型:bigint,字段长度:8,是否可空:True)
 objAllDataTypeEN.mBool = TransNullToBool(objDT.Rows[0][clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型(字段类型:bit,字段长度:1,是否可空:True)
 objAllDataTypeEN.mDouble = TransNullToDouble(objDT.Rows[0][clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度(字段类型:decimal,字段长度:8,是否可空:True)
 objAllDataTypeEN.mFloat = TransNullToFloat(objDT.Rows[0][clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型(字段类型:float,字段长度:8,是否可空:True)
 objAllDataTypeEN.mDate = objDT.Rows[0][clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型(字段类型:varchar,字段长度:20,是否可空:True)
 objAllDataTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objAllDataTypeEN._IsDeleted = TransNullToBool(objDT.Rows[0][clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objAllDataTypeEN._DeletedDate = objDT.Rows[0][clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAllDataTypeDA: GetAllDataType)", objException.Message));
}
objDT = null;
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsAllDataTypeEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
 objAllDataTypeEN.mId = Int32.Parse(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objAllDataTypeEN.mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串(字段类型:varchar,字段长度:50,是否可空:True)
 objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型(字段类型:int,字段长度:4,是否可空:True)
 objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型(字段类型:bigint,字段长度:8,是否可空:True)
 objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型(字段类型:bit,字段长度:1,是否可空:True)
 objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度(字段类型:decimal,字段长度:8,是否可空:True)
 objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型(字段类型:float,字段长度:8,是否可空:True)
 objAllDataTypeEN.mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型(字段类型:varchar,字段长度:20,是否可空:True)
 objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objAllDataTypeEN._DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAllDataTypeDA: GetObjBymId)", objException.Message));
}
objDT = null;
return objAllDataTypeEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程AllDataType_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAllDataTypeOneBySP(clsAllDataTypeEN objAllDataTypeEN)
{
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objAllDataTypeEN.mId
};
 objDT = objSQL.ExecSpReturnDT("AllDataType_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return false;
}
 objAllDataTypeEN.mId = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objAllDataTypeEN.mString = objDT.Rows[0][clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串(字段类型:varchar,字段长度:50,是否可空:True)
 objAllDataTypeEN.mInt = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型(字段类型:int,字段长度:4,是否可空:True)
 objAllDataTypeEN.mLong = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型(字段类型:bigint,字段长度:8,是否可空:True)
 objAllDataTypeEN.mBool = TransNullToBool(objDT.Rows[0][clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型(字段类型:bit,字段长度:1,是否可空:True)
 objAllDataTypeEN.mDouble = TransNullToDouble(objDT.Rows[0][clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度(字段类型:decimal,字段长度:8,是否可空:True)
 objAllDataTypeEN.mFloat = TransNullToFloat(objDT.Rows[0][clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型(字段类型:float,字段长度:8,是否可空:True)
 objAllDataTypeEN.mDate = objDT.Rows[0][clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型(字段类型:varchar,字段长度:20,是否可空:True)
 objAllDataTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objAllDataTypeEN._IsDeleted = TransNullToBool(objDT.Rows[0][clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objAllDataTypeEN._DeletedDate = objDT.Rows[0][clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
objDT = null;
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAllDataTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAllDataTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN()
{
mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()), //mId
mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(), //字符串
mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()), //整型
mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()), //长整型
mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()), //布尔型
mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()), //双精度
mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()), //浮点型
mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(), //日期型
OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()), //序号
_IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()), //是否删除
_DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim() //删除日期
};
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
objDT = null;
return objAllDataTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAllDataTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAllDataTypeEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsAllDataTypeDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("AllDataType_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return null;
}
DataRow objRow = objDT.Rows[0];
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN()
{
mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()), //mId
mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(), //字符串
mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()), //整型
mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()), //长整型
mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()), //布尔型
mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()), //双精度
mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()), //浮点型
mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(), //日期型
OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()), //序号
_IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()), //是否删除
_DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim() //删除日期
};
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
objDT = null;
return objAllDataTypeEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAllDataTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号
objAllDataTypeEN._IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAllDataTypeDA: GetObjByDataRowAllDataType)", objException.Message));
}
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAllDataTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAllDataTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = TransNullToInt(objRow[clsAllDataTypeEN.con_mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = TransNullToInt(objRow[clsAllDataTypeEN.con_mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = TransNullToInt(objRow[clsAllDataTypeEN.con_mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = TransNullToBool(objRow[clsAllDataTypeEN.con_mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = TransNullToDouble(objRow[clsAllDataTypeEN.con_mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = TransNullToFloat(objRow[clsAllDataTypeEN.con_mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = TransNullToInt(objRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim()); //序号
objAllDataTypeEN._IsDeleted = TransNullToBool(objRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAllDataTypeDA: GetObjByDataRow)", objException.Message));
}
objAllDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAllDataTypeEN;
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
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsAllDataTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAllDataTypeEN._CurrTabName_S, clsAllDataTypeEN.con_mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsAllDataTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAllDataTypeEN._CurrTabName_S, clsAllDataTypeEN.con_mId, 8, strPrefix);
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
 List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from AllDataType where " + strCondition;
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
objDT = null;
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
objDT = null;
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from AllDataType where " + strCondition;
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
objDT = null;
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
objDT = null;
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AllDataType", "mId = " + ""+ lngmId+""))
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngmId)
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("AllDataType_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAllDataTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AllDataType", strCondition))
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
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsAllDataTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("AllDataType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAllDataTypeEN objAllDataTypeEN)
 {
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAllDataTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AllDataType");
objRow = objDS.Tables["AllDataType"].NewRow();
 if (objAllDataTypeEN.mString !=  "")
 {
objRow[clsAllDataTypeEN.con_mString] = objAllDataTypeEN.mString; //字符串
 }
objRow[clsAllDataTypeEN.con_mInt] = objAllDataTypeEN.mInt; //整型
objRow[clsAllDataTypeEN.con_mLong] = objAllDataTypeEN.mLong; //长整型
objRow[clsAllDataTypeEN.con_mBool] = objAllDataTypeEN.mBool; //布尔型
objRow[clsAllDataTypeEN.con_mDouble] = objAllDataTypeEN.mDouble; //双精度
objRow[clsAllDataTypeEN.con_mFloat] = objAllDataTypeEN.mFloat; //浮点型
 if (objAllDataTypeEN.mDate !=  "")
 {
objRow[clsAllDataTypeEN.con_mDate] = objAllDataTypeEN.mDate; //日期型
 }
objRow[clsAllDataTypeEN.con_OrderNum] = objAllDataTypeEN.OrderNum; //序号
objRow[clsAllDataTypeEN.con__IsDeleted] = objAllDataTypeEN._IsDeleted; //是否删除
 if (objAllDataTypeEN._DeletedDate !=  "")
 {
objRow[clsAllDataTypeEN.con__DeletedDate] = objAllDataTypeEN._DeletedDate; //删除日期
 }
objDS.Tables[clsAllDataTypeEN._CurrTabName_S].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAllDataTypeEN._CurrTabName_S);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objDA = null;
objDS = null;
objCB = null;
objRow = null;
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAllDataTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAllDataTypeEN.mString !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mString);
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mString + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mInt);
 arrValueListForInsert.Add(objAllDataTypeEN.mInt.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mLong);
 arrValueListForInsert.Add(objAllDataTypeEN.mLong.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mBool);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN.mBool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDouble);
 arrValueListForInsert.Add(objAllDataTypeEN.mDouble.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mFloat);
 arrValueListForInsert.Add(objAllDataTypeEN.mFloat.ToString());
 
 if (objAllDataTypeEN.mDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDate);
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mDate + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_OrderNum);
 arrValueListForInsert.Add(objAllDataTypeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__IsDeleted);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN._IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__DeletedDate);
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN._DeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AllDataType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAllDataTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAllDataTypeEN.mString !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mString);
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mString + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mInt);
 arrValueListForInsert.Add(objAllDataTypeEN.mInt.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mLong);
 arrValueListForInsert.Add(objAllDataTypeEN.mLong.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mBool);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN.mBool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDouble);
 arrValueListForInsert.Add(objAllDataTypeEN.mDouble.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mFloat);
 arrValueListForInsert.Add(objAllDataTypeEN.mFloat.ToString());
 
 if (objAllDataTypeEN.mDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDate);
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mDate + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_OrderNum);
 arrValueListForInsert.Add(objAllDataTypeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__IsDeleted);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN._IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__DeletedDate);
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN._DeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AllDataType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAllDataTypeEN objAllDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAllDataTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAllDataTypeEN.mString !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mString);
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mString + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mInt);
 arrValueListForInsert.Add(objAllDataTypeEN.mInt.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mLong);
 arrValueListForInsert.Add(objAllDataTypeEN.mLong.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mBool);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN.mBool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDouble);
 arrValueListForInsert.Add(objAllDataTypeEN.mDouble.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mFloat);
 arrValueListForInsert.Add(objAllDataTypeEN.mFloat.ToString());
 
 if (objAllDataTypeEN.mDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDate);
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mDate + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_OrderNum);
 arrValueListForInsert.Add(objAllDataTypeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__IsDeleted);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN._IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__DeletedDate);
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN._DeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AllDataType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAllDataTypeEN objAllDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAllDataTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAllDataTypeEN.mString !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mString);
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mString + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mInt);
 arrValueListForInsert.Add(objAllDataTypeEN.mInt.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mLong);
 arrValueListForInsert.Add(objAllDataTypeEN.mLong.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mBool);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN.mBool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDouble);
 arrValueListForInsert.Add(objAllDataTypeEN.mDouble.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mFloat);
 arrValueListForInsert.Add(objAllDataTypeEN.mFloat.ToString());
 
 if (objAllDataTypeEN.mDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_mDate);
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN.mDate + "'");
 }
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con_OrderNum);
 arrValueListForInsert.Add(objAllDataTypeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__IsDeleted);
 arrValueListForInsert.Add("'" + (objAllDataTypeEN._IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(clsAllDataTypeEN.con__DeletedDate);
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objAllDataTypeEN._DeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AllDataType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewAllDataTypeBySP(clsAllDataTypeEN objAllDataTypeEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objAllDataTypeEN.mString,
 objAllDataTypeEN.mInt,
 objAllDataTypeEN.mLong,
 objAllDataTypeEN.mBool,
 objAllDataTypeEN.mDouble,
 objAllDataTypeEN.mFloat,
 objAllDataTypeEN.mDate,
 objAllDataTypeEN.OrderNum,
 objAllDataTypeEN._IsDeleted,
objAllDataTypeEN._DeletedDate
};
 objSQL.ExecSP("AllDataType_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAllDataTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AllDataType");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAllDataTypeEN._CurrTabName_S ].NewRow();
objRow[clsAllDataTypeEN.con_mString] = oRow[clsAllDataTypeEN.con_mString].ToString().Trim(); //字符串
objRow[clsAllDataTypeEN.con_mInt] = oRow[clsAllDataTypeEN.con_mInt].ToString().Trim(); //整型
objRow[clsAllDataTypeEN.con_mLong] = oRow[clsAllDataTypeEN.con_mLong].ToString().Trim(); //长整型
objRow[clsAllDataTypeEN.con_mBool] = oRow[clsAllDataTypeEN.con_mBool].ToString().Trim(); //布尔型
objRow[clsAllDataTypeEN.con_mDouble] = oRow[clsAllDataTypeEN.con_mDouble].ToString().Trim(); //双精度
objRow[clsAllDataTypeEN.con_mFloat] = oRow[clsAllDataTypeEN.con_mFloat].ToString().Trim(); //浮点型
objRow[clsAllDataTypeEN.con_mDate] = oRow[clsAllDataTypeEN.con_mDate].ToString().Trim(); //日期型
objRow[clsAllDataTypeEN.con_OrderNum] = oRow[clsAllDataTypeEN.con_OrderNum].ToString().Trim(); //序号
objRow[clsAllDataTypeEN.con__IsDeleted] = oRow[clsAllDataTypeEN.con__IsDeleted].ToString().Trim(); //是否删除
objRow[clsAllDataTypeEN.con__DeletedDate] = oRow[clsAllDataTypeEN.con__DeletedDate].ToString().Trim(); //删除日期
 objDS.Tables[clsAllDataTypeEN._CurrTabName_S].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAllDataTypeEN._CurrTabName_S);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objDA = null;
objDS = null;
objCB = null;
objRow = null;
objSQL.SQLConnect.Close();
objSQL = null;
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAllDataTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from AllDataType where mId = " + ""+ objAllDataTypeEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAllDataTypeEN._CurrTabName_S);
if (objDS.Tables[clsAllDataTypeEN._CurrTabName_S].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objAllDataTypeEN.mId+"");
return false;
}
objRow = objDS.Tables[clsAllDataTypeEN._CurrTabName_S].Rows[0];
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mString))
 {
objRow[clsAllDataTypeEN.con_mString] = objAllDataTypeEN.mString; //字符串
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mInt))
 {
objRow[clsAllDataTypeEN.con_mInt] = objAllDataTypeEN.mInt; //整型
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mLong))
 {
objRow[clsAllDataTypeEN.con_mLong] = objAllDataTypeEN.mLong; //长整型
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mBool))
 {
objRow[clsAllDataTypeEN.con_mBool] = objAllDataTypeEN.mBool; //布尔型
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDouble))
 {
objRow[clsAllDataTypeEN.con_mDouble] = objAllDataTypeEN.mDouble; //双精度
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mFloat))
 {
objRow[clsAllDataTypeEN.con_mFloat] = objAllDataTypeEN.mFloat; //浮点型
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDate))
 {
objRow[clsAllDataTypeEN.con_mDate] = objAllDataTypeEN.mDate; //日期型
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_OrderNum))
 {
objRow[clsAllDataTypeEN.con_OrderNum] = objAllDataTypeEN.OrderNum; //序号
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__IsDeleted))
 {
objRow[clsAllDataTypeEN.con__IsDeleted] = objAllDataTypeEN._IsDeleted; //是否删除
 }
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__DeletedDate))
 {
objRow[clsAllDataTypeEN.con__DeletedDate] = objAllDataTypeEN._DeletedDate; //删除日期
 }
try
{
objDA.Update(objDS, clsAllDataTypeEN._CurrTabName_S);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objDA = null;
objDS = null;
objCB = null;
objRow = null;
}
return true;
}


 /// <summary>
 /// /// 功能:通过存储过程(StoreProcedure)来修改记录
 /// /// 缺点:1、不能支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySP)
 /// </summary>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySP(clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAllDataTypeEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objAllDataTypeEN.mId,
 objAllDataTypeEN.mString,
 objAllDataTypeEN.mInt,
 objAllDataTypeEN.mLong,
 objAllDataTypeEN.mBool,
 objAllDataTypeEN.mDouble,
 objAllDataTypeEN.mFloat,
 objAllDataTypeEN.mDate,
 objAllDataTypeEN.OrderNum,
 objAllDataTypeEN._IsDeleted,
 objAllDataTypeEN._DeletedDate
};
 objSQL.ExecSP("AllDataType_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAllDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update AllDataType Set ");
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mString))
 {
 if (objAllDataTypeEN.mString !=  null)
 {
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objAllDataTypeEN.mString, clsAllDataTypeEN.con_mString); //字符串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsAllDataTypeEN.con_mString); //字符串
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mInt))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mInt, clsAllDataTypeEN.con_mInt); //整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mLong))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mLong, clsAllDataTypeEN.con_mLong); //长整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mBool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAllDataTypeEN.mBool == true?"1":"0", clsAllDataTypeEN.con_mBool); //布尔型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDouble))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mDouble, clsAllDataTypeEN.con_mDouble); //双精度
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mFloat))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mFloat, clsAllDataTypeEN.con_mFloat); //浮点型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDate))
 {
 if (objAllDataTypeEN.mDate !=  null)
 {
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objAllDataTypeEN.mDate, clsAllDataTypeEN.con_mDate); //日期型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsAllDataTypeEN.con_mDate); //日期型
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.OrderNum, clsAllDataTypeEN.con_OrderNum); //序号
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAllDataTypeEN._IsDeleted == true?"1":"0", clsAllDataTypeEN.con__IsDeleted); //是否删除
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__DeletedDate))
 {
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objAllDataTypeEN._DeletedDate, clsAllDataTypeEN.con__DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsAllDataTypeEN.con__DeletedDate); //删除日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAllDataTypeEN.mId); 
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
 /// <param name = "objAllDataTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAllDataTypeEN objAllDataTypeEN, string strCondition)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAllDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AllDataType Set ");
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mString))
 {
 if (objAllDataTypeEN.mString !=  null)
 {
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" mString = '{0}',", objAllDataTypeEN.mString); //字符串
 }
 else
 {
 sbSQL.Append(" mString = null,"); //字符串
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mInt))
 {
 sbSQL.AppendFormat(" mInt = {0},", objAllDataTypeEN.mInt); //整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mLong))
 {
 sbSQL.AppendFormat(" mLong = {0},", objAllDataTypeEN.mLong); //长整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mBool))
 {
 sbSQL.AppendFormat(" mBool = '{0}',", objAllDataTypeEN.mBool == true?"1":"0"); //布尔型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDouble))
 {
 sbSQL.AppendFormat(" mDouble = {0},", objAllDataTypeEN.mDouble); //双精度
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mFloat))
 {
 sbSQL.AppendFormat(" mFloat = {0},", objAllDataTypeEN.mFloat); //浮点型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDate))
 {
 if (objAllDataTypeEN.mDate !=  null)
 {
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" mDate = '{0}',", objAllDataTypeEN.mDate); //日期型
 }
 else
 {
 sbSQL.Append(" mDate = null,"); //日期型
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objAllDataTypeEN.OrderNum); //序号
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__IsDeleted))
 {
 sbSQL.AppendFormat(" _IsDeleted = '{0}',", objAllDataTypeEN._IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__DeletedDate))
 {
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" _DeletedDate = '{0}',", objAllDataTypeEN._DeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" _DeletedDate = null,"); //删除日期
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
 /// <param name = "objAllDataTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAllDataTypeEN objAllDataTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAllDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AllDataType Set ");
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mString))
 {
 if (objAllDataTypeEN.mString !=  null)
 {
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" mString = '{0}',", objAllDataTypeEN.mString); //字符串
 }
 else
 {
 sbSQL.Append(" mString = null,"); //字符串
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mInt))
 {
 sbSQL.AppendFormat(" mInt = {0},", objAllDataTypeEN.mInt); //整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mLong))
 {
 sbSQL.AppendFormat(" mLong = {0},", objAllDataTypeEN.mLong); //长整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mBool))
 {
 sbSQL.AppendFormat(" mBool = '{0}',", objAllDataTypeEN.mBool == true?"1":"0"); //布尔型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDouble))
 {
 sbSQL.AppendFormat(" mDouble = {0},", objAllDataTypeEN.mDouble); //双精度
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mFloat))
 {
 sbSQL.AppendFormat(" mFloat = {0},", objAllDataTypeEN.mFloat); //浮点型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDate))
 {
 if (objAllDataTypeEN.mDate !=  null)
 {
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" mDate = '{0}',", objAllDataTypeEN.mDate); //日期型
 }
 else
 {
 sbSQL.Append(" mDate = null,"); //日期型
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objAllDataTypeEN.OrderNum); //序号
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__IsDeleted))
 {
 sbSQL.AppendFormat(" _IsDeleted = '{0}',", objAllDataTypeEN._IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__DeletedDate))
 {
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" _DeletedDate = '{0}',", objAllDataTypeEN._DeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" _DeletedDate = null,"); //删除日期
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAllDataTypeEN objAllDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objAllDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAllDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AllDataType Set ");
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mString))
 {
 if (objAllDataTypeEN.mString !=  null)
 {
 objAllDataTypeEN.mString = objAllDataTypeEN.mString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objAllDataTypeEN.mString, clsAllDataTypeEN.con_mString); //字符串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsAllDataTypeEN.con_mString); //字符串
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mInt))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mInt, clsAllDataTypeEN.con_mInt); //整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mLong))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mLong, clsAllDataTypeEN.con_mLong); //长整型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mBool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAllDataTypeEN.mBool == true?"1":"0", clsAllDataTypeEN.con_mBool); //布尔型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDouble))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mDouble, clsAllDataTypeEN.con_mDouble); //双精度
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mFloat))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.mFloat, clsAllDataTypeEN.con_mFloat); //浮点型
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_mDate))
 {
 if (objAllDataTypeEN.mDate !=  null)
 {
 objAllDataTypeEN.mDate = objAllDataTypeEN.mDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objAllDataTypeEN.mDate, clsAllDataTypeEN.con_mDate); //日期型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsAllDataTypeEN.con_mDate); //日期型
 }
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con_OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objAllDataTypeEN.OrderNum, clsAllDataTypeEN.con_OrderNum); //序号
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAllDataTypeEN._IsDeleted == true?"1":"0", clsAllDataTypeEN.con__IsDeleted); //是否删除
 }
 
 if (objAllDataTypeEN.IsUpdated(clsAllDataTypeEN.con__DeletedDate))
 {
 if (objAllDataTypeEN._DeletedDate !=  null)
 {
 objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objAllDataTypeEN._DeletedDate, clsAllDataTypeEN.con__DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsAllDataTypeEN.con__DeletedDate); //删除日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAllDataTypeEN.mId); 
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("AllDataType_Delete", values);
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
//删除AllDataType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AllDataType where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelAllDataType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
//删除AllDataType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AllDataType where mId in (" + strKeyList + ")";
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
//删除AllDataType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AllDataType where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAllDataType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAllDataTypeDA: DelAllDataType)", objException.Message));
}
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AllDataType where " + strCondition ;
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
public bool DelAllDataTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAllDataTypeDA: DelAllDataTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AllDataType where " + strCondition ;
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
 /// <param name = "objAllDataTypeENS">源对象</param>
 /// <param name = "objAllDataTypeENT">目标对象</param>
public void CopyTo(clsAllDataTypeEN objAllDataTypeENS, clsAllDataTypeEN objAllDataTypeENT)
{
objAllDataTypeENT.mId = objAllDataTypeENS.mId; //mId
objAllDataTypeENT.mString = objAllDataTypeENS.mString; //字符串
objAllDataTypeENT.mInt = objAllDataTypeENS.mInt; //整型
objAllDataTypeENT.mLong = objAllDataTypeENS.mLong; //长整型
objAllDataTypeENT.mBool = objAllDataTypeENS.mBool; //布尔型
objAllDataTypeENT.mDouble = objAllDataTypeENS.mDouble; //双精度
objAllDataTypeENT.mFloat = objAllDataTypeENS.mFloat; //浮点型
objAllDataTypeENT.mDate = objAllDataTypeENS.mDate; //日期型
objAllDataTypeENT.OrderNum = objAllDataTypeENS.OrderNum; //序号
objAllDataTypeENT._IsDeleted = objAllDataTypeENS._IsDeleted; //是否删除
objAllDataTypeENT._DeletedDate = objAllDataTypeENS._DeletedDate; //删除日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAllDataTypeEN objAllDataTypeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objAllDataTypeEN.mString, 50, clsAllDataTypeEN.con_mString);
clsCheckSql.CheckFieldLen(objAllDataTypeEN.mDate, 20, clsAllDataTypeEN.con_mDate);
clsCheckSql.CheckFieldLen(objAllDataTypeEN._DeletedDate, 50, clsAllDataTypeEN.con__DeletedDate);
//检查字段外键固定长度
 objAllDataTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAllDataTypeEN objAllDataTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAllDataTypeEN.mString, 50, clsAllDataTypeEN.con_mString);
clsCheckSql.CheckFieldLen(objAllDataTypeEN.mDate, 20, clsAllDataTypeEN.con_mDate);
clsCheckSql.CheckFieldLen(objAllDataTypeEN._DeletedDate, 50, clsAllDataTypeEN.con__DeletedDate);
//检查外键字段长度
 objAllDataTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAllDataTypeEN objAllDataTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAllDataTypeEN.mString, 50, clsAllDataTypeEN.con_mString);
clsCheckSql.CheckFieldLen(objAllDataTypeEN.mDate, 20, clsAllDataTypeEN.con_mDate);
clsCheckSql.CheckFieldLen(objAllDataTypeEN._DeletedDate, 50, clsAllDataTypeEN.con__DeletedDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAllDataTypeEN.mString, clsAllDataTypeEN.con_mString);
clsCheckSql.CheckSqlInjection4Field(objAllDataTypeEN.mDate, clsAllDataTypeEN.con_mDate);
clsCheckSql.CheckSqlInjection4Field(objAllDataTypeEN._DeletedDate, clsAllDataTypeEN.con__DeletedDate);
//检查外键字段长度
 objAllDataTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--AllDataType(各种数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "lngmId">mId(主键)</param>
 /// <returns></returns>
public bool CheckAllDataTypeUniqueness(long lngmId )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("mId !=  {0}", lngmId);
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--AllDataType(各种数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckAllDataTypeUniqueness()
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--AllDataType(各种数据类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "strmString">字符串(要求唯一的字段)</param>
 /// <param name = "intOrderNum">序号(要求唯一的字段)</param>
 /// <returns></returns>
public string GetUniquenessConditionString(clsAllDataTypeEN objAllDataTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mString = '{0}'", objAllDataTypeEN.mString);
 sbCondition.AppendFormat(" and OrderNum = '{0}'", objAllDataTypeEN.OrderNum);
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAllDataTypeEN._CurrTabName_S);
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAllDataTypeEN._CurrTabName_S, strCondition);
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsAllDataTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}