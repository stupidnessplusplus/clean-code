namespace Markdown.MdTags.Interfaces;

internal interface IMdTag
{
    public bool IsMdTag(string mdString, int startIndex, out int tagLength);
}
