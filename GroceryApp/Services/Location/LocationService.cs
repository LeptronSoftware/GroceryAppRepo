using Microsoft.Maui.Devices.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.Location
{
    public class LocationService : ILocationService
    {  
        public LocationService()
        {
            
        }
        public async Task<string> GetCity()
        {
            try
            {
               
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null) return "Error";
                var placemarks = await Geocoding.GetPlacemarksAsync(location);
                var placemark = placemarks?.FirstOrDefault();
                var city = placemark?.Locality;
                return city == null ? "Error" : city;

            }
            //TODO: Catch one of the following exceptions:
            //   FeatureNotSupportedException
            //   FeatureNotEnabledException
            //   PermissionException
            catch (Exception ex)
            {
                // Unable to get location
                return "Error " + ex.Message;
            }
        }

    }
}
