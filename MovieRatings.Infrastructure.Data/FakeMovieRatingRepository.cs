using MovieRatings.Core.DomainService;
using MovieRatings.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRatings.Infrastructure.Data
{
    public class FakeMovieRatingRepository : IMovieRatingRepository
    {
        List<MovieRating> movieRatings = new List<MovieRating>();

        public void Add(MovieRating movieRating)
        {
            movieRatings.Add(movieRating);    
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
            return movieRatings.Where(mr => mr.Reviewer == reviewer).Count();
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
