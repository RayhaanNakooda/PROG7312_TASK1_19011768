namespace LibrarySystem19011768
{
    partial class frmReplaceBooks
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
            this.components = new System.ComponentModel.Container();
            this.lbCallNumbers = new System.Windows.Forms.ListBox();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblMilli = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCallNumbers
            // 
            this.lbCallNumbers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCallNumbers.FormattingEnabled = true;
            this.lbCallNumbers.ItemHeight = 22;
            this.lbCallNumbers.Location = new System.Drawing.Point(103, 75);
            this.lbCallNumbers.Name = "lbCallNumbers";
            this.lbCallNumbers.Size = new System.Drawing.Size(356, 246);
            this.lbCallNumbers.TabIndex = 10;
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.BackColor = System.Drawing.Color.Tomato;
            this.btnCheckOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckOrder.FlatAppearance.BorderSize = 2;
            this.btnCheckOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOrder.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOrder.Location = new System.Drawing.Point(218, 393);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(124, 34);
            this.btnCheckOrder.TabIndex = 11;
            this.btnCheckOrder.Text = "Check Order";
            this.btnCheckOrder.UseVisualStyleBackColor = false;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Tomato;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUp.FlatAppearance.BorderSize = 2;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(494, 138);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(124, 34);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Move Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Tomato;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDown.FlatAppearance.BorderSize = 2;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(494, 214);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(124, 34);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Move Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Tomato;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(235, 338);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 34);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMinutes.Location = new System.Drawing.Point(565, 409);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 31);
            this.lblMinutes.TabIndex = 17;
            this.lblMinutes.Text = "00";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.Transparent;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.ForeColor = System.Drawing.SystemColors.Window;
            this.lblM.Location = new System.Drawing.Point(605, 409);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(22, 31);
            this.lblM.TabIndex = 18;
            this.lblM.Text = ":";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSeconds.Location = new System.Drawing.Point(623, 409);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(44, 31);
            this.lblSeconds.TabIndex = 19;
            this.lblSeconds.Text = "00";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.SystemColors.Window;
            this.lblD.Location = new System.Drawing.Point(673, 409);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(22, 31);
            this.lblD.TabIndex = 20;
            this.lblD.Text = ".";
            // 
            // lblMilli
            // 
            this.lblMilli.AutoSize = true;
            this.lblMilli.BackColor = System.Drawing.Color.Transparent;
            this.lblMilli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilli.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMilli.Location = new System.Drawing.Point(691, 422);
            this.lblMilli.Name = "lblMilli";
            this.lblMilli.Size = new System.Drawing.Size(21, 15);
            this.lblMilli.TabIndex = 21;
            this.lblMilli.Text = "00";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Tomato;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(587, 357);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(108, 34);
            this.btnRestart.TabIndex = 22;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::LibrarySystem19011768.Properties.Resources.cancel;
            this.pbExit.Location = new System.Drawing.Point(694, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(39, 38);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 23;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // frmReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LibrarySystem19011768.Properties.Resources.Library_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 449);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblMilli);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCheckOrder);
            this.Controls.Add(this.lbCallNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReplaceBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmLoad);
            this.Load += new System.EventHandler(this.frmReplaceBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbCallNumbers;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblMilli;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pbExit;
    }
}