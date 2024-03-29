using System.Text;

namespace ExamProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Question question = new();

            bool value = true;

            while (value)
            {
                Console.WriteLine("Zəhmət olmasa birini seçin");
                Console.WriteLine("Sual əlavə et-1");
                Console.WriteLine("Suallara bax-2");
                Console.WriteLine("İmtahan ver-3");
                Console.WriteLine("Sual sil-4");
                Console.WriteLine("Proqramı bitir-5");

                int number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("Id daxil edin");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Sual daxil edin");
                    string text = Console.ReadLine();

                    Console.WriteLine("VariantA daxil edin");
                    string variantA = Console.ReadLine();

                    Console.WriteLine("VariantB daxil edin");
                    string variantB = Console.ReadLine();

                    
                    Console.WriteLine("VariantC daxil edin");
                    string variantC = Console.ReadLine();

                    Console.WriteLine("VariantD daxil edin");
                    string variantD = Console.ReadLine();

                    Console.WriteLine("Düzgün cavabı daxil edin");
                    char trueAns = Convert.ToChar(Console.ReadLine().ToLower());

                    Question addQuestion = new Question()
                    {
                        Id = id,
                        Text = text,
                        VariantA = variantA,
                        VariantB = variantB,
                        VariantC = variantC,
                        VariantD = variantD,
                        TrueAnswer = trueAns
                    };

                    question.CreateQuestion(addQuestion);

                    Console.Clear();
                }
                else if (number == 2)
                {
                    var questions = question.GetAllQuestion();

                    foreach (var item in questions)
                    {
                        Console.WriteLine($"{item.Id} {item.Text} {item.VariantA} {item.VariantB} {item.VariantC} {item.VariantD}");
                    }
                }
                else if (number == 3)
                {
                    var questions = question.GetAllQuestion();
                    question.StartExam(questions);
                }
                else if (number == 4)
                {
                    Console.WriteLine("Id daxil edin");
                    int id = Convert.ToInt32(Console.ReadLine());

                    question.DeleteQuestion(id);
                }
                else if (number == 5)
                {
                    value = false;
                }
            }
        }
    }

    class Question
    {
        List<Question> questionList = new List<Question>();

        public int Id { get; set; }
        public string Text { get; set; }
        public string VariantA { get; set; }
        public string VariantB { get; set; }
        public string VariantC { get; set; }
        public string VariantD { get; set; }
        public char TrueAnswer { get; set; }


        public void CreateQuestion(Question question)
        {
            questionList.Add(question);
        }

        public List<Question> GetAllQuestion()
        {
            return questionList;
        }

        public void DeleteQuestion(int id)
        {
            var existingQuestion = questionList.Find(x => x.Id == id);

            questionList.Remove(existingQuestion);
        }

        public void StartExam(List<Question> questions)
        {
            byte count = 0;
            foreach (var question in questions)
            {
                Console.WriteLine($"Sual 1: {question.Text}");
                Console.WriteLine($"A: {question.VariantA}");
                Console.WriteLine($"B: {question.VariantB}");
                Console.WriteLine($"C: {question.VariantC}");
                Console.WriteLine($"D: {question.VariantD}");

                char questionAnswer = Convert.ToChar(Console.ReadLine().ToLower());

                if (question.TrueAnswer == questionAnswer)
                {
                    count++;
                }

            }
            Console.WriteLine($"Siz {count} suala düzgün cavab verdiniz.");
        }
    }
}
