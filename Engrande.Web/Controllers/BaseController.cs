using Engrande.Contract;
using Engrande.Entities;
using Engrande.Web.Models;
using Engrande.Web.Models.JqueryDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Engrande.Web.Controllers
{
    public class BaseController : Controller
    {
        public WebResult<T> CreateWebResult<T>(string status, IEnumerable<T> data, string message, int totalCount)
        {
            return new WebResult<T>()
            {
                Status = status,
                Data = data,
                Message = message,
                TotalCount = totalCount
            };
        }

        public void LogException(IUnitOfWork uow, string message)
        {
            uow.ErrorLogRepo.CreateEntity(
                new ErrorLog()
                {
                    DateAndTime = DateTime.Now,
                    Message = message
                });

            uow.SaveChanges();
        }

    }
}