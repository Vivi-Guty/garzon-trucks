using inercya.EntityLite.Extensions;
using inercya.EntityLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public partial class TextRepository
    {
        public Dictionary<string, Dictionary<string, string>> TextsByLanguageCode { get; set; }

        public async Task<Dictionary<string, Dictionary<string, string>>> GetTextsByLanguageCode()
        {
            var dic = new Dictionary<string, Dictionary<string, string>>();
            var getters = typeof(Text).GetPropertyGetters()
                .Where(kv => kv.Key.StartsWith("Text") && kv.Key != TextFields.TextId)
                .ToDictionary(kv => kv.Key.Substring(4).ToLower(), kv => kv.Value);

            foreach (var kv in getters)
            {
                dic.Add(kv.Key, new Dictionary<string, string>());
            }

            foreach (var text in await this.Query(Projection.BaseTable).ToEnumerableAsync())
            {
                foreach (var kv in getters)
                {
                    dic[kv.Key].Add(text.NameLocalizable, (string)kv.Value(text));
                }
            }

            return dic;
        }
    }
}
