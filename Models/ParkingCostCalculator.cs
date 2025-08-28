using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoCodProprio.Models
{
    public static class ParkingCostCalculator
    {
        public static decimal TotalCost(decimal InicialPrice, decimal HourPrice, int horas)
        {
            decimal FinalPrice = InicialPrice + (HourPrice * horas);
            return FinalPrice;
        }
    }
}