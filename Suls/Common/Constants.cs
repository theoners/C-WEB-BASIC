namespace Suls.Common
{
    public static class Constant
    {

        public static class AppsConstant
        {
            public const string ConnectionString = "Server=ASUS\\SQLEXPRESS;Database=Suls;Integrated Security=True;";
        }

        public static class UserConstant
        {
            public const int UsernameMaxLength = 20;
            public const int UsernameMinLength = 5;

            public const int PasswordMaxLength = 20;
            public const int PasswordMinLength = 6;


        }

        public static class ProblemConstant
        {
            public const int NameMaxLength = 20;
            public const int NameMinLength = 5;

            public const int PointsMaxLength = 300;
            public const int PointsMinLength = 50;


        }

        public static class SubmissionConstant
        {
            public const int CodeMaxLength = 800;
            public const int CodeMinLength = 30;

            public const int AchievedResultMaxLength = 300;
            public const int AchievedResultMinLength = 0;
        }

    }


}
