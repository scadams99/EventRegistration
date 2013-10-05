using System.Web.Mvc;
namespace EventRegistration.Infrastructure
{
    public static class ExternalHelpers
    {
        public static MvcHtmlString RegistrationCount(this HtmlHelper html, int i)
        {
            string result;
            switch (i)
            {
                case 0:
                    result = "There are no registrations";
                    break;
                case 1:
                    result = "There is one registration";
                    break;
                default:
                    result = string.Format("There are {0} registrations<script>alert('Hello')</script>", i);
                    break;
            }
            return new MvcHtmlString(string.Format("<h2>{0}</h2>", html.Encode(result)));
        }
    }
}