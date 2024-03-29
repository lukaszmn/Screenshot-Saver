﻿namespace ITLN.ScreenshotSaver {
	partial class MainForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.clipboardPanel1 = new ITLN.ScreenshotSaver.ClipboardPanel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.watchPanel1 = new ITLN.ScreenshotSaver.WatchPanel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(856, 541);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.clipboardPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(848, 515);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Clipboard";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// clipboardPanel1
			// 
			this.clipboardPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clipboardPanel1.Location = new System.Drawing.Point(3, 3);
			this.clipboardPanel1.Name = "clipboardPanel1";
			this.clipboardPanel1.Size = new System.Drawing.Size(842, 509);
			this.clipboardPanel1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.watchPanel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(848, 515);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Watch folder";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// watchPanel1
			// 
			this.watchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.watchPanel1.Location = new System.Drawing.Point(3, 3);
			this.watchPanel1.Name = "watchPanel1";
			this.watchPanel1.Size = new System.Drawing.Size(842, 509);
			this.watchPanel1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 541);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Screenshot Saver";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private ClipboardPanel clipboardPanel1;
		private WatchPanel watchPanel1;
	}
}

