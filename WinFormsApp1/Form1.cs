namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Item[] arr = new Item[5];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item1 = new Cola();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter < 5)
            {
                arr[counter] = new Cola();
                counter++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (counter < 5)
            {
                arr[counter] = new kinly();
                counter++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] allList = new string[5];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Cola)
                {
                    Cola sweet = (Cola)arr[i];
                    allList[i] = sweet.GetPrice().ToString();
                }
                else
                {
                    kinly old = (kinly)arr[i];
                    allList[i] = old.GetPrice().ToString();
                }
                

            }
            MessageBox.Show($"{allList[0]} {allList[1]} {allList[2]} {allList[3]} {allList[4]}");
        }
    }
}