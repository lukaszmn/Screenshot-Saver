using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Screenshot_Saver {

	public partial class WatchPanel : UserControl {

		private FileSystemWatcher watcher;

		private string discoveredPath;


		public WatchPanel() {
			InitializeComponent();
		}


		private void uTypeDesktop_Click(object sender, EventArgs e) {
			move("Desktop");
		}

		private void uTypeTablet_Click(object sender, EventArgs e) {
			move("Tablet");
		}

		private void uTypeMobile_Click(object sender, EventArgs e) {
			move("Mobile");
		}


		private void move(string type) {
			string name = uName.Text + " - " + type + ".png";
			string dest = name;
			uPicture.Image = null;

			try {
				string src = discoveredPath;
				dest = Path.Combine(uFolder.Text, name);

				File.Move(src, dest);

				uStatus.Text = "Moved to: " + dest;
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				uStatus.Text = "ERROR when moving to: " + dest;
			}
		}


		private void watch() {
			try {
				if (watcher != null) {
					watcher.Changed -= new FileSystemEventHandler(watcher_Changed);
					watcher.Dispose();
				}

				watcher = new FileSystemWatcher();
				watcher.Path = uWatchFolder.Text;
				watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
									   | NotifyFilters.FileName | NotifyFilters.DirectoryName;
				watcher.Filter = "*.png";
				watcher.Changed += new FileSystemEventHandler(watcher_Changed);
				watcher.EnableRaisingEvents = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}


		private void uWatch_Click(object sender, EventArgs e) {
			watch();
		}


		private void watcher_Changed(object source, FileSystemEventArgs e) {
			if (e.ChangeType == WatcherChangeTypes.Deleted) return;

			string path = e.FullPath;
			try {
				Image image = null;
				// avoid locking the file
				using (var bmpTemp = new Bitmap(path)) {
					image = new Bitmap(bmpTemp);
				}

				uPicture.Invoke(new Action(() => setInfo(image, "New image: " + path)));
				discoveredPath = path;
			} catch (Exception) {
				uPicture.Invoke(new Action(() => setInfo(null, "")));
				discoveredPath = null;
			}
		}


		private void setInfo(Image image, string text) {
			uPicture.Image = image;
			uStatus.Text = text;
		}

	}
}
