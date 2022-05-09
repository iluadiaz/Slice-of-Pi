﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace TestBDD
{
        // Sitewide definitions and useful methods
        public class Common
        {
            public const string BaseUrl = "https://localhost:44355";
            // Page names that everyone should use
            public const string HomePageName = "Home";
            public const string LoginPageName = "Login";
            public const string CityLookUpPageName = "CityCrimeLookUp";
            public const string CrimeStatsPageName = "CrimeStats";
            public const string StreetViewPageName = "StreetView";
            public const string StreetViewLookUpPageName = "StreetViewLookUp";

            // A handy way to look these up
            public static readonly Dictionary<string, string> Paths = new()
            {
                { HomePageName, "/" },
                { LoginPageName, "/Identity/Account/Login" },
                { CityLookUpPageName, "/Crime/CityCrimeLookUp" },
                { CrimeStatsPageName, "/Crime/CrimeStats"},
                { StreetViewLookUpPageName, "/ATTOM/StreetViewLookUp"},
                { StreetViewPageName, "/ATTOM/StreetView"}
            };

            public static string PathFor(string pathName) => Paths[pathName];
            public static string UrlFor(string pathName) => BaseUrl + Paths[pathName];
    
        }
    }
