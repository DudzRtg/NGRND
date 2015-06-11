using Engrande.Contract;
using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Engrande.Web
{
    public static class ViewHelper
    {
        public static MvcHtmlString DropDownForCategory<TProperty>(this HtmlHelper helper, Expression<Func<Category, TProperty>> property)
        {
            TagBuilder builder = new TagBuilder("select");


            return MvcHtmlString.Create(builder.ToString());

        }
    }
}