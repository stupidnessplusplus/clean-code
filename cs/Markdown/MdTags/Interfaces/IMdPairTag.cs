namespace Markdown.MdTags.Interfaces;

internal interface IMdPairTag : IMdTag
{
    public IEnumerable<TagIndicesPair> PairTagIndices(string mdString, IList<int> tagIndices);
}
