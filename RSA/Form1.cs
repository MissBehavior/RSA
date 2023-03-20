using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RSA
{
    public partial class Form1 : Form
    {
        int eChosenNum = 5; //exponent e for Eucledean algorythm GCD
        public Form1()
        {
            InitializeComponent();
            txtE.Text = eChosenNum.ToString();
        }


        

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
           
            
            if (txtP.Text != "" & txtQ.Text != "")
            {
                txtP.BackColor = Color.White;
                txtQ.BackColor = Color.White;
                int p = Int16.Parse(txtP.Text);
                int q = Int16.Parse(txtQ.Text);
                //STEP 1: Find n value:
                int n = p * q;
                txtN.Text = n.ToString();
                //STEP 2: Find Φ[n] value:
                int phi = (p - 1) * (q - 1);
                txtPhi.Text = phi.ToString();
                //STEP 3: Euclidean algorithm (GCD):
                /*a) When do we know we have found the GCD?
                 * When R = 0 (Where R is the remainder)
                 * b) Find a VB expression for the remainder where J and I are the numbers J > I.
                 * Then R = J - INT(J/I)*I
                 * c) If R = 0 then what variable does GCD equal?
                 * GCD = I
                 * d) What happens if we do not obtain R = 0 upon our first division?
                 * Then for second time: I becomes J => J = I
                 *                       R becomes I => I = R
                 * and we test R = J - INT(J/I)*I for R = 0
                 *** J is the upper number of division and I is the lower. I/J or M/N
                 *If the GCD = 1, the numbers are said to be relatively prime. 
                 * */
                int gcd = findGCD(phi, eChosenNum);
                txtGCD.Text = gcd.ToString();
                if (gcd != 1)
                {
                    MessageBox.Show("Greatest common divisor GCD is not equal to 1. Please check entered information.");
                    txtGCD.BackColor = Color.Red;
                }
                //STEP 4: Public Key = (n, e) - show in text boxes:
                txtPublicKeyN.Text = n.ToString();
                txtPublicKeyE.Text = eChosenNum.ToString();
                //STEP 5: Extended Euclidean algorytm:
                /*In this formula set a to e, b to phi=(p-1)(q-1) and gcd(a, b) to 1 
                 * (because e and φ(pq) are required to be coprime in the RSA algorithm) 
                 * and solve for x which gives you your d. 
                 */
                int d = Math.Abs(ExtendedEuclideanAlgorithm(eChosenNum, phi)); //finding d - private key
                txtExtendedgcdD.Text = d.ToString();
                //STEP 6: Encrypt the plain text x:
                string plainText = txtPlainText.Text;
                string encryptedtxt = encryptedText(plainText, eChosenNum, n);
                txtEncrypted.Text = encryptedtxt;
            } else
            {
                MessageBox.Show("Error! Please enter p and q values (prime numbers).");
                txtP.BackColor = Color.Red;
                txtQ.BackColor = Color.Red;
            }

        }

        //Euclidean algorythm:
        public static int findGCD(int m, int n) //m is upper number n is lower. For example, 12/4 m=12, 4=n
        {
            int temp;
            int r;
            if (m < n) //if upper number of division is lower than the lower one, they get swapped
            {
                temp = m; //temp is needed to temprorarly save number somewhere so it doesn't get delted
                m = n;
                n = temp;
            }

            while (true)
            {
                r = m % n;
                if (r == 0) //if remainder is = 0 break
                    break;
                m = n; //if we didn't get 0 remainder then we switch numbers
                n = r;
            }
            return n;
        }


        private static int ExtendedEuclideanAlgorithm(int a, int b)
        {
            int s = 0, t = 1, r = b, old_s = 1, old_t = 0, old_r = a;
            while (r != 0)
            {
                int quotient = old_r / r;

                int tmp = old_r;
                old_r = r;
                r = tmp - quotient * r;

                tmp = old_s;
                old_s = s;
                s = tmp - quotient * s;

                tmp = old_t;
                old_t = t;
                t = tmp - quotient * t;
            }

            return old_s;
        }



        // encryption
        static String encryptedText(String str, int e, int n)
        {
            String encryptedtxt = "";

            for (int i = 0; i < str.Length; i++)
            {
                //ASCII range
                //int x = (str[i] ^ e) % n;
                double x = (Math.Pow(str[i], e)) % n;

                encryptedtxt += (char)(x);
            }
            return encryptedtxt;
        }

    }
}
