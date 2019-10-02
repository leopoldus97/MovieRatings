using System;
using System.Linq;
using System.Collections.Generic;
using MovieRatings.Core.Entity;
using MovieRatings.Core.DomainService;


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
            return movieRatings.Where(mr => mr.Reviewer == reviewer).Select(mr => mr.Grade).DefaultIfEmpty(0).Average();
        }

        public double AverageRatingOnMovie(int movie)
        {
            return movieRatings.Where(mr => mr.Movie == movie).Select(mr => mr.Grade).DefaultIfEmpty(0).Average();
        }

        public int GetCountOfGradesByReviewer(int reviewer, int grade)
        {
            return movieRatings.Where(mr => mr.Reviewer == reviewer).Where(mr => mr.Grade == grade).Count();
        }

        public int GetCountOfMovieReviews(int movie)
        {
            return movieRatings.Where(mr => mr.Movie == movie).Count();
        }

        public int GetCountOfMovieByGrade(int movie, int grade)
        {
            return movieRatings.Where(mr => mr.Movie == movie).Where(mr => mr.Grade == grade).Count();
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
