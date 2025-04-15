using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Threading.Tasks;
using Umbraco.Cms.Core;

namespace Umbraco.Cms.Core.DynamicRoot.QuerySteps;

public interface IDynamicRootQueryStep
{
    Task<Attempt<ICollection<Guid>>> ExecuteAsync(ICollection<Guid> origins, DynamicRootQueryStep filter);
    string SupportedDirectionAlias { get; }
}