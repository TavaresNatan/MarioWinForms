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
            this.buy_panel = new System.Windows.Forms.Panel();
            this.higher_jumpbtn = new System.Windows.Forms.Button();
            this.jump_btn = new System.Windows.Forms.Button();
            this.Mario = new System.Windows.Forms.PictureBox();
            this.Flower = new System.Windows.Forms.PictureBox();
            this.plant_timer = new System.Windows.Forms.Timer(this.components);
            this.mario_timer = new System.Windows.Forms.Timer(this.components);
            this.gravity = new System.Windows.Forms.Timer(this.components);
            this.game_Over = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.buy_points = new System.Windows.Forms.Label();
            this.bp = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.buy_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.buy_panel);
            this.panel1.Controls.Add(this.jump_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // buy_panel
            // 
            this.buy_panel.BackColor = System.Drawing.Color.Honeydew;
            this.buy_panel.Controls.Add(this.higher_jumpbtn);
            this.buy_panel.Location = new System.Drawing.Point(10, 8);
            this.buy_panel.Name = "buy_panel";
            this.buy_panel.Size = new System.Drawing.Size(427, 40);
            this.buy_panel.TabIndex = 1;
            // 
            // higher_jumpbtn
            // 
            this.higher_jumpbtn.BackColor = System.Drawing.Color.Transparent;
            this.higher_jumpbtn.Enabled = false;
            this.higher_jumpbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.higher_jumpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.higher_jumpbtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.higher_jumpbtn.ForeColor = System.Drawing.Color.Black;
            this.higher_jumpbtn.Location = new System.Drawing.Point(3, 3);
            this.higher_jumpbtn.Name = "higher_jumpbtn";
            this.higher_jumpbtn.Size = new System.Drawing.Size(74, 35);
            this.higher_jumpbtn.TabIndex = 2;
            this.higher_jumpbtn.Text = "higher jump\r\n30bp";
            this.higher_jumpbtn.UseVisualStyleBackColor = false;
            this.higher_jumpbtn.Click += new System.EventHandler(this.higher_jumpbtn_Click);
            // 
            // jump_btn
            // 
            this.jump_btn.Enabled = false;
            this.jump_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.jump_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jump_btn.ForeColor = System.Drawing.Color.White;
            this.jump_btn.Location = new System.Drawing.Point(694, 8);
            this.jump_btn.Name = "jump_btn";
            this.jump_btn.Size = new System.Drawing.Size(94, 38);
            this.jump_btn.TabIndex = 0;
            this.jump_btn.Text = "Jump";
            this.jump_btn.UseVisualStyleBackColor = true;
            this.jump_btn.Visible = false;
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
            this.plant_timer.Interval = 10;
            this.plant_timer.Tick += new System.EventHandler(this.plant_timer_Tick);
            // 
            // mario_timer
            // 
            this.mario_timer.Interval = 10;
            this.mario_timer.Tick += new System.EventHandler(this.mario_timer_Tick);
            // 
            // gravity
            // 
            this.gravity.Interval = 10;
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
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Terminator Two", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_lbl.ForeColor = System.Drawing.Color.White;
            this.score_lbl.Location = new System.Drawing.Point(12, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(198, 46);
            this.score_lbl.TabIndex = 4;
            this.score_lbl.Text = "Score:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Terminator Two", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(216, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(50, 46);
            this.score.TabIndex = 5;
            this.score.Text = "0";
            // 
            // buy_points
            // 
            this.buy_points.AutoSize = true;
            this.buy_points.Font = new System.Drawing.Font("Terminator Two", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buy_points.ForeColor = System.Drawing.Color.White;
            this.buy_points.Location = new System.Drawing.Point(12, 55);
            this.buy_points.Name = "buy_points";
            this.buy_points.Size = new System.Drawing.Size(205, 27);
            this.buy_points.TabIndex = 6;
            this.buy_points.Text = "buy points:";
            // 
            // bp
            // 
            this.bp.AutoSize = true;
            this.bp.Font = new System.Drawing.Font("Terminator Two", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bp.ForeColor = System.Drawing.Color.White;
            this.bp.Location = new System.Drawing.Point(216, 55);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(30, 27);
            this.bp.TabIndex = 7;
            this.bp.Text = "0";
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Font = new System.Drawing.Font("Terminator Two", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pause.ForeColor = System.Drawing.Color.White;
            this.pause.Location = new System.Drawing.Point(745, 9);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(43, 27);
            this.pause.TabIndex = 8;
            this.pause.Text = "| |";
            // 
            // startbtn
            // 
            this.startbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.ForeColor = System.Drawing.Color.White;
            this.startbtn.Location = new System.Drawing.Point(359, 198);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(94, 38);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.buy_points);
            this.Controls.Add(this.score);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.game_Over);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Flower);
            this.Controls.Add(this.Mario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.buy_panel.ResumeLayout(false);
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
        private Label score_lbl;
        private Label score;
        private Label buy_points;
        private Label bp;
        private Label pause;
        private Panel buy_panel;
        private Button higher_jumpbtn;
        private Button startbtn;
    }
}