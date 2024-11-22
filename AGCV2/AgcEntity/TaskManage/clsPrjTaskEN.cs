
///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/08/27
///�����ߣ�pyf
///�������ƣ�AGC
///����ID��0005
///ģ�����������������
///ģ��Ӣ������TaskManage
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2011.05.08.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2011.05.08.1
///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
/// <summary>
/// ��Ŀ����(PrjTask)
/// </summary>
[Serializable]
public class clsPrjTaskEN : clsEntityBase2
{
public const string CurrTabName_S = "PrjTask"; //��ǰ�������������صı���
public const string CurrTabKeyFldName_S = "PrjTaskId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"PrjTaskId", "TaskName", "TaskContent", "PrjId", "ViewId", "TaskStateId", "TaskTypeId", "PlanBeginDate", "PlanEndDate", "PlanNeedHours", "IsAssigned", "TaskAssignDate", "PermiterId", "TaskPermitDate", "IsFinished", "Executor", "DepartMentId", "ActualBeginDate", "ActualEndDate", "ActualCostHours", "SubmitDate", "TaskExcuteSum", "IsChecked", "CheckerId", "TaskCheckDate", "CheckDesc", "InspectTimes", "FinishedPercent", "CumulatePoints"};
 //���������Ա���


 /// <summary> 
 /// ��������ID(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrPrjTaskId;

 /// <summary> 
 /// ��������(�ֶ�����:varchar,�ֶγ���:30,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrTaskName;

 /// <summary> 
 /// ����(�ֶ�����:varchar,�ֶγ���:1000,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskContent;

 /// <summary> 
 /// ����ID(�ֶ�����:char,�ֶγ���:4,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrPrjId;

 /// <summary> 
 /// ����ID(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrViewId;

 /// <summary> 
 /// ����״̬ID(�ֶ�����:char,�ֶγ���:2,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskStateId;

 /// <summary> 
 /// �������ID(�ֶ�����:varchar,�ֶγ���:4,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskTypeId;

 /// <summary> 
 /// �ƻ���ʼ����(�ֶ�����:char,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrPlanBeginDate;

 /// <summary> 
 /// �ƻ���������(�ֶ�����:char,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrPlanEndDate;

 /// <summary> 
 /// �ƻ���Ҫʱ��(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:True)
 /// </summary>
 protected int mintPlanNeedHours;

 /// <summary> 
 /// �Ƿ�ָ��(�ֶ�����:bit,�ֶγ���:1,�Ƿ�ɿ�:True)
 /// </summary>
 protected bool mbolIsAssigned;

 /// <summary> 
 /// ����ָ������(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskAssignDate;

 /// <summary> 
 /// ȷ����ID(�ֶ�����:varchar,�ֶγ���:18,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrPermiterId;

 /// <summary> 
 /// ����ȷ������(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskPermitDate;

 /// <summary> 
 /// �Ƿ����(�ֶ�����:bit,�ֶγ���:1,�Ƿ�ɿ�:True)
 /// </summary>
 protected bool mbolIsFinished;

 /// <summary> 
 /// ʵʩ��(�ֶ�����:varchar,�ֶγ���:18,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrExecutor;

 /// <summary> 
 /// ����ID(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrDepartMentId;

 /// <summary> 
 /// ʵ�ʿ�ʼ����(�ֶ�����:char,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrActualBeginDate;

 /// <summary> 
 /// ʵ�ʽ�������(�ֶ�����:char,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrActualEndDate;

 /// <summary> 
 /// ʵ�ʻ���ʱ��(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:True)
 /// </summary>
 protected int mintActualCostHours;

 /// <summary> 
 /// �ύ����(�ֶ�����:char,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrSubmitDate;

 /// <summary> 
 /// ����ʵʩ�ܽ�(�ֶ�����:varchar,�ֶγ���:1000,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskExcuteSum;

 /// <summary> 
 /// �Ƿ��ʵ(�ֶ�����:bit,�ֶγ���:1,�Ƿ�ɿ�:True)
 /// </summary>
 protected bool mbolIsChecked;

 /// <summary> 
 /// ��ʵ��ID(�ֶ�����:varchar,�ֶγ���:18,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrCheckerId;

 /// <summary> 
 /// �����ʵ����(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrTaskCheckDate;

