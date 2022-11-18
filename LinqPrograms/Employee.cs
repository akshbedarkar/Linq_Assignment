using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrograms
{
    internal class Employee
    {
        #region Variables
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime NoteDate { get; set; }
        

        public DateTime DOJ { get; set; }

        public string City { get; set; }



        #endregion

        


        public static List<Employee> GetAllDetails()
        {
            List<Employee> listemployees = new List<Employee>
            {
                new Employee
                {
                    Id = 1001, 
                    FirstName = "Malcolm", 
                    LastName = "Daruwalla", 
                    Title = "Manager",
                    NoteDate=new DateTime(1984,11,16),
                    DOJ= new DateTime(2011,08,06),
                    City="Mumbai",
                },

                new Employee
                {
                    Id = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", NoteDate=new DateTime(1984,11,16),DOJ= new DateTime(2011,06,08),City= "Mumbai",

                },
                new Employee
                {
                    Id = 1003, FirstName = "Madhvi", LastName = "Oza", Title = "Consultant",NoteDate=new DateTime(1984,08,20),DOJ= new DateTime(2012,07,07),City= "Pune",
                },
                new Employee
                {
                    Id = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", NoteDate=new DateTime(1987,11,14),DOJ= new DateTime(2015,04,12),City= "Pune",
                },
                new Employee
                {
                    Id = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", NoteDate=new DateTime(1990,06,03),DOJ= new DateTime(2016,02,02),City= "Mumbai",

                },new Employee
                {
                    Id = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant",NoteDate=new DateTime(1991,03,08),DOJ= new DateTime(2016,02,02),City="Chennai",
                },
                new Employee
                {
                    Id = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", NoteDate=new DateTime(1989,12,02),DOJ= new DateTime(2015,06,01),City= "Mumbai",
                },new Employee
                {
                    Id = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate",NoteDate=new DateTime(1993,11,11),DOJ= new DateTime(2014,11,06),City= "Chennai",
                },
                new Employee
                {
                    Id = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate",NoteDate=new DateTime(1992,08,12),DOJ= new DateTime(2014,12,03),City= "Chennai",

                },new Employee
                {
                    Id = 1010, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", NoteDate=new DateTime(1991,04,12),DOJ= new DateTime(2016,01,02),City= "Chennai",
                },
               

            };
            return listemployees;

        }
}
    
}
