
namespace Final
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
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(228, 161);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(324, 22);
			this.txtUsuario.TabIndex = 0;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(228, 232);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(324, 22);
			this.txtContraseña.TabIndex = 1;
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.SystemColors.Desktop;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
			this.lblUsuario.Location = new System.Drawing.Point(228, 140);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(122, 18);
			this.lblUsuario.TabIndex = 2;
			this.lblUsuario.Text = "Usuario:";
			// 
			// lblContraseña
			// 
			this.lblContraseña.BackColor = System.Drawing.SystemColors.Desktop;
			this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContraseña.ForeColor = System.Drawing.SystemColors.Control;
			this.lblContraseña.Location = new System.Drawing.Point(228, 211);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(122, 18);
			this.lblContraseña.TabIndex = 3;
			this.lblContraseña.Text = "Contraseña";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 279);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 27);
			this.button1.TabIndex = 4;
			this.button1.Text = "&Ingresar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(320, 327);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 26);
			this.button2.TabIndex = 5;
			this.button2.Text = "Acceso";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(766, 478);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.Name = "MainForm";
			this.Text = "Final";
			this.TransparencyKey = System.Drawing.Color.White;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
	}
}
