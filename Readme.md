<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/InplageGaugeControl/Form1.cs) (VB: [Form1.vb](./VB/InplageGaugeControl/Form1.vb))
<!-- default file list end -->
# How to use GaugeControl as an in-place editor


<p>This sample illustrates how you can embed your GaugeControl into the GridControl. <br />
1. Create your GaugeControl at runtime.<br />
2. Create an unbound column you wish to display the GaugeControl for.<br />
3. Assign the PictureEdit editor to the GridColumn.ColumnEdit property.<br />
4. Use the IGaugeContainer.GetImage method to get a gauge image, and assign this image in the CustomUnboundColumnData event 
<br />
handler.</p>

<br/>


