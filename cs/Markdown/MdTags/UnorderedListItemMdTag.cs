using Markdown.MdTags.Interfaces;

namespace Markdown.MdTags;

internal class UnorderedListItemMdTag : IGroupedMdTag, IHtmlTagsPair
{
    private readonly UnorderedListHtmlTagsPair _unorderedListTags = new();

    public string HtmlOpenTag => "<li>";

    public string HtmlCloseTag => "</li>";

    public IHtmlTagsPair GroupHtmlTagsPair => _unorderedListTags;

    public bool IsMdTag(string mdString, int startIndex, out int tagLength)
    {
        throw new NotImplementedException();
    }
}
