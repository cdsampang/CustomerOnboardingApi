using CustomerOnboardingApi.Application.Validators;
using CustomerOnboardingApi.Domain;
using NUnit.Framework;

namespace CustomerOnboardingApi.Tests
{
    public class CustomerValidatorTests
    {
        [Test]
        public void Validate_ShouldFail_WhenFirstNameIsMissing()
        {
            var customer = new Customer
            {
                LastName = "Dela Cruz",
                Email = "juan@example.com",
                PhoneNumber = "09123456789"
            };

            var errors = CustomerValidator.Validate(customer);

            Assert.That(errors, Contains.Item("First name is required."));
        }

        [Test]
        public void Validate_ShouldFail_WhenEmailIsInvalid()
        {
            var customer = new Customer
            {
                FirstName = "Juan",
                LastName = "Dela Cruz",
                Email = "invalidemail",
                PhoneNumber = "09123456789"
            };

            var errors = CustomerValidator.Validate(customer);

            Assert.That(errors, Contains.Item("Email must be valid."));
        }

        [Test]
        public void Validate_ShouldPass_WhenAllFieldsAreValid()
        {
            var customer = new Customer
            {
                FirstName = "Juan",
                LastName = "Dela Cruz",
                Email = "juan@example.com",
                PhoneNumber = "09123456789"
            };

            var errors = CustomerValidator.Validate(customer);

            Assert.That(errors, Is.Empty);
        }

        [Test]
        public void Validate_ShouldFail_WhenSignatureIsNotBase64()
        {
            var customer = new Customer
            {
                FirstName = "Maria",
                LastName = "Santos",
                Email = "maria@example.com",
                PhoneNumber = "09998887777",
                Signature = "not-a-base64-string"
            };

            var errors = CustomerValidator.Validate(customer);

            Assert.That(errors, Contains.Item("Signature must be a valid Base64 string."));
        }

        [Test]
        public void Validate_ShouldPass_WhenSignatureIsNull()
        {
            var customer = new Customer
            {
                FirstName = "Pedro",
                LastName = "Reyes",
                Email = "pedro@example.com",
                PhoneNumber = "09123456789",
                Signature = null
            };

            var errors = CustomerValidator.Validate(customer);

            Assert.That(errors, Is.Empty);
        }


    }
}