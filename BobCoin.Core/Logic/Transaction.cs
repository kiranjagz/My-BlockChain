﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BobCoin.Core.Logic
{
    [Serializable]
    public class Transaction
    {
        public string Sender { set; get; }
        public string Recipient { set; get; }
        public double Amount { set; get; }
        public double Fee { set; get; }
    }
}
