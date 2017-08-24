using System.Configuration;
using System.IO;
using System.Reflection;

namespace Emigrace.Core
{
	public static class Config
	{
		private static readonly IConfig _default = new DefaultConfig();
		private static IConfig _current = _default;

		public static IConfig Default
		{
			get { return _default; }
		}

		public static IConfig Current
		{
			get { return _current; }
			set { _current = value; }
		}

		private class DefaultConfig : IConfig
		{
			private static readonly Configuration _configuration;

            static DefaultConfig()
			{
                var folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase.Replace("file:///", ""));
                var file = Path.Combine(folder, "Configuration", "Core.config");
                var map = new ExeConfigurationFileMap { ExeConfigFilename = file };
				_configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            }

			public string ConnectionString { get { return GetAppSettingsValue("database"); } }
			public string Environment { get { return GetAppSettingsValue("environment"); } }
           

            private string GetAppSettingsValue(string key)
            {
                return _configuration.AppSettings.Settings[key].Value;
            }            
        }
	}
}
