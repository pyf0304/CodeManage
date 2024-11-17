
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolDA
 表名:XzSchool(01160012)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/19 02:35:46
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:系统管理
 模块英文名:SysManage
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
using CommonTable.Entity;
using SimplePrj.Entity;

namespace SimplePrj.DAL
{
 /// <summary>
 /// 学校(XzSchool)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsXzSchoolDA : clsCommBase4DA
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
 return clsXzSchoolEN._CurrTabName_S;
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
if (string.IsNullOrEmpty(clsXzSchoolEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzSchoolEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzSchoolEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzSchoolEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strid_School">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strid_School)
{
strid_School = strid_School.Replace("'", "''");
if (strid_School.Length > 4)
{
throw new Exception("(errid:Data000001)在表:XzSchool中,检查关键字,长度不正确!(clsXzSchoolDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strid_School)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzSchool中,关键字不能为空 或 null!(clsXzSchoolDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_School);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzSchoolDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strid_School">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strid_School)
{
strid_School = strid_School.Replace("'", "''");
if (strid_School.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:XzSchool中,检查关键字,长度不正确!(简化版)(clsXzSchoolDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strid_School)  ==  true)
{
throw new Exception("(errid:Data000005)在表:XzSchool中,关键字不能为空 或 null!(clsXzSchoolDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_School);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsXzSchoolDA:CheckPrimaryKey)", objException.Message));
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = "Select * from XzSchool where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("XzSchool_SelectByCond",values, "XzSchool");
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzSchool where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSet)ByRange", objException.Message));
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCond_V_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetV(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000013)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetV)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = "Select * from vXzSchool where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vXzSchool");
 return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_V_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000014)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetVByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的一定范围的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_V_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000068)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetVByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的一定范围的数据集,用DataSet表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_V_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000069)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataSetVByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {3} And {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0} order by {3})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
 objDS = objSQL.GetDataSet(strSQL, "XzSchool");
 return objDS;
}

 #endregion 获取数据表的DataSet

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSet_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSet_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzSchool(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_XzSchool)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSet_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByTabName_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSet_S_IsCheckSQLAttack)
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByTabName_S_IsCheckSQLAttack)
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopCondRecSet_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.TopSize, objTopPara.WhereCond, objTopPara.OrderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopCondRecSet_S)
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopCondRecSet_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzSchool where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopCondRecSet_S_IsCheckSQLAttack)
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzSchool where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByPager_S)
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and id_School not in (Select top {2} id_School from XzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and id_School not in (Select top {3} id_School from XzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByPager_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and id_School not in (Select top {2} id_School from XzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and id_School not in (Select top {3} id_School from XzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByPager_S_IsCheckSQLAttack)
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and id_School not in (Select top {2} id_School from XzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and id_School not in (Select top {3} id_School from XzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByRange_S)
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from XzSchool a where {0} And a.id_School not in (Select Top {2} id_School From XzSchool Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzSchool_SelectByCond",values);
return objDT;
}


 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetV_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回已经转换代码的DataTable</returns>
public System.Data.DataTable GetDataTableV(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000031)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableV)", objException.Message));
}
StringBuilder strSQL = new StringBuilder(); 
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL.Append("Select vXzSchool.* ");
strSQL.Append(" from vXzSchool ");
strSQL.Append(" where " + strCondition); 
objDT = objSQL.GetDataTable(strSQL.ToString());
return objDT;
}

 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetV_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回已经转换代码的DataTable</returns>
public System.Data.DataTable GetDataTable_XzSchoolV(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000032)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_XzSchoolV)", objException.Message));
}
StringBuilder strSQL = new StringBuilder(); 
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL.Append("Select vXzSchool.* ");
strSQL.Append(" from vXzSchool ");
strSQL.Append(" where " + strCondition); 
objDT = objSQL.GetDataTable(strSQL.ToString());
return objDT;
}

 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetV_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回已经转换代码的DataTable</returns>
