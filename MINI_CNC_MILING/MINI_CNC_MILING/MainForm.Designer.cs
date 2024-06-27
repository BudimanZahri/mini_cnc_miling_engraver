﻿/*
 * Created by SharpDevelop.
 * User: budimanzahri
 * Date: 25/06/2024
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MINI_CNC_MILING
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.button_enable_cw_x = new Guna.UI2.WinForms.Guna2Button();
			this.button_enable_ccw_x = new Guna.UI2.WinForms.Guna2Button();
			this.button_disable_x = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.exit_button = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.serial_com_dropdown = new Guna.UI2.WinForms.Guna2ComboBox();
			this.button_disconnect_serial = new Guna.UI2.WinForms.Guna2Button();
			this.button_connect_serial = new Guna.UI2.WinForms.Guna2Button();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.button_enable_ccw_y = new Guna.UI2.WinForms.Guna2Button();
			this.button_disable_y = new Guna.UI2.WinForms.Guna2Button();
			this.button_enable_cw_y = new Guna.UI2.WinForms.Guna2Button();
			this.Trackbar_y_axis = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.is_yellow_lamp_indicator_x_axis = new Guna.UI2.WinForms.Guna2PictureBox();
			this.is_green_lamp_indicator_x_axis = new Guna.UI2.WinForms.Guna2PictureBox();
			this.is_red_lamp_indicator_x_axis = new Guna.UI2.WinForms.Guna2PictureBox();
			this.pictureBox1 = new Guna.UI2.WinForms.Suite.PictureBox();
			this.Trackbar_x_axis = new Guna.UI2.WinForms.Guna2TrackBar();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			this.guna2GroupBox2.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.is_yellow_lamp_indicator_x_axis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.is_green_lamp_indicator_x_axis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.is_red_lamp_indicator_x_axis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button_enable_cw_x
			// 
			this.button_enable_cw_x.BorderRadius = 5;
			this.button_enable_cw_x.CheckedState.Parent = this.button_enable_cw_x;
			this.button_enable_cw_x.CustomImages.Parent = this.button_enable_cw_x;
			this.button_enable_cw_x.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button_enable_cw_x.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_enable_cw_x.ForeColor = System.Drawing.Color.White;
			this.button_enable_cw_x.HoverState.Parent = this.button_enable_cw_x;
			this.button_enable_cw_x.Location = new System.Drawing.Point(15, 121);
			this.button_enable_cw_x.Name = "button_enable_cw_x";
			this.button_enable_cw_x.ShadowDecoration.Parent = this.button_enable_cw_x;
			this.button_enable_cw_x.Size = new System.Drawing.Size(154, 26);
			this.button_enable_cw_x.TabIndex = 0;
			this.button_enable_cw_x.Text = "Enable CW (X)";
			this.button_enable_cw_x.Click += new System.EventHandler(this.Button_enable_cw_xClick);
			// 
			// button_enable_ccw_x
			// 
			this.button_enable_ccw_x.BorderRadius = 5;
			this.button_enable_ccw_x.CheckedState.Parent = this.button_enable_ccw_x;
			this.button_enable_ccw_x.CustomImages.Parent = this.button_enable_ccw_x;
			this.button_enable_ccw_x.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button_enable_ccw_x.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_enable_ccw_x.ForeColor = System.Drawing.Color.White;
			this.button_enable_ccw_x.HoverState.Parent = this.button_enable_ccw_x;
			this.button_enable_ccw_x.Location = new System.Drawing.Point(15, 89);
			this.button_enable_ccw_x.Name = "button_enable_ccw_x";
			this.button_enable_ccw_x.ShadowDecoration.Parent = this.button_enable_ccw_x;
			this.button_enable_ccw_x.Size = new System.Drawing.Size(154, 26);
			this.button_enable_ccw_x.TabIndex = 0;
			this.button_enable_ccw_x.Text = "Enable CCW (X)";
			this.button_enable_ccw_x.Click += new System.EventHandler(this.Button_enable_ccw_xClick);
			// 
			// button_disable_x
			// 
			this.button_disable_x.BorderRadius = 5;
			this.button_disable_x.CheckedState.Parent = this.button_disable_x;
			this.button_disable_x.CustomImages.Parent = this.button_disable_x;
			this.button_disable_x.FillColor = System.Drawing.Color.Red;
			this.button_disable_x.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_disable_x.ForeColor = System.Drawing.Color.White;
			this.button_disable_x.HoverState.Parent = this.button_disable_x;
			this.button_disable_x.Location = new System.Drawing.Point(15, 57);
			this.button_disable_x.Name = "button_disable_x";
			this.button_disable_x.ShadowDecoration.Parent = this.button_disable_x;
			this.button_disable_x.Size = new System.Drawing.Size(154, 26);
			this.button_disable_x.TabIndex = 0;
			this.button_disable_x.Text = "Disable (X)";
			this.button_disable_x.Click += new System.EventHandler(this.Button_disable_xClick);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(1110, 26);
			this.guna2Panel1.TabIndex = 1;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.White;
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 26);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(1110, 59);
			this.guna2Panel2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Manrope", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(11, 29);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(297, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = " Mini CNC Milling menggunakan Integrated servo motor";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Manrope", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "PBLMK232-54";
			// 
			// exit_button
			// 
			this.exit_button.BorderRadius = 5;
			this.exit_button.CheckedState.Parent = this.exit_button;
			this.exit_button.CustomImages.Parent = this.exit_button;
			this.exit_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.exit_button.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.exit_button.ForeColor = System.Drawing.Color.White;
			this.exit_button.HoverState.Parent = this.exit_button;
			this.exit_button.Location = new System.Drawing.Point(26, 637);
			this.exit_button.Name = "exit_button";
			this.exit_button.ShadowDecoration.Parent = this.exit_button;
			this.exit_button.Size = new System.Drawing.Size(154, 33);
			this.exit_button.TabIndex = 0;
			this.exit_button.Text = "Exit";
			this.exit_button.Click += new System.EventHandler(this.Exit_buttonClick);
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.BackColor = System.Drawing.Color.White;
			this.guna2Panel3.Controls.Add(this.serial_com_dropdown);
			this.guna2Panel3.Controls.Add(this.button_disconnect_serial);
			this.guna2Panel3.Controls.Add(this.button_connect_serial);
			this.guna2Panel3.Controls.Add(this.exit_button);
			this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel3.Location = new System.Drawing.Point(0, 85);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
			this.guna2Panel3.Size = new System.Drawing.Size(212, 691);
			this.guna2Panel3.TabIndex = 3;
			// 
			// serial_com_dropdown
			// 
			this.serial_com_dropdown.BackColor = System.Drawing.Color.Transparent;
			this.serial_com_dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.serial_com_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.serial_com_dropdown.FocusedColor = System.Drawing.Color.Empty;
			this.serial_com_dropdown.FocusedState.Parent = this.serial_com_dropdown;
			this.serial_com_dropdown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.serial_com_dropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.serial_com_dropdown.FormattingEnabled = true;
			this.serial_com_dropdown.HoverState.Parent = this.serial_com_dropdown;
			this.serial_com_dropdown.ItemHeight = 30;
			this.serial_com_dropdown.ItemsAppearance.Parent = this.serial_com_dropdown;
			this.serial_com_dropdown.Location = new System.Drawing.Point(12, 21);
			this.serial_com_dropdown.Name = "serial_com_dropdown";
			this.serial_com_dropdown.ShadowDecoration.Parent = this.serial_com_dropdown;
			this.serial_com_dropdown.Size = new System.Drawing.Size(183, 36);
			this.serial_com_dropdown.TabIndex = 1;
			this.serial_com_dropdown.SelectedIndexChanged += new System.EventHandler(this.Serial_com_dropdownSelectedIndexChanged);
			// 
			// button_disconnect_serial
			// 
			this.button_disconnect_serial.BorderRadius = 3;
			this.button_disconnect_serial.CheckedState.Parent = this.button_disconnect_serial;
			this.button_disconnect_serial.CustomImages.Parent = this.button_disconnect_serial;
			this.button_disconnect_serial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button_disconnect_serial.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_disconnect_serial.ForeColor = System.Drawing.Color.White;
			this.button_disconnect_serial.HoverState.Parent = this.button_disconnect_serial;
			this.button_disconnect_serial.Location = new System.Drawing.Point(109, 72);
			this.button_disconnect_serial.Name = "button_disconnect_serial";
			this.button_disconnect_serial.ShadowDecoration.Parent = this.button_disconnect_serial;
			this.button_disconnect_serial.Size = new System.Drawing.Size(86, 28);
			this.button_disconnect_serial.TabIndex = 0;
			this.button_disconnect_serial.Text = "Disconnect";
			this.button_disconnect_serial.Click += new System.EventHandler(this.Button_disconnect_serialClick);
			// 
			// button_connect_serial
			// 
			this.button_connect_serial.BorderRadius = 3;
			this.button_connect_serial.CheckedState.Parent = this.button_connect_serial;
			this.button_connect_serial.CustomImages.Parent = this.button_connect_serial;
			this.button_connect_serial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button_connect_serial.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_connect_serial.ForeColor = System.Drawing.Color.White;
			this.button_connect_serial.HoverState.Parent = this.button_connect_serial;
			this.button_connect_serial.Location = new System.Drawing.Point(12, 72);
			this.button_connect_serial.Name = "button_connect_serial";
			this.button_connect_serial.ShadowDecoration.Parent = this.button_connect_serial;
			this.button_connect_serial.Size = new System.Drawing.Size(90, 28);
			this.button_connect_serial.TabIndex = 0;
			this.button_connect_serial.Text = "Connect";
			this.button_connect_serial.Click += new System.EventHandler(this.Button_connect_serialClick);
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Controls.Add(this.button_enable_ccw_y);
			this.guna2GroupBox2.Controls.Add(this.button_disable_y);
			this.guna2GroupBox2.Controls.Add(this.button_enable_cw_y);
			this.guna2GroupBox2.Controls.Add(this.Trackbar_y_axis);
			this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2GroupBox2.Location = new System.Drawing.Point(247, 417);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
			this.guna2GroupBox2.Size = new System.Drawing.Size(387, 254);
			this.guna2GroupBox2.TabIndex = 3;
			this.guna2GroupBox2.Text = "Y Axis";
			// 
			// button_enable_ccw_y
			// 
			this.button_enable_ccw_y.BorderRadius = 5;
			this.button_enable_ccw_y.CheckedState.Parent = this.button_enable_ccw_y;
			this.button_enable_ccw_y.CustomImages.Parent = this.button_enable_ccw_y;
			this.button_enable_ccw_y.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button_enable_ccw_y.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_enable_ccw_y.ForeColor = System.Drawing.Color.White;
			this.button_enable_ccw_y.HoverState.Parent = this.button_enable_ccw_y;
			this.button_enable_ccw_y.Location = new System.Drawing.Point(15, 89);
			this.button_enable_ccw_y.Name = "button_enable_ccw_y";
			this.button_enable_ccw_y.ShadowDecoration.Parent = this.button_enable_ccw_y;
			this.button_enable_ccw_y.Size = new System.Drawing.Size(154, 26);
			this.button_enable_ccw_y.TabIndex = 0;
			this.button_enable_ccw_y.Text = "Enable CCW (Y)";
			this.button_enable_ccw_y.Click += new System.EventHandler(this.Button_enable_ccw_yClick);
			// 
			// button_disable_y
			// 
			this.button_disable_y.BorderRadius = 5;
			this.button_disable_y.CheckedState.Parent = this.button_disable_y;
			this.button_disable_y.CustomImages.Parent = this.button_disable_y;
			this.button_disable_y.FillColor = System.Drawing.Color.Red;
			this.button_disable_y.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_disable_y.ForeColor = System.Drawing.Color.White;
			this.button_disable_y.HoverState.Parent = this.button_disable_y;
			this.button_disable_y.Location = new System.Drawing.Point(15, 57);
			this.button_disable_y.Name = "button_disable_y";
			this.button_disable_y.ShadowDecoration.Parent = this.button_disable_y;
			this.button_disable_y.Size = new System.Drawing.Size(154, 26);
			this.button_disable_y.TabIndex = 0;
			this.button_disable_y.Text = "Disable (Y)";
			this.button_disable_y.Click += new System.EventHandler(this.Button_disable_yClick);
			// 
			// button_enable_cw_y
			// 
			this.button_enable_cw_y.BorderRadius = 5;
			this.button_enable_cw_y.CheckedState.Parent = this.button_enable_cw_y;
			this.button_enable_cw_y.CustomImages.Parent = this.button_enable_cw_y;
			this.button_enable_cw_y.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button_enable_cw_y.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_enable_cw_y.ForeColor = System.Drawing.Color.White;
			this.button_enable_cw_y.HoverState.Parent = this.button_enable_cw_y;
			this.button_enable_cw_y.Location = new System.Drawing.Point(15, 121);
			this.button_enable_cw_y.Name = "button_enable_cw_y";
			this.button_enable_cw_y.ShadowDecoration.Parent = this.button_enable_cw_y;
			this.button_enable_cw_y.Size = new System.Drawing.Size(154, 26);
			this.button_enable_cw_y.TabIndex = 0;
			this.button_enable_cw_y.Text = "Enable CW (Y)";
			this.button_enable_cw_y.Click += new System.EventHandler(this.Button_enable_cw_yClick);
			// 
			// Trackbar_y_axis
			// 
			this.Trackbar_y_axis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
			this.Trackbar_y_axis.HoverState.Parent = this.Trackbar_y_axis;
			this.Trackbar_y_axis.Location = new System.Drawing.Point(15, 153);
			this.Trackbar_y_axis.Maximum = 100000;
			this.Trackbar_y_axis.Minimum = 20;
			this.Trackbar_y_axis.Name = "Trackbar_y_axis";
			this.Trackbar_y_axis.Size = new System.Drawing.Size(347, 23);
			this.Trackbar_y_axis.SmallChange = 100;
			this.Trackbar_y_axis.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.Trackbar_y_axis.TabIndex = 3;
			this.Trackbar_y_axis.ThumbColor = System.Drawing.Color.OrangeRed;
			this.Trackbar_y_axis.Value = 10000;
			this.Trackbar_y_axis.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Trackbar_x_axisScroll);
			this.Trackbar_y_axis.Click += new System.EventHandler(this.Trackbar_y_axisClick);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.is_yellow_lamp_indicator_x_axis);
			this.guna2GroupBox1.Controls.Add(this.is_green_lamp_indicator_x_axis);
			this.guna2GroupBox1.Controls.Add(this.is_red_lamp_indicator_x_axis);
			this.guna2GroupBox1.Controls.Add(this.pictureBox1);
			this.guna2GroupBox1.Controls.Add(this.Trackbar_x_axis);
			this.guna2GroupBox1.Controls.Add(this.button_enable_ccw_x);
			this.guna2GroupBox1.Controls.Add(this.button_disable_x);
			this.guna2GroupBox1.Controls.Add(this.button_enable_cw_x);
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2GroupBox1.Location = new System.Drawing.Point(247, 106);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
			this.guna2GroupBox1.Size = new System.Drawing.Size(387, 275);
			this.guna2GroupBox1.TabIndex = 2;
			this.guna2GroupBox1.Text = "X Axis";
			// 
			// is_yellow_lamp_indicator_x_axis
			// 
			this.is_yellow_lamp_indicator_x_axis.BackColor = System.Drawing.Color.Transparent;
			this.is_yellow_lamp_indicator_x_axis.Image = ((System.Drawing.Image)(resources.GetObject("is_yellow_lamp_indicator_x_axis.Image")));
			this.is_yellow_lamp_indicator_x_axis.Location = new System.Drawing.Point(236, 72);
			this.is_yellow_lamp_indicator_x_axis.Name = "is_yellow_lamp_indicator_x_axis";
			this.is_yellow_lamp_indicator_x_axis.ShadowDecoration.Parent = this.is_yellow_lamp_indicator_x_axis;
			this.is_yellow_lamp_indicator_x_axis.Size = new System.Drawing.Size(76, 53);
			this.is_yellow_lamp_indicator_x_axis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.is_yellow_lamp_indicator_x_axis.TabIndex = 5;
			this.is_yellow_lamp_indicator_x_axis.TabStop = false;
			this.is_yellow_lamp_indicator_x_axis.UseTransparentBackground = true;
			// 
			// is_green_lamp_indicator_x_axis
			// 
			this.is_green_lamp_indicator_x_axis.BackColor = System.Drawing.Color.Transparent;
			this.is_green_lamp_indicator_x_axis.Image = ((System.Drawing.Image)(resources.GetObject("is_green_lamp_indicator_x_axis.Image")));
			this.is_green_lamp_indicator_x_axis.Location = new System.Drawing.Point(236, 104);
			this.is_green_lamp_indicator_x_axis.Name = "is_green_lamp_indicator_x_axis";
			this.is_green_lamp_indicator_x_axis.ShadowDecoration.Parent = this.is_green_lamp_indicator_x_axis;
			this.is_green_lamp_indicator_x_axis.Size = new System.Drawing.Size(76, 53);
			this.is_green_lamp_indicator_x_axis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.is_green_lamp_indicator_x_axis.TabIndex = 5;
			this.is_green_lamp_indicator_x_axis.TabStop = false;
			this.is_green_lamp_indicator_x_axis.UseTransparentBackground = true;
			// 
			// is_red_lamp_indicator_x_axis
			// 
			this.is_red_lamp_indicator_x_axis.BackColor = System.Drawing.Color.Transparent;
			this.is_red_lamp_indicator_x_axis.Image = ((System.Drawing.Image)(resources.GetObject("is_red_lamp_indicator_x_axis.Image")));
			this.is_red_lamp_indicator_x_axis.Location = new System.Drawing.Point(236, 45);
			this.is_red_lamp_indicator_x_axis.Name = "is_red_lamp_indicator_x_axis";
			this.is_red_lamp_indicator_x_axis.ShadowDecoration.Parent = this.is_red_lamp_indicator_x_axis;
			this.is_red_lamp_indicator_x_axis.Size = new System.Drawing.Size(76, 53);
			this.is_red_lamp_indicator_x_axis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.is_red_lamp_indicator_x_axis.TabIndex = 5;
			this.is_red_lamp_indicator_x_axis.TabStop = false;
			this.is_red_lamp_indicator_x_axis.UseTransparentBackground = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(186, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(176, 187);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Trackbar_x_axis
			// 
			this.Trackbar_x_axis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
			this.Trackbar_x_axis.HoverState.Parent = this.Trackbar_x_axis;
			this.Trackbar_x_axis.Location = new System.Drawing.Point(15, 238);
			this.Trackbar_x_axis.Maximum = 100000;
			this.Trackbar_x_axis.Minimum = 20;
			this.Trackbar_x_axis.Name = "Trackbar_x_axis";
			this.Trackbar_x_axis.Size = new System.Drawing.Size(347, 23);
			this.Trackbar_x_axis.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.Trackbar_x_axis.TabIndex = 3;
			this.Trackbar_x_axis.ThumbColor = System.Drawing.Color.OrangeRed;
			this.Trackbar_x_axis.Value = 10000;
			this.Trackbar_x_axis.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Trackbar_x_axisScroll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1110, 776);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MINI_CNC_MILING";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel3.ResumeLayout(false);
			this.guna2GroupBox2.ResumeLayout(false);
			this.guna2GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.is_yellow_lamp_indicator_x_axis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.is_green_lamp_indicator_x_axis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.is_red_lamp_indicator_x_axis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private Guna.UI2.WinForms.Guna2TrackBar Trackbar_y_axis;
		private Guna.UI2.WinForms.Guna2PictureBox is_yellow_lamp_indicator_x_axis;
		private Guna.UI2.WinForms.Guna2PictureBox is_red_lamp_indicator_x_axis;
		private Guna.UI2.WinForms.Guna2PictureBox is_green_lamp_indicator_x_axis;
		private Guna.UI2.WinForms.Suite.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2TrackBar Trackbar_x_axis;
		private Guna.UI2.WinForms.Guna2Button button_enable_cw_y;
		private Guna.UI2.WinForms.Guna2Button button_disable_y;
		private Guna.UI2.WinForms.Guna2Button button_enable_ccw_y;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2Button button_connect_serial;
		private Guna.UI2.WinForms.Guna2Button button_disconnect_serial;
		private Guna.UI2.WinForms.Guna2ComboBox serial_com_dropdown;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private Guna.UI2.WinForms.Guna2Button exit_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button button_disable_x;
		private Guna.UI2.WinForms.Guna2Button button_enable_ccw_x;
		private Guna.UI2.WinForms.Guna2Button button_enable_cw_x;
		
	}
}
