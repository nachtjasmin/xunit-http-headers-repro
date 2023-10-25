using Xunit;
using System.Net.Http.Headers;

namespace xunit_http_headers_collection_repro;

public class MyHttpHeaders : HttpHeaders {}

public class UnitTest1
{
    [Fact]
    public void Test()
    {
        var a = new MyHttpHeaders();
        var b = new MyHttpHeaders();

        a.Add("test", "test");
        b.Add("test", "test");

        Assert.Equal(a, b);
    }
}