using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartControl.Services
{
    public class Sales
    {
        static IList<SaleInfo> dataSource;
        static Sales()
        {
            CreateDataSource();
        }

        public static Task<IQueryable<SaleInfo>> GetSalesAsync()
        {
            return Task.FromResult(dataSource.AsQueryable());
        }

        static void CreateDataSource()
        {
            dataSource = new List<SaleInfo> {
                new() {
                    OrderId = 10248,
                    City = "Gen",
                    Amount = 6,
                    Date = DateTime.Parse("2017/01/06")
                },
                new() {
                    OrderId = 10249,
                    City = "Feb",
                    Amount = 8,
                    Date = DateTime.Parse("2019/01/13")
                },
                new() {
                    OrderId = 10250,
                    City = "Mar",
                    Amount = 4,
                    Date = DateTime.Parse("2017/01/07")
                },
                new() {
                    OrderId = 10251,
                    City = "Apr",
                    Amount = 22,
                    Date = DateTime.Parse("2018/01/03")
                },
                new() {
                    OrderId = 10252,
                    City = "Mag",
                    Amount = 18,
                    Date = DateTime.Parse("2017/01/10")
                },
                new() {
                    OrderId = 10253,
                    City = "Giu",
                    Amount = 12,
                    Date = DateTime.Parse("2017/01/17")
                },
                new() {
                    OrderId = 10254,
                    City = "Lug",
                    Amount = 23,
                    Date = DateTime.Parse("2017/01/21")
                },
                new() {
                    OrderId = 10255,
                    City = "Set",
                    Amount = 0,
                    Date = DateTime.Parse("2017/01/01")
                },
                new() {
                    OrderId = 10256,
                    City = "Ott",
                    Amount = 0,
                    Date = DateTime.Parse("2017/01/24")
                },
                new() {
                    OrderId = 10257,
                    City = "Nov",
                    Amount = 0,
                    Date = DateTime.Parse("2017/01/11")
                },
                new() {
                    OrderId = 10258,
                    City = "Dic",
                    Amount = 0,
                    Date = DateTime.Parse("2017/01/11")
                },
            // ...
            };
        }
    }
}