using Builder.Builders;
using Builder.Directors;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReviewDirector director = new ReviewDirector();
            GoogleBuilder googleBuilder = new GoogleBuilder();
            director.constructBadGoogleReview(googleBuilder);
            var badGoogleReview = googleBuilder.getReview();

            FacebookBuilder facebookBuilder = new FacebookBuilder();
            director.constructAmazingFacebookRecommendation(facebookBuilder);
            var amazingFacebookReview = facebookBuilder.getReview();
        }
    }
}
