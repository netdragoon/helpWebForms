using System.Collections;
using System.Linq.Expressions;
using System.Text;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public static class MethodsHelpers
    {
        internal static object GetValue<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
            where TModel : class
        {
            TModel model = htmlHelper.ViewData.Model;
            if (model == null)
            {
                return default(TProperty);
            }
            Func<TModel, TProperty> func = expression.Compile();
            return func(model);
        }
        internal static MvcHtmlString Render(HtmlHelper htmlHelper, string name, string prefix = "<div>", string sufix = "</div>", object htmlAttributes = null)
        {
            RadioButtonList _list = htmlHelper.ViewData[name] as RadioButtonList;

            if (_list != null)
            {
                int _count = 0;
                StringBuilder _str = new StringBuilder();
                TagBuilder _tagLabel = null;
                TagBuilder _tagInput = null;

                foreach (var _item in _list.Items)
                {
                    Type _type = _item.GetType();
                    object _value = _type.GetProperty(_list.DataValueField).GetValue(_item);
                    object _name = _type.GetProperty(_list.DataLabelField).GetValue(_item);
                    string _id = string.Format("{0}{1}", name, _count);

                    _tagLabel = new TagBuilder("label");

                    _tagInput = new TagBuilder("input");
                    _tagInput.MergeAttribute("id", _id);
                    _tagInput.MergeAttribute("name", name);
                    _tagInput.MergeAttribute("type", "radio");
                    _tagInput.MergeAttribute("value", _value.ToString());

                    if (htmlAttributes != null)
                    {
                        _tagInput.MergeAttributes(new RouteValueDictionary(htmlAttributes));
                    }

                    if (_list.SelectedValue != null &&
                        _value.ToString().Equals(_list.SelectedValue.ToString()))
                    {
                        _tagInput.MergeAttribute("checked", "checked");
                    }

                    _tagLabel.InnerHtml = _tagInput.ToString(TagRenderMode.SelfClosing) + " " + _name;
                    _str.AppendLine(string.Format("{0}{1}{2}", prefix, _tagLabel.ToString(), sufix));

                    _count++;
                }
                if (_str.Length > 0)
                {
                    return MvcHtmlString.Create(_str.ToString());
                }
            }
            else
            {
                throw new Exception("RadioButtonList no find");
            }

            return MvcHtmlString.Empty;
        }
        internal static string ButtonRender(string label, string css = "")
        {
            return string.Format("<button type=\"submit\" class=\"{0}\">{1}</button>", css, label);
        }
        #region RadioButtonList
        public static MvcHtmlString RadioButtonList(this HtmlHelper htmlHelper, string name, string prefix = "<div>", string sufix = "</div>", object htmlAttributes = null)
        {
            return Render(htmlHelper, name, prefix, sufix, htmlAttributes);
        }
        public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable items, string dataValue, string dataName = null, object htmlAttributes = null, string prefix = "<div>", string sufix = "</div>")
            where TModel: class, new()
        {            
            ModelMetadata _metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);   
                                 
            object _value = GetValue(htmlHelper, expression);

            if (!(htmlHelper.ViewContext.ViewData.Keys.Contains(_metadata.PropertyName)))
            {
                htmlHelper.ViewContext.ViewData[_metadata.PropertyName] = 
                    new RadioButtonList(items, dataValue, dataName ?? dataValue, _value);
            }
            else
            {
                if (!(htmlHelper.ViewContext.ViewData[_metadata.PropertyName] is RadioButtonList))
                {
                    htmlHelper.ViewContext.ViewData.Remove(_metadata.PropertyName);
                    htmlHelper.ViewContext.ViewData.Add(_metadata.PropertyName, 
                        new RadioButtonList(items, dataValue, dataName ?? dataValue, _value));
                }
            }

            return Render(htmlHelper, _metadata.PropertyName, prefix, sufix, htmlAttributes);
        }
        public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, RadioButtonList config, object htmlAttributes = null, string prefix = "<div>", string sufix = "</div>")
            where TModel : class, new()
        {
            ModelMetadata _metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);                        

            if (!(htmlHelper.ViewContext.ViewData.Keys.Contains(_metadata.PropertyName)))
            {
                htmlHelper.ViewContext.ViewData[_metadata.PropertyName] = config;
            }
            else
            {
                if (!(htmlHelper.ViewContext.ViewData[_metadata.PropertyName] is RadioButtonList))
                {
                    htmlHelper.ViewContext.ViewData.Remove(_metadata.PropertyName);
                    htmlHelper.ViewContext.ViewData.Add(_metadata.PropertyName, config);
                }
            }

            return Render(htmlHelper, _metadata.PropertyName, prefix, sufix, htmlAttributes);
        }
        #endregion RadioButtonList

        #region ButtonSubmit
        public static MvcHtmlString ButtonSubmit(this HtmlHelper htmlHelper, string label)
        {
            return MvcHtmlString.Create(ButtonRender(label, ""));
        }

        public static MvcHtmlString ButtonSubmit(this HtmlHelper htmlHelper, string label, ButtonStyle style)
        {            
            return MvcHtmlString.Create(ButtonRender(label, style.ToString()));
        }

        #endregion ButtonSubmit
    }
}