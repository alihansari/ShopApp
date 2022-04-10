using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (RouteData.Values["category"] != null)
            {
                ViewBag.SelectedCategory = RouteData?.Values["category"];
            }

            return View(await _categoryService.GetAll());
        }
    }
}
