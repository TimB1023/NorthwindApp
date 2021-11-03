
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customersFoundListBox = new System.Windows.Forms.ListBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.enterCustomerNameLabel = new System.Windows.Forms.Label();
            this.resultsListBoxLabel = new System.Windows.Forms.Label();
            this.customerNameHeading = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.ordersToDateSQLLabel = new System.Windows.Forms.Label();
            this.ordersToDateSQLTextBox = new System.Windows.Forms.TextBox();
            this.ordersToDateCalcLabel = new System.Windows.Forms.Label();
            this.ordersToDateCalcTextBox = new System.Windows.Forms.TextBox();
            this.ordersListLabel = new System.Windows.Forms.Label();
            this.selectedCustomerLabelOrders = new System.Windows.Forms.Label();
            this.ordersListCustomerLabel = new System.Windows.Forms.Label();
            this.earliestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.latestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDateFilterLabel = new System.Windows.Forms.Label();
            this.clearFiltersBbutton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersFoundListBox
            // 
            this.customersFoundListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersFoundListBox.FormattingEnabled = true;
            this.customersFoundListBox.ItemHeight = 21;
            this.customersFoundListBox.Location = new System.Drawing.Point(45, 124);
            this.customersFoundListBox.Name = "customersFoundListBox";
            this.customersFoundListBox.Size = new System.Drawing.Size(291, 298);
            this.customersFoundListBox.TabIndex = 1;
            this.customersFoundListBox.SelectedValueChanged += new System.EventHandler(this.CustomersFoundListBox_SelectedItemChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(45, 49);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(291, 33);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // enterCustomerNameLabel
            // 
            this.enterCustomerNameLabel.AutoSize = true;
            this.enterCustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterCustomerNameLabel.Location = new System.Drawing.Point(45, 28);
            this.enterCustomerNameLabel.Name = "enterCustomerNameLabel";
            this.enterCustomerNameLabel.Size = new System.Drawing.Size(228, 21);
            this.enterCustomerNameLabel.TabIndex = 2;
            this.enterCustomerNameLabel.Text = "Enter customer name to search:";
            // 
            // resultsListBoxLabel
            // 
            this.resultsListBoxLabel.AutoSize = true;
            this.resultsListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsListBoxLabel.Location = new System.Drawing.Point(45, 100);
            this.resultsListBoxLabel.Name = "resultsListBoxLabel";
            this.resultsListBoxLabel.Size = new System.Drawing.Size(196, 21);
            this.resultsListBoxLabel.TabIndex = 2;
            this.resultsListBoxLabel.Text = "Select customer for details:";
            // 
            // customerNameHeading
            // 
            this.customerNameHeading.AutoSize = true;
            this.customerNameHeading.Location = new System.Drawing.Point(409, 37);
            this.customerNameHeading.Name = "customerNameHeading";
            this.customerNameHeading.Size = new System.Drawing.Size(169, 25);
            this.customerNameHeading.TabIndex = 3;
            this.customerNameHeading.Text = "Selected Customer";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactLabel.Location = new System.Drawing.Point(409, 103);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(63, 21);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Contact";
            this.contactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactTextBox.Location = new System.Drawing.Point(560, 100);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(289, 29);
            this.contactTextBox.TabIndex = 2;
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactTitleTextBox.Location = new System.Drawing.Point(560, 133);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(289, 29);
            this.contactTitleTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(409, 218);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 21);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTextBox.Location = new System.Drawing.Point(560, 215);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(289, 29);
            this.addressTextBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(409, 257);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 21);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityTextBox.Location = new System.Drawing.Point(560, 254);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(289, 29);
            this.cityTextBox.TabIndex = 6;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionLabel.Location = new System.Drawing.Point(409, 296);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(59, 21);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Region";
            this.regionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regionTextBox
            // 
            this.regionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionTextBox.Location = new System.Drawing.Point(560, 293);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(289, 29);
            this.regionTextBox.TabIndex = 7;
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postcodeLabel.Location = new System.Drawing.Point(409, 335);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(72, 21);
            this.postcodeLabel.TabIndex = 4;
            this.postcodeLabel.Text = "Postcode";
            this.postcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postcodeTextBox.Location = new System.Drawing.Point(560, 332);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(289, 29);
            this.postcodeTextBox.TabIndex = 8;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(409, 374);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(66, 21);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Country";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryTextBox.Location = new System.Drawing.Point(560, 371);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(289, 29);
            this.countryTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(409, 178);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 21);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(560, 175);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(289, 29);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // ordersToDateSQLLabel
            // 
            this.ordersToDateSQLLabel.AutoSize = true;
            this.ordersToDateSQLLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersToDateSQLLabel.Location = new System.Drawing.Point(409, 409);
            this.ordersToDateSQLLabel.Name = "ordersToDateSQLLabel";
            this.ordersToDateSQLLabel.Size = new System.Drawing.Size(101, 21);
            this.ordersToDateSQLLabel.TabIndex = 4;
            this.ordersToDateSQLLabel.Text = "Orders (SQL)";
            this.ordersToDateSQLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ordersToDateSQLTextBox
            // 
            this.ordersToDateSQLTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersToDateSQLTextBox.Location = new System.Drawing.Point(560, 406);
            this.ordersToDateSQLTextBox.Name = "ordersToDateSQLTextBox";
            this.ordersToDateSQLTextBox.Size = new System.Drawing.Size(289, 29);
            this.ordersToDateSQLTextBox.TabIndex = 10;
            // 
            // ordersToDateCalcLabel
            // 
            this.ordersToDateCalcLabel.AutoSize = true;
            this.ordersToDateCalcLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersToDateCalcLabel.Location = new System.Drawing.Point(409, 444);
            this.ordersToDateCalcLabel.Name = "ordersToDateCalcLabel";
            this.ordersToDateCalcLabel.Size = new System.Drawing.Size(98, 21);
            this.ordersToDateCalcLabel.TabIndex = 4;
            this.ordersToDateCalcLabel.Text = "Orders (calc)";
            this.ordersToDateCalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ordersToDateCalcTextBox
            // 
            this.ordersToDateCalcTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersToDateCalcTextBox.Location = new System.Drawing.Point(560, 441);
            this.ordersToDateCalcTextBox.Name = "ordersToDateCalcTextBox";
            this.ordersToDateCalcTextBox.Size = new System.Drawing.Size(289, 29);
            this.ordersToDateCalcTextBox.TabIndex = 11;
            // 
            // ordersListLabel
            // 
            this.ordersListLabel.AutoSize = true;
            this.ordersListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersListLabel.Location = new System.Drawing.Point(45, 521);
            this.ordersListLabel.Name = "ordersListLabel";
            this.ordersListLabel.Size = new System.Drawing.Size(79, 21);
            this.ordersListLabel.TabIndex = 2;
            this.ordersListLabel.Text = "Orders by";
            // 
            // selectedCustomerLabelOrders
            // 
            this.selectedCustomerLabelOrders.AutoSize = true;
            this.selectedCustomerLabelOrders.Location = new System.Drawing.Point(130, 496);
            this.selectedCustomerLabelOrders.Name = "selectedCustomerLabelOrders";
            this.selectedCustomerLabelOrders.Size = new System.Drawing.Size(0, 25);
            this.selectedCustomerLabelOrders.TabIndex = 3;
            // 
            // ordersListCustomerLabel
            // 
            this.ordersListCustomerLabel.AutoSize = true;
            this.ordersListCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersListCustomerLabel.Location = new System.Drawing.Point(117, 521);
            this.ordersListCustomerLabel.Name = "ordersListCustomerLabel";
            this.ordersListCustomerLabel.Size = new System.Drawing.Size(140, 21);
            this.ordersListCustomerLabel.TabIndex = 3;
            this.ordersListCustomerLabel.Text = "Selected Customer";
            // 
            // earliestDatePicker
            // 
            this.earliestDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earliestDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earliestDatePicker.Location = new System.Drawing.Point(560, 522);
            this.earliestDatePicker.Name = "earliestDatePicker";
            this.earliestDatePicker.Size = new System.Drawing.Size(139, 25);
            this.earliestDatePicker.TabIndex = 8;
            this.earliestDatePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.earliestDatePicker.ValueChanged += new System.EventHandler(this.EarliestDatePicker_ValueChanged);
            // 
            // latestDatePicker
            // 
            this.latestDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latestDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latestDatePicker.Location = new System.Drawing.Point(705, 521);
            this.latestDatePicker.Name = "latestDatePicker";
            this.latestDatePicker.Size = new System.Drawing.Size(144, 25);
            this.latestDatePicker.TabIndex = 7;
            this.latestDatePicker.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.latestDatePicker.ValueChanged += new System.EventHandler(this.LatestDatePicker_ValueChanged);
            // 
            // orderDateFilterLabel
            // 
            this.orderDateFilterLabel.AutoSize = true;
            this.orderDateFilterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderDateFilterLabel.Location = new System.Drawing.Point(409, 521);
            this.orderDateFilterLabel.Name = "orderDateFilterLabel";
            this.orderDateFilterLabel.Size = new System.Drawing.Size(145, 21);
            this.orderDateFilterLabel.TabIndex = 8;
            this.orderDateFilterLabel.Text = "Filter by order date:";
            // 
            // clearFiltersBbutton
            // 
            this.clearFiltersBbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearFiltersBbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearFiltersBbutton.Location = new System.Drawing.Point(856, 521);
            this.clearFiltersBbutton.Name = "clearFiltersBbutton";
            this.clearFiltersBbutton.Size = new System.Drawing.Size(22, 23);
            this.clearFiltersBbutton.TabIndex = 8;
            this.clearFiltersBbutton.Text = "x";
            this.clearFiltersBbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearFiltersBbutton.UseVisualStyleBackColor = true;
            this.clearFiltersBbutton.Click += new System.EventHandler(this.ClearFiltersBbutton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ordersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordersDataGridView.EnableHeadersVisualStyles = false;
            this.ordersDataGridView.Location = new System.Drawing.Point(45, 553);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ordersDataGridView.RowTemplate.Height = 25;
            this.ordersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(804, 291);
            this.ordersDataGridView.TabIndex = 2;
            this.ordersDataGridView.DoubleClick += new System.EventHandler(this.OrdersDataGridView_DoubleClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 856);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.clearFiltersBbutton);
            this.Controls.Add(this.orderDateFilterLabel);
            this.Controls.Add(this.latestDatePicker);
            this.Controls.Add(this.earliestDatePicker);
            this.Controls.Add(this.contactTitleTextBox);
            this.Controls.Add(this.ordersToDateCalcTextBox);
            this.Controls.Add(this.ordersToDateCalcLabel);
            this.Controls.Add(this.ordersToDateSQLTextBox);
            this.Controls.Add(this.ordersToDateSQLLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(this.postcodeLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.selectedCustomerLabelOrders);
            this.Controls.Add(this.ordersListCustomerLabel);
            this.Controls.Add(this.customerNameHeading);
            this.Controls.Add(this.resultsListBoxLabel);
            this.Controls.Add(this.ordersListLabel);
            this.Controls.Add(this.enterCustomerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customersFoundListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NorthWind Customers";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customersFoundListBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label enterCustomerNameLabel;
        private System.Windows.Forms.Label resultsListBoxLabel;
        private System.Windows.Forms.Label customerNameHeading;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label ordersToDateSQLLabel;
        private System.Windows.Forms.TextBox ordersToDateSQLTextBox;
        private System.Windows.Forms.Label ordersToDateCalcLabel;
        private System.Windows.Forms.TextBox ordersToDateCalcTextBox;
        private System.Windows.Forms.Label ordersListLabel;
        private System.Windows.Forms.Label selectedCustomerLabelOrders;
        private System.Windows.Forms.Label ordersListCustomerLabel;
        private System.Windows.Forms.DateTimePicker earliestDatePicker;
        private System.Windows.Forms.DateTimePicker latestDatePicker;
        private System.Windows.Forms.Label orderDateFilterLabel;
        private System.Windows.Forms.Button clearFiltersBbutton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
    }
}

