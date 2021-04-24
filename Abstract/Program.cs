using Abstract.Factories;
using Abstract.Interfaces;
using Abstract.Models.Enums;
using System;
using System.Collections.Generic;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Abstract World!");

            IDashboardFactory dashboardFactory;

            List<Vendor> vendors = new List<Vendor>() { Vendor.GOOGLE, Vendor.FACEBOOK };
            foreach (var vendor in vendors)
            {
                switch (vendor)
                {
                    case Vendor.GOOGLE:
                        dashboardFactory = new GoogleFactory();
                        break;
                    case Vendor.FACEBOOK:
                        dashboardFactory = new FacebookFactory();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
