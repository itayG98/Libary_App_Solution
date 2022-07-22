﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryModel
{
    public class StudentCostumer : Costumer
    {
        public StudentCostumer(string id, string firstName, string lastName, string city, string street, int houseNumber = -1, string password = DEFAULT_PASSWORD) : base(id, firstName, lastName, city, street, houseNumber, password)
        {
            DiscountPerCent = 25;
        }
        public override string ToString()
        {
            return "Student Costumer "+base.ToString();
        }
    }
}
