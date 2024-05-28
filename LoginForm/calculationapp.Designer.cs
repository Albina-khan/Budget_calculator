namespace LoginForm
{
    partial class calculationapp
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
			dateTimePicker1 = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			type = new TextBox();
			loginBtn = new Button();
			amount = new NumericUpDown();
			shipment = new NumericUpDown();
			duty = new NumericUpDown();
			area = new NumericUpDown();
			transport = new NumericUpDown();
			total = new NumericUpDown();
			save = new Button();
			label8 = new Label();
			label9 = new Label();
			qty = new NumericUpDown();
			label = new Label();
			cost = new NumericUpDown();
			label10 = new Label();
			profit = new NumericUpDown();
			label11 = new Label();
			((System.ComponentModel.ISupportInitialize)amount).BeginInit();
			((System.ComponentModel.ISupportInitialize)shipment).BeginInit();
			((System.ComponentModel.ISupportInitialize)duty).BeginInit();
			((System.ComponentModel.ISupportInitialize)area).BeginInit();
			((System.ComponentModel.ISupportInitialize)transport).BeginInit();
			((System.ComponentModel.ISupportInitialize)total).BeginInit();
			((System.ComponentModel.ISupportInitialize)qty).BeginInit();
			((System.ComponentModel.ISupportInitialize)cost).BeginInit();
			((System.ComponentModel.ISupportInitialize)profit).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(722, 48);
			dateTimePicker1.MinDate = new DateTime(2024, 4, 15, 0, 0, 0, 0);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(200, 23);
			dateTimePicker1.TabIndex = 1;
			dateTimePicker1.Value = new DateTime(2024, 4, 15, 1, 50, 48, 0);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(30, 131);
			label1.Name = "label1";
			label1.Size = new Size(90, 21);
			label1.TabIndex = 2;
			label1.Text = "Item type : ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(30, 235);
			label2.Name = "label2";
			label2.Size = new Size(80, 21);
			label2.TabIndex = 3;
			label2.Text = "Amount : ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(30, 288);
			label3.Name = "label3";
			label3.Size = new Size(149, 21);
			label3.TabIndex = 4;
			label3.Text = "Shipment charges : ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(30, 340);
			label4.Name = "label4";
			label4.Size = new Size(57, 21);
			label4.TabIndex = 5;
			label4.Text = "Duty : ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.Location = new Point(30, 389);
			label5.Name = "label5";
			label5.Size = new Size(85, 21);
			label5.TabIndex = 6;
			label5.Text = "Area rent :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label6.Location = new Point(30, 437);
			label6.Name = "label6";
			label6.Size = new Size(125, 21);
			label6.TabIndex = 7;
			label6.Text = "Transport rent : ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label7.Location = new Point(536, 228);
			label7.Name = "label7";
			label7.Size = new Size(60, 21);
			label7.TabIndex = 8;
			label7.Text = "Total : ";
			// 
			// type
			// 
			type.Location = new Point(237, 129);
			type.Name = "type";
			type.Size = new Size(180, 23);
			type.TabIndex = 9;
			// 
			// loginBtn
			// 
			loginBtn.BackColor = Color.FromArgb(0, 0, 64);
			loginBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			loginBtn.ForeColor = Color.White;
			loginBtn.Location = new Point(30, 539);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(149, 37);
			loginBtn.TabIndex = 16;
			loginBtn.Text = "CALCULATE";
			loginBtn.UseVisualStyleBackColor = false;
			loginBtn.Click += loginBtn_Click;
			// 
			// amount
			// 
			amount.Location = new Point(240, 233);
			amount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			amount.Name = "amount";
			amount.Size = new Size(177, 23);
			amount.TabIndex = 17;
			// 
			// shipment
			// 
			shipment.Location = new Point(240, 286);
			shipment.Name = "shipment";
			shipment.Size = new Size(177, 23);
			shipment.TabIndex = 18;
			// 
			// duty
			// 
			duty.Location = new Point(240, 338);
			duty.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			duty.Name = "duty";
			duty.Size = new Size(177, 23);
			duty.TabIndex = 19;
			// 
			// area
			// 
			area.Location = new Point(240, 387);
			area.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			area.Name = "area";
			area.Size = new Size(177, 23);
			area.TabIndex = 20;
			// 
			// transport
			// 
			transport.Location = new Point(240, 435);
			transport.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			transport.Name = "transport";
			transport.Size = new Size(177, 23);
			transport.TabIndex = 21;
			// 
			// total
			// 
			total.Enabled = false;
			total.Location = new Point(745, 228);
			total.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(177, 23);
			total.TabIndex = 22;
			// 
			// save
			// 
			save.BackColor = Color.FromArgb(0, 0, 64);
			save.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			save.ForeColor = Color.White;
			save.Location = new Point(268, 539);
			save.Name = "save";
			save.Size = new Size(149, 37);
			save.TabIndex = 23;
			save.Text = "SAVE RECORD";
			save.UseVisualStyleBackColor = false;
			save.Click += save_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label8.Location = new Point(722, 26);
			label8.Name = "label8";
			label8.Size = new Size(89, 19);
			label8.TabIndex = 24;
			label8.Text = "Pick a date : ";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label9.Location = new Point(30, 181);
			label9.Name = "label9";
			label9.Size = new Size(82, 21);
			label9.TabIndex = 25;
			label9.Text = "Quantity :";
			// 
			// qty
			// 
			qty.Location = new Point(240, 179);
			qty.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
			qty.Name = "qty";
			qty.Size = new Size(177, 23);
			qty.TabIndex = 26;
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label.Location = new Point(536, 176);
			label.Name = "label";
			label.Size = new Size(166, 21);
			label.TabIndex = 27;
			label.Text = "Selling price per unit :";
			// 
			// cost
			// 
			cost.Enabled = false;
			cost.Location = new Point(745, 174);
			cost.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			cost.Name = "cost";
			cost.ReadOnly = true;
			cost.Size = new Size(177, 23);
			cost.TabIndex = 28;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label10.Location = new Point(536, 127);
			label10.Name = "label10";
			label10.Size = new Size(58, 21);
			label10.TabIndex = 29;
			label10.Text = "profit :";
			// 
			// profit
			// 
			profit.Location = new Point(745, 125);
			profit.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			profit.Name = "profit";
			profit.Size = new Size(177, 23);
			profit.TabIndex = 30;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			label11.Location = new Point(30, 29);
			label11.Name = "label11";
			label11.Size = new Size(224, 42);
			label11.TabIndex = 31;
			label11.Text = "Budget Calculator";
			// 
			// calculationapp
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1051, 669);
			Controls.Add(label11);
			Controls.Add(profit);
			Controls.Add(label10);
			Controls.Add(cost);
			Controls.Add(label);
			Controls.Add(qty);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(save);
			Controls.Add(total);
			Controls.Add(transport);
			Controls.Add(area);
			Controls.Add(duty);
			Controls.Add(shipment);
			Controls.Add(amount);
			Controls.Add(loginBtn);
			Controls.Add(type);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dateTimePicker1);
			Name = "calculationapp";
			Text = "calculationapp";
			((System.ComponentModel.ISupportInitialize)amount).EndInit();
			((System.ComponentModel.ISupportInitialize)shipment).EndInit();
			((System.ComponentModel.ISupportInitialize)duty).EndInit();
			((System.ComponentModel.ISupportInitialize)area).EndInit();
			((System.ComponentModel.ISupportInitialize)transport).EndInit();
			((System.ComponentModel.ISupportInitialize)total).EndInit();
			((System.ComponentModel.ISupportInitialize)qty).EndInit();
			((System.ComponentModel.ISupportInitialize)cost).EndInit();
			((System.ComponentModel.ISupportInitialize)profit).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox type;
        private Button loginBtn;
        private NumericUpDown amount;
        private NumericUpDown shipment;
        private NumericUpDown duty;
        private NumericUpDown area;
        private NumericUpDown transport;
        private NumericUpDown total;
        private Button save;
        private Label label8;
        private Label label9;
        private NumericUpDown qty;
        private Label label;
        private NumericUpDown cost;
        private Label label10;
        private NumericUpDown profit;
		private Label label11;
	}
}