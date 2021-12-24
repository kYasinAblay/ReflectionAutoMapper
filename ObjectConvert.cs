

using System.Linq;
using System.Reflection;

namespace ReflectionAutoMapVS2022
{
    internal static class ObjectConvert
    {
        public static ModelResult Convert<m, ModelResult>(m Model) where ModelResult : class, new()
        {
            ModelResult result = new ModelResult();
            foreach (var item in typeof(m).GetProperties().ToList())
            {
                var property = typeof(ModelResult).GetProperty(item.Name);
                if (property != null)
                {
                    property.SetValue(result, item.GetValue(Model));
                }
            }
            return result;
        }
    }
}
