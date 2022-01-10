using System.Collections.Generic;

namespace Core.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public List<UserDto> users = new List<UserDto>();
        //    public List<UserDto> user = new List<UserDto>()
        //    {
        //      new UserDto
        //        {
        //            FirstName = "Ricky",
        //            LastName = "Martin",
        //            Age = 50,
        //            Email = "rickymartin@gmail.com"
        //        },
        //    new UserDto
        //    {
        //        FirstName = "Britney",
        //        LastName = "Spears",
        //        Age = 40,
        //        Email = "britneyspears@gmail.com"
        //    },
        //    new UserDto
        //    {
        //        FirstName = "Ashley",
        //        LastName = "Simpson",
        //        Age = 25,
        //        Email = "ashley@gmail.com"
        //    },
        //    new UserDto
        //    {
        //        FirstName = "Elvis",
        //        LastName = "Presley",
        //        Age = 65,
        //        Email = "presleyelvis@gmail.com"
        //    },
        //    new UserDto
        //    {
        //        FirstName = "Harrison",
        //        LastName = "Ford",
        //        Age = 79,
        //        Email = "harry_ford@gmail.com"
        //    },
        //     new UserDto
        //    {
        //        FirstName = "Anthony",
        //        LastName = "Hopkins",
        //        Age = 79,
        //        Email = "anhope@gmail.com"
        //    },
        //    new UserDto
        //    {
        //        FirstName = "Morgan",
        //        LastName = "Freeman",
        //        Age = 79,
        //        Email = "freeman@gmail.com"
        //    },
        //    new UserDto
        //    {
        //        FirstName = "Chiara",
        //        LastName = "Ferragni",
        //        Age = 79,
        //        Email = "chiaraferragni@gmail.com"
        //    }

        //};


        public static List<UserDto> GetListSweets(List<UserDto> users)
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
            var newUser3 = new UserDto
            {
                FirstName = "Ashley",
                LastName = "Simpson",
                Age = 25,
                Email = "ashley@gmail.com"
            };
            var newUse4 = new UserDto
            {
                FirstName = "Elvis",
                LastName = "Presley",
                Age = 65,
                Email = "presleyelvis@gmail.com"
            };
            var newUse5 = new UserDto
            {
                FirstName = "Harrison",
                LastName = "Ford",
                Age = 79,
                Email = "harry_ford@gmail.com"
            };
            var newUse6 = new UserDto
            {
                FirstName = "Anthony",
                LastName = "Hopkins",
                Age = 79,
                Email = "anhope@gmail.com"
            };
            var newUse7 = new UserDto
            {
                FirstName = "Morgan",
                LastName = "Freeman",
                Age = 79,
                Email = "freeman@gmail.com"
            };
            var newUse8 = new UserDto
            {
                FirstName = "Chiara",
                LastName = "Ferragni",
                Age = 79,
                Email = "chiaraferragni@gmail.com"
            };
            return users;
        }



    }


}