 /// <summary> 
 /// ��ʵ���(�ֶ�����:varchar,�ֶγ���:1000,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrCheckDesc;

 /// <summary> 
 /// ������(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:True)
 /// </summary>
 protected int mintInspectTimes;

 /// <summary> 
 /// ��ǰ��ɰٷֱ�(�ֶ�����:float,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected float mfltFinishedPercent;

 /// <summary> 
 /// ����(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:True)
 /// </summary>
 protected int mintCumulatePoints;

//�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
private static string m_strConnectString;
public static string ConnectString
{
get { return m_strConnectString; }
set { m_strConnectString = value; }
}

 public clsPrjTaskEN()
 {
 SetInit();
 _CurrTabName = "PrjTask";
 lstKeyFldNames.Add("PrjTaskId");
 }

public clsPrjTaskEN(string strPrjTaskId)
 {

mstrPrjTaskId=strPrjTaskId;
 SetInit();
 _CurrTabName = "PrjTask";
 lstKeyFldNames.Add("PrjTaskId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName == "PrjTaskId")
{
return mstrPrjTaskId;
}
else if (strAttributeName == "TaskName")
{
return mstrTaskName;
}
else if (strAttributeName == "TaskContent")
{
return mstrTaskContent;
}
else if (strAttributeName == "PrjId")
{
return mstrPrjId;
}
else if (strAttributeName == "ViewId")
{
return mstrViewId;
}
else if (strAttributeName == "TaskStateId")
{
return mstrTaskStateId;
}
else if (strAttributeName == "TaskTypeId")
{
return mstrTaskTypeId;
}
else if (strAttributeName == "PlanBeginDate")
{
return mstrPlanBeginDate;
}
else if (strAttributeName == "PlanEndDate")
{
return mstrPlanEndDate;
}
else if (strAttributeName == "PlanNeedHours")
{
return mintPlanNeedHours;
}
else if (strAttributeName == "IsAssigned")
{
return mbolIsAssigned;
}
else if (strAttributeName == "TaskAssignDate")
{
return mstrTaskAssignDate;
}
else if (strAttributeName == "PermiterId")
{
return mstrPermiterId;
}
else if (strAttributeName == "TaskPermitDate")
{
return mstrTaskPermitDate;
}
else if (strAttributeName == "IsFinished")
{
return mbolIsFinished;
}
else if (strAttributeName == "Executor")
{
return mstrExecutor;
}
else if (strAttributeName == "DepartMentId")
{
return mstrDepartMentId;
}
else if (strAttributeName == "ActualBeginDate")
{
return mstrActualBeginDate;
}
else if (strAttributeName == "ActualEndDate")
{
return mstrActualEndDate;
}
else if (strAttributeName == "ActualCostHours")
{
return mintActualCostHours;
}
else if (strAttributeName == "SubmitDate")
{
return mstrSubmitDate;
}
else if (strAttributeName == "TaskExcuteSum")
{
return mstrTaskExcuteSum;
}
else if (strAttributeName == "IsChecked")
{
return mbolIsChecked;
}
else if (strAttributeName == "CheckerId")
{
return mstrCheckerId;
}
else if (strAttributeName == "TaskCheckDate")
{
return mstrTaskCheckDate;
}
else if (strAttributeName == "CheckDesc")
{
return mstrCheckDesc;
}
else if (strAttributeName == "InspectTimes")
{
return mintInspectTimes;
}
else if (strAttributeName == "FinishedPercent")
{
return mfltFinishedPercent;
}
else if (strAttributeName == "CumulatePoints")
{
return mintCumulatePoints;
}
return null;
}
set
{
if (strAttributeName == "PrjTaskId")
{
mstrPrjTaskId = value.ToString();
}
else if (strAttributeName == "TaskName")
{
mstrTaskName = value.ToString();
}
else if (strAttributeName == "TaskContent")
{
mstrTaskContent = value.ToString();
}
else if (strAttributeName == "PrjId")
{
mstrPrjId = value.ToString();
}
else if (strAttributeName == "ViewId")
{
mstrViewId = value.ToString();
}
else if (strAttributeName == "TaskStateId")
{
mstrTaskStateId = value.ToString();
}
else if (strAttributeName == "TaskTypeId")
{
mstrTaskTypeId = value.ToString();
}
else if (strAttributeName == "PlanBeginDate")
{
mstrPlanBeginDate = value.ToString();
}
else if (strAttributeName == "PlanEndDate")
{
mstrPlanEndDate = value.ToString();
}
else if (strAttributeName == "PlanNeedHours")
{
mintPlanNeedHours = TransNullToInt(value.ToString());
}
else if (strAttributeName == "IsAssigned")
{
mbolIsAssigned = TransNullToBool(value.ToString());
}
else if (strAttributeName == "TaskAssignDate")
{
mstrTaskAssignDate = value.ToString();
}
else if (strAttributeName == "PermiterId")
{
mstrPermiterId = value.ToString();
}
else if (strAttributeName == "TaskPermitDate")
{
mstrTaskPermitDate = value.ToString();
}
else if (strAttributeName == "IsFinished")
{
mbolIsFinished = TransNullToBool(value.ToString());
}
else if (strAttributeName == "Executor")
{
mstrExecutor = value.ToString();
}
else if (strAttributeName == "DepartMentId")
{
mstrDepartMentId = value.ToString();
}
else if (strAttributeName == "ActualBeginDate")
{
mstrActualBeginDate = value.ToString();
}
else if (strAttributeName == "ActualEndDate")
{
mstrActualEndDate = value.ToString();
}
else if (strAttributeName == "ActualCostHours")
{
mintActualCostHours = TransNullToInt(value.ToString());
}
else if (strAttributeName == "SubmitDate")
{
mstrSubmitDate = value.ToString();
}
else if (strAttributeName == "TaskExcuteSum")
{
mstrTaskExcuteSum = value.ToString();
}
else if (strAttributeName == "IsChecked")
{
mbolIsChecked = TransNullToBool(value.ToString());
}
else if (strAttributeName == "CheckerId")
{
mstrCheckerId = value.ToString();
}
else if (strAttributeName == "TaskCheckDate")
{
mstrTaskCheckDate = value.ToString();
}
else if (strAttributeName == "CheckDesc")
{
mstrCheckDesc = value.ToString();
}
else if (strAttributeName == "InspectTimes")
{
mintInspectTimes = TransNullToInt(value.ToString());
}
else if (strAttributeName == "FinishedPercent")
{
mfltFinishedPercent = TransNullToFloat(value.ToString());
}
else if (strAttributeName == "CumulatePoints")
{
mintCumulatePoints = TransNullToInt(value.ToString());
}
}
}
public object this[int intIndex]
{
get
{
if ("PrjTaskId" == AttributeName[intIndex])
{
return mstrPrjTaskId;
}
else if ("TaskName" == AttributeName[intIndex])
{
return mstrTaskName;
}
else if ("TaskContent" == AttributeName[intIndex])
{
return mstrTaskContent;
}
else if ("PrjId" == AttributeName[intIndex])
{
return mstrPrjId;
}
else if ("ViewId" == AttributeName[intIndex])
{
return mstrViewId;
}
else if ("TaskStateId" == AttributeName[intIndex])
{
return mstrTaskStateId;
}
else if ("TaskTypeId" == AttributeName[intIndex])
{
return mstrTaskTypeId;
}
else if ("PlanBeginDate" == AttributeName[intIndex])
{
return mstrPlanBeginDate;
}
else if ("PlanEndDate" == AttributeName[intIndex])
{
return mstrPlanEndDate;
}
else if ("PlanNeedHours" == AttributeName[intIndex])
{
return mintPlanNeedHours;
}
else if ("IsAssigned" == AttributeName[intIndex])
{
return mbolIsAssigned;
}
else if ("TaskAssignDate" == AttributeName[intIndex])
{
return mstrTaskAssignDate;
}
else if ("PermiterId" == AttributeName[intIndex])
{
return mstrPermiterId;
}
else if ("TaskPermitDate" == AttributeName[intIndex])
{
return mstrTaskPermitDate;
}
else if ("IsFinished" == AttributeName[intIndex])
{
return mbolIsFinished;
}
else if ("Executor" == AttributeName[intIndex])
{
return mstrExecutor;
}
else if ("DepartMentId" == AttributeName[intIndex])
{
return mstrDepartMentId;
}
else if ("ActualBeginDate" == AttributeName[intIndex])
{
return mstrActualBeginDate;
}
else if ("ActualEndDate" == AttributeName[intIndex])
{
return mstrActualEndDate;
}
else if ("ActualCostHours" == AttributeName[intIndex])
{
return mintActualCostHours;
}
else if ("SubmitDate" == AttributeName[intIndex])
{
return mstrSubmitDate;
}
else if ("TaskExcuteSum" == AttributeName[intIndex])
{
return mstrTaskExcuteSum;
}
else if ("IsChecked" == AttributeName[intIndex])
{
return mbolIsChecked;
}
else if ("CheckerId" == AttributeName[intIndex])
{
return mstrCheckerId;
}
else if ("TaskCheckDate" == AttributeName[intIndex])
{
return mstrTaskCheckDate;
}
else if ("CheckDesc" == AttributeName[intIndex])
{
return mstrCheckDesc;
}
else if ("InspectTimes" == AttributeName[intIndex])
{
return mintInspectTimes;
}
else if ("FinishedPercent" == AttributeName[intIndex])
{
return mfltFinishedPercent;
}
else if ("CumulatePoints" == AttributeName[intIndex])
{
return mintCumulatePoints;
}
return null;
}
set
{
if ("PrjTaskId" == AttributeName[intIndex])
{
mstrPrjTaskId = value.ToString();
}
else if ("TaskName" == AttributeName[intIndex])
{
mstrTaskName = value.ToString();
}
else if ("TaskContent" == AttributeName[intIndex])
{
mstrTaskContent = value.ToString();
}
else if ("PrjId" == AttributeName[intIndex])
{
mstrPrjId = value.ToString();
}
else if ("ViewId" == AttributeName[intIndex])
{
mstrViewId = value.ToString();
}
else if ("TaskStateId" == AttributeName[intIndex])
{
mstrTaskStateId = value.ToString();
}
else if ("TaskTypeId" == AttributeName[intIndex])
{
mstrTaskTypeId = value.ToString();
}
else if ("PlanBeginDate" == AttributeName[intIndex])
{
mstrPlanBeginDate = value.ToString();
}
else if ("PlanEndDate" == AttributeName[intIndex])
{
mstrPlanEndDate = value.ToString();
}
else if ("PlanNeedHours" == AttributeName[intIndex])
{
mintPlanNeedHours = TransNullToInt(value.ToString());
}
else if ("IsAssigned" == AttributeName[intIndex])
{
mbolIsAssigned = TransNullToBool(value.ToString());
}
else if ("TaskAssignDate" == AttributeName[intIndex])
{
mstrTaskAssignDate = value.ToString();
}
else if ("PermiterId" == AttributeName[intIndex])
{
mstrPermiterId = value.ToString();
}
else if ("TaskPermitDate" == AttributeName[intIndex])
{
mstrTaskPermitDate = value.ToString();
}
else if ("IsFinished" == AttributeName[intIndex])
{
mbolIsFinished = TransNullToBool(value.ToString());
}
else if ("Executor" == AttributeName[intIndex])
{
mstrExecutor = value.ToString();
}
else if ("DepartMentId" == AttributeName[intIndex])
{
mstrDepartMentId = value.ToString();
}
else if ("ActualBeginDate" == AttributeName[intIndex])
{
mstrActualBeginDate = value.ToString();
}
else if ("ActualEndDate" == AttributeName[intIndex])
{
mstrActualEndDate = value.ToString();
}
else if ("ActualCostHours" == AttributeName[intIndex])
{
mintActualCostHours = TransNullToInt(value.ToString());
}
else if ("SubmitDate" == AttributeName[intIndex])
{
mstrSubmitDate = value.ToString();
}
else if ("TaskExcuteSum" == AttributeName[intIndex])
{
mstrTaskExcuteSum = value.ToString();
}
else if ("IsChecked" == AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
}
else if ("CheckerId" == AttributeName[intIndex])
{
mstrCheckerId = value.ToString();
}
else if ("TaskCheckDate" == AttributeName[intIndex])
{
mstrTaskCheckDate = value.ToString();
}
else if ("CheckDesc" == AttributeName[intIndex])
{
mstrCheckDesc = value.ToString();
}
else if ("InspectTimes" == AttributeName[intIndex])
{
mintInspectTimes = TransNullToInt(value.ToString());
}
else if ("FinishedPercent" == AttributeName[intIndex])
{
mfltFinishedPercent = TransNullToFloat(value.ToString());
}
else if ("CumulatePoints" == AttributeName[intIndex])
{
mintCumulatePoints = TransNullToInt(value.ToString());
}
}
}

/// <summary>
/// ��������ID(˵��:;�ֶ�����:varchar;�ֶγ���:8;�Ƿ�ɿ�:False)
/// </summary>
public string PrjTaskId
{
get
{
return mstrPrjTaskId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPrjTaskId = value;
}
else
{
mstrPrjTaskId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("PrjTaskId");
}
}
/// <summary>
/// ��������(˵��:;�ֶ�����:varchar;�ֶγ���:30;�Ƿ�ɿ�:False)
/// </summary>
public string TaskName
{
get
{
return mstrTaskName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskName = value;
}
else
{
mstrTaskName = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskName");
}
}
/// <summary>
/// ����(˵��:;�ֶ�����:varchar;�ֶγ���:1000;�Ƿ�ɿ�:True)
/// </summary>
public string TaskContent
{
get
{
return mstrTaskContent;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskContent = value;
}
else
{
mstrTaskContent = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskContent");
}
}
/// <summary>
/// ����ID(˵��:;�ֶ�����:char;�ֶγ���:4;�Ƿ�ɿ�:False)
/// </summary>
public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPrjId = value;
}
else
{
mstrPrjId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("PrjId");
}
}
/// <summary>
/// ����ID(˵��:;�ֶ�����:varchar;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewId = value;
}
else
{
mstrViewId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("ViewId");
}
}
/// <summary>
/// ����״̬ID(˵��:;�ֶ�����:char;�ֶγ���:2;�Ƿ�ɿ�:True)
/// </summary>
public string TaskStateId
{
get
{
return mstrTaskStateId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskStateId = value;
}
else
{
mstrTaskStateId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskStateId");
}
}
/// <summary>
/// �������ID(˵��:;�ֶ�����:varchar;�ֶγ���:4;�Ƿ�ɿ�:True)
/// </summary>
public string TaskTypeId
{
get
{
return mstrTaskTypeId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskTypeId = value;
}
else
{
mstrTaskTypeId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskTypeId");
}
}
/// <summary>
/// �ƻ���ʼ����(˵��:;�ֶ�����:char;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string PlanBeginDate
{
get
{
return mstrPlanBeginDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPlanBeginDate = value;
}
else
{
mstrPlanBeginDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("PlanBeginDate");
}
}
/// <summary>
/// �ƻ���������(˵��:;�ֶ�����:char;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string PlanEndDate
{
get
{
return mstrPlanEndDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPlanEndDate = value;
}
else
{
mstrPlanEndDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("PlanEndDate");
}
}
/// <summary>
/// �ƻ���Ҫʱ��(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:True)
/// </summary>
public int PlanNeedHours
{
get
{
return mintPlanNeedHours;
}
set
{
mintPlanNeedHours = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("PlanNeedHours");
}
}
/// <summary>
/// �Ƿ�ָ��(˵��:;�ֶ�����:bit;�ֶγ���:1;�Ƿ�ɿ�:True)
/// </summary>
public bool IsAssigned
{
get
{
return mbolIsAssigned;
}
set
{
mbolIsAssigned = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("IsAssigned");
}
}
/// <summary>
/// ����ָ������(˵��:;�ֶ�����:varchar;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string TaskAssignDate
{
get
{
return mstrTaskAssignDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskAssignDate = value;
}
else
{
mstrTaskAssignDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskAssignDate");
}
}
/// <summary>
/// ȷ����ID(˵��:;�ֶ�����:varchar;�ֶγ���:18;�Ƿ�ɿ�:True)
/// </summary>
public string PermiterId
{
get
{
return mstrPermiterId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPermiterId = value;
}
else
{
mstrPermiterId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("PermiterId");
}
}
/// <summary>
/// ����ȷ������(˵��:;�ֶ�����:varchar;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string TaskPermitDate
{
get
{
return mstrTaskPermitDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskPermitDate = value;
}
else
{
mstrTaskPermitDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskPermitDate");
}
}
/// <summary>
/// �Ƿ����(˵��:;�ֶ�����:bit;�ֶγ���:1;�Ƿ�ɿ�:True)
/// </summary>
public bool IsFinished
{
get
{
return mbolIsFinished;
}
set
{
mbolIsFinished = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("IsFinished");
}
}
/// <summary>
/// ʵʩ��(˵��:;�ֶ�����:varchar;�ֶγ���:18;�Ƿ�ɿ�:True)
/// </summary>
public string Executor
{
get
{
return mstrExecutor;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrExecutor = value;
}
else
{
mstrExecutor = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("Executor");
}
}
/// <summary>
/// ����ID(˵��:;�ֶ�����:varchar;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string DepartMentId
{
get
{
return mstrDepartMentId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrDepartMentId = value;
}
else
{
mstrDepartMentId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("DepartMentId");
}
}
/// <summary>
/// ʵ�ʿ�ʼ����(˵��:;�ֶ�����:char;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string ActualBeginDate
{
get
{
return mstrActualBeginDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrActualBeginDate = value;
}
else
{
mstrActualBeginDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("ActualBeginDate");
}
}
/// <summary>
/// ʵ�ʽ�������(˵��:;�ֶ�����:char;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string ActualEndDate
{
get
{
return mstrActualEndDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrActualEndDate = value;
}
else
{
mstrActualEndDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("ActualEndDate");
}
}
/// <summary>
/// ʵ�ʻ���ʱ��(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:True)
/// </summary>
public int ActualCostHours
{
get
{
return mintActualCostHours;
}
set
{
mintActualCostHours = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("ActualCostHours");
}
}
/// <summary>
/// �ύ����(˵��:;�ֶ�����:char;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string SubmitDate
{
get
{
return mstrSubmitDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrSubmitDate = value;
}
else
{
mstrSubmitDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("SubmitDate");
}
}
/// <summary>
/// ����ʵʩ�ܽ�(˵��:;�ֶ�����:varchar;�ֶγ���:1000;�Ƿ�ɿ�:True)
/// </summary>
public string TaskExcuteSum
{
get
{
return mstrTaskExcuteSum;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskExcuteSum = value;
}
else
{
mstrTaskExcuteSum = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskExcuteSum");
}
}
/// <summary>
/// �Ƿ��ʵ(˵��:;�ֶ�����:bit;�ֶγ���:1;�Ƿ�ɿ�:True)
/// </summary>
public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
mbolIsChecked = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("IsChecked");
}
}
/// <summary>
/// ��ʵ��ID(˵��:;�ֶ�����:varchar;�ֶγ���:18;�Ƿ�ɿ�:True)
/// </summary>
public string CheckerId
{
get
{
return mstrCheckerId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrCheckerId = value;
}
else
{
mstrCheckerId = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("CheckerId");
}
}
/// <summary>
/// �����ʵ����(˵��:;�ֶ�����:varchar;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public string TaskCheckDate
{
get
{
return mstrTaskCheckDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskCheckDate = value;
}
else
{
mstrTaskCheckDate = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TaskCheckDate");
}
}
/// <summary>
/// ��ʵ���(˵��:;�ֶ�����:varchar;�ֶγ���:1000;�Ƿ�ɿ�:True)
/// </summary>
public string CheckDesc
{
get
{
return mstrCheckDesc;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrCheckDesc = value;
}
else
{
mstrCheckDesc = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("CheckDesc");
}
}
/// <summary>
/// ������(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:True)
/// </summary>
public int InspectTimes
{
get
{
return mintInspectTimes;
}
set
{
mintInspectTimes = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("InspectTimes");
}
}
/// <summary>
/// ��ǰ��ɰٷֱ�(˵��:;�ֶ�����:float;�ֶγ���:8;�Ƿ�ɿ�:True)
/// </summary>
public float FinishedPercent
{
get
{
return mfltFinishedPercent;
}
set
{
mfltFinishedPercent = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("FinishedPercent");
}
}
/// <summary>
/// ����(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:True)
/// </summary>
public int CumulatePoints
{
get
{
return mintCumulatePoints;
}
set
{
mintCumulatePoints = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("CumulatePoints");
}
}
}
}