namespace InplaceGaugeControl {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.dataSet = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGauge = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
            this.gridControl.DataMember = "SpeedTable";
			this.gridControl.DataSource = this.dataSet;
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.Location = new System.Drawing.Point(0, 0);
			this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
			this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
			this.gridControl.Size = new System.Drawing.Size(698, 600);
			this.gridControl.TabIndex = 0;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// dataSet1
			// 
			this.dataSet.DataSetName = "NewDataSet";
			this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
			this.dataTable1.TableName = "SpeedTable";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "Speed";
			this.dataColumn1.DataType = typeof(int);
			// 
			// gridView1
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSpeed,
            this.colGauge});
			this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.RowHeight = 200;
			this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
			// 
			// colColumn1
			// 
			this.colSpeed.Caption = "SpeedValue";
            this.colSpeed.FieldName = "Speed";
            this.colSpeed.Name = "colSpeed";
			this.colSpeed.Visible = true;
			this.colSpeed.VisibleIndex = 0;
			// 
			// gridColumn1
			// 
			this.colGauge.Caption = "Speed On GaugeControl";
			this.colGauge.ColumnEdit = this.repositoryItemPictureEdit1;
			this.colGauge.FieldName = "Unbound";
            this.colGauge.Name = "colGauge";
			this.colGauge.UnboundType = DevExpress.Data.UnboundColumnType.Object;
			this.colGauge.Visible = true;
			this.colGauge.VisibleIndex = 1;
			// 
			// repositoryItemPictureEdit1
			// 
			this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 600);
			this.Controls.Add(this.gridControl);
			this.Name = "Form1";
			this.Text = "Inplace GaugeControl";
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private System.Data.DataSet dataSet;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
		private DevExpress.XtraGrid.Columns.GridColumn colGauge;
		private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
	}
}