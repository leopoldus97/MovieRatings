using System;
using System.Collections.Generic;
using System.Text;
using MovieRatings.Core.DomainService;
using MovieRatings.Core.Entity;

namespace MovieRatings.Core.ApplicationService.Services
{
    public class MovieRatingServices : IMovieRatingServices
    {
        private readonly IMovieRatingRepository movieRatingRepository;
        public MovieRatingServices(IMovieRatingRepository movieRatingRepository)
        {
            this.movieRatingRepository = movieRatingRepository;
        }
        public double AverageRatingByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public double AverageRatingOnMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfGrades(int reviewer, int grade)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfMovieReviews(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetMovieReviewsByGrade(int movie, int grade)
        {
            throw new NotImplementedException();
        }

        public List<MovieRating> GetMoviesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<MovieRating> GetReviewersByMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetReviewsByReviewer(int reviewer)
        {
            return movieRatingRepository.GetReviewsByReviewer(reviewer);
        }

        public int GetTopGradedMovies()
        {
            throw new NotImplementedException();
        }

        public List<MovieRating> GetTopMovies(int number)
        {
            throw new NotImplementedException();
        }

        public int GetTopReviewer()
        {
            throw new NotImplementedException();
        }
    }
}
