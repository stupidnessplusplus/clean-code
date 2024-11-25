using Markdown.MdTags;
using Markdown.MdTags.Interfaces;

namespace Markdown;

public class Md : IStringProcessor
{
    /// <summary>
    /// Теги в порядке, в котором происходит проверка на них.
    /// </summary>
    private readonly IMdTag[] _mdTags =
    [
        new OrderedListItemMdTag(),
        new UnorderedListItemMdTag(),
        new HeaderMdTag(),
        new ImageMdTag(),
        new LinkMdTag(),
        new BoldTextMdTag(),
        new ItalicTextMdTag(),
    ];

    public string Render(string mdString)
    {
        var tagsIndices = _mdTags
            .ToDictionary(tag => tag, tag => GetTagIndices(mdString, tag).ToArray());

        throw new NotImplementedException();
    }

    private IEnumerable<int> GetTagIndices(string mdString, IMdTag tag)
    {
        for (var i = 0; i < mdString.Length; i++)
        {
            if (tag.IsMdTag(mdString, i, out var tagLength))
            {
                yield return i;
                i += tagLength - 1;
            }
        }
    }
}
