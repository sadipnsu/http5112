using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeasonApp.Models;
using System.Web.Http.Cors;


namespace SeasonApp.Controllers
{
    public class SeasonAPIController : ApiController
    {

        /// <summary>
        /// Receives an input of the temperature and provides information about the season
        /// </summary>
        /// <param name="temperature">The temperature in degrees C</param>
        /// <example>
        ///     GET api/SeasonAPI/GetSeason/21	->
        ///     Season.SeasonName = "Summer"
        ///     Season.PhotographerName = "Sean O."
        ///     Season.ImageURL = "https://unsplash.com/photos/KMn4VEeEPR8"
        ///     Season.Temperature = 21
        /// </example>
        /// <example>
        ///     GET api/SeasonAPI/GetSeason/17	->
        ///     Season.SeasonName = "Fall"
        ///     Season.PhotographerName = "Jeremy Thomas"
        ///     Season.ImageURL = "https://unsplash.com/photos/O6N9RV2rzX8"
        ///     Season.Temperature = 17
        /// </example>
        /// <example>
        ///     GET api/SeasonAPI/GetSeason/-15	-> 
        ///     Season.SeasonName = "Winter"
        ///     Season.PhotographerName = "Bob Canning"
        ///     Season.ImageURL = "https://unsplash.com/photos/r53rNKb_7s8"     
        ///     Season.Temperature = -15
        /// </example>
        /// <returns>
        /// A season object, containing properties including
        ///     SeasonName: The associated season with the temperature,
        ///     PhotographerName: The associated photographer for the image we are using,
        ///     ImageURL: The original image URL we are using
        /// </returns>
        [Route("api/SeasonAPI/GetSeason/{temperature}")]
        [EnableCors(origins:"*", methods:"*", headers:"*")]
        public Season GetSeason(int? temperature)
        {
            Season SeasonInfo = new Season();
            string season = "";
            string author = "";
            string img = "";
            
            if (temperature == null) {
                season = "unknown";
                author = "unknown";
                img = "unknown";

                
                SeasonInfo.SeasonName = season;
                SeasonInfo.PhotographerName = author;
                SeasonInfo.ImageURL = img;
                SeasonInfo.Temperature = (int)temperature;

                return SeasonInfo;
            }
            
            

            if (temperature > 20)
            {
                season = "Summer";
                author = "Sean O.";
                img = "https://unsplash.com/photos/KMn4VEeEPR8";
            }
            else if (temperature >= 15)
            {
                season = "Fall";
                author = "Jeremy Thomas";
                img = "https://unsplash.com/photos/O6N9RV2rzX8";
            }
            else if (temperature > 10)
            {
                season = "Spring";
                author = "Sergey Shmidt";
                img = "https://unsplash.com/photos/koy6FlCCy5s";
            }
            else
            {
                season = "Winter";
                author = "Bob Canning";
                img = "https://unsplash.com/photos/r53rNKb_7s8";
            }

            
            SeasonInfo.SeasonName = season;
            SeasonInfo.PhotographerName = author;
            SeasonInfo.ImageURL = img;
            SeasonInfo.Temperature = (int)temperature;


            return SeasonInfo;
        }
    }
}
