using Umbraco.Cms.Core.Composing;
using System;
using System.Collections.Generic;

namespace Umbraco.Cms.Core.Snippets;

public class PartialViewSnippetCollection : BuilderCollectionBase<PartialViewSnippet>
{
    public PartialViewSnippetCollection(Func<IEnumerable<PartialViewSnippet>> items)
        : base(items)
    {
    }
}