<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621003/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4899)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyBaseTabPageViewInfo.cs](./CS/MyRegistrator/MyBaseTabPageViewInfo.cs) (VB: [MyBaseTabPageViewInfo.vb](./VB/MyRegistrator/MyBaseTabPageViewInfo.vb))
* [MyRegistrator.cs](./CS/MyRegistrator/MyRegistrator.cs) (VB: [MyRegistrator.vb](./VB/MyRegistrator/MyRegistrator.vb))
* [MySkinTabHeaderViewInfo.cs](./CS/MyRegistrator/MySkinTabHeaderViewInfo.cs) (VB: [MySkinTabHeaderViewInfo.vb](./VB/MyRegistrator/MySkinTabHeaderViewInfo.vb))
* [MySkinTabPainter.cs](./CS/MyRegistrator/MySkinTabPainter.cs) (VB: [MySkinTabPainter.vb](./VB/MyRegistrator/MySkinTabPainter.vb))
* [MyTabControl.cs](./CS/MyTabControl/MyTabControl.cs) (VB: [MyTabControl.vb](./VB/MyTabControl/MyTabControl.vb))
* [MyXtraTabPage.cs](./CS/MyTabControl/MyXtraTabPage.cs) (VB: [MyXtraTabPageCollection.vb](./VB/MyTabControl/MyXtraTabPageCollection.vb))
* [MyXtraTabPageCollection.cs](./CS/MyTabControl/MyXtraTabPageCollection.cs) (VB: [MyXtraTabPageCollection.vb](./VB/MyTabControl/MyXtraTabPageCollection.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraForm1.cs](./CS/XtraForm1.cs) (VB: [XtraForm1.vb](./VB/XtraForm1.vb))
<!-- default file list end -->
# How to hide a tab page header


<p>This example demonstrates how to create a custom XtraTabControl with the capability to hide the header of a particular tab page. <br />
</p><p>For this, we have created a custom XtraTabControl and set its PaintStyleName property to a custom PaintStyle name.</p><p>We have also overridden the CreateTabCollection method to return a custom XtraTabPageCollection of custom XtraTabPages with the new HidePageHeader property that allows managing the tab page header visibility.</p><p>You can select a page with the hidden header in code.</p>

<br/>


