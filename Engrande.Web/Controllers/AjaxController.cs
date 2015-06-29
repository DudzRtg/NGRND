using Engrande.Contract;
using Engrande.Services.Interfaces;
using Engrande.Web.Models;
using Engrande.Web.Models.JqueryDT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Engrande.Web.Controllers
{
    public class AjaxController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICategoryService categoryService;

        public AjaxController(IUnitOfWork uow, ICategoryService category)
        {
            unitOfWork = uow;
            categoryService = category;
        }

        [HttpPost]
        public ActionResult GetCategoriesForDT()
        {
            var r = Request;
            WebResult<CategoryViewModel> webResult;

            var temp = JsonConvert.DeserializeObject<DTRequest>(HttpUtility.UrlDecode(Request.Form.ToString()));
            
            try
            {
                var data = GetAllCategories();
                webResult = CreateWebResult<CategoryViewModel>("success", data, null, data.Count);
            }
            catch(Exception ex)
            {
                LogException(unitOfWork, ex.Message);
                webResult = CreateWebResult<CategoryViewModel>("error", null, ex.Message, 0);
            }

            return Json(webResult, JsonRequestBehavior.AllowGet);
        }

        private List<CategoryViewModel> GetAllCategories()
        {
            var result = from c in categoryService.GetCategoriesList(null, null)
                         select new CategoryViewModel()
                         {
                             Key = c.Id,
                             Name = c.Name,
                             Description = c.Description,
                             ParentName = c.ParentName,
                             Status = c.StatusName,
                             ModifiedDate = c.ModifiedDate.ToString(),
                             ModifiedBy = c.ModifiedBy
                         };

            return result.ToList();
        }
    }
}