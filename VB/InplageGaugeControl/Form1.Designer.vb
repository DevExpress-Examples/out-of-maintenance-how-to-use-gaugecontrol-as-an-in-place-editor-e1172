Imports Microsoft.VisualBasic
Imports System
Namespace InplaceGaugeControl
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.dataSet = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colSpeed = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGauge = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl.DataMember = "SpeedTable"
			Me.gridControl.DataSource = Me.dataSet
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.Location = New System.Drawing.Point(0, 0)
			Me.gridControl.MainView = Me.gridView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridControl.Size = New System.Drawing.Size(698, 600)
			Me.gridControl.TabIndex = 0
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
			' 
			' dataSet1
			' 
			Me.dataSet.DataSetName = "NewDataSet"
			Me.dataSet.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "SpeedTable"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Speed"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' gridView1
			' 
			Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSpeed, Me.colGauge})
			Me.gridView.GridControl = Me.gridControl
			Me.gridView.Name = "gridView"
			Me.gridView.OptionsView.ShowGroupPanel = False
			Me.gridView.RowHeight = 200
'			Me.gridView.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
			' 
			' colColumn1
			' 
			Me.colSpeed.Caption = "SpeedValue"
			Me.colSpeed.FieldName = "Speed"
			Me.colSpeed.Name = "colSpeed"
			Me.colSpeed.Visible = True
			Me.colSpeed.VisibleIndex = 0
			' 
			' gridColumn1
			' 
			Me.colGauge.Caption = "Speed On GaugeControl"
			Me.colGauge.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colGauge.FieldName = "Unbound"
			Me.colGauge.Name = "colGauge"
			Me.colGauge.UnboundType = DevExpress.Data.UnboundColumnType.Object
			Me.colGauge.Visible = True
			Me.colGauge.VisibleIndex = 1
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(698, 600)
			Me.Controls.Add(Me.gridControl)
			Me.Name = "Form1"
			Me.Text = "Inplace GaugeControl"
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private colSpeed As DevExpress.XtraGrid.Columns.GridColumn
		Private colGauge As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
	End Class
End Namespace