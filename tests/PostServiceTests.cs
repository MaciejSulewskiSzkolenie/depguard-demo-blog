using Demo;
using Xunit;

public class PostServiceTests
{
    [Fact]
    public void CreateSlug_ReplacesSpaces() =>
        Assert.Equal("hello-world", new PostService().CreateSlug("Hello World"));

    [Fact]
    public void CreateSlug_StripsPunctuation() =>
        Assert.Equal("a-b", new PostService().CreateSlug("A, B!"));
}
