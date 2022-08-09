/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Distance_Traveled
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_5Hours;
		private System.Windows.Forms.Button button_8Hours;
		private System.Windows.Forms.Button button_12Hours;
		private System.Windows.Forms.Button Clearbutton;
		private System.Windows.Forms.Button Exitbutton;
		private System.Windows.Forms.TextBox SpeedtextBox;
		private System.Windows.Forms.TextBox resulttextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button_5Hours = new System.Windows.Forms.Button();
			this.button_8Hours = new System.Windows.Forms.Button();
			this.button_12Hours = new System.Windows.Forms.Button();
			this.Clearbutton = new System.Windows.Forms.Button();
			this.Exitbutton = new System.Windows.Forms.Button();
			this.SpeedtextBox = new System.Windows.Forms.TextBox();
			this.resulttextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(33, 62);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Speed:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(33, 105);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Distance Traveled: ";
			// 
			// button_5Hours
			// 
			this.button_5Hours.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button_5Hours.Location = new System.Drawing.Point(33, 179);
			this.button_5Hours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button_5Hours.Name = "button_5Hours";
			this.button_5Hours.Size = new System.Drawing.Size(93, 33);
			this.button_5Hours.TabIndex = 2;
			this.button_5Hours.Text = "5 Hours";
			this.button_5Hours.UseVisualStyleBackColor = false;
			this.button_5Hours.Click += new System.EventHandler(this.Button_5HoursClick);
			// 
			// button_8Hours
			// 
			this.button_8Hours.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button_8Hours.Location = new System.Drawing.Point(158, 179);
			this.button_8Hours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button_8Hours.Name = "button_8Hours";
			this.button_8Hours.Size = new System.Drawing.Size(88, 33);
			this.button_8Hours.TabIndex = 3;
			this.button_8Hours.Text = "8 Hours";
			this.button_8Hours.UseVisualStyleBackColor = false;
			this.button_8Hours.Click += new System.EventHandler(this.Button_8HoursClick);
			// 
			// button_12Hours
			// 
			this.button_12Hours.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button_12Hours.Location = new System.Drawing.Point(275, 179);
			this.button_12Hours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button_12Hours.Name = "button_12Hours";
			this.button_12Hours.Size = new System.Drawing.Size(90, 33);
			this.button_12Hours.TabIndex = 4;
			this.button_12Hours.Text = "12 Hours";
			this.button_12Hours.UseVisualStyleBackColor = false;
			this.button_12Hours.Click += new System.EventHandler(this.Button_12HoursClick);
			// 
			// Clearbutton
			// 
			this.Clearbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.Clearbutton.Location = new System.Drawing.Point(106, 252);
			this.Clearbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new System.Drawing.Size(74, 33);
			this.Clearbutton.TabIndex = 5;
			this.Clearbutton.Text = "Clear";
			this.Clearbutton.UseVisualStyleBackColor = false;
			this.Clearbutton.Click += new System.EventHandler(this.ClearbuttonClick);
			// 
			// Exitbutton
			// 
			this.Exitbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.Exitbutton.Location = new System.Drawing.Point(226, 252);
			this.Exitbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Exitbutton.Name = "Exitbutton";
			this.Exitbutton.Size = new System.Drawing.Size(74, 33);
			this.Exitbutton.TabIndex = 6;
			this.Exitbutton.Text = "Exit";
			this.Exitbutton.UseVisualStyleBackColor = false;
			this.Exitbutton.Click += new System.EventHandler(this.ExitbuttonClick);
			// 
			// SpeedtextBox
			// 
			this.SpeedtextBox.Location = new System.Drawing.Point(175, 62);
			this.SpeedtextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.SpeedtextBox.Name = "SpeedtextBox";
			this.SpeedtextBox.Size = new System.Drawing.Size(94, 23);
			this.SpeedtextBox.TabIndex = 7;
			this.SpeedtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// resulttextBox
			// 
			this.resulttextBox.Enabled = false;
			this.resulttextBox.Location = new System.Drawing.Point(175, 105);
			this.resulttextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.resulttextBox.Name = "resulttextBox";
			this.resulttextBox.Size = new System.Drawing.Size(94, 23);
			this.resulttextBox.TabIndex = 8;
			this.resulttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(275, 103);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "miles";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(275, 62);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "miles per hour";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(418, 352);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.resulttextBox);
			this.Controls.Add(this.SpeedtextBox);
			this.Controls.Add(this.Exitbutton);
			this.Controls.Add(this.Clearbutton);
			this.Controls.Add(this.button_12Hours);
			this.Controls.Add(this.button_8Hours);
			this.Controls.Add(this.button_5Hours);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "MainForm";
			this.Text = "Distance Traveled";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
