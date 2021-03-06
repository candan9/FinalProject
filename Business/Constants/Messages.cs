﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde ürün zaten var.";
        public static string CategoryLimitExceded ="Kategori sınırı aşıldı.";
        public static string AuthorizationDenied ="Yetkiniz yok.";
        public static string UserRegistered= "kullanıcı kayıtlı";
        public static string UserNotFound= " kullanıcı bulunamadı.";
        public static string PasswordError="yanlış parola.";
        public static string SuccessfulLogin=" giriş başarılı";
        public static string UserAlreadyExists="kullanıcı zaten var";
        public static string AccessTokenCreated="Token oluşturuldu.";
        public static string ProductUpdated="Ürün güncellendi.";
    }
}
