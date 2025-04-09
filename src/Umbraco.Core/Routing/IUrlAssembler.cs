using Umbraco.Cms.Core.Models.PublishedContent;
using System;

namespace Umbraco.Cms.Core.Routing;

public interface IUrlAssembler
{
    Uri AssembleUrl(string path, Uri current, UrlMode mode);
}