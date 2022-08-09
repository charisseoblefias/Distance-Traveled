/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Distance_Traveled
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button_5HoursClick(object sender, EventArgs e)
		{
			int Speed = Convert.ToInt16(SpeedtextBox.Text);
			int result = Speed * 5;
			resulttextBox.Text= result.ToString();
		}
		void Button_8HoursClick(object sender, EventArgs e)
		{
			int Speed = Convert.ToInt16(SpeedtextBox.Text);
			int result = Speed * 8;
			resulttextBox.Text= result.ToString();
		}
		void Button_12HoursClick(object sender, EventArgs e)
		{
			int Speed = Convert.ToInt16(SpeedtextBox.Text);
			int result = Speed * 12;
			resulttextBox.Text= result.ToString();
		}
		void ClearbuttonClick(object sender, EventArgs e)
		{
			SpeedtextBox.Clear();
			resulttextBox.Clear();
		}
		void ExitbuttonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
