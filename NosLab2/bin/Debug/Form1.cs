using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;


namespace NosLab2
{
    public partial class Form1 : Form
    {
        // DEFAULT VALUES
        int symetricKeySize = 192;
        int asymetricKeySize = 2048;
        string symmetricAlg = "AES";
        string asymmetricAlg = "RSA";
        CipherMode mode = CipherMode.ECB;
        string hashMode = "SHA1";

        string symmetricKey = "";
        string encryptedSymmetricKey = "";
        string decryptedSymmetricKey = "";
        string privateKey = "";
        string publicKey = "";

        RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitRadios();
            InitLabels();

            rsa = new RSACryptoServiceProvider(asymetricKeySize);
            privateKey = rsa.ToXmlString(true);
            publicKey = rsa.ToXmlString(false);
        }
        private void InitLabels()
        {
            LabelSymAlgToUseValue.Text = symmetricAlg + symetricKeySize.ToString();
            LabelAsymAlgToUseValue.Text = asymmetricAlg + asymetricKeySize.ToString();
            LabelModeValue.Text = mode.ToString();
        }
        private void InitRadios()
        {
            // MODE
            RadioModeECB.Checked = true;
            // DEFAULTS
            RadioAesKey192.Checked = true;
            RadioDesKey192.Checked = true;
            RadioRsaKey2048.Checked = true;
            //RadioElGamalKey2048.Checked = true;
            RadioHashSHA1.Checked = true;
            
            // DISABLED 
            RadioDesKey128.Enabled = false;
            RadioDesKey192.Enabled = false;
            //RadioElGamalKey1024.Enabled = false;
            //RadioElGamalKey2048.Enabled = false;
            //RadioElGamalKey3072.Enabled = false;
        }

        private string RandomNumber(int length)
        {
            //length++;
            string strChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] VcArray = strChar.Split(',');
            string VNum = "";
            int temp = -1;
            Random random = new Random();
            for (int i = 1; i < length + 1; i++)
            {
                int t = random.Next(62);
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;
        }
        private void GetSymKeySizeFromRadio(RadioButton radioButton)
        {
            if (radioButton.Checked && radioButton.Enabled)
            {
                symetricKeySize = Convert.ToInt32(radioButton.Text); ;
            }
        }
        private void GetAsymKeySizeFromRadio(RadioButton radioButton)
        {
            if (radioButton.Checked && radioButton.Enabled)
            {
                asymetricKeySize = Convert.ToInt32(radioButton.Text); ;
            }
        }
        private void GetModeFromRadio(RadioButton radioButton)
        {
            if (radioButton.Checked && radioButton.Enabled)
            {
                if (radioButton.Text == "CBC")
                {
                    mode = CipherMode.CBC;
                }else if(radioButton.Text == "ECB")
                {
                    mode = CipherMode.ECB;
                }else if(radioButton.Text == "CFB")
                {
                    mode = CipherMode.CFB;
                }
            }
        }
        private void GetHashTypeFromRadio(RadioButton radioButton)
        {
            if (radioButton.Checked && radioButton.Enabled)
            {
                if (radioButton.Text == "SHA1")
                {
                    hashMode = "SHA1";
                }
                else if (radioButton.Text == "SHA256")
                {
                    hashMode = "SHA256";
                }
                else if (radioButton.Text == "SHA384")
                {
                    hashMode = "SHA384";
                }else if (radioButton.Text == "SHA512")
                {
                    hashMode = "SHA512";
                }
            }
        }
        static string Hash(string input, string mode)
        {
            HashAlgorithm sha = HashAlgorithm.Create(mode);
                
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
        }

