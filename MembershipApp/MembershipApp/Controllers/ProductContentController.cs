﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using MembershipApp.Extensions;

namespace MembershipApp.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;

            var sections = await SectionExtensions.GetProductSectionsAsync(id, userId);

            return View(sections);
        }
    }
}