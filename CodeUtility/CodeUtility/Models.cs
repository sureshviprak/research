using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeUtility
{

	class VersionRelease
	{
		public string RepoType { get; set; }
		public string RepoLoc { get; set; }
		public string ZipLoc { get; set; }
		public string Range { get; set; }
		public bool IncludeDlls { get; set; }
		public string FileFilterType { get; set; }
		public string Filters { get; set; }
	}

	class Backup
	{
		public string BackupType { get; set; }
		public string RootLoc { get; set; }
		public string ZipLoc { get; set; }
	}

	class Restore
	{
		public string RestoreLoc { get; set; }
		public string ZipLoc { get; set; }
	}

	class Settings
	{
		public string GitExe { get; set; }
		public string SvnExe { get; set; }
	}

	class SettingsSerializer
	{
		private string filePath = "settings.json";
		public VersionRelease versionRelease { get; set; }
		public Backup backup { get; set; }
		public Restore restore { get; set; }
		public Settings settings { get; set; }

		public SettingsSerializer()
		{
			versionRelease = new VersionRelease();
			backup = new Backup();
			restore = new Restore();
			settings = new Settings();
		}

		public void SaveSettings()
		{
			string str = JsonConvert.SerializeObject(this);
			File.WriteAllText(filePath, str);
		}

		public void LoadSettings()
		{
			string str = File.ReadAllText(filePath);
			if (!string.IsNullOrEmpty(str))
			{
				SettingsSerializer s = JsonConvert.DeserializeObject<SettingsSerializer>(str);
				this.versionRelease = s.versionRelease;
				this.backup = s.backup;
				this.restore = s.restore;
				this.settings = s.settings;
			}
		}
	}

}
