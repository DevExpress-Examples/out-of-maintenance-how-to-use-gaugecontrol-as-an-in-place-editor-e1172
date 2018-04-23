Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Presets.Styles
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Gauges.Circular

Namespace InplaceGaugeControl
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()

			CreateGaugeFromCode(Theme.MagicLight)

			For i As Integer = 25 To 74 Step 5
				dataSet.Tables(0).Rows.Add(New Object() { i })
			Next i
		End Sub
		Private gaugeControl As GaugeControl
		Private circularGauge As CircularGauge
		Private Sub CreateGaugeFromCode(ByVal theme As Theme)
			gaugeControl = New GaugeControl()
			gaugeControl.Size = New System.Drawing.Size(200, 200)

			circularGauge = gaugeControl.AddCircularGauge()
			circularGauge.AddDefaultElements()

			Dim style = StyleLoader.Load("Circular", theme.Name, "Full")
			If style IsNot Nothing Then
				style.Apply(circularGauge)
			End If
		End Sub
		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView.CustomUnboundColumnData
			If e.Column Is colGauge AndAlso e.IsGetData Then
				Dim speed As Integer = CInt(Fix(gridView.GetRowCellValue(e.ListSourceRowIndex, colSpeed)))
				circularGauge.Scales(0).Value = CSng(speed)
				e.Value = (CType(gaugeControl, IGaugeContainer)).GetImage(200, 200)
			End If
		End Sub
	End Class
End Namespace