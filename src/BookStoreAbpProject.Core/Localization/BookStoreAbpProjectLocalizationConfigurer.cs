using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BookStoreAbpProject.Localization
{
    public static class BookStoreAbpProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BookStoreAbpProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BookStoreAbpProjectLocalizationConfigurer).GetAssembly(),
                        "BookStoreAbpProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
