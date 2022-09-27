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
            if(plant_default_location[0] <= -52)
            {
                plant_default_location[0] = 735;
                Flower.Location = new Point(plant_default_location[0], plant_default_location[1]);
            }
            else if(plant_default_location[0] <= 64 && plant_default_location[0] >= 26 && mario_default_location[1]>= 218)
            {
                plant_timer.Enabled = false;
                mario_timer.Enabled = false;
            }
            else
            {
                plant_default_location[0] -= 30;
                Flower.Location = new Point(plant_default_location[0], plant_default_location[1]);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            mario_timer.Enabled = true;
        }

        //Jumping
        int jump_count = 0;
        private void mario_timer_Tick(object sender, EventArgs e)
        {
            if(jump_count < 4)
            {
                mario_default_location[1] -= 30;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
                jump_count++;
            }
            else
            {
                mario_default_location[1] += 120;
                Mario.Location = new Point(mario_default_location[0], mario_default_location[1]);
                jump_count=0;
                mario_timer.Enabled = false;
            }
        }
    }
}