using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;


namespace Freelancer.extensions
{
    public static class PublishedContentExtensions
    {


        // Finds the Home Page from the current content item.
        public static HomePage? GetHomePage(
            this IPublishedContent publishedContent)
        {
            return publishedContent.AncestorOrSelf<HomePage>();
        }


        // Finds Site Settings under the Home Page.
        public static SiteSettings? GetSiteSettings(
            this IPublishedContent publishedContent)
        {
            var homePage = publishedContent.GetHomePage();

            if (homePage == null)
            {
                return null;
            }

            return homePage.FirstChild<SiteSettings>();
        }



    }
}






