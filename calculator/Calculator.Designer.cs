namespace calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            close = new Button();
            panel2 = new Panel();
            pre = new Label();
            prv = new Label();
            clr = new Button();
            back = new Button();
            prsnt = new Button();
            div = new Button();
            mul = new Button();
            mins = new Button();
            sum = new Button();
            sqrt = new Button();
            calc = new Button();
            num0 = new Button();
            pow = new Button();
            num7 = new Button();
            num9 = new Button();
            num8 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            dot = new Button();
            privvalue = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(close);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 26);
            panel1.TabIndex = 0;
            // 
            // close
            // 
            close.BackColor = Color.OrangeRed;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatAppearance.BorderSize = 0;
            close.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(307, 3);
            close.Name = "close";
            close.Size = new Size(30, 20);
            close.TabIndex = 1;
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(pre);
            panel2.Controls.Add(prv);
            panel2.Cursor = Cursors.IBeam;
            panel2.ForeColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(12, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 68);
            panel2.TabIndex = 1;
            // 
            // pre
            // 
            pre.AutoSize = true;
            pre.FlatStyle = FlatStyle.Flat;
            pre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pre.Location = new Point(8, 30);
            pre.Margin = new Padding(0);
            pre.MaximumSize = new Size(300, 0);
            pre.MinimumSize = new Size(300, 0);
            pre.Name = "pre";
            pre.RightToLeft = RightToLeft.Yes;
            pre.Size = new Size(300, 30);
            pre.TabIndex = 3;
            pre.Text = "00000000000000000000000";
            pre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prv
            // 
            prv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prv.AutoSize = true;
            prv.FlatStyle = FlatStyle.Flat;
            prv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prv.ImageAlign = ContentAlignment.MiddleRight;
            prv.Location = new Point(8, 5);
            prv.MaximumSize = new Size(300, 0);
            prv.MinimumSize = new Size(300, 0);
            prv.Name = "prv";
            prv.Size = new Size(300, 17);
            prv.TabIndex = 2;
            prv.Text = "00000000000000000000000000000000000000000";
            prv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clr
            // 
            clr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clr.BackColor = SystemColors.ActiveBorder;
            clr.Cursor = Cursors.Hand;
            clr.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            clr.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clr.Location = new Point(12, 157);
            clr.Name = "clr";
            clr.Size = new Size(51, 51);
            clr.TabIndex = 2;
            clr.Text = "C";
            clr.UseVisualStyleBackColor = false;
            clr.Click += clr_Click;
            // 
            // back
            // 
            back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            back.BackColor = SystemColors.ActiveBorder;
            back.Cursor = Cursors.Hand;
            back.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            back.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(80, 157);
            back.Name = "back";
            back.Size = new Size(51, 51);
            back.TabIndex = 3;
            back.Text = "<";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // prsnt
            // 
            prsnt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prsnt.BackColor = SystemColors.ActiveBorder;
            prsnt.Cursor = Cursors.Hand;
            prsnt.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            prsnt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prsnt.Location = new Point(148, 157);
            prsnt.Name = "prsnt";
            prsnt.Size = new Size(51, 51);
            prsnt.TabIndex = 4;
            prsnt.Text = "%";
            prsnt.UseVisualStyleBackColor = false;
            prsnt.Click += prsnt_Click;
            // 
            // div
            // 
            div.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            div.BackColor = SystemColors.ActiveBorder;
            div.Cursor = Cursors.Hand;
            div.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            div.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            div.Location = new Point(277, 157);
            div.Name = "div";
            div.Size = new Size(51, 51);
            div.TabIndex = 5;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += div_Click;
            // 
            // mul
            // 
            mul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mul.BackColor = SystemColors.ActiveBorder;
            mul.Cursor = Cursors.Hand;
            mul.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            mul.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mul.Location = new Point(277, 225);
            mul.Name = "mul";
            mul.Size = new Size(51, 51);
            mul.TabIndex = 6;
            mul.Text = "x";
            mul.UseVisualStyleBackColor = false;
            mul.Click += mul_Click;
            // 
            // mins
            // 
            mins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mins.BackColor = SystemColors.ActiveBorder;
            mins.Cursor = Cursors.Hand;
            mins.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            mins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mins.Location = new Point(277, 293);
            mins.Name = "mins";
            mins.Size = new Size(51, 51);
            mins.TabIndex = 7;
            mins.Text = "-";
            mins.UseVisualStyleBackColor = false;
            mins.Click += mins_Click;
            // 
            // sum
            // 
            sum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sum.BackColor = SystemColors.ActiveBorder;
            sum.Cursor = Cursors.Hand;
            sum.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            sum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sum.Location = new Point(277, 363);
            sum.Name = "sum";
            sum.Size = new Size(51, 51);
            sum.TabIndex = 8;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = false;
            sum.Click += sum_Click;
            // 
            // sqrt
            // 
            sqrt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sqrt.BackColor = SystemColors.ButtonHighlight;
            sqrt.Cursor = Cursors.Hand;
            sqrt.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            sqrt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sqrt.Location = new Point(215, 157);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(51, 51);
            sqrt.TabIndex = 9;
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += sqrt_Click;
            // 
            // calc
            // 
            calc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calc.BackColor = SystemColors.ButtonHighlight;
            calc.Cursor = Cursors.Hand;
            calc.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            calc.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calc.Location = new Point(215, 293);
            calc.Name = "calc";
            calc.Size = new Size(51, 121);
            calc.TabIndex = 10;
            calc.Text = "=";
            calc.UseVisualStyleBackColor = false;
            calc.Click += calc_Click;
            // 
            // num0
            // 
            num0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num0.BackColor = SystemColors.ButtonHighlight;
            num0.Cursor = Cursors.Hand;
            num0.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num0.Location = new Point(12, 420);
            num0.Name = "num0";
            num0.Size = new Size(187, 51);
            num0.TabIndex = 11;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = false;
            num0.Click += num0_Click;
            // 
            // pow
            // 
            pow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pow.BackColor = SystemColors.ActiveBorder;
            pow.Cursor = Cursors.Hand;
            pow.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            pow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pow.Location = new Point(215, 225);
            pow.Name = "pow";
            pow.Size = new Size(51, 51);
            pow.TabIndex = 12;
            pow.Text = "^";
            pow.UseVisualStyleBackColor = false;
            pow.Click += pow_Click;
            // 
            // num7
            // 
            num7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num7.BackColor = SystemColors.ButtonFace;
            num7.Cursor = Cursors.Hand;
            num7.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num7.Location = new Point(12, 225);
            num7.Name = "num7";
            num7.Size = new Size(51, 51);
            num7.TabIndex = 13;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += num7_Click;
            // 
            // num9
            // 
            num9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num9.BackColor = SystemColors.ButtonFace;
            num9.Cursor = Cursors.Hand;
            num9.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num9.Location = new Point(148, 225);
            num9.Name = "num9";
            num9.Size = new Size(51, 51);
            num9.TabIndex = 14;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = false;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num8.BackColor = SystemColors.ButtonFace;
            num8.Cursor = Cursors.Hand;
            num8.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num8.Location = new Point(80, 225);
            num8.Name = "num8";
            num8.Size = new Size(51, 51);
            num8.TabIndex = 15;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += num8_Click;
            // 
            // num6
            // 
            num6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num6.BackColor = SystemColors.ButtonFace;
            num6.Cursor = Cursors.Hand;
            num6.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num6.Location = new Point(148, 293);
            num6.Name = "num6";
            num6.Size = new Size(51, 51);
            num6.TabIndex = 16;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = false;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num5.BackColor = SystemColors.ButtonFace;
            num5.Cursor = Cursors.Hand;
            num5.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num5.Location = new Point(80, 293);
            num5.Name = "num5";
            num5.Size = new Size(51, 51);
            num5.TabIndex = 17;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = false;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num4.BackColor = SystemColors.ButtonFace;
            num4.Cursor = Cursors.Hand;
            num4.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num4.Location = new Point(12, 293);
            num4.Name = "num4";
            num4.Size = new Size(51, 51);
            num4.TabIndex = 18;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = false;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num3.BackColor = SystemColors.ButtonFace;
            num3.Cursor = Cursors.Hand;
            num3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num3.Location = new Point(148, 363);
            num3.Name = "num3";
            num3.Size = new Size(51, 51);
            num3.TabIndex = 19;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = false;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num2.BackColor = SystemColors.ButtonFace;
            num2.Cursor = Cursors.Hand;
            num2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2.Location = new Point(80, 363);
            num2.Name = "num2";
            num2.Size = new Size(51, 51);
            num2.TabIndex = 20;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = false;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num1.BackColor = SystemColors.ButtonFace;
            num1.Cursor = Cursors.Hand;
            num1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            num1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1.Location = new Point(12, 363);
            num1.Name = "num1";
            num1.Size = new Size(51, 51);
            num1.TabIndex = 21;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = false;
            num1.Click += num1_Click;
            // 
            // dot
            // 
            dot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dot.BackColor = SystemColors.ButtonHighlight;
            dot.Cursor = Cursors.Hand;
            dot.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            dot.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dot.Location = new Point(215, 420);
            dot.Name = "dot";
            dot.Size = new Size(51, 51);
            dot.TabIndex = 22;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // privvalue
            // 
            privvalue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privvalue.BackColor = SystemColors.ButtonHighlight;
            privvalue.Cursor = Cursors.Hand;
            privvalue.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            privvalue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            privvalue.Location = new Point(277, 420);
            privvalue.Name = "privvalue";
            privvalue.Size = new Size(51, 51);
            privvalue.TabIndex = 23;
            privvalue.Text = "M";
            privvalue.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(340, 497);
            Controls.Add(privvalue);
            Controls.Add(dot);
            Controls.Add(num1);
            Controls.Add(num2);
            Controls.Add(num3);
            Controls.Add(num4);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(num7);
            Controls.Add(pow);
            Controls.Add(num0);
            Controls.Add(calc);
            Controls.Add(sqrt);
            Controls.Add(sum);
            Controls.Add(mins);
            Controls.Add(mul);
            Controls.Add(div);
            Controls.Add(prsnt);
            Controls.Add(back);
            Controls.Add(clr);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculator";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Panel panel2;
        private Label pre;
        private Label prv;
        private Button clr;
        private Button back;
        private Button prsnt;
        private Button div;
        private Button mul;
        private Button mins;
        private Button sum;
        private Button sqrt;
        private Button calc;
        private Button num0;
        private Button pow;
        private Button num7;
        private Button num9;
        private Button num8;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
        private Button dot;
        private Button privvalue;
    }
}
