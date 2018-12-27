namespace Screenshot_Saver {
	partial class WatchPanel {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.uPicture = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.uStatus = new System.Windows.Forms.Label();
			this.uFolder = new System.Windows.Forms.TextBox();
			this.uTypeMobile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.uTypeTablet = new System.Windows.Forms.Button();
			this.uName = new System.Windows.Forms.TextBox();
			this.uTypeDesktop = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.uWatchFolder = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.uWatch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.uPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// uPicture
			// 
			this.uPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uPicture.Location = new System.Drawing.Point(406, 192);
			this.uPicture.Name = "uPicture";
			this.uPicture.Size = new System.Drawing.Size(419, 331);
			this.uPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.uPicture.TabIndex = 17;
			this.uPicture.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Save to folder:";
			// 
			// uStatus
			// 
			this.uStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uStatus.AutoSize = true;
			this.uStatus.Location = new System.Drawing.Point(14, 531);
			this.uStatus.Name = "uStatus";
			this.uStatus.Size = new System.Drawing.Size(38, 13);
			this.uStatus.TabIndex = 16;
			this.uStatus.Text = "Ready";
			// 
			// uFolder
			// 
			this.uFolder.Location = new System.Drawing.Point(17, 87);
			this.uFolder.Name = "uFolder";
			this.uFolder.Size = new System.Drawing.Size(808, 20);
			this.uFolder.TabIndex = 9;
			// 
			// uTypeMobile
			// 
			this.uTypeMobile.Location = new System.Drawing.Point(282, 224);
			this.uTypeMobile.Name = "uTypeMobile";
			this.uTypeMobile.Size = new System.Drawing.Size(99, 72);
			this.uTypeMobile.TabIndex = 13;
			this.uTypeMobile.Text = "Mobile";
			this.uTypeMobile.UseVisualStyleBackColor = true;
			this.uTypeMobile.Click += new System.EventHandler(this.uTypeMobile_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "File name:";
			// 
			// uTypeTablet
			// 
			this.uTypeTablet.Location = new System.Drawing.Point(149, 224);
			this.uTypeTablet.Name = "uTypeTablet";
			this.uTypeTablet.Size = new System.Drawing.Size(99, 72);
			this.uTypeTablet.TabIndex = 14;
			this.uTypeTablet.Text = "Tablet";
			this.uTypeTablet.UseVisualStyleBackColor = true;
			this.uTypeTablet.Click += new System.EventHandler(this.uTypeTablet_Click);
			// 
			// uName
			// 
			this.uName.Location = new System.Drawing.Point(17, 147);
			this.uName.Name = "uName";
			this.uName.Size = new System.Drawing.Size(808, 20);
			this.uName.TabIndex = 11;
			// 
			// uTypeDesktop
			// 
			this.uTypeDesktop.Location = new System.Drawing.Point(20, 224);
			this.uTypeDesktop.Name = "uTypeDesktop";
			this.uTypeDesktop.Size = new System.Drawing.Size(99, 72);
			this.uTypeDesktop.TabIndex = 15;
			this.uTypeDesktop.Text = "Desktop";
			this.uTypeDesktop.UseVisualStyleBackColor = true;
			this.uTypeDesktop.Click += new System.EventHandler(this.uTypeDesktop_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Screenshot type - click to rename and move to your folder:";
			// 
			// uWatchFolder
			// 
			this.uWatchFolder.Location = new System.Drawing.Point(17, 33);
			this.uWatchFolder.Name = "uWatchFolder";
			this.uWatchFolder.Size = new System.Drawing.Size(720, 20);
			this.uWatchFolder.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Watch folder:";
			// 
			// uWatch
			// 
			this.uWatch.Location = new System.Drawing.Point(743, 30);
			this.uWatch.Name = "uWatch";
			this.uWatch.Size = new System.Drawing.Size(75, 23);
			this.uWatch.TabIndex = 18;
			this.uWatch.Text = "Watch";
			this.uWatch.UseVisualStyleBackColor = true;
			this.uWatch.Click += new System.EventHandler(this.uWatch_Click);
			// 
			// WatchPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.uWatch);
			this.Controls.Add(this.uPicture);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uWatchFolder);
			this.Controls.Add(this.uStatus);
			this.Controls.Add(this.uFolder);
			this.Controls.Add(this.uTypeMobile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.uTypeTablet);
			this.Controls.Add(this.uName);
			this.Controls.Add(this.uTypeDesktop);
			this.Controls.Add(this.label3);
			this.Name = "WatchPanel";
			this.Size = new System.Drawing.Size(842, 559);
			((System.ComponentModel.ISupportInitialize)(this.uPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox uPicture;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label uStatus;
		private System.Windows.Forms.TextBox uFolder;
		private System.Windows.Forms.Button uTypeMobile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button uTypeTablet;
		private System.Windows.Forms.TextBox uName;
		private System.Windows.Forms.Button uTypeDesktop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox uWatchFolder;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button uWatch;
	}
}
