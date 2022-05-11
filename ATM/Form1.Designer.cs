
namespace ATM
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
            this.lblcustname = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblbalance = new System.Windows.Forms.Label();
            this.btnbalance = new System.Windows.Forms.Button();
            this.btnwithdrop = new System.Windows.Forms.Button();
            this.btndeposit = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Location = new System.Drawing.Point(134, 40);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(115, 17);
            this.lblcustname.TabIndex = 0;
            this.lblcustname.Text = "EnterCustomerID";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(399, 37);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(268, 22);
            this.txtcustomerid.TabIndex = 1;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(399, 96);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(268, 22);
            this.txtcustomername.TabIndex = 3;
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.Location = new System.Drawing.Point(134, 99);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(103, 17);
            this.lblcustomername.TabIndex = 2;
            this.lblcustomername.Text = "Customername";
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(399, 143);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(268, 22);
            this.txtbalance.TabIndex = 5;
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Location = new System.Drawing.Point(134, 146);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(118, 17);
            this.lblbalance.TabIndex = 4;
            this.lblbalance.Text = "Customerbalance";
            // 
            // btnbalance
            // 
            this.btnbalance.Location = new System.Drawing.Point(77, 270);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(134, 38);
            this.btnbalance.TabIndex = 6;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = true;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnwithdrop
            // 
            this.btnwithdrop.Location = new System.Drawing.Point(252, 270);
            this.btnwithdrop.Name = "btnwithdrop";
            this.btnwithdrop.Size = new System.Drawing.Size(134, 38);
            this.btnwithdrop.TabIndex = 7;
            this.btnwithdrop.Text = "Withdraw";
            this.btnwithdrop.UseVisualStyleBackColor = true;
            this.btnwithdrop.Click += new System.EventHandler(this.btnwithdrop_Click);
            // 
            // btndeposit
            // 
            this.btndeposit.Location = new System.Drawing.Point(415, 270);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(134, 38);
            this.btndeposit.TabIndex = 8;
            this.btndeposit.Text = "Deposit";
            this.btndeposit.UseVisualStyleBackColor = true;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(512, 230);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(238, 22);
            this.txtamount.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.btndeposit);
            this.Controls.Add(this.btnwithdrop);
            this.Controls.Add(this.btnbalance);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.lblcustomername);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.lblcustname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Button btnwithdrop;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.TextBox txtamount;
    }
}

