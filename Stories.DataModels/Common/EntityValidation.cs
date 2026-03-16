namespace Stories.DataModels.Common
{
    public static class EntityValidation
    {
        public const int AuthorFirstNameMinLength = 1;
        public const int AuthorFirstNameMaxLength = 50;

        public const int AuthorLastNameMinLength = 1;
        public const int AuthorLastNameMaxLength = 100;
        
        public const int AuthorBiographyMaxLength = 10000;


        public const int BookTitleMinLength = 1;
        public const int BookTitleMaxLength = 100;

        public const int BookAnnotationMaxLength = 1000;
        public const int BookDescriptionMaxLength = 10000;


        public const int CategoryNameMinLength = 1;
        public const int CategoryNameMaxLength = 50;

    }
}
