﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Invite
{
    class Invitation
    {
        static void Main(string[] args)
        {
            //URL where a text file containing JSON objects is located
            const string URL = "https://gist.githubusercontent.com/brianw/19896c50afa89ad4dec3/raw/" +
                "6c11047887a03483c50017c1d451667fd62a53ca/gistfile1.txt";

            //initialize a GPSPoint with Dublin GPS coordiantes
            GPSPoint DublinLocation = new GPSPoint(53.3381985 * Math.PI / 180,
                -6.2592576 * Math.PI / 180);

            //initialize a customer list using the classes UrlReader and JsonObjectReader
            //that implements the interfaces IReader and IObjectreader respectively
            try
            {
                UrlReader myUrlReader = new UrlReader(URL);
                JsonObjectReader<Customer> myJsonObjectReader = new JsonObjectReader<Customer>(myUrlReader);
                List<Customer> customers = myJsonObjectReader.FetchObjects().ToList();

                //sort list of customers by User_id
                List<Customer> sortedCustomers = (from c in customers orderby c.User_id select c)
                    .ToList<Customer>();

                //print out the list of invited customers
                foreach (Customer customer in sortedCustomers)
                {
                    if (customer.GetCustomerLocation().Distance(DublinLocation) <= 100)
                    {
                        Console.WriteLine("User ID: {0} Customer Name: {1} Distance: {2}",
                        customer.User_id, customer.Name, customer.GetCustomerLocation().Distance(DublinLocation));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
