using TextEncryptDecrypt;

namespace EncryptDecryptGUI
{
    struct EncryptDecryptData
    {
        public HashAlgorithm HashAlgorithm { get; set; }

        public string SourceText { get; set; }

        public string TargetText { get; set; }

        public string Password { get; set; }
    }
}
