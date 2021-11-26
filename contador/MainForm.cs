/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 25/10/2021
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace contador
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int hora=00, minuto=00, segundos=00;
		
		public MainForm()
		{
			
			InitializeComponent();
			
			
			
		}
		void Btn1Click(object sender, EventArgs e)
		{
			
			tmr_cronometro.Enabled=true;
			
			
		}
		void Tmr_cronometroTick(object sender, EventArgs e)
		{
			
			if (segundos > 60) {
				segundos=0;
				minuto=minuto+1;
			}
			
			if (minuto> 60) {
				minuto=0;
				hora=hora+1;
			}
			
			segundos++;
				
			if (segundos < 10) {
				
				lbl_segundos.Text= "0"+segundos.ToString();
				
			}
			
			if (minuto < 10) {
				
				lbl_minutos.Text= "0"+minuto.ToString();
				
			}
			
			if (hora < 10) {
				
				lbl_horas.Text = "0"+hora.ToString();	
				
			}
			
			if (segundos >= 10) {
				
				lbl_segundos.Text= segundos.ToString();
				
			}
			
			if (minuto >= 10) {
				
				lbl_minutos.Text= minuto.ToString();
				
			}
			
			if (hora >= 10) {
				
				lbl_horas.Text = hora.ToString();	
				
			}
			
		}
		void Btn2Click(object sender, EventArgs e)
		{
	
			tmr_cronometro.Enabled=false;
			
		}
		void Btn3Click(object sender, EventArgs e)
		{
			
			tmr_cronometro.Enabled=false;
			
			hora=0;
			minuto=0;
			segundos=0;
			
			lbl_horas.Text = "00";	
			lbl_minutos.Text= "00";
			lbl_segundos.Text="00";
			
			
		}
	}
}
