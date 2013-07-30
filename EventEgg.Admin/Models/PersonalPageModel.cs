﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using EventEgg.Admin.Library;
using EventEgg.Service.Models;

namespace EventEgg.Admin.Models
{
    public class PersonalLoginPageModel
    {
        [Required(ErrorMessage = "Eposta adresi boş olamaz!")]
        [DataType(DataType.Text)]
        [DisplayName("Email")]
        [EmailValidation(ErrorMessage = "Eposta adresiniz geçersiz görünüyor.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz boş olamaz")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }

    public class PersonalAddPageModel
    {
        public PersonalViewModel PersonalViewModel { get; set; }

        #region List

        public List<SelectListItem> RoleList
        {
            get
            {
                var list = new List<SelectListItem>
                    {
                        new SelectListItem {Value = "", Text = ""},
                        new SelectListItem {Value = "1", Text = "SystemAdmin"},
                        new SelectListItem {Value = "2", Text = "Editor"},
                        new SelectListItem {Value = "3", Text = "Developer"}
                    };

                return list;

            }
        }

        public List<SelectListItem> GenderList
        {
            get
            {
                var list = new List<SelectListItem>
                    {
                        new SelectListItem {Value = "1", Text = "Erkek"},
                        new SelectListItem {Value = "2", Text = "Kadın"},
                        new SelectListItem {Value = "3", Text = "Diğer"}
                    };

                return list;
            }
        }



        public List<SelectListItem> CountryList
        {
            get
            {
                var list = new List<SelectListItem>
                    {
                        new SelectListItem {Value = "", Text = ""},
                        new SelectListItem {Value = "1", Text = "Türkiye"},
                        new SelectListItem {Value = "2", Text = "Amerika"},
                        new SelectListItem {Value = "3", Text = "Yunanistan"}
                    };

                return list;
            }
        }

        #endregion
    }
}