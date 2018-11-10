namespace CurrencyTrader.Gui
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
            this.btnReadTrades = new System.Windows.Forms.Button();
            this.btnParseTrades = new System.Windows.Forms.Button();
            this.btnStoreTrades = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeUrl = new System.Windows.Forms.TextBox();
            this.lbTradeLines = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumTrades = new System.Windows.Forms.TextBox();
            this.txtStoreStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadTrades
            // 
            this.btnReadTrades.Location = new System.Drawing.Point(100, 129);
            this.btnReadTrades.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadTrades.Name = "btnReadTrades";
            this.btnReadTrades.Size = new System.Drawing.Size(374, 115);
            this.btnReadTrades.TabIndex = 0;
            this.btnReadTrades.Text = "Read Trades";
            this.btnReadTrades.UseVisualStyleBackColor = true;
            this.btnReadTrades.Click += new System.EventHandler(this.btnReadTrades_Click);
            // 
            // btnParseTrades
            // 
            this.btnParseTrades.Location = new System.Drawing.Point(606, 129);
            this.btnParseTrades.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnParseTrades.Name = "btnParseTrades";
            this.btnParseTrades.Size = new System.Drawing.Size(374, 115);
            this.btnParseTrades.TabIndex = 1;
            this.btnParseTrades.Text = "Parse Trades";
            this.btnParseTrades.UseVisualStyleBackColor = true;
            this.btnParseTrades.Click += new System.EventHandler(this.btnParseTrades_Click);
            // 
            // btnStoreTrades
            // 
            this.btnStoreTrades.Location = new System.Drawing.Point(1120, 129);
            this.btnStoreTrades.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStoreTrades.Name = "btnStoreTrades";
            this.btnStoreTrades.Size = new System.Drawing.Size(374, 115);
            this.btnStoreTrades.TabIndex = 2;
            this.btnStoreTrades.Text = "Store Trades";
            this.btnStoreTrades.UseVisualStyleBackColor = true;
            this.btnStoreTrades.Click += new System.EventHandler(this.btnStoreTrades_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 25;
            this.lbStatus.Location = new System.Drawing.Point(406, 896);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(812, 204);
            this.lbStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 865);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trade URL";
            // 
            // txtTradeUrl
            // 
            this.txtTradeUrl.Location = new System.Drawing.Point(100, 58);
            this.txtTradeUrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTradeUrl.Name = "txtTradeUrl";
            this.txtTradeUrl.Size = new System.Drawing.Size(464, 31);
            this.txtTradeUrl.TabIndex = 6;
            this.txtTradeUrl.Text = "http://faculty.css.edu/tgibbons/trades4.txt";
            // 
            // lbTradeLines
            // 
            this.lbTradeLines.FormattingEnabled = true;
            this.lbTradeLines.ItemHeight = 25;
            this.lbTradeLines.Location = new System.Drawing.Point(100, 285);
            this.lbTradeLines.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbTradeLines.Name = "lbTradeLines";
            this.lbTradeLines.Size = new System.Drawing.Size(370, 479);
            this.lbTradeLines.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trades parsed ";
            // 
            // txtNumTrades
            // 
            this.txtNumTrades.Location = new System.Drawing.Point(612, 385);
            this.txtNumTrades.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumTrades.Name = "txtNumTrades";
            this.txtNumTrades.Size = new System.Drawing.Size(338, 31);
            this.txtNumTrades.TabIndex = 9;
            // 
            // txtStoreStatus
            // 
            this.txtStoreStatus.Location = new System.Drawing.Point(1120, 385);
            this.txtStoreStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStoreStatus.Name = "txtStoreStatus";
            this.txtStoreStatus.Size = new System.Drawing.Size(370, 31);
            this.txtStoreStatus.TabIndex = 11;
            this.txtStoreStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1115, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trades Storeage Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1127);
            this.Controls.Add(this.txtStoreStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumTrades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTradeLines);
            this.Controls.Add(this.txtTradeUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStoreTrades);
            this.Controls.Add(this.btnParseTrades);
            this.Controls.Add(this.btnReadTrades);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Trades Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadTrades;
        private System.Windows.Forms.Button btnParseTrades;
        private System.Windows.Forms.Button btnStoreTrades;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeUrl;
        private System.Windows.Forms.ListBox lbTradeLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumTrades;
        private System.Windows.Forms.TextBox txtStoreStatus;
        private System.Windows.Forms.Label label4;
    }
}

