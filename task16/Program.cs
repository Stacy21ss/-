// Написать программу которая меняет символы в тексте
string text = "Врачи-рентгенологи в Москве с помощью нейросетей проанализировали более 100 тыс. маммографий с начала года. Об этом в четверг сообщила журналистам заместитель мэра столицы по вопросам социального развития Анастасия Ракова.";
string Replace (string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newtext = Replace (text, 'с', 'С');
Console.WriteLine(newtext);
