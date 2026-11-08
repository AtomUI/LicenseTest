using AtomUI.Desktop.Controls;

namespace AtomUI.DataGrid.LicenseTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Ensure(EmployeeGrid.Initialize(DataGridModuleHostOptions.Create()));
        Ensure(EmployeeGrid.SetColumns(
        [
            DataGridColumnDefinition.Create<EmployeeInfo>(new("number"), "工号", static row => row.Number, 110),
            DataGridColumnDefinition.Create<EmployeeInfo>(new("name"), "姓名", static row => row.Name, 110),
            DataGridColumnDefinition.Create<EmployeeInfo>(new("department"), "部门", static row => row.Department, 130),
            DataGridColumnDefinition.Create<EmployeeInfo>(new("position"), "职位", static row => row.Position, 160),
            DataGridColumnDefinition.Create<EmployeeInfo>(new("email"), "邮箱", static row => row.Email, 260),
            DataGridColumnDefinition.Create<EmployeeInfo>(new("location"), "办公地点", static row => row.Location, 130)
        ]));
        Ensure(EmployeeGrid.SetItems(EmployeeInfo.CreateSample(), static row => new DataGridRowKey(row.Number)));
    }

    private static void Ensure(DataGridResult result)
    {
        if (!result.IsSuccess)
        {
            throw new InvalidOperationException($"DataGrid initialization failed: {result.Error}");
        }
    }
}
