Imports System.Security.Cryptography
Imports System.Text

Public Class CryptoHelper
    Private Const Key As String = "lipa-cathedral-multipurpose-coop" ' Replace with a secure key management method

    ' AES-256 Encryption Function
    Public Function Encrypt(input As String) As String
        Try
            Using aes As New AesManaged()
                aes.KeySize = 256
                aes.BlockSize = 128
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(Key.PadRight(32).Substring(0, 32)) ' 256-bit key
                aes.Key = keyBytes

                ' Generate a random IV
                aes.GenerateIV()
                Dim ivBytes As Byte() = aes.IV

                Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
                Dim encryptedBytes As Byte()

                Using encryptor As ICryptoTransform = aes.CreateEncryptor()
                    encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length)
                End Using

                ' Combine IV and encrypted data
                Dim resultBytes As Byte() = ivBytes.Concat(encryptedBytes).ToArray()
                Return Convert.ToBase64String(resultBytes)
            End Using
        Catch ex As Exception
            ' Handle or log encryption errors
            Throw New Exception("Encryption failed.", ex)
        End Try
    End Function

    ' AES-256 Decryption Function
    Public Function Decrypt(encryptedInput As String) As String
        Try
            Using aes As New AesManaged()
                aes.KeySize = 256
                aes.BlockSize = 128
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(Key.PadRight(32).Substring(0, 32)) ' 256-bit key
                aes.Key = keyBytes

                Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedInput)

                ' Extract IV and encrypted data
                Dim ivBytes As Byte() = encryptedBytes.Take(16).ToArray() ' First 16 bytes are the IV
                Dim cipherBytes As Byte() = encryptedBytes.Skip(16).ToArray() ' Remaining bytes are the ciphertext

                aes.IV = ivBytes

                Dim decryptedBytes As Byte()

                Using decryptor As ICryptoTransform = aes.CreateDecryptor()
                    decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length)
                End Using

                Return Encoding.UTF8.GetString(decryptedBytes)
            End Using
        Catch ex As Exception
            ' Handle or log decryption errors
            Throw New Exception("Decryption failed.", ex)
        End Try
    End Function
End Class
