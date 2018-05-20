using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading;
namespace Client02
{
    public partial class Form1 : Form
    {
        public byte[] bobPublicKey;
        public byte[] bobKey;

        public string dt=DateTime.Now.ToString();
        Socket client;
        EndPoint ep;
        byte[] nhanLength, nhanPublicKey, nhanSKey,nhanspecKey;
        int sec = 0;
        AES256 aes = new AES256();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public byte[] generatePublicKey()
        {
            using (ECDiffieHellmanCng bob = new ECDiffieHellmanCng())
            {
                bob.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                bob.HashAlgorithm = CngAlgorithm.Sha256;
                bobPublicKey = bob.PublicKey.ToByteArray();
                byte[] a = bobPublicKey;
                return a;
            }
        }

        public byte[] secretKey(byte[] alicePublicKey)
        {
            bobKey = new byte[1024];
            using (ECDiffieHellmanCng bob = new ECDiffieHellmanCng())
            {
                CngKey k = CngKey.Import(alicePublicKey, CngKeyBlobFormat.EccPublicBlob);
                bobKey = bob.DeriveKeyMaterial(k);
                byte[] a = bobKey;
                return a;
            }
        }

        public void BobKey()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ep = ipep;

            byte[] publicKey = generatePublicKey();
            int x = publicKey.Length;
            byte[] length = BitConverter.GetBytes(x);
            client.SendTo(length, ep);
            client.SendTo(publicKey, ep);
            txtAlicePubKey.Text = Convert.ToBase64String(publicKey);

            nhanLength = new byte[100];
            int recLength = client.ReceiveFrom(nhanLength, ref ep);
            int y = BitConverter.ToInt32(nhanLength, 0);


            nhanPublicKey = new byte[y];
            int recPublicKey = client.ReceiveFrom(nhanPublicKey, ref ep);
            byte[] a = nhanPublicKey;

            nhanSKey = new byte[1024];
            int recKey = client.ReceiveFrom(nhanSKey, ref ep);
            string nhanKey = Encoding.ASCII.GetString(nhanSKey, 0, recKey);
            int count = (Encoding.ASCII.GetByteCount(nhanKey));

            string publicKey01 = Encoding.ASCII.GetString(nhanPublicKey, 0, recPublicKey);
            int count1 = (Encoding.ASCII.GetByteCount(publicKey01));
            txtBobPubKey.Text = Convert.ToBase64String(nhanPublicKey, 0, count1);


            byte[] secretKey02 = secretKey(nhanPublicKey);
            txtKey.Text = Convert.ToBase64String(nhanSKey, 0, count);

            client.Close();
        }

