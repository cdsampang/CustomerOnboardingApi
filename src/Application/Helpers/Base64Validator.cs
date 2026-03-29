namespace CustomerOnboardingApi.Application.Helpers
{
    public class Base64Validator
    {
        public static bool IsBase64String(string value)
        {
            try
            {
                // Remove data URI prefix if present
                var base64 = value.Contains(",") ? value.Split(",")[1] : value;

                // Try convert
                Convert.FromBase64String(base64);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
