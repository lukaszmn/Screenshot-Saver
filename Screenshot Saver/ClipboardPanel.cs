using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace ITLN.ScreenshotSaver {

	public partial class ClipboardPanel : UserControl {

		public ClipboardPanel() {
			InitializeComponent();
		}

		private void uTypeDesktop_Click(object sender, EventArgs e) {
			paste("Desktop");
		}

		private void uTypeTablet_Click(object sender, EventArgs e) {
			paste("Tablet");
		}

		private void uTypeMobile_Click(object sender, EventArgs e) {
			paste("Mobile");
		}


		private void paste(string type) {
			string name = uName.Text + " - " + type + ".png";
			string path = name;
			uPicture.Image = null;

			try {
				path = Path.Combine(uFolder.Text, name);

				Image image = Clipboard.GetImage();
				uPicture.Image = image;
				image.Save(path, ImageFormat.Png);

				uStatus.Text = "Saved to: " + path;
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				uStatus.Text = "ERROR when saving to: " + path;
			}
		}

	}
}
