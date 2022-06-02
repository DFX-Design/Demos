using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Airline
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Purdue_Airlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlDataAdapter adapt;
        int ID = 0;

        

            public Form1()
        {
            InitializeComponent();


            this.comboBox1.SelectedIndex = 0;

            

            
        }


   
        

       
        
        private void ValidateEmail()
        {
            string email = textBox9.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Purdue_Airlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Middle_Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Last_Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@Street_Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@City", textBox5.Text);
                cmd.Parameters.AddWithValue("@State", textBox6.Text);
                cmd.Parameters.AddWithValue("@Zip", textBox7.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", textBox8.Text);
                cmd.Parameters.AddWithValue("@Email_Address", textBox9.Text);


                con.Open();
                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Your reservation is complete.");
                }
            }


            else
                MessageBox.Show("Please enter a valid email address.");
                return;
        }

        private void Flight1()
        {
            

            string value = "";
            bool A1Bool = A1.Checked;
            if (A1Bool)
                value = A1.Text;
            bool A2Bool = A2.Checked;
            if (A2Bool)
                value = A2.Text;
            bool A3Bool = A3.Checked;
            if (A3Bool)
                value = A3.Text;
            bool A4Bool = A4.Checked;
            if (A4Bool)
                value = A4.Text;
            bool B1Bool = B1.Checked;
            if (B1Bool)
                value = B1.Text;
            bool B2Bool = B2.Checked;
            if (B2Bool)
                value = B2.Text;
            bool B3Bool = B3.Checked;
            if (B3Bool)
                value = B3.Text;
            bool B4Bool = B4.Checked;
            if (B4Bool)
                value = B4.Text;
            bool C1Bool = C1.Checked;
            if (C1Bool)
                value = C1.Text;
            bool C2Bool = C2.Checked;
            if (C2Bool)
                value = C2.Text;
            bool C3Bool = C3.Checked;
            if (C3Bool)
                value = C3.Text;
            bool C4Bool = C4.Checked;
            if (C4Bool)
                value = C4.Text;
            bool D1Bool = D1.Checked;
            if (D1Bool)
                value = D1.Text;
            bool D2Bool = D2.Checked;
            if (D2Bool)
                value = D2.Text;
            bool D3Bool = D3.Checked;
            if (D3Bool)
                value = D3.Text;
            bool D4Bool = D4.Checked;
            if (D4Bool)
                value = D4.Text;
            bool E1Bool = E1.Checked;
            if (E1Bool)
                value = E1.Text;
            bool E2Bool = E2.Checked;
            if (E2Bool)
                value = E2.Text;
            bool E3Bool = E3.Checked;
            if (E3Bool)
                value = E3.Text;
            bool E4Bool = E4.Checked;
            if (E4Bool)
                value = E4.Text;
            bool F1Bool = F1.Checked;
            if (F1Bool)
                value = F1.Text;
            bool F2Bool = F2.Checked;
            if (F2Bool)
                value = F2.Text;
            bool F3Bool = F3.Checked;
            if (F3Bool)
                value = F3.Text;
            bool F4Bool = F4.Checked;
            if (F4Bool)
                value = F4.Text;
            bool G1Bool = G1.Checked;
            if (G1Bool)
                value = G1.Text;
            bool G2Bool = G2.Checked;
            if (G2Bool)
                value = G2.Text;
            bool G3Bool = G3.Checked;
            if (G3Bool)
                value = G3.Text;
            bool G4Bool = G4.Checked;
            if (G4Bool)
                value = G4.Text;
            bool H1Bool = H1.Checked;
            if (H1Bool)
                value = H1.Text;

            bool H2Bool = H2.Checked;
            if (H2Bool)
                value = H2.Text;

            bool H3Bool = H3.Checked;
            if (H3Bool)
                value = H3.Text;

            bool H4Bool = H4.Checked;
            if (H4Bool)
                value = H4.Text;
            bool I1Bool = I1.Checked;
            if (I1Bool)
                value = I1.Text;

            bool I2Bool = I2.Checked;
            if (I2Bool)
                value = I2.Text;

            bool I3Bool = I3.Checked;
            if (I3Bool)
                value = I3.Text;

            bool I4Bool = I4.Checked;
            if (I4Bool)
                value = I4.Text;
            bool J1Bool = J1.Checked;
            if (J1Bool)
                value = J1.Text;

            bool J2Bool = J2.Checked;
            if (J2Bool)
                value = J2.Text;

            bool J3Bool = J3.Checked;
            if (J3Bool)
                value = J3.Text;

            bool J4Bool = J4.Checked;
            if (J4Bool)
                value = J4.Text;

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Purdue_Airlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("sp_insert1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email_Address", textBox9.Text);
            cmd.Parameters.Add("@Seat_Number", value);
            

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Flight2()
        {

            string value = "";
            bool A1Bool = A1.Checked;
            if (A1Bool)
                value = A1.Text;
            bool A2Bool = A2.Checked;
            if (A2Bool)
                value = A2.Text;
            bool A3Bool = A3.Checked;
            if (A3Bool)
                value = A3.Text;
            bool A4Bool = A4.Checked;
            if (A4Bool)
                value = A4.Text;
            bool B1Bool = B1.Checked;
            if (B1Bool)
                value = B1.Text;
            bool B2Bool = B2.Checked;
            if (B2Bool)
                value = B2.Text;
            bool B3Bool = B3.Checked;
            if (B3Bool)
                value = B3.Text;
            bool B4Bool = B4.Checked;
            if (B4Bool)
                value = B4.Text;
            bool C1Bool = C1.Checked;
            if (C1Bool)
                value = C1.Text;
            bool C2Bool = C2.Checked;
            if (C2Bool)
                value = C2.Text;
            bool C3Bool = C3.Checked;
            if (C3Bool)
                value = C3.Text;
            bool C4Bool = C4.Checked;
            if (C4Bool)
                value = C4.Text;
            bool D1Bool = D1.Checked;
            if (D1Bool)
                value = D1.Text;
            bool D2Bool = D2.Checked;
            if (D2Bool)
                value = D2.Text;
            bool D3Bool = D3.Checked;
            if (D3Bool)
                value = D3.Text;
            bool D4Bool = D4.Checked;
            if (D4Bool)
                value = D4.Text;
            bool E1Bool = E1.Checked;
            if (E1Bool)
                value = E1.Text;
            bool E2Bool = E2.Checked;
            if (E2Bool)
                value = E2.Text;
            bool E3Bool = E3.Checked;
            if (E3Bool)
                value = E3.Text;
            bool E4Bool = E4.Checked;
            if (E4Bool)
                value = E4.Text;
            bool F1Bool = F1.Checked;
            if (F1Bool)
                value = F1.Text;
            bool F2Bool = F2.Checked;
            if (F2Bool)
                value = F2.Text;
            bool F3Bool = F3.Checked;
            if (F3Bool)
                value = F3.Text;
            bool F4Bool = F4.Checked;
            if (F4Bool)
                value = F4.Text;
            bool G1Bool = G1.Checked;
            if (G1Bool)
                value = G1.Text;
            bool G2Bool = G2.Checked;
            if (G2Bool)
                value = G2.Text;
            bool G3Bool = G3.Checked;
            if (G3Bool)
                value = G3.Text;
            bool G4Bool = G4.Checked;
            if (G4Bool)
                value = G4.Text;
            bool H1Bool = H1.Checked;
            if (H1Bool)
                value = H1.Text;

            bool H2Bool = H2.Checked;
            if (H2Bool)
                value = H2.Text;

            bool H3Bool = H3.Checked;
            if (H3Bool)
                value = H3.Text;

            bool H4Bool = H4.Checked;
            if (H4Bool)
                value = H4.Text;
            bool I1Bool = I1.Checked;
            if (I1Bool)
                value = I1.Text;

            bool I2Bool = I2.Checked;
            if (I2Bool)
                value = I2.Text;

            bool I3Bool = I3.Checked;
            if (I3Bool)
                value = I3.Text;

            bool I4Bool = I4.Checked;
            if (I4Bool)
                value = I4.Text;
            bool J1Bool = J1.Checked;
            if (J1Bool)
                value = J1.Text;

            bool J2Bool = J2.Checked;
            if (J2Bool)
                value = J2.Text;

            bool J3Bool = J3.Checked;
            if (J3Bool)
                value = J3.Text;

            bool J4Bool = J4.Checked;
            if (J4Bool)
                value = J4.Text;

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Purdue_Airlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("sp_insert2", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email_Address", textBox9.Text);
            cmd.Parameters.Add("@Seat_Number", value);
          

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string zipCodePattern = @"^\d{2}\s?\d{3}$";
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$";

            bool isZipValid = Regex.IsMatch(textBox7.Text, zipCodePattern);
            bool isPhoneValid = Regex.IsMatch(textBox8.Text, phonePattern);
            
            
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your first name.");
                return;
            }

            if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your last name.");
                return;
            }

            if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your full address.");
                return;
            }

            if (textBox5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your full address.");
                return;
            }

            if (textBox6.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your full address.");
                return;
            }

            

            if (!isZipValid)
            {
                    MessageBox.Show("Please enter a valid zip code");
                    return;
            }
            

            

            if (!isPhoneValid)
            {
                    MessageBox.Show("Please enter a valid phone number");
                    return;
            }


            

            if (textBox9.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your email address.");
                
               
                return;
            }

            ValidateEmail();

            if (comboBox1.SelectedIndex == 0)
            {
                Flight1();
            }
            else
            {
                Flight2();
            }

            
            


            







           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label16.Text = "1";
                comboBox2.SelectedIndex = 1;
                A1.ForeColor = Color.Green;
                A2.ForeColor = Color.Green;
                A3.ForeColor = Color.Green;
                A4.ForeColor = Color.Green;
                B1.ForeColor = Color.Green;
                B2.ForeColor = Color.Green;
                B3.ForeColor = Color.Green;
                B4.ForeColor = Color.Green;
                C1.ForeColor = Color.Green;
                C2.ForeColor = Color.Green;
                C3.ForeColor = Color.Green;
                C4.ForeColor = Color.Green;
                D1.ForeColor = Color.Green;
                D2.ForeColor = Color.Green;
                D3.ForeColor = Color.Green;
                D4.ForeColor = Color.Green;
                E1.ForeColor = Color.Green;
                E2.ForeColor = Color.Green;
                E3.ForeColor = Color.Green;
                E4.ForeColor = Color.Green;
                F1.ForeColor = Color.Green;
                F2.ForeColor = Color.Green;
                F3.ForeColor = Color.Green;
                F4.ForeColor = Color.Green;
                G1.ForeColor = Color.Green;
                G2.ForeColor = Color.Green;
                G3.ForeColor = Color.Green;
                G4.ForeColor = Color.Green;
                H1.ForeColor = Color.Green;
                H2.ForeColor = Color.Green;
                H3.ForeColor = Color.Green;
                H4.ForeColor = Color.Green;
                I1.ForeColor = Color.Green;
                I2.ForeColor = Color.Green;
                I3.ForeColor = Color.Green;
                I4.ForeColor = Color.Green;
                J1.ForeColor = Color.Green;
                J2.ForeColor = Color.Green;
                J3.ForeColor = Color.Green;
                J4.ForeColor = Color.Green;

                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Purdue_Airlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Seat_Number;

                string query = @"SELECT Seat_Number From Passenger_List_Flight1;";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Seat_Number = dr.GetString(0);
                        string a1 = "A1";
                        string a2 = "A2";
                        string a3 = "A3";
                        string a4 = "A4";
                        string b1 = "B1";
                        string b2 = "B2";
                        string b3 = "B3";
                        string b4 = "B4";
                        string c1 = "C1";
                        string c2 = "C2";
                        string c3 = "C3";
                        string c4 = "C4";
                        string d1 = "D1";
                        string d2 = "D2";
                        string d3 = "D3";
                        string d4 = "D4";
                        string e1 = "E1";
                        string e2 = "E2";
                        string e3 = "E3";
                        string e4 = "E4";
                        string f1 = "F1";
                        string f2 = "F2";
                        string f3 = "F3";
                        string f4 = "F4";
                        string g1 = "G1";
                        string g2 = "G2";
                        string g3 = "G3";
                        string g4 = "G4";
                        string h1 = "H1";
                        string h2 = "H2";
                        string h3 = "H3";
                        string h4 = "H4";
                        string i1 = "I1";
                        string i2 = "I2";
                        string i3 = "I3";
                        string i4 = "I4";
                        string j1 = "J1";
                        string j2 = "J2";
                        string j3 = "J3";
                        string j4 = "J4";

                        if (Seat_Number.Contains(a1))
                        {
                            A1.ForeColor = Color.Red;
                            A1.AutoCheck = false;


                        }


                        if (Seat_Number.Contains(a2))
                        {
                            A2.ForeColor = Color.Red;
                            A2.AutoCheck = false;

                        }

                        if (Seat_Number.Contains(a3))
                        {
                            A3.ForeColor = Color.Red;
                            A3.AutoCheck = false;

                        }

                        if (Seat_Number.Contains(a4))
                        {
                            A4.ForeColor = Color.Red;
                            A4.AutoCheck = false;

                        }

                        if (Seat_Number.Contains(b1))
                        {
                            B1.ForeColor = Color.Red;
                            B1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(b2))
                        {
                            B2.ForeColor = Color.Red;
                            B2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(b3))
                        {
                            B3.ForeColor = Color.Red;
                            B3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(b4))
                        {
                            B4.ForeColor = Color.Red;
                            B4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(c1))
                        {
                            C1.ForeColor = Color.Red;
                            C1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(c2))
                        {
                            C2.ForeColor = Color.Red;
                            C2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(c3))
                        {
                            C3.ForeColor = Color.Red;
                            C3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(c4))
                        {
                            C4.ForeColor = Color.Red;
                            C4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(d1))
                        {
                            D1.ForeColor = Color.Red;
                            D1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(d2))
                        {
                            D2.ForeColor = Color.Red;
                            D2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(d3))
                        {
                            D3.ForeColor = Color.Red;
                            D3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(d4))
                        {
                            D4.ForeColor = Color.Red;
                            D4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(e1))
                        {
                            E1.ForeColor = Color.Red;
                            E1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(e2))
                        {
                            E2.ForeColor = Color.Red;
                            E2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(e3))
                        {
                            E3.ForeColor = Color.Red;
                            E3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(e4))
                        {
                            E4.ForeColor = Color.Red;
                            E4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(f1))
                        {
                            F1.ForeColor = Color.Red;
                            F1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(f2))
                        {
                            F2.ForeColor = Color.Red;
                            F2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(f3))
                        {
                            F3.ForeColor = Color.Red;
                            F3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(f4))
                        {
                            F4.ForeColor = Color.Red;
                            F4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(g1))
                        {
                            G1.ForeColor = Color.Red;
                            G1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(g2))
                        {
                            G2.ForeColor = Color.Red;
                            G2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(g3))
                        {
                            G3.ForeColor = Color.Red;
                            G3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(g4))
                        {
                            G4.ForeColor = Color.Red;
                            G4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(h1))
                        {
                            H1.ForeColor = Color.Red;
                            H1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(h2))
                        {
                            H2.ForeColor = Color.Red;
                            H2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(h3))
                        {
                            H3.ForeColor = Color.Red;
                            H3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(h4))
                        {
                            H4.ForeColor = Color.Red;
                            H4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(i1))
                        {
                            I1.ForeColor = Color.Red;
                            I1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(i2))
                        {
                            I2.ForeColor = Color.Red;
                            I2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(i3))
                        {
                            I3.ForeColor = Color.Red;
                            I3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(i4))
                        {
                            I4.ForeColor = Color.Red;
                            I4.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(j1))
                        {
                            J1.ForeColor = Color.Red;
                            J1.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(j2))
                        {
                            J2.ForeColor = Color.Red;
                            J2.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(j3))
                        {
                            J3.ForeColor = Color.Red;
                            J3.AutoCheck = false;
                        }

                        if (Seat_Number.Contains(j4))
                        {
                            J4.ForeColor = Color.Red;
                            J4.AutoCheck = false;
                        }




                    }
                }

                con.Close();
            }


            else
            {
                label16.Text = "2";
                comboBox2.SelectedIndex = 0;
                A1.ForeColor = Color.Green;
                A2.ForeColor = Color.Green;
                A3.ForeColor = Color.Green;
                A4.ForeColor = Color.Green;
                B1.ForeColor = Color.Green;
                B2.ForeColor = Color.Green;
                B3.ForeColor = Color.Green;
                B4.ForeColor = Color.Green;
                C1.ForeColor = Color.Green;
                C2.ForeColor = Color.Green;
                C3.ForeColor = Color.Green;
                C4.ForeColor = Color.Green;
                D1.ForeColor = Color.Green;
                D2.ForeColor = Color.Green;
                D3.ForeColor = Color.Green;
                D4.ForeColor = Color.Green;
                E1.ForeColor = Color.Green;
                E2.ForeColor = Color.Green;
                E3.ForeColor = Color.Green;
                E4.ForeColor = Color.Green;
                F1.ForeColor = Color.Green;
                F2.ForeColor = Color.Green;
                F3.ForeColor = Color.Green;
                F4.ForeColor = Color.Green;
                G1.ForeColor = Color.Green;
                G2.ForeColor = Color.Green;
                G3.ForeColor = Color.Green;
                G4.ForeColor = Color.Green;
                H1.ForeColor = Color.Green;
                H2.ForeColor = Color.Green;
                H3.ForeColor = Color.Green;
                H4.ForeColor = Color.Green;
                I1.ForeColor = Color.Green;
                I2.ForeColor = Color.Green;
                I3.ForeColor = Color.Green;
                I4.ForeColor = Color.Green;
                J1.ForeColor = Color.Green;
                J2.ForeColor = Color.Green;
                J3.ForeColor = Color.Green;
                J4.ForeColor = Color.Green;



                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Purdue_Airlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Seat_Number;

                string query = @"SELECT Seat_Number From Passenger_List_Flight2;";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Seat_Number = dr.GetString(0);
                        string a1 = "A1";
                        string a2 = "A2";
                        string a3 = "A3";
                        string a4 = "A4";
                        string b1 = "B1";
                        string b2 = "B2";
                        string b3 = "B3";
                        string b4 = "B4";
                        string c1 = "C1";
                        string c2 = "C2";
                        string c3 = "C3";
                        string c4 = "C4";
                        string d1 = "D1";
                        string d2 = "D2";
                        string d3 = "D3";
                        string d4 = "D4";
                        string e1 = "E1";
                        string e2 = "E2";
                        string e3 = "E3";
                        string e4 = "E4";
                        string f1 = "F1";
                        string f2 = "F2";
                        string f3 = "F3";
                        string f4 = "F4";
                        string g1 = "G1";
                        string g2 = "G2";
                        string g3 = "G3";
                        string g4 = "G4";
                        string h1 = "H1";
                        string h2 = "H2";
                        string h3 = "H3";
                        string h4 = "H4";
                        string i1 = "I1";
                        string i2 = "I2";
                        string i3 = "I3";
                        string i4 = "I4";
                        string j1 = "J1";
                        string j2 = "J2";
                        string j3 = "J3";
                        string j4 = "J4";

                        if (Seat_Number.Contains(a1))
                        {
                            A1.ForeColor = Color.Red;
                            A1.AutoCheck = false;
                            
                            
                        }
                      

                        if (Seat_Number.Contains(a2))
                        {
                            A2.ForeColor = Color.Red;
                            A2.AutoCheck = false;
                            
                        }
                        
                        if (Seat_Number.Contains(a3))
                        {
                            A3.ForeColor = Color.Red;
                            A3.AutoCheck = false;
                            
                        }
                        
                        if (Seat_Number.Contains(a4))
                        {
                            A4.ForeColor = Color.Red;
                            A4.AutoCheck = false;
                            
                        }
                       
                        if (Seat_Number.Contains(b1))
                        {
                            B1.ForeColor = Color.Red;
                            B1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(b2))
                        {
                            B2.ForeColor = Color.Red;
                            B2.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(b3))
                        {
                            B3.ForeColor = Color.Red;
                            B3.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(b4))
                        {
                            B4.ForeColor = Color.Red;
                            B4.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(c1))
                        {
                            C1.ForeColor = Color.Red;
                            C1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(c2))
                        {
                            C2.ForeColor = Color.Red;
                            C2.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(c3))
                        {
                            C3.ForeColor = Color.Red;
                            C3.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(c4))
                        {
                            C4.ForeColor = Color.Red;
                            C4.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(d1))
                        {
                            D1.ForeColor = Color.Red;
                            D1.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(d2))
                        {
                            D2.ForeColor = Color.Red;
                            D2.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(d3))
                        {
                            D3.ForeColor = Color.Red;
                            D3.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(d4))
                        {
                            D4.ForeColor = Color.Red;
                            D4.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(e1))
                        {
                            E1.ForeColor = Color.Red;
                            E1.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(e2))
                        {
                            E2.ForeColor = Color.Red;
                            E2.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(e3))
                        {
                            E3.ForeColor = Color.Red;
                            E3.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(e4))
                        {
                            E4.ForeColor = Color.Red;
                            E4.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(f1))
                        {
                            F1.ForeColor = Color.Red;
                            F1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(f2))
                        {
                            F2.ForeColor = Color.Red;
                            F2.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(f3))
                        {
                            F3.ForeColor = Color.Red;
                            F3.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(f4))
                        {
                            F4.ForeColor = Color.Red;
                            F4.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(g1))
                        {
                            G1.ForeColor = Color.Red;
                            G1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(g2))
                        {
                            G2.ForeColor = Color.Red;
                            G2.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(g3))
                        {
                            G3.ForeColor = Color.Red;
                            G3.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(g4))
                        {
                            G4.ForeColor = Color.Red;
                            G4.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(h1))
                        {
                            H1.ForeColor = Color.Red;
                            H1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(h2))
                        {
                            H2.ForeColor = Color.Red;
                            H2.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(h3))
                        {
                            H3.ForeColor = Color.Red;
                            H3.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(h4))
                        {
                            H4.ForeColor = Color.Red;
                            H4.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(i1))
                        {
                            I1.ForeColor = Color.Red;
                            I1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(i2))
                        {
                            I2.ForeColor = Color.Red;
                            I2.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(i3))
                        {
                            I3.ForeColor = Color.Red;
                            I3.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(i4))
                        {
                            I4.ForeColor = Color.Red;
                            I4.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(j1))
                        {
                            J1.ForeColor = Color.Red;
                            J1.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(j2))
                        {
                            J2.ForeColor = Color.Red;
                            J2.AutoCheck = false;
                        }
                       
                        if (Seat_Number.Contains(j3))
                        {
                            J3.ForeColor = Color.Red;
                            J3.AutoCheck = false;
                        }
                        
                        if (Seat_Number.Contains(j4))
                        {
                            J4.ForeColor = Color.Red;
                            J4.AutoCheck = false;
                        }
                       




                    }
                }

                con.Close();
            }

            

        }


    }
}
