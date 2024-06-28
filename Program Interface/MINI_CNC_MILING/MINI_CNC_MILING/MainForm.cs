/*
 * Created by SharpDevelop.
 * User: budimanzahri
 * Date: 25/06/2024
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MINI_CNC_MILING
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private SerialPort serialPort;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            // Initialize the SerialPort
            serialPort = new SerialPort();
            
            // Populate the ComboBox with available COM ports
            PopulateSerialComDropdown();
            
            // Attach the event handler for the ComboBox
            serial_com_dropdown.SelectedIndexChanged += Serial_com_dropdownSelectedIndexChanged;
            
//            X Axis
            is_green_lamp_indicator_x_axis.Visible = false;
            is_red_lamp_indicator_x_axis.Visible = true;
            is_yellow_lamp_indicator_x_axis.Visible = false;
            
            arrow_up_x_axis.Visible = false;
            arrow_down_x_axis.Visible = false;
            
//            Y Axis
            is_green_lamp_indicator_y_axis.Visible = false;
            is_red_lamp_indicator_y_axis.Visible = true;
            is_yellow_lamp_indicator_y_axis.Visible = false;
            
            arrow_left_y_axis.Visible = false;
            arrow_right_y_axis.Visible = false;
            
//            Z Axis
            is_green_lamp_indicator_z_axis.Visible = false;
            is_red_lamp_indicator_z_axis.Visible = true;
            is_yellow_lamp_indicator_z_axis.Visible = false;
        }

        private void PopulateSerialComDropdown()
		{
		    // Add a placeholder item
		    serial_com_dropdown.Items.Add("Select a COM port...");
		    
		    // Get the available COM ports
		    string[] ports = SerialPort.GetPortNames();
		    
		    // Add the COM ports to the ComboBox
		    serial_com_dropdown.Items.AddRange(ports);
		    
		    // Select the placeholder by default
		    if (serial_com_dropdown.Items.Count > 0)
		    {
		        serial_com_dropdown.SelectedIndex = 0; // Select the placeholder item by default
		    }
		}

        void Button_enable_cw_xClick(object sender, EventArgs e)
        {
        	is_green_lamp_indicator_x_axis.Visible = true;
            is_red_lamp_indicator_x_axis.Visible = false;
            is_yellow_lamp_indicator_x_axis.Visible = false;
            
            arrow_up_x_axis.Visible = true;
            arrow_down_x_axis.Visible = false;
            
        	if (serialPort.IsOpen)
            {
                serialPort.Write("Q");
            }
        }

        void Button_enable_ccw_xClick(object sender, EventArgs e)
        {
        	is_green_lamp_indicator_x_axis.Visible = false;
            is_red_lamp_indicator_x_axis.Visible = false;
            is_yellow_lamp_indicator_x_axis.Visible = true;
            
            arrow_up_x_axis.Visible = false;
            arrow_down_x_axis.Visible = true;
            
            if (serialPort.IsOpen)
            {
                serialPort.Write("W");
            }
        }

        void Button_disable_xClick(object sender, EventArgs e)
        {
        	is_green_lamp_indicator_x_axis.Visible = false;
            is_red_lamp_indicator_x_axis.Visible = true;
            is_yellow_lamp_indicator_x_axis.Visible = false;
            
            arrow_up_x_axis.Visible = false;
            arrow_down_x_axis.Visible = false;
            
            if (serialPort.IsOpen)
            {
                serialPort.Write("E");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        void Exit_buttonClick(object sender, EventArgs e)
        {
            Close();
        }
        
		
		void Serial_com_dropdownSelectedIndexChanged(object sender, EventArgs e)
		{
		    if (serial_com_dropdown.SelectedIndex > 0)
		    {
		        string selectedPort = serial_com_dropdown.SelectedItem.ToString();
		        if (serialPort.IsOpen)
		        {
		            serialPort.Close();
		        }
		        serialPort.PortName = selectedPort;
		        serialPort.BaudRate = 9600; // Set your desired baud rate
		        serialPort.Open();
		    }
		    else
		    {
		        if (serialPort.IsOpen)
		        {
		            serialPort.Close();
		        }
		    }
		}
		
		void Button_connect_serialClick(object sender, EventArgs e)
		{
			try
			{
				if (!serialPort.IsOpen)
				{
					serialPort.Open();
					MessageBox.Show("Serial port connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Serial port is already connected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error connecting to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void Button_disconnect_serialClick(object sender, EventArgs e)
		{
			try
			{
				if (serialPort.IsOpen)
				{
					serialPort.Close();
					MessageBox.Show("Serial port disconnected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Serial port is already disconnected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error disconnecting from serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button_enable_cw_yClick(object sender, EventArgs e)
		{
			is_green_lamp_indicator_y_axis.Visible = true;
            is_red_lamp_indicator_y_axis.Visible = false;
            is_yellow_lamp_indicator_y_axis.Visible = false;
            
            arrow_left_y_axis.Visible = true;
            arrow_right_y_axis.Visible = false;
            
			if (serialPort.IsOpen)
            {
                serialPort.Write("R");
            }
		}
		
		void Button_enable_ccw_yClick(object sender, EventArgs e)
		{
			is_green_lamp_indicator_y_axis.Visible = false;
            is_red_lamp_indicator_y_axis.Visible = false;
            is_yellow_lamp_indicator_y_axis.Visible = true;
            
            arrow_left_y_axis.Visible = false;
            arrow_right_y_axis.Visible = true;
			
			if (serialPort.IsOpen)
            {
                serialPort.Write("T");
            }
		}
		
		void Button_disable_yClick(object sender, EventArgs e)
		{
			is_green_lamp_indicator_y_axis.Visible = false;
            is_red_lamp_indicator_y_axis.Visible = true;
            is_yellow_lamp_indicator_y_axis.Visible = false;
            
            arrow_left_y_axis.Visible = false;
            arrow_right_y_axis.Visible = false;
            
			if (serialPort.IsOpen)
            {
                serialPort.Write("Y");
            }
		}
		
		void Trackbar_x_axisScroll(object sender, ScrollEventArgs e)
		{
			if (serialPort.IsOpen)
		    {
		        int speed = Trackbar_x_axis.Value;
		        string command = string.Format("S{0}X", speed);
		        serialPort.Write(command);
		    }
		}
		
		void Trackbar_y_axisClick(object sender, EventArgs e)
		{
			if (serialPort.IsOpen)
	        {
	            int speed = Trackbar_y_axis.Value;
	            string command = string.Format("S{0}Y", speed);
	            serialPort.Write(command);
	        }
		}
		
		void Button_disable_zClick(object sender, EventArgs e)
		{
			is_green_lamp_indicator_z_axis.Visible = false;
            is_red_lamp_indicator_z_axis.Visible = true;
            is_yellow_lamp_indicator_z_axis.Visible = false;
			
			if (serialPort.IsOpen)
            {
                serialPort.Write("O");
            }		
		}
		
		void Button_enable_cw_zClick(object sender, EventArgs e)
		{
			is_green_lamp_indicator_z_axis.Visible = true;
            is_red_lamp_indicator_z_axis.Visible = false;
            is_yellow_lamp_indicator_z_axis.Visible = false;
			
			if (serialPort.IsOpen)
            {
                serialPort.Write("U");
            }		
		}
		
		void Button_enable_ccw_zClick(object sender, EventArgs e)
		{
			is_green_lamp_indicator_z_axis.Visible = false;
            is_red_lamp_indicator_z_axis.Visible = false;
            is_yellow_lamp_indicator_z_axis.Visible = true;
			
			if (serialPort.IsOpen)
            {
                serialPort.Write("I");
            }
		}
		
		void Button_emergencyClick(object sender, EventArgs e)
		{
			Button_disable_xClick(sender, e);
			Button_disable_yClick(sender, e);
			Button_disable_zClick(sender, e);
		}
    }
}
