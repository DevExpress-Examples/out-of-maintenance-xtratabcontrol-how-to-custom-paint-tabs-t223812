Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTab.Registrator

Namespace WindowsFormsApplication662
    Public Class MySkinViewInfoRegistrator
        Inherits SkinViewInfoRegistrator

        Public Sub New()
            MyBase.New()

        End Sub
        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyStyle"
            End Get
        End Property
        Public Overrides Function CreatePainter(ByVal tabControl As DevExpress.XtraTab.IXtraTab) As DevExpress.XtraTab.Drawing.BaseTabPainter
            Return New MySkinTapPainter(tabControl)
        End Function
    End Class
End Namespace
