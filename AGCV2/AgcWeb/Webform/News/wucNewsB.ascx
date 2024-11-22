<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucNewsB.ascx.cs" Inherits="CompanyPage.Webform.wucNewsB" %>
<%@ Register Assembly="DotNetTextBox" Namespace="DotNetTextBox" TagPrefix="DNTB" %>
<link rel="stylesheet" type="text/css" href="../../Css/Images/style.css" />
<script src="../../Scripts/jquery-3.6.0.min.js"></script>
<script src="../../Scripts/jquery.validate.min.js"></script>
<script type="text/javascript" src="../../Js/messages_cn.js"></script>
<script src="../../Scripts/jquery-form.js"></script>
<script type="text/javascript" src="../../Js/cursorfocus.js"></script>
<script type="text/javascript" language="javascript" src="../../Js/My97DatePicker/WdatePicker.js">
</script>
<script type="text/javascript">
    $(function () {
        //����֤JS
        $("#form1").validate({
            //����ʱ��ӵı�ǩ
            errorElement: "span",
            success: function (label) {
                //��ȷʱ����ʽ
                label.text(" ").addClass("success");
            }
        });

    });
</script>
<table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
    <tr>
        <th colspan="2" align="left">
            ��Ѷ�༭
        </th>
    </tr>
    <tr>
        <td align="right">
            ���⣺
        </td>
        <td >
            <asp:TextBox ID="txtNewsTitle" runat="server" CssClass="input w380 required" MaxLength="50" Width="500px"
                minlength="3" HintTitle="���������±���" HintInfo="������50�������ڣ������ı�������Ҫ̫����"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            ��Ѷ���ͣ�
        </td>
        <td>
            <asp:DropDownList ID="ddlNewsTypeId" runat="server" CssClass="input">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            �Ƿ��ö���
        </td>
        <td>
            <asp:CheckBox ID="chkIsTop" runat="server" Text="" CssClass="Check_Defa"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            ͼƬ·����
        </td>
        <td>
            <asp:FileUpload runat="server" ID="fupImageUrl" runat="server" CssClass="input w250 left"
                HintTitle="���ĵ�ͼƬ" HintInfo="�����ұߵ����������ϴ����Ĵ�ͼ����С�뱣����50KB���ڡ�" />
            <asp:Image runat="server" ID="ImgUrl" runat="server" Height="70px" Width="120px"
                Visible="false" />
        </td>
    </tr>
    <tr>
        <td align="right">
            �������ݣ�
        </td>
        <td>
            <DNTB:WebEditor ID="txtNewsContent" runat="server"></DNTB:WebEditor>
        </td>
    </tr>
    <tr>
        <td align="right">
            �༭�ˣ�
        </td>
        <td>
            <asp:TextBox ID="txtEditPeople" runat="server" CssClass="input w250 required" MaxLength="10"
                HintTitle="�༭��" HintInfo="������10�������ڣ��硰����Ա����"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            �༭ʱ�䣺
        </td>
        <td>
            <asp:TextBox ID="txtEditTime" runat="server" onfocus="new WdatePicker(this,'%Y-%M-%D',true,'whyGreen')"
                CssClass="input w250 required" MaxLength="16" HintTitle="����" HintInfo="������16�������ڣ��硰1988-07-22����"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            ��Դ��
        </td>
        <td>
            <asp:TextBox ID="txtSource" runat="server" CssClass="input w250 required" MaxLength="10"
                HintTitle="��Դ" HintInfo="������10�������ڣ��硰�й�����������"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            �������
        </td>
        <td>
            <asp:TextBox ID="txtViews" runat="server" CssClass="input required number" size="10"
                MaxLength="10" HintTitle="���µ��������" HintInfo="�����֣������±��Ķ��Ĵ�����">0</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            ��ע��
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" CssClass="input w380 left" Height="80px"
                HintInfo="������1000�������ڣ����Ա�עһЩ������" HintTitle="��ע" MaxLength="1000" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
