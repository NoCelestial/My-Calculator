namespace Calculater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnplas = new System.Windows.Forms.Button();
            this.btnmos = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnoffon = new System.Windows.Forms.Button();
            this.btnfloat = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Controls.Add(this.btn2);
            this.pnl1.Controls.Add(this.btn3);
            this.pnl1.Controls.Add(this.btn4);
            this.pnl1.Controls.Add(this.btn5);
            this.pnl1.Controls.Add(this.btn6);
            this.pnl1.Controls.Add(this.btn7);
            this.pnl1.Controls.Add(this.btn8);
            this.pnl1.Controls.Add(this.btn9);
            this.pnl1.Controls.Add(this.btn0);
            this.pnl1.Controls.Add(this.btnce);
            this.pnl1.Controls.Add(this.btnc);
            this.pnl1.Location = new System.Drawing.Point(15, 121);
            this.pnl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(438, 255);
            this.pnl1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(4, 4);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(138, 55);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(150, 4);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(138, 55);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(296, 4);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(138, 55);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(4, 67);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(138, 55);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(150, 67);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(138, 55);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(296, 67);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(138, 55);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(4, 130);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(138, 55);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(150, 130);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(138, 55);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(296, 130);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(138, 55);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(4, 193);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(139, 55);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btn0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // btnce
            // 
            this.btnce.Location = new System.Drawing.Point(151, 193);
            this.btnce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(135, 55);
            this.btnce.TabIndex = 11;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnce.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clear);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(294, 193);
            this.btnc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(135, 55);
            this.btnc.TabIndex = 10;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clear);
            // 
            // btnplas
            // 
            this.btnplas.Location = new System.Drawing.Point(94, 4);
            this.btnplas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnplas.Name = "btnplas";
            this.btnplas.Size = new System.Drawing.Size(82, 51);
            this.btnplas.TabIndex = 1;
            this.btnplas.Text = "+";
            this.btnplas.UseVisualStyleBackColor = true;
            this.btnplas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnplas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnplas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oprator);
            // 
            // btnmos
            // 
            this.btnmos.Location = new System.Drawing.Point(174, 407);
            this.btnmos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmos.Name = "btnmos";
            this.btnmos.Size = new System.Drawing.Size(95, 52);
            this.btnmos.TabIndex = 2;
            this.btnmos.Text = "=";
            this.btnmos.UseVisualStyleBackColor = true;
            this.btnmos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnmos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnmos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnmos_Click);
            // 
            // btnex
            // 
            this.btnex.Location = new System.Drawing.Point(4, 4);
            this.btnex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(82, 51);
            this.btnex.TabIndex = 0;
            this.btnex.Text = "*";
            this.btnex.UseVisualStyleBackColor = true;
            this.btnex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oprator);
            // 
            // btnmin
            // 
            this.btnmin.Location = new System.Drawing.Point(94, 63);
            this.btnmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(82, 51);
            this.btnmin.TabIndex = 3;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnmin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oprator);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(4, 63);
            this.btndiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(82, 51);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btndiv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btndiv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oprator);
            // 
            // pnl2
            // 
            this.pnl2.ColumnCount = 2;
            this.pnl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl2.Controls.Add(this.btnex, 0, 0);
            this.pnl2.Controls.Add(this.btnplas, 1, 0);
            this.pnl2.Controls.Add(this.btndiv, 0, 1);
            this.pnl2.Controls.Add(this.btnmin, 1, 1);
            this.pnl2.Location = new System.Drawing.Point(272, 404);
            this.pnl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl2.Name = "pnl2";
            this.pnl2.RowCount = 2;
            this.pnl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl2.Size = new System.Drawing.Size(180, 118);
            this.pnl2.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(15, 40);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(67, 20);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "Result ::";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(91, 40);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(353, 29);
            this.txtresult.TabIndex = 4;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // btnoffon
            // 
            this.btnoffon.Location = new System.Drawing.Point(25, 407);
            this.btnoffon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnoffon.Name = "btnoffon";
            this.btnoffon.Size = new System.Drawing.Size(141, 111);
            this.btnoffon.TabIndex = 3;
            this.btnoffon.Text = "On";
            this.btnoffon.UseVisualStyleBackColor = true;
            this.btnoffon.Click += new System.EventHandler(this.btnoffon_Click);
            this.btnoffon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            // 
            // btnfloat
            // 
            this.btnfloat.Location = new System.Drawing.Point(174, 466);
            this.btnfloat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfloat.Name = "btnfloat";
            this.btnfloat.Size = new System.Drawing.Size(95, 52);
            this.btnfloat.TabIndex = 1;
            this.btnfloat.Text = ".";
            this.btnfloat.UseVisualStyleBackColor = true;
            this.btnfloat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfun);
            this.btnfloat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyUp);
            this.btnfloat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_func);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 535);
            this.Controls.Add(this.btnfloat);
            this.Controls.Add(this.btnoffon);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnmos);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculater SAH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnplas;
        private System.Windows.Forms.Button btnmos;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.TableLayoutPanel pnl2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnoffon;
        private System.Windows.Forms.Button btnfloat;
    }
}

