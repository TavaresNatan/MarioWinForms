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
        }
        //plant thing
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
            }
            else
            {
                plant_default_location[0] -= 6;
                Flower.Location = new Point(plant_default_location[0], plant_default_location[1]);
            }
        }
        //Jumping
        int jump_count = 0;
        private void mario_timer_Tick(object sender, EventArgs e)
        {
            if(jump_count < 3)
            {
                mario_default_location[1] -= 45;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
                jump_count++;
            }
            else if(jump_count >= 3 && jump_count <=5)
            {
                mario_default_location[1] -= 12;
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Space)
            {
                mario_timer.Enabled = true;
            }
        }
    }
}