namespace Sample.API.Constants
{
    public static class EntitiesValidationConstants
    {

        public const string PessoaNomeMinimumLengthMessage = "Name Length must be at least 2";
        public const string PessoaNomeMaximumLengthMessage = "Name Length can not be longer than 256";
        public const string PessoaNomePatternMessage = "Name must contain only letters and spaces";
        public const string PessoaIdadeMinimumLenghtMessage = "Idade must be greater than zero";
        public const string PessoaIdadeMaximumLenghtMessage = "Are you really that old?";
        public const string PessoaIdadeNullMessage = "Idade must be a value between 1 and 200";
        public const string PessoaEmailNullMessage = "E-Mail can not be null";
        public const string PessoaEmailPatternMessage = "E-Mail do not corresponding the expected pattern";
        public const string PessoaNomeNullMessage = "Name can not be null";

        public const int PessoaNomeMinimumLength = 2;
        public const int PessoaNomeMaximumLength = 256;
        public const int PessoaIdadeMinimunLength = 0;
        public const int PessoaIdadeMaximumLength = 200;
        public const string PessoaNomePattern = @"^([A-zÀÁÂÃÉÈÊÓÒÔÕÚÙÛÍÌÇçîáàãâéèêóòõôúùûíìî\s])+$";


    }
}
