namespace GADE_EXAM
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
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_attack = new System.Windows.Forms.Button();
            this.actionlist = new System.Windows.Forms.ListBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblmap = new System.Windows.Forms.Label();
            this.lblshop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(192, 533);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(56, 39);
            this.btn_down.TabIndex = 8;
            this.btn_down.Text = "down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click_1);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(130, 533);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(56, 39);
            this.btn_left.TabIndex = 7;
            this.btn_left.Text = "left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click_1);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(254, 533);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(56, 39);
            this.btn_right.TabIndex = 6;
            this.btn_right.Text = "right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click_1);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(192, 488);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(56, 39);
            this.btn_up.TabIndex = 5;
            this.btn_up.Text = "up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click_1);
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(1108, 511);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(75, 23);
            this.btn_attack.TabIndex = 12;
            this.btn_attack.Text = "Attack Selected";
            this.btn_attack.UseVisualStyleBackColor = true;
            // 
            // actionlist
            // 
            this.actionlist.FormattingEnabled = true;
            this.actionlist.Location = new System.Drawing.Point(1108, 303);
            this.actionlist.Name = "actionlist";
            this.actionlist.Size = new System.Drawing.Size(219, 199);
            this.actionlist.TabIndex = 11;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(1105, 88);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(56, 13);
            this.lblPlayer.TabIndex = 10;
            this.lblPlayer.Text = "Player info";
            // 
            // lblmap
            // 
            this.lblmap.AutoSize = true;
            this.lblmap.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmap.Location = new System.Drawing.Point(595, 140);
            this.lblmap.Name = "lblmap";
            this.lblmap.Size = new System.Drawing.Size(117, 33);
            this.lblmap.TabIndex = 13;
            this.lblmap.Text = "label1";
            // 
            // lblshop
            // 
            this.lblshop.AutoSize = true;
            this.lblshop.Location = new System.Drawing.Point(848, 87);
            this.lblshop.Name = "lblshop";
            this.lblshop.Size = new System.Drawing.Size(35, 13);
            this.lblshop.TabIndex = 14;
            this.lblshop.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 650);
            this.Controls.Add(this.lblshop);
            this.Controls.Add(this.lblmap);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.actionlist);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_down;
        public System.Windows.Forms.Button btn_left;
        public System.Windows.Forms.Button btn_right;
        public System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.ListBox actionlist;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblmap;
        private System.Windows.Forms.Label lblshop;
    }
}

