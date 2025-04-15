namespace Umbraco.Cms.Core.DynamicRoot.QuerySteps;

using System;
using System.Collections.Generic;

public class DynamicRootQueryStep
{
    /// <summary>
    /// Empty means all Doctypes
    /// </summary>
    public IEnumerable<Guid> AnyOfDocTypeKeys { get; set; } = Array.Empty<Guid>();

    public string Alias { get; set; } = string.Empty;
}