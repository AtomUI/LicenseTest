namespace AtomUI.DataGrid.LicenseTest;

public sealed record EmployeeInfo(string Number, string Name, string Department, string Position, string Email, string Location)
{
    public static IReadOnlyList<EmployeeInfo> CreateSample() =>
    [
        new("EMP001", "张晨", "研发中心", "高级开发工程师", "zhang.chen@example.test", "北京"),
        new("EMP002", "李欣", "产品中心", "产品经理", "li.xin@example.test", "上海"),
        new("EMP003", "王浩", "研发中心", "前端工程师", "wang.hao@example.test", "深圳"),
        new("EMP004", "赵敏", "设计中心", "交互设计师", "zhao.min@example.test", "杭州"),
        new("EMP005", "陈宇", "研发中心", "测试工程师", "chen.yu@example.test", "北京"),
        new("EMP006", "刘洋", "运营中心", "运营专员", "liu.yang@example.test", "上海"),
        new("EMP007", "周宁", "研发中心", "架构师", "zhou.ning@example.test", "深圳"),
        new("EMP008", "吴桐", "设计中心", "视觉设计师", "wu.tong@example.test", "杭州"),
        new("EMP009", "郑凯", "市场中心", "市场经理", "zheng.kai@example.test", "北京"),
        new("EMP010", "孙悦", "产品中心", "需求分析师", "sun.yue@example.test", "上海"),
        new("EMP011", "许航", "研发中心", "后端工程师", "xu.hang@example.test", "深圳"),
        new("EMP012", "林溪", "运营中心", "客户成功经理", "lin.xi@example.test", "杭州"),
        new("EMP013", "何睿", "研发中心", "桌面开发工程师", "he.rui@example.test", "北京"),
        new("EMP014", "高雅", "产品中心", "项目经理", "gao.ya@example.test", "上海"),
        new("EMP015", "罗远", "研发中心", "质量工程师", "luo.yuan@example.test", "深圳"),
        new("EMP016", "唐薇", "设计中心", "用户研究员", "tang.wei@example.test", "杭州"),
        new("EMP017", "马骏", "市场中心", "技术支持工程师", "ma.jun@example.test", "北京"),
        new("EMP018", "方晴", "运营中心", "内容运营", "fang.qing@example.test", "上海"),
        new("EMP019", "沈川", "研发中心", "性能工程师", "shen.chuan@example.test", "深圳"),
        new("EMP020", "顾妍", "产品中心", "产品设计师", "gu.yan@example.test", "杭州")
    ];
}
