using System;
using System.Collections.Generic;
using System.Text;

namespace qastly.Models
{
    public static class OAuthSettings
    {
        public const string ApplicationId = "79ecd27e-e111-437e-bf69-9766068be8d8";
        public const string Scopes = "User.Read Calendars.Read Files.ReadWrite.AppFolder";        
        public const string RedirectUri = "msauth://com.companyname.GraphTutorial";
        //public const string Scopes = "User.Read Calendars.Read";

    }
}