public System.Data.DataTable GetDataTableV(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000033)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetDataTableV)", objException.Message));
}
StringBuilder strSQL = new StringBuilder(); 
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL.Append("Select vXzSchool.* ");
strSQL.Append(" from vXzSchool ");
strSQL.Append(" where " + strCondition); 
objDT = objSQL.GetDataTable(strSQL.ToString());
return objDT;
}


 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByRangeV_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000034)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableVByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByRangeV_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000072)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableVByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击.
 /// (AutoGCLib.clsGeneCodeBase:GenGetCondRecSetByRangeV_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsXzSchoolDA: GetXzSchoolByRange)", intMaxNum, intMinNum));
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000073)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableVByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vXzSchool a where {0} And a.id_School not in (Select Top {2} id_School From vXzSchool Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
public List<clsXzSchoolEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetObjLst)", objException.Message));
}
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzSchoolDA: GetObjLst)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzSchoolEN);
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
public List<clsXzSchoolEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzSchoolDA: GetObjLst)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzSchoolEN);
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
public List<clsXzSchoolEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetObjLstBySP)", objException.Message));
}
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzSchool_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsXzSchoolDA: GetObjLstBySP)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzSchoolEN);
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
 /// <param name = "objXzSchoolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzSchool(ref clsXzSchoolEN objXzSchoolEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where id_School = " + "'"+ objXzSchoolEN.id_School+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return false;
}
try
{
 objXzSchoolEN.id_School = objDT.Rows[0][clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzSchoolEN.SchoolId = objDT.Rows[0][clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objXzSchoolEN.SchoolName = objDT.Rows[0][clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objXzSchoolEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objXzSchoolEN.Memo = objDT.Rows[0][clsXzSchoolEN.con_Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzSchoolDA: GetXzSchool)", objException.Message));
}
objDT = null;
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public clsXzSchoolEN GetObjByid_School(string strid_School)
{
CheckPrimaryKey_Sim(strid_School);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where id_School = " + "'"+ strid_School+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
 objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzSchoolDA: GetObjByid_School)", objException.Message));
}
objDT = null;
return objXzSchoolEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程XzSchool_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzSchoolOneBySP(clsXzSchoolEN objXzSchoolEN)
{
System.Data.DataTable objDT = null; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objXzSchoolEN.id_School
};
 objDT = objSQL.ExecSpReturnDT("XzSchool_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return false;
}
 objXzSchoolEN.id_School = objDT.Rows[0][clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzSchoolEN.SchoolId = objDT.Rows[0][clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objXzSchoolEN.SchoolName = objDT.Rows[0][clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objXzSchoolEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objXzSchoolEN.Memo = objDT.Rows[0][clsXzSchoolEN.con_Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
objDT = null;
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzSchoolEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN()
{
id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(), //学校流水号
SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(), //学校Id
SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(), //学校名称
IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()), //是否当前使用
Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim() //备注
};
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
objDT = null;
return objXzSchoolEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzSchoolDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzSchoolEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("XzSchool_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
objDT = null;
return null;
}
DataRow objRow = objDT.Rows[0];
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN()
{
id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(), //学校流水号
SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(), //学校Id
SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(), //学校名称
IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()), //是否当前使用
Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim() //备注
};
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
objDT = null;
return objXzSchoolEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzSchoolEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzSchoolDA: GetObjByDataRowXzSchool)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzSchoolEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzSchoolEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzSchoolDA: GetObjByDataRow)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzSchoolEN;
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
objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzSchoolEN._CurrTabName_S, clsXzSchoolEN.con_id_School, 4, "");
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
objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzSchoolEN._CurrTabName_S, clsXzSchoolEN.con_id_School, 4, strPrefix);
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
 List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select id_School from XzSchool where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
