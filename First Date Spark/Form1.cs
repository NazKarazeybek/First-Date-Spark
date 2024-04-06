using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace First_Date_Spark
{
    public partial class Form1 : Form
    {
        int page;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            continueButton.Visible = false;
            aceButton.Visible = false;
            walkerButton.Visible = false;
            haelButton.Visible = false;
            option1Button.Visible = false;
            option2Button.Visible = false;
            supriseButton.Visible = false;
            restartButton.Visible = false;

            Refresh();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Refresh();

            textLabel2.Parent = this;
            this.BackgroundImage = Properties.Resources.page2; //change of backgroud
            playButton.Visible = false; //hide button

            Refresh();

            //displaying text
            textLabel.Text = "";//clears text
            string text1 = "Sitting on my bed, I stare at three invitations on my phone screen. Ace, Walker, and Hael—all waiting for my answer. Heart racing, I open their profiles. I must choose wisely; this date could lead to a boyfriend, maybe even shape my future.";
            foreach (char c in text1)
            {
                textLabel.Text += c;
                Thread.Sleep(13);
                textLabel.Refresh();
            }

            Refresh();

            continueButton.Visible = true;

            Refresh();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            page++;

            DisplayPage();

        }

        private void walkerButton_Click(object sender, EventArgs e)
        {
            walkerButton.Enabled = false;
        }

        private void haelButton_Click(object sender, EventArgs e)
        {
            haelButton.Enabled = false;
        }

        private void aceButton_Click(object sender, EventArgs e)
        {
            int aceOption;
            aceOption = 1;

            if (aceOption == 1)
            {
                page = 2;
            }

            DisplayPage();

        }

        private void DisplayPage()
        {
            switch (page)
            {
                case 1:

                    Refresh();

                    continueButton.Visible = false;
                    textLabel.Text = "";
                    this.BackgroundImage = Properties.Resources.page3; //change of background

                    Refresh();

                    //displaying text
                    textLabel2.Text = ""; //clears text
                    string text2 = "Who Should I Choose For My Date?";
                    foreach (char c in text2)
                    {
                        textLabel2.Text += c;
                        Thread.Sleep(27);
                        textLabel2.Refresh();
                    }

                    Refresh();

                    aceButton.Visible = true;
                    walkerButton.Visible = true;
                    haelButton.Visible = true;

                    Refresh();

                    break;

                case 2:

                    Refresh();

                    this.BackgroundImage = Properties.Resources.page4; //change of background
                    textLabel2.Text = "";
                    walkerButton.Visible = false;
                    haelButton.Visible = false;
                    aceButton.Visible = false;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text3 = "As we agree to meet in a few hours, excitement bubbles within me. I get ready eagerly, heart racing. Each step towards our spot widens my smile. Anticipation fills me, eager for what lies ahead.";
                    foreach (char c in text3)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.Visible = true;
                    continueButton.BackColor = Color.FromArgb(153, 118, 83);
                    continueButton.ForeColor = Color.Black;

                    Refresh();

                    break;

                case 3:

                    Refresh();

                    this.BackgroundImage = Properties.Resources.page5; //change background
                    continueButton.Visible = false;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text4 = "I'm lost in thought. Did I make the right choice picking Ace? How will the date unfold? Will he enjoy my company? How is he even like? Am I good eno--?";
                    foreach (char c in text4)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.Visible = true;
                    continueButton.BackColor = Color.FromArgb(163, 115, 106);
                    continueButton.ForeColor = Color.White;

                    Refresh();

                    break;

                case 4:

                    Refresh();

                    textLabel.Text = ""; //clears text
                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page6;

                    Refresh();

                    Thread.Sleep(400);
                    this.BackgroundImage = Properties.Resources.page7;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text5 = "' Ouch... Oh, I-I'm terribly sorry, I wasn't paying attention— ' I rub my forehead and lift my gaze slowly.";
                    foreach (char c in text5)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.Visible = true;
                    continueButton.BackColor = Color.FromArgb(241, 232, 227);
                    continueButton.ForeColor = Color.FromArgb(70, 55, 49);

                    Refresh();

                    break;

                case 5:

                    Refresh();

                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page8;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text6 = "' A-Ace? Is it really you? '  I stammer, my heart racing with a mixture of suprisement and relief.";
                    foreach (char c in text6)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    Thread.Sleep(2000);

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text7 = "Ace: ' Yeah, it's me. Are you alright? ' He checks your forehead and gazes down at you with concern written on his face.";
                    foreach (char c in text7)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }


                    Refresh();

                    Thread.Sleep(2000);

                    Refresh();

                    this.BackgroundImage = Properties.Resources.page8;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text8 = "' I-I'm okay, thank you. ' I smile gently. ' Should we continue with our date? '";
                    foreach (char c in text8)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.Visible = true;
                    continueButton.ForeColor = Color.FromArgb(226, 214, 199);
                    continueButton.BackColor = Color.FromArgb(150, 129, 113);

                    Refresh();

                    break;

                case 6:

                    Refresh();

                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page9;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text9 = "' Of course. ' He smiles warmly, holding out his hand. ' Where would you like to go first? '";
                    foreach (char c in text9)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.Text = "To The Arcade";
                    option1Button.Visible = true;


                    option2Button.Text = "To The Park";
                    option2Button.Visible = true;

                    Refresh();


                    break;

                case 7:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page10;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text10 = "As we arrive at the arcade, the vibrant lights and cheerful sounds fill the air, igniting a sense of excitement within me. Should I take the lead and choose our first activity, or would it be better to let Ace decide?";
                    foreach (char c in text10)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(160, 189, 191);
                    option1Button.ForeColor = Color.FromArgb(71, 80, 99);
                    option1Button.Text = "Let Ace Decide";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(160, 189, 191);
                    option2Button.ForeColor = Color.FromArgb(71, 80, 99);
                    option2Button.Text = "Choose Yourself";
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 8:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page11;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text11 = "I decide to let Ace take the lead. We spend the next hour or two exploring various games and attractions, taking turns choosing what to do next. As we walk towards the exit, contemplating what to do next, my eyes catch sight of a claw machine.";
                    foreach (char c in text11)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option2Button.Text = "Continue";
                    option2Button.BackColor = Color.FromArgb(192, 140, 129);
                    option2Button.ForeColor = Color.FromArgb(40, 25, 34);
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 9:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page25;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text25 = "I decide to choose and we started with laser tag. We spend the next hour or two exploring various games. taking turns choosing what to do next. As we walk towards the exit, contemplating what to do next, my eyes catch sight of a claw machine.";
                    foreach (char c in text25)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.BackColor = Color.FromArgb(192, 140, 129);
                    continueButton.ForeColor = Color.FromArgb(40, 25, 34);
                    continueButton.Visible = true;

                    Refresh();

                    break;

                case 10:

                    Refresh();

                    option2Button.Visible= false;
                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page25;


                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text12 = "Ace notices me looking at the claw machine and gently stops us, his gaze meeting mine. 'Do you want to play the crane game?' he asks, a playful glint in his eyes.";
                    foreach (char c in text12)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(217, 226, 217);
                    option1Button.ForeColor = Color.FromArgb(67, 87, 101);
                    option1Button.Text = "Yes";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(217, 226, 217);
                    option2Button.ForeColor = Color.FromArgb(67, 87, 101);
                    option2Button.Text = "No";
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 11:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page12;

                    Refresh();


                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text13 = "I lean against the machine, nodding excitedly as Ace chuckles at my reaction. After a few tries, Ace manages to win a fluffy teddy bear. With a playful grin, he hands it to me, leaving me speechless but smiling warmly as I accept the unexpected gift.";
                    foreach (char c in text13)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    option2Button.Text = "Continue";
                    option2Button.BackColor = Color.FromArgb(167, 155, 166);
                    option2Button.ForeColor = Color.FromArgb(68, 52, 65);
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 12:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;

                    Refresh();


                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text14 = "I glance at the claw machine and then at Ace. Slowly, I shake my head, wanting to continue our date somewhere else.";
                    foreach (char c in text14)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.BackColor = Color.FromArgb(192, 140, 129);
                    continueButton.ForeColor = Color.FromArgb(40, 25, 34);
                    continueButton.Visible = true;

                    Refresh();

                    break;

                case 13:

                    Refresh();

                    option2Button.Visible= false;
                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page13;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text15 = "After our fun-filled time at the arcade, we step out, the cool afternoon breeze hitting against our skin. As we stroll along, we think about what to do next.";
                    foreach (char c in text15)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(65, 53, 47);
                    option1Button.ForeColor = Color.FromArgb(205, 199, 187);
                    option1Button.Text = "To The Restaurant";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(65, 53, 47);
                    option2Button.ForeColor = Color.FromArgb(205, 199, 187);
                    option2Button.Text = "To The Mall";
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 14:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page14;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text16 = "We arrive and grab a seat, checking out the menu. I glance at Ace, wondering: should I let him handle the ordering, or do I want to pick for myself?";
                    foreach (char c in text16)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(57, 50, 37);
                    option1Button.ForeColor = Color.FromArgb(197, 143, 86);
                    option1Button.Text = "Let Ace Order";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(57, 50, 37);
                    option2Button.ForeColor = Color.FromArgb(197, 143, 86);
                    option2Button.Text = "Choose Yourself";
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 15:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page26;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text17 = "Since I'm terrible at making decisions, I let Ace take the lead on ordering. We enjoy our meal, chatting and getting to know each other better over the delicious food.";

                    foreach (char c in text17)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option2Button.Text = "Continue";
                    option2Button.BackColor = Color.FromArgb(220, 213, 207);
                    option2Button.ForeColor = Color.FromArgb(54, 60, 61);
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 16:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page28;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text18 = "I look through the menu and order steak and wine with some side dishes. Out food arrives soon and we enjoy our meal, chatting and getting to know each other better over the delicious food.";
                    foreach (char c in text18)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option2Button.Text = "Continue";
                    option2Button.BackColor = Color.FromArgb(197, 143, 86);
                    option2Button.ForeColor = Color.FromArgb(104, 52, 26);
                    option2Button.Visible = true;

                    Refresh();

                    break;

                case 17:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page27;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text19 = "We head to the mall and look through a few stores, but ultimately decide not to buy anything.";
                    foreach (char c in text19)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.BackColor = Color.FromArgb(220, 213, 207);
                    continueButton.ForeColor = Color.FromArgb(54, 60, 61);
                    continueButton.Visible = true;
                    Refresh();


                    break;

                case 18:


                    Refresh();

                    option2Button.Visible= false;
                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page13;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text20 = "After, we decide to visit one last place. Stepping out of the restaurant, we start walking, thinking about where to go next.";
                    foreach (char c in text20)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(57, 50, 37);
                    option1Button.ForeColor = Color.FromArgb(197, 143, 86);
                    option1Button.Text = "To The Park";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(57, 50, 37);
                    option2Button.ForeColor = Color.FromArgb(197, 143, 86);
                    option2Button.Text = "To The Beach";
                    option2Button.Visible = true;

                    Refresh();

                    break;


                case 19:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page29;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text21 = "We make our way to the park, reaching our destination in a short period of time.";
                    foreach (char c in text21)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.BackColor = Color.FromArgb(222, 216, 194);
                    continueButton.ForeColor = Color.FromArgb(51, 59, 35);
                    continueButton.Visible = true;

                    Refresh();

                    break;

                case 20:

                    Refresh();

                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page30;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text22 = "As we arrive, Ace turns to me with his warm smile. 'So, what do you want to do? Should we sit and chat or take a stroll across the park?'";
                    foreach (char c in text22)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(176, 153, 126);
                    option1Button.ForeColor = Color.FromArgb(70, 55, 49);
                    option1Button.Text = "Sit and Chat";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(176, 153, 126);
                    option2Button.ForeColor = Color.FromArgb(70, 55, 49);
                    option2Button.Text = "Take A Stroll";
                    option2Button.Visible = true;
                    

                    Refresh();

                    break;

                case 21:

                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page15;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text23 = "We decide to sit and chat, finding a comfy spot. Sharing stories and laughs, we grow closer. Before we know it, a few hours slip by, lost in each other's company, enjoying every minute of it.";
                    foreach (char c in text23)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.BackColor = Color.FromArgb(202, 200, 184);
                    continueButton.ForeColor = Color.FromArgb(70, 64, 52);
                    continueButton.Visible = true;

                    Refresh();

                    break;

                case 22:

                    Refresh();

                    this.BackgroundImage = Properties.Resources.page33;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text24 = "As we lose track of time in our laughter-filled conversation, we realize evening has arrived. We agree it's time to call it a day. Just as I'm about to stand up, Ace surprises me, asking me to close my eyes.  What should I do?";
                    foreach (char c in text24)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option1Button.BackColor = Color.FromArgb(234, 204, 158);
                    option1Button.ForeColor = Color.FromArgb(70, 64, 52);
                    option1Button.Text = "Close Your eyes";
                    option1Button.Visible = true;

                    Refresh();

                    option2Button.BackColor = Color.FromArgb(234, 204, 158);
                    option2Button.ForeColor = Color.FromArgb(70, 64, 52);
                    option2Button.Text = "Don't Close Them";
                    option2Button.Visible = true;
                    option2Button.Enabled = false; // disabling option

                    Refresh();

                    break;

                case 23:

                    Refresh();

                    continueButton.Visible = false;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page17;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text31 = "Curious, I close my eyes, wondering what's going through Ace's mind. There's a rustling noise, and after a brief pause, Ace asks me to open my eyes. Intrigued, I open my eyes.";
                    foreach (char c in text31)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    Thread.Sleep(2000);
                    this.BackgroundImage = Properties.Resources.page18;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text26 = "As I open my eyes, I see Ace holding a beautiful bouquet of roses, blushing lightly. He thanks me for the wonderful time and expresses how much fun he had. Dumbfounded at first, I slowly break into a warm smile, deeply touched.";
                    foreach (char c in text26)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    Thread.Sleep(2000);
                    this.BackgroundImage = Properties.Resources.page19;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text27 = "Ace hands me the bouquet, and I'm mesmerized by the sight and scent of the roses. Smiling warmly, I thank him for the wonderful time we had together. Accepting his offer to walk me home, we share laughter and conversations on our way.";
                    foreach (char c in text27)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    continueButton.BackColor = Color.FromArgb(171, 112, 72);
                    continueButton.ForeColor = Color.FromArgb(28, 20, 16);
                    continueButton.Visible = true;

                    Refresh();

                    break;

                case 24:
                    this.BackgroundImage = Properties.Resources.page24;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    continueButton.Visible = false;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text28 = "As we reach my house, we share another round of how much fun we had. Looking up at him, I feel a warmth in my chest, and I...";
                    foreach (char c in text28)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    supriseButton.BackColor = Color.FromArgb(185, 175, 157);
                    supriseButton.ForeColor = Color.FromArgb(63, 57, 49);
                    supriseButton.Visible = true;

                    Refresh();

                    break;

                case 26:

                    Refresh();

                    option1Button.Visible = false;
                    continueButton.Visible = false;
                    this.BackgroundImage = Properties.Resources.page31;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text29 = "We walk through the park, enjoying the scenery and each other's company. I start feeling more comfortable with Ace and like him even more. Eventually, he walks me home.";
                    foreach (char c in text29)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option2Button.Text = "Continue";
                    option2Button.BackColor = Color.FromArgb(160, 189, 191);
                    option2Button.ForeColor = Color.FromArgb(63, 57, 49);
                    continueButton.Visible = true;

                    Refresh();

                    break;


                case 25:


                    Refresh();

                    this.BackgroundImage = Properties.Resources.page23; //change of background
                    option1Button.Visible = false;
                    option2Button.Visible = false;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text30 = "After we went to the park, I let out a scream at the sight of a bug. Ace gave me a strange look and asked if I was really scared of a bug. Feeling embarrassed, I remained silent. The atmosphere turned awkward after that, and the date was cut short.";
                    foreach (char c in text30)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    restartButton.BackColor = Color.FromArgb(188, 189, 181);
                    restartButton.ForeColor = Color.FromArgb(61, 92, 124);
                    restartButton.Visible = true;

                    Refresh();

                    break;

                case 27:


                    Refresh();

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.BackgroundImage = Properties.Resources.page32;

                    Refresh();

                    //displaying text
                    textLabel.Text = ""; //clears text
                    string text32 = "We stroll along the beach, enjoying the scenery and each other's company. I find myself growing more comfortable with Ace's presence and liking him even more. Eventually, he walks me home.";
                    foreach (char c in text32)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    Refresh();

                    option2Button.Text = "Continue";
                    option2Button.BackColor = Color.FromArgb(171, 184, 187);
                    option2Button.ForeColor = Color.FromArgb(63, 57, 49);
                    option2Button.Visible = true;

                    Refresh();

                    break;


            }
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 6)
            {
                page = 7;   
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 22)
            {
                page = 23;
            }
            DisplayPage();

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if  (page == 6)
            {
                page = 25;
            }
            else if (page == 7)
            {
                page = 9;

            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page ==10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 27;
            }
            else if (page == 20)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 24;
            }
            else if (page == 27)
            {
                page = 24;
            }
            DisplayPage();

        }

        private void supriseButton_Click(object sender, EventArgs e)
        {

            option1Button.Visible = false;
            option2Button.Visible = false;
            supriseButton.Visible = false;

            if (page == 24)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101); // Generate a random number between 1 and 100

                if (randomNumber <= 60)
                {
                    this.BackgroundImage = Properties.Resources.page21;
                    Refresh();

                    // 60% chance: Hug
                    textLabel.Text = ""; //clears text
                    string text24 = "Give him a warm hug, looking up at him with a smile. 'I loved every part of the date.' I say before bidding goodbye and heading home, leaving him speechless.";
                    foreach (char c in text24)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    restartButton.Visible = true;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.page22;
                    Refresh();

                    // 40% chance: Kiss on cheek
                    textLabel.Text = "";
                    string text25 = "Go on my tiptoes, I give him a soft kiss on the cheek. 'I loved every part of the date.' I whisper, excitement bubbling for the next one. With a smile, I say goodbye and head inside, leaving him dumbfounded with red cheeks.";
                    foreach (char c in text25)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(13);
                        textLabel.Refresh();
                    }

                    restartButton.Visible = true;
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Refresh();

            restartButton.Visible = false;
            page = 1; // Reset the page to its initial value
            DisplayPage();

            Refresh(); 

        }
    }
}

//it comes up to 10 questions with the random  