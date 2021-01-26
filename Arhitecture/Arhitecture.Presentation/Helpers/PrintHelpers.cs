using System;
using System.Collections.Generic;
using Arhitecture.Data.Entities.Models;

namespace Arhitecture.Presentation.Helpers
{
    public static class PrintHelpers
    {
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"Id: {employee.Id} \n" +
                              $"First Name: {employee.FirstName} \n" +
                              $"Last Name: {employee.LastName} \n" +
                              $"Beginig of shift: {employee.BeginingOfShift} \n" +
                              $"Ending of shift: {employee.EndingOfShift}");
        }

        public static void PrintEmployees(ICollection<Employee> employees)
        {
            foreach (var employee in employees)
            {
                PrintEmployee(employee);
            }
        }

        public static void PrintOffer(Offer offer)
        {
            Console.WriteLine($"Id: {offer.Id} \t Name: {offer.Name}");
        }

        public static void PrintOffers(ICollection<Offer> offers)
        {
            foreach (var offer in offers)
            {
                PrintOffer(offer);
            }
        }
        public static void PrintProduct(Product product)
        {
            Console.WriteLine($"Id: {product.Id} \t Name: {product.Offer.Name} \t Amount: {product.Count}");
        }

        public static void PrintProducts(ICollection<Product> products)
        {
            foreach (var product in products)
            {
                PrintProduct(product);
            }
        }
        public static void PrintService(Service service)
        {
            Console.WriteLine($"Id: {service.Id} \t Name: {service.Offer.Name}");
        }

        public static void PrintServices(ICollection<Service> services)
        {
            foreach (var service in services)
            {
                PrintService(service);
            }
        }
        public static void PrintRent(Rent rent)
        {
            Console.WriteLine($"Id: {rent.Id} \t Name: {rent.Offer.Name}");
        }

        public static void PrintRents(ICollection<Rent> rents)
        {
            foreach (var rent in rents)
            {
                PrintRent(rent);
            }
        }
        public static void PrintCategory(Category category)
        {
            Console.WriteLine($"Id: {category.Id} \t Name: {category.Name}");
        }

        public static void PrintCategories(ICollection<Category> categories)
        {
            foreach (var category in categories)
            {
                PrintCategory(category);
            }
        }

        public static void PrintOfferPerCategory(OfferPerCategory offerPerCategory)
        {
            Console.WriteLine($"Offer: \n " +
                              $"{offerPerCategory.Offer.Id} - {offerPerCategory.Offer.Name}  \n " +
                              $"belongs to this category: \n " +
                              $"{offerPerCategory.Category.Id} - {offerPerCategory.Category.Name}");
        }
        public static void PrintOffersPerCategories(ICollection<OfferPerCategory> offersPerCategories)
        {
            foreach (var offerPerCategory in offersPerCategories)
            {
                PrintOfferPerCategory(offerPerCategory);
            }
        }

        public static void PrintOneOffBill(OneOffBill oneOffBill)
        {
            Console.WriteLine($"Id: {oneOffBill.Id} \t Name of the product: {oneOffBill.Product.Offer.Name} \t Amount of product: {oneOffBill.Amount} \t Date of Issue: {oneOffBill.Bill.DateAndTimeOfIssue} ");
        }
        public static void PrintOneOffBills(ICollection<OneOffBill> oneOffBills)
        {
            foreach (var oneOffBill in oneOffBills)
            {
                PrintOneOffBill(oneOffBill);
            }
        }

        public static void PrintServiceBill(ServiceBill serviceBill)
        {
            Console.WriteLine($"Id: {serviceBill.Id} \t Name of the service: {serviceBill.Service.Offer.Name} \t Starting date and time: {serviceBill.StartingDateAndTime} \t Ending date and time: {serviceBill.EndingDateAndTime} \t Id of employee: {serviceBill.EmployeeId} \t Date of Issue: {serviceBill.Bill.DateAndTimeOfIssue} ");
        }
        public static void PrintServiceBills(ICollection<ServiceBill> serviceBills)
        {
            foreach (var serviceBill in serviceBills)
            {
                PrintServiceBill(serviceBill);
            }
        }
        public static void PrintRentBill(RentBill rentBill)
        {
            Console.WriteLine($"Id: {rentBill.Id} \n" +
                              $"Name of the rent: {rentBill.Rent.Offer.Name} \n" +
                              $"Starting date: {rentBill.StartingDate} \n" +
                              $"Ending date: {rentBill.EndingDate} \n" +
                              $"Subscriptioner First Name: {rentBill.Subscriptioner.FirstName} \n" +
                              $"Subscriptioner Last Name: {rentBill.Subscriptioner.LastName} \n" +
                              $"Date of Issue: {rentBill.Bill.DateAndTimeOfIssue} ");
        }
        public static void PrintRentBills(ICollection<RentBill> rentBills)
        {
            foreach (var rentBill in rentBills)
            {
                PrintRentBill(rentBill);
            }
        }


    }
}
