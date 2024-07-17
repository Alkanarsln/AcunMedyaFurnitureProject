﻿using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.UILayout
{
    public class _UILayoutFooterComponent : ViewComponent
    {
        private readonly FurniterContext _context;

        public _UILayoutFooterComponent(FurniterContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
