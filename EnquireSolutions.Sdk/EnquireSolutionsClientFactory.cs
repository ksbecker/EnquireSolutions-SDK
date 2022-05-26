namespace EnquireSolutions.Sdk
{
    internal class EnquireSolutionsClientFactory
    {
        internal static void ConfigureHttpClientCore(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
        }
    }
}