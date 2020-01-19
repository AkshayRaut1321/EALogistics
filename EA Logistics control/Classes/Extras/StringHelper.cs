namespace EA_Logistics_Control.Classes.Extras
{
    public static class StringHelper
    {
        public static string GetEmptyOrZero(this string value, bool empty)
        {
            if (!value.HasContent())
                return (empty ? "" : "0");
            return value;
        }
        public static bool HasContent(this string value)
        {
            return !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }
    }
}
