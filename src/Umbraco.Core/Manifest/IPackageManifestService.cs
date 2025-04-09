using System.Collections.Generic;
using System.Threading.Tasks;

namespace Umbraco.Cms.Core.Manifest;

public interface IPackageManifestService
{
    Task<IEnumerable<PackageManifest>> GetAllPackageManifestsAsync();

    Task<IEnumerable<PackageManifest>> GetPublicPackageManifestsAsync();

    Task<IEnumerable<PackageManifest>> GetPrivatePackageManifestsAsync();

    Task<PackageManifestImportmap> GetPackageManifestImportmapAsync();
}