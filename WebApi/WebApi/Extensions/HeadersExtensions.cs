using System.Net.Http.Headers;

namespace WebApi.Extensions
{
    public static class HeadersExtensions
    {
        public static Guid ETag(this HttpRequestHeaders headers)
        {
            Guid result = Guid.NewGuid();
            if (headers.IfNoneMatch != null)
            {
                Guid dummy;
                IEnumerable<Guid> etags = headers.IfNoneMatch
                    .Where(x => x != null && !string.IsNullOrEmpty(x.Tag) && Guid.TryParse(x.Tag.TrimEnd('\"').TrimStart('\"'), out dummy))
                    .Select(x => Guid.Parse(x.Tag.TrimEnd('\"').TrimStart('\"')));
                foreach (Guid etag in etags)
                {
                    if (etag != result) result = etag;
                }
            }
            return result;
        }
    }
}
