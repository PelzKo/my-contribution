using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyContribution.Contacts
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Skill
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

    }

    public class Field
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
    public class RelativeTime
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int TimeAsNumber { get; set; }
        public bool Future { get; set; }

    }

    public class AccountRequest
    {
        public string Username { get; set; }
        public string Institution { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime TimeOfRegister { get; set; }

    }
    public class Account
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Institution { get; set; }
        public string PassHash { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime TimeOfRegister { get; set; }

    }

    public class OfferRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid[] Fields { get; set; }
        public Guid[] Skills { get; set; }
        [Required]
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string LastWorked { get; set; }
        public bool CoronaPassed { get; set; }
        [Required]
        public string AvailableFrom { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Radius { get; set; }
        public string Comment { get; set; }
    }

    public class Offer
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<Offer_Field> Fields { get; set; }
        public List<Offer_Skill> Skills { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string LastWorked { get; set; }
        public bool CoronaPassed { get; set; }
        [Required]
        public string AvailableFrom { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Radius { get; set; }
        public string Comment { get; set; }
        public int Entfernung { get; set; }

    }
    public class Offer_Field
    {
        public Guid Id { get; set; }
        public Guid OfferId { get; set; }
        public Guid FieldId { get; set; }

    }
    public class Offer_Skill
    {
        public Guid Id { get; set; }
        public Guid OfferId { get; set; }
        public Guid SkillId { get; set; }

    }
    public class AddressRequest
    {
        public string Full { get; set; }
    }

    public class Address
    {
        public string Full { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}
