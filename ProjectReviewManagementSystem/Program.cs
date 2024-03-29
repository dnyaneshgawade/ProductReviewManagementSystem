﻿using System;
using System.Collections.Generic;

namespace ProjectReviewManagementSystem
{
    public class Program
    {
        public static List<ProductReview> list = new List<ProductReview>()
        {
            new ProductReview(){ProductId=1,UserId=1,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=2,UserId=2,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=3,UserId=3,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=4,UserId=4,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=5,UserId=5,Rating=3,Review="Good",IsLike=true},
            new ProductReview(){ProductId=6,UserId=6,Rating=3,Review="Good",IsLike=true},
            new ProductReview(){ProductId=7,UserId=1,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=8,UserId=2,Rating=1,Review="Flop",IsLike=false},
            new ProductReview(){ProductId=9,UserId=3,Rating=2,Review="Average",IsLike=false},
            new ProductReview(){ProductId=10,UserId=4,Rating=3,Review="Good",IsLike=true},
            new ProductReview(){ProductId=11,UserId=5,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=12,UserId=6,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=13,UserId=7,Rating=1,Review="Flop",IsLike=false},
            new ProductReview(){ProductId=14,UserId=1,Rating=1,Review="Flop",IsLike=false},
            new ProductReview(){ProductId=15,UserId=2,Rating=2,Review="Average",IsLike=false},
            new ProductReview(){ProductId=16,UserId=3,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=17,UserId=4,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=18,UserId=5,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=19,UserId=6,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=20,UserId=1,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=21,UserId=7,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=22,UserId=6,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=23,UserId=5,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=24,UserId=4,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=25,UserId=3,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=26,UserId=10,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=27,UserId=10,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=28,UserId=10,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=29,UserId=10,Rating=4,Review="Nice",IsLike=true},
            new ProductReview(){ProductId=30,UserId=10,Rating=3,Review="Good",IsLike=true},
            new ProductReview(){ProductId=31,UserId=10,Rating=3,Review="Good",IsLike=true},
            new ProductReview(){ProductId=32,UserId=10,Rating=5,Review="Excellent",IsLike=true},
            new ProductReview(){ProductId=33,UserId=10,Rating=1,Review="Flop",IsLike=false},
            new ProductReview(){ProductId=34,UserId=10,Rating=2,Review="Average",IsLike=false},
            new ProductReview(){ProductId=35,UserId=10,Rating=3,Review="Good",IsLike=true}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Product Review Management system!");
            Management management = new Management();
            management.Operations();
        }
    }
}
