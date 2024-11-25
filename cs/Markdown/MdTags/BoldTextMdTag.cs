using Markdown.MdTags.Interfaces;

namespace Markdown.MdTags;

internal class BoldTextMdTag : IMdPairTag, IHtmlTagsPair
{
    public string HtmlOpenTag => "<strong>";

    public string HtmlCloseTag => "</strong>";

    public bool IsMdTag(string mdString, int index, out int tagLength)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TagIndicesPair> PairTagIndices(string mdString, IList<int> tagIndices)
    {
        throw new NotImplementedException();
    }
}