        private void ButtonAES_Click(object sender, EventArgs e)
        {
            symmetricAlg = "AES";

            RadioAesKey128.Enabled = true;
            RadioAesKey192.Enabled = true;
            RadioAesKey256.Enabled = true;
            RadioDesKey128.Enabled = false;
            RadioDesKey192.Enabled = false;

            GetSymKeySizeFromRadio(RadioAesKey128);
            GetSymKeySizeFromRadio(RadioAesKey192);
            GetSymKeySizeFromRadio(RadioAesKey256);

            LabelSymAlgToUseValue.Text = symmetricAlg + symetricKeySize.ToString();


        }
        private void Button3DES_Click(object sender, EventArgs e)
        {
            symmetricAlg = "3DES";

            RadioDesKey128.Enabled = true;
            RadioDesKey192.Enabled = true;
            RadioAesKey128.Enabled = false;
            RadioAesKey192.Enabled = false;
            RadioAesKey256.Enabled = false;

            GetSymKeySizeFromRadio(RadioDesKey128);
            GetSymKeySizeFromRadio(RadioDesKey192);

            LabelSymAlgToUseValue.Text = symmetricAlg + symetricKeySize.ToString();



        }
        private void ButtonRSA_Click(object sender, EventArgs e)
        {
            asymmetricAlg = "RSA";
            RadioRsaKey1024.Enabled = true;
            RadioRsaKey2048.Enabled = true;
            RadioRsaKey3072.Enabled = true;

            //RadioElGamalKey1024.Enabled = false;
            //RadioElGamalKey2048.Enabled = false;
            //RadioElGamalKey3072.Enabled = false;

            GetAsymKeySizeFromRadio(RadioRsaKey1024);
            GetAsymKeySizeFromRadio(RadioRsaKey2048);
            GetAsymKeySizeFromRadio(RadioRsaKey3072);

            LabelAsymAlgToUseValue.Text = asymmetricAlg + asymetricKeySize.ToString();

        }
        private void ButtonElGamal_Click(object sender, EventArgs e)
        {
            asymmetricAlg = "ElGamal";
            //RadioElGamalKey1024.Enabled = true;
            //RadioElGamalKey2048.Enabled = true;
            //RadioElGamalKey3072.Enabled = true;

            RadioRsaKey1024.Enabled = false;
            RadioRsaKey2048.Enabled = false;
            RadioRsaKey3072.Enabled = false;

            //GetAsymKeySizeFromRadio(RadioElGamalKey1024);
            //GetAsymKeySizeFromRadio(RadioElGamalKey2048);
            //GetAsymKeySizeFromRadio(RadioElGamalKey3072);

            LabelAsymAlgToUseValue.Text = asymmetricAlg + asymetricKeySize.ToString();


        }
        private void ButtonHash_Click(object sender, EventArgs e)
        {
            GetHashTypeFromRadio(RadioHashSHA1);
            GetHashTypeFromRadio(RadioHashSHA256);
            GetHashTypeFromRadio(RadioHashSHA384);
            GetHashTypeFromRadio(RadioHashSHA512);
            string heš = Hash("NEGRO", hashMode);
            TextBoxHash.Text = heš;
        }
        private void ButtonGenSymKey_Click(object sender, EventArgs e)
        {

            if (TextBoxMsgToEncrypt.Text == "")
            {
                MessageBox.Show("Please enter a message!");
            }
            else
            {
                // SYMMETRIC KEY SIZE
                GetSymKeySizeFromRadio(RadioAesKey128);
                GetSymKeySizeFromRadio(RadioAesKey192);
                GetSymKeySizeFromRadio(RadioAesKey256);
                GetSymKeySizeFromRadio(RadioDesKey128);
                GetSymKeySizeFromRadio(RadioDesKey192);
                // MODE
                GetModeFromRadio(RadioModeCBC);
                GetModeFromRadio(RadioModeECB);
                GetModeFromRadio(RadioModeCFB);
                // ASYMMETRIC KEY SIZE
                GetAsymKeySizeFromRadio(RadioRsaKey1024);
                GetAsymKeySizeFromRadio(RadioRsaKey2048);
                GetAsymKeySizeFromRadio(RadioRsaKey3072);

                LabelSymAlgToUseValue.Text = symmetricAlg + symetricKeySize.ToString();
                LabelModeValue.Text = mode.ToString();

                symmetricKey = RandomNumber(symetricKeySize / 8);
                SymKeyValue.Text = symmetricKey;

                encryptedSymmetricKey = EncryptRSA(symmetricKey, publicKey);
                TextBoxEncryptedKey.Text = encryptedSymmetricKey;

                // debug
                decryptedSymmetricKey = DecryptRSA(encryptedSymmetricKey, privateKey);
                TextBoxDecryptedKey.Text = decryptedSymmetricKey;

                //rsa = new RSACryptoServiceProvider(asymetricKeySize);
                //privateKey = rsa.ToXmlString(true);
                // publicKey = rsa.ToXmlString(false);

            }


        }
        private void ButtonGenerateEnvelope_Click(object sender, EventArgs e)
        {
            if (SymKeyValue.Text == "" || TextBoxEncryptedMsg.Text == "")
            {
                MessageBox.Show("Encrypt your message with generated key before generating envelope");
            }
            else
            {
                WriteEnvelopeToFile();
                TextBoxEnvelope.Text = TextBoxEncryptedMsg.Text + encryptedSymmetricKey;
            }
        }
        private void ButtonDecryptEnvelope_Click(object sender, EventArgs e)
        {
            if (TextBoxEnvelope.Text == "")
            {
                MessageBox.Show("Generate an envelope before checking it!");
            }
            else
            {
                StreamReader sr = new StreamReader("data.txt");
                string data = sr.ReadLine();// data 
                string key = sr.ReadLine(); // encrypted symmetric key
                sr.Close();

                if (symmetricAlg == "AES")
                {
                    //string decryptedMsg = DecryptAES(TextBoxEncryptedMsg.Text, symmetricKey, "WinNie31WinNie31", mode);
                    string decryptedKey = DecryptRSA(key, privateKey);
                    string decryptedMsg = DecryptAES(data, decryptedKey, "WinNie31WinNie31", mode);
                    TextBoxDecryptedEnvelope.Text = decryptedMsg;
                }
                else if (symmetricAlg == "3DES")
                {
                    //string decryptedMsg = Decrypt3DES(TextBoxEncryptedMsg.Text, symmetricKey, "WinNie31", mode);
                    string decryptedKey = DecryptRSA(key, privateKey);
                    string decryptedMsg = Decrypt3DES(data, decryptedKey, "WinNie31", mode);
                    TextBoxDecryptedEnvelope.Text = decryptedMsg;
                }
            }
        }
        private void ButtonGenerateSignature_Click(object sender, EventArgs e)
        {
            if (TextBoxMsgToEncrypt.Text == "")
            {
                MessageBox.Show("Please enter your message!");
            }
            else
            {
                WriteSignatureToFile();
                string hashedMsg = Hash(TextBoxMsgToEncrypt.Text, hashMode);
                string encryptedHashedMsg = EncryptRSA(hashedMsg, privateKey);
                TextBoxSignature.Text = TextBoxMsgToEncrypt.Text + encryptedHashedMsg;
            }

        }
        private void ButtonGenerateSeal_Click(object sender, EventArgs e)
        {
            if (TextBoxMsgToEncrypt.Text == "" || TextBoxEncryptedMsg.Text == "")
            {
                MessageBox.Show("Please enter your message and encrypt it!");
            }
            else
            {
                // 1. Generate envelope -> take previously generated one
                // ENVELOPE // 
                // Encrypted Message
                // Encrypted Symmetric Key
                string envelope = TextBoxEnvelope.Text;
                // 2. Hash envelope 
                string hashedEnvelope = Hash(envelope, hashMode);
                // 3. Encrypt hashedEnvelope with private key
                string encryptedHashedEnvelope = EncryptRSA(hashedEnvelope, privateKey);
                // SEAL 
                // Message (zapravo Envelope)  || Envelope
                // Encrypted + Hashed Message  || Encrypted & Hashed Envelope
                TextBoxSeal.Text = envelope + encryptedHashedEnvelope;
                WriteSealToFile();
            }


        }
        private void ButtonCheckSignature_Click(object sender, EventArgs e)
        {
            if (TextBoxSignature.Text == "")
            {
                MessageBox.Show("Generate a signature before checking it!");
            }
            else
            {
                StreamReader sr = new StreamReader("signature.txt");
                string message = sr.ReadLine();// clear message 
                string hashedEncryptedMsg = sr.ReadLine(); // hashed encrypted message 
                sr.Close();
                string hashedMessage = Hash(message, hashMode);
                // SHOULD BE PUBLIC KEY BUT ERRORS :/
                string decryptedHashedMsg = DecryptRSA(hashedEncryptedMsg, rsa.ToXmlString(true));

                if (hashedMessage == decryptedHashedMsg)
                {
                    LabelSignatureCheck.Text = "Signature is valid!";
                }
                else
                {
                    LabelSignatureCheck.Text = "Signature is in1valid!";
                }
            }


        }
        private void ButtonCheckSeal_Click(object sender, EventArgs e)
        {
            if (TextBoxSeal.Text == "")
            {
                MessageBox.Show("Generate a seal before checking it!");
            }
            else
            {

                StreamReader sr = new StreamReader("seal.txt");
                string encryptedMessage = sr.ReadLine();
                string encryptedKey = sr.ReadLine();
                string encryptedHashedEnvelope = sr.ReadLine();
                sr.Close();

                string decryptedMessage = "";
                string decryptedKey = DecryptRSA(encryptedKey, privateKey);
                //MessageBox.Show(decryptedKey);
                if (symmetricAlg == "AES")
                {
                    decryptedMessage = DecryptAES(encryptedMessage, decryptedKey, "WinNie31WinNie31", mode);
                }
                else if (symmetricAlg == "3DES")
                {
                    decryptedMessage = Decrypt3DES(encryptedMessage, decryptedKey, "WinNie31", mode);
                }
                string decryptedHashedEnvelope = DecryptRSA(encryptedHashedEnvelope, privateKey);
                string hashedMessage = Hash(encryptedMessage + encryptedKey, hashMode);

                if (decryptedHashedEnvelope == hashedMessage)
                {
                    LabelSealCheck.Text = "Seal is valid!";
                    LabelSealCheckMsg.Text = "Message: " + decryptedMessage;
                    LabelSealCheckKey.Text = "Key: " + decryptedKey;
                }
                else
                {
                    LabelSealCheck.Text = "Seal is NOT valid!";
                }
            }


        }

