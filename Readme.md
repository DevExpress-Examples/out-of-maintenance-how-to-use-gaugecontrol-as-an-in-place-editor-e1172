<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623988/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1172)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


