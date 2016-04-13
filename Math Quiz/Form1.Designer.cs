namespace Math_Quiz {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.timeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.plusLeftLabel = new System.Windows.Forms.Label();
			this.plusSign = new System.Windows.Forms.Label();
			this.plusRightLabel = new System.Windows.Forms.Label();
			this.equalsOne = new System.Windows.Forms.Label();
			this.EqualsTwo = new System.Windows.Forms.Label();
			this.minusRightLabel = new System.Windows.Forms.Label();
			this.minusLabel = new System.Windows.Forms.Label();
			this.minusLeftLabel = new System.Windows.Forms.Label();
			this.equalsFour = new System.Windows.Forms.Label();
			this.divRightLabel = new System.Windows.Forms.Label();
			this.divLabel = new System.Windows.Forms.Label();
			this.divLeftLabel = new System.Windows.Forms.Label();
			this.equalsThree = new System.Windows.Forms.Label();
			this.multRightLabel = new System.Windows.Forms.Label();
			this.multLabel = new System.Windows.Forms.Label();
			this.multLeftLabel = new System.Windows.Forms.Label();
			this.sum = new System.Windows.Forms.NumericUpDown();
			this.difference = new System.Windows.Forms.NumericUpDown();
			this.quotient = new System.Windows.Forms.NumericUpDown();
			this.product = new System.Windows.Forms.NumericUpDown();
			this.startButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
			this.SuspendLayout();
			// 
			// timeLabel
			// 
			this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.timeLabel.AutoSize = true;
			this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(567, 9);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(2, 27);
			this.timeLabel.TabIndex = 0;
			this.timeLabel.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(388, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Time left:";
			// 
			// plusLeftLabel
			// 
			this.plusLeftLabel.AutoSize = true;
			this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plusLeftLabel.Location = new System.Drawing.Point(57, 106);
			this.plusLeftLabel.Name = "plusLeftLabel";
			this.plusLeftLabel.Size = new System.Drawing.Size(42, 46);
			this.plusLeftLabel.TabIndex = 2;
			this.plusLeftLabel.Text = "?";
			// 
			// plusSign
			// 
			this.plusSign.AutoSize = true;
			this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plusSign.Location = new System.Drawing.Point(197, 106);
			this.plusSign.Name = "plusSign";
			this.plusSign.Size = new System.Drawing.Size(43, 46);
			this.plusSign.TabIndex = 3;
			this.plusSign.Text = "+";
			// 
			// plusRightLabel
			// 
			this.plusRightLabel.AutoSize = true;
			this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plusRightLabel.Location = new System.Drawing.Point(339, 106);
			this.plusRightLabel.Name = "plusRightLabel";
			this.plusRightLabel.Size = new System.Drawing.Size(42, 46);
			this.plusRightLabel.TabIndex = 4;
			this.plusRightLabel.Text = "?";
			// 
			// equalsOne
			// 
			this.equalsOne.AutoSize = true;
			this.equalsOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalsOne.Location = new System.Drawing.Point(480, 106);
			this.equalsOne.Name = "equalsOne";
			this.equalsOne.Size = new System.Drawing.Size(43, 46);
			this.equalsOne.TabIndex = 5;
			this.equalsOne.Text = "=";
			// 
			// EqualsTwo
			// 
			this.EqualsTwo.AutoSize = true;
			this.EqualsTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EqualsTwo.Location = new System.Drawing.Point(480, 236);
			this.EqualsTwo.Name = "EqualsTwo";
			this.EqualsTwo.Size = new System.Drawing.Size(43, 46);
			this.EqualsTwo.TabIndex = 9;
			this.EqualsTwo.Text = "=";
			// 
			// minusRightLabel
			// 
			this.minusRightLabel.AutoSize = true;
			this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minusRightLabel.Location = new System.Drawing.Point(339, 236);
			this.minusRightLabel.Name = "minusRightLabel";
			this.minusRightLabel.Size = new System.Drawing.Size(42, 46);
			this.minusRightLabel.TabIndex = 8;
			this.minusRightLabel.Text = "?";
			// 
			// minusLabel
			// 
			this.minusLabel.AutoSize = true;
			this.minusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minusLabel.Location = new System.Drawing.Point(197, 236);
			this.minusLabel.Name = "minusLabel";
			this.minusLabel.Size = new System.Drawing.Size(33, 46);
			this.minusLabel.TabIndex = 7;
			this.minusLabel.Text = "-";
			// 
			// minusLeftLabel
			// 
			this.minusLeftLabel.AutoSize = true;
			this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minusLeftLabel.Location = new System.Drawing.Point(57, 236);
			this.minusLeftLabel.Name = "minusLeftLabel";
			this.minusLeftLabel.Size = new System.Drawing.Size(42, 46);
			this.minusLeftLabel.TabIndex = 6;
			this.minusLeftLabel.Text = "?";
			// 
			// equalsFour
			// 
			this.equalsFour.AutoSize = true;
			this.equalsFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalsFour.Location = new System.Drawing.Point(480, 502);
			this.equalsFour.Name = "equalsFour";
			this.equalsFour.Size = new System.Drawing.Size(43, 46);
			this.equalsFour.TabIndex = 17;
			this.equalsFour.Text = "=";
			// 
			// divRightLabel
			// 
			this.divRightLabel.AutoSize = true;
			this.divRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divRightLabel.Location = new System.Drawing.Point(339, 502);
			this.divRightLabel.Name = "divRightLabel";
			this.divRightLabel.Size = new System.Drawing.Size(42, 46);
			this.divRightLabel.TabIndex = 16;
			this.divRightLabel.Text = "?";
			// 
			// divLabel
			// 
			this.divLabel.AutoSize = true;
			this.divLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divLabel.Location = new System.Drawing.Point(197, 502);
			this.divLabel.Name = "divLabel";
			this.divLabel.Size = new System.Drawing.Size(31, 46);
			this.divLabel.TabIndex = 15;
			this.divLabel.Text = "/";
			// 
			// divLeftLabel
			// 
			this.divLeftLabel.AutoSize = true;
			this.divLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divLeftLabel.Location = new System.Drawing.Point(57, 502);
			this.divLeftLabel.Name = "divLeftLabel";
			this.divLeftLabel.Size = new System.Drawing.Size(42, 46);
			this.divLeftLabel.TabIndex = 14;
			this.divLeftLabel.Text = "?";
			// 
			// equalsThree
			// 
			this.equalsThree.AutoSize = true;
			this.equalsThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalsThree.Location = new System.Drawing.Point(480, 372);
			this.equalsThree.Name = "equalsThree";
			this.equalsThree.Size = new System.Drawing.Size(43, 46);
			this.equalsThree.TabIndex = 13;
			this.equalsThree.Text = "=";
			// 
			// multRightLabel
			// 
			this.multRightLabel.AutoSize = true;
			this.multRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multRightLabel.Location = new System.Drawing.Point(339, 372);
			this.multRightLabel.Name = "multRightLabel";
			this.multRightLabel.Size = new System.Drawing.Size(42, 46);
			this.multRightLabel.TabIndex = 12;
			this.multRightLabel.Text = "?";
			// 
			// multLabel
			// 
			this.multLabel.AutoSize = true;
			this.multLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multLabel.Location = new System.Drawing.Point(197, 372);
			this.multLabel.Name = "multLabel";
			this.multLabel.Size = new System.Drawing.Size(41, 46);
			this.multLabel.TabIndex = 11;
			this.multLabel.Text = "x";
			// 
			// multLeftLabel
			// 
			this.multLeftLabel.AutoSize = true;
			this.multLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multLeftLabel.Location = new System.Drawing.Point(57, 372);
			this.multLeftLabel.Name = "multLeftLabel";
			this.multLeftLabel.Size = new System.Drawing.Size(42, 46);
			this.multLeftLabel.TabIndex = 10;
			this.multLeftLabel.Text = "?";
			// 
			// sum
			// 
			this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sum.Location = new System.Drawing.Point(566, 106);
			this.sum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.sum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.sum.Name = "sum";
			this.sum.Size = new System.Drawing.Size(180, 48);
			this.sum.TabIndex = 2;
			this.sum.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// difference
			// 
			this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.difference.Location = new System.Drawing.Point(566, 238);
			this.difference.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.difference.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.difference.Name = "difference";
			this.difference.Size = new System.Drawing.Size(180, 48);
			this.difference.TabIndex = 3;
			this.difference.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// quotient
			// 
			this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quotient.Location = new System.Drawing.Point(566, 502);
			this.quotient.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.quotient.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.quotient.Name = "quotient";
			this.quotient.Size = new System.Drawing.Size(180, 48);
			this.quotient.TabIndex = 5;
			this.quotient.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// product
			// 
			this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.product.Location = new System.Drawing.Point(566, 370);
			this.product.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.product.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.product.Name = "product";
			this.product.Size = new System.Drawing.Size(180, 48);
			this.product.TabIndex = 4;
			this.product.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// startButton
			// 
			this.startButton.AutoSize = true;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(317, 612);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(206, 42);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start the Quiz!";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 701);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.quotient);
			this.Controls.Add(this.product);
			this.Controls.Add(this.difference);
			this.Controls.Add(this.sum);
			this.Controls.Add(this.equalsFour);
			this.Controls.Add(this.divRightLabel);
			this.Controls.Add(this.divLabel);
			this.Controls.Add(this.divLeftLabel);
			this.Controls.Add(this.equalsThree);
			this.Controls.Add(this.multRightLabel);
			this.Controls.Add(this.multLabel);
			this.Controls.Add(this.multLeftLabel);
			this.Controls.Add(this.EqualsTwo);
			this.Controls.Add(this.minusRightLabel);
			this.Controls.Add(this.minusLabel);
			this.Controls.Add(this.minusLeftLabel);
			this.Controls.Add(this.equalsOne);
			this.Controls.Add(this.plusRightLabel);
			this.Controls.Add(this.plusSign);
			this.Controls.Add(this.plusLeftLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.timeLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Math Quiz";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DoubleClick += new System.EventHandler(this.answer_Enter);
			this.Enter += new System.EventHandler(this.answer_Enter);
			((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label plusLeftLabel;
		private System.Windows.Forms.Label plusSign;
		private System.Windows.Forms.Label plusRightLabel;
		private System.Windows.Forms.Label equalsOne;
		private System.Windows.Forms.Label EqualsTwo;
		private System.Windows.Forms.Label minusRightLabel;
		private System.Windows.Forms.Label minusLabel;
		private System.Windows.Forms.Label minusLeftLabel;
		private System.Windows.Forms.Label equalsFour;
		private System.Windows.Forms.Label divRightLabel;
		private System.Windows.Forms.Label divLabel;
		private System.Windows.Forms.Label divLeftLabel;
		private System.Windows.Forms.Label equalsThree;
		private System.Windows.Forms.Label multRightLabel;
		private System.Windows.Forms.Label multLabel;
		private System.Windows.Forms.Label multLeftLabel;
		private System.Windows.Forms.NumericUpDown sum;
		private System.Windows.Forms.NumericUpDown difference;
		private System.Windows.Forms.NumericUpDown quotient;
		private System.Windows.Forms.NumericUpDown product;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Timer timer1;
	}
}

