using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST;


public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnMyName(){
        var returnValue = controller.Get(1);
        Assert.Equal("Zongwen Xue", returnValue);
    }

    [Fact]
    public void Test1()
    {

    }
}