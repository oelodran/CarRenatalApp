
namespace CarRenatalApp
{
    partial class AddEditRentalRecord
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
            this.labTitle = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.labRented = new System.Windows.Forms.Label();
            this.labReturned = new System.Windows.Forms.Label();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.labTypeOfCar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.labCost = new System.Windows.Forms.Label();
            this.labRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(175, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(472, 64);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Add Rental Record";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(12, 117);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(309, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCustomerName.Location = new System.Drawing.Point(8, 94);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(124, 20);
            this.labCustomerName.TabIndex = 2;
            this.labCustomerName.Text = "Customer Name";
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(12, 210);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(308, 20);
            this.dtRented.TabIndex = 3;
            // 
            // dtReturned
            // 
            this.dtReturned.Location = new System.Drawing.Point(480, 210);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(308, 20);
            this.dtReturned.TabIndex = 4;
            // 
            // labRented
            // 
            this.labRented.AutoSize = true;
            this.labRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRented.Location = new System.Drawing.Point(8, 187);
            this.labRented.Name = "labRented";
            this.labRented.Size = new System.Drawing.Size(101, 20);
            this.labRented.TabIndex = 5;
            this.labRented.Text = "Date Rented";
            // 
            // labReturned
            // 
            this.labReturned.AutoSize = true;
            this.labReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labReturned.Location = new System.Drawing.Point(476, 187);
            this.labReturned.Name = "labReturned";
            this.labReturned.Size = new System.Drawing.Size(115, 20);
            this.labReturned.TabIndex = 6;
            this.labReturned.Text = "Date Returned";
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(12, 295);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(308, 21);
            this.cbTypeOfCar.TabIndex = 7;
            // 
            // labTypeOfCar
            // 
            this.labTypeOfCar.AutoSize = true;
            this.labTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTypeOfCar.Location = new System.Drawing.Point(12, 272);
            this.labTypeOfCar.Name = "labTypeOfCar";
            this.labTypeOfCar.Size = new System.Drawing.Size(93, 20);
            this.labTypeOfCar.TabIndex = 8;
            this.labTypeOfCar.Text = "Type Of Car";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Matura MT Script Capitals", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(479, 117);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(309, 20);
            this.tbCost.TabIndex = 10;
            // 
            // labCost
            // 
            this.labCost.AutoSize = true;
            this.labCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCost.Location = new System.Drawing.Point(476, 94);
            this.labCost.Name = "labCost";
            this.labCost.Size = new System.Drawing.Size(42, 20);
            this.labCost.TabIndex = 11;
            this.labCost.Text = "Cost";
            // 
            // labRecordId
            // 
            this.labRecordId.AutoSize = true;
            this.labRecordId.Location = new System.Drawing.Point(391, 381);
            this.labRecordId.Name = "labRecordId";
            this.labRecordId.Size = new System.Drawing.Size(0, 13);
            this.labRecordId.TabIndex = 12;
            this.labRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labRecordId);
            this.Controls.Add(this.labCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTypeOfCar);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.labReturned);
            this.Controls.Add(this.labRented);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.dtRented);
            this.Controls.Add(this.labCustomerName);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.labTitle);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label labCustomerName;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.Label labRented;
        private System.Windows.Forms.Label labReturned;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label labTypeOfCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label labCost;
        private System.Windows.Forms.Label labRecordId;
    }
}

