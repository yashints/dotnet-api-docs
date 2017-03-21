    <AspNetHostingPermission(SecurityAction.Demand, Level:=AspNetHostingPermissionLevel.Minimal)> _
    Public NotInheritable Class CustomHyperLinkRenderContents
        Inherits System.Web.UI.WebControls.HyperLink

        Protected Overrides Sub RenderContents(ByVal writer As System.Web.UI.HtmlTextWriter)

            ' Call the base RenderContents method.
            MyBase.RenderContents(writer)

            ' Append some text to the HyperLink.
            writer.Write(" Home Page")
        End Sub
    End Class