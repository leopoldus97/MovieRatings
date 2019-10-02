using System;
using System.IO;
using System.Collections.Generic;
using MovieRatings.Core.Entity;
using MovieRatings.Core.DomainService;

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
            return movieRatingRepository.AverageRatingByReviewer(reviewer);
        }

        public double AverageRatingOnMovie(int movie)
        {
            return movieRatingRepository.AverageRatingOnMovie(movie);
        }

        public int GetCountOfGradesByReviewer(int reviewer, int grade)
        {
            if (!(grade > 0 && grade < 6))
            {
                throw new InvalidDataException("The grade has to be between 1-5");
            }
            return movieRatingRepository.GetCountOfGradesByReviewer(reviewer, grade);
        }

        public int GetCountOfMovieReviews(int movie)
        {
            return movieRatingRepository.GetCountOfMovieReviews(movie);
        }

        public int GetCountOfMovieByGrade(int movie, int grade)
        {
            if (!(grade > 0 && grade < 6))
            {
                throw new InvalidDataException("The grade has to be between 1-5");
            }
            return movieRatingRepository.GetCountOfMovieByGrade(movie, grade);
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
