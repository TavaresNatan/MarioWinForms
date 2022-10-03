namespace MarioGame
{
    public partial class Form1 : Form
    {
        int[] plant_default_location = new int[] {735,349};
        int[] mario_default_location = new int[] {-52,265};
        int score_points = 0;
        string path = "Stuff\\Params.txt";
        public Form1()
        {
            InitializeComponent();
            bp.Text = GetBP().ToString();
            if(GetBP() >= 30)
            {
                higher_jumpbtn.Enabled = true;
            }
        }
        //plant functions
        int speed = 100;
        private void plant_timer_Tick(object sender, EventArgs e)
        {
            bool game_over = 
                plant_default_location[0] <= 64 &&
                plant_default_location[0] >= 26 &&
                mario_default_location[1] >= 218;
            
            if (plant_default_location[0] <= -52)
            {
                score_points++;
                score.Text = score_points.ToString();
                plant_default_location[0] = 735;
                Flower.Location = new Point(plant_default_location[0], plant_default_location[1]);
            }
            else if(game_over)
            {
                game_Over.Visible = true;
                plant_timer.Enabled = false;
                mario_timer.Enabled = false;
                SaveScore();
            }
            else
            {
                plant_default_location[0] -= 6 * speed / 500;
                if(speed <= 20000)
                {
                speed++;

                }
                Flower.Location = new Point(plant_default_location[0], plant_default_location[1]);
            }
        }
        /// <summary>
        /// Saves the player score
        /// </summary>
        private void SaveScore()
        {
            string[] conf = File.ReadAllLines(path);
            int value = int.Parse(bp.Text) + score_points;
            conf[0] = "coins=" + value;
            using (var writer = new StreamWriter(path)) 
            {
                foreach(var line in conf)
                {
                    writer.WriteLine(line);
                }
            }
        }
        //Jumping
        int jump_count = 0;
        int jump_height = 45;
        private void mario_timer_Tick(object sender, EventArgs e)
        {
            if(jump_count < 3)
            {
                mario_default_location[1] -= jump_height;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
                jump_count++;
            }
            else if(jump_count >= 3 && jump_count <=5)
            {
                mario_default_location[1] -= jump_height - 33;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
                jump_count++;
            }
            else
            {
                jump_count =0;
                mario_timer.Enabled = false;
            }
        }
        //load buy points
        int GetBP()
        {
            //index=0
            var points = File.ReadAllLines(path);
            var bp = int.Parse(points[0].Substring(points[0].IndexOf("=") + 1));
            return bp;
        }
        private void gravity_Tick(object sender, EventArgs e)
        {
            if(mario_default_location[1] < 265)
            {
                mario_default_location[1] += 6;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
            }
            if (mario_default_location[1] > 265)
            {
                mario_default_location[1] = 265;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
            }
        }
        private void jump_btn_Click(object sender, EventArgs e)
        {
            if (mario_default_location[1] == 265)
            {
                mario_timer.Enabled = true;
            }
        }
        //Jumping with space
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Space)
            {
                mario_timer.Enabled = true;
            }
        }

        //from buy panel
        private void higher_jumpbtn_Click(object sender, EventArgs e)
        {
            if(jump_height != 60)
            {
                bp.Text = (int.Parse(bp.Text) - 30).ToString();
                jump_height = 60;
            }
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            jump_btn.Visible = true;
            jump_btn.Enabled = true;
            gravity.Enabled = true;
            plant_timer.Enabled = true;
            startbtn.Enabled = false;
            startbtn.Visible = false;
        }
    }
}