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
	Public Class MyFocusHelper
		Inherits FocusHelperBase
		Public Sub New(ByVal control As ILayoutControl)
			MyBase.New(control)

		End Sub

		Public Function GetItemsInVisibleOrder() As ArrayList
			Return GetArrangedFocusList(False)
		End Function

		Public Shared Function GetItemsInVisibleOrder(ByVal control As ILayoutControl) As ArrayList
			Return New MyFocusHelper(control).GetItemsInVisibleOrder()
		End Function
	End Class
End Namespace
