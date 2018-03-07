namespace Rubiks
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
            this.components = new System.ComponentModel.Container();
            this.strt_btn = new System.Windows.Forms.Button();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.antiLeft_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.antiBottom_btn = new System.Windows.Forms.Button();
            this.top_btn = new System.Windows.Forms.Button();
            this.antiBack_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.antiFront_btn = new System.Windows.Forms.Button();
            this.front_btn = new System.Windows.Forms.Button();
            this.vRotate2_btn = new System.Windows.Forms.Button();
            this.vRotate_btn = new System.Windows.Forms.Button();
            this.lRotate_btn = new System.Windows.Forms.Button();
            this.Rrotate_btn = new System.Windows.Forms.Button();
            this.antiTop_btn = new System.Windows.Forms.Button();
            this.bottom_btn = new System.Windows.Forms.Button();
            this.antiRight_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            this.timeStart_btn = new System.Windows.Forms.Button();
            this.main_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // strt_btn
            // 
            this.strt_btn.Location = new System.Drawing.Point(12, 12);
            this.strt_btn.Name = "strt_btn";
            this.strt_btn.Size = new System.Drawing.Size(258, 160);
            this.strt_btn.TabIndex = 0;
            this.strt_btn.Text = "Start";
            this.strt_btn.UseVisualStyleBackColor = true;
            this.strt_btn.Click += new System.EventHandler(this.strt_btn_Click);
            // 
            // main_pnl
            // 
            this.main_pnl.Controls.Add(this.antiLeft_btn);
            this.main_pnl.Controls.Add(this.right_btn);
            this.main_pnl.Controls.Add(this.antiBottom_btn);
            this.main_pnl.Controls.Add(this.top_btn);
            this.main_pnl.Controls.Add(this.antiBack_btn);
            this.main_pnl.Controls.Add(this.Back_btn);
            this.main_pnl.Controls.Add(this.antiFront_btn);
            this.main_pnl.Controls.Add(this.front_btn);
            this.main_pnl.Location = new System.Drawing.Point(303, 173);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(575, 762);
            this.main_pnl.TabIndex = 1;
            this.main_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.main_pnl_Paint);
            // 
            // antiLeft_btn
            // 
            this.antiLeft_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiLeft_btn.Location = new System.Drawing.Point(168, 656);
            this.antiLeft_btn.Name = "antiLeft_btn";
            this.antiLeft_btn.Size = new System.Drawing.Size(43, 64);
            this.antiLeft_btn.TabIndex = 9;
            this.antiLeft_btn.UseVisualStyleBackColor = true;
            this.antiLeft_btn.Click += new System.EventHandler(this.antiLeft_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_btn.Location = new System.Drawing.Point(272, 656);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(43, 64);
            this.right_btn.TabIndex = 8;
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // antiBottom_btn
            // 
            this.antiBottom_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiBottom_btn.Location = new System.Drawing.Point(495, 274);
            this.antiBottom_btn.Name = "antiBottom_btn";
            this.antiBottom_btn.Size = new System.Drawing.Size(64, 43);
            this.antiBottom_btn.TabIndex = 6;
            this.antiBottom_btn.UseVisualStyleBackColor = true;
            this.antiBottom_btn.Click += new System.EventHandler(this.antiBottom_btn_Click);
            // 
            // top_btn
            // 
            this.top_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_btn.Location = new System.Drawing.Point(495, 169);
            this.top_btn.Name = "top_btn";
            this.top_btn.Size = new System.Drawing.Size(64, 43);
            this.top_btn.TabIndex = 5;
            this.top_btn.UseVisualStyleBackColor = true;
            this.top_btn.Click += new System.EventHandler(this.top_btn_Click);
            // 
            // antiBack_btn
            // 
            this.antiBack_btn.Location = new System.Drawing.Point(27, 518);
            this.antiBack_btn.Name = "antiBack_btn";
            this.antiBack_btn.Size = new System.Drawing.Size(105, 93);
            this.antiBack_btn.TabIndex = 5;
            this.antiBack_btn.UseVisualStyleBackColor = true;
            this.antiBack_btn.Click += new System.EventHandler(this.antiBack_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(354, 518);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(105, 93);
            this.Back_btn.TabIndex = 4;
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // antiFront_btn
            // 
            this.antiFront_btn.Location = new System.Drawing.Point(27, 27);
            this.antiFront_btn.Name = "antiFront_btn";
            this.antiFront_btn.Size = new System.Drawing.Size(105, 93);
            this.antiFront_btn.TabIndex = 3;
            this.antiFront_btn.UseVisualStyleBackColor = true;
            this.antiFront_btn.Click += new System.EventHandler(this.antiFront_btn_Click);
            // 
            // front_btn
            // 
            this.front_btn.Location = new System.Drawing.Point(354, 27);
            this.front_btn.Name = "front_btn";
            this.front_btn.Size = new System.Drawing.Size(105, 93);
            this.front_btn.TabIndex = 2;
            this.front_btn.UseVisualStyleBackColor = true;
            this.front_btn.Click += new System.EventHandler(this.front_btn_Click);
            // 
            // vRotate2_btn
            // 
            this.vRotate2_btn.Location = new System.Drawing.Point(512, 899);
            this.vRotate2_btn.Name = "vRotate2_btn";
            this.vRotate2_btn.Size = new System.Drawing.Size(64, 66);
            this.vRotate2_btn.TabIndex = 1;
            this.vRotate2_btn.UseVisualStyleBackColor = true;
            this.vRotate2_btn.Click += new System.EventHandler(this.vRotate2_btn_Click);
            // 
            // vRotate_btn
            // 
            this.vRotate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vRotate_btn.Location = new System.Drawing.Point(512, 12);
            this.vRotate_btn.Name = "vRotate_btn";
            this.vRotate_btn.Size = new System.Drawing.Size(64, 66);
            this.vRotate_btn.TabIndex = 0;
            this.vRotate_btn.UseVisualStyleBackColor = true;
            this.vRotate_btn.Click += new System.EventHandler(this.vRotate_btn_Click);
            // 
            // lRotate_btn
            // 
            this.lRotate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRotate_btn.Location = new System.Drawing.Point(884, 378);
            this.lRotate_btn.Name = "lRotate_btn";
            this.lRotate_btn.Size = new System.Drawing.Size(64, 66);
            this.lRotate_btn.TabIndex = 3;
            this.lRotate_btn.UseVisualStyleBackColor = true;
            this.lRotate_btn.Click += new System.EventHandler(this.lRotate_btn_Click_1);
            // 
            // Rrotate_btn
            // 
            this.Rrotate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rrotate_btn.Location = new System.Drawing.Point(135, 378);
            this.Rrotate_btn.Name = "Rrotate_btn";
            this.Rrotate_btn.Size = new System.Drawing.Size(64, 66);
            this.Rrotate_btn.TabIndex = 4;
            this.Rrotate_btn.UseVisualStyleBackColor = true;
            this.Rrotate_btn.Click += new System.EventHandler(this.Rrotate_btn_Click);
            // 
            // antiTop_btn
            // 
            this.antiTop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiTop_btn.Location = new System.Drawing.Point(222, 342);
            this.antiTop_btn.Name = "antiTop_btn";
            this.antiTop_btn.Size = new System.Drawing.Size(64, 43);
            this.antiTop_btn.TabIndex = 6;
            this.antiTop_btn.UseVisualStyleBackColor = true;
            this.antiTop_btn.Click += new System.EventHandler(this.antiTop_btn_Click);
            // 
            // bottom_btn
            // 
            this.bottom_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom_btn.Location = new System.Drawing.Point(222, 447);
            this.bottom_btn.Name = "bottom_btn";
            this.bottom_btn.Size = new System.Drawing.Size(64, 43);
            this.bottom_btn.TabIndex = 7;
            this.bottom_btn.UseVisualStyleBackColor = true;
            this.bottom_btn.Click += new System.EventHandler(this.bottom_btn_Click);
            // 
            // antiRight_btn
            // 
            this.antiRight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiRight_btn.Location = new System.Drawing.Point(575, 94);
            this.antiRight_btn.Name = "antiRight_btn";
            this.antiRight_btn.Size = new System.Drawing.Size(43, 64);
            this.antiRight_btn.TabIndex = 7;
            this.antiRight_btn.UseVisualStyleBackColor = true;
            this.antiRight_btn.Click += new System.EventHandler(this.antiRight_btn_Click);
            // 
            // left_btn
            // 
            this.left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_btn.Location = new System.Drawing.Point(471, 94);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(43, 64);
            this.left_btn.TabIndex = 8;
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(12, 12);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(258, 160);
            this.reset_btn.TabIndex = 9;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(1256, 144);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(51, 55);
            this.time_lbl.TabIndex = 10;
            this.time_lbl.Text = "0";
            // 
            // timeStart_btn
            // 
            this.timeStart_btn.Location = new System.Drawing.Point(1061, 144);
            this.timeStart_btn.Name = "timeStart_btn";
            this.timeStart_btn.Size = new System.Drawing.Size(130, 55);
            this.timeStart_btn.TabIndex = 11;
            this.timeStart_btn.Text = "Start";
            this.timeStart_btn.UseVisualStyleBackColor = true;
            this.timeStart_btn.Click += new System.EventHandler(this.timeStart_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1411, 1038);
            this.Controls.Add(this.timeStart_btn);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.antiRight_btn);
            this.Controls.Add(this.bottom_btn);
            this.Controls.Add(this.antiTop_btn);
            this.Controls.Add(this.lRotate_btn);
            this.Controls.Add(this.Rrotate_btn);
            this.Controls.Add(this.vRotate2_btn);
            this.Controls.Add(this.vRotate_btn);
            this.Controls.Add(this.strt_btn);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.reset_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strt_btn;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Button vRotate_btn;
        private System.Windows.Forms.Button vRotate2_btn;
        private System.Windows.Forms.Button front_btn;
        private System.Windows.Forms.Button lRotate_btn;
        private System.Windows.Forms.Button antiFront_btn;
        private System.Windows.Forms.Button Rrotate_btn;
        private System.Windows.Forms.Button antiBack_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button top_btn;
        private System.Windows.Forms.Button antiTop_btn;
        private System.Windows.Forms.Button antiBottom_btn;
        private System.Windows.Forms.Button bottom_btn;
        private System.Windows.Forms.Button antiRight_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button antiLeft_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Button timeStart_btn;
    }
}

