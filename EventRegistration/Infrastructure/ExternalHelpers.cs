using System.Web.Mvc;
namespace EventRegistration.Infrastructure
{
    public static class ExternalHelpers
    {
        public static string RegistrationCount(this HtmlHelper html, int i)
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
                    result = string.Format("There are {0} registrations", i);
                    break;
            }
            return result;
        }
    }
}