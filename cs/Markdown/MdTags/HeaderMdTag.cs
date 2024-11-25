using Markdown.MdTags.Interfaces;

namespace Markdown.MdTags;

internal class HeaderMdTag : IMdTag, IHtmlTagsPair
{
    public string HtmlOpenTag => "<h1>";

    public string HtmlCloseTag => "</h1>";

    public bool IsMdTag(string mdString, int index, out int tagLength)
    {
        throw new NotImplementedException();
    }
}
