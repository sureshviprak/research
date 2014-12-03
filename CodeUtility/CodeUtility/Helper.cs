using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeUtility
{
	class Helper
	{
		Action<string> Logger = null;

		public Helper(): this(null)
		{

		}

		public Helper(Action<string> Logger)
		{
			this.Logger = Logger;
		}

		private void Log(string str)
		{
			if (Logger != null)
			{
				Logger(str);
			}
		}

		bool Extract(string zip, string extractTo, bool overwrite = true)
		{
			bool returnVal = false;
			if (!Directory.Exists(extractTo))
			{
				Directory.CreateDirectory(extractTo);
			}
			//ZipFile.ExtractToDirectory(zip, extractTo);
			using (ZipArchive archive = ZipFile.OpenRead(zip))
			{
				//archive.ExtractToDirectory(zip, extractTo, true);
				if (!overwrite)
				{
					Log(string.Format("Extracting to: {0}", extractTo));
					archive.ExtractToDirectory(extractTo);
					returnVal = true;
				}
				else
				{
					foreach (ZipArchiveEntry file in archive.Entries)
					{
						string completeFileName = Path.Combine(extractTo, file.FullName);
						string dPath = Path.GetDirectoryName(completeFileName);
						if (!Directory.Exists(dPath))
						{
							Directory.CreateDirectory(dPath);
							continue;
						}
						Log(string.Format("Extracting: {0}", file.Name));
						file.ExtractToFile(completeFileName, true);
					}
					returnVal = true;
				}
			}
			return returnVal;
		}

		bool Zip(IEnumerable<string> files, string zip, string rootLoc = "")
		{
			bool returnVal = false;
			if (files == null || files.Count() == 0) return false;
			var dir = Path.GetDirectoryName(zip);
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}
			using (ZipArchive archive = ZipFile.Open(zip, ZipArchiveMode.Update))
			{
				returnVal = true;
				foreach (string file in files)
				{
					string realPath = file;
					string virtualPath = file;
					if (!string.IsNullOrEmpty(rootLoc))
					{
						if (virtualPath.StartsWith(rootLoc, true, null))
						{
							//virtualPath = virtualPath.Replace(rootLoc + Path.DirectorySeparatorChar, "");
							virtualPath = Regex.Replace(virtualPath, Regex.Escape(rootLoc + Path.DirectorySeparatorChar), "", RegexOptions.IgnoreCase);
						}
						else
						{
							realPath = Path.Combine(rootLoc, virtualPath);
						}
					}
					else
					{
						virtualPath = Path.IsPathRooted(virtualPath) ? file.Replace(Path.GetPathRoot(virtualPath), "") : virtualPath;
					}
					if (File.Exists(realPath))
					{
						Log(string.Format("Adding to Zip: {0}", realPath));
						archive.CreateEntryFromFile(realPath, virtualPath);
					}
				}
			}
			return returnVal;
		}

		string _Backup(IEnumerable<string> list, string zipFilePath, string rootLoc = "")
		{
			string returnVal = "";
			if (list == null || list.Count() == 0) return returnVal;
			if (Zip(list, zipFilePath, rootLoc))
			{
				returnVal = zipFilePath;
			}
			return returnVal;
		}

		public string Backup(IEnumerable<string> list, string dest, string rootLoc = "")
		{
			var zipFilePath = Path.Combine(dest, Path.GetDirectoryName(dest) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".zip");
			return _Backup(list, zipFilePath, rootLoc);
		}

		public string Backup(string src, string dest)
		{
			var list = Directory.EnumerateFiles(src, "*.*", SearchOption.AllDirectories).Where(x => !x.EndsWith("*.log"));
			var zipFilePath = Path.Combine(dest, Path.GetFileName(src) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".zip");
			return _Backup(list, zipFilePath);
		}

		public bool Restore(string zipFilePath, string restoreTo)
		{
			bool returnVal = false;
			returnVal = Extract(zipFilePath, restoreTo);
			return returnVal;
		}

		public string GetProcessOutput(string fileToExecute, string arguments)
		{
			Process p = new Process();
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardError = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.Arguments = arguments;
			p.StartInfo.FileName = fileToExecute;
			p.Start();
			string output = p.StandardOutput.ReadToEnd();
			string error = p.StandardError.ReadToEnd();
			p.WaitForExit();

			if (!string.IsNullOrEmpty(error))
			{
				throw new Exception("Process error:" + error);
			}
			return output;
		}
		
		public IEnumerable<string> SVNExport(string repo, string range)
		{
			List<string> list = null;
			string output = GetProcessOutput(@"c:\Program Files\TortoiseSVN\bin\svn.exe", " diff --summarize -r " + range + " " + repo);
			output = output.Replace("/", Path.DirectorySeparatorChar.ToString());
			list = output.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !x.StartsWith("D")).Select(x => x.Substring(8)).ToList();
			Log(string.Format("file list from SVN :\n{0}", string.Join("\n",list)));
			return list;
		}

		public IEnumerable<string> GitExport(string repo, string range)
		{
			List<string> list = null;
			string output = GetProcessOutput(@"d:\Softwares\Git\bin\git.exe", "-C \"" + repo + "\" diff --diff-filter=ACMR --name-only " + range + " -- ");
			output = output.Replace("/", Path.DirectorySeparatorChar.ToString());
			list = output.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			Log(string.Format("file list from Git :\n{0}", string.Join("\n", list)));
			return list;
		}

		public bool ZipForRelease(string rootLoc, IEnumerable<string> files, string zip, string includeFileFilter, string excludeFileFilter)
		{
			var filterToInclude = (includeFileFilter ?? "").Replace(" ", "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			var filtersToExclude = (excludeFileFilter ?? "").Replace(" ", "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

			List<string> filesToZip = new List<string>();
			if (filterToInclude.Count() > 0)
			{
				filesToZip.AddRange(files.Where(x => filterToInclude.Contains(Path.GetExtension(x))));
			}
			else
			{
				filesToZip.AddRange(files);
			}
			if (filtersToExclude.Count() > 0 && filesToZip.Count() > 0)
			{
				filesToZip = filesToZip.Where(x => !filtersToExclude.Contains(Path.GetExtension(x))).ToList();
			}
			Log(string.Format("Files to Zip:\n{0}", string.Join("\n", filesToZip)));
			return Zip(filesToZip, zip, rootLoc);
		}

		public IEnumerable<string> BinFiles(string srcFolder, double timeInSec = 10)
		{
			List<string> list = new List<string>();
			var files = new DirectoryInfo(srcFolder).EnumerateFiles("*", SearchOption.AllDirectories).Where(x => (x.Extension == ".dll" || x.Extension == ".pdb" || x.Extension == ".xml") && x.DirectoryName.IndexOf("bin") > -1).OrderByDescending(x => x.LastWriteTime).ToList();
			if (files == null || files.Count == 0) return list;
			DateTime d = files[0].LastWriteTime;
			double secs = 0;
			foreach (var s in files)
			{
				secs = d.Subtract(s.LastWriteTime).TotalSeconds;
				if (secs < timeInSec)
				{
					list.Add(s.FullName.Replace(srcFolder + @"\", ""));
				}
				if (secs > timeInSec)
				{
					break;
				}
			}
			Log(string.Format("Files from Bin:\n{0}", string.Join("\n", list)));
			return list;
		}
	}
}
