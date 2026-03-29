using CustomerOnboardingApi.Application.Helpers;
using CustomerOnboardingApi.Domain;

namespace CustomerOnboardingApi.Application.Validators
{
    public class CustomerValidator
    {
        public static List<string> Validate(Customer customer)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(customer.FirstName))
                errors.Add("First name is required.");

            if (string.IsNullOrWhiteSpace(customer.LastName))
                errors.Add("Last name is required.");

            if (string.IsNullOrWhiteSpace(customer.Email))
                errors.Add("Email is required.");
            else if (!customer.Email.Contains("@"))
                errors.Add("Email must be valid.");

            if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
                errors.Add("Phone number is required.");

            if (!string.IsNullOrWhiteSpace(customer.Signature))
            {
                if (!Base64Validator.IsBase64String(customer.Signature))
                    errors.Add("Signature must be a valid Base64 string.");
            }



            return errors;
        }

    }
}
