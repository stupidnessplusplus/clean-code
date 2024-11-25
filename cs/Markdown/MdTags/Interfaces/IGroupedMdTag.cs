namespace Markdown.MdTags.Interfaces;

internal interface IGroupedMdTag : IMdTag
{
    /// <summary>
    /// Тег-обертка для группы тегов.
    /// </summary>
    internal IHtmlTagsPair GroupHtmlTagsPair { get; }
}
