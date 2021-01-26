using Arhitecture.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Arhitecture.Data.Seed
{
    public class DataBaseSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            
            builder.Entity<Offer>()
               .HasData(new List<Offer>
               {
                   new Offer
                   {
                       Id = 1,
                       Name = "Artikal A",
                       Price = 10m
                   },
                   new Offer
                   {
                       Id = 2,
                       Name = "Artikal B",
                       Price = 15m
                   },
                   new Offer
                   {
                       Id = 3,
                       Name = "Artikal C",
                       Price = 13m
                   },
                   new Offer
                   {
                       Id = 4,
                       Name = "Artikal D",
                       Price = 12.79m
                   },
                   new Offer
                   {
                       Id = 5,
                       Name = "Artikal E",
                       Price = 17.99m
                   },
                   new Offer
                   {
                       Id = 6,
                       Name = "Artikal F",
                       Price = 18m
                   },
                   new Offer
                   {
                       Id = 7,
                       Name = "Artikal G",
                       Price = 7.8m
                   },
                    new Offer
                   {
                       Id = 8,
                       Name = "Service A",
                       Price = 50m,
                   },
                   new Offer
                   {
                       Id = 9,
                       Name = "Service B",
                       Price = 30m,
                   },
                   new Offer
                   {
                       Id = 10,
                       Name = "Service C",
                       Price = 60m,
                   },
                   new Offer
                   {
                       Id = 11,
                       Name = "Service D",
                       Price = 39m,
                   },
                   new Offer
                   {
                       Id = 12,
                       Name = "Service E",
                       Price = 20m,
                   },
                   new Offer
                   {
                       Id = 13,
                       Name = "Service F",
                       Price = 59m,
                   },
                   new Offer
                   {
                       Id = 14,
                       Name = "Service G",
                       Price = 40m,
                   },
                   new Offer
                   {
                       Id = 15,
                       Name = "Rent A",
                       Price = 35m,
                   },
                   new Offer
                   {
                       Id = 16,
                       Name = "Rent B",
                       Price = 37.5m,
                   },
                   new Offer
                   {
                       Id = 17,
                       Name = "Rent C",
                       Price = 19.5m,
                   },
                   new Offer
                   {
                       Id = 18,
                       Name = "Rent D",
                       Price = 50m,
                   },
                   new Offer
                   {
                       Id = 19,
                       Name = "Rent E",
                       Price = 25.5m,
                   },
                   new Offer
                   {
                       Id = 20,
                       Name = "Rent F",
                       Price = 12m,
                   },
                   new Offer
                   {
                       Id = 21,
                       Name = "Rent G",
                       Price = 80m,
                   }
               }) ;
            builder.Entity<Product>()
               .HasData(new List<Product>
               {
                   new Product
                   {
                       Id = 1,
                       Count = 2,
                       OfferId = 1
                   },
                   new Product
                   {
                       Id = 2,
                       Count = 9,
                       OfferId = 2
                   },
                   new Product
                   {
                       Id = 3,
                       Count = 59,
                       OfferId = 3
                   },
                   new Product
                   {
                       Id = 4,
                       Count = 90,
                       OfferId = 4
                   },
                   new Product
                   {
                       Id = 5,
                       Count = 14,
                       OfferId = 5
                   },
                   new Product
                   {
                       Id = 6,
                       Count = 60,
                       OfferId = 6
                   },
                   new Product
                   {
                       Id = 7,
                       Count = 9,
                       OfferId = 7
                   }
               }) ;
            builder.Entity<Service>()
               .HasData(new List<Service>
               {
                   new Service
                   {
                       Id = 1,
                       OfferId = 8
                   },
                   new Service
                   {
                       Id = 2,
                       OfferId = 9
                   },
                   new Service
                   {
                       Id = 3,
                       OfferId = 10
                   },
                   new Service
                   {
                       Id = 4,
                       OfferId = 11
                   },
                   new Service
                   {
                       Id = 5,
                       OfferId = 12
                   },
                   new Service
                   {
                       Id = 6,
                       OfferId = 13
                   },
                   new Service
                   {
                       Id = 7,
                       OfferId = 14
                   }
               });
            builder.Entity<Rent>()
               .HasData(new List<Rent>
               {
                   new Rent
                   {
                       Id = 1,
                       OfferId = 15
                   },
                   new Rent
                   {
                       Id = 2,
                       OfferId = 16
                   },
                   new Rent
                   {
                       Id = 3,
                       OfferId = 17
                   },
                   new Rent
                   {
                       Id = 4,
                       OfferId = 18
                   },
                   new Rent
                   {
                       Id = 5,
                       OfferId = 19
                   },
                   new Rent
                   {
                       Id = 6,
                       OfferId = 20
                   },
                   new Rent
                   {
                       Id = 7,
                       OfferId = 21
                   }
               });
            builder.Entity<Category>()
               .HasData(new List<Category>
               {
                   new Category
                   {
                       Id = 1,
                       Name = "Category A",
                   },
                   new Category
                   {
                       Id = 2,
                       Name = "Category B",
                   },
                   new Category
                   {
                       Id = 3,
                       Name = "Category C",
                   },
                   new Category
                   {
                       Id = 4,
                       Name = "Category D",
                   },
                   new Category
                   {
                       Id = 5,
                       Name = "Category E",
                   },
                   new Category
                   {
                       Id = 6,
                       Name = "Category F",
                   },
                   new Category
                   {
                       Id = 7,
                       Name = "Category G",
                   }
               });
            builder.Entity<OfferPerCategory>()
               .HasData(new List<OfferPerCategory>
               {
                   new OfferPerCategory
                   {
                       Id = 1,
                       CategoryId = 1,
                       OfferId = 1
                   },
                   new OfferPerCategory
                   {
                       Id = 2,
                       CategoryId = 1,
                       OfferId = 8
                   },
                   new OfferPerCategory
                   {
                       Id = 3,
                       CategoryId = 1,
                       OfferId = 15
                   },
                   new OfferPerCategory
                   {
                       Id = 4,
                       CategoryId = 2,
                       OfferId = 2
                   },
                   new OfferPerCategory
                   {
                       Id = 5,
                       CategoryId = 2,
                       OfferId = 9
                   },
                   new OfferPerCategory
                   {
                       Id = 6,
                       CategoryId = 2,
                       OfferId = 16
                   },
                   new OfferPerCategory
                   {
                       Id = 7,
                       CategoryId = 3,
                       OfferId = 3
                   },
                   new OfferPerCategory
                   {
                       Id = 8,
                       CategoryId = 3,
                       OfferId = 10
                   },
                   new OfferPerCategory
                   {
                       Id = 9,
                       CategoryId = 3,
                       OfferId = 17
                   },
                   new OfferPerCategory
                   {
                       Id = 10,
                       CategoryId = 4,
                       OfferId = 4
                   },
                   new OfferPerCategory
                   {
                       Id = 11,
                       CategoryId = 4,
                       OfferId = 11
                   },
                   new OfferPerCategory
                   {
                       Id = 12,
                       CategoryId = 4,
                       OfferId = 18
                   },
                   new OfferPerCategory
                   {
                       Id = 13,
                       CategoryId = 5,
                       OfferId = 5
                   },
                   new OfferPerCategory
                   {
                       Id = 14,
                       CategoryId = 5,
                       OfferId = 12
                   },
                   new OfferPerCategory
                   {
                       Id = 15,
                       CategoryId = 5,
                       OfferId = 19
                   },
                   new OfferPerCategory
                   {
                       Id = 16,
                       CategoryId = 6,
                       OfferId = 6
                   },
                   new OfferPerCategory
                   {
                       Id = 17,
                       CategoryId = 6,
                       OfferId = 13
                   },
                   new OfferPerCategory
                   {
                       Id = 18,
                       CategoryId = 6,
                       OfferId = 20
                   },
                   new OfferPerCategory
                   {
                       Id = 19,
                       CategoryId = 7,
                       OfferId = 7
                   },
                   new OfferPerCategory
                   {
                       Id = 20,
                       CategoryId = 7,
                       OfferId = 14
                   },
                   new OfferPerCategory
                   {
                       Id = 21,
                       CategoryId = 7,
                       OfferId = 21
                   }
               });
            builder.Entity<Employee>()
          .HasData(new List<Employee>
          {
                   new Employee
                   {
                       Id = 1,
                       FirstName = "Mate",
                       LastName = "Matić",
                       BeginingOfShift = new DateTime(1, 1, 1, 8, 0, 1),
                       EndingOfShift = new DateTime(1, 1, 1, 16, 0, 0)
                   },
                   new Employee
                   {
                       Id = 2,
                       FirstName = "Ante",
                       LastName = "Antić",
                       BeginingOfShift = new DateTime(1, 1, 1, 16, 0, 1),
                       EndingOfShift = new DateTime(1, 1, 1, 23, 59, 59)
                   },
                   new Employee
                   {
                       Id = 3,
                       FirstName = "Ana",
                       LastName = "Anić",
                       BeginingOfShift = new DateTime(1, 1, 1, 23, 59, 59),
                       EndingOfShift = new DateTime(1, 1, 1, 8 ,0, 0)
                   }
            });
            builder.Entity<Bill>()
          .HasData(new List<Bill>
          {
              new Bill
              {
                  Id = 1,
                  DateAndTimeOfIssue = new DateTime(2020, 12, 15)
              },
              new Bill
              {
                  Id = 2,
                  DateAndTimeOfIssue = new DateTime(2020, 12, 15)
              },
              new Bill
              {
                  Id = 3,
                  DateAndTimeOfIssue = new DateTime(2020, 11, 16)
              },
              new Bill
              {
                  Id = 4,
                  DateAndTimeOfIssue = new DateTime(2020, 11, 17)
              },
              new Bill
              {
                  Id = 5,
                  DateAndTimeOfIssue = new DateTime(2020, 11, 18)
              },
              new Bill
              {
                  Id = 6,
                  DateAndTimeOfIssue = new DateTime(2020, 12, 14)
              }
          });

            builder.Entity<OneOffBill>()
          .HasData(new List<OneOffBill>
          {
                   new OneOffBill
                   {
                       Id = 1,
                       Amount = 4,
                       ProductId = 1,
                       BillId = 1
                   },
                   new OneOffBill
                   {
                       Id = 2,
                       Amount = 6,
                       ProductId = 2,
                       BillId = 1
                   },
                   new OneOffBill
                   {
                       Id = 3,
                       Amount = 1,
                       ProductId = 3,
                       BillId = 1
                   },
                   new OneOffBill
                   {
                       Id = 4,
                       Amount = 7,
                       ProductId = 4,
                       BillId = 1
                   },
                   new OneOffBill
                   {
                       Id = 5,
                       Amount = 12,
                       ProductId = 5,
                       BillId = 1
                   },
                   new OneOffBill
                   {
                       Id = 6,
                       Amount = 3,
                       ProductId = 2,
                       BillId = 2
                   },
                   new OneOffBill
                   {
                       Id = 7,
                       Amount = 16,
                       ProductId = 3,
                       BillId = 2
                   }
            });
            builder.Entity<ServiceBill>()
          .HasData(new List<ServiceBill>
          {
              new ServiceBill
              {
                  Id = 1,
                  StartingTime = new DateTime(1, 1, 1, 8, 0, 0),
                  EndingTime = new DateTime(1, 1, 1, 12, 0, 0),
                  EmployeeId = 1,
                  BillId = 3,
                  ServiceId = 1
              },
              new ServiceBill
              {
                  Id = 2,
                  StartingTime = new DateTime(1, 1, 1, 17, 0, 0),
                  EndingTime = new DateTime(1, 1, 1, 22, 0, 0),
                  EmployeeId = 2,
                  BillId = 4,
                  ServiceId = 1
              },
              new ServiceBill
              {
                  Id = 3,
                  StartingTime = new DateTime(1, 1, 1, 8, 0, 0),
                  EndingTime = new DateTime(1, 1, 1, 12, 0, 0),
                  EmployeeId = 2,
                  BillId = 5,
                  ServiceId = 2
              },
              new ServiceBill
              {
                  Id = 4,
                  StartingTime = new DateTime(1, 1, 1, 1, 0, 0),
                  EndingTime = new DateTime(1, 1, 1, 7, 0, 0),
                  EmployeeId = 2,
                  BillId = 6,
                  ServiceId = 4
              }
          });
            builder.Entity<RentBill>()
          .HasData(new List<RentBill>
          {
              new RentBill
              {
                  Id = 1,
                  isRentActive = false,
                  StartingDate = new DateTime(2020, 11, 4),
                  EndingDate = new DateTime(2020, 11,  5),
                  FirstName = "Michelle",
                  LastName = "Šarić",
                  CreditCardNumber = "1234123412341234",
                  RentId = 1
              },
              new RentBill
              {
                  Id = 2,
                  isRentActive = false,
                  StartingDate = new DateTime(2020, 12, 16),
                  EndingDate = new DateTime(2020, 12,  17),
                  FirstName = "Bože",
                  LastName = "Topić",
                  CreditCardNumber = "1234123412345678",
                  RentId = 2
              },
              new RentBill
              {
                  Id = 3,
                  isRentActive = false,
                  StartingDate = new DateTime(2020, 11, 17),
                  EndingDate = new DateTime(2020, 11,  19),
                  FirstName = "Lucia",
                  LastName = "Vukorepa",
                  CreditCardNumber = "1234123412341235",
                  RentId = 3
              },
              new RentBill
              {
                  Id = 4,
                  isRentActive = false,
                  StartingDate = new DateTime(2020, 11, 17),
                  EndingDate = new DateTime(2020, 11,  19),
                  FirstName = "Lucia",
                  LastName = "Vukorepa",
                  CreditCardNumber = "1234123412341235",
                  RentId = 4
              }
          }) ;
        }
    }
}
