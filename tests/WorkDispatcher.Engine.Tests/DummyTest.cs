using WorkDispatcher.Core;

namespace WorkDispatcher.Engine.Tests;

public class DummyTest
{
    [Fact]
    public void Test1()
    {
        var ctrl = new SomeCtrl();
        var s = ctrl.GetInt();
        var t = ctrl.GetString();
    }
}