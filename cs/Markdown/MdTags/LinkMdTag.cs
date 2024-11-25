using Markdown.MdTags.Interfaces;

namespace Markdown.MdTags;

internal class LinkMdTag : IMdTag, IHtmlConverter
{
    public bool IsMdTag(string mdString, int startIndex, out int tagLength)
    {
        throw new NotImplementedException();
    }

    public string GetHtmlString(string mdString, int startIndex)
    {
        throw new NotImplementedException();
    }
}
