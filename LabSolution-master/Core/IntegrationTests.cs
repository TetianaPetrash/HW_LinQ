using Core.Helper;
using Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Tests
    {
        // LinQ
        // разница между возвр значением where и select
        // firstordefault разница с first
        // all
        // any
        // take
        // where 
        // select - разобраться детальней!!!!!!!!!!!!!
        // firstordefault
        // first
        // single
        // singleordefault
        // join (создать таблицу и тогда применить)
        // GroupJoin
        public List<UserDto> user2 = new List<UserDto>() // почему лист нужно в тест прописывать,если в классе,то не запускается тест
                {
                  new UserDto
                    {
                        Id = 8,
                        FirstName = "Anya",
                        LastName = "Taylor",
                        Age = 25,
                        
                    },
                new UserDto
                {
                    Id = 7,
                    FirstName = "Cortney",
                    LastName = "Kardashian",
                    Age = 32,
                    
                },
                new UserDto
                {
                    Id = 6,
                    FirstName = "Ashley",
                    LastName = "Ghramm",
                    Age = 28,
                    
                },
                new UserDto
                {
                    Id = 5,
                    FirstName = "Elton",
                    LastName = "Jhon",
                    Age = 73,
                    
                },
                new UserDto
                {
                    Id = 4,
                    FirstName = "Shay",
                    LastName = "Mitchell",
                    Age = 31,
                    
                },
                 new UserDto
                {
                     Id = 3,
                    FirstName = "Tom",
                    LastName = "Cruz",
                    Age = 55,
                 
                },
                new UserDto
                {
                    Id = 2,
                    FirstName = "Eva",
                    LastName = "Longoria",
                    Age = 63,
                   
                },
                new UserDto
                {
                    Id = 1,
                    FirstName = "Jenifer",
                    LastName = "Lopez",
                    Age = 54,
                   
                }

            };

        public List<UserDto> user = new List<UserDto>() // почему лист нужно в тест прописывать,если в классе,то не запускается тест
                {
                  new UserDto
                    {
                      Id = 1,
                        FirstName = "Ricky",
                        LastName = "Martin",
                        Age = 50,
                        Email = "rickymartin@gmail.com"
                    },
                new UserDto
                {
                    Id = 2,
                    FirstName = "Britney",
                    LastName = "Spears",
                    Age = 40,
                    Email = "britneyspears@gmail.com"
                },
                new UserDto
                {
                    Id = 3,
                    FirstName = "Ashley",
                    LastName = "Simpson",
                    Age = 25,
                    Email = "ashley@gmail.com"
                },
                new UserDto
                {
                    Id = 4,
                    FirstName = "Elvis",
                    LastName = "Presley",
                    Age = 65,
                    Email = "presleyelvis@gmail.com"
                },
                new UserDto
                {
                    Id = 5,
                    FirstName = "Harrison",
                    LastName = "Ford",
                    Age = 79,
                    Email = "harry_ford@gmail.com"
                },
                 new UserDto
                {
                     Id = 6,
                    FirstName = "Anthony",
                    LastName = "Hopkins",
                    Age = 82,
                    Email = "anhope@gmail.com"
                },
                new UserDto
                {
                    Id = 7,
                    FirstName = "Morgan",
                    LastName = "Freeman",
                    Age = 30,
                    Email = "freeman@gmail.com"
                },
                new UserDto
                {
                    Id = 8,
                    FirstName = "Chiara",
                    LastName = "Ferragni",
                    Age = 38,
                    Email = "chiaraferragni@gmail.com"
                }

            };

        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test1()
        {
            //Arrange => Create object for class User
            var newUser = new UserDto
            {
                FirstName = "Ricky",
                LastName = "Martin",
                Age = 50,
                Email = "rickymartin@gmail.com"
            };

            var newUser2 = new UserDto
            {
                FirstName = "Britney",
                LastName = "Spears",
                Age = 40,
                Email = "britneyspears@gmail.com"
            };

            //Act => Get path and set object to excel file
            var pathToExcelFile = ExcelHelper.GetFilePath("ExcelFile.xlsx");
            ExcelHelper.SetDataToExcelFile(pathToExcelFile, newUser);
            ExcelHelper.SetDataToExcelFile(pathToExcelFile, newUser2, 3, false);

            var data = ExcelHelper.GetTableFromExcelFile(pathToExcelFile);
        }



        [Theory]
        [TestCase("Britney", false)]

        public void Test3(string firstname, bool expectedResult)
        {
            var newUser = new UserDto
            {
                FirstName = "Ricky",
                LastName = "Martin",
                Age = 50,
                Email = "rickymartin@gmail.com"
            };

            var newUser2 = new UserDto
            {
                FirstName = "Britney",
                LastName = "Spears",
                Age = 40,
                Email = "britneyspears@gmail.com"
            };
            var actualResult = newUser2.FirstName.Contains(firstname);
            Assert.IsTrue(actualResult);

        }


        [Test]
        public void Test2()
        {

            bool actualResult = true;
            foreach (var item in user)
            {
                if (string.IsNullOrEmpty(item.Email)) // проверяю не пустое ли поле Email 
                {
                    actualResult = false;
                }
            }
            Assert.IsTrue(actualResult);

        }

        [Test]
        public void Test4()
        {
            var result = user.Where(x => x.Age == 30);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


        [Test]
        public void Test5()
        {
            var result = user.Take(10).Where(x => x.Age == 30); // в первых 10 элемент найти где возраст 30
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


        [Test]
        public void Test6()
        {
            var result = user.Where(x => x.Age == 30).Take(1); // вывести одно значение возраста 30
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void Test7()
        { // не уверена,что правильно??
            bool result = user.Any(x => x.FirstName.Equals("Chiara")); // Any вернет true если хотя бы одно из значений подойдет условию
            Assert.IsTrue(result);
        }

        [Test]
        public void Test8()
        {  // почему false
            bool result = user.All(x => x.Email.Length > 2); // All вернет true если все значения подходят условию
            Assert.IsTrue(result);
        }

        [Test]
        public void Test9()
        {  //  ???
            var result = user.Select(x => x.FirstName.Equals("Chiara"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void Test10()
        {

            foreach (var item in user)  //First возвращает первое значение, если null, то падает
            {
                var result = user.First();
                Console.WriteLine(result);
            }
        }

        [Test]
        public void Test11()
        {

            foreach (var item in user)  //FirstOrDefault возвращает значение,  при null не падает
            {
                var result = user.Take(0).FirstOrDefault();
                Console.WriteLine(result == null ? "\n\tНичего не найдено :(" : result); ;

            }
        }

        [Test]
        public void Test12()
        {

            foreach (var item in user)
            {
                var result = user.Single(x => x.Age == 30); //Single возвращает значение, если null, то упадет
                Console.WriteLine(result);
            }

        }

        [Test]
        public void Test13()
        {

            foreach (var item in user)
            {
                var result = user.SingleOrDefault(x => x.Age == 100); //SingleOrDefault возвращает значение, при null не упадет
                Console.WriteLine(result);
            }

        }


        [Test]
        public void Test14()
        {
            var result = user.Join(user2, e => e.Id, o => o.Id, (e, o) => new
            {
                Id = e.Id,
                name = string.Format("{0} {1}", o.FirstName, e.LastName)               
            }) ;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void Test15()
        {
            var result = user.GroupJoin(user2, e => e.Id, o => o.Id, (e, os) => new
            {
                Id = e.Id,
                name = string.Format("{0} {1}", os.FirstOrDefault().FirstName, e.LastName)
            });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

       

    }
}