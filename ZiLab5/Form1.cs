using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES256Encryption
{
    public partial class MainForm : Form
    {
        private byte[] key; // ���� ����� ����������� �� �����������
        private readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456"); // 128 ��� (16 ����)

        public MainForm()
        {
            InitializeComponent();
            key = new byte[32]; // ������������� ����� �������� 256 ��� (32 �����)
        }

        // ����� ����������� ����� �� ������� �������
        private byte[] GetKeyFromUserInput(string userKey)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(userKey); // ����������� ���� � �����
                return sha256.ComputeHash(keyBytes); // �������� ���� �� 256 ��� (32 �����)
            }
        }

        // ����� ����������
        private string Encrypt(string plainText)
        {
            if (key.Length != 32)
            {
                MessageBox.Show("���� ������ ���� ������ 32 �����.");
                return string.Empty;
            }

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] inputBuffer = Encoding.UTF8.GetBytes(plainText);
                byte[] encrypted = encryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
                return Convert.ToBase64String(encrypted);
            }
        }

        // ����� �����������
        private string Decrypt(string cipherText)
        {
            if (key.Length != 32)
            {
                MessageBox.Show("���� ������ ���� ������ 32 �����.");
                return string.Empty;
            }

            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;
                    aesAlg.Mode = CipherMode.CBC;
                    aesAlg.Padding = PaddingMode.PKCS7;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    byte[] cipherBytes = Convert.FromBase64String(cipherText);
                    byte[] decrypted = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                    return Encoding.UTF8.GetString(decrypted);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� �����������: " + ex.Message);
                return string.Empty;
            }
        }

        // ���������� ������ ����������
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� ���� �� ���������� ����
                string userKey = txtKey.Text;
                key = GetKeyFromUserInput(userKey); // �������� ���� �� 32 ����

                string plainText = txtInput.Text;
                string encryptedText = Encrypt(plainText);
                txtOutput.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ����������: " + ex.Message);
            }
        }

        // ���������� ������ �����������
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� ���� �� ���������� ����
                string userKey = txtKey.Text;
                key = GetKeyFromUserInput(userKey); // �������� ���� �� 32 ����

                string cipherText = txtInput.Text;
                string decryptedText = Decrypt(cipherText);
                txtOutput.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� �����������: " + ex.Message);
            }
        }
    }
}