        // TEMP
        private void ButtonEncryptMsg_Click(object sender, EventArgs e)
        {
            if (TextBoxMsgToEncrypt.Text == "")
            {
                MessageBox.Show("Please enter a message and generate a key!");
            }
            else
            {
                if (symmetricAlg == "AES")
                {
                    string encryptedMsg = EncryptAES(TextBoxMsgToEncrypt.Text, symmetricKey, "WinNie31WinNie31", mode);
                    TextBoxEncryptedMsg.Text = encryptedMsg;
                }
                else if (symmetricAlg == "3DES")
                {
                    string encryptedMsg = Encrypt3DES(TextBoxMsgToEncrypt.Text, symmetricKey, "WinNie31", mode);
                    TextBoxEncryptedMsg.Text = encryptedMsg;
                }
            }

        }
        private void ButtonDecryptMsg_Click(object sender, EventArgs e)
        {
            if (TextBoxEncryptedMsg.Text == "")
            {
                MessageBox.Show("Please encrypt your message!");
            }
            else
            {
                if (symmetricAlg == "AES")
                {
                    //string decryptedMsg = DecryptAES(TextBoxEncryptedMsg.Text, symmetricKey, "WinNie31WinNie31", mode);
                    string decryptedMsg = DecryptAES(TextBoxEncryptedMsg.Text, decryptedSymmetricKey, "WinNie31WinNie31", mode);
                    TextBoxDecryptedMsg.Text = decryptedMsg;
                }
                else if (symmetricAlg == "3DES")
                {
                    //string decryptedMsg = Decrypt3DES(TextBoxEncryptedMsg.Text, symmetricKey, "WinNie31", mode);
                    string decryptedMsg = Decrypt3DES(TextBoxEncryptedMsg.Text, decryptedSymmetricKey, "WinNie31", mode);
                    TextBoxDecryptedMsg.Text = decryptedMsg;
                }
            }


        }
        // TEMP 
        private void TextBoxMsgToEncrypt_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxEncryptedMsg_TextChanged(object sender, EventArgs e)
        {

        }

