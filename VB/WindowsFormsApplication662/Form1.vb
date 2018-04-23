Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab.Registrator


Namespace WindowsFormsApplication662
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            PaintStyleCollection.DefaultPaintStyles.Add(New MySkinViewInfoRegistrator())
            xtraTabControl1.PaintStyleName = "MyStyle"
        End Sub
    End Class
End Namespace
