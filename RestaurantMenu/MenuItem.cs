using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        public enum Courses { Appetaizer, MainCourse, Dessert };

        private double price;
        private string description;
        private string course;
        
        public bool NewMenuItem { get; set; }

        public Courses Course {
            set {
                switch (value) {
                    case Courses.Appetaizer:
                        course = "Appetaizer";
                        break;
                    case Courses.MainCourse:
                        course = "Main Course";
                        break;
                    case Courses.Dessert:
                        course = "Dessert";
                        break;
                }
            }
        }

        public string get() {
            return course;
        } 

        public string Description {
            set { 
                if (value.Equals("") ){
                    Console.WriteLine("Description can be empty");
                    return;
                }

                description = value;
            } 
            get { return description; }
        }

        public double Price { 
            get { 
                return price; 
            }
            set {
                if (value < 0) {
                    Console.WriteLine("Price can't be less or equal 0");
                    return;
                }
                price = value;
            } 
        }

        public MenuItem(double price, string description, Courses course, bool newMenuItem) {
            Course = course;
            Price = price;
            Description = description;
            NewMenuItem = newMenuItem;
        }

    }
}
