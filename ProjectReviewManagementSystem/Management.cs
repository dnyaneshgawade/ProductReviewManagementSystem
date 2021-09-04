using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectReviewManagementSystem
{
    public class Management
    {
        public static int choice;
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from list in review
                                orderby list.Rating descending
                                select list).Take(3);

            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductId+"User Id: "+item.UserId+"Product Rating: "+item.Rating+"Is Like: "+item.IsLike);
            }
        }

        public void RetrivePerticularRecord(List<ProductReview> review)
        {
            var recordedData = from list in review
                               where (list.ProductId == 1 || list.ProductId == 4 || list.ProductId == 9) && list.Rating > 3
                               select list;
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductId + "User Id: " + item.UserId + "Product Rating: " + item.Rating + "Is Like: " + item.IsLike);
            }
        }

        public void RetriveCount(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
      
            foreach (var item in recordedData)
            {
                Console.WriteLine(item.ProductID +  "---" + item.Count );
            }
        }

        public void Operations()
        {
            Program program = new Program();
            while (choice != 10)
            {
                Console.WriteLine("\n Enter 1 for Display top Three records\n Enter 2 for Display Selected records\n Enter 3 for Display Count of Records For ProductID \n Enter 10 for exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        this.TopRecords(Program.list);
                        break;
                    case 2:
                        RetrivePerticularRecord(Program.list);
                        break;
                    case 3:
                        RetriveCount(Program.list);
                        break;
                    default:
                        Console.WriteLine("Enter wrong input");
                        break;
                }
            }
        }
    }
}
