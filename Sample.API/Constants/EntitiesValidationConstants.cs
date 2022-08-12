namespace Sample.API.Constants
{
    public static class EntitiesValidationConstants
    {

        public const string PessoaNomeMinimumLengthMessage = "Name Length must be at least 2";
        public const string PessoaNomeMaximumLengthMessage = "Name Length can not be longer than 256";
        public const string PessoaNomePatternMessage = "Name must contain only letters and spaces";
        public const string PessoaNomeNullMessage = "Name can not be null";

        public const int PessoaNomeMinimumLength = 2;
        public const int PessoaNomeMaximumLength = 256;
        public const string PessoaNomePattern = @"^([A-zÀÁÂÃÉÈÊÓÒÔÕÚÙÛÍÌÇçîáàãâéèêóòõôúùûíìî\s])+$";


    }
}
