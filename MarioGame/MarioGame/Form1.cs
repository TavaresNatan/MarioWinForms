namespace MarioGame
{
    public partial class Form1 : Form
    {
        //int[] plant_default_location = new int[] { 735, 349 };
        int[] plant_default_location = new int[] {735,349};
        int[] mario_default_location = new int[] {-52,265};
        public Form1()
        {
            InitializeComponent();
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
                plant_default_location[0] -= 30;
                Flower.Location = new Point(plant_default_location[0], plant_default_location[1]);
            }
        }


        //Jumping
        int jump_count = 0;
        private void mario_timer_Tick(object sender, EventArgs e)
        {
            if(jump_count < 4)
            {
                mario_default_location[1] -= 60;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
                jump_count++;
            }
            else
            {
                jump_count=0;
                mario_timer.Enabled = false;
            }
        }

        private void gravity_Tick(object sender, EventArgs e)
        {
            if(mario_default_location[1] < 265)
            {
                mario_default_location[1] += 30;
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
            mario_timer.Enabled = true;
        }
    }
}