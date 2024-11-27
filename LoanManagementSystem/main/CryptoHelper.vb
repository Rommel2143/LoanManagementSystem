Imports System.Security.Cryptography
Imports System.Text

Public Class CryptoHelper
    ' AES-256 Encryption Function
    Dim key As String = "Magnaye2143" ' Replace with a robust 32-character key

    Public Function Encrypt(input As String) As String
        Dim aes As New AesManaged()
        aes.KeySize = 256
        aes.BlockSize = 128
        aes.Mode = CipherMode.CBC
        aes.Padding = PaddingMode.PKCS7

        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)) ' 256-bit key
        Dim ivBytes As Byte() = Encoding.UTF8.GetBytes("16BYTES-IV-HERE!") ' 128-bit IV (16 characters)

        aes.Key = keyBytes
        aes.IV = ivBytes

        Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
        Dim encryptedBytes As Byte()

        Using encryptor As ICryptoTransform = aes.CreateEncryptor()
            encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length)
        End Using

        Return Convert.ToBase64String(encryptedBytes)
    End Function

    ' AES-256 Decryption Function
    Public Function Decrypt(encryptedInput As String) As String
        Dim aes As New AesManaged()
        aes.KeySize = 256
        aes.BlockSize = 128
        aes.Mode = CipherMode.CBC
        aes.Padding = PaddingMode.PKCS7

        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)) ' 256-bit key
        Dim ivBytes As Byte() = Encoding.UTF8.GetBytes("16BYTES-IV-HERE!") ' 128-bit IV (16 characters)

        aes.Key = keyBytes
        aes.IV = ivBytes

        Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedInput)
        Dim decryptedBytes As Byte()

        Using decryptor As ICryptoTransform = aes.CreateDecryptor()
            decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)
        End Using

        Return Encoding.UTF8.GetString(decryptedBytes)
    End Function
End Class
