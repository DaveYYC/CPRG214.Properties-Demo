using System.Collections;
using CPRG214.Properties.Data;
using System.Linq;

namespace CPRG214.Properties.BLL
{
    public class PropertyTypeManager
    {
        public static IList GetAsKeyValuePairs()
        {
            var context = new RentalsContext();
            var types = context.PropertyTypes.Select(type => new
            {
                Value = type.Id,
                Text = type.Style
            }).ToList();
            return types;
        }
    }
}
