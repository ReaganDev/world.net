﻿namespace World.Net.Helpers;

internal sealed class CountryInitializer
{
    public static Dictionary<int, ICountry> Initialize()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AfghanistanId, new Afghanistan() },
            { CountryIdentifier.AlandIslands, new AlandIslands() },
            { CountryIdentifier.Albania, new Albania() },
            { CountryIdentifier.Algeria, new Algeria() },
            { CountryIdentifier.AmericanSamoa, new AmericanSamoa() },
            { CountryIdentifier.Andorra, new Andorra() },
            { CountryIdentifier.AntiguaAndBarbuda, new AntiguaAndBarbuda() },
            { CountryIdentifier.Armenia, new Armenia() },
            { CountryIdentifier.Argentina, new Argentina() },
            { CountryIdentifier.Angola, new Angola() },
            { CountryIdentifier.Anguilla, new Anguilla() },
            { CountryIdentifier.Antarctica, new Antarctica() }
            // Future countries can be added here in the same format.
        };
    }
}
