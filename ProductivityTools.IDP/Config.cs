// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace ProductivityTools.IDP
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            { };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
            new Client{
                ClientName="PW Gallery",
                ClientId="pwgalleryclient",
                AllowedGrantTypes=GrantTypes.Code,
                RedirectUris=new List<string>
                {
                    "https://localhost:6002/signin-oidc"
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile
                },
                ClientSecrets=
                {
                    new Secret("secret".Sha256())
                }
            } ,
            new Client
{
    ClientId = "js",
    ClientName = "JavaScript Client",
    AllowedGrantTypes = GrantTypes.Implicit,
    AllowAccessTokensViaBrowser = true,

    RedirectUris =           { "https://localhost:6002/callback.html" },
    PostLogoutRedirectUris = { "https://localhost:6002/index.html" },
    AllowedCorsOrigins =     { "https://localhost:6002" },

    AllowedScopes =
    {
        IdentityServerConstants.StandardScopes.OpenId,
        IdentityServerConstants.StandardScopes.Profile,
        "api1"
    }
}
            };

    }
}