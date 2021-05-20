using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CoreAndFood.Controllers
{
    internal class ViewBag
    {
        public static implicit operator ViewBag(List<SelectListItem> v)
        {
            throw new NotImplementedException();
        }
    }
}