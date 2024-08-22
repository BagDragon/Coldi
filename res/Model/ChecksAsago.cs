namespace Coldi.res.Model
{
    class ChecksAsago
    {


        public static void Score(ComboBox RegComboBox, ComboBox CityComboBox, Label ScoreKof)
        {

            int selectedIndex = CityComboBox.SelectedIndex;

            if (RegComboBox.SelectedItem.ToString() == "Ульяновская область")
            {
                string[] kof =
                   {
                    "1,1",
                    "1,4",
                    "0,8"
                };

                if (selectedIndex >= 0 && selectedIndex < kof.Length)
                {
                    ScoreKof.Text = kof[selectedIndex].ToString();
                }


            }

            //////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Пензенская область")
            {
                string[] kof =
                                 {
                    "1,2",
                    "1",
                    "1,4",
                    "0,7"
                };

                if (selectedIndex >= 0 && selectedIndex < kof.Length)
                {
                    ScoreKof.Text = kof[selectedIndex].ToString();
                }
            }

            //////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Самарская область")
            {
                string[] kof =
                   {
                    "1,1",
                    "1,1",
                    "1,6",
                    "1,5",
                    "1,2",
                    "0,9"
                };

                if (selectedIndex >= 0 && selectedIndex < kof.Length)
                {
                    ScoreKof.Text = kof[selectedIndex].ToString();
                }
            }

            ////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Республика Башкортостан")
            {
                string[] kof =
                  {
                    "1,2",
                    "1,1",
                    "1,3",
                    "1,8",
                    "1"
                };

                if (selectedIndex >= 0 && selectedIndex < kof.Length)
                {
                    ScoreKof.Text = kof[selectedIndex].ToString();
                }
            }

            //////////////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Республика Татарстан")
            {
                string[] kof =
                   {
                    "1,3",
                    "1,3",
                    "1",
                    "1",
                    "1,2",
                    "2",
                    "1,7",
                    "1,1"
                };

                if (selectedIndex >= 0 && selectedIndex < kof.Length)
                {
                    ScoreKof.Text = kof[selectedIndex].ToString();
                }
            }

        }




        public static void checkReg(ComboBox RegComboBox, ComboBox CityComboBox)
        {
            if (RegComboBox.SelectedItem.ToString() == "Ульяновская область")
            {

                string[] city =
             {
                 "Димитровград",
                "Ульяновск",
                "Прочие города"
            };



                foreach (string items in city)
                {

                    CityComboBox.Items.Add(items);

                }



            }

            //////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Пензенская область")
            {
                string[] city =
             {
                "Заречный",
                "Кузнецк",
                "Пенза",
                "Прочие города"
            };

                foreach (string items in city)
                {
                    CityComboBox.Items.Add(items);
                }
            }

            //////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Самарская область")
            {
                string[] city =
             {
               "Новокуйбышев",
                "Сызрань",
                "Самара",
                "Тольятти",
                "Чепаевск",
                "Прочие города"
            };

                foreach (string items in city)
                {
                    CityComboBox.Items.Add(items);
                }
            }

            ////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Республика Башкортостан")
            {
                string[] city =
             {
               "Благовещенск",
                "Салават",
                "Стерлитамак",
                "Уфа",
                "Прочие города"
            };

                foreach (string items in city)
                {
                    CityComboBox.Items.Add(items);
                }
            }

            //////////////////////////////////////////

            if (RegComboBox.SelectedItem.ToString() == "Республика Татарстан")
            {
                string[] city =
             {
               "Альметьевск",
                "Нижнекамск",
                "Бугульма",
                "Елабуга",
                "Казань",
                "Набережные Челны",
                "Прочие города"
            };

                foreach (string items in city)
                {
                    CityComboBox.Items.Add(items);
                }
            }
        }

        public static void CheckAge_and_Experience(TextBox AgeTextBox, TextBox ExperienceTextBox, Label kofAge_andExperience)
        {
            int Age = int.Parse(AgeTextBox.Text);
            int Experience = int.Parse(ExperienceTextBox.Text);

            if (Age <= 22 && Experience <= 3)
            {
                kofAge_andExperience.Text = "1,8";//
            }
            if (Age <= 22 && Experience > 3)
            {
                kofAge_andExperience.Text = "1,6";
            }
            if (Age > 22 && Experience <= 3)
            {
                kofAge_andExperience.Text = "1,7";
            }
            if (Age > 22 && Experience > 3)
            {
                kofAge_andExperience.Text = "1,0";
            }

        }

        public static void CheckCountDriver(RadioButton limited, RadioButton unlimited, Label kofDrivers)
        {
            if (limited.Checked == true)
            {
                kofDrivers.Text = "1,0";
            }
            if (unlimited.Checked == true)
            {
                kofDrivers.Text = "1,8";
            }

        }

        public static void Check_KMB(Label kmb, TextBox ExperienceTextBox, RadioButton unlimited)
        {
            int Exp = int.Parse(ExperienceTextBox.Text);

            double Kof_kmb = 3.92;//yes

            for (int i = 1; i <= Exp; i++)
            {
                Kof_kmb = Kof_kmb - 0.173;

            }
            if (Kof_kmb <= 0.47)
            {
                MessageBox.Show("Вы достигли минимума");
                Kof_kmb = 0.47;
            }
            if (unlimited.Checked == true)
            {
                Kof_kmb = 1.94;
            }
            double KMBRound = Math.Round(Kof_kmb, 2);
            kmb.Text = KMBRound.ToString();

        }

        public static void Check_Power(TextBox PowerTextBox, Label kofPower)
        {
            int kmCount = int.Parse(PowerTextBox.Text);

            if (kmCount <= 50)
            {
                kofPower.Text = "0,6";
            }
            if (kmCount >= 51 && kmCount <= 70)
            {
                kofPower.Text = "1,0";
            }
            if (kmCount >= 71 && kmCount <= 100)
            {
                kofPower.Text = "1,1";
            }
            if (kmCount >= 101 && kmCount <= 120)
            {
                kofPower.Text = "1,2";
            }
            if (kmCount >= 121 && kmCount <= 150)
            {
                kofPower.Text = "1,4";
            }
            if (kmCount >= 151)
            {
                kofPower.Text = "1,6";
            }

        }

        public static void CheckTarif(ComboBox TransportСategoryСomboBox, Label kofTarig)
        {
            int selectCateg = TransportСategoryСomboBox.SelectedIndex;
            string[] kof =
                  {
                    "1215",
                    "1980",
                    "2025"

                };

            if (selectCateg >= 0 && selectCateg < kof.Length)
            {
                kofTarig.Text = kof[selectCateg].ToString();
            }
        }
    }
}
