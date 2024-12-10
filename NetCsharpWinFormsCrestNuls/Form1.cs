namespace NetCsharpWinFormsCrestNuls
{


    public partial class Form1 : Form
    {
        bool isStarted { get; set; }
        bool isFinish { get; set; }
       List<MyButton> buttons;
        public Form1()
        {
            InitializeComponent();
           
            buttons = new List<MyButton>();
            buttons.Add(new MyButton(button1));
            buttons.Add(new MyButton(button2));
            buttons.Add(new MyButton(button3));
            buttons.Add(new MyButton(button4));
            buttons.Add(new MyButton(button5));
            buttons.Add(new MyButton(button6));
            buttons.Add(new MyButton(button7));
            buttons.Add(new MyButton(button8));
            buttons.Add(new MyButton(button9));
        }
        public void Check(string b)
        {
            if (b == "X")
            {
                MessageBox.Show("Выиграли крестики", "Крестики-Нолики", MessageBoxButtons.OK);
                isFinish = true;
                return;
            }
            else if (b == "O")
                {
                    MessageBox.Show("Выиграли нолики", "Крестики-Нолики", MessageBoxButtons.OK);
                isFinish = true;
                return;
                }
           
        }
        //start button
        private void button10_Click(object sender, EventArgs e)
        {
             isStarted = true;
            isFinish = false;  

           
            foreach (var button in buttons)
            {
                button.butt.Image = null; 
                button.isOpen = false;     
                button.who = "";           
            }

            if (checkBox1.Checked)
            {
                Bitmap img = new Bitmap("X.jpg");
                
                foreach (var button in buttons) { 
                if (!button.isOpen)
                    {
                        button.butt.Image = img;
                        button.who = "X";
                        button.isOpen = true;
                        break;
                    }
                }
            }
        }
        //icon_button
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (isStarted==false)
            {
                MessageBox.Show("Игра еще не начата","Крестики-Нолики", MessageBoxButtons.OK);
            }
            if(!isFinish)
            {
               
              
                Bitmap img = new Bitmap("O.jpg");
                Button b = (sender as Button);

                if (buttons.Find(a => a.butt == b).isOpen)
                {
                    MessageBox.Show("Вы не можете занять это поле", "Крестики-Нолики", MessageBoxButtons.OK);
                }
                else
                {
                    buttons.Find(a => a.butt == b).butt.Image = img;
                    buttons.Find(a => a.butt == b).who = "O";
                    buttons.Find(a => a.butt == b).isOpen = true;
                    CheckComb();
                    if (!isFinish)
                    {
                        Bitmap img2 = new Bitmap("X.jpg");
                        foreach (var button in buttons)
                        {
                            if (!button.isOpen)
                            {
                                button.butt.Image = img2;
                                button.who = "X";
                                button.isOpen = true;
                                break;
                            }
                        }
                        CheckComb();
                    }

                }

               
              
                  
                






                
            }
            
        }
        public void CheckComb()
        {
            string mybutton1 = buttons.Find(a => a.butt == button1).who;
            string mybutton2 = buttons.Find(a => a.butt == button2).who;
            string mybutton3 = buttons.Find(a => a.butt == button3).who;
            string mybutton4 = buttons.Find(a => a.butt == button4).who;
            string mybutton5 = buttons.Find(a => a.butt == button5).who;
            string mybutton6 = buttons.Find(a => a.butt == button6).who;
            string mybutton7 = buttons.Find(a => a.butt == button7).who;
            string mybutton8 = buttons.Find(a => a.butt == button8).who;
            string mybutton9 = buttons.Find(a => a.butt == button9).who;
            if ((mybutton1 != "" && mybutton1 == mybutton2 && mybutton1 == mybutton3) || (mybutton4 != "" && mybutton4 == mybutton5 && mybutton4 == mybutton6) ||
                              (mybutton7 != "" && mybutton7 == mybutton8 && mybutton7 == mybutton9) || (mybutton1 != "" && mybutton1 == mybutton4 && mybutton1 == mybutton7) ||
                              (mybutton2 != "" && mybutton2 == mybutton5 && mybutton2 == mybutton8) || (mybutton3 != "" && mybutton3 == mybutton6 && mybutton3 == mybutton9) ||
                              (mybutton1 != "" && mybutton1 == mybutton5 && mybutton1 == mybutton9) || (mybutton3 != "" && mybutton3 == mybutton5 && mybutton3 == mybutton7))
            {
                if (mybutton1 == mybutton2 && mybutton1 == mybutton3)
                {
                    Check(mybutton1);
                    return;
                }
                else if (mybutton4 == mybutton5 && mybutton4 == mybutton6)
                {
                    Check(mybutton4);
                    return;
                }
                else if (mybutton7 == mybutton8 && mybutton7 == mybutton9)
                {
                    Check(mybutton7);
                    return;
                }
                else if (mybutton1 == mybutton4 && mybutton1 == mybutton7)
                {
                    Check(mybutton1);
                    return;
                }
                else if (mybutton2 == mybutton5 && mybutton2 == mybutton8)
                {
                    Check(mybutton2);
                    return;
                }
                else if (mybutton3 == mybutton6 && mybutton3 == mybutton9)
                {
                    Check(mybutton3);
                    return;
                }
                else if (mybutton1 == mybutton5 && mybutton1 == mybutton9)
                {
                    Check(mybutton1);
                    return;
                }
                else if (mybutton3 == mybutton5 && mybutton3 == mybutton7)
                {
                    Check(mybutton3);
                    return;
                }
                

            }
        }
    }
   
    public class MyButton
    {
        public Button butt { get; set; }
        public bool isOpen { get; set; }
        public string who {  get; set; }
        public MyButton() { }
        public MyButton(Button b)
        {
            butt = b;
            isOpen = false;
            who = "";
        }
    }
}
