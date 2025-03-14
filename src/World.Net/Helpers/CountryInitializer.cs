﻿namespace World.Net.Helpers;

internal sealed class CountryInitializer
{
    public static Dictionary<CountryIdentifier, ICountry> Initialize()
    {
        return new Dictionary<CountryIdentifier, ICountry>
        {
            { CountryIdentifier.Afghanistan, new Afghanistan() },
            { CountryIdentifier.AlandIslands, new AlandIslands() },
            { CountryIdentifier.Albania, new Albania() },
            { CountryIdentifier.Algeria, new Algeria() },
            { CountryIdentifier.AmericanSamoa, new AmericanSamoa() },
            { CountryIdentifier.Andorra, new Andorra() },
            { CountryIdentifier.Angola, new Angola() },
            { CountryIdentifier.Anguilla, new Anguilla() },
            { CountryIdentifier.Antarctica, new Antarctica() },
            { CountryIdentifier.AntiguaAndBarbuda, new AntiguaAndBarbuda() },
            { CountryIdentifier.Argentina, new Argentina() },
            { CountryIdentifier.Armenia, new Armenia() },
            { CountryIdentifier.Aruba, new Aruba() },
            { CountryIdentifier.Australia, new Australia() },
            { CountryIdentifier.Austria, new Austria() },
            { CountryIdentifier.Azerbaijan, new Azerbaijan() },
            { CountryIdentifier.Bahamas, new TheBahamas() },
            { CountryIdentifier.Bahrain, new Bahrain() },
            { CountryIdentifier.Bangladesh, new Bangladesh() },
            { CountryIdentifier.Barbados, new Barbados() },
            { CountryIdentifier.Belarus, new Belarus() },
            { CountryIdentifier.Belgium, new Belgium() },
            { CountryIdentifier.Belize, new Belize() },
            { CountryIdentifier.Benin, new Benin() },
            { CountryIdentifier.Bermuda, new Bermuda() },
            { CountryIdentifier.Bhutan, new Bhutan() },
            { CountryIdentifier.Bolivia, new Bolivia() },
            { CountryIdentifier.BosniaAndHerzegovina, new BosniaAndHerzegovina() },
            { CountryIdentifier.Botswana, new Botswana() },
            { CountryIdentifier.BouvetIsland, new BouvetIsland() },
            { CountryIdentifier.Brazil, new Brazil() },
            { CountryIdentifier.BritishIndianOceanTerritory, new BritishIndianOceanTerritory() },
            { CountryIdentifier.Brunei, new Brunei() },
            { CountryIdentifier.Bulgaria, new Bulgaria() },
            { CountryIdentifier.BurkinaFaso, new BurkinaFaso() },
            { CountryIdentifier.Burundi, new Burundi() },
            { CountryIdentifier.Cambodia, new Cambodia() },
            { CountryIdentifier.Cameroon, new Cameroon() },
            { CountryIdentifier.Canada, new Canada() },
            { CountryIdentifier.CapeVerde, new CapeVerde() },           
            { CountryIdentifier.CaymanIslands, new CaymanIslands() },           
            { CountryIdentifier.CentralAfricanRepublic, new CentralAfricanRepublic() },           
            { CountryIdentifier.Chad, new Chad() },           
            { CountryIdentifier.Chile, new Chile() },           
            { CountryIdentifier.China, new China() },           

            // Future countries can be added here in the same format.
        };
    }
}
