# How to enter the unique value in WPF DataGrid (SfDataGrid) ?

This sample show cases how to enter the unique value in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid)?

# About the sample

You can make a specific column accept unique value per row using [SfDataGrid.CurrentCellValidating](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_CurrentCellValidating) event in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

```Xaml
<syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding Orders}" AutoGenerateColumns="False" AllowEditing="True" CurrentCellValidating="dataGrid_CurrentCellValidating" >
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:GridTextColumn MappingName="OrderID" HeaderText="Order ID" />
        <syncfusion:GridTextColumn MappingName="CustomerID" HeaderText="Customer ID" />
        <syncfusion:GridTextColumn MappingName="Country"/>
        <syncfusion:GridTextColumn MappingName="CustomerName" HeaderText="Customer Name" />
        <syncfusion:GridTextColumn MappingName="ShipCity" HeaderText="Ship City" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
```
```c#
private void dataGrid_CurrentCellValidating(object sender, Syncfusion.UI.Xaml.Grid.CurrentCellValidatingEventArgs e)
{
    if (e.Column.MappingName == "OrderID")
    {
        for (int i = 0; i < dataGrid.View.Records.Count; i++)
        {
            if ((this.dataGrid.View.Records[i].Data as OrderInfo).OrderID.ToString().Equals((e.NewValue.ToString())) && (e.NewValue.ToString() != e.OldValue.ToString()))
            {
                e.IsValid = false;
                e.ErrorMessage = "Invalid Value";
                break;
            }
        }
    }
}
```

KB article - [How to enter the unique value in WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/12043/how-to-enter-the-unique-value-in-wpf-datagrid-sfdatagrid)

## Requirements to run the demo
 Visual Studio 2015 and above versions
