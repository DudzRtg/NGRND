using Engrande.Contract;
using Engrande.Entities;
using Engrande.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Engrande.Web.Controllers
{
    public class BaseController : Controller
    {
        public WebResult<T> CreateWebResult<T>(string status, T singleData, IEnumerable<T> listData, string message)
        {
            return new WebResult<T>()
            {
                Status = status,
                SingleData = singleData,
                ListData = listData,
                Message = message
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