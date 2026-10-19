using Contoso.Text;

namespace Demo;

public class PostService
{
    public string CreateSlug(string title) => Slug.Create(title);
}
