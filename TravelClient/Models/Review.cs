using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; } // FOREIGN KEY
        public int CityId { get; set; } // FOREIGN KEY


        // This method uses the method defined in the API helper to grab all the reviews from the database
        // The actual API call is made in the API helper (Have not made that method yet!)

        // public static List<Review> GetReviews()
        // {
        //     var apiCallTask = ApiHelper.GetAllReviewsAsync();
        //     var result = apiCallTask.Result;

        //     JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        //     List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

        //     return reviewList;
        // }


    }
}