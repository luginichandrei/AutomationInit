using SeleniumExtras.PageObjects;

namespace NUnitTest
{
    public static class Pages
    {
        private static T getPages<T>() where T : new()
        {
            var page = new T();

            PageFactory.InitElements(Browsers.getDriver, page);
            return page;
        }

        public static ContactUs contactUs
        {
            get { return getPages<ContactUs>(); }
        }
    }
}