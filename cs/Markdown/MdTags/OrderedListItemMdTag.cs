using Markdown.MdTags.Interfaces;

namespace Markdown.MdTags;

internal class OrderedListItemMdTag : IGroupedMdTag, IHtmlTagsPair
{
    private readonly OrderedListHtmlTagsPair _orderedListTags = new();

    public string HtmlOpenTag => "<li>";

    public string HtmlCloseTag => "</li>";

    public IHtmlTagsPair GroupHtmlTagsPair => _orderedListTags;

    public bool IsMdTag(string mdString, int startIndex, out int tagLength)
    {
        throw new NotImplementedException();
    }
}
