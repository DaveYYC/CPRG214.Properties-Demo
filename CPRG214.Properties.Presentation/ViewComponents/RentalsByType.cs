﻿using CPRG214.Properties.BLL;
using CPRG214.Properties.Domain;
using CPRG214.Properties.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPRG214.Properties.Presentation.ViewComponents
{
    public class RentalsByTypeViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            List<RentalProperty> properties = null;

            if(id ==0)
            {
                properties = RentalsManager.GetAll();
            }
            else 
            {
                properties = RentalsManager.GetAllByPropertyType(id);
            }

            var rentals = properties.Select(p => new RentalViewModel 
            {
                Address =p.Address,
                City = p.City,
                Id = p.Id,
                Owner = p.Owner.Name,
                PropertyType = p.PropertyType.Style,
                Province = p.Province,
                Rent = p.Rent.ToString()
            }).ToList();

            properties = RentalsManager.GetAll();

            return View(rentals);
        }
    }
}
