using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

namespace ServiceStackToolkit.Automation
{
    public static class TextFormatting
    {
        /// <summary>
        /// Returns the singluar form of the specified word
        /// </summary>
        public static string Singluarize(string word)
        {
            var service = PluralizationService.CreateService(CultureInfo.CurrentCulture);
            return service.Singularize(word);
        }

        /// <summary>
        /// Returns the plural form of the specified word
        /// </summary>
        public static string Pluralize(string word)
        {
            var service = PluralizationService.CreateService(CultureInfo.CurrentCulture);
            return service.Pluralize(word);
        }

        /// <summary>
        /// Returns the word in title case.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string TitleCase(string word)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower(CultureInfo.CurrentCulture));
        }
    }
}
