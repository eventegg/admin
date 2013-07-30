using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EventEgg.Service.Infrastructure;
using EventEgg.Service.Interfaces;

namespace EventEgg.Service.Models
{
    public class PersonalViewModel : IViewModel
    {

        /*
         [Id]
      ,[Email]
      ,[FirstName]
      ,[LastName]
      ,[Password]
      ,[Gender]
      ,[RoleId]
      ,[CountryId]
      ,[CityId]
      ,[Address]
      ,[Phone]
      ,[Mobile]
      ,[Title]
      ,[BioDescription]
      ,[Type]
      ,[PersonalWebUrl]
      ,[GooglePlus]
      ,[Twitter]
      ,[Status]
      ,[CreatedDate]
      ,[LastModifiedDate]
         */


        public Guid Id { get; set; }

        [Required(ErrorMessage = "Eposta adresi girilmelidir.")]
        [EmailValidation(ErrorMessage = "Eposta adresi geçersiz görünüyor.")]
        [DisplayName("Eposta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Adı girilmelidir.")]
        [DisplayName("Adı")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyadı girilmelidir.")]
        [DisplayName("Soyadı")]
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Required(ErrorMessage = "Şifre girilmelidir.")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Cinsiyet")]
        public byte Gender { get; set; }


        [Required(ErrorMessage = "Rol seçilnelidir.")]
        [DisplayName("Rol")]
        public int RoleId { get; set; }


        [DisplayName("Ülke")]
        public int CountryId { get; set; }


        [DisplayName("Şehir")]
        public int CityId { get; set; }


        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Telefon")]
        public string Phone { get; set; }


        [DisplayName("Mobil")]
        public string Mobile { get; set; }


        [DisplayName("Başlık")]
        public string Title { get; set; }


        [DisplayName("Biyografi")]
        public string BioDescription { get; set; }


        [DisplayName("Type")]
        public byte Type { get; set; }


        [DisplayName("Web Site")]
        public string PersonalWebUrl { get; set; }


        [DisplayName("Google+")]
        public string GooglePlus { get; set; }

        [DisplayName("Twitter")]
        public string Twitter { get; set; }


        [DisplayName("Durum")]
        public byte Status { get; set; }
        
        [DisplayName("Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }


        [DisplayName("Güncelleme Tarihi")]
        public DateTime LastModifiedDate { get; set; }



    }
}
