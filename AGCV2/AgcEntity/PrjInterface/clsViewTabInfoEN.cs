
///----------------------
///���ɴ���汾��2012.11.9.1
///�������ڣ�2012/11/20
///�����ߣ����Է�
///�������ƣ�AGC
///����ID��0005
///ģ������������Ŀ�������
///ģ��Ӣ������PrjInterface
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2012.10.20.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2012.10.23.1
///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
/// <summary>
/// ViewTabInfo(ViewTabInfo)
/// </summary>
[Serializable]
public class clsViewTabInfoEN : clsEntityBase2
{
public const string CurrTabName_S = "ViewTabInfo"; //��ǰ�������������صı���
public const string CurrTabKeyFldName_S = "mId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"mId", "ViewId", "DataBaseName", "TabName"};
 //���������Ա���


 /// <summary> 
 /// mId(�ֶ�����:bigint,�ֶγ���:8,�Ƿ�ɿ�:False)
 /// </summary>
 protected long mlngmId;

 /// <summary> 
 /// ����ID(�ֶ�����:varchar,�ֶγ���:8,�Ƿ�ɿ�:True)
 /// </summary>
 protected string mstrViewId;

 /// <summary> 
 /// ���ݿ���(�ֶ�����:varchar,�ֶγ���:50,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrDataBaseName;

 /// <summary> 
 /// ����(�ֶ�����:varchar,�ֶγ���:60,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrTabName;
        
 public clsViewTabInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ViewTabInfo";
 lstKeyFldNames.Add("mId");
 }

public clsViewTabInfoEN(long lngmId)
 {
  if (lngmId == 0)
  {
     throw new Exception("�ؼ��ֲ���Ϊ0��");
   }

mlngmId=lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ViewTabInfo";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName == "mId")
{
return mlngmId;
}
else if (strAttributeName == "ViewId")
{
return mstrViewId;
}
else if (strAttributeName == "DataBaseName")
{
return mstrDataBaseName;
}
else if (strAttributeName == "TabName")
{
return mstrTabName;
}
return null;
}
set
{
if (strAttributeName == "mId")
{
mlngmId = TransNullToInt(value.ToString());
}
else if (strAttributeName == "ViewId")
{
mstrViewId = value.ToString();
}
else if (strAttributeName == "DataBaseName")
{
mstrDataBaseName = value.ToString();
}
else if (strAttributeName == "TabName")
{
mstrTabName = value.ToString();
}
}
}
public object this[int intIndex]
{
get
{
if ("mId" == AttributeName[intIndex])
{
return mlngmId;
}
else if ("ViewId" == AttributeName[intIndex])
{
return mstrViewId;
}
else if ("DataBaseName" == AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if ("TabName" == AttributeName[intIndex])
{
return mstrTabName;
}
return null;
}
set
{
if ("mId" == AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
}
else if ("ViewId" == AttributeName[intIndex])
{
mstrViewId = value.ToString();
}
else if ("DataBaseName" == AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
}
else if ("TabName" == AttributeName[intIndex])
{
mstrTabName = value.ToString();
}
}
}

/// <summary>
/// mId(˵��:;�ֶ�����:bigint;�ֶγ���:8;�Ƿ�ɿ�:False)
/// </summary>
public long mId
{
get
{
return mlngmId;
}
set
{
mlngmId = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("mId");
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
/// ���ݿ���(˵��:;�ֶ�����:varchar;�ֶγ���:50;�Ƿ�ɿ�:False)
/// </summary>
public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrDataBaseName = value;
}
else
{
mstrDataBaseName = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("DataBaseName");
}
}
/// <summary>
/// ����(˵��:;�ֶ�����:varchar;�ֶγ���:60;�Ƿ�ɿ�:False)
/// </summary>
public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTabName = value;
}
else
{
mstrTabName = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("TabName");
}
}
}
}