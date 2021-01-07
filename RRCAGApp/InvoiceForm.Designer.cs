namespace RRCAGApp
{
    partial class InvoiceForm
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDPDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(36, 54);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(698, 85);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "RRC Automotive Group";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(38, 175);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(388, 67);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "777 Inheritance Drive";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Winnipeg,Manitoba,I0I 0I0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "204-867-5309";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(52, 410);
            this.lblInvoiceTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(466, 79);
            this.lblInvoiceTitle.TabIndex = 5;
            this.lblInvoiceTitle.Text = "[Invoice title]";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1176, 73);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 65);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // lblDPDate
            // 
            this.lblDPDate.AutoSize = true;
            this.lblDPDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPDate.Location = new System.Drawing.Point(1288, 73);
            this.lblDPDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDPDate.Name = "lblDPDate";
            this.lblDPDate.Size = new System.Drawing.Size(102, 37);
            this.lblDPDate.TabIndex = 7;
            this.lblDPDate.Text = "[Date]";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 1127);
            this.Controls.Add(this.lblDPDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInvoiceTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "InvoiceForm";
            this.Text = "Form Title";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDPDate;
        protected System.Windows.Forms.Label lblInvoiceTitle;
    }
}