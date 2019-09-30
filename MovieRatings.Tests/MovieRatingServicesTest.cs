using Moq;
using MovieRatings.Core.ApplicationService;
using MovieRatings.Core.ApplicationService.Services;
using MovieRatings.Core.DomainService;
using MovieRatings.Core.Entity;
using MovieRatings.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieRatings.Tests
{
    public class MovieRatingServicesTest
    {
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        public void GetNumberOfReviewsFromReviewerWithCorrectValues(int reviewer, int reviews)
        {
            var movieRatingRepository = new Mock<FakeMovieRatingRepository>();
            MovieRating movieRating1 = new MovieRating(1, 0, 2, DateTime.Now);
            MovieRating movieRating2 = new MovieRating(2, 1, 2, DateTime.Now);
            MovieRating movieRating3 = new MovieRating(2, 2, 2, DateTime.Now);
            MovieRating movieRating4 = new MovieRating(2, 3, 2, DateTime.Now);
            movieRatingRepository.Object.Add(movieRating1);
            movieRatingRepository.Object.Add(movieRating2);
            movieRatingRepository.Object.Add(movieRating3);
            movieRatingRepository.Object.Add(movieRating4);
            IMovieRatingServices movieRatingService = new MovieRatingServices(movieRatingRepository.Object);

            int actual = movieRatingService.GetReviewsByReviewer(reviewer);

            Assert.Equal(reviews, actual);
        }



    }
}
