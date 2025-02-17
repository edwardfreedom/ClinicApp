using ClinicApp.Domain.Models.Clinics.ValueObjects;
using ClinicApp.Domain.Shared;

namespace ClinicApp.Domain.Errors;

public static class ClinicErrors
{
    public static Error NotFound(Guid id) => new(
        "Clinic.NotFound",
        $"Clinic with ID {id} was not found.");
    public static class AddressErrors
    {
        public static readonly Error Required = new(
            "Clinic.AddressRequired",
            "The clinic address is required.");

        public static readonly Error TooLong = new(
            "Clinic.AddressTooLong",
            $"The clinic address must not exceed {ClinicAddress.MaxLength} characters.");
    }

    public static class PhoneNumberErrors
    {
        public static readonly Error Required = new(
            "Clinic.PhoneNumberRequired",
            "The clinic phone number is required.");

        public static readonly Error Invalid = new(
            "Clinic.InvalidPhoneNumber",
            "The clinic phone number must contain only digits.");
    }
}
