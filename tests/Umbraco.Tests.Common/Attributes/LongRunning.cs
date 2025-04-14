using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace Umbraco.Cms.Tests.Common.Attributes;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
public class LongRunning : CategoryAttribute
{
    public LongRunning()
        : base(TestConstants.Categories.LongRunning)
    {
    }
}
