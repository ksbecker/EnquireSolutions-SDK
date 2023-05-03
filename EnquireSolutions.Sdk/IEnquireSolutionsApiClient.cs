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
    Task<IndividualResponse> IndividualGetAsync([AliasAs("id")] int individualId, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Put("/Object")]
    Task<IEnumerable<ObjectPutResponse>> ObjectPutAsync([Body(true)] ObjectRequest objectRequest, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Portal")]
    Task<IEnumerable<PortalResponse>> PortalsGetAsync(CancellationToken cancellationToken = default);

    [Get("/Object?Type=23")]
    Task<IndividualObjectResponse> IndividualObjectGetAsync(EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Object?Type=29")]
    Task<IndividualObjectResponse> FormObjectGetAsync(EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Address")]
    Task<IEnumerable<AddressResponse>> AddressesGetAsync([AliasAs("IndividualId")] int individualId, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Post("/Individual")]
    Task<IndividualPostResponse> IndividualPostAsync([Body(true)] IndividualRequest individualRequest, EnquireQueryParams parameters, CancellationToken cancellationToken = default);

    [Get("/Search?PageNumber={pageNumber}&PageSize={pageSize}")]
    Task<SearchResponse> SearchAsync([AliasAs("pageNumber")] int pageNumber, [AliasAs("pageSize")] int pageSize, EnquireQueryParams parameters, CancellationToken cancellationToken);

    [Get("/Search/All?PageNumber={pageNumber}&PageSize={pageSize}")]
    Task<SearchAllResponse> SearchAllAsync([AliasAs("pageNumber")] int pageNumber, [AliasAs("pageSize")] int pageSize, EnquireQueryParams parameters, CancellationToken cancellationToken);
}
