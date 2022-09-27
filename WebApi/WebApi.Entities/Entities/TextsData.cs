using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class TextsData
    {
        public Dictionary<string, Dictionary<string, string>>? TextsByLanguageCode { get; set; }
    }
}
