﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IRentBusiness
    {
        int GetRentCount();
        decimal CalculateRevenue();
        int InsertRent(Rent rent);
        List<Rent> GetAllRents();
        List<Rent> GetUserRents(int UserID);

        int DeleteRentByApartment(int apt_id);
        int RemoveRent(int RentId);
        int DeleteRentByUserOrLandlord(int user_id);
    }
}
