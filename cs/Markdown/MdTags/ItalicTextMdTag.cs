using Markdown.MdTags.Interfaces;

namespace Markdown.MdTags;

internal class ItalicTextMdTag : IMdPairTag, IHtmlTagsPair
{
    public string HtmlOpenTag => "<em>";

    public string HtmlCloseTag => "</em>";

    public bool IsMdTag(string mdString, int index, out int tagLength)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TagIndicesPair> PairTagIndices(string mdString, IList<int> tagIndices)
    {
        throw new NotImplementedException();
    }
}
