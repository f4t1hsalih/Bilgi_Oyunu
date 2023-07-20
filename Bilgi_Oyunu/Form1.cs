namespace Bilgi_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlýs = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Focus();

            if (linkLabel1.Text == "Baþla")
            {
                button1.Text = "";
                soruno = 0;
                dogru = 0;
                yanlýs = 0;
                labelDogru.Text = "0";
                labelYanlis.Text = "0";

                buttonA.BackColor = Color.Transparent;
                buttonB.BackColor = Color.Transparent;
                buttonC.BackColor = Color.Transparent;
                buttonD.BackColor = Color.Transparent;
                buttonE.BackColor = Color.Transparent;
                buttonF.BackColor = Color.Transparent;
                buttonG.BackColor = Color.Transparent;
                buttonH.BackColor = Color.Transparent;
                buttonI.BackColor = Color.Transparent;
                buttonni.BackColor = Color.Transparent;
                buttonJ.BackColor = Color.Transparent;
                buttonK.BackColor = Color.Transparent;
                buttonL.BackColor = Color.Transparent;
                buttonM.BackColor = Color.Transparent;
                buttonN.BackColor = Color.Transparent;
                buttonO.BackColor = Color.Transparent;
                buttonP.BackColor = Color.Transparent;
                buttonR.BackColor = Color.Transparent;
                buttonS.BackColor = Color.Transparent;
                buttonT.BackColor = Color.Transparent;
                buttonU.BackColor = Color.Transparent;
                buttonV.BackColor = Color.Transparent;
                buttonY.BackColor = Color.Transparent;
                buttonZ.BackColor = Color.Transparent;

                linkLabel1.Text = "Sonraki";
            }
            if (textBox1.Text != "")
            {
                denetle();
                textBox1.Enabled = true;

                soruno++;
                this.Text = soruno.ToString();

                textBox1.Clear();

                if (soruno == 1)
                {
                    richTextBox1.Text = "Türkiyenin Baþkenti neresidir?";
                    buttonA.BackColor = Color.Yellow;
                }
                else if (soruno == 2)
                {
                    richTextBox1.Text = "Yeþilliði ile ünlü marmara ilimiz?";
                    buttonB.BackColor = Color.Yellow;
                }
                else if (soruno == 3)
                {
                    richTextBox1.Text = "Müslümanlarýn kutsal günü?";
                    buttonC.BackColor = Color.Yellow;
                }
                else if (soruno == 4)
                {
                    richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                    buttonD.BackColor = Color.Yellow;
                }
                else if (soruno == 5)
                {
                    richTextBox1.Text = "Yeni kelimesinin zýt anlamlýsý?";
                    buttonE.BackColor = Color.Yellow;
                }
                else if (soruno == 6)
                {
                    richTextBox1.Text = "Padiþahýn emirlerinin yazýlý hali?";
                    buttonF.BackColor = Color.Yellow;
                }
                else if (soruno == 7)
                {
                    richTextBox1.Text = "Dünyanýn ýsý kaynaðý?";
                    buttonG.BackColor = Color.Yellow;
                }
                else if (soruno == 8)
                {
                    richTextBox1.Text = "Öðrencilerin kötü karne getirince bakýþtýðý nesne?";
                    buttonH.BackColor = Color.Yellow;
                }
                else if (soruno == 9)
                {
                    richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                    buttonI.BackColor = Color.Yellow;
                }
                else if (soruno == 10)
                {
                    richTextBox1.Text = "Mersinin diðer ismi?";
                    buttonni.BackColor = Color.Yellow;
                }
                else if (soruno == 11)
                {
                    richTextBox1.Text = "Askeri bir topluluk?";
                    buttonJ.BackColor = Color.Yellow;
                }
                else if (soruno == 12)
                {
                    richTextBox1.Text = "Malatyanýn meþhur meyvesi?";
                    buttonK.BackColor = Color.Yellow;
                }
                else if (soruno == 13)
                {
                    richTextBox1.Text = "Her yýl bahar aylarýnda düzenlenen meþhur çiçek festivali?";
                    buttonL.BackColor = Color.Yellow;
                }
                else if (soruno == 14)
                {
                    richTextBox1.Text = "Yýlýn üçüncü ayý?";
                    buttonM.BackColor = Color.Yellow;
                }
                else if (soruno == 15)
                {
                    richTextBox1.Text = "Üflemeli bir müzik aleti?";
                    buttonN.BackColor = Color.Yellow;
                }
                else if (soruno == 16)
                {
                    richTextBox1.Text = "Halk Þairi?";
                    buttonO.BackColor = Color.Yellow;
                }
                else if (soruno == 17)
                {
                    richTextBox1.Text = "Çocuklarýn pek sevmediði pirinç havuç gibi sebzeleer ile yapýlan yemek?";
                    buttonP.BackColor = Color.Yellow;
                }
                else if (soruno == 18)
                {
                    richTextBox1.Text = "11 Ayýn sultaný?";
                    buttonR.BackColor = Color.Yellow;
                }
                else if (soruno == 19)
                {
                    richTextBox1.Text = "Ýngilizcede yýlan?";
                    buttonS.BackColor = Color.Yellow;
                }
                else if (soruno == 20)
                {
                    richTextBox1.Text = "Saçlarý taramaya yarayan alet?";
                    buttonT.BackColor = Color.Yellow;
                }
                else if (soruno == 21)
                {
                    richTextBox1.Text = "Ümit kelimesinin eþ anlamlýsý?";
                    buttonU.BackColor = Color.Yellow;
                }
                else if (soruno == 22)
                {
                    richTextBox1.Text = "Kedisi ile ünlü ilimiz?";
                    buttonV.BackColor = Color.Yellow;
                }
                else if (soruno == 23)
                {
                    richTextBox1.Text = "Þimþek kelimesinin eþ anlamlýsý?";
                    buttonY.BackColor = Color.Yellow;
                }
                else if (soruno == 24)
                {
                    richTextBox1.Text = "Ege bölgesinin en çok aðacý bulunan yaðý da yapýlan bir kahvaltý besini?";
                    buttonZ.BackColor = Color.Yellow;
                }
                else
                {
                    this.Text = "Yarýþma Bitti";
                    linkLabel1.Text = "Baþla";
                    textBox1.Text = "***";
                    textBox1.Enabled = false;
                    button1.Text = "Yarýþma Bitti \n" + dogru.ToString() + " Adet Doðrunuz\n"+yanlýs.ToString()+ " Adet Yanlýþýnýz\n Var";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Cevap Giriniz!");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            denetle(e);
        }

        void denetle()
        {
            switch (soruno)
            {
                case 1:
                    if (textBox1.Text.ToLower() == "ankara")
                    {
                        buttonA.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonA.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 2:
                    if (textBox1.Text.ToLower() == "bursa")
                    {
                        buttonB.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonB.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 3:
                    if (textBox1.Text.ToLower() == "cuma")
                    {
                        buttonC.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonC.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 4:
                    if (textBox1.Text.ToLower() == "diyarbakýr")
                    {
                        buttonD.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonD.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 5:
                    if (textBox1.Text.ToLower() == "eski")
                    {
                        buttonE.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonE.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 6:
                    if (textBox1.Text.ToLower() == "ferman")
                    {
                        buttonF.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonF.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 7:
                    if (textBox1.Text.ToLower() == "güneþ")
                    {
                        buttonG.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonG.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 8:
                    if (textBox1.Text.ToLower() == "halý")
                    {
                        buttonH.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonH.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 9:
                    if (textBox1.Text.ToLower() == "ýsparta")
                    {
                        buttonI.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonI.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 10:
                    if (textBox1.Text.ToLower() == "içel")
                    {
                        buttonni.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonni.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 11:
                    if (textBox1.Text.ToLower() == "jandarma")
                    {
                        buttonJ.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonJ.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 12:
                    if (textBox1.Text.ToLower() == "kayýsý")
                    {
                        buttonK.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonK.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 13:
                    if (textBox1.Text.ToLower() == "lale")
                    {
                        buttonL.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonL.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 14:
                    if (textBox1.Text.ToLower() == "mart")
                    {
                        buttonM.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonM.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 15:
                    if (textBox1.Text.ToLower() == "ney")
                    {
                        buttonN.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonN.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 16:
                    if (textBox1.Text.ToLower() == "ozan")
                    {
                        buttonO.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonO.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 17:
                    if (textBox1.Text.ToLower() == "pýrasa")
                    {
                        buttonP.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonP.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 18:
                    if (textBox1.Text.ToLower() == "ramazan")
                    {
                        buttonR.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonR.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 19:
                    if (textBox1.Text.ToLower() == "snake")
                    {
                        buttonS.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonS.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 20:
                    if (textBox1.Text.ToLower() == "tarak")
                    {
                        buttonT.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonT.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 21:
                    if (textBox1.Text.ToLower() == "umut")
                    {
                        buttonU.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonU.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 22:
                    if (textBox1.Text.ToLower() == "van")
                    {
                        buttonV.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonV.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 23:
                    if (textBox1.Text.ToLower() == "yýldýrým")
                    {
                        buttonY.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonY.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
                case 24:
                    if (textBox1.Text.ToLower() == "zeytin")
                    {
                        buttonZ.BackColor = Color.Green;
                        dogru++;
                        labelDogru.Text = dogru.ToString();
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        buttonZ.BackColor = Color.Red;
                        yanlýs++;
                        labelYanlis.Text = yanlýs.ToString();
                        textBox1.Enabled = false;
                    }
                    break;
            }
        }

        void denetle(KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    switch (soruno)
                    {
                        case 1:
                            if (textBox1.Text.ToLower() == "ankara")
                            {
                                buttonA.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonA.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 2:
                            if (textBox1.Text.ToLower() == "bursa")
                            {
                                buttonB.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonB.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 3:
                            if (textBox1.Text.ToLower() == "cuma")
                            {
                                buttonC.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonC.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 4:
                            if (textBox1.Text.ToLower() == "diyarbakýr")
                            {
                                buttonD.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonD.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 5:
                            if (textBox1.Text.ToLower() == "eski")
                            {
                                buttonE.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonE.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 6:
                            if (textBox1.Text.ToLower() == "ferman")
                            {
                                buttonF.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonF.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 7:
                            if (textBox1.Text.ToLower() == "güneþ")
                            {
                                buttonG.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonG.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 8:
                            if (textBox1.Text.ToLower() == "halý")
                            {
                                buttonH.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonH.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 9:
                            if (textBox1.Text.ToLower() == "ýsparta")
                            {
                                buttonI.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonI.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 10:
                            if (textBox1.Text.ToLower() == "içel")
                            {
                                buttonni.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonni.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 11:
                            if (textBox1.Text.ToLower() == "jandarma")
                            {
                                buttonJ.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonJ.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 12:
                            if (textBox1.Text.ToLower() == "kayýsý")
                            {
                                buttonK.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonK.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 13:
                            if (textBox1.Text.ToLower() == "lale")
                            {
                                buttonL.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonL.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 14:
                            if (textBox1.Text.ToLower() == "mart")
                            {
                                buttonM.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonM.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 15:
                            if (textBox1.Text.ToLower() == "ney")
                            {
                                buttonN.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonN.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 16:
                            if (textBox1.Text.ToLower() == "ozan")
                            {
                                buttonO.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonO.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 17:
                            if (textBox1.Text.ToLower() == "pýrasa")
                            {
                                buttonP.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonP.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 18:
                            if (textBox1.Text.ToLower() == "ramazan")
                            {
                                buttonR.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonR.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 19:
                            if (textBox1.Text.ToLower() == "snake")
                            {
                                buttonS.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonS.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 20:
                            if (textBox1.Text.ToLower() == "tarak")
                            {
                                buttonT.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonT.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 21:
                            if (textBox1.Text.ToLower() == "umut")
                            {
                                buttonU.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonU.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 22:
                            if (textBox1.Text.ToLower() == "van")
                            {
                                buttonV.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonV.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 23:
                            if (textBox1.Text.ToLower() == "yýldýrým")
                            {
                                buttonY.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonY.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                        case 24:
                            if (textBox1.Text.ToLower() == "zeytin")
                            {
                                buttonZ.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                buttonZ.BackColor = Color.Red;
                                yanlýs++;
                                labelYanlis.Text = yanlýs.ToString();
                                textBox1.Enabled = false;
                            }
                            break;
                    }
                }
            }
            
        }

    }
}