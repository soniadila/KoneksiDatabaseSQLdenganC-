/*
 * Created by SharpDevelop.
 * User: User
 * Date: 03/12/2021
 * Time: 22:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tubes_LabSMDB
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ID_KaryawanTextBox = new System.Windows.Forms.TextBox();
			this.Nama_DepanTextBox = new System.Windows.Forms.TextBox();
			this.Nama_BelakangTextBox = new System.Windows.Forms.TextBox();
			this.AlamatTextBox = new System.Windows.Forms.TextBox();
			this.Kode_PosTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.No_TeleponTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.IDKaryawan = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(795, 106);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Menu;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(16, 14);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(761, 79);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(215, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 46);
			this.label1.TabIndex = 1;
			this.label1.Text = "TUBES LAB SMDB";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(12, 124);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(795, 613);
			this.panel3.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.Menu;
			this.panel6.Controls.Add(this.label9);
			this.panel6.Location = new System.Drawing.Point(600, 14);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(177, 78);
			this.panel6.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.label9.Location = new System.Drawing.Point(13, 13);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(147, 50);
			this.label9.TabIndex = 1;
			this.label9.Text = "Button :";
			//this.label9.Click += new System.EventHandler(this.Label9Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Menu;
			this.panel5.Controls.Add(this.button6);
			this.panel5.Controls.Add(this.button4);
			this.panel5.Controls.Add(this.button3);
			this.panel5.Controls.Add(this.button2);
			this.panel5.Controls.Add(this.button1);
			this.panel5.Location = new System.Drawing.Point(600, 100);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(177, 502);
			this.panel5.TabIndex = 1;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(13, 414);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(147, 75);
			this.button6.TabIndex = 5;
			this.button6.Text = "Exit";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(13, 311);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(147, 78);
			this.button4.TabIndex = 3;
			this.button4.Text = "Reset";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(13, 210);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 76);
			this.button3.TabIndex = 2;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(13, 108);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 78);
			this.button2.TabIndex = 1;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(13, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 75);
			this.button1.TabIndex = 0;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Menu;
			this.panel4.Controls.Add(this.ID_KaryawanTextBox);
			this.panel4.Controls.Add(this.Nama_DepanTextBox);
			this.panel4.Controls.Add(this.Nama_BelakangTextBox);
			this.panel4.Controls.Add(this.AlamatTextBox);
			this.panel4.Controls.Add(this.Kode_PosTextBox);
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Controls.Add(this.No_TeleponTextBox);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.IDKaryawan);
			this.panel4.Location = new System.Drawing.Point(16, 14);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(578, 588);
			this.panel4.TabIndex = 0;
			// 
			// ID_KaryawanTextBox
			// 
			this.ID_KaryawanTextBox.Location = new System.Drawing.Point(187, 13);
			this.ID_KaryawanTextBox.Multiline = true;
			this.ID_KaryawanTextBox.Name = "ID_KaryawanTextBox";
			this.ID_KaryawanTextBox.Size = new System.Drawing.Size(373, 28);
			this.ID_KaryawanTextBox.TabIndex = 17;
			// 
			// Nama_DepanTextBox
			// 
			this.Nama_DepanTextBox.Location = new System.Drawing.Point(187, 58);
			this.Nama_DepanTextBox.Multiline = true;
			this.Nama_DepanTextBox.Name = "Nama_DepanTextBox";
			this.Nama_DepanTextBox.Size = new System.Drawing.Size(373, 28);
			this.Nama_DepanTextBox.TabIndex = 16;
			// 
			// Nama_BelakangTextBox
			// 
			this.Nama_BelakangTextBox.Location = new System.Drawing.Point(187, 113);
			this.Nama_BelakangTextBox.Multiline = true;
			this.Nama_BelakangTextBox.Name = "Nama_BelakangTextBox";
			this.Nama_BelakangTextBox.Size = new System.Drawing.Size(373, 28);
			this.Nama_BelakangTextBox.TabIndex = 15;
			// 
			// AlamatTextBox
			// 
			this.AlamatTextBox.Location = new System.Drawing.Point(187, 165);
			this.AlamatTextBox.Multiline = true;
			this.AlamatTextBox.Name = "AlamatTextBox";
			this.AlamatTextBox.Size = new System.Drawing.Size(373, 28);
			this.AlamatTextBox.TabIndex = 14;
			// 
			// Kode_PosTextBox
			// 
			this.Kode_PosTextBox.Location = new System.Drawing.Point(187, 219);
			this.Kode_PosTextBox.Multiline = true;
			this.Kode_PosTextBox.Name = "Kode_PosTextBox";
			this.Kode_PosTextBox.Size = new System.Drawing.Size(373, 28);
			this.Kode_PosTextBox.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 316);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(547, 259);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// No_TeleponTextBox
			// 
			this.No_TeleponTextBox.Location = new System.Drawing.Point(187, 273);
			this.No_TeleponTextBox.Multiline = true;
			this.No_TeleponTextBox.Name = "No_TeleponTextBox";
			this.No_TeleponTextBox.Size = new System.Drawing.Size(373, 28);
			this.No_TeleponTextBox.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 273);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 28);
			this.label7.TabIndex = 10;
			this.label7.Text = "No. Telepon";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Kode Pos";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 28);
			this.label5.TabIndex = 6;
			this.label5.Text = "Alamat";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 28);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nama Belakang";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nama Depan";
			// 
			// IDKaryawan
			// 
			this.IDKaryawan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IDKaryawan.Location = new System.Drawing.Point(13, 13);
			this.IDKaryawan.Name = "IDKaryawan";
			this.IDKaryawan.Size = new System.Drawing.Size(130, 28);
			this.IDKaryawan.TabIndex = 0;
			this.IDKaryawan.Text = "ID Karyawan";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 749);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "tubes_LabSMDB";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label IDKaryawan;
		private System.Windows.Forms.TextBox AlamatTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Nama_BelakangTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Nama_DepanTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ID_KaryawanTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Kode_PosTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox No_TeleponTextBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
