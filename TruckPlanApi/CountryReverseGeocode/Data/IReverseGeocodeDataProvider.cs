using System;
using System.Collections.Generic;
using System.Text;
using CountryReverseGeocode.Models;

namespace CountryReverseGeocode.Data
{
    public interface IReverseGeocodeDataProvider
    {
        List<AreaData> Data { get; }
     }
}
