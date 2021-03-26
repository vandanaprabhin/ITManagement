<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Sample2.Views.Test.Inventory" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <label>Invoice No</label>
        <input type="text" name="InvoiceNo" class="form-control" />
        &nbsp; &nbsp; 
        
        <label>Location</label>
        <input type="text" name="Location" class="form-control" />

        &nbsp; &nbsp;
        <label>RepackCase No</label>
        <input type="text" name="RepackCaseNo" class="form-control" />


        &nbsp;&nbsp;

        <label>Part No</label>
        <input type="text" name="PartNo" class="form-control" />

        &nbsp;&nbsp;

        <label>Customer Code</label>
        <select name="Code" class="form-control">
        </select>
        <div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Load" />
        <rsweb:ReportViewer ID="ReportViewer1" AsyncRendering="false" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" Style="margin-right: 614px" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="967px">
            <LocalReport ReportPath="Reports\RepackInventry.rdlc">
                
            </LocalReport>
        </rsweb:ReportViewer>
    </form>
</body>
</html>
