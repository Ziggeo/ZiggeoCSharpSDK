using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoAuth {

    protected Ziggeo application;

    public ZiggeoAuth(Ziggeo application) {
        this.application = application;
    }

    /**
     * Generate RSA 
    */ 
    public string Generate(JObject initial_options) {
        var options = new JObject(
            new JProperty("application_token", this.application.token),
            new JProperty("nonce", _GenerateNonce())
        );

        var mergeSettings = new JsonMergeSettings {
            MergeArrayHandling = MergeArrayHandling.Replace
        };

        options.Merge(initial_options, mergeSettings);

        return _Encrypt(options.ToString(Formatting.None) );
    }

    /**
     * Main Encrpion Method 
    */
    protected string _Encrypt(string JSONString) {
        try {

            using (MD5 md5Hash = MD5.Create()) {

                byte[] hash = _GetMd5Hash(md5Hash, this.application.encryption_key);

                // Generate Key and IV for AES
                byte[] Key = hash;
                byte[] IV = new byte[8];
                using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider()) {
                    // Fill the array with a random value.
                    rngCsp.GetBytes(IV);
                }

                var resultIV = _ByteToHexString(IV);

                var hexKey = _ByteToHexString(Key);
                Key = _StringToByteArray(hexKey);
                IV = _StringToByteArray(resultIV); 

                // Encrypt the string to an array of bytes
                byte[] cipher = _RSA(JSONString, Key, IV);

                return resultIV + _ByteToHexString(cipher);
            }
        }
        catch (Exception e) {
            Console.WriteLine("Error: {0}", e.Message);
            return "Unexpected Error Ocurred";
        }
    }


    /**
     * Generate RijndaelManaged algorithm from provided string, key and IV
     */
    protected byte[] _RSA(string plainText, byte[] Key, byte[] IV) {
        // Check argunents
        if (plainText == null || plainText.Length <= 0) {
            throw new ArgumentNullException("plainText");
        }

        if (Key == null || Key.Length <= 0) {
            throw new ArgumentNullException("Key");
        }

        if (IV == null || IV.Length <= 0) {
            throw new ArgumentNullException("IV");
        }

        byte[] encrypted = null;

        using (RijndaelManaged symmetricKey = new RijndaelManaged()) {
            symmetricKey.KeySize = 256;
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.IV = IV;
            symmetricKey.Key = Key;
            symmetricKey.Padding = PaddingMode.PKCS7;

            // Create a decryptor to perform the stream transform.
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(symmetricKey.Key, symmetricKey.IV);

            // Create the streams used for encryption
            using (MemoryStream msEncrypt = new MemoryStream()) {

                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {


                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {

                        // Write all data to the strean
                        swEncrypt.Write(plainText);
                    }

                    encrypted = msEncrypt.ToArray();
                    return encrypted;
                }
            }

        }
    }

    /**
    * Generate random number
    */
    private string _GenerateNonce() {
        var time = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        Random rnd = new Random();
        return Convert.ToString(Convert.ToUInt64(time)) + rnd.Next(2147483647);
    }


    /**
    * Generate MD5 hash code
    */
    protected byte[] _GetMd5Hash(MD5 md5Hash, string input) {
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        return data;
    }


    /**
    * Convert Bytes to HEX string
    */
    protected string _ByteToHexString(byte[] input) {
        StringBuilder sBuilder = new StringBuilder();

        for (int i = 0; i < input.Length; i++) {
            sBuilder.Append(input[i].ToString("x2"));
        }

        return sBuilder.ToString();

    }

    /**
     * Get bytes from provided input text
    */
    protected byte[] _StringToByteArray(string str) {
        System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
        return encoding.GetBytes(str);
    }


    /**
    * Return byte from Provided hex 
    */
    protected byte[] _HexToByteArray(string hex) {
        return Enumerable.Range(0, hex.Length)
                            .Where(x => x % 2 == 0)
                            .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                            .ToArray();
    }

}