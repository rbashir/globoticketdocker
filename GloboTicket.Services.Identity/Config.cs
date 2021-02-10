// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace GloboTicket.Services.Identity
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("eventcatalog","Event Catalog APIs")
                {
                    Scopes = { "eventcatalog.read", "eventcatalog.write" }
                },
                new ApiResource("shoppingbasket","Shopping basket API")
                {
                    Scopes = { "shoppingbasket.fullaccess" }
                },
                new ApiResource("discount","Discount API")
                {
                    Scopes = { "discount.fullaccess" }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("eventcatalog.fullaccess"),
                new ApiScope("shoppingbasket.fullaccess"),
                new ApiScope("eventcatalog.read"),
                new ApiScope("eventcatalog.write"),
                new ApiScope("discount.fullaccess")
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "GloboTicket Machine to Machine client",
                    ClientId = "globoticketm2m",
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = {"eventcatalog.fullaccess"}
                },
                 new Client
                {
                    ClientName = "Globo Ticket interactive Client",
                    ClientId = "globoticketinteractive",
                    ClientSecrets = { new Secret("50C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:5000/signin-oidc" },
                    //FrontChannelLogoutUri = "https://localhost:5000/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                    //AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "shoppingbasket.fullaccess" }
                },
                  new Client
                {
                    ClientName = "GloboTicket Client",
                    ClientId = "globoticket",
                    ClientSecrets = { new Secret("50C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },
                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RedirectUris = { "https://localhost:5000/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },
                    AllowedScopes = { "openid", "profile", "shoppingbasket.fullaccess" ,
                          "eventcatalog.read", "eventcatalog.write" }
                }
                  ,
                new Client
                {
                    ClientId = "shoppingbaskettodownstreamtokenexchangeclient",
                    ClientName = "Shopping Basket Token Exchange Client",
                    AllowedGrantTypes = new[] { "urn:ietf:params:oauth:grant-type:token-exchange" },
                    ClientSecrets = { new Secret("0cdea0bc-779e-4368-b46b-09956f70712c".Sha256()) },
                    AllowedScopes = {
                         "openid", "profile", "discount.fullaccess" }
                },

            };
    }
}