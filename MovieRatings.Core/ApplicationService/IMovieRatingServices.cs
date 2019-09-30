using MovieRatings.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatings.Core.ApplicationService
{
    public interface IMovieRatingServices
    {
        int GetReviewsByReviewer(int reviewer);
        double AverageRatingByReviewer(int reviewer);
        int GetCountOfGrades(int reviewer, int grade);
        int GetCountOfMovieReviews(int movie);
        double AverageRatingOnMovie(int movie);
        int GetMovieReviewsByGrade(int movie, int grade);
        int GetTopGradedMovies();
        int GetTopReviewer();
        List<MovieRating> GetTopMovies(int number);
        List<MovieRating> GetMoviesByReviewer(int reviewer);
        List<MovieRating> GetReviewersByMovie(int movie);
    }
}
