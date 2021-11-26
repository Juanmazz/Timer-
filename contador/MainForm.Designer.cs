/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 25/10/2021
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace contador
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_iniciar;
		private System.Windows.Forms.Button btn_detener;
		private System.Windows.Forms.Button btn_reiniciar;
		private System.Windows.Forms.Timer tmr_cronometro;
		private System.Windows.Forms.Label lbl_horas;
		private System.Windows.Forms.Label lbl_minutos;
		private System.Windows.Forms.Label lbl_segundos;
		private System.Windows.Forms.Label lbl_puntos;
		private System.Windows.Forms.Label label1;
		
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
			this.components = new System.ComponentModel.Container();
			this.btn_iniciar = new System.Windows.Forms.Button();
			this.btn_detener = new System.Windows.Forms.Button();
			this.btn_reiniciar = new System.Windows.Forms.Button();
			this.tmr_cronometro = new System.Windows.Forms.Timer(this.components);
			this.lbl_horas = new System.Windows.Forms.Label();
			this.lbl_minutos = new System.Windows.Forms.Label();
			this.lbl_segundos = new System.Windows.Forms.Label();
			this.lbl_puntos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.Location = new System.Drawing.Point(68, 375);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.Size = new System.Drawing.Size(155, 49);
			this.btn_iniciar.TabIndex = 0;
			this.btn_iniciar.Text = "Iniciar";
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn_detener
			// 
			this.btn_detener.Location = new System.Drawing.Point(241, 375);
			this.btn_detener.Name = "btn_detener";
			this.btn_detener.Size = new System.Drawing.Size(155, 49);
			this.btn_detener.TabIndex = 1;
			this.btn_detener.Text = "Detener";
			this.btn_detener.UseVisualStyleBackColor = true;
			this.btn_detener.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn_reiniciar
			// 
			this.btn_reiniciar.Location = new System.Drawing.Point(415, 375);
			this.btn_reiniciar.Name = "btn_reiniciar";
			this.btn_reiniciar.Size = new System.Drawing.Size(155, 49);
			this.btn_reiniciar.TabIndex = 2;
			this.btn_reiniciar.Text = "Reiniciar ";
			this.btn_reiniciar.UseVisualStyleBackColor = true;
			this.btn_reiniciar.Click += new System.EventHandler(this.Btn3Click);
			// 
			// tmr_cronometro
			// 
			this.tmr_cronometro.Interval = 1000;
			this.tmr_cronometro.Tick += new System.EventHandler(this.Tmr_cronometroTick);
			// 
			// lbl_horas
			// 
			this.lbl_horas.Location = new System.Drawing.Point(226, 184);
			this.lbl_horas.Name = "lbl_horas";
			this.lbl_horas.Size = new System.Drawing.Size(78, 92);
			this.lbl_horas.TabIndex = 3;
			this.lbl_horas.Text = "00";
			// 
			// lbl_minutos
			// 
			this.lbl_minutos.Location = new System.Drawing.Point(310, 184);
			this.lbl_minutos.Name = "lbl_minutos";
			this.lbl_minutos.Size = new System.Drawing.Size(78, 92);
			this.lbl_minutos.TabIndex = 4;
			this.lbl_minutos.Text = "00";
			// 
			// lbl_segundos
			// 
			this.lbl_segundos.Location = new System.Drawing.Point(394, 184);
			this.lbl_segundos.Name = "lbl_segundos";
			this.lbl_segundos.Size = new System.Drawing.Size(78, 92);
			this.lbl_segundos.TabIndex = 5;
			this.lbl_segundos.Text = "00";
			// 
			// lbl_puntos
			// 
			this.lbl_puntos.Location = new System.Drawing.Point(266, 184);
			this.lbl_puntos.Name = "lbl_puntos";
			this.lbl_puntos.Size = new System.Drawing.Size(16, 28);
			this.lbl_puntos.TabIndex = 6;
			this.lbl_puntos.Text = ":";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(357, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = ":";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 622);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_puntos);
			this.Controls.Add(this.lbl_segundos);
			this.Controls.Add(this.lbl_minutos);
			this.Controls.Add(this.lbl_horas);
			this.Controls.Add(this.btn_reiniciar);
			this.Controls.Add(this.btn_detener);
			this.Controls.Add(this.btn_iniciar);
			this.Name = "MainForm";
			this.Text = "contador";
			this.ResumeLayout(false);

		}
	}
}
