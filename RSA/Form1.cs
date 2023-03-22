﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


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
                //ASCII range (full)
                ulong x = (ulong)((Math.Pow(str[i], e)) % n); //power: str[i] ^ e

                encryptedtxt += (char)(x);
            }
            return encryptedtxt;
        }



        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = txtEncrypted.Text;
            int dDecryption = Int16.Parse(txtDdecryption.Text);
            int nDecryption = Int16.Parse(txtNdecryption.Text);
            //STEP 1: Find p and q values.
            /*First, we need to find p and q values to canculate φ. For that we use mathematical algorythm - 
             * Sieve of Eratosthenes - an ancient algorithm for finding all prime numbers up to any given limit.
             * Using that algorythm we find prime pair.
            */
            int pDecryption = findPrimePair(nDecryption).i;
            int qDecryption = findPrimePair(nDecryption).x;
            txtFindP.Text = pDecryption.ToString();
            txtFindQ.Text = qDecryption.ToString();
            //STEP 2: Find Phi:
            int phiDecrypt = (pDecryption - 1) * (qDecryption - 1);
            txtPhiDecryption.Text = phiDecrypt.ToString();
            //STEP 3: Decrypt:
            string decryptedtxt = decryptedText(encryptedText, dDecryption, nDecryption);
            txtDecrypted.Text = decryptedtxt;


        }



        static void SieveOfEratosthenes(int a, bool[] isPrime)
        {
            // Initialize all entries of bool
            // array as true. A value in
            // isPrime[i] will finally be false
            // if i is Not a prime, else true
            // bool isPrime[n+1];
            isPrime[0] = isPrime[1] = false;
            for (int i = 2; i <= a; i++)
                isPrime[i] = true;

            for (int p = 2; p * p <= a; p++)
            {
                // If isPrime[p] is not changed,
                // then it is a prime
                if (isPrime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * 2; i <= a; i += p)
                        isPrime[i] = false;
                }
            }
        }

        // Function to print a prime
        // pair with given product
        static (int x, int i) findPrimePair(int a)
        {
            int flag = 0;

            // Generating primes using Sieve
            bool[] isPrime = new bool[a + 1];
            SieveOfEratosthenes(a, isPrime);

            // Traversing all numbers to
            // find first pair
            for (int i = 2; i < a; i++)
            {
                int x = a / i;
                
                if (isPrime[i] && isPrime[x] &&
                        x != i && x * i == a)
                {
                    //Console.Write(i + " " + x);
                    flag = 1;
                    return (x, i);
                }
            }

            if (flag == 0)
            {
                MessageBox.Show("Error! No p and q values found.");
                throw new Exception("No P and Q found");
            }
            else
            {
                throw new Exception("Error in code");
            }
            

        }

        // decryption
        static String decryptedText(String str, int d, int n)
        {
            String decryptedtxt = "";
            BigInteger nBig = new BigInteger(n);
            for (int i = 0; i < str.Length; i++)
            {
                //ASCII range (full)
                BigInteger iBig = new BigInteger(str[i]);
                BigInteger x  = ((BigInteger.Pow(iBig, d)) % nBig);
                int decryptedX = (int)x;
                decryptedtxt += (char)(decryptedX);
            }
            return decryptedtxt;
        }



    }

}

