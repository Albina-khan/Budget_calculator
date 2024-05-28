namespace LoginForm
{
    partial class History
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
            dataGridView1 = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Shipment = new DataGridViewTextBoxColumn();
            Area_Rent = new DataGridViewTextBoxColumn();
            Transport_Rent = new DataGridViewTextBoxColumn();
            Total_Amount = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Duty = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Type, Amount, Shipment, Area_Rent, Transport_Rent, Total_Amount, Quantity, Duty, Date });
            dataGridView1.Location = new Point(-3, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(944, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Shipment
            // 
            Shipment.HeaderText = "Shipment";
            Shipment.Name = "Shipment";
            // 
            // Area_Rent
            // 
            Area_Rent.HeaderText = "Area Rent";
            Area_Rent.Name = "Area_Rent";
            // 
            // Transport_Rent
            // 
            Transport_Rent.HeaderText = "Transport rent";
            Transport_Rent.Name = "Transport_Rent";
            // 
            // Total_Amount
            // 
            Total_Amount.HeaderText = "Total";
            Total_Amount.Name = "Total_Amount";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Duty
            // 
            Duty.HeaderText = "Duty";
            Duty.Name = "Duty";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 450);
            Controls.Add(dataGridView1);
            Name = "History";
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Shipment;
        private DataGridViewTextBoxColumn Area_Rent;
        private DataGridViewTextBoxColumn Transport_Rent;
        private DataGridViewTextBoxColumn Total_Amount;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Duty;
        private DataGridViewTextBoxColumn Date;
    }
}