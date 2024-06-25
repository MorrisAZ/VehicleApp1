namespace VehicleApp
{
    partial class frmVehicles
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
            this.grpVehicleInformation = new System.Windows.Forms.GroupBox();
            this.grbBike = new System.Windows.Forms.GroupBox();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.nrudTireSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnBicycle = new System.Windows.Forms.RadioButton();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.nrudPassenger = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.grpVehicleInformation.SuspendLayout();
            this.grbBike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVehicleInformation
            // 
            this.grpVehicleInformation.Controls.Add(this.grbBike);
            this.grpVehicleInformation.Controls.Add(this.groupBox4);
            this.grpVehicleInformation.Controls.Add(this.grbCar);
            this.grpVehicleInformation.Controls.Add(this.txtStore);
            this.grpVehicleInformation.Controls.Add(this.txtWarranty);
            this.grpVehicleInformation.Controls.Add(this.txtPrice);
            this.grpVehicleInformation.Controls.Add(this.txtBrand);
            this.grpVehicleInformation.Controls.Add(this.txtName);
            this.grpVehicleInformation.Controls.Add(this.label5);
            this.grpVehicleInformation.Controls.Add(this.label3);
            this.grpVehicleInformation.Controls.Add(this.label4);
            this.grpVehicleInformation.Controls.Add(this.label2);
            this.grpVehicleInformation.Controls.Add(this.label1);
            this.grpVehicleInformation.Location = new System.Drawing.Point(9, 10);
            this.grpVehicleInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpVehicleInformation.Name = "grpVehicleInformation";
            this.grpVehicleInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpVehicleInformation.Size = new System.Drawing.Size(582, 305);
            this.grpVehicleInformation.TabIndex = 0;
            this.grpVehicleInformation.TabStop = false;
            this.grpVehicleInformation.Text = "Vehicle Information";
            // 
            // grbBike
            // 
            this.grbBike.Controls.Add(this.cboTerrain);
            this.grbBike.Controls.Add(this.nrudTireSize);
            this.grbBike.Controls.Add(this.label9);
            this.grbBike.Controls.Add(this.label8);
            this.grbBike.Enabled = false;
            this.grbBike.Location = new System.Drawing.Point(230, 160);
            this.grbBike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbBike.Name = "grbBike";
            this.grbBike.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbBike.Size = new System.Drawing.Size(150, 115);
            this.grbBike.TabIndex = 10;
            this.grbBike.TabStop = false;
            this.grbBike.Text = "For Bikes";
            // 
            // cboTerrain
            // 
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Items.AddRange(new object[] {
            "Paved",
            "Unpaved"});
            this.cboTerrain.Location = new System.Drawing.Point(60, 72);
            this.cboTerrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(81, 21);
            this.cboTerrain.TabIndex = 4;
            // 
            // nrudTireSize
            // 
            this.nrudTireSize.Location = new System.Drawing.Point(76, 31);
            this.nrudTireSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nrudTireSize.Name = "nrudTireSize";
            this.nrudTireSize.Size = new System.Drawing.Size(64, 20);
            this.nrudTireSize.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Terrain:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tire Size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnBicycle);
            this.groupBox4.Controls.Add(this.rbtnCar);
            this.groupBox4.Location = new System.Drawing.Point(421, 27);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(150, 115);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of Vehicle";
            // 
            // rbtnBicycle
            // 
            this.rbtnBicycle.AutoSize = true;
            this.rbtnBicycle.Location = new System.Drawing.Point(36, 76);
            this.rbtnBicycle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnBicycle.Name = "rbtnBicycle";
            this.rbtnBicycle.Size = new System.Drawing.Size(59, 17);
            this.rbtnBicycle.TabIndex = 1;
            this.rbtnBicycle.Text = "Bicycle";
            this.rbtnBicycle.UseVisualStyleBackColor = true;
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Checked = true;
            this.rbtnCar.Location = new System.Drawing.Point(36, 36);
            this.rbtnCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(41, 17);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.rbtnCar_CheckedChanged);
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.cboFuel);
            this.grbCar.Controls.Add(this.nrudPassenger);
            this.grbCar.Controls.Add(this.label7);
            this.grbCar.Controls.Add(this.label6);
            this.grbCar.Location = new System.Drawing.Point(230, 29);
            this.grbCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCar.Name = "grbCar";
            this.grbCar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCar.Size = new System.Drawing.Size(150, 115);
            this.grbCar.TabIndex = 11;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "For Cars";
            // 
            // cboFuel
            // 
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.cboFuel.Location = new System.Drawing.Point(60, 72);
            this.cboFuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(80, 21);
            this.cboFuel.TabIndex = 3;
            // 
            // nrudPassenger
            // 
            this.nrudPassenger.Location = new System.Drawing.Point(76, 32);
            this.nrudPassenger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nrudPassenger.Name = "nrudPassenger";
            this.nrudPassenger.Size = new System.Drawing.Size(64, 20);
            this.nrudPassenger.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fuel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passengers:";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(103, 244);
            this.txtStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(76, 20);
            this.txtStore.TabIndex = 9;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(103, 187);
            this.txtWarranty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(76, 20);
            this.txtWarranty.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 132);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(103, 83);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(76, 20);
            this.txtBrand.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Store:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Warranty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(492, 325);
            this.btnCreateVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(98, 33);
            this.btnCreateVehicle.TabIndex = 1;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.grpVehicleInformation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehicles";
            this.Text = "Vehicles";
            this.grpVehicleInformation.ResumeLayout(false);
            this.grpVehicleInformation.PerformLayout();
            this.grbBike.ResumeLayout(false);
            this.grbBike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassenger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicleInformation;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbBike;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grbCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.NumericUpDown nrudTireSize;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.NumericUpDown nrudPassenger;
        private System.Windows.Forms.RadioButton rbtnBicycle;
        private System.Windows.Forms.RadioButton rbtnCar;
    }
}

