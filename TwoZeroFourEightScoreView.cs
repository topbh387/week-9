using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
     
    public partial class TwoZeroFourEightScoreView : Form,View
    {
                public TwoZeroFourEightScoreView()
        {

            InitializeComponent();
           
           
        }
        public void Notify(Model m)
        {
            UpdateScore(((TwoZeroFourEightModel)m).GetSum());
        }
        private void UpdateScore(int sum)
        {


            lblScore.Text = Convert.ToString(sum);

        }
        private void lblScore_Click(object sender, EventArgs e)
        {

        }
        public void score_(int score)
        {
            lblScore.Text = Convert.ToString(score);
        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
