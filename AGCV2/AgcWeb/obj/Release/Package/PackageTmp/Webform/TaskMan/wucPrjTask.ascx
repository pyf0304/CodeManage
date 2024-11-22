<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjTask.ascx.cs" Inherits="AGC.Webform.wucPrjTask"
    %>

<table id="tabwucPrjTask" cellspacing="1" cellpadding="1" width="368" border="0"
    style="width: 368px; height: 381px">
    <tr>
        <td>
            <asp:Label ID="lblPrjTaskId" runat="server" >��������ID</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:TextBox ID="txtPrjTaskId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server" >����ID</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:DropDownList ID="ddlViewId" runat="server" 
                Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjProcessId" runat="server" >��Ŀ����ID</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:DropDownList ID="ddlPrjProcessId" runat="server" 
                Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTaskName" runat="server" >��������</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:TextBox ID="txtTaskName" runat="server" 
                Width="272px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTaskDesc" runat="server" >��������</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:TextBox ID="txtTaskDesc" runat="server" 
                Width="272px" Height="96px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblExecutor" runat="server" >ʵʩ��</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:DropDownList ID="ddlExecutor" runat="server" 
                Width="159px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDepartmentId" runat="server" >����ID</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:DropDownList ID="ddlDepartmentId" runat="server" 
                Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPlanBeginDate" runat="server" >�ƻ���ʼ����</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:TextBox ID="txtPlanBeginDate" runat="server" ></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator_PlanBeginTime"
                runat="server" Operator="DataTypeCheck" Type="Date" ControlToValidate="txtPlanBeginDate"
                ErrorMessage="��������ȷ����!"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPlanEndDate" runat="server" >�ƻ���������</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:TextBox ID="txtPlanEndDate" runat="server" ></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator_PlanEndTime1"
                runat="server" ErrorMessage="��������ȷ����!" ControlToValidate="txtPlanEndDate" Type="Date"
                Operator="DataTypeCheck"></asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidator_PlanEndTime2"
                runat="server" ErrorMessage="�ƻ��������ڲ���С�ڿ�ʼ����" ControlToValidate="txtPlanEndDate"
                Operator="GreaterThanEqual" ControlToCompare="txtPlanBeginDate"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPlanNeedHours" runat="server" >�ƻ���Ҫʱ��</asp:Label>
        </td>
        <td style="width: 280px">
            <asp:TextBox ID="txtPlanNeedHours" runat="server" ></asp:TextBox>
            <asp:CompareValidator ID="ComValid_PlanNeedHours" runat="server" 
                 ErrorMessage="������������ֵ!" ControlToValidate="txtPlanNeedHours"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredField_PlanNeedHours" 
                 runat="server" ControlToValidate="txtPlanNeedHours" ErrorMessage="�ƻ���Ҫʱ�䲻��Ϊ��!"
                Enabled="False"></asp:RequiredFieldValidator>
        </td>
    </tr>
</table>
