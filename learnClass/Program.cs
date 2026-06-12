namespace learnClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection
            Question[] questions =
            [
                new Question(
                    questionText: "What is the capital of France?", 
                    options: ["A. Paris", "B. London", "C. Rome", "D. Berlin"],
                    answer: "A. Paris"),
                new Question(
                    questionText: "What is the largest planet in our solar system?", 
                    options: ["A. Earth", "B. Jupiter", "C. Saturn", "D. Mars"], 
                    answer: "B. Jupiter"),
                new Question(
                    questionText: "What is the chemical symbol for water?", 
                    options: ["A. H2O", "B. CO2", "C. O2", "D. NaCl"], 
                    answer: "A. H2O"),
            ];

            foreach (var question in questions)
            {
                question.DisplayQuestion();
                Console.WriteLine();

                Console.Write("Your answer: ");
                string? userAnswer = Console.ReadLine();
                if (question.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }

            Question.GetRandomQuestion(questions);


        }

    }

    public class Question
    {
        //propertis
        private int? Id { get; set; }
        private string? QuestionText { get; set; }
        private string[] Options { get; set; }
        private string? Answer { get; set; }

        //Constractor
        public Question(string questionText, string[] options, string answer)
        {
            Random random = new Random();
            this.Id = random.Next(1, 1000);
            this.QuestionText = questionText;
            this.Options = options;
            this.Answer = answer;
        }
        //Method
        public void DisplayQuestion()
        {
            Console.WriteLine($"Question: {this.QuestionText}");
            foreach (var option in this.Options)
            {
                Console.WriteLine(option);
            }
        }   

        public bool CheckAnswer(string? userAnswer)
        {
            if(string.IsNullOrEmpty(userAnswer)) return false;
            return userAnswer.Equals(this.Answer, StringComparison.OrdinalIgnoreCase);
        }
        //static method
        public static void GetRandomQuestion(Question[] questions)
        {
            Random random = new Random();
            questions[random.Next(questions.Length)].DisplayQuestion();

        } 

        
    }


}