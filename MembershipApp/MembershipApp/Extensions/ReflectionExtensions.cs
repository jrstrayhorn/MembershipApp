namespace MembershipApp.Extensions
{
    public static class ReflectionExtensions
    {
        public static string GetPropertyValue<T>(this T item, string propertyName)
        {
            // reflecting over the item and pulling out the property value
            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
        }
    }
}