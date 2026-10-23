// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
//     Console.WriteLine("Дата формирования отчёта: 24.10.2026");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("     Конец программы");
//     Console.WriteLine("X_X");
// }


// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }

// PrintStudentCard("Егор", 18, "ИСП-253");
// PrintStudentCard("Валерия", 17, "ИСП-254");


// double baseAmount = 2000;
// double bonusPercent = 15;
// double averageGrade = 4.5;

// double result;

// if (IsEligibleForBonus(averageGrade)) {
//     result = CalculateScholarship(baseAmount, bonusPercent);
// } else {
//     result = CalculateScholarship(baseAmount, 0);
// }

// Console.WriteLine($"Итоговая стипендия: {result}");

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }


int[] grades = { 4, 5, 3, 5, 4 };

double average = CalculateAverageGrade(grades);
int fivesCount = CountFives(grades);

Console.WriteLine($"Средний балл: {average}");
Console.WriteLine($"Количество пятёрок: {fivesCount}");

double CalculateAverageGrade(int[] grades) {
    int sum = 0;
    foreach (int grade in grades) {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades) {
    int count = 0;
    foreach (int grade in grades) {
        if (grade == 5) {
            count++;
        }
    }
    return count;
}