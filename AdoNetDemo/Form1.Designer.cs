﻿
namespace AdoNetDemo
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
			this.dgwProducts = new System.Windows.Forms.DataGridView();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.tbxStockAmount = new System.Windows.Forms.TextBox();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblStockAmount = new System.Windows.Forms.Label();
			this.gbxAdd = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
			this.lblStockAmountUpdate = new System.Windows.Forms.Label();
			this.tbxNameUpdate = new System.Windows.Forms.TextBox();
			this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
			this.lblNameUpdate = new System.Windows.Forms.Label();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
			this.gbxAdd.SuspendLayout();
			this.gbxUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProducts
			// 
			this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProducts.Location = new System.Drawing.Point(12, 229);
			this.dgwProducts.Name = "dgwProducts";
			this.dgwProducts.Size = new System.Drawing.Size(776, 209);
			this.dgwProducts.TabIndex = 0;
			this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(111, 23);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(100, 21);
			this.tbxName.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(67, 26);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name:";
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(111, 49);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(100, 21);
			this.tbxUnitPrice.TabIndex = 3;
			// 
			// tbxStockAmount
			// 
			this.tbxStockAmount.Location = new System.Drawing.Point(111, 75);
			this.tbxStockAmount.Name = "tbxStockAmount";
			this.tbxStockAmount.Size = new System.Drawing.Size(100, 21);
			this.tbxStockAmount.TabIndex = 4;
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(49, 52);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
			this.lblUnitPrice.TabIndex = 5;
			this.lblUnitPrice.Text = "Unit Price:";
			// 
			// lblStockAmount
			// 
			this.lblStockAmount.AutoSize = true;
			this.lblStockAmount.Location = new System.Drawing.Point(28, 78);
			this.lblStockAmount.Name = "lblStockAmount";
			this.lblStockAmount.Size = new System.Drawing.Size(77, 13);
			this.lblStockAmount.TabIndex = 6;
			this.lblStockAmount.Text = "Stock Amount:";
			// 
			// gbxAdd
			// 
			this.gbxAdd.Controls.Add(this.btnAdd);
			this.gbxAdd.Controls.Add(this.tbxStockAmount);
			this.gbxAdd.Controls.Add(this.lblStockAmount);
			this.gbxAdd.Controls.Add(this.tbxName);
			this.gbxAdd.Controls.Add(this.lblUnitPrice);
			this.gbxAdd.Controls.Add(this.lblName);
			this.gbxAdd.Controls.Add(this.tbxUnitPrice);
			this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxAdd.Location = new System.Drawing.Point(21, 57);
			this.gbxAdd.Name = "gbxAdd";
			this.gbxAdd.Size = new System.Drawing.Size(261, 151);
			this.gbxAdd.TabIndex = 7;
			this.gbxAdd.TabStop = false;
			this.gbxAdd.Text = "Add a product";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(111, 111);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
			this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
			this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
			this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
			this.gbxUpdate.Controls.Add(this.lblNameUpdate);
			this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
			this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxUpdate.Location = new System.Drawing.Point(311, 57);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(261, 151);
			this.gbxUpdate.TabIndex = 8;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Update a product";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(111, 111);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxStockAmountUpdate
			// 
			this.tbxStockAmountUpdate.Location = new System.Drawing.Point(111, 75);
			this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
			this.tbxStockAmountUpdate.Size = new System.Drawing.Size(100, 21);
			this.tbxStockAmountUpdate.TabIndex = 4;
			// 
			// lblStockAmountUpdate
			// 
			this.lblStockAmountUpdate.AutoSize = true;
			this.lblStockAmountUpdate.Location = new System.Drawing.Point(28, 78);
			this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
			this.lblStockAmountUpdate.Size = new System.Drawing.Size(77, 13);
			this.lblStockAmountUpdate.TabIndex = 6;
			this.lblStockAmountUpdate.Text = "Stock Amount:";
			// 
			// tbxNameUpdate
			// 
			this.tbxNameUpdate.Location = new System.Drawing.Point(111, 23);
			this.tbxNameUpdate.Name = "tbxNameUpdate";
			this.tbxNameUpdate.Size = new System.Drawing.Size(100, 21);
			this.tbxNameUpdate.TabIndex = 1;
			// 
			// lblUnitPriceUpdate
			// 
			this.lblUnitPriceUpdate.AutoSize = true;
			this.lblUnitPriceUpdate.Location = new System.Drawing.Point(49, 52);
			this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
			this.lblUnitPriceUpdate.Size = new System.Drawing.Size(56, 13);
			this.lblUnitPriceUpdate.TabIndex = 5;
			this.lblUnitPriceUpdate.Text = "Unit Price:";
			// 
			// lblNameUpdate
			// 
			this.lblNameUpdate.AutoSize = true;
			this.lblNameUpdate.Location = new System.Drawing.Point(67, 26);
			this.lblNameUpdate.Name = "lblNameUpdate";
			this.lblNameUpdate.Size = new System.Drawing.Size(38, 13);
			this.lblNameUpdate.TabIndex = 2;
			this.lblNameUpdate.Text = "Name:";
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(111, 49);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(100, 21);
			this.tbxUnitPriceUpdate.TabIndex = 3;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(617, 168);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(100, 23);
			this.btnRemove.TabIndex = 9;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.gbxAdd);
			this.Controls.Add(this.dgwProducts);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
			this.gbxAdd.ResumeLayout(false);
			this.gbxAdd.PerformLayout();
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProducts;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox tbxUnitPrice;
		private System.Windows.Forms.TextBox tbxStockAmount;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblStockAmount;
		private System.Windows.Forms.GroupBox gbxAdd;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox gbxUpdate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxStockAmountUpdate;
		private System.Windows.Forms.Label lblStockAmountUpdate;
		private System.Windows.Forms.TextBox tbxNameUpdate;
		private System.Windows.Forms.Label lblUnitPriceUpdate;
		private System.Windows.Forms.Label lblNameUpdate;
		private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
		private System.Windows.Forms.Button btnRemove;
	}
}

