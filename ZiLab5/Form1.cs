using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES256Encryption
{
    public partial class MainForm : Form
    {
        private byte[] key; // Ключ будет вычисляться по хешированию
        private readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456"); // 128 бит (16 байт)

        public MainForm()
        {
            InitializeComponent();
            key = new byte[32]; // Инициализация ключа размером 256 бит (32 байта)
        }

        // Метод хеширования ключа до нужного размера
        private byte[] GetKeyFromUserInput(string userKey)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(userKey); // Преобразуем ключ в байты
                return sha256.ComputeHash(keyBytes); // Хешируем ключ до 256 бит (32 байта)
            }
        }

        // Метод шифрования
        private string Encrypt(string plainText)
        {
            if (key.Length != 32)
            {
                MessageBox.Show("Ключ должен быть длиной 32 байта.");
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

        // Метод расшифровки
        private string Decrypt(string cipherText)
        {
            if (key.Length != 32)
            {
                MessageBox.Show("Ключ должен быть длиной 32 байта.");
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
                MessageBox.Show("Ошибка при расшифровке: " + ex.Message);
                return string.Empty;
            }
        }

        // Обработчик кнопки шифрования
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем ключ из текстового поля
                string userKey = txtKey.Text;
                key = GetKeyFromUserInput(userKey); // Хешируем ключ до 32 байт

                string plainText = txtInput.Text;
                string encryptedText = Encrypt(plainText);
                txtOutput.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при шифровании: " + ex.Message);
            }
        }

        // Обработчик кнопки расшифровки
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем ключ из текстового поля
                string userKey = txtKey.Text;
                key = GetKeyFromUserInput(userKey); // Хешируем ключ до 32 байт

                string cipherText = txtInput.Text;
                string decryptedText = Decrypt(cipherText);
                txtOutput.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расшифровке: " + ex.Message);
            }
        }
    }
}
