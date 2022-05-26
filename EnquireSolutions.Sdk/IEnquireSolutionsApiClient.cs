using EnquireSolutions.Sdk.Models;

using Refit;

namespace EnquireSolutions.Sdk;

public class EnquireQueryParams
{
    [AliasAs("PortalId")]
    public int PortalId { get; set; } = default!;
}

public interface IEnquireSolutionsApiClient
{
    [Get("/Individual/{id}")]
    Task<IndividualResponse> Individual([AliasAs("id")] int individualId, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Put("/Object")]
    Task<IEnumerable<ObjectPutResponse>> Object([Body(true)] ObjectRequest objectRequest, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Portal")]
    Task<IEnumerable<PortalResponse>> Portals(CancellationToken cancellationToken = default);

    [Get("/Object?Type=23")]
    Task<IndividualObjectResponse> IndividualObject(EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Object?Type=29")]
    Task<IndividualObjectResponse> FormObject(EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Address")]
    Task<IEnumerable<AddressResponse>> Addresses([AliasAs("IndividualId")] int individualId, EnquireQueryParams parameters, CancellationToken cancellationToken = default);
}