objDT = null;
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
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select id_School from XzSchool where " + strCondition;
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
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strid_School)
{
CheckPrimaryKey_Sim(strid_School);
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzSchool", "id_School = " + "'"+ strid_School+"'"))
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
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strid_School)
{
CheckPrimaryKey(strid_School);
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strid_School,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("XzSchool_IsExist", values);
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
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzSchoolDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzSchool", strCondition))
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
objSQL = clsXzSchoolDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzSchool");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzSchoolEN objXzSchoolEN)
 {
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzSchool");
objRow = objDS.Tables["XzSchool"].NewRow();
objRow[clsXzSchoolEN.con_id_School] = objXzSchoolEN.id_School; //学校流水号
objRow[clsXzSchoolEN.con_SchoolId] = objXzSchoolEN.SchoolId; //学校Id
objRow[clsXzSchoolEN.con_SchoolName] = objXzSchoolEN.SchoolName; //学校名称
objRow[clsXzSchoolEN.con_IsCurrentUse] = objXzSchoolEN.IsCurrentUse; //是否当前使用
 if (objXzSchoolEN.Memo !=  "")
 {
objRow[clsXzSchoolEN.con_Memo] = objXzSchoolEN.Memo; //备注
 }
objDS.Tables[clsXzSchoolEN._CurrTabName_S].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzSchoolEN._CurrTabName_S);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzSchoolEN.id_School !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_id_School);
 objXzSchoolEN.id_School = objXzSchoolEN.id_School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.id_School + "'");
 }
 
 if (objXzSchoolEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_SchoolId);
 objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.SchoolId + "'");
 }
 
 if (objXzSchoolEN.SchoolName !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_SchoolName);
 objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.SchoolName + "'");
 }
 
 arrFieldListForInsert.Add(clsXzSchoolEN.con_IsCurrentUse);
 arrValueListForInsert.Add("'" + (objXzSchoolEN.IsCurrentUse  ==  false ? "0" : "1") + "'");
 
 if (objXzSchoolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_Memo);
 objXzSchoolEN.Memo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzSchool");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzSchoolEN objXzSchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzSchoolEN.id_School !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_id_School);
 objXzSchoolEN.id_School = objXzSchoolEN.id_School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.id_School + "'");
 }
 
 if (objXzSchoolEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_SchoolId);
 objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.SchoolId + "'");
 }
 
 if (objXzSchoolEN.SchoolName !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_SchoolName);
 objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.SchoolName + "'");
 }
 
 arrFieldListForInsert.Add(clsXzSchoolEN.con_IsCurrentUse);
 arrValueListForInsert.Add("'" + (objXzSchoolEN.IsCurrentUse  ==  false ? "0" : "1") + "'");
 
 if (objXzSchoolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(clsXzSchoolEN.con_Memo);
 objXzSchoolEN.Memo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objXzSchoolEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzSchool");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewXzSchoolBySP(clsXzSchoolEN objXzSchoolEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objXzSchoolEN.id_School,
 objXzSchoolEN.SchoolId,
 objXzSchoolEN.SchoolName,
 objXzSchoolEN.IsCurrentUse,
objXzSchoolEN.Memo
};
 objSQL.ExecSP("XzSchool_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzSchools(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where id_School = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzSchool");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strid_School = oRow[clsXzSchoolEN.con_id_School].ToString().Trim();
if (IsExist(strid_School))
{
 string strResult = "关键字变量值为:" + string.Format("id_School = {0}", strid_School) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzSchoolEN._CurrTabName_S ].NewRow();
objRow[clsXzSchoolEN.con_id_School] = oRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objRow[clsXzSchoolEN.con_SchoolId] = oRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objRow[clsXzSchoolEN.con_SchoolName] = oRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objRow[clsXzSchoolEN.con_IsCurrentUse] = oRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim(); //是否当前使用
objRow[clsXzSchoolEN.con_Memo] = oRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
 objDS.Tables[clsXzSchoolEN._CurrTabName_S].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzSchoolEN._CurrTabName_S);
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
 /// <param name = "objXzSchoolEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where id_School = " + "'"+ objXzSchoolEN.id_School+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzSchoolEN._CurrTabName_S);
