using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo.Localization
{
    public static class ANZ104AngularDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    ANZ104AngularDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ANZ104AngularDemoLocalizationConfigurer).GetAssembly(),
                        "ANZ104AngularDemo.Localization.ANZ104AngularDemo"
                    )
                )
            );
        }
    }
}