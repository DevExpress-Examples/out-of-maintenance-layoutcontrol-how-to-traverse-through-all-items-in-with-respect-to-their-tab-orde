Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports System.Collections

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			ProcessItems()
		End Sub
		Private Sub ProcessItems()
			Dim items As ArrayList = MyFocusHelper.GetItemsInVisibleOrder(layoutControl1)
			For i As Integer = 0 To items.Count - 1
				Dim item As LayoutControlItem = TryCast(items(i), LayoutControlItem)
				If item IsNot Nothing Then
					item.Text = String.Format("Order = <{0}>", i)
					item.TextVisible = True
				End If
			Next i
		End Sub
	End Class


End Namespace