if (objDS.Tables[clsXzSchoolEN._CurrTabName_S].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:id_School = " + "'"+ objXzSchoolEN.id_School+"'");
return false;
}
objRow = objDS.Tables[clsXzSchoolEN._CurrTabName_S].Rows[0];
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_id_School))
 {
objRow[clsXzSchoolEN.con_id_School] = objXzSchoolEN.id_School; //学校流水号
 }
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolId))
 {
objRow[clsXzSchoolEN.con_SchoolId] = objXzSchoolEN.SchoolId; //学校Id
 }
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolName))
 {
objRow[clsXzSchoolEN.con_SchoolName] = objXzSchoolEN.SchoolName; //学校名称
 }
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_IsCurrentUse))
 {
objRow[clsXzSchoolEN.con_IsCurrentUse] = objXzSchoolEN.IsCurrentUse; //是否当前使用
 }
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_Memo))
 {
objRow[clsXzSchoolEN.con_Memo] = objXzSchoolEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsXzSchoolEN._CurrTabName_S);
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
public bool UpdateBySP(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objXzSchoolEN.id_School,
 objXzSchoolEN.SchoolId,
 objXzSchoolEN.SchoolName,
 objXzSchoolEN.IsCurrentUse,
 objXzSchoolEN.Memo
};
 objSQL.ExecSP("XzSchool_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objXzSchoolEN.SchoolId, clsXzSchoolEN.con_SchoolId); //学校Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsXzSchoolEN.con_SchoolId); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objXzSchoolEN.SchoolName, clsXzSchoolEN.con_SchoolName); //学校名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsXzSchoolEN.con_SchoolName); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_IsCurrentUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0", clsXzSchoolEN.con_IsCurrentUse); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 objXzSchoolEN.Memo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objXzSchoolEN.Memo, clsXzSchoolEN.con_Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsXzSchoolEN.con_Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id_School = '{0}'", objXzSchoolEN.id_School); 
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzSchoolEN objXzSchoolEN, string strCondition)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolId = '{0}',", objXzSchoolEN.SchoolId); //学校Id
 }
 else
 {
 sbSQL.Append(" SchoolId = null,"); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolName = '{0}',", objXzSchoolEN.SchoolName); //学校名称
 }
 else
 {
 sbSQL.Append(" SchoolName = null,"); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_IsCurrentUse))
 {
 sbSQL.AppendFormat(" IsCurrentUse = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0"); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 objXzSchoolEN.Memo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objXzSchoolEN.Memo); //备注
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzSchoolEN objXzSchoolEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolId = '{0}',", objXzSchoolEN.SchoolId); //学校Id
 }
 else
 {
 sbSQL.Append(" SchoolId = null,"); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolName = '{0}',", objXzSchoolEN.SchoolName); //学校名称
 }
 else
 {
 sbSQL.Append(" SchoolName = null,"); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_IsCurrentUse))
 {
 sbSQL.AppendFormat(" IsCurrentUse = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0"); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 objXzSchoolEN.Memo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objXzSchoolEN.Memo); //备注
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzSchoolEN objXzSchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objXzSchoolEN.SchoolId, clsXzSchoolEN.con_SchoolId); //学校Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsXzSchoolEN.con_SchoolId); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objXzSchoolEN.SchoolName, clsXzSchoolEN.con_SchoolName); //学校名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsXzSchoolEN.con_SchoolName); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_IsCurrentUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0", clsXzSchoolEN.con_IsCurrentUse); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(clsXzSchoolEN.con_Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 objXzSchoolEN.Memo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objXzSchoolEN.Memo, clsXzSchoolEN.con_Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",clsXzSchoolEN.con_Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id_School = '{0}'", objXzSchoolEN.id_School); 
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
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strid_School) 
{
CheckPrimaryKey(strid_School);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strid_School,
};
 objSQL.ExecSP("XzSchool_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strid_School">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strid_School, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strid_School);
