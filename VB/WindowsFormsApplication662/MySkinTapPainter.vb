Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Drawing

Namespace WindowsFormsApplication662

    Public Class MySkinTapPainter
        Inherits SkinTabPainter

        Public Sub New(ByVal tabControl As IXtraTab)
            MyBase.New(tabControl)

        End Sub
        Protected Overrides Sub DrawHeaderPage(ByVal e As TabDrawArgs, ByVal row As DevExpress.XtraTab.ViewInfo.BaseTabRowViewInfo, ByVal pInfo As DevExpress.XtraTab.ViewInfo.BaseTabPageViewInfo)
            MyBase.DrawHeaderPage(e, row, pInfo)
            Dim rect As Rectangle = pInfo.Bounds
            rect.Height = 2
            e.Graphics.FillRectangle(Brushes.Red, rect)
            e.Graphics.FillRectangle(New SolidBrush(pInfo.Page.Appearance.Header.BackColor2), rect)
        End Sub
    End Class
End Namespace
