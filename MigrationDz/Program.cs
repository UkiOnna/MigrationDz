﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationDz
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserModel context = new UserModel())
            {
               context.Users.ToList();
               
            }
        }
    }
}
