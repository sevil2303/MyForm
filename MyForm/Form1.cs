using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer background = new System.Media.SoundPlayer(Properties.Resources.success_1_6297);
        string firstname = "";
        string lastname = "";
        string gender = "";
        string speciality = "";
        string email = "";
        string number = "";
        string country = "";
        string city = "";
        string address = "";
        string citizen = "";
        List<string> languages = new List<string> { };
        DateTime birthdate = DateTime.MinValue;
        string info = "";
        public Form1()
        {
            InitializeComponent();
        }
        class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Gender { get; set; }
            public string Speciality { get; set; }
            public string Email { get; set; }
            public string Number { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string Citizen { get; set; }
            public DateTime BirthDate { get; set; }
            public List<string> Languages { get; set; }
            public void Show()
            {
                Console.WriteLine($"First name : {Firstname}");
                Console.WriteLine($"Last name : {Lastname}");
                Console.WriteLine($"Gender : {Gender}");
                Console.WriteLine($"E-mail : {Email}");
                Console.WriteLine($"Number : {Number}");
                Console.WriteLine($"Country : {Country}");
                Console.WriteLine($"City : {City}");
                Console.WriteLine($"Address : {Address}");
                Console.WriteLine($"Citizen : {Citizen}");
                Console.WriteLine($"BirthDate : {BirthDate}");
                Console.WriteLine($"Languages : ");
                for (int i = 0; i < Languages.Count; i++)
                {
                    Console.WriteLine(Languages[i]); 
                }
            }
        }
        private void firstnameTxb_TextChanged(object sender, EventArgs e)
        {
            firstname = firstnameTxb.Text;
        }

        private void lastnameTxb_TextChanged(object sender, EventArgs e)
        {
            lastname = lastnameTxb.Text;
        }

        private void maleBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = maleBtn.Text;
        }

        private void femaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = femaleBtn.Text;
        }

        private void specialityTxb_TextChanged(object sender, EventArgs e)
        {
            speciality = specialityTxb.Text;
        }

        private void emailTxb_TextChanged(object sender, EventArgs e)
        {
            email = emailTxb.Text;
        }

        private void birthdatetime_ValueChanged(object sender, EventArgs e)
        {
            birthdate = birthdatetime.Value;
        }

        private void mobiletxb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            number = mobiletxb.Text;
        }

        private void countryTxb_TextChanged(object sender, EventArgs e)
        {
            country = countryTxb.Text;
        }

        private void cityTxb_TextChanged(object sender, EventArgs e)
        {
            city = cityTxb.Text;
        }

        private void addressTxb_TextChanged(object sender, EventArgs e)
        {
            address = addressTxb.Text;
        }

        private void yesBtn_CheckedChanged(object sender, EventArgs e)
        {
            citizen = "Azerbaijani";
        }

        private void noBtn_CheckedChanged(object sender, EventArgs e)
        {
            citizen = "not Azerbaijani";
        }

        private void engChbox_CheckedChanged(object sender, EventArgs e)
        {
            languages.Add(engChbox.Text);
        }

        private void germanChbox_CheckedChanged(object sender, EventArgs e)
        {
            languages.Add(germanChbox.Text);
        }

        private void arabianChbox_CheckedChanged(object sender, EventArgs e)
        {
            languages.Add(arabianChbox.Text);
        }

        private void azChbox_CheckedChanged(object sender, EventArgs e)
        {
            languages.Add(azChbox.Text);
        }

        private void turkChbox_CheckedChanged(object sender, EventArgs e)
        {
            languages.Add(turkChbox.Text);
        }

        private void spainChbox_CheckedChanged(object sender, EventArgs e)
        {
            languages.Add(spainChbox.Text);
        }      
        private void submitBtn_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Firstname = firstname;
            person.Lastname = lastname;
            person.Gender = gender;
            person.Speciality = speciality;
            person.Email = email;
            person.Number = number;
            person.Country = country;
            person.City = city;
            person.Address = address;
            person.Citizen = citizen;
            person.BirthDate = birthdate;
            person.Languages = languages;

            if (firstnameTxb.Text == "")
            {
                firstwarnLbl.Text = "this field is required";
            }
            if (lastnameTxb.Text == "")
            {
                lastwarnLbl.Text = "this field is required";
            }
            if (maleBtn.Text == "" && femaleBtn.Text == "")
            {
                genderwarnLbl.Text = "this field is required";
            }
            if (specialityTxb.Text == "")
            {
                specialtiywarnLbl.Text = "this field is required";
            }
            if (emailTxb.Text == "")
            {
                emailTxb.Text = "this field is required";
            }
            if (mobiletxb.Text == "")
            {
                numberwarnLbl.Text = "this field is required";
            }
            if (countryTxb.Text == "")
            {
                countrywarnLbl.Text = "this field is required";
            }
            if (cityTxb.Text == "")
            {
                citywarnLbl.Text = "this field is required";
            }
            if (addressTxb.Text == "")
            {
                addresswarnLbl.Text = "this field is required";
            }
            if (birthdate == DateTime.MinValue)
            {
                birthdatewarnLbl.Text = "this field is required";
            }
            if (engChbox.Text == "" && germanChbox.Text == "" && azChbox.Text == "" && turkChbox.Text == "" && spainChbox.Text == "" && arabianChbox.Text == "")
            {
                languageswarnLbl.Text = "this field is required";
            }
            else
            {
                Write(person);
                background.Play();
                MessageBox.Show("Your form is sent successfully!");
                var read=Read(person);
                read.Show();
            }
        }
    }
}
