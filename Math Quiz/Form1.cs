using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz {
	public partial class Form1 : Form {
		Random randomizer = new Random();
		int addLeft, addRight, subLeft, subRight, multLeft, multRight, divLeft, divRight;
		int addAnswer, subAnswer, multAnswer, divAnswer;
		int timeLeft;
		public Form1() {
			InitializeComponent();
		}
		public void startTheQuiz() {
			//Populate values to be calculated
			addLeft = randomizer.Next(51);
			addRight = randomizer.Next(51);
			subLeft = randomizer.Next(51);
			subRight = randomizer.Next(51);
			multLeft = randomizer.Next(11);
			multRight = randomizer.Next(11);
			divLeft = randomizer.Next(2,11);
			divRight = randomizer.Next(2,11);
			//Set generated values to their label representatives.
			plusLeftLabel.Text = addLeft.ToString();
			plusRightLabel.Text = addRight.ToString();
			minusLeftLabel.Text = subLeft.ToString();
			minusRightLabel.Text = subRight.ToString();
			multLeftLabel.Text = multLeft.ToString();
			multRightLabel.Text = multRight.ToString();
			divLeftLabel.Text = divLeft.ToString();
			divRightLabel.Text = divRight.ToString();
			//Default the values in the form.
			sum.Value = 0;
			difference.Value = 0;
			product.Value = 0;
			quotient.Value = 0;
			//Calculate the correct answers.
			addAnswer=addLeft+addRight;
			subAnswer=subLeft-subRight;
			multAnswer=multLeft*multRight;
			divAnswer=multRight/multLeft;
			timeLeft = 30;
			timeLabel.Text = "30 seconds!";
			timer1.Start();
		}

		private bool checkTheAnswer() {
			return (sum.Value == addAnswer) &&
				(difference.Value == subAnswer) &&
				(product.Value == multAnswer) &&
				(quotient.Value==divAnswer);
		}

		private void startButton_Click(object sender, EventArgs e) {
			startTheQuiz();
			startButton.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e) {
			if (checkTheAnswer()) {
				timer1.Stop();
				MessageBox.Show("You got all the answers correct!", "Congratulations");
				startButton.Enabled = true;
			}
			else if (timeLeft > 0) {
				if (timeLeft == 15) timeLabel.BackColor = Color.Red;
				timeLeft--;
				timeLabel.Text = timeLeft.ToString()+" Second(s).";
			}
			else {
				timer1.Stop();
				timeLabel.Text = "Time is up!";
				MessageBox.Show("You didn't finish in time.", "Sorry!");
				sum.Value = addAnswer;
				difference.Value = subAnswer;
				product.Value = multAnswer;
				quotient.Value = divAnswer;
				startButton.Enabled = true;
			}
		}

		private void answer_Enter(object sender, EventArgs e) {
			//set the whole answer in the NumericUpDown control.
			NumericUpDown answerBox = sender as NumericUpDown;
			if(answerBox!=null){
				int lengthOfAnswer=answerBox.Value.ToString().Length;
				answerBox.Select(0,lengthOfAnswer);
			}
		}

		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}
