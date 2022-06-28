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
    Task<IndividualResponse> IndividualGet([AliasAs("id")] int individualId, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Put("/Object")]
    Task<IEnumerable<ObjectPutResponse>> ObjectPut([Body(true)] ObjectRequest objectRequest, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Portal")]
    Task<IEnumerable<PortalResponse>> PortalsGet(CancellationToken cancellationToken = default);

    [Get("/Object?Type=23")]
    Task<IndividualObjectResponse> IndividualObjectGet(EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Object?Type=29")]
    Task<IndividualObjectResponse> FormObjectGet(EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Address")]
    Task<IEnumerable<AddressResponse>> AddressesGet([AliasAs("IndividualId")] int individualId, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Post("/Individual")]
    Task<string> IndividualPost([Body(true)] IndividualRequest individualRequest, EnquireQueryParams parameters, CancellationToken cancellationToken = default);
}
