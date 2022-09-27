namespace MarioGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jump_btn = new System.Windows.Forms.Button();
            this.Mario = new System.Windows.Forms.PictureBox();
            this.Flower = new System.Windows.Forms.PictureBox();
            this.plant_timer = new System.Windows.Forms.Timer(this.components);
            this.mario_timer = new System.Windows.Forms.Timer(this.components);
            this.gravity = new System.Windows.Forms.Timer(this.components);
            this.game_Over = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.jump_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // jump_btn
            // 
            this.jump_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.jump_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jump_btn.ForeColor = System.Drawing.Color.White;
            this.jump_btn.Location = new System.Drawing.Point(359, 3);
            this.jump_btn.Name = "jump_btn";
            this.jump_btn.Size = new System.Drawing.Size(94, 38);
            this.jump_btn.TabIndex = 0;
            this.jump_btn.Text = "Jump";
            this.jump_btn.UseVisualStyleBackColor = true;
            this.jump_btn.Click += new System.EventHandler(this.jump_btn_Click);
            // 
            // Mario
            // 
            this.Mario.BackColor = System.Drawing.Color.Transparent;
            this.Mario.Image = global::MarioGame.Properties.Resources.ddxh2tf_fc8fc42e_8794_4501_8621_31a4e68a25b5;
            this.Mario.Location = new System.Drawing.Point(-52, 265);
            this.Mario.Name = "Mario";
            this.Mario.Size = new System.Drawing.Size(226, 134);
            this.Mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mario.TabIndex = 1;
            this.Mario.TabStop = false;
            // 
            // Flower
            // 
            this.Flower.BackColor = System.Drawing.Color.Transparent;
            this.Flower.Image = global::MarioGame.Properties.Resources.tumblr_m9wl8isr2h1rfjowdo1_500;
            this.Flower.Location = new System.Drawing.Point(735, 349);
            this.Flower.Name = "Flower";
            this.Flower.Size = new System.Drawing.Size(89, 50);
            this.Flower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Flower.TabIndex = 2;
            this.Flower.TabStop = false;
            // 
            // plant_timer
            // 
            this.plant_timer.Enabled = true;
            this.plant_timer.Interval = 50;
            this.plant_timer.Tick += new System.EventHandler(this.plant_timer_Tick);
            // 
            // mario_timer
            // 
            this.mario_timer.Interval = 50;
            this.mario_timer.Tick += new System.EventHandler(this.mario_timer_Tick);
            // 
            // gravity
            // 
            this.gravity.Enabled = true;
            this.gravity.Interval = 50;
            this.gravity.Tick += new System.EventHandler(this.gravity_Tick);
            // 
            // game_Over
            // 
            this.game_Over.AutoSize = true;
            this.game_Over.Font = new System.Drawing.Font("Terminator Two", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.game_Over.ForeColor = System.Drawing.Color.White;
            this.game_Over.Location = new System.Drawing.Point(240, 149);
            this.game_Over.Name = "game_Over";
            this.game_Over.Size = new System.Drawing.Size(331, 46);
            this.game_Over.TabIndex = 3;
            this.game_Over.Text = "GAME OVER";
            this.game_Over.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.game_Over);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Flower);
            this.Controls.Add(this.Mario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox Mario;
        private PictureBox Flower;
        private System.Windows.Forms.Timer plant_timer;
        private System.Windows.Forms.Timer mario_timer;
        private System.Windows.Forms.Timer gravity;
        private Label game_Over;
        private Button jump_btn;
    }
}