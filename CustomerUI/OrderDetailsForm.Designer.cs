﻿
namespace NorthwindUI
{
    partial class OrderDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.shippingCountryTextBox = new System.Windows.Forms.TextBox();
            this.shippingPostCodeTextBox = new System.Windows.Forms.TextBox();
            this.shippingRegionTextBox = new System.Windows.Forms.TextBox();
            this.shippingCityTextBox = new System.Windows.Forms.TextBox();
            this.shippingAdressTextBox = new System.Windows.Forms.TextBox();
            this.shippingAddressLabel = new System.Windows.Forms.Label();
            this.ShippedDateLabel = new System.Windows.Forms.Label();
            this.shippedDateTextBox = new System.Windows.Forms.TextBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderedDateTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.thisOrderValueLabel = new System.Windows.Forms.Label();
            this.thisOrderValueTextBox = new System.Windows.Forms.TextBox();
            this.allOrdersValueLabel = new System.Windows.Forms.Label();
            this.allOrdersValueTextBox = new System.Windows.Forms.TextBox();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.orderSumLabel = new System.Windows.Forms.Label();
            this.orderSumTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerNameLabel.Location = new System.Drawing.Point(32, 28);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(98, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer";
            // 
            // shippingCountryTextBox
            // 
            this.shippingCountryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingCountryTextBox.Location = new System.Drawing.Point(361, 235);
            this.shippingCountryTextBox.Name = "shippingCountryTextBox";
            this.shippingCountryTextBox.Size = new System.Drawing.Size(186, 29);
            this.shippingCountryTextBox.TabIndex = 1;
            this.shippingCountryTextBox.Text = "Shipping Country";
            // 
            // shippingPostCodeTextBox
            // 
            this.shippingPostCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingPostCodeTextBox.Location = new System.Drawing.Point(362, 198);
            this.shippingPostCodeTextBox.Name = "shippingPostCodeTextBox";
            this.shippingPostCodeTextBox.Size = new System.Drawing.Size(186, 29);
            this.shippingPostCodeTextBox.TabIndex = 1;
            this.shippingPostCodeTextBox.Text = "Shipping Postcode";
            // 
            // shippingRegionTextBox
            // 
            this.shippingRegionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingRegionTextBox.Location = new System.Drawing.Point(362, 161);
            this.shippingRegionTextBox.Name = "shippingRegionTextBox";
            this.shippingRegionTextBox.Size = new System.Drawing.Size(186, 29);
            this.shippingRegionTextBox.TabIndex = 1;
            this.shippingRegionTextBox.Text = "Shipping Region";
            // 
            // shippingCityTextBox
            // 
            this.shippingCityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingCityTextBox.Location = new System.Drawing.Point(362, 124);
            this.shippingCityTextBox.Name = "shippingCityTextBox";
            this.shippingCityTextBox.Size = new System.Drawing.Size(186, 29);
            this.shippingCityTextBox.TabIndex = 1;
            this.shippingCityTextBox.Text = "Shipping City";
            // 
            // shippingAdressTextBox
            // 
            this.shippingAdressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingAdressTextBox.Location = new System.Drawing.Point(361, 87);
            this.shippingAdressTextBox.Name = "shippingAdressTextBox";
            this.shippingAdressTextBox.Size = new System.Drawing.Size(186, 29);
            this.shippingAdressTextBox.TabIndex = 1;
            this.shippingAdressTextBox.Text = "Shipping Address";
            // 
            // shippingAddressLabel
            // 
            this.shippingAddressLabel.AutoSize = true;
            this.shippingAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippingAddressLabel.Location = new System.Drawing.Point(362, 65);
            this.shippingAddressLabel.Name = "shippingAddressLabel";
            this.shippingAddressLabel.Size = new System.Drawing.Size(132, 21);
            this.shippingAddressLabel.TabIndex = 2;
            this.shippingAddressLabel.Text = "Shipping Address";
            // 
            // ShippedDateLabel
            // 
            this.ShippedDateLabel.AutoSize = true;
            this.ShippedDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShippedDateLabel.Location = new System.Drawing.Point(28, 198);
            this.ShippedDateLabel.Name = "ShippedDateLabel";
            this.ShippedDateLabel.Size = new System.Drawing.Size(103, 21);
            this.ShippedDateLabel.TabIndex = 3;
            this.ShippedDateLabel.Text = "Shipped Date";
            // 
            // shippedDateTextBox
            // 
            this.shippedDateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shippedDateTextBox.Location = new System.Drawing.Point(167, 198);
            this.shippedDateTextBox.Name = "shippedDateTextBox";
            this.shippedDateTextBox.Size = new System.Drawing.Size(158, 29);
            this.shippedDateTextBox.TabIndex = 4;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderDateLabel.Location = new System.Drawing.Point(28, 161);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(104, 21);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "Ordered Date";
            // 
            // orderedDateTextBox
            // 
            this.orderedDateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderedDateTextBox.Location = new System.Drawing.Point(167, 161);
            this.orderedDateTextBox.Name = "orderedDateTextBox";
            this.orderedDateTextBox.Size = new System.Drawing.Size(158, 29);
            this.orderedDateTextBox.TabIndex = 4;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeIDLabel.Location = new System.Drawing.Point(28, 124);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(108, 21);
            this.employeeIDLabel.TabIndex = 3;
            this.employeeIDLabel.Text = "Ordered by ID";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeIDTextBox.Location = new System.Drawing.Point(167, 124);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(158, 29);
            this.employeeIDTextBox.TabIndex = 4;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderIDLabel.Location = new System.Drawing.Point(28, 87);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(70, 21);
            this.orderIDLabel.TabIndex = 3;
            this.orderIDLabel.Text = "Order ID";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderIDTextBox.Location = new System.Drawing.Point(167, 87);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(158, 29);
            this.orderIDTextBox.TabIndex = 4;
            // 
            // thisOrderValueLabel
            // 
            this.thisOrderValueLabel.AutoSize = true;
            this.thisOrderValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thisOrderValueLabel.Location = new System.Drawing.Point(28, 235);
            this.thisOrderValueLabel.Name = "thisOrderValueLabel";
            this.thisOrderValueLabel.Size = new System.Drawing.Size(122, 21);
            this.thisOrderValueLabel.TabIndex = 3;
            this.thisOrderValueLabel.Text = "Value, this order";
            // 
            // thisOrderValueTextBox
            // 
            this.thisOrderValueTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thisOrderValueTextBox.Location = new System.Drawing.Point(167, 235);
            this.thisOrderValueTextBox.Name = "thisOrderValueTextBox";
            this.thisOrderValueTextBox.Size = new System.Drawing.Size(158, 29);
            this.thisOrderValueTextBox.TabIndex = 4;
            // 
            // allOrdersValueLabel
            // 
            this.allOrdersValueLabel.AutoSize = true;
            this.allOrdersValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allOrdersValueLabel.Location = new System.Drawing.Point(28, 272);
            this.allOrdersValueLabel.Name = "allOrdersValueLabel";
            this.allOrdersValueLabel.Size = new System.Drawing.Size(120, 21);
            this.allOrdersValueLabel.TabIndex = 3;
            this.allOrdersValueLabel.Text = "Value, all orders";
            // 
            // allOrdersValueTextBox
            // 
            this.allOrdersValueTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allOrdersValueTextBox.Location = new System.Drawing.Point(167, 272);
            this.allOrdersValueTextBox.Name = "allOrdersValueTextBox";
            this.allOrdersValueTextBox.Size = new System.Drawing.Size(158, 29);
            this.allOrdersValueTextBox.TabIndex = 4;
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.AllowUserToAddRows = false;
            this.orderItemsDataGridView.AllowUserToDeleteRows = false;
            this.orderItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(32, 336);
            this.orderItemsDataGridView.MultiSelect = false;
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.ReadOnly = true;
            this.orderItemsDataGridView.RowHeadersVisible = false;
            this.orderItemsDataGridView.RowTemplate.Height = 25;
            this.orderItemsDataGridView.Size = new System.Drawing.Size(756, 206);
            this.orderItemsDataGridView.TabIndex = 5;
            // 
            // orderSumLabel
            // 
            this.orderSumLabel.AutoSize = true;
            this.orderSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderSumLabel.Location = new System.Drawing.Point(559, 547);
            this.orderSumLabel.Name = "orderSumLabel";
            this.orderSumLabel.Size = new System.Drawing.Size(102, 21);
            this.orderSumLabel.TabIndex = 3;
            this.orderSumLabel.Text = "Sum of order";
            // 
            // orderSumTextBox
            // 
            this.orderSumTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderSumTextBox.Location = new System.Drawing.Point(662, 543);
            this.orderSumTextBox.Name = "orderSumTextBox";
            this.orderSumTextBox.Size = new System.Drawing.Size(126, 29);
            this.orderSumTextBox.TabIndex = 4;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.orderItemsDataGridView);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.orderedDateTextBox);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.allOrdersValueTextBox);
            this.Controls.Add(this.allOrdersValueLabel);
            this.Controls.Add(this.orderSumTextBox);
            this.Controls.Add(this.orderSumLabel);
            this.Controls.Add(this.thisOrderValueTextBox);
            this.Controls.Add(this.thisOrderValueLabel);
            this.Controls.Add(this.shippedDateTextBox);
            this.Controls.Add(this.ShippedDateLabel);
            this.Controls.Add(this.shippingAddressLabel);
            this.Controls.Add(this.shippingAdressTextBox);
            this.Controls.Add(this.shippingCityTextBox);
            this.Controls.Add(this.shippingRegionTextBox);
            this.Controls.Add(this.shippingPostCodeTextBox);
            this.Controls.Add(this.shippingCountryTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "OrderDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label shippingAddressLabel;
        private System.Windows.Forms.Label ShippedDateLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label orderIDLabel;
        public System.Windows.Forms.TextBox shippingCountryTextBox;
        public System.Windows.Forms.TextBox shippingPostCodeTextBox;
        public System.Windows.Forms.TextBox shippingRegionTextBox;
        public System.Windows.Forms.TextBox shippingCityTextBox;
        public System.Windows.Forms.TextBox shippingAdressTextBox;
        public System.Windows.Forms.TextBox shippedDateTextBox;
        public System.Windows.Forms.TextBox orderedDateTextBox;
        public System.Windows.Forms.TextBox employeeIDTextBox;
        public System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Label thisOrderValueLabel;
        public System.Windows.Forms.TextBox thisOrderValueTextBox;
        private System.Windows.Forms.Label allOrdersValueLabel;
        public System.Windows.Forms.TextBox allOrdersValueTextBox;
        private System.Windows.Forms.DataGridView orderItemsDataGridView;
        private System.Windows.Forms.Label orderSumLabel;
        public System.Windows.Forms.TextBox orderSumTextBox;
    }
}