using Umbraco.Cms.Core.Composing;
using System;
using System.Collections.Generic;

namespace Umbraco.Cms.Core.Installer;

public class NewInstallStepCollection : BuilderCollectionBase<IInstallStep>
{
    public NewInstallStepCollection(Func<IEnumerable<IInstallStep>> items)
        : base(items)
    {
    }
}