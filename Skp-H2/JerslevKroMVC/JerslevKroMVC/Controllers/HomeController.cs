using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace JerslevKroMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Gets the current language and makes a new object of it

                HttpCookie LangCookie = Request.Cookies["LangCookie"];
                if (LangCookie != null && LangCookie.Value != null)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(LangCookie.Value);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(LangCookie.Value);
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("da");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("da");
                }

            return View();
        }

        public ActionResult About()
        {
            //Gets the current language and makes a new object of it

                HttpCookie LangCookie = Request.Cookies["LangCookie"];
                if (LangCookie != null && LangCookie.Value != null)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(LangCookie.Value);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(LangCookie.Value);
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("da");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("da");
                }

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //Gets the current language and makes a new object of it

                HttpCookie LangCookie = Request.Cookies["LangCookie"];
                if (LangCookie != null && LangCookie.Value != null)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(LangCookie.Value);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(LangCookie.Value);
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("da");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("da");
                }

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SelectLanguage(string language)
        {
            //Makes a cookie and saves the language

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language.ToLower());

            HttpCookie LangCookie = new HttpCookie("LangCookie");
            LangCookie.Value = language;
            Response.Cookies.Add(LangCookie);

            return RedirectToAction("Index", "Home");
        }
    }
}