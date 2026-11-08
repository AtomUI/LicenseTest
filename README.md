# DataGrid 商业包临时测试

用 Rider 打开 `AtomUI.DataGrid.LicenseTest.sln`，构建并运行项目。

- 一个主窗体，商业 DataGrid 显示 20 条员工信息、6 列。
- DataGrid 包：`1.0.0-local.20261029.1`；传递 SDK：`AtomUI.License 1.0.0-local.14`。
- NuGet 源：`/Users/chinboy/Data/nuget-atomui-local` 与 nuget.org。
- 本地授权 API：`https://localhost:44339`；认证服务：`https://localhost:44340`。
- 未授权时，正常交互构建会提示授权链接；本地服务需要处于运行状态。
- 默认使用 SDK 的用户凭据存储；如需复用指定测试存储，Rider 的构建进程需设置相同的 `ATOMUI_LICENSE_DATA_DIR`。

这是独立临时消费者，未创建 Git 仓库，也不引用 SDK 或 DataGrid 的源码工程。