        public string Encrypt3DES(string original, string key, string iv, CipherMode mode)
        {
            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider();
            tripleDes.Key = Encoding.UTF8.GetBytes(key);
            tripleDes.IV = Encoding.UTF8.GetBytes(iv);
            tripleDes.Mode = mode;
            byte[] s = Encoding.UTF8.GetBytes(original);
            ICryptoTransform desencrypt = tripleDes.CreateEncryptor();
            return BitConverter.ToString(desencrypt.TransformFinalBlock(s, 0, s.Length)).Replace("-", string.Empty);
        }
        public string Decrypt3DES(string hexString, string key, string iv, CipherMode mode)
        {
                TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider();
                tripleDes.Key = Encoding.ASCII.GetBytes(key);
                tripleDes.IV = Encoding.ASCII.GetBytes(iv);
                tripleDes.Mode = mode;
                byte[] s = new byte[hexString.Length / 2];
                int j = 0;
                for (int i = 0; i < hexString.Length / 2; i++)
                {
                    s[i] = Byte.Parse(hexString[j].ToString() + hexString[j + 1].ToString(), System.Globalization.NumberStyles.HexNumber);
                    j += 2;
                }
                ICryptoTransform desencrypt = tripleDes.CreateDecryptor();
                return Encoding.UTF8.GetString(desencrypt.TransformFinalBlock(s, 0, s.Length));
        }
        public string EncryptAES(string original, string key, string iv, CipherMode mode)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);
            aes.Mode = mode;
            byte[] s = Encoding.UTF8.GetBytes(original);
            ICryptoTransform aesencrypt = aes.CreateEncryptor();
            return BitConverter.ToString(aesencrypt.TransformFinalBlock(s, 0, s.Length)).Replace("-", string.Empty);

        }
        public string DecryptAES(string hexString, string key, string iv, CipherMode mode)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = Encoding.ASCII.GetBytes(key);
            aes.IV = Encoding.ASCII.GetBytes(iv);
            aes.Mode = mode;
            byte[] s = new byte[hexString.Length / 2];
            int j = 0;
            for (int i = 0; i < hexString.Length / 2; i++)
            {
                s[i] = Byte.Parse(hexString[j].ToString() + hexString[j + 1].ToString(), System.Globalization.NumberStyles.HexNumber);
                j += 2;
            }
            ICryptoTransform aesDecrypt = aes.CreateDecryptor();
            return Encoding.UTF8.GetString(aesDecrypt.TransformFinalBlock(s, 0, s.Length));
        }
        public string EncryptRSA(string original, string xmlString)
        {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(asymetricKeySize);
                rsa.FromXmlString(xmlString);
                byte[] s = Encoding.UTF8.GetBytes(original);
                return BitConverter.ToString(rsa.Encrypt(s, false)).Replace("-", string.Empty);
        }
        public string DecryptRSA(string hexString, string xmlString)
        {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(asymetricKeySize);
                rsa.FromXmlString(xmlString);
                byte[] s = new byte[hexString.Length / 2];
                int j = 0;
                for (int i = 0; i < hexString.Length / 2; i++)
                {
                    s[i] = Byte.Parse(hexString[j].ToString() + hexString[j + 1].ToString(), System.Globalization.NumberStyles.HexNumber);
                    j += 2;
                }
                return Encoding.UTF8.GetString( rsa.Decrypt(s, false) );
        }
        
        public void WriteEnvelopeToFile()
        {      
            StreamWriter sw = new StreamWriter("data.txt");
            sw.WriteLine(TextBoxEncryptedMsg.Text);//write cyphertext
            sw.WriteLine(encryptedSymmetricKey);//write encrypted key
            sw.Close();

            StreamWriter swp = new StreamWriter("privatekey.txt");
            swp.WriteLine(rsa.ToXmlString(true));
            swp.Close();
        }
        public void WriteSignatureToFile()
        {
            StreamWriter sw = new StreamWriter("signature.txt");
            sw.WriteLine(TextBoxMsgToEncrypt.Text); // Write message
            string hashedMsg = Hash(TextBoxMsgToEncrypt.Text, hashMode);
            string encryptedHashedMsg = EncryptRSA(hashedMsg, privateKey);

            sw.WriteLine(encryptedHashedMsg); // Write encrypted hashed message
            sw.Close();
        }
        public void WriteSealToFile()
        {
            StreamWriter sw = new StreamWriter("seal.txt");
            string encryptedMessage = TextBoxEncryptedMsg.Text;
            string encryptedKey = TextBoxEncryptedKey.Text;
            string envelope = encryptedMessage + encryptedKey;
            string hashedEnvelope = Hash(envelope, hashMode);
            string encryptedHashedEnvelope = EncryptRSA(hashedEnvelope, privateKey);
            //sw.WriteLine(envelope);
            sw.WriteLine(encryptedMessage);//write cyphertext
            sw.WriteLine(encryptedKey);//write encrypted key    // Two of these are the envelope
            sw.WriteLine(encryptedHashedEnvelope);

            sw.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
