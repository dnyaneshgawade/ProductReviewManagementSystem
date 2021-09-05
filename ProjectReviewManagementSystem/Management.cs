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

        public void RetrivePerticularFields(List<ProductReview> review)
        {
            var recordedData = from list in review
                               select new { list.ProductId, list.Rating };
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id : " + item.ProductId + "\t\tProduct Rating : " + item.Rating);
            }
        }

        public void SkipRecords(List<ProductReview> review)
        {
            var recordedData = (from list in review
                                orderby list.Rating descending
                                select list).Skip(5);

            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductId + "User Id: " + item.UserId + "Product Rating: " + item.Rating + "Is Like: " + item.IsLike);
            }
        }

        public void DataTable(List<ProductReview> review)
        {
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            var recordedData = from list in review
                               select list;
            foreach (var item in recordedData)
            {
                dataTable.Rows.Add(item.ProductId, item.UserId, item.Rating, item.Review, item.IsLike);
            }
            var dataRow = from list in dataTable.AsEnumerable() select list;
            foreach (var item in dataRow)
            {
                Console.WriteLine(item.Field<int>("ProductId") +" " + item.Field<int>("UserId") + " " +
                    item.Field<double>("Rating") + " " + item.Field<string>("Review") + " " +
                    item.Field<bool>("IsLike") + " " );
            }
        }

        public void Operations()
        {
            while (choice != 10)
            {
                Console.WriteLine("\n Enter 1 for Display top Three records" +
                    "\n Enter 2 for Display Selected records" +
                    "\n Enter 3 for Display Count of Records For ProductID" +
                    "\n Enter 4 for Display Perticular Fields" +
                    "\n Enter 5 for Skip Five records" +
                    "\n Enter 6 for create DataTable " +
                    "\n Enter 10 for exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TopRecords(Program.list);
                        break;
                    case 2:
                        RetrivePerticularRecord(Program.list);
                        break;
                    case 3:
                        RetriveCount(Program.list);
                        break;
                    case 4:
                        RetrivePerticularFields(Program.list);
                        break;
                    case 5:
                        SkipRecords(Program.list);
                        break;
                    case 6:
                        DataTable(Program.list);
                        break;
                    default:
                        Console.WriteLine("Enter wrong input");
                        break;
                }
            }
        }
    }
}
