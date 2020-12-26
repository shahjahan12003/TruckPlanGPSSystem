using System;
using System.Collections.Generic;
using System.Linq;
using CountryReverseGeocode.Data;
using CountryReverseGeocode.Models;

namespace CountryReverseGeocode
{
    public interface ICountryReverseGeocodeService
    {
        LocationInfo FindCountry(GeoLocation location); 
        LocationInfo FindAreaData(GeoLocation location, List<AreaData> areaDataList);
    }

    public class CountryReverseGeocodeService : ICountryReverseGeocodeService
    {
        public CountryReverseGeocodeService()
        {
            this.CountryDataProvider = new CountryDataProvider();
            
        }
        public IReverseGeocodeDataProvider CountryDataProvider { get; set; }
       

        public LocationInfo FindCountry(GeoLocation location)
        {
            if (CountryDataProvider == null) throw new Exception("No country data provider set. Set via 'CountryDataProvider' property.");
            return FindAreaData(location, CountryDataProvider.Data);
        }

        

        public LocationInfo FindAreaData(GeoLocation location, List<AreaData> areaDataList)
        {
            var matchedAreaData = areaDataList.Find(areaData => IsLocationInArea(location, areaData));
            return matchedAreaData != null ? LocationInfo.FromAreaData(matchedAreaData) : null;
        }

        private bool IsLocationInArea(GeoLocation location, AreaData data)
        {
            return data.coordinates.Any(polygon =>
            {
                List<GeoLocation> locations = polygon.Select(point => new GeoLocation { Latitude = point[1], Longitude = point[0] }).ToList();
                return location.IsInPolygon(locations);
            });
        }
    }
}