string strSQL = "";
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
//删除XzSchool本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzSchool where id_School = " + "'"+ strid_School+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzSchool(List<string> lstKey)
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
//删除XzSchool本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzSchool where id_School in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strid_School) 
{
CheckPrimaryKey(strid_School);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
//删除XzSchool本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzSchool where id_School = " + "'"+ strid_School+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzSchool(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzSchoolDA: DelXzSchool)", objException.Message));
}
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzSchool where " + strCondition ;
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
public bool DelXzSchoolWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzSchoolDA: DelXzSchoolWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzSchool where " + strCondition ;
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
public void CopyTo(clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
objXzSchoolENT.id_School = objXzSchoolENS.id_School; //学校流水号
objXzSchoolENT.SchoolId = objXzSchoolENS.SchoolId; //学校Id
objXzSchoolENT.SchoolName = objXzSchoolENS.SchoolName; //学校名称
objXzSchoolENT.IsCurrentUse = objXzSchoolENS.IsCurrentUse; //是否当前使用
objXzSchoolENT.Memo = objXzSchoolENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzSchoolEN objXzSchoolEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzSchoolEN.SchoolId, clsXzSchoolEN.con_SchoolId);
clsCheckSql.CheckFieldNotNull(objXzSchoolEN.SchoolName, clsXzSchoolEN.con_SchoolName);
clsCheckSql.CheckFieldNotNull(objXzSchoolEN.IsCurrentUse, clsXzSchoolEN.con_IsCurrentUse);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzSchoolEN.id_School, 4, clsXzSchoolEN.con_id_School);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolId, 20, clsXzSchoolEN.con_SchoolId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolName, 50, clsXzSchoolEN.con_SchoolName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.Memo, 1000, clsXzSchoolEN.con_Memo);
//检查字段外键固定长度
 objXzSchoolEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzSchoolEN objXzSchoolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolId, 20, clsXzSchoolEN.con_SchoolId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolName, 50, clsXzSchoolEN.con_SchoolName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.Memo, 1000, clsXzSchoolEN.con_Memo);
//检查外键字段长度
 objXzSchoolEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzSchoolEN objXzSchoolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzSchoolEN.id_School, 4, clsXzSchoolEN.con_id_School);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolId, 20, clsXzSchoolEN.con_SchoolId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolName, 50, clsXzSchoolEN.con_SchoolName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.Memo, 1000, clsXzSchoolEN.con_Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.id_School, clsXzSchoolEN.con_id_School);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolId, clsXzSchoolEN.con_SchoolId);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolName, clsXzSchoolEN.con_SchoolName);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.Memo, clsXzSchoolEN.con_Memo);
//检查外键字段长度
 objXzSchoolEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable Getid_School()
{
//获取某学院所有专业信息
string strSQL = "select id_School, SchoolName from XzSchool ";
 clsSpecSQLforSql mySql = clsXzSchoolDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzSchool(学校), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strid_School">学校流水号(主键)</param>
 /// <returns></returns>
public bool CheckXzSchoolUniqueness(string strid_School )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("id_School !=  '{0}'", strid_School);
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
 /// 检查唯一性(Uniqueness)--XzSchool(学校), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckXzSchoolUniqueness()
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
 /// 获取唯一性条件串(Uniqueness)--XzSchool(学校)
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "strid_School">学校流水号(主键)</param>
 /// <returns></returns>
public string GetUniquenessConditionString(string strid_School )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
return sbCondition.ToString();
}

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenfunGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenfunGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenfunGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzSchoolEN._CurrTabName_S);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenfunGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzSchoolEN._CurrTabName_S, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenfunGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL = null;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}