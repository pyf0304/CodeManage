<%@ Page Language="c#" CodeBehind="wfmTestMoveImg.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTestMoveImg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmTestMoveImg</title>

    <script language="javascript" type="text/javascript">
		<!--
    var intTabQueryLeft, intTabQueryWidthOld, intTabQueryWidthNew, intImgLeftNew, oldx=0,oldy=0,oldobj=null;
   	var theImgId = new Array(100);
	var theImgLeft = new Array(100);
	var theImgTop = new Array(100);

    var bolIsMouseDown;
	function Img_onMouseDown()
	{
		oldobj=event.srcElement
		oldx=event.x-oldobj.offsetLeft;
		oldy=event.y-oldobj.offsetTop;
		oldobj.style.position="absolute"
		oldobj.setCapture()
		bolIsMouseDown = true;
	}
	function Img_onMouseMove()
	{
		if(oldobj==null)
			return false
		if (bolIsMouseDown == true)
		{
			oldobj.style.left=event.x-oldx;
			oldobj.style.top=event.y-oldy
		}
	}
	function Img_onMouseUp()
	{
		bolIsMouseDown = false;
		if (window.event.x != document.Form1.TextBox1.value || window.event.y != document.Form1.TextBox2.value)
		{
			//document.Form1.TextBox1.value = window.event.x-oldx
			document.Form1.TextBox2.value = window.event.y-oldy
			document.Form1.TextBox3.value = oldobj.id
			intImgLeftNew = event.x-oldx;
			document.Form1.hidString.value = "";
			var WorkStepPoints = document.getElementsByName("wsPoint");
			if (WorkStepPoints.length == 0)
			{
				document.Form1.hidString.value += "lenght=0";
			}
			for(var i=0;i<WorkStepPoints.length;i++)
			{
				/*theImgId[i] = WorkStepPoints[i].id;
				theImgLeft[i] = WorkStepPoints[i].style.left;
				theImgTop[i] = WorkStepPoints[i].style.top;
				*/
				document.Form1.hidString.value += WorkStepPoints[i].id + "," 
												+ WorkStepPoints[i].style.left + ","
												+ WorkStepPoints[i].style.top + ";";
			}
		
			/*for (var i = 0; i<WorkStepPoints.length; i++)
			{
				document.Form1.hidString.value += theImgId[i] + ",";
			}
			*/
//			tabLayout.style.width = 400;
			///�������ò�ѯ����(tabQuery)�Ŀ���Լ��ڲ�DATAGRID�Ŀ�ȡ�
			//�����ѯ����ԭ������߽�
//			intTabQueryLeft = parseInt(tabQuery.style.left, 10);			
			//�����ѯ����ԭ���Ŀ��
//			intTabQueryWidthOld = tabQuery.style.width;		
			//�����ѯ������¿��
//			intTabQueryWidthNew = intImgLeftNew - intTabQueryLeft;	
			//���ò�ѯ����Ŀ��
//			tabQuery.style.width = intTabQueryWidthNew - 5;					
//			var intTabQueryLeft = parseInt(tabQuery.style.left, 10);	
//			var intTabQueryWidthNew2 = tabQuery.style.width;
//			intTabQueryWidthNew = 	parseInt(intTabQueryWidthNew2,10);
//			dgCaseType.style.width = intTabQueryWidthNew - 1;		//���ò�ѯ������DataGrid�Ŀ��
//			imgSplit.style.left = intTabQueryLeft + intTabQueryWidthNew + 13;
//			tabLayout.style.left = intTabQueryLeft + intTabQueryWidthNew + 18;
//			var intTemp = tabQuery.clientWidth;
//			document.Form1.TextBox2.value = "tabQuery.clientWidth = " + intTemp;	
//			intTemp = tabQuery.offsetWidth;
//			document.Form1.TextBox3.value = "tabQuery.offsetWidth = " + intTemp;	
//			intTemp = tabQuery.style.width;
//			document.Form1.TextBox1.value = "tabQuery.style.width = " + intTemp;	
		}
		oldobj=null;
		document.releaseCapture();
//		var timeid = setTimeout("setLayout",10);
	}
	function initWindows()
	{
		document.Form1.TextBox1.value = "tabQuery.style.width = ";
	}
	function setLayout()
	{
		var intTabQueryLeft = parseInt(tabQuery.style.left, 10);		
		var intTabQueryWidthNew2 = tabQuery.style.width;
		var intTabQueryWidthNew = 	parseInt(intTabQueryWidthNew2,10);
		document.Form1.TextBox1.value = "intTabQueryWidthNew(in setLayout) = " + intTabQueryWidthNew;
		dgCaseType.style.width = intTabQueryWidthNew - 1;		//���ò�ѯ������DataGrid�Ŀ��
		imgSplit.style.left =intTabQueryLeft + intTabQueryWidthNew + 1;
		//�༭���(tabLayout)�����嵽�µ�λ��
		tabLayout.style.left = intTabQueryLeft + intTabQueryWidthNew + 5 ;
		//�������ò�ѯ����Ŀ�ȣ��������ϲ��ó���ֵ��һ��,��Ϊ��һ��table�Ŀ�ȱ�����̫Сʱ�����ܻ᲻���ܣ�ϵͳ����һ��������С��ȡ�
		
	}
	//-->
    </script>

</head>
<body onload="">
    <form id="Form1" method="post" runat="server">
        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="����" ForeColor="White"
                        Font-Bold="True">�����ƶ�ͼ��</asp:Label></td>
            </tr>
        </table>
        </FONT>
        <asp:TextBox ID="TextBox1" Style="z-index: 102; left: 64px; position: absolute; top: 32px"
            runat="server" Width="264px" Height="128px" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="TextBox2" Style="z-index: 103; left: 352px; position: absolute;
            top: 32px" runat="server" Width="136px" Height="40px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" Style="z-index: 104; left: 504px; position: absolute;
            top: 32px" runat="server" Width="128px" Height="40px"></asp:TextBox>
        <table id="tabQuery" style="z-index: 105; left: 16px; width: 448px; position: absolute;
            top: 104px; height: 128px" cellspacing="1" cellpadding="1" width="448" border="1">
            <tr>
                <td>
                    <span id="span1" runat="server"></span>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnSaveData" Style="z-index: 106; left: 656px; position: absolute;
            top: 64px" runat="server" Width="112px" Text="����λ����Ϣ"></asp:Button>
        <input id="hidString" style="z-index: 107; left: 648px; position: absolute; top: 32px"
            type="hidden" runat="server">
        &nbsp;
    </form>
</body>
</html>