        void NhanDL()
        {
            try
            {
                if (txtIp.Text == "" || txtRemote.Text == "" || txtLocal.Text == "")
                {
                    MessageBox.Show("nhap du lieu day du");
                }
                else
                {
                    UdpClient nhandulieu = new UdpClient(int.Parse(txtLocal.Text));
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
                    while (true)
                    {
                        byte[] data = new byte[1024 * 24];
                        data = nhandulieu.Receive(ref ipe);
                        string s = Encoding.UTF8.GetString(data);
                        if (s.Trim().ToUpper().Equals("QUIT"))
                            break;
                        string[] arrString = s.Split(';');
                        string encryptedText = arrString[0];
                        string dt = arrString[1];
                        string md5EncryptedText = arrString[2];
                        string _a = arrString[3];
                        string paddingValue = arrString[4];

                        string hashEncryptedText = MD5.HashMd5(encryptedText);
                        if (md5EncryptedText == hashEncryptedText)
                        {
                            richTextBox1.Invoke((MethodInvoker)delegate ()
                            {
                                richTextBox1.Text+="\nĐã nhận: " + encryptedText;

                            });
                            txtfinalText.Text = s;
                            txtKey01.Text = _a;
                            txtEncrypted.Text = encryptedText;
                            string rawText = Decrypted(encryptedText, dt);
                            txtDecrypt.Text = rawText.Substring(0, rawText.Length - int.Parse(paddingValue));
                        }

                        else
                        {
                            richTextBox1.Invoke((MethodInvoker)delegate ()
                            {
                               richTextBox1.Text+= "\nĐã nhận: Noi dung da bi thay doi.";

                            });
                        }
                    }
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            UdpClient guidulieu = new UdpClient();
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(txtIp.Text), int.Parse(txtRemote.Text));

            byte[] data = new byte[1024 * 24];
            data = Encoding.UTF8.GetBytes(txtfinalText.Text);
            guidulieu.Send(data, data.Length, ipe);


            richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text+= "\n Đã gửi:" + txtMessage.Text;
            });
            txtMessage.Clear();
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            Thread thr = new Thread(new ThreadStart(NhanDL));
            thr.Start();
            MessageBox.Show("Connected successfully", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Information);

         
        }

        public string Encrypted(string rawString, string keyText, string iv)
        {
            string rawText = txtPadding.Text;
            string key = keyText;
            string encryptedText = aes.Encrypt(rawText, key, dt);
            return encryptedText;
        }

        public string Decrypted(string textEncrypted, string Time)
        {
            string encryptedText = textEncrypted;
            string key = txtKey01.Text;
            string decryptedText = aes.Decrypt(textEncrypted, key, Time);
            return decryptedText;
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            dt = MD5.HashMd5(DateTime.Now.ToString());
            txtKey01.Text = randomString32byte(16);
            string _a = txtKey01.Text;
            string valuePadding = paddingData().ToString();
            string encryptedText = Encrypted(txtPadding.Text, _a, dt);
            string MD5encryptedText = MD5.HashMd5(encryptedText);
            txtEncrypted.Text = encryptedText;
            string finalText = encryptedText + ";" + dt + ";" + MD5encryptedText + ";" + _a + ";" + valuePadding;
            txtfinalText.Text = finalText;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtIp.Text = "127.0.0.1";
            txtLocal.Text = "90";
            txtRemote.Text = "60";
        }

        private int paddingData()
        {
            string Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUniversalTime().ToString("yyyyMMddHHmmssffff");
            string MHtimeStamp = MD5.HashMd5(Timestamp);
            int soByteCuaChuoi = UTF8Encoding.UTF8.GetByteCount(txtMessage.Text);
            int i = 0;
            string tmpTime = string.Empty;
            if (soByteCuaChuoi % 16 != 0)
            {
                i = 1;
                int length = soByteCuaChuoi;
                while (length % 16 != 0)
                {
                    tmpTime = MHtimeStamp.Substring(0, i);
                    length = length + 1;
                    i++;
                }

            }
            txtPadding.Text = txtMessage.Text + tmpTime;
            //Trả về giá trị số padding cần thêm
            return i - 1;
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            dt = MD5.HashMd5(DateTime.Now.ToString());
            txtKey01.Text = randomString32byte(16);
            string _a = txtKey01.Text;
            string valuePadding = paddingData().ToString();
            string encryptedText = Encrypted(txtPadding.Text, _a, dt);
            string MD5encryptedText = MD5.HashMd5(encryptedText);
            txtEncrypted.Text = encryptedText;
            string finalText = encryptedText + ";" + dt + ";" + MD5encryptedText + ";" + _a + ";" + valuePadding;
            txtfinalText.Text = finalText;
        }

        private void btnEncryptNoise_Click(object sender, EventArgs e)
        {
            dt = MD5.HashMd5(DateTime.Now.ToString());
            txtKey01.Text = randomString32byte(16);
            string _a = txtKey01.Text;
            string valuePadding = paddingData().ToString();
            string encryptedText = Encrypted(txtPadding.Text, _a, dt);
            string a = encryptedText;
            int length = encryptedText.Length;
            Random r = new Random();
            int randomPos = r.Next(0, length + 1);
            string stringDauDenRandomPos = a.Substring(0, randomPos);
            string kyTuCuoiCuaText = a.Substring(randomPos);
            string textChanged = stringDauDenRandomPos + PhatSinhKyTuNgauNhien() + kyTuCuoiCuaText;
            string MD5encryptedText = MD5.HashMd5(textChanged);
            txtEncrypted.Text = encryptedText;
            string finalText = encryptedText + ";" + dt + ";" + MD5encryptedText + ";" + _a + ";" + valuePadding;
            txtfinalText.Text = finalText;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec + 1;
            lbTimer.Text = sec.ToString();
            if (sec == 10)
            {
                timer1.Stop();
                MessageBox.Show("Time Out. Please change another key!!!", "CLIENT-02");
                sec = 0;
                BobKey();
                txtEncrypted.Clear();
                txtfinalText.Clear();
            }
        }
        public void KhoiTaoTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BobKey();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            sec = 0;
            KhoiTaoTimer();
            timer1.Start();
        }

        public static string PhatSinhKyTuNgauNhien()
        {
            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            return chars[i].ToString();
        }
        

        private string randomString32byte(int size)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 122))); //Limit: chu thuong, chu hoa
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
