using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeUtility
{
	public partial class Form1 : Form
	{
		private SettingsSerializer settings = new SettingsSerializer();
		private Helper helper = null;

		public Form1()
		{
			InitializeComponent();

			helper = new Helper(this.Log);

			ddlBackupType.SelectedIndex = 0;
			ddlRepoType.SelectedIndex = 0;
			ddlFileFilterType.SelectedIndex = 0;
			cmbRange.Items.Add("\"@{60 mins ago}\"");
			cmbRange.Items.Add("\"{60 days ago}:HEAD\"");
			cmbRange.SelectedIndex = 0;
		}

		private void btnRepoLoc_Click(object sender, EventArgs e)
		{
			tbRepoLoc.Text = chooseFolder();
		}

		private void btnZipLoc_Click(object sender, EventArgs e)
		{
			tbZipLoc.Text = chooseFolder();
		}

		private void btnVersionRelease_Click(object sender, EventArgs e)
		{
			string repoLoc, range, zipLoc, includeFilter, excludeFilter, fileFilterType, repoType, filters;
			bool includeDlls = cbDlls.Checked;
			range = cmbRange.Text;
			fileFilterType = ddlFileFilterType.Text;
			repoType = ddlRepoType.Text;
			filters = tbFilters.Text.Replace("\n",",");
			zipLoc = tbZipLoc.Text;
			repoLoc = tbRepoLoc.Text.ToLower();
			includeFilter = "";
			excludeFilter = "";

			IEnumerable<string> fileList = null;
			if (repoType == "git")
			{
				try
				{
					fileList = helper.GitExport(repoLoc, range);
				}
				catch (Exception ex)
				{
					Log(ex);
				}
			}
			else if (repoType == "svn")
			{
				try
				{
					fileList = helper.SVNExport(repoLoc, range);
				}
				catch (Exception ex)
				{
					Log(ex);
				}
			}

			if (fileFilterType == "inclusion")
			{
				includeFilter = filters;
			}
			else
			{
				excludeFilter = filters;
			}

			if (includeDlls)
			{
				fileList = (new List<string>(fileList ?? new string[]{})).Concat(helper.BinFiles(repoLoc, 60 * 60 * 2));
			}
			bool ret = false;
			try
			{
				ret = helper.ZipForRelease(repoLoc, fileList, zipLoc, includeFilter, excludeFilter);
			}
			catch (Exception ex)
			{
				Log(ex);
			}
			Log(ret ? "Zip file ready for release" : "Some error. Please try again");
		}

		private void ddlBackupType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlBackupType.Text == "file list")
			{
				tbBackupFiles.Enabled = true;
				tbBackupFolder.Enabled = false;
			}
			else
			{
				tbBackupFiles.Enabled = false;
				tbBackupFolder.Enabled = true;
			}
		}

		private void btnBackupZipLoc_Click(object sender, EventArgs e)
		{
			tbBackupZipLoc.Text = chooseFolder();
		}

		private void btnBackupStart_Click(object sender, EventArgs e)
		{
			string src, dest, rootLoc;
			IEnumerable<string> list = null;
			bool isFileList = ddlBackupType.Text.ToLower() == "file list";
			src = tbBackupFolder.Text;
			dest = tbBackupZipLoc.Text;
			rootLoc = tbBackupRootLoc.Text;
			string ret = null;
			list = tbBackupFiles.Text.Replace(",", "\n").Split(new[]{'\n'}, StringSplitOptions.RemoveEmptyEntries);
			try
			{
				if (isFileList)
				{
					ret = helper.Backup(list, dest, rootLoc);
				}
				else
				{
					ret = helper.Backup(src, dest);
				}

			}
			catch (Exception ex)
			{
				Log(ex);
			} 
			Log(!string.IsNullOrEmpty(ret) ? "Backup file created" : "Backup failed. Please try again");
		}

		private void btnRestoreZipFile_Click(object sender, EventArgs e)
		{
			tbRestoreZipFile.Text = chooseFile(new []{"zip"});
		}

		private void btnRestoreLoc_Click(object sender, EventArgs e)
		{
			tbRestoreLoc.Text = chooseFolder();
		}

		private void btnRestoreStart_Click(object sender, EventArgs e)
		{
			string zipFilePath, restoreTo;
			zipFilePath = tbRestoreZipFile.Text;
			restoreTo = tbRestoreLoc.Text;
			bool ret = false;
			try
			{
				ret = helper.Restore(zipFilePath, restoreTo);
			}
			catch (Exception ex)
			{
				Log(ex);
			}
		}

		private void btnGitExe_Click(object sender, EventArgs e)
		{
			tbGitExe.Text = chooseFile(new[] { "exe" });
		}

		private void btnSvnExe_Click(object sender, EventArgs e)
		{
			tbSvnExe.Text = chooseFile(new[] { "exe" });
		}

		private void btnSettingsSave_Click(object sender, EventArgs e)
		{
			settings.settings.GitExe = tbGitExe.Text;
			settings.settings.SvnExe = tbSvnExe.Text;
			settings.SaveSettings();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			settings.LoadSettings();
			LoadSettingsInForm(settings);
		}

		private void Log(string p)
		{
			this.tbOutput.Text += string.Format("{0:yyyy-MM-dd HH:mm:ss}:=> {1}", DateTime.Now, p);
		}

		private void Log(Exception ex) 
		{
			List<string> list = new List<string>();
			list.Add(ex.Message);
			list.Add(ex.StackTrace);
			if (ex.InnerException != null)
			{
				list.Add(ex.InnerException.Message);
				list.Add(ex.InnerException.StackTrace);
			}
		}
		private void LoadSettingsInForm(SettingsSerializer settings)
		{
			cbDlls.Checked = settings.versionRelease.IncludeDlls;
			cmbRange.Text = settings.versionRelease.Range;
			ddlFileFilterType.Text = settings.versionRelease.FileFilterType;
			ddlRepoType.Text = settings.versionRelease.RepoType;
			tbFilters.Text = settings.versionRelease.Filters;
			tbZipLoc.Text = settings.versionRelease.ZipLoc;
			tbRepoLoc.Text = settings.versionRelease.RepoLoc;

			ddlBackupType.Text = settings.backup.BackupType;
			tbBackupRootLoc.Text = settings.backup.RootLoc;
			tbBackupZipLoc.Text = settings.backup.ZipLoc;

			tbRestoreLoc.Text = settings.restore.RestoreLoc;
			tbRestoreZipFile.Text = settings.restore.ZipLoc;

			tbGitExe.Text = settings.settings.GitExe;
			tbSvnExe.Text = settings.settings.SvnExe;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				settings.versionRelease.IncludeDlls = cbDlls.Checked;
				settings.versionRelease.Range = cmbRange.Text;
				settings.versionRelease.FileFilterType = ddlFileFilterType.Text;
				settings.versionRelease.RepoType = ddlRepoType.Text;
				settings.versionRelease.Filters = tbFilters.Text;
				settings.versionRelease.ZipLoc = tbZipLoc.Text;
				settings.versionRelease.RepoLoc = tbRepoLoc.Text;

				settings.backup.BackupType = ddlBackupType.Text;
				settings.backup.RootLoc = tbBackupRootLoc.Text;
				settings.backup.ZipLoc = tbBackupZipLoc.Text;

				settings.restore.RestoreLoc = tbRestoreLoc.Text;
				settings.restore.ZipLoc = tbRestoreZipFile.Text;

				settings.settings.GitExe = tbGitExe.Text;
				settings.settings.SvnExe = tbSvnExe.Text;

				settings.SaveSettings();
			}
			catch (Exception ex)
			{
				
			}
		}

		private string chooseFile(IEnumerable<string> extensionList)
		{
			string ret = null;
			openFileDialog1.Filter = string.Join("|", extensionList.Select(x => string.Format("{0} files (*.{0})|*.{0}", x)));
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ret = openFileDialog1.FileName;
			}
			return ret;
		}

		private string chooseFolder()
		{
			string ret = null;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				ret = folderBrowserDialog1.SelectedPath;
			}
			return ret;
		}
	}
}
