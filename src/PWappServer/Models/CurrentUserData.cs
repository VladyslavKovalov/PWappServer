﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWappServer.Models
{
    public class CurrentUserData
    {
        public int UserPw { get; set; }
        public  List<Transaction> UserTransactions{ get; set; }
    }
}
