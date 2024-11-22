
///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/08/27
///�����ߣ�pyf
///�������ƣ�AGC
///����ID��0005
///ģ�����������ֶΡ���ά��
///ģ��Ӣ������Table_Field
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
/// �ֶ���(Column)
/// </summary>
[Serializable]
public class clsColumnEN : clsEntityBase2
{
public const string CurrTabName_S = "Column"; //��ǰ�������������صı���
public const string CurrTabKeyFldName_S = "id"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"id", "DataField", "HeaderText", "SortExpression"};
 //���������Ա���


 /// <summary> 
 /// id(�ֶ�����:int identity,�ֶγ���:4,�Ƿ�ɿ�:False)
 /// </summary>
 protected int mintid;

 /// <summary> 
 /// DataField(�ֶ�����:varchar,�ֶγ���:50,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrDataField;

 /// <summary> 
 /// HeaderText(�ֶ�����:varchar,�ֶγ���:30,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrHeaderText;

 /// <summary> 
 /// SortExpression(�ֶ�����:varchar,�ֶγ���:50,�Ƿ�ɿ�:False)
 /// </summary>
 protected string mstrSortExpression;


 public clsColumnEN()
 {
 SetInit();
 _CurrTabName = "Column";
 lstKeyFldNames.Add("id");
 }

public clsColumnEN(int intid)
 {

mintid=intid;
 SetInit();
 _CurrTabName = "Column";
 lstKeyFldNames.Add("id");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public new object this[string strAttributeName]
{
get
{
if (strAttributeName == "id")
{
return mintid;
}
else if (strAttributeName == "DataField")
{
return mstrDataField;
}
else if (strAttributeName == "HeaderText")
{
return mstrHeaderText;
}
else if (strAttributeName == "SortExpression")
{
return mstrSortExpression;
}
return null;
}
set
{
if (strAttributeName == "id")
{
mintid = TransNullToInt(value.ToString());
}
else if (strAttributeName == "DataField")
{
mstrDataField = value.ToString();
}
else if (strAttributeName == "HeaderText")
{
mstrHeaderText = value.ToString();
}
else if (strAttributeName == "SortExpression")
{
mstrSortExpression = value.ToString();
}
}
}
public object this[int intIndex]
{
get
{
if ("id" == AttributeName[intIndex])
{
return mintid;
}
else if ("DataField" == AttributeName[intIndex])
{
return mstrDataField;
}
else if ("HeaderText" == AttributeName[intIndex])
{
return mstrHeaderText;
}
else if ("SortExpression" == AttributeName[intIndex])
{
return mstrSortExpression;
}
return null;
}
set
{
if ("id" == AttributeName[intIndex])
{
mintid = TransNullToInt(value.ToString());
}
else if ("DataField" == AttributeName[intIndex])
{
mstrDataField = value.ToString();
}
else if ("HeaderText" == AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
}
else if ("SortExpression" == AttributeName[intIndex])
{
mstrSortExpression = value.ToString();
}
}
}

/// <summary>
/// id(˵��:;�ֶ�����:int identity;�ֶγ���:4;�Ƿ�ɿ�:False)
/// </summary>
public int id
{
get
{
return mintid;
}
set
{
mintid = value;
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("id");
}
}
/// <summary>
/// DataField(˵��:;�ֶ�����:varchar;�ֶγ���:50;�Ƿ�ɿ�:False)
/// </summary>
public string DataField
{
get
{
return mstrDataField;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrDataField = value;
}
else
{
mstrDataField = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("DataField");
}
}
/// <summary>
/// HeaderText(˵��:;�ֶ�����:varchar;�ֶγ���:30;�Ƿ�ɿ�:False)
/// </summary>
public string HeaderText
{
get
{
return mstrHeaderText;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrHeaderText = value;
}
else
{
mstrHeaderText = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("HeaderText");
}
}
/// <summary>
/// SortExpression(˵��:;�ֶ�����:varchar;�ֶγ���:50;�Ƿ�ɿ�:False)
/// </summary>
public string SortExpression
{
get
{
return mstrSortExpression;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrSortExpression = value;
}
else
{
mstrSortExpression = value;
}
//��¼�޸Ĺ����ֶ�
AddUpdatedFld("SortExpression");
}
}
}
}