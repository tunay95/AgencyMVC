using Agency.Business.Services.Interfaces;
using Agency.Business.ViewModels.ProductVM;
using Agency.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agency.MVC.Areas.Admin.Controllers
{
    public class ProductController
    {
        [Area("Manage")]
        public class FeautureController : Controller
        {
            private readonly IProductService _service;


            public FeautureController(IProductService service)
            {
                _service = service;
            }
            [Authorize(Roles = "Admin,Moderator")]
            public async Task<IActionResult> Index()
            {
                var products = await _service.GetAllAsync();
                return View(products);
            }
            [Authorize(Roles = "Admin,Moderator")]
            public IActionResult Create()
            {
                return View();
            }
            [Authorize(Roles = "Admin,Moderator")]
            [HttpPost]
            public async Task<IActionResult> Create(CreateProductVM createProductVM)
            {
                await _service.Create(createProductVM);
                return RedirectToAction("Index");
            }
            [Authorize(Roles = "Admin,Moderator")]
            public async Task<IActionResult> Update(int id)
            {
                Product products = await _service.GetByIdAsync(id);
                UpdateProductVM updateProductVM = new UpdateProductVM()
                {
                    Title = products.Title,
                    Description = products.Description,
                };
                return View(updateProductVM);
            }
            [Authorize(Roles = "Admin,Moderator")]
            [HttpPost]
            public async Task<IActionResult> Update(UpdateProductVM updateProductVM)
            {
                await _service.Update(updateProductVM);

                return RedirectToAction("Index");
            }
            [Authorize(Roles = "Admin,Moderator")]
            public async Task<IActionResult> Delete(int id)
            {
                Product products = await _service.GetByIdAsync(id);
                _service.Delete(products);

                return RedirectToAction("Index");
            }
        }
    }
}
