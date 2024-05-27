namespace Login_Form
{
    partial class Admin
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
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.textBoxEnterNewPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEnterNewName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.Btn_AvailableFoodItems = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxNewFoodPrice = new System.Windows.Forms.TextBox();
            this.textBoxNewFoodName = new System.Windows.Forms.TextBox();
            this.labelNewFood = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControlOrders.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOrders
            // 
            this.tabControlOrders.Controls.Add(this.tabPage1);
            this.tabControlOrders.Controls.Add(this.tabPage2);
            this.tabControlOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlOrders.HotTrack = true;
            this.tabControlOrders.Location = new System.Drawing.Point(23, 32);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(815, 461);
            this.tabControlOrders.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.btnShowOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(807, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.BackColor = System.Drawing.Color.White;
            this.btnShowOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowOrder.Location = new System.Drawing.Point(239, 144);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(272, 80);
            this.btnShowOrder.TabIndex = 32;
            this.btnShowOrder.Text = "Show order";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.Btn_exit);
            this.tabPage2.Controls.Add(this.textBoxEnterNewPrice);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxEnterNewName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxNewPrice);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxNewName);
            this.tabPage2.Controls.Add(this.buttondelete);
            this.tabPage2.Controls.Add(this.buttonUpdate);
            this.tabPage2.Controls.Add(this.buttonRefresh);
            this.tabPage2.Controls.Add(this.Btn_AvailableFoodItems);
            this.tabPage2.Controls.Add(this.buttonEnter);
            this.tabPage2.Controls.Add(this.textBoxNewFoodPrice);
            this.tabPage2.Controls.Add(this.textBoxNewFoodName);
            this.tabPage2.Controls.Add(this.labelNewFood);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(807, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.Color.Purple;
            this.Btn_exit.Location = new System.Drawing.Point(706, 386);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(81, 32);
            this.Btn_exit.TabIndex = 123;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // textBoxEnterNewPrice
            // 
            this.textBoxEnterNewPrice.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterNewPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEnterNewPrice.Location = new System.Drawing.Point(594, 229);
            this.textBoxEnterNewPrice.Name = "textBoxEnterNewPrice";
            this.textBoxEnterNewPrice.Size = new System.Drawing.Size(151, 30);
            this.textBoxEnterNewPrice.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(480, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "New Price :";
            // 
            // textBoxEnterNewName
            // 
            this.textBoxEnterNewName.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterNewName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEnterNewName.Location = new System.Drawing.Point(594, 116);
            this.textBoxEnterNewName.Name = "textBoxEnterNewName";
            this.textBoxEnterNewName.Size = new System.Drawing.Size(151, 30);
            this.textBoxEnterNewName.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(480, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "New Name :";
            // 
            // textBoxNewPrice
            // 
            this.textBoxNewPrice.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewPrice.Location = new System.Drawing.Point(594, 190);
            this.textBoxNewPrice.Name = "textBoxNewPrice";
            this.textBoxNewPrice.Size = new System.Drawing.Size(151, 30);
            this.textBoxNewPrice.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(480, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Old Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(478, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Old Name :";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewName.Location = new System.Drawing.Point(594, 79);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(151, 30);
            this.textBoxNewName.TabIndex = 28;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttondelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttondelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.Color.Purple;
            this.buttondelete.Location = new System.Drawing.Point(258, 300);
            this.buttondelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(133, 49);
            this.buttondelete.TabIndex = 26;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Purple;
            this.buttonUpdate.Location = new System.Drawing.Point(568, 286);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(151, 32);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "UPDATE ";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Purple;
            this.buttonRefresh.Location = new System.Drawing.Point(619, 386);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(83, 32);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Btn_AvailableFoodItems
            // 
            this.Btn_AvailableFoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_AvailableFoodItems.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_AvailableFoodItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.Btn_AvailableFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AvailableFoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AvailableFoodItems.ForeColor = System.Drawing.Color.Purple;
            this.Btn_AvailableFoodItems.Location = new System.Drawing.Point(66, 298);
            this.Btn_AvailableFoodItems.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Btn_AvailableFoodItems.Name = "Btn_AvailableFoodItems";
            this.Btn_AvailableFoodItems.Size = new System.Drawing.Size(142, 50);
            this.Btn_AvailableFoodItems.TabIndex = 22;
            this.Btn_AvailableFoodItems.Text = "Show Available food items";
            this.Btn_AvailableFoodItems.UseVisualStyleBackColor = false;
            this.Btn_AvailableFoodItems.Click += new System.EventHandler(this.Btn_AvailableFoodItems_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.Color.Purple;
            this.buttonEnter.Location = new System.Drawing.Point(499, 386);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(116, 32);
            this.buttonEnter.TabIndex = 22;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxNewFoodPrice
            // 
            this.textBoxNewFoodPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewFoodPrice.Location = new System.Drawing.Point(378, 386);
            this.textBoxNewFoodPrice.Name = "textBoxNewFoodPrice";
            this.textBoxNewFoodPrice.Size = new System.Drawing.Size(70, 29);
            this.textBoxNewFoodPrice.TabIndex = 21;
            // 
            // textBoxNewFoodName
            // 
            this.textBoxNewFoodName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewFoodName.Location = new System.Drawing.Point(231, 386);
            this.textBoxNewFoodName.Name = "textBoxNewFoodName";
            this.textBoxNewFoodName.Size = new System.Drawing.Size(141, 29);
            this.textBoxNewFoodName.TabIndex = 20;
            this.textBoxNewFoodName.TextChanged += new System.EventHandler(this.textBoxNewFoodName_TextChanged);
            // 
            // labelNewFood
            // 
            this.labelNewFood.AutoSize = true;
            this.labelNewFood.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNewFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelNewFood.Location = new System.Drawing.Point(15, 383);
            this.labelNewFood.Name = "labelNewFood";
            this.labelNewFood.Size = new System.Drawing.Size(217, 24);
            this.labelNewFood.TabIndex = 19;
            this.labelNewFood.Text = "Enter new Food Item :";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(258, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(207, 244);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(19, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(238, 244);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(871, 512);
            this.Controls.Add(this.tabControlOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControlOrders.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOrders;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxNewFoodPrice;
        private System.Windows.Forms.TextBox textBoxNewFoodName;
        private System.Windows.Forms.Label labelNewFood;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNewPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.TextBox textBoxEnterNewPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEnterNewName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_AvailableFoodItems;
    }
}