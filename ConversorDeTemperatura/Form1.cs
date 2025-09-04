namespace ConversorDeTemperatura
{
    public partial class Form1 : Form
    {

        int tempF, tempC;

        public Form1()
        {
            InitializeComponent();
        }

        private void vsbTemp_Scroll(object sender, ScrollEventArgs e)
        {
            tempF = vsbTemp.Value;
            lblTempF.Text = tempF.ToString();
            tempC = Convert.ToInt32((tempF - 32) * 5/ 9);
            lblTempC.Text = tempC.ToString();
        }
    }
}
