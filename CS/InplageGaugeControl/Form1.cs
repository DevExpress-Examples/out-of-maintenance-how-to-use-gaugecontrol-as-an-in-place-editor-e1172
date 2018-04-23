using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Presets.Styles;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Gauges.Circular;

namespace InplaceGaugeControl {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            
            CreateGaugeFromCode(Theme.MagicLight);

            for(int i = 25; i < 75; i += 5)
                dataSet.Tables[0].Rows.Add(new object[] { i });
        }
        GaugeControl gaugeControl;
        CircularGauge circularGauge;
        void CreateGaugeFromCode(Theme theme) {
            gaugeControl = new GaugeControl();
            gaugeControl.Size = new System.Drawing.Size(200, 200);

            circularGauge = gaugeControl.AddCircularGauge();
            circularGauge.AddDefaultElements();

            var style = StyleLoader.Load("Circular", theme.Name, "Full");
            if(style != null)
                style.Apply(circularGauge);
        }
        void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(e.Column == colGauge && e.IsGetData) {
                int speed = (int)gridView.GetRowCellValue(e.ListSourceRowIndex, colSpeed);
                circularGauge.Scales[0].Value = (float)speed;
                e.Value = ((IGaugeContainer)gaugeControl).GetImage(200, 200);
            }
        }
    }
}