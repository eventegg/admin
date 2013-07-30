using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace EventEgg.Admin.Library
{
    public class EmailValidationAttribute : RegularExpressionAttribute
    {
        public EmailValidationAttribute()
            : base(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$")
        {

        }

        public static string RadioButtonList<T>(this IViewModelContainer<T> container, Expression<Func<T, object>> expression, IEnumerable<string> items) where T : class
        {
            var func = expression.Compile();
            var result = func(container.ViewModel);
            var selectList = new SelectList(items, result);
            return container.RadioButtonList(expression, selectList);
        }

        public static string RadioButtonList<T>(this IViewModelContainer<T> container, Expression<Func<T, object>> expression, IEnumerable<SelectListItem> items) where T : class
        {
            TagBuilder tableTag = new TagBuilder("table");
            tableTag.AddCssClass("radio-main");

            var trTag = new TagBuilder("tr");
            foreach (var item in items)
            {
                var tdTag = new TagBuilder("td");
                var radioTag = container.RadioButton(expression).Value(item.Value ?? item.Text).Checked(item.Selected).LabelAfter(item.Text);
                tdTag.InnerHtml = radioTag.ToString();

                trTag.InnerHtml += tdTag.ToString();
            }
            tableTag.InnerHtml = trTag.ToString();

            return tableTag.ToString();
        }
    }
}