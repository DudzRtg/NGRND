using Engrande.Contract;
using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Engrande.Web.Models;
using Engrande.Services.Interfaces;

namespace Engrande.Web.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;
        private readonly IUnitOfWork unitOfWork;

        public CategoryController(IUnitOfWork uow, ICategoryService category)
        {
            unitOfWork = uow;
            categoryService = category;
        }
        

        // GET: Category
        public ActionResult Index()
        {
            //point to ViewCategories();
            return RedirectToAction("ViewCategories");
        }

        [HttpGet]
        public ActionResult ViewCategories()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View(new Category());
        }

        //[HttpPost]
        //public ActionResult AddCategory(Category cat)
        //{
        //    WebResult<int> result;
        //    try
        //    {
        //        cat.ModifiedDate = DateTime.Now;
        //        _uow.CategoryRepo.CreateEntity(cat);
        //        _uow.SaveChanges();

        //        result = CreateWebResult<int>("success", cat.Id, null, string.Format("Category {0} was successfully added.", cat.Name));
        //    }
        //    catch (ArgumentException arg)
        //    {
        //        result = CreateWebResult<int>("error", 0, null, arg.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogException(_uow, ex.ToString());

        //        result = CreateWebResult<int>("error", 0, null, string.Format("Failed to create {0} category.", cat.Name));
        //    }

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult RemoveCategory(int id)
        //{
        //    WebResult<int> result;
        //    try
        //    {
        //        if (_uow.CategoryRepo.RetrieveEntity(id) == null)
        //            throw new ArgumentException("Could not find item.");

        //        _uow.CategoryRepo.DeleteEntity(id);
        //        var resultId = _uow.SaveChanges();

        //        result = CreateWebResult<int>("success", resultId, null, "Category was successfully deleted.");
        //    }
        //    catch (ArgumentException arg)
        //    {
        //        result = CreateWebResult<int>("error", 0, null, arg.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogException(_uow, ex.ToString());

        //        result = CreateWebResult<int>("error", 0, null, "Failed to delete category.");
        //    }

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult EditCategory(Category cat)
        //{
        //    WebResult<int> result;
        //    try
        //    {
        //        if (_uow.CategoryRepo.RetrieveEntity(cat.Id) == null)
        //            throw new ArgumentException("Could not find item.");

        //        Category origItem = _uow.CategoryRepo.RetrieveEntity(cat.Id);
        //        origItem.Name = cat.Name;
        //        origItem.Description = cat.Description;
        //        origItem.ParentId = cat.ParentId;
        //        origItem.ModifiedDate = DateTime.Now;
        //        origItem.StatusId = cat.StatusId;

        //        _uow.CategoryRepo.UpdateEntity(origItem);
        //        var resultId = _uow.SaveChanges();

        //        result = CreateWebResult<int>("success", resultId, null, string.Format("Category {0} was successfully updated.", cat.Name));
        //    }
        //    catch (ArgumentException arg)
        //    {
        //        result = CreateWebResult<int>("error", 0, null, arg.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogException(_uow, ex.ToString());

        //        result = CreateWebResult<int>("error", 0, null, "Failed to update category.");
        //    }

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult ViewCategory(int id)
        //{
        //    try
        //    {
        //        var item = _uow.CategoryRepo.RetrieveEntity(id);
        //        if (item == null)
        //            throw new ArgumentException("Could not find item.");

        //        WebResult<Category> result = CreateWebResult<Category>("success", item, null, "Category found.");
        //        return Json(result, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (ArgumentException arg)
        //    {
        //        WebResult<int> result = CreateWebResult<int>("error", 0, null, arg.Message);
        //        return Json(result, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogException(_uow, ex.ToString());

        //        WebResult<int> result = CreateWebResult<int>("error", 0, null, "Failed to retrieve category.");
        //        return Json(result, JsonRequestBehavior.AllowGet);
        //    }
        //}
    }
}