﻿using System;
using System.Text;


namespace Enumeração_Composição.Entities.Enums
{
    enum OrderStatus : int
    {
                    PendingPayment = 0,
                    Processing = 1,
                    Shipped = 2,
                    Delivered = 3
        }
}
