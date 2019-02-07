//Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
// в) отсортировать список по возрасту студента;
// г) *отсортировать список по курсу и возрасту студента;

namespace lev1les6t3
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public string department;
        public int course;
        public int group;
        public string city;
        public int age;
        public Student(string lastName, string firstName, string university, string faculty, string department, int course, int group, string city, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.group = group;
            this.city = city;
            this.age = age;
        }
    }
}
