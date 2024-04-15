namespace OOP.Delegate
{
    public class MyClass
    {
        Action myActionDelegate;
        Action<int, int, string, Student> myAction;

        Func<int, string, bool> myFunc;

        Predicate<int> Predicate;

        public static List<Student> Students = new List<Student>();

        public int MyProperty { get; set; }

        public delegate bool MyValidationDelegate(Student student);

        static MyValidationDelegate MyNameValidation = FirstNameIsNull;
        static MyValidationDelegate MyNameLengthValidation = FirstNameMinLength;
        static MyValidationDelegate AgeCannotNegativeValidation = IsAgeNegative;


        public static void MyCustomAddMethod(Student student)
        {
            bool result = ValidationHandler(student,
                MyNameValidation,
                MyNameLengthValidation,
                AgeCannotNegativeValidation);

            if (result)
            {
                Students.Add(student);
            }
            else
            {
                Console.WriteLine("Məlumatları düzgün daxil edin");
            }

            return;
        }


        public static bool FirstNameIsNull(Student student)
        {
            return !string.IsNullOrEmpty(student.FirstName);
        }

        public static bool FirstNameMinLength(Student student)
        {
            return student.FirstName.Length > 2;
        }

        public static bool IsAgeNegative(Student student)
        {
            return student.Age > 0;
        }

        public static bool ValidationHandler(Student student, params MyValidationDelegate[] validationDelegates)
        {
            foreach (var validation in validationDelegates)
            {
                if (!validation(student))
                    return false;
            }
            return true;
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public sbyte Age { get; set; }
    }
}
