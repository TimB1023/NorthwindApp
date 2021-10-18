
namespace NorthwindUI
{
    partial class CustomerForm
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
            this.customersFoundListBox = new System.Windows.Forms.ListBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.enterCustomerNameLabel = new System.Windows.Forms.Label();
            this.searchButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersFoundListBox
            // 
            this.customersFoundListBox.FormattingEnabled = true;
            this.customersFoundListBox.ItemHeight = 25;
            this.customersFoundListBox.Location = new System.Drawing.Point(45, 124);
            this.customersFoundListBox.Name = "customersFoundListBox";
            this.customersFoundListBox.Size = new System.Drawing.Size(168, 304);
            this.customersFoundListBox.TabIndex = 0;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(45, 49);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(168, 33);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // enterCustomerNameLabel
            // 
            this.enterCustomerNameLabel.AutoSize = true;
            this.enterCustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterCustomerNameLabel.Location = new System.Drawing.Point(45, 28);
            this.enterCustomerNameLabel.Name = "enterCustomerNameLabel";
            this.enterCustomerNameLabel.Size = new System.Drawing.Size(164, 21);
            this.enterCustomerNameLabel.TabIndex = 2;
            this.enterCustomerNameLabel.Text = "Enter Customer Name";
            // 
            // searchButtom
            // 
            this.searchButtom.Location = new System.Drawing.Point(45, 89);
            this.searchButtom.Name = "searchButtom";
            this.searchButtom.Size = new System.Drawing.Size(168, 29);
            this.searchButtom.TabIndex = 3;
            this.searchButtom.Text = "Search";
            this.searchButtom.UseVisualStyleBackColor = true;
            this.searchButtom.Click += new System.EventHandler(this.searchButtom_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 451);
            this.Controls.Add(this.searchButtom);
            this.Controls.Add(this.enterCustomerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customersFoundListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NorthWind Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customersFoundListBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label enterCustomerNameLabel;
        private System.Windows.Forms.Button searchButtom;
    }
